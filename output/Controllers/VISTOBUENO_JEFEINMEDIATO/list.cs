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
	public partial class VISTOBUENO_JEFEINMEDIATOController : BaseController
	{
		public ActionResult list()
		{
			try
			{
				dynamic i = null, mode = null, options = XVar.Array(), pageObject = null;
				XTempl xt;
				GlobalVars.requestTable = new XVar("VISTOBUENO_JEFEINMEDIATO");
				GlobalVars.requestPage = new XVar("list");
				CommonFunctions.add_nocache_headers();
				VISTOBUENO_JEFEINMEDIATO_Variables.Apply();
				CommonFunctions.InitLookupLinks();
				if(XVar.Pack(!(XVar)(ListPage.processListPageSecurity((XVar)(GlobalVars.strTableName)))))
				{
					return MVCFunctions.GetBuferContentAndClearBufer();
				}
				if(XVar.Pack(ListPage.processSaveParams((XVar)(GlobalVars.strTableName))))
				{
					return MVCFunctions.GetBuferContentAndClearBufer();
				}
{

TLayout t_layout = null;

t_layout = new TLayout(new XVar("list_bootstrap1"), new XVar("OfficeOffice"), new XVar("MobileOffice"));
t_layout.version = 3;
	t_layout.bootstrapTheme = "default";
			t_layout.customCssPageName = "VISTOBUENO_JEFEINMEDIATO_list";
t_layout.blocks["center"] = XVar.Array();
t_layout.containers["gridcontrols"] = XVar.Array();
t_layout.containers["gridcontrols"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "add_delete" ));
t_layout.containers["add_delete"] = XVar.Array();
t_layout.containers["add_delete"].Add(new XVar("name", "add", "block", "newrecord_controls_block", "substyle", 1  ));

t_layout.containers["add_delete"].Add(new XVar("name", "recordcontrol", "block", "record_controls_block", "substyle", 1  ));

t_layout.skins["add_delete"] = "";


t_layout.containers["gridcontrols"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "gridinfo" ));
t_layout.containers["gridinfo"] = XVar.Array();
t_layout.containers["gridinfo"].Add(new XVar("name", "details_found", "block", "details_found", "substyle", 1  ));

t_layout.containers["gridinfo"].Add(new XVar("name", "printpanel", "block", "print_friendly", "substyle", 1  ));

t_layout.containers["gridinfo"].Add(new XVar("name", "bsfieldhidepanel", "block", "field_hide_panel", "substyle", 1  ));

t_layout.skins["gridinfo"] = "";


t_layout.containers["gridcontrols"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "gridinfo_sort" ));
t_layout.containers["gridinfo_sort"] = XVar.Array();
t_layout.containers["gridinfo_sort"].Add(new XVar("name", "reorder_records", "block", "reorder_records", "substyle", 1  ));

t_layout.skins["gridinfo_sort"] = "";


t_layout.skins["gridcontrols"] = "";

t_layout.blocks["center"].Add("gridcontrols");
t_layout.containers["tabs"] = XVar.Array();
t_layout.containers["tabs"].Add(new XVar("name", "bsgrid_tabs", "block", "grid_tabs", "substyle", 1  ));

t_layout.skins["tabs"] = "";

t_layout.blocks["center"].Add("tabs");
t_layout.containers["messagerow"] = XVar.Array();
t_layout.containers["messagerow"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "message" ));
t_layout.containers["message"] = XVar.Array();
t_layout.containers["message"].Add(new XVar("name", "message", "block", "message_block", "substyle", 1  ));

t_layout.skins["message"] = "";


t_layout.skins["messagerow"] = "";

t_layout.blocks["center"].Add("messagerow");
t_layout.containers["center"] = XVar.Array();
t_layout.containers["center"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "grid" ));
t_layout.containers["grid"] = XVar.Array();
t_layout.containers["grid"].Add(new XVar("name", "grid", "block", "grid_block", "substyle", 1  ));

t_layout.skins["grid"] = "";


t_layout.skins["center"] = "";

t_layout.blocks["center"].Add("center");
t_layout.containers["pagination"] = XVar.Array();
t_layout.containers["pagination"].Add(new XVar("name", "pagination", "block", "pagination_block", "substyle", 1  ));

t_layout.skins["pagination"] = "";

t_layout.blocks["center"].Add("pagination");
t_layout.blocks["left"] = XVar.Array();
t_layout.containers["left"] = XVar.Array();
t_layout.containers["left"].Add(new XVar("name", "searchpanel", "block", "searchPanel", "substyle", 1  ));

t_layout.containers["left"].Add(new XVar("name", "filterpanel", "block", "filterPanel", "substyle", 1  ));

t_layout.skins["left"] = "";

t_layout.blocks["left"].Add("left");
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

t_layout.blocks["top"].Add("menu");
t_layout.blocks["topmiddle"] = XVar.Array();
t_layout.containers["breadcrumbs"] = XVar.Array();
t_layout.containers["breadcrumbs"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "bc" ));
t_layout.containers["bc"] = XVar.Array();
t_layout.containers["bc"].Add(new XVar("name", "breadcrumbs", "block", "breadcrumbs", "substyle", 1  ));

t_layout.skins["bc"] = "";


t_layout.skins["breadcrumbs"] = "";

