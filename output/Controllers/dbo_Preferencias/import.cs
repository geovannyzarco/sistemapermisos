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
	public partial class dbo_PreferenciasController : BaseController
	{
		public ActionResult import()
		{
			try
			{
				dynamic id = null, pageObject = null, strtablename = null, var_params = XVar.Array();
				XTempl xt;
				MVCFunctions.Header("Expires", "Thu, 01 Jan 1970 00:00:01 GMT");
				Server.ScriptTimeout = 600;
				dbo_Preferencias_Variables.Apply();
				if(XVar.Pack(!(XVar)(Security.processPageSecurity((XVar)(strtablename), new XVar("I")))))
				{
					return MVCFunctions.GetBuferContentAndClearBufer();
				}
{

TLayout t_layout = null;

t_layout = new TLayout(new XVar("import_bootstrap"), new XVar("OfficeOffice"), new XVar("MobileOffice"));
t_layout.version = 3;
	t_layout.bootstrapTheme = "default";
			t_layout.customCssPageName = "dbo_Preferencias_import";
t_layout.blocks["top"] = XVar.Array();
t_layout.containers["page"] = XVar.Array();
t_layout.containers["page"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "panel" ));
t_layout.containers["panel"] = XVar.Array();
t_layout.containers["panel"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "header" ));
t_layout.containers["header"] = XVar.Array();
t_layout.containers["header"].Add(new XVar("name", "importheader", "block", "", "substyle", 1  ));

t_layout.skins["header"] = "";


t_layout.containers["panel"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "body" ));
t_layout.containers["body"] = XVar.Array();
t_layout.containers["body"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "message" ));
t_layout.containers["message"] = XVar.Array();
t_layout.containers["message"].Add(new XVar("name", "errormessage", "block", "", "substyle", 1  ));

t_layout.skins["message"] = "";


t_layout.containers["body"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "import" ));
t_layout.containers["import"] = XVar.Array();
t_layout.containers["import"].Add(new XVar("name", "importheader_text", "block", "", "substyle", 1  ));

t_layout.containers["import"].Add(new XVar("name", "importfields", "block", "", "substyle", 1  ));

t_layout.containers["import"].Add(new XVar("name", "import_rawtext_control", "block", "", "substyle", 1  ));

t_layout.containers["import"].Add(new XVar("name", "import_preview", "block", "", "substyle", 1  ));

t_layout.containers["import"].Add(new XVar("name", "import_process", "block", "", "substyle", 1  ));

t_layout.containers["import"].Add(new XVar("name", "import_results", "block", "", "substyle", 1  ));

t_layout.containers["import"].Add(new XVar("name", "importbuttons", "block", "", "substyle", 1  ));

t_layout.skins["import"] = "";


t_layout.skins["body"] = "";


t_layout.skins["panel"] = "";


t_layout.skins["page"] = "";

t_layout.blocks["top"].Add("page");
GlobalVars.page_layouts["dbo_Preferencias_import"] = t_layout;


}

				xt = XVar.UnPackXTempl(new XTempl());
				id = XVar.Clone(CommonFunctions.postvalue_number(new XVar("id")));
				id = XVar.Clone((XVar.Pack(id != XVar.Pack("")) ? XVar.Pack(id) : XVar.Pack(1)));
				var_params = XVar.Clone(XVar.Array());
				var_params.InitAndSetArrayItem(id, "id");
				var_params.InitAndSetArrayItem(xt, "xt");
				var_params.InitAndSetArrayItem(GlobalVars.strTableName, "tName");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("a")), "action");
				var_params.InitAndSetArrayItem(Constants.PAGE_IMPORT, "pageType");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("page")), "pageName");
				var_params.InitAndSetArrayItem(false, "needSearchClauseObj");
				var_params.InitAndSetArrayItem(GlobalVars.strOriginalTableName, "strOriginalTableName");
				if(var_params["action"] == "importPreview")
				{
					var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("importType")), "importType");
					var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("importText")), "importText");
					var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("useXHR")), "useXHR");
				}
				else
				{
					if(var_params["action"] == "importData")
					{
						var_params.InitAndSetArrayItem(MVCFunctions.my_json_decode((XVar)(MVCFunctions.postvalue(new XVar("importData")))), "importData");
					}
				}
				GlobalVars.pageObject = XVar.Clone(new ImportPage((XVar)(var_params)));
				GlobalVars.pageObject.init();
				GlobalVars.pageObject.process();
				ViewBag.xt = xt;
				return View(xt.GetViewPath());
			}
			catch(RunnerRedirectException ex)
			{ return Redirect(ex.Message); }
		}
	}
}
