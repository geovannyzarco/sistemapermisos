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
	public partial class admin_membersController : BaseController
	{
		public ActionResult list()
		{
			try
			{
				dynamic options = XVar.Array(), pageObject = null;
				XTempl xt;
				MVCFunctions.Header("Expires", "Thu, 01 Jan 1970 00:00:01 GMT");
				admin_members_Variables.Apply();
				if(XVar.Pack(!(XVar)(Security.processAdminPageSecurity(new XVar(false)))))
				{
					return MVCFunctions.GetBuferContentAndClearBufer();
				}
{

TLayout t_layout = null;

t_layout = new TLayout(new XVar("admin_members_list_bootstrap"), new XVar("OfficeOffice"), new XVar("MobileOffice"));
t_layout.version = 3;
	t_layout.bootstrapTheme = "default";
			t_layout.customCssPageName = "_admin_members_list";
t_layout.blocks["top"] = XVar.Array();
t_layout.containers["top"] = XVar.Array();
t_layout.containers["top"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "menu" ));
t_layout.containers["menu"] = XVar.Array();
t_layout.containers["menu"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "hdr" ));
t_layout.containers["hdr"] = XVar.Array();
t_layout.containers["hdr"].Add(new XVar("name", "logo", "block", "logo_block", "substyle", 1  ));

t_layout.containers["hdr"].Add(new XVar("name", "bsnavbarcollapse", "block", "collapse_block", "substyle", 1  ));

t_layout.skins["hdr"] = "";


t_layout.containers["menu"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "menu_1" ));
t_layout.containers["menu_1"] = XVar.Array();
t_layout.containers["menu_1"].Add(new XVar("name", "hmenu", "block", "menu_block", "substyle", 1  ));

t_layout.containers["menu_1"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "more" ));
t_layout.containers["more"] = XVar.Array();
t_layout.containers["more"].Add(new XVar("name", "morebutton", "block", "more_list", "substyle", 1  ));

t_layout.containers["more"].Add(new XVar("name", "loggedas", "block", "security_block", "substyle", 1  ));

t_layout.skins["more"] = "";


t_layout.containers["menu_1"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "more_1" ));
t_layout.containers["more_1"] = XVar.Array();
t_layout.containers["more_1"].Add(new XVar("name", "search", "block", "searchform_block", "substyle", 1  ));

t_layout.skins["more_1"] = "";


t_layout.skins["menu_1"] = "";


t_layout.skins["menu"] = "";


t_layout.containers["top"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "breadcrumbs" ));
t_layout.containers["breadcrumbs"] = XVar.Array();
t_layout.containers["breadcrumbs"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "bc" ));
t_layout.containers["bc"] = XVar.Array();
t_layout.containers["bc"].Add(new XVar("name", "breadcrumbs", "block", "breadcrumbs", "substyle", 1  ));

t_layout.skins["bc"] = "";


t_layout.skins["breadcrumbs"] = "";


t_layout.containers["top"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "messagerow" ));
t_layout.containers["messagerow"] = XVar.Array();
t_layout.containers["messagerow"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "message" ));
t_layout.containers["message"] = XVar.Array();
t_layout.containers["message"].Add(new XVar("name", "message", "block", "message_block", "substyle", 1  ));

t_layout.skins["message"] = "";


t_layout.skins["messagerow"] = "";


t_layout.containers["top"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "ugcontrols" ));
t_layout.containers["ugcontrols"] = XVar.Array();
t_layout.containers["ugcontrols"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "save" ));
t_layout.containers["save"] = XVar.Array();
t_layout.containers["save"].Add(new XVar("name", "ugbuttons", "block", "", "substyle", 1  ));

t_layout.skins["save"] = "";


t_layout.containers["ugcontrols"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "filter" ));
t_layout.containers["filter"] = XVar.Array();
t_layout.containers["filter"].Add(new XVar("name", "ugmembersbuttons", "block", "", "substyle", 1  ));

t_layout.skins["filter"] = "";


t_layout.skins["ugcontrols"] = "";


t_layout.containers["top"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "permgrid" ));
t_layout.containers["permgrid"] = XVar.Array();
t_layout.containers["permgrid"].Add(new XVar("name", "ugmemgrid", "block", "grid_block", "substyle", 1  ));

t_layout.skins["permgrid"] = "";


t_layout.containers["top"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "pagination" ));
t_layout.containers["pagination"] = XVar.Array();
t_layout.containers["pagination"].Add(new XVar("name", "pagination", "block", "pagination_block", "substyle", 1  ));

t_layout.skins["pagination"] = "";


t_layout.skins["top"] = "";

t_layout.blocks["top"].Add("top");
GlobalVars.page_layouts["admin_members_list"] = t_layout;


}

				xt = XVar.UnPackXTempl(new XTempl());
				options = XVar.Clone(XVar.Array());
				options.InitAndSetArrayItem(Constants.PAGE_LIST, "pageType");
				options.InitAndSetArrayItem((XVar.Pack(CommonFunctions.postvalue_number(new XVar("id"))) ? XVar.Pack(CommonFunctions.postvalue_number(new XVar("id"))) : XVar.Pack(1)), "id");
				options.InitAndSetArrayItem(Constants.MEMBERS_PAGE, "mode");
				options.InitAndSetArrayItem(xt, "xt");
				GlobalVars.pageObject = XVar.Clone(ListPage.createListPage((XVar)(GlobalVars.strTableName), (XVar)(options)));
				if(MVCFunctions.postvalue(new XVar("a")) == "saveMembers")
				{
					dynamic modifiedMembers = null;
					modifiedMembers = XVar.Clone(MVCFunctions.my_json_decode((XVar)(MVCFunctions.postvalue(new XVar("values")))));
					GlobalVars.pageObject.saveMembers((XVar)(modifiedMembers));
					return MVCFunctions.GetBuferContentAndClearBufer();
				}
				GlobalVars.pageObject.prepareForBuildPage();
				GlobalVars.pageObject.showPage();
				ViewBag.xt = xt;
				return View(xt.GetViewPath());
			}
			catch(RunnerRedirectException ex)
			{ return Redirect(ex.Message); }
		}
	}
}
