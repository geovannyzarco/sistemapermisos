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
	public partial class INGRESAR_PERMISOController : BaseController
	{
		public ActionResult export()
		{
			try
			{
				dynamic pageObject = null, strtablename = null, var_params = XVar.Array();
				XTempl xt;
				MVCFunctions.Header("Expires", "Thu, 01 Jan 1970 00:00:01 GMT");
				INGRESAR_PERMISO_Variables.Apply();
				if(XVar.Pack(!(XVar)(Security.processPageSecurity((XVar)(strtablename), new XVar("P")))))
				{
					return MVCFunctions.GetBuferContentAndClearBufer();
				}
{

TLayout t_layout = null;

t_layout = new TLayout(new XVar("export_bootstrap"), new XVar("OfficeOffice"), new XVar("MobileOffice"));
t_layout.version = 3;
	t_layout.bootstrapTheme = "default";
			t_layout.customCssPageName = "INGRESAR_PERMISO_export";
t_layout.blocks["top"] = XVar.Array();
t_layout.containers["page"] = XVar.Array();
t_layout.containers["page"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "page_1" ));
t_layout.containers["page_1"] = XVar.Array();
t_layout.containers["page_1"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "panel" ));
t_layout.containers["panel"] = XVar.Array();
t_layout.containers["panel"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "header" ));
t_layout.containers["header"] = XVar.Array();
t_layout.containers["header"].Add(new XVar("name", "exportheader", "block", "exportheader", "substyle", 1  ));

t_layout.skins["header"] = "";


t_layout.containers["panel"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "body" ));
t_layout.containers["body"] = XVar.Array();
t_layout.containers["body"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "range" ));
t_layout.containers["range"] = XVar.Array();
t_layout.containers["range"].Add(new XVar("name", "bsexprange", "block", "range_block", "substyle", 1  ));

t_layout.skins["range"] = "";


t_layout.containers["body"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "fields" ));
t_layout.containers["fields"] = XVar.Array();
t_layout.containers["fields"].Add(new XVar("name", "bsexportchoosefields", "block", "choosefields", "substyle", 1  ));

t_layout.skins["fields"] = "";


t_layout.containers["body"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "fields_1" ));
t_layout.containers["fields_1"] = XVar.Array();
t_layout.containers["fields_1"].Add(new XVar("name", "bsexportformat", "block", "exportformat", "substyle", 1  ));

t_layout.skins["fields_1"] = "";


t_layout.containers["body"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "fields_2" ));
t_layout.containers["fields_2"] = XVar.Array();
t_layout.containers["fields_2"].Add(new XVar("name", "bsexpoutput", "block", "", "substyle", 1  ));

t_layout.skins["fields_2"] = "";


t_layout.containers["body"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "buttons" ));
t_layout.containers["buttons"] = XVar.Array();
t_layout.containers["buttons"].Add(new XVar("name", "bsexpbuttons", "block", "exportbuttons", "substyle", 2  ));

t_layout.skins["buttons"] = "";


t_layout.skins["body"] = "";


t_layout.skins["panel"] = "";


t_layout.skins["page_1"] = "";


t_layout.skins["page"] = "";

t_layout.blocks["top"].Add("page");
GlobalVars.page_layouts["INGRESAR_PERMISO_export"] = t_layout;


}

				xt = XVar.UnPackXTempl(new XTempl());
				var_params = XVar.Clone(XVar.Array());
				var_params.InitAndSetArrayItem(CommonFunctions.postvalue_number(new XVar("id")), "id");
				var_params.InitAndSetArrayItem(xt, "xt");
				var_params.InitAndSetArrayItem(GlobalVars.strTableName, "tName");
				var_params.InitAndSetArrayItem(Constants.PAGE_EXPORT, "pageType");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("page")), "pageName");
				if((XVar)(!(XVar)(GlobalVars.eventObj.exists(new XVar("ListGetRowCount"))))  && (XVar)(!(XVar)(GlobalVars.eventObj.exists(new XVar("ListQuery")))))
				{
					var_params.InitAndSetArrayItem(false, "needSearchClauseObj");
				}
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("exportFields")), "selectedFields");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("type")), "exportType");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("a")), "action");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("records")), "records");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("selection")), "selection");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("delimiter")), "csvDelimiter");
				if(MVCFunctions.postvalue(new XVar("txtformatting")) == "raw")
				{
					var_params.InitAndSetArrayItem(true, "useRawValues");
				}
				var_params.InitAndSetArrayItem(ExportPage.readModeFromRequest(), "mode");
				GlobalVars.pageObject = XVar.Clone(new ExportPage((XVar)(var_params)));
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
