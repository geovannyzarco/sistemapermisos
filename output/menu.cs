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
		public ActionResult menu()
		{
			try
			{
				dynamic pageObject = null, var_params = XVar.Array();
				XTempl xt;
				Security.processLogoutRequest();
				if(XVar.Pack(!(XVar)(CommonFunctions.isLogged())))
				{
					MVCFunctions.HeaderRedirect(new XVar("login"));
					return MVCFunctions.GetBuferContentAndClearBufer();
				}
				if((XVar)(XSession.Session["MyURL"] == "")  || (XVar)(!(XVar)(CommonFunctions.isLoggedAsGuest())))
				{
					Security.saveRedirectURL();
				}
{

TLayout t_layout = null;

t_layout = new TLayout(new XVar("menu_bootstrap1"), new XVar("OfficeOffice"), new XVar("MobileOffice"));
t_layout.version = 3;
	t_layout.bootstrapTheme = "default";
			t_layout.customCssPageName = "_menu";
t_layout.blocks["top"] = XVar.Array();
t_layout.containers["menu"] = XVar.Array();
t_layout.containers["menu"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "hdr" ));
t_layout.containers["hdr"] = XVar.Array();
t_layout.containers["hdr"].Add(new XVar("name", "logo", "block", "logo_block", "substyle", 1  ));

t_layout.containers["hdr"].Add(new XVar("name", "bsnavbarcollapse", "block", "collapse_block", "substyle", 1  ));

t_layout.skins["hdr"] = "";


t_layout.containers["menu"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "menu_1" ));
t_layout.containers["menu_1"] = XVar.Array();
t_layout.containers["menu_1"].Add(new XVar("name", "hmenu", "block", "menu_block", "substyle", 1  ));

t_layout.containers["menu_1"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "login" ));
t_layout.containers["login"] = XVar.Array();
t_layout.containers["login"].Add(new XVar("name", "morebutton", "block", "more_list", "substyle", 1  ));

t_layout.containers["login"].Add(new XVar("name", "loggedas", "block", "security_block", "substyle", 1  ));

t_layout.skins["login"] = "";


t_layout.skins["menu_1"] = "";


t_layout.skins["menu"] = "";

t_layout.blocks["top"].Add("menu");
t_layout.containers["center"] = XVar.Array();
t_layout.containers["center"].Add(new XVar("name", "welcome", "block", "", "substyle", 1  ));

t_layout.skins["center"] = "";

t_layout.blocks["top"].Add("center");
GlobalVars.page_layouts["menu"] = t_layout;


}

				GlobalVars.tableEvents.InitAndSetArrayItem(new eventclass_dbo_Permisos2(), "dbo.Permisos2");
				GlobalVars.tableEvents.InitAndSetArrayItem(new eventclass_dbo_REGISTRO_HORAS_COMPESADAS(), "dbo.REGISTRO_HORAS_COMPESADAS");
				GlobalVars.tableEvents.InitAndSetArrayItem(new eventclass_APROBAR_PERMISOS(), "APROBAR_PERMISOS");
				GlobalVars.tableEvents.InitAndSetArrayItem(new eventclass_VISTOBUENO_JEFEINMEDIATO(), "VISTOBUENO_JEFEINMEDIATO");
				GlobalVars.tableEvents.InitAndSetArrayItem(new eventclass_VISTOBUENO_JEFEDEPARTAMENTO(), "VISTOBUENO_JEFEDEPARTAMENTO");
				GlobalVars.tableEvents.InitAndSetArrayItem(new eventclass_VER_PERMISOS(), "VER_PERMISOS");
				GlobalVars.tableEvents.InitAndSetArrayItem(new eventclass_APROBACION_COMPESADOS_JEFEINMEDIATO(), "APROBACION_COMPESADOS_JEFEINMEDIATO");
				GlobalVars.tableEvents.InitAndSetArrayItem(new eventclass_APROBACION_COMPESADOS_JEFEDEPARTAMENTO(), "APROBACION_COMPESADOS_JEFEDEPARTAMENTO");
				GlobalVars.tableEvents.InitAndSetArrayItem(new eventclass_APROBAR_COMPESADOS(), "APROBAR_COMPESADOS");
				GlobalVars.tableEvents.InitAndSetArrayItem(new eventclass_INGRESAR_PERMISO(), "INGRESAR PERMISO");
				GlobalVars.tableEvents.InitAndSetArrayItem(new eventclass_INGRESAR_COMPESADO(), "INGRESAR_COMPESADO");
				xt = XVar.UnPackXTempl(new XTempl());
				var_params = XVar.Clone(XVar.Array());
				var_params.InitAndSetArrayItem(CommonFunctions.postvalue_number(new XVar("id")), "id");
				var_params.InitAndSetArrayItem(xt, "xt");
				var_params.InitAndSetArrayItem(Constants.GLOBAL_PAGES, "tName");
				var_params.InitAndSetArrayItem(Constants.PAGE_MENU, "pageType");
				var_params.InitAndSetArrayItem(GlobalVars.isGroupSecurity, "isGroupSecurity");
				var_params.InitAndSetArrayItem(false, "needSearchClauseObj");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("page")), "pageName");
				GlobalVars.pageObject = XVar.Clone(new MenuPage((XVar)(var_params)));
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
