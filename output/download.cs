using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Reflection;
using runnerDotNet;
namespace runnerDotNet
{
	public partial class GlobalController : BaseController
	{
		public XVar download()
		{
			try
			{
				dynamic _connection = null, absFileName = null, ctype = null, data = XVar.Array(), ext = null, field = null, fieldsArr = XVar.Array(), filename = null, keys = XVar.Array(), keysArr = XVar.Array(), qResult = null, sql = null, strfilesize = null, table = null, where = null;
				table = XVar.Clone(MVCFunctions.postvalue(new XVar("table")));
				GlobalVars.strTableName = XVar.Clone(CommonFunctions.GetTableByShort((XVar)(table)));
				if(XVar.Pack(!(XVar)(CommonFunctions.checkTableName((XVar)(table)))))
				{
					MVCFunctions.Echo(new XVar(0));
					return MVCFunctions.GetBuferContentAndClearBufer();
				}
				Assembly.GetExecutingAssembly().GetType(MVCFunctions.Concat("runnerDotNet.", MVCFunctions.Concat("", table, ""),
					"_Variables")).InvokeMember("Apply", BindingFlags.InvokeMethod, null, null, null);
				if((XVar)(!(XVar)(CommonFunctions.isLogged()))  || (XVar)(!(XVar)(CommonFunctions.CheckSecurity((XVar)(XSession.Session[MVCFunctions.Concat("_", GlobalVars.strTableName, "_OwnerID")]), new XVar("Search")))))
				{
					MVCFunctions.HeaderRedirect(new XVar("login"));
					return MVCFunctions.GetBuferContentAndClearBufer();
				}
				field = XVar.Clone(MVCFunctions.postvalue(new XVar("field")));
				if(XVar.Pack(!(XVar)(GlobalVars.gSettings.checkFieldPermissions((XVar)(field)))))
				{
					return MVCFunctions.GetBuferContentAndClearBufer();
				}
				fieldsArr = XVar.Clone(GlobalVars.gSettings.getFieldsList());
				foreach (KeyValuePair<XVar, dynamic> f in fieldsArr.GetEnumerator())
				{
					dynamic fViewFormat = null;
					fViewFormat = XVar.Clone(GlobalVars.gSettings.getViewFormat((XVar)(f.Value)));
					if((XVar)(field == f.Value)  && (XVar)((XVar)((XVar)(fViewFormat != Constants.FORMAT_FILE)  && (XVar)(fViewFormat != Constants.FORMAT_AUDIO))  && (XVar)(fViewFormat != Constants.FORMAT_VIDEO)))
					{
						MVCFunctions.Echo(new XVar(0));
						return MVCFunctions.GetBuferContentAndClearBufer();
					}
				}
				_connection = XVar.Clone(GlobalVars.cman.byTable((XVar)(GlobalVars.strTableName)));
				keysArr = XVar.Clone(GlobalVars.gSettings.getTableKeys());
				keys = XVar.Clone(XVar.Array());
				foreach (KeyValuePair<XVar, dynamic> k in keysArr.GetEnumerator())
				{
					keys.InitAndSetArrayItem(MVCFunctions.postvalue((XVar)(MVCFunctions.Concat("key", k.Key + 1))), k.Value);
				}
				where = XVar.Clone(CommonFunctions.KeyWhere((XVar)(keys)));
				if(GlobalVars.gSettings.getAdvancedSecurityType() == Constants.ADVSECURITY_VIEW_OWN)
				{
					where = XVar.Clone(CommonFunctions.whereAdd((XVar)(where), (XVar)(CommonFunctions.SecuritySQL(new XVar("Search"), (XVar)(GlobalVars.strTableName)))));
				}
				sql = XVar.Clone(GlobalVars.gQuery.gSQLWhere((XVar)(where)));
				qResult = XVar.Clone(_connection.query((XVar)(sql)));
				if(XVar.Pack(!(XVar)(qResult)))
				{
					return MVCFunctions.GetBuferContentAndClearBufer();
				}
				data = XVar.Clone(qResult.fetchAssoc());
				if(XVar.Pack(!(XVar)(data)))
				{
					return MVCFunctions.GetBuferContentAndClearBufer();
				}
				filename = XVar.Clone(data[field]);
				ext = XVar.Clone(MVCFunctions.substr((XVar)(filename), (XVar)(MVCFunctions.strlen((XVar)(filename)) - 4)));
				ctype = XVar.Clone(CommonFunctions.getContentTypeByExtension((XVar)(ext)));
				if(XVar.Pack(GlobalVars.gSettings.isAbsolute((XVar)(field))))
				{
					absFileName = XVar.Clone(MVCFunctions.Concat(GlobalVars.gSettings.getUploadFolder((XVar)(field)), filename));
				}
				else
				{
					absFileName = XVar.Clone(MVCFunctions.getabspath((XVar)(MVCFunctions.Concat(GlobalVars.gSettings.getUploadFolder((XVar)(field)), filename))));
				}
				if(XVar.Pack(!(XVar)(MVCFunctions.file_exists((XVar)(absFileName)))))
				{
					MVCFunctions.returnError404();
					MVCFunctions.Echo(new XVar(""));
					return MVCFunctions.GetBuferContentAndClearBufer();
				}
				strfilesize = XVar.Clone(MVCFunctions.filesize((XVar)(absFileName)));
				if(XVar.Equals(XVar.Pack(strfilesize), XVar.Pack(false)))
				{
					MVCFunctions.returnError404();
					MVCFunctions.Echo(new XVar(""));
					return MVCFunctions.GetBuferContentAndClearBufer();
				}
				MVCFunctions.Header((XVar)(MVCFunctions.Concat("Content-Type: ", ctype)));
				MVCFunctions.Header((XVar)(MVCFunctions.Concat("Content-Disposition: attachment;Filename=\"", filename, "\"")));
				MVCFunctions.Header("Cache-Control", "private");
				MVCFunctions.SendContentLength((XVar)(strfilesize));
				MVCFunctions.printfile((XVar)(absFileName));
				return MVCFunctions.GetBuferContentAndClearBufer();
			}
			catch(RunnerRedirectException ex)
			{ return Redirect(ex.Message); }
		}
	}
}
