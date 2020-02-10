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
	public static partial class GlobalSettings
	{
		public static void Apply()
		{
			GlobalVars.tdataGLOBAL = XVar.Clone(XVar.Array());
			XVar pages = CommonFunctions.types2pages( XVar.Clone(MVCFunctions.my_json_decode(new XVar("{\"changepwd\":[\"changepwd\"],\"changepwd_success\":[\"changepwd_success\"],\"login\":[\"login\"],\"menu\":[\"menu\"]}"))) );
			XVar defaultPages = XVar.Clone(MVCFunctions.my_json_decode(new XVar("{\"changepwd\":\"changepwd\",\"changepwd_success\":\"changepwd_success\",\"login\":\"login\",\"menu\":\"menu\"}")));
			GlobalVars.tdataGLOBAL.InitAndSetArrayItem(pages, ".pages");
			GlobalVars.tdataGLOBAL.InitAndSetArrayItem(defaultPages, ".defaultPages");
			GlobalVars.tables_data.InitAndSetArrayItem(GlobalVars.tdataGLOBAL, "<global>");
		}
	}

}
