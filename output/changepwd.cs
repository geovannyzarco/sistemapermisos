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
		public ActionResult changepwd()
		{
			try
			{
				dynamic pageObject = null, token = null, var_params = XVar.Array();
				XTempl xt;
				token = XVar.Clone(MVCFunctions.postvalue(new XVar("token")));
				if((XVar)(!(XVar)(token))  && (XVar)((XVar)(!(XVar)(CommonFunctions.isLogged()))  || (XVar)(XSession.Session["UserID"] == "<Guest>")))
				{
					Security.saveRedirectURL();
					MVCFunctions.HeaderRedirect(new XVar("login"), new XVar(""), new XVar("message=expired"));
					return MVCFunctions.GetBuferContentAndClearBufer();
				}
{

TLayout t_layout = null;

t_layout = new TLayout(new XVar("changepwd_bootstrap"), new XVar("OfficeOffice"), new XVar("MobileOffice"));
t_layout.version = 3;
	t_layout.bootstrapTheme = "default";
			t_layout.customCssPageName = "_changepwd";
t_layout.blocks["top"] = XVar.Array();
t_layout.containers["page"] = XVar.Array();
t_layout.containers["page"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "page_1" ));
t_layout.containers["page_1"] = XVar.Array();
t_layout.containers["page_1"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "panel" ));
t_layout.containers["panel"] = XVar.Array();
t_layout.containers["panel"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "header" ));
t_layout.containers["header"] = XVar.Array();
t_layout.containers["header"].Add(new XVar("name", "changeheader", "block", "changeheader", "substyle", 1  ));

t_layout.skins["header"] = "";


t_layout.containers["panel"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "body" ));
t_layout.containers["body"] = XVar.Array();
t_layout.containers["body"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "header_1" ));
t_layout.containers["header_1"] = XVar.Array();
t_layout.containers["header_1"].Add(new XVar("name", "message", "block", "message_block", "substyle", 1  ));

t_layout.skins["header_1"] = "";


t_layout.containers["body"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "fields" ));
t_layout.containers["fields"] = XVar.Array();
t_layout.containers["fields"].Add(new XVar("name", "changefields", "block", "", "substyle", 1  ));

t_layout.skins["fields"] = "";


t_layout.containers["body"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "header_2" ));
t_layout.containers["header_2"] = XVar.Array();
t_layout.containers["header_2"].Add(new XVar("name", "changebuttons", "block", "changebuttons", "substyle", 1  ));

t_layout.skins["header_2"] = "";


t_layout.skins["body"] = "";


t_layout.skins["panel"] = "";


t_layout.skins["page_1"] = "";


t_layout.skins["page"] = "";

t_layout.blocks["top"].Add("page");
GlobalVars.page_layouts["changepwd"] = t_layout;


}

{

TLayout t_layout = null;

t_layout = new TLayout(new XVar("changepwd_success_bootstrap"), new XVar("OfficeOffice"), new XVar("MobileOffice"));
t_layout.version = 3;
	t_layout.bootstrapTheme = "default";
			t_layout.customCssPageName = "_changepwd_success";
t_layout.blocks["top"] = XVar.Array();
t_layout.containers["page"] = XVar.Array();
t_layout.containers["page"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "page_1" ));
t_layout.containers["page_1"] = XVar.Array();
t_layout.containers["page_1"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "panel" ));
t_layout.containers["panel"] = XVar.Array();
t_layout.containers["panel"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "header" ));
t_layout.containers["header"] = XVar.Array();
t_layout.containers["header"].Add(new XVar("name", "changeheader", "block", "changeheader", "substyle", 1  ));

t_layout.skins["header"] = "";


t_layout.containers["panel"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "body" ));
t_layout.containers["body"] = XVar.Array();
t_layout.containers["body"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "header_1" ));
t_layout.containers["header_1"] = XVar.Array();
t_layout.containers["header_1"].Add(new XVar("name", "changepwd_message", "block", "", "substyle", 1  ));

t_layout.skins["header_1"] = "";


t_layout.containers["body"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "header_2" ));
t_layout.containers["header_2"] = XVar.Array();
t_layout.containers["header_2"].Add(new XVar("name", "changesuccessbutton", "block", "", "substyle", 1  ));

t_layout.skins["header_2"] = "";


t_layout.skins["body"] = "";


t_layout.skins["panel"] = "";


t_layout.skins["page_1"] = "";


t_layout.skins["page"] = "";

t_layout.blocks["top"].Add("page");
GlobalVars.page_layouts["changepwd_success"] = t_layout;


}

				xt = XVar.UnPackXTempl(new XTempl());
				var_params = XVar.Clone(XVar.Array());
				var_params.InitAndSetArrayItem(xt, "xt");
				var_params.InitAndSetArrayItem(token, "token");
				var_params.InitAndSetArrayItem(CommonFunctions.postvalue_number(new XVar("id")), "id");
				var_params.InitAndSetArrayItem(GlobalVars.cLoginTable, "tName");
				var_params.InitAndSetArrayItem(Constants.GLOBAL_PAGES, "pageTable");
				var_params.InitAndSetArrayItem(Constants.PAGE_CHANGEPASS, "pageType");
				var_params.InitAndSetArrayItem(false, "needSearchClauseObj");
				var_params.InitAndSetArrayItem(ChangePasswordPage.readActionFromRequest(), "action");
				GlobalVars.pageObject = XVar.Clone(new ChangePasswordPage((XVar)(var_params)));
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
