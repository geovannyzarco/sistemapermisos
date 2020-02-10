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
	public partial class INGRESAR_COMPESADOController : BaseController
	{
		public ActionResult print()
		{
			try
			{
				dynamic pageObject = null, strtablename = null, var_params = XVar.Array();
				XTempl xt;
				CommonFunctions.add_nocache_headers();
				INGRESAR_COMPESADO_Variables.Apply();
				if(XVar.Pack(!(XVar)(Security.processPageSecurity((XVar)(strtablename), new XVar("P")))))
				{
					return MVCFunctions.GetBuferContentAndClearBufer();
				}
{

TLayout t_layout = null;

t_layout = new TLayout(new XVar("print_bootstrap"), new XVar("OfficeOffice"), new XVar("MobileOffice"));
t_layout.version = 3;
	t_layout.bootstrapTheme = "default";
			t_layout.customCssPageName = "INGRESAR_COMPESADO_print";
t_layout.blocks["top"] = XVar.Array();
t_layout.containers["pdf"] = XVar.Array();
t_layout.containers["pdf"].Add(new XVar("name", "printbuttons", "block", "printbuttons", "substyle", 1  ));

t_layout.skins["pdf"] = "";

t_layout.blocks["top"].Add("pdf");
t_layout.containers["master"] = XVar.Array();
t_layout.containers["master"].Add(new XVar("name", "masterinfo", "block", "mastertable_block", "substyle", 1  ));

t_layout.skins["master"] = "";

t_layout.blocks["top"].Add("master");
t_layout.containers["pageheader"] = XVar.Array();
t_layout.containers["pageheader"].Add(new XVar("name", "printheader", "block", "printheader", "substyle", 1  ));

t_layout.containers["pageheader"].Add(new XVar("name", "page_of_print", "block", "page_number", "substyle", 1  ));

t_layout.skins["pageheader"] = "";

t_layout.blocks["top"].Add("pageheader");
t_layout.containers["grid"] = XVar.Array();
t_layout.containers["grid"].Add(new XVar("name", "printgrid", "block", "grid_block", "substyle", 1  ));

t_layout.skins["grid"] = "";

t_layout.blocks["top"].Add("grid");
GlobalVars.page_layouts["INGRESAR_COMPESADO_print"] = t_layout;


}

				xt = XVar.UnPackXTempl(new XTempl());
				var_params = XVar.Clone(XVar.Array());
				var_params.InitAndSetArrayItem(CommonFunctions.postvalue_number(new XVar("id")), "id");
				var_params.InitAndSetArrayItem(xt, "xt");
				var_params.InitAndSetArrayItem(Constants.PAGE_PRINT, "pageType");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("page")), "pageName");
				var_params.InitAndSetArrayItem(GlobalVars.strTableName, "tName");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("selection")), "selection");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("all")), "allPagesMode");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("details")), "detailTables");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("records")), "splitByRecords");
				var_params.InitAndSetArrayItem((XVar.Pack(MVCFunctions.postvalue(new XVar("pdfjson"))) ? XVar.Pack(Constants.PRINT_PDFJSON) : XVar.Pack(Constants.PRINT_SIMPLE)), "mode");
				GlobalVars.pageObject = XVar.Clone(new PrintPage((XVar)(var_params)));
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