t_layout.blocks["topmiddle"].Add("breadcrumbs");
t_layout.containers["masterinfo"] = XVar.Array();
t_layout.containers["masterinfo"].Add(new XVar("name", "masterinfo", "block", "mastertable_block", "substyle", 1  ));

t_layout.skins["masterinfo"] = "";

t_layout.blocks["topmiddle"].Add("masterinfo");
GlobalVars.page_layouts["VISTOBUENO_JEFEINMEDIATO_list"] = t_layout;


}

				options = XVar.Clone(XVar.Array());
				mode = XVar.Clone(ListPage.readListModeFromRequest());
				if(mode == Constants.LIST_SIMPLE)
				{
				}
				else
				{
					if(mode == Constants.LIST_AJAX)
					{
					}
					else
					{
						if(mode == Constants.LIST_LOOKUP)
						{
							options.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("table")), "mainTable");
							options.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("field")), "mainField");
							options.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("pageType")), "mainPageType");
							options.InitAndSetArrayItem(MVCFunctions.my_json_decode((XVar)(MVCFunctions.postvalue(new XVar("data")))), "mainRecordData");
							options.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("mainRecordMasterTable")), "mainRecordMasterTable");
							if(XVar.Pack(MVCFunctions.postvalue(new XVar("parentsExist"))))
							{
								options.InitAndSetArrayItem(MVCFunctions.my_json_decode((XVar)(MVCFunctions.postvalue(new XVar("parentCtrlsData")))), "parentCtrlsData");
							}
						}
						else
						{
							if(mode == Constants.LIST_POPUPDETAILS)
							{
							}
							else
							{
								if(mode == Constants.LIST_DETAILS)
								{
								}
								else
								{
									if(mode == Constants.LIST_DASHDETAILS)
									{
									}
									else
									{
										if(mode == Constants.LIST_DASHBOARD)
										{
										}
										else
										{
											if(mode == Constants.MAP_DASHBOARD)
											{
											}
										}
									}
								}
							}
						}
					}
				}
				xt = XVar.UnPackXTempl(new XTempl((XVar)(mode != Constants.LIST_SIMPLE)));
				options.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("page")), "pageName");
				options.InitAndSetArrayItem(Constants.PAGE_LIST, "pageType");
				options.InitAndSetArrayItem((XVar.Pack(CommonFunctions.postvalue_number(new XVar("id"))) ? XVar.Pack(CommonFunctions.postvalue_number(new XVar("id"))) : XVar.Pack(1)), "id");
				options.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("recordId")) + 0, "flyId");
				options.InitAndSetArrayItem(mode, "mode");
				options.InitAndSetArrayItem(xt, "xt");
				options.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("masterpagetype")), "masterPageType");
				options.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("mastertable")), "masterTable");
				options.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("masterpage")), "masterPage");
				options.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("masterid")), "masterId");
				options.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("firsttime")), "firstTime");
				options.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("sortby")), "sortBy");
				if((XVar)((XVar)(mode == Constants.LIST_DASHBOARD)  && (XVar)(MVCFunctions.postvalue(new XVar("nodata"))))  && (XVar)(MVCFunctions.strlen((XVar)(options["masterTable"]))))
				{
					options.InitAndSetArrayItem(true, "showNoData");
				}
				if(mode != Constants.LIST_LOOKUP)
				{
					options.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("dashelement")), "dashElementName");
					options.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("table")), "dashTName");
				}
				if(XVar.Pack(MVCFunctions.postvalue(new XVar("mapRefresh"))))
				{
					options.InitAndSetArrayItem(true, "mapRefresh");
					options.InitAndSetArrayItem(MVCFunctions.my_json_decode((XVar)(MVCFunctions.postvalue(new XVar("vpCoordinates")))), "vpCoordinates");
				}
				i = new XVar(1);
				while(XVar.Pack(MVCFunctions.REQUESTKeyExists(MVCFunctions.Concat("masterkey", i))))
				{
					if(i == 1)
					{
						options.InitAndSetArrayItem(XVar.Array(), "masterKeysReq");
					}
					options.InitAndSetArrayItem(MVCFunctions.postvalue(MVCFunctions.Concat("masterkey", i)), "masterKeysReq", i);
					i++;
				}
				GlobalVars.pageObject = XVar.Clone(ListPage.createListPage((XVar)(GlobalVars.strTableName), (XVar)(options)));
				if(XVar.Pack(GlobalVars.pageObject.processSaveSearch()))
				{
					MVCFunctions.Echo(new XVar(""));
					return MVCFunctions.GetBuferContentAndClearBufer();
				}
				GlobalVars.gQuery.ReplaceFieldsWithDummies((XVar)(GlobalVars.pageObject.getNotListBlobFieldsIndices()));
				if((XVar)((XVar)(mode != Constants.LIST_DETAILS)  && (XVar)(mode != Constants.MAP_DASHBOARD))  && (XVar)(mode != Constants.LIST_DASHBOARD))
				{
				}
				XSession.Session.Remove("message_add");
				XSession.Session.Remove("message_edit");
				GlobalVars.pageObject.prepareForBuildPage();
				GlobalVars.pageObject.showPage();
				if(mode != Constants.LIST_SIMPLE)
				{
					MVCFunctions.Echo(new XVar(""));
					return MVCFunctions.GetBuferContentAndClearBufer();
				}
				ViewBag.xt = xt;
				return View(xt.GetViewPath());
			}
			catch(RunnerRedirectException ex)
			{ return Redirect(ex.Message); }
		}
	}
}
