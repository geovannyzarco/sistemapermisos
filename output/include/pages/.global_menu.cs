
		// <global>
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
			public static partial class Options____global____menu
			{
				static public XVar options()
				{
					return new XVar( "welcome", new XVar( "welcomeItems", new XVar( "logo", new XVar( "menutItem", false ),
"menu", new XVar( "menutItem", false ),
"loginform_login", new XVar( "menutItem", false ),
"username_button", new XVar( "menutItem", false ),
"breadcrumb", new XVar( "menutItem", false ),
"snippet", new XVar( "menutItem", false ) ) ),
"fields", new XVar( "gridFields", XVar.Array(),
"searchRequiredFields", XVar.Array(),
"searchPanelFields", XVar.Array(),
"fieldItems", new XVar(  ) ),
"layoutHelper", new XVar( "formItems", new XVar( "formItems", new XVar( "supertop", new XVar( 0, "logo",
1, "menu",
2, "loginform_login",
3, "username_button" ),
"above-grid", new XVar( 0, "breadcrumb" ),
"grid", new XVar( 0, "snippet" ) ),
"formXtTags", new XVar( "above-grid", new XVar( 0, "breadcrumb" ) ),
"itemForms", new XVar( "logo", "supertop",
"menu", "supertop",
"loginform_login", "supertop",
"username_button", "supertop",
"breadcrumb", "above-grid",
"snippet", "grid" ),
"itemLocations", new XVar(  ),
"itemVisiblity", new XVar( "menu", 3,
"loginform_login", 3,
"username_button", 3 ) ),
"itemsByType", new XVar( "logo", new XVar( 0, "logo" ),
"menu", new XVar( 0, "menu" ),
"breadcrumb", new XVar( 0, "breadcrumb" ),
"loginform_login", new XVar( 0, "loginform_login" ),
"username_button", new XVar( 0, "username_button" ),
"logout_link", new XVar( 0, "logout_link" ),
"changepassword_link", new XVar( 0, "changepassword_link" ),
"adminarea_link", new XVar( 0, "adminarea_link" ),
"snippet", new XVar( 0, "snippet" ) ),
"cellMaps", new XVar(  ) ),
"loginForm", new XVar( "loginForm", 0 ),
"page", new XVar( "labeledButtons", new XVar( "update_records", new XVar(  ),
"print_pages", new XVar(  ),
"register_activate_message", new XVar(  ) ) ),
"events", new XVar( "maps", XVar.Array(),
"mapsData", new XVar(  ),
"buttons", XVar.Array() ) );
				}
				static public XVar page()
				{
					return new XVar( "id", "menu",
"type", "menu",
"layoutId", "topbar",
"disabled", 0,
"default", 0,
"forms", new XVar( "supertop", new XVar( "modelId", "menu-topbar-menu",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ),
1, new XVar( "cell", "c2" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "logo",
1, "menu" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ),
"c2", new XVar( "model", "c2",
"items", new XVar( 0, "loginform_login",
1, "username_button" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"above-grid", new XVar( "modelId", "empty-above-grid",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "breadcrumb" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"grid", new XVar( "modelId", "welcome",
"grid", new XVar( 0, new XVar( "section", "",
"cells", new XVar( 0, new XVar( "cell", "c1",
"rowspan", 1 ) ) ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "snippet" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ) ),
"items", new XVar( "logo", new XVar( "type", "logo" ),
"menu", new XVar( "type", "menu" ),
"breadcrumb", new XVar( "type", "breadcrumb" ),
"loginform_login", new XVar( "type", "loginform_login",
"popup", false ),
"username_button", new XVar( "type", "username_button",
"items", new XVar( 0, "logout_link",
1, "adminarea_link",
2, "changepassword_link" ) ),
"logout_link", new XVar( "type", "logout_link" ),
"changepassword_link", new XVar( "type", "changepassword_link" ),
"adminarea_link", new XVar( "type", "adminarea_link" ),
"snippet", new XVar( "eventId", "Informacion_usuario",
"label", new XVar( "text", "Informacion_usuario",
"type", 0 ),
"type", "snippet" ) ),
"dbProps", new XVar(  ),
"version", 2 );
				}
			}
		}