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
	public partial class VER_COMPESADOSController : BaseController
	{
		public ActionResult view()
		{
			try
			{
				dynamic keys = XVar.Array(), pageMode = null, pageObject = null, var_params = XVar.Array();
				XTempl xt;
				VER_COMPESADOS_Variables.Apply();
				CommonFunctions.add_nocache_headers();
				if(XVar.Pack(!(XVar)(ViewPage.processEditPageSecurity((XVar)(GlobalVars.strTableName)))))
				{
					return MVCFunctions.GetBuferContentAndClearBufer();
				}
{

TLayout t_layout = null;

t_layout = new TLayout(new XVar("view_bootstrap_2col"), new XVar("OfficeOffice"), new XVar("MobileOffice"));
t_layout.version = 3;
	t_layout.bootstrapTheme = "default";
			t_layout.customCssPageName = "VER_COMPESADOS_view";
t_layout.blocks["top"] = XVar.Array();
t_layout.containers["viewpage"] = XVar.Array();
t_layout.containers["viewpage"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "header" ));
t_layout.containers["header"] = XVar.Array();
t_layout.containers["header"].Add(new XVar("name", "viewheader", "block", "viewheader", "substyle", 1  ));

t_layout.skins["header"] = "";


t_layout.skins["viewpage"] = "";

t_layout.blocks["top"].Add("viewpage");
t_layout.containers["fields"] = XVar.Array();
t_layout.containers["fields"].Add(new XVar("name", "viewfields", "block", "", "substyle", 1  ));

t_layout.skins["fields"] = "";

t_layout.blocks["top"].Add("fields");
t_layout.containers["bottombuttons"] = XVar.Array();
t_layout.containers["bottombuttons"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "buttons" ));
t_layout.containers["buttons"] = XVar.Array();
t_layout.containers["buttons"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "leftbuttons" ));
t_layout.containers["leftbuttons"] = XVar.Array();
t_layout.containers["leftbuttons"].Add(new XVar("name", "viewbuttons", "block", "viewbuttons", "substyle", 1  ));

t_layout.skins["leftbuttons"] = "";


t_layout.containers["buttons"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "leftbuttons_1" ));
t_layout.containers["leftbuttons_1"] = XVar.Array();
t_layout.containers["leftbuttons_1"].Add(new XVar("name", "rightviewbuttons", "block", "rightviewbuttons", "substyle", 1  ));

t_layout.skins["leftbuttons_1"] = "";


t_layout.skins["buttons"] = "";


t_layout.skins["bottombuttons"] = "";

t_layout.blocks["top"].Add("bottombuttons");
GlobalVars.page_layouts["VER_COMPESADOS_view"] = t_layout;


}

				pageMode = XVar.Clone(ViewPage.readViewModeFromRequest());
				xt = XVar.UnPackXTempl(new XTempl());
				keys = XVar.Clone(XVar.Array());
				keys.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("editid1")), "id_compesados");
				var_params = XVar.Clone(XVar.Array());
				var_params.InitAndSetArrayItem(CommonFunctions.postvalue_number(new XVar("id")), "id");
				var_params.InitAndSetArrayItem(xt, "xt");
				var_params.InitAndSetArrayItem(keys, "keys");
				var_params.InitAndSetArrayItem(pageMode, "mode");
				var_params.InitAndSetArrayItem(Constants.PAGE_VIEW, "pageType");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("page")), "pageName");
				var_params.InitAndSetArrayItem(GlobalVars.strTableName, "tName");
				var_params.InitAndSetArrayItem(!XVar.Equals(XVar.Pack(MVCFunctions.postvalue(new XVar("mvcPDF"))), XVar.Pack("")), "pdfMode");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("mastertable")), "masterTable");
				if(pageMode == Constants.VIEW_DASHBOARD)
				{
					var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("dashelement")), "dashElementName");
					var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("table")), "dashTName");
					if(XVar.Pack(MVCFunctions.postvalue(new XVar("mapRefresh"))))
					{
						var_params.InitAndSetArrayItem(true, "mapRefresh");
						var_params.InitAndSetArrayItem(MVCFunctions.my_json_decode((XVar)(MVCFunctions.postvalue(new XVar("vpCoordinates")))), "vpCoordinates");
					}
				}
				if(pageMode == Constants.VIEW_POPUP)
				{
					var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("dashelement")), "dashElementName");
					var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("dashTName")), "dashTName");
				}
				if(XVar.Pack(var_params["masterTable"]))
				{
					var_params.InitAndSetArrayItem(ViewPage.processMasterKeys(), "masterKeysReq");
				}
				GlobalVars.pageObject = XVar.Clone(new ViewPage((XVar)(var_params)));
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
