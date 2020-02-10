
		// APROBAR_COMPESADOS
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
			public static partial class Options_APROBAR_COMPESADOS_list
			{
				static public XVar options()
				{
					return new XVar( "list", new XVar( "inlineAdd", false,
"detailsAdd", true,
"inlineEdit", true,
"delete", false,
"updateSelected", false,
"addInPopup", null,
"editInPopup", null,
"viewInPopup", false,
"clickSort", true,
"sortDropdown", false,
"showHideFields", false,
"reorderFields", false ),
"master", new XVar( "dbo.EMPLEADO", new XVar( "preview", true ),
"dbo.ESTADO_COMPESADO", new XVar( "preview", true ) ),
"listSearch", new XVar( "alwaysOnPanelFields", XVar.Array(),
"searchPanel", true,
"fixedSearchPanel", false,
"simpleSearchOptions", false,
"searchSaving", false ),
"totals", new XVar( "id_compesados", new XVar( "totalsType", "" ),
"ONI", new XVar( "totalsType", "" ),
"nombre", new XVar( "totalsType", "" ),
"departamento", new XVar( "totalsType", "" ),
"fecha_creacion", new XVar( "totalsType", "" ),
"desde", new XVar( "totalsType", "" ),
"hasta", new XVar( "totalsType", "" ),
"dias", new XVar( "totalsType", "" ),
"horas", new XVar( "totalsType", "" ),
"minutos", new XVar( "totalsType", "" ),
"justificacion", new XVar( "totalsType", "" ),
"anexo", new XVar( "totalsType", "" ),
"observacion", new XVar( "totalsType", "" ),
"vistobueno1", new XVar( "totalsType", "" ),
"vistobueno2", new XVar( "totalsType", "" ),
"id_estado_compesado", new XVar( "totalsType", "" ) ),
"fields", new XVar( "gridFields", new XVar( 0, "id_compesados",
1, "fecha_creacion",
2, "ONI",
3, "nombre",
4, "departamento",
5, "desde",
6, "hasta",
7, "justificacion",
8, "anexo",
9, "dias",
10, "horas",
11, "minutos",
12, "id_estado_compesado",
13, "observacion" ),
"searchRequiredFields", XVar.Array(),
"searchPanelFields", new XVar( 0, "fecha_creacion",
1, "id_estado_compesado",
2, "departamento",
3, "minutos",
4, "horas",
5, "dias",
6, "hasta",
7, "desde" ),
"filterFields", XVar.Array(),
"inlineAddFields", XVar.Array(),
"inlineEditFields", new XVar( 0, "id_estado_compesado",
1, "observacion" ),
"fieldItems", new XVar( "id_compesados", new XVar( 0, "simple_grid_field",
1, "simple_grid_field11" ),
"fecha_creacion", new XVar( 0, "simple_grid_field2",
1, "simple_grid_field15" ),
"ONI", new XVar( 0, "simple_grid_field1",
1, "simple_grid_field16" ),
"nombre", new XVar( 0, "simple_grid_field12",
1, "simple_grid_field17" ),
"departamento", new XVar( 0, "simple_grid_field10",
1, "simple_grid_field18" ),
"desde", new XVar( 0, "simple_grid_field3",
1, "simple_grid_field19" ),
"hasta", new XVar( 0, "simple_grid_field4",
1, "simple_grid_field20" ),
"justificacion", new XVar( 0, "simple_grid_field6",
1, "simple_grid_field21" ),
"anexo", new XVar( 0, "simple_grid_field7",
1, "simple_grid_field22" ),
"dias", new XVar( 0, "simple_grid_field5",
1, "simple_grid_field23" ),
"horas", new XVar( 0, "simple_grid_field13",
1, "simple_grid_field24" ),
"minutos", new XVar( 0, "simple_grid_field14",
1, "simple_grid_field25" ),
"id_estado_compesado", new XVar( 0, "simple_grid_field9",
1, "simple_grid_field26" ),
"observacion", new XVar( 0, "simple_grid_field8",
1, "simple_grid_field27" ) ) ),
"pageLinks", new XVar( "edit", false,
"add", false,
"view", true,
"print", false ),
"layoutHelper", new XVar( "formItems", new XVar( "formItems", new XVar( "supertop", new XVar( 0, "logo",
1, "menu",
2, "simple_search",
3, "list_options",
4, "loginform_login",
5, "username_button" ),
"left", new XVar( 0, "search_panel" ),
"top", new XVar( 0, "breadcrumb",
1, "master_info" ),
"above-grid", new XVar( 0, "inline_add",
1, "inline_save_all",
2, "inline_cancel_all",
3, "details_found",
4, "page_size" ),
"below-grid", new XVar( 0, "pagination" ),
"grid", new XVar( 0, "simple_grid_field11",
1, "simple_grid_field",
2, "simple_grid_field15",
3, "simple_grid_field2",
4, "simple_grid_field16",
5, "simple_grid_field1",
6, "simple_grid_field17",
7, "simple_grid_field12",
8, "simple_grid_field18",
9, "simple_grid_field10",
10, "simple_grid_field19",
11, "simple_grid_field3",
12, "simple_grid_field20",
13, "simple_grid_field4",
14, "simple_grid_field21",
15, "simple_grid_field6",
16, "simple_grid_field22",
17, "simple_grid_field7",
18, "simple_grid_field23",
19, "simple_grid_field5",
20, "simple_grid_field24",
21, "simple_grid_field13",
22, "simple_grid_field25",
23, "simple_grid_field14",
24, "simple_grid_field26",
25, "simple_grid_field9",
26, "simple_grid_field27",
27, "simple_grid_field8",
28, "grid_inline_edit",
29, "grid_inline_save",
30, "grid_inline_cancel",
31, "grid_view",
32, "grid_checkbox_head",
33, "grid_checkbox" ) ),
"formXtTags", new XVar( "top", new XVar( 0, "breadcrumb",
1, "mastertable_block" ),
"above-grid", new XVar( 0, "inlineadd_link",
1, "saveall_link",
2, "cancelall_link",
3, "records_indicator",
4, "recsPerPage" ),
"below-grid", new XVar( 0, "pagination" ) ),
"itemForms", new XVar( "logo", "supertop",
"menu", "supertop",
"simple_search", "supertop",
"list_options", "supertop",
"loginform_login", "supertop",
"username_button", "supertop",
"search_panel", "left",
"breadcrumb", "top",
"master_info", "top",
"inline_add", "above-grid",
"inline_save_all", "above-grid",
"inline_cancel_all", "above-grid",
"details_found", "above-grid",
"page_size", "above-grid",
"pagination", "below-grid",
"simple_grid_field11", "grid",
"simple_grid_field", "grid",
"simple_grid_field15", "grid",
"simple_grid_field2", "grid",
"simple_grid_field16", "grid",
"simple_grid_field1", "grid",
"simple_grid_field17", "grid",
"simple_grid_field12", "grid",
"simple_grid_field18", "grid",
"simple_grid_field10", "grid",
"simple_grid_field19", "grid",
"simple_grid_field3", "grid",
"simple_grid_field20", "grid",
"simple_grid_field4", "grid",
"simple_grid_field21", "grid",
"simple_grid_field6", "grid",
"simple_grid_field22", "grid",
"simple_grid_field7", "grid",
"simple_grid_field23", "grid",
"simple_grid_field5", "grid",
"simple_grid_field24", "grid",
"simple_grid_field13", "grid",
"simple_grid_field25", "grid",
"simple_grid_field14", "grid",
"simple_grid_field26", "grid",
"simple_grid_field9", "grid",
"simple_grid_field27", "grid",
"simple_grid_field8", "grid",
"grid_inline_edit", "grid",
"grid_inline_save", "grid",
"grid_inline_cancel", "grid",
"grid_view", "grid",
"grid_checkbox_head", "grid",
"grid_checkbox", "grid" ),
"itemLocations", new XVar( "simple_grid_field11", new XVar( "location", "grid",
"cellId", "headcell_field" ),
"simple_grid_field", new XVar( "location", "grid",
"cellId", "cell_field" ),
"simple_grid_field15", new XVar( "location", "grid",
"cellId", "headcell_field1" ),
"simple_grid_field2", new XVar( "location", "grid",
"cellId", "cell_field1" ),
"simple_grid_field16", new XVar( "location", "grid",
"cellId", "headcell_field2" ),
"simple_grid_field1", new XVar( "location", "grid",
"cellId", "cell_field2" ),
"simple_grid_field17", new XVar( "location", "grid",
"cellId", "headcell_field3" ),
"simple_grid_field12", new XVar( "location", "grid",
"cellId", "cell_field3" ),
"simple_grid_field18", new XVar( "location", "grid",
"cellId", "headcell_field4" ),
"simple_grid_field10", new XVar( "location", "grid",
"cellId", "cell_field4" ),
"simple_grid_field19", new XVar( "location", "grid",
"cellId", "headcell_field5" ),
"simple_grid_field3", new XVar( "location", "grid",
"cellId", "cell_field5" ),
"simple_grid_field20", new XVar( "location", "grid",
"cellId", "headcell_field6" ),
"simple_grid_field4", new XVar( "location", "grid",
"cellId", "cell_field6" ),
"simple_grid_field21", new XVar( "location", "grid",
"cellId", "headcell_field7" ),
"simple_grid_field6", new XVar( "location", "grid",
"cellId", "cell_field7" ),
"simple_grid_field22", new XVar( "location", "grid",
"cellId", "headcell_field8" ),
"simple_grid_field7", new XVar( "location", "grid",
"cellId", "cell_field8" ),
"simple_grid_field23", new XVar( "location", "grid",
"cellId", "headcell_field9" ),
"simple_grid_field5", new XVar( "location", "grid",
"cellId", "cell_field9" ),
"simple_grid_field24", new XVar( "location", "grid",
"cellId", "headcell_field10" ),
"simple_grid_field13", new XVar( "location", "grid",
"cellId", "cell_field10" ),
"simple_grid_field25", new XVar( "location", "grid",
"cellId", "headcell_field11" ),
"simple_grid_field14", new XVar( "location", "grid",
"cellId", "cell_field11" ),
"simple_grid_field26", new XVar( "location", "grid",
"cellId", "headcell_field12" ),
"simple_grid_field9", new XVar( "location", "grid",
"cellId", "cell_field12" ),
"simple_grid_field27", new XVar( "location", "grid",
"cellId", "headcell_field13" ),
"simple_grid_field8", new XVar( "location", "grid",
"cellId", "cell_field13" ),
"grid_inline_edit", new XVar( "location", "grid",
"cellId", "cell_icons" ),
"grid_inline_save", new XVar( "location", "grid",
"cellId", "cell_icons" ),
"grid_inline_cancel", new XVar( "location", "grid",
"cellId", "cell_icons" ),
"grid_view", new XVar( "location", "grid",
"cellId", "cell_icons" ),
"grid_checkbox_head", new XVar( "location", "grid",
"cellId", "headcell_checkbox" ),
"grid_checkbox", new XVar( "location", "grid",
"cellId", "cell_checkbox" ) ),
"itemVisiblity", new XVar( "menu", 3,
"simple_search", 3,
"list_options", 3,
"loginform_login", 3,
"username_button", 3,
"search_panel", 5 ) ),
"itemsByType", new XVar( "page_size", new XVar( 0, "page_size" ),
"details_found", new XVar( 0, "details_found" ),
"breadcrumb", new XVar( 0, "breadcrumb" ),
"logo", new XVar( 0, "logo" ),
"menu", new XVar( 0, "menu" ),
"simple_search", new XVar( 0, "simple_search" ),
"pagination", new XVar( 0, "pagination" ),
"list_options", new XVar( 0, "list_options" ),
"export", new XVar( 0, "export" ),
"-", new XVar( 0, "-",
1, "-1",
2, "-2",
3, "-3" ),
"export_selected", new XVar( 0, "export_selected" ),
"advsearch_link", new XVar( 0, "advsearch_link" ),
"master_info", new XVar( 0, "master_info" ),
"username_button", new XVar( 0, "username_button" ),
"changepassword_link", new XVar( 0, "changepassword_link" ),
"adminarea_link", new XVar( 0, "adminarea_link" ),
"loginform_login", new XVar( 0, "loginform_login" ),
"logout_link", new XVar( 0, "logout_link" ),
"edit_selected", new XVar( 0, "edit_selected" ),
"inline_save_all", new XVar( 0, "inline_save_all" ),
"inline_cancel_all", new XVar( 0, "inline_cancel_all" ),
"search_panel", new XVar( 0, "search_panel" ),
"search_panel_field", new XVar( 0, "search_panel_field",
1, "search_panel_field1",
2, "search_panel_field2",
3, "search_panel_field3",
4, "search_panel_field4",
5, "search_panel_field5",
6, "search_panel_field6",
7, "search_panel_field7" ),
"show_search_panel", new XVar( 0, "show_search_panel" ),
"hide_search_panel", new XVar( 0, "hide_search_panel" ),
"grid_field", new XVar( 0, "simple_grid_field",
1, "simple_grid_field2",
2, "simple_grid_field1",
3, "simple_grid_field12",
4, "simple_grid_field10",
5, "simple_grid_field3",
6, "simple_grid_field4",
7, "simple_grid_field6",
8, "simple_grid_field7",
9, "simple_grid_field5",
10, "simple_grid_field13",
11, "simple_grid_field14",
12, "simple_grid_field9",
13, "simple_grid_field8" ),
"grid_field_label", new XVar( 0, "simple_grid_field11",
1, "simple_grid_field15",
2, "simple_grid_field16",
3, "simple_grid_field17",
4, "simple_grid_field18",
5, "simple_grid_field19",
6, "simple_grid_field20",
7, "simple_grid_field21",
8, "simple_grid_field22",
9, "simple_grid_field23",
10, "simple_grid_field24",
11, "simple_grid_field25",
12, "simple_grid_field26",
13, "simple_grid_field27" ),
"grid_view", new XVar( 0, "grid_view" ),
"grid_checkbox", new XVar( 0, "grid_checkbox" ),
"grid_checkbox_head", new XVar( 0, "grid_checkbox_head" ),
"grid_inline_edit", new XVar( 0, "grid_inline_edit" ),
"grid_inline_save", new XVar( 0, "grid_inline_save" ),
"grid_inline_cancel", new XVar( 0, "grid_inline_cancel" ),
"inline_add", new XVar( 0, "inline_add" ) ),
"cellMaps", new XVar( "grid", new XVar( "cells", new XVar( "headcell_icons", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 0 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_checkbox", new XVar( "cols", new XVar( 0, 1 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "checkbox_column" ),
"items", new XVar( 0, "grid_checkbox_head" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field", new XVar( "cols", new XVar( 0, 2 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "id_compesados_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field11" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field1", new XVar( "cols", new XVar( 0, 3 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "fecha_creacion_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field15" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field2", new XVar( "cols", new XVar( 0, 4 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "ONI_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field16" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field3", new XVar( "cols", new XVar( 0, 5 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "nombre_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field17" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field4", new XVar( "cols", new XVar( 0, 6 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "departamento_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field18" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field5", new XVar( "cols", new XVar( 0, 7 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "desde_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field19" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field6", new XVar( "cols", new XVar( 0, 8 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "hasta_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field20" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field7", new XVar( "cols", new XVar( 0, 9 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "justificacion_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field21" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field8", new XVar( "cols", new XVar( 0, 10 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "anexo_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field22" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field9", new XVar( "cols", new XVar( 0, 11 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "dias_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field23" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field10", new XVar( "cols", new XVar( 0, 12 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "horas_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field24" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field11", new XVar( "cols", new XVar( 0, 13 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "minutos_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field25" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field12", new XVar( "cols", new XVar( 0, 14 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "id_estado_compesado_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field26" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field13", new XVar( "cols", new XVar( 0, 15 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "observacion_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field27" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_icons", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "inlineedit_column",
1, "inline_save",
2, "inline_cancel",
3, "view_column" ),
"items", new XVar( 0, "grid_inline_edit",
1, "grid_inline_save",
2, "grid_inline_cancel",
3, "grid_view" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_checkbox", new XVar( "cols", new XVar( 0, 1 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "checkbox_column" ),
"items", new XVar( 0, "grid_checkbox" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field", new XVar( "cols", new XVar( 0, 2 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "id_compesados_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field1", new XVar( "cols", new XVar( 0, 3 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "fecha_creacion_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field2" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field2", new XVar( "cols", new XVar( 0, 4 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "ONI_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field1" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field3", new XVar( "cols", new XVar( 0, 5 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "nombre_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field12" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field4", new XVar( "cols", new XVar( 0, 6 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "departamento_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field10" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field5", new XVar( "cols", new XVar( 0, 7 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "desde_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field3" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field6", new XVar( "cols", new XVar( 0, 8 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "hasta_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field4" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field7", new XVar( "cols", new XVar( 0, 9 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "justificacion_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field6" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field8", new XVar( "cols", new XVar( 0, 10 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "anexo_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field7" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field9", new XVar( "cols", new XVar( 0, 11 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "dias_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field5" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field10", new XVar( "cols", new XVar( 0, 12 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "horas_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field13" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field11", new XVar( "cols", new XVar( 0, 13 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "minutos_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field14" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field12", new XVar( "cols", new XVar( 0, 14 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "id_estado_compesado_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field9" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field13", new XVar( "cols", new XVar( 0, 15 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "observacion_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field8" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_icons", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_checkbox", new XVar( "cols", new XVar( 0, 1 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field", new XVar( "cols", new XVar( 0, 2 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field1", new XVar( "cols", new XVar( 0, 3 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field2", new XVar( "cols", new XVar( 0, 4 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field3", new XVar( "cols", new XVar( 0, 5 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field4", new XVar( "cols", new XVar( 0, 6 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field5", new XVar( "cols", new XVar( 0, 7 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field6", new XVar( "cols", new XVar( 0, 8 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field7", new XVar( "cols", new XVar( 0, 9 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field8", new XVar( "cols", new XVar( 0, 10 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field9", new XVar( "cols", new XVar( 0, 11 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field10", new XVar( "cols", new XVar( 0, 12 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field11", new XVar( "cols", new XVar( 0, 13 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field12", new XVar( "cols", new XVar( 0, 14 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field13", new XVar( "cols", new XVar( 0, 15 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ) ),
"width", 16,
"height", 3 ) ) ),
"loginForm", new XVar( "loginForm", 0 ),
"page", new XVar( "labeledButtons", new XVar( "update_records", new XVar(  ),
"print_pages", new XVar(  ),
"register_activate_message", new XVar(  ) ),
"gridType", 0,
"recsPerRow", 1 ),
"misc", new XVar( "type", "list",
"breadcrumb", true ),
"events", new XVar( "maps", XVar.Array(),
"mapsData", new XVar(  ),
"buttons", XVar.Array() ),
"dataGrid", new XVar( "groupFields", XVar.Array() ) );
				}
				static public XVar page()
				{
					return new XVar( "id", "list",
"type", "list",
"layoutId", "topbar",
"disabled", 0,
"default", 0,
"forms", new XVar( "supertop", new XVar( "modelId", "topbar-menu",
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
"items", new XVar( 0, "simple_search",
1, "list_options",
2, "loginform_login",
3, "username_button" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"left", new XVar( "modelId", "list-vbar",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "search_panel" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"top", new XVar( "modelId", "list-top",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ),
1, new XVar( "cells", new XVar( 0, new XVar( "cell", "c3" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "breadcrumb" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ),
"c3", new XVar( "model", "c3",
"items", new XVar( 0, "master_info" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"above-grid", new XVar( "modelId", "list-above-grid",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ),
1, new XVar( "cell", "c2" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "inline_add",
1, "inline_save_all",
2, "inline_cancel_all" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ),
"c2", new XVar( "model", "c2",
"items", new XVar( 0, "details_found",
1, "page_size" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"below-grid", new XVar( "modelId", "list-below-grid",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "pagination" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"grid", new XVar( "modelId", "horizontal-grid",
"grid", new XVar( 0, new XVar( "section", "head",
"cells", new XVar( 0, new XVar( "cell", "headcell_icons" ),
1, new XVar( "cell", "headcell_checkbox" ),
2, new XVar( "cell", "headcell_field" ),
3, new XVar( "cell", "headcell_field1" ),
4, new XVar( "cell", "headcell_field2" ),
5, new XVar( "cell", "headcell_field3" ),
6, new XVar( "cell", "headcell_field4" ),
7, new XVar( "cell", "headcell_field5" ),
8, new XVar( "cell", "headcell_field6" ),
9, new XVar( "cell", "headcell_field7" ),
10, new XVar( "cell", "headcell_field8" ),
11, new XVar( "cell", "headcell_field9" ),
12, new XVar( "cell", "headcell_field10" ),
13, new XVar( "cell", "headcell_field11" ),
14, new XVar( "cell", "headcell_field12" ),
15, new XVar( "cell", "headcell_field13" ) ) ),
1, new XVar( "section", "body",
"cells", new XVar( 0, new XVar( "cell", "cell_icons" ),
1, new XVar( "cell", "cell_checkbox" ),
2, new XVar( "cell", "cell_field" ),
3, new XVar( "cell", "cell_field1" ),
4, new XVar( "cell", "cell_field2" ),
5, new XVar( "cell", "cell_field3" ),
6, new XVar( "cell", "cell_field4" ),
7, new XVar( "cell", "cell_field5" ),
8, new XVar( "cell", "cell_field6" ),
9, new XVar( "cell", "cell_field7" ),
10, new XVar( "cell", "cell_field8" ),
11, new XVar( "cell", "cell_field9" ),
12, new XVar( "cell", "cell_field10" ),
13, new XVar( "cell", "cell_field11" ),
14, new XVar( "cell", "cell_field12" ),
15, new XVar( "cell", "cell_field13" ) ) ),
2, new XVar( "section", "foot",
"cells", new XVar( 0, new XVar( "cell", "footcell_icons" ),
1, new XVar( "cell", "footcell_checkbox" ),
2, new XVar( "cell", "footcell_field" ),
3, new XVar( "cell", "footcell_field1" ),
4, new XVar( "cell", "footcell_field2" ),
5, new XVar( "cell", "footcell_field3" ),
6, new XVar( "cell", "footcell_field4" ),
7, new XVar( "cell", "footcell_field5" ),
8, new XVar( "cell", "footcell_field6" ),
9, new XVar( "cell", "footcell_field7" ),
10, new XVar( "cell", "footcell_field8" ),
11, new XVar( "cell", "footcell_field9" ),
12, new XVar( "cell", "footcell_field10" ),
13, new XVar( "cell", "footcell_field11" ),
14, new XVar( "cell", "footcell_field12" ),
15, new XVar( "cell", "footcell_field13" ) ) ) ),
"cells", new XVar( "headcell_field", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field11" ),
"field", "id_compesados",
"columnName", "field" ),
"cell_field", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field" ),
"field", "id_compesados",
"columnName", "field" ),
"footcell_field", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field1", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field15" ),
"field", "fecha_creacion",
"columnName", "field" ),
"cell_field1", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field2" ),
"field", "fecha_creacion",
"columnName", "field" ),
"footcell_field1", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field2", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field16" ),
"field", "ONI",
"columnName", "field" ),
"cell_field2", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field1" ),
"field", "ONI",
"columnName", "field" ),
"footcell_field2", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field3", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field17" ),
"field", "nombre",
"columnName", "field" ),
"cell_field3", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field12" ),
"field", "nombre",
"columnName", "field" ),
"footcell_field3", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field4", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field18" ),
"field", "departamento",
"columnName", "field" ),
"cell_field4", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field10" ),
"field", "departamento",
"columnName", "field" ),
"footcell_field4", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field5", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field19" ),
"field", "desde",
"columnName", "field" ),
"cell_field5", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field3" ),
"field", "desde",
"columnName", "field" ),
"footcell_field5", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field6", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field20" ),
"field", "hasta",
"columnName", "field" ),
"cell_field6", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field4" ),
"field", "hasta",
"columnName", "field" ),
"footcell_field6", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field7", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field21" ),
"field", "justificacion",
"columnName", "field" ),
"cell_field7", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field6" ),
"field", "justificacion",
"columnName", "field" ),
"footcell_field7", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field8", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field22" ),
"field", "anexo",
"columnName", "field" ),
"cell_field8", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field7" ),
"field", "anexo",
"columnName", "field" ),
"footcell_field8", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field9", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field23" ),
"field", "dias",
"columnName", "field" ),
"cell_field9", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field5" ),
"field", "dias",
"columnName", "field" ),
"footcell_field9", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field10", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field24" ),
"field", "horas",
"columnName", "field" ),
"cell_field10", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field13" ),
"field", "horas",
"columnName", "field" ),
"footcell_field10", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field11", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field25" ),
"field", "minutos",
"columnName", "field" ),
"cell_field11", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field14" ),
"field", "minutos",
"columnName", "field" ),
"footcell_field11", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field12", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field26" ),
"field", "id_estado_compesado",
"columnName", "field" ),
"cell_field12", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field9" ),
"field", "id_estado_compesado",
"columnName", "field" ),
"footcell_field12", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field13", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field27" ),
"field", "observacion",
"columnName", "field" ),
"cell_field13", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field8" ),
"field", "observacion",
"columnName", "field" ),
"footcell_field13", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_icons", new XVar( "model", "headcell_icons",
"items", XVar.Array(),
"columnName", "list-icons" ),
"cell_icons", new XVar( "model", "cell_icons",
"items", new XVar( 0, "grid_inline_edit",
1, "grid_inline_save",
2, "grid_inline_cancel",
3, "grid_view" ),
"columnName", "list-icons" ),
"footcell_icons", new XVar( "model", "footcell_icons",
"items", XVar.Array(),
"columnName", "list-icons" ),
"headcell_checkbox", new XVar( "model", "headcell_checkbox",
"items", new XVar( 0, "grid_checkbox_head" ),
"columnName", "checkbox" ),
"cell_checkbox", new XVar( "model", "cell_checkbox",
"items", new XVar( 0, "grid_checkbox" ),
"columnName", "checkbox" ),
"footcell_checkbox", new XVar( "model", "footcell_checkbox",
"items", XVar.Array(),
"columnName", "checkbox" ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ) ),
"items", new XVar( "page_size", new XVar( "type", "page_size" ),
"details_found", new XVar( "type", "details_found" ),
"breadcrumb", new XVar( "type", "breadcrumb" ),
"logo", new XVar( "type", "logo" ),
"menu", new XVar( "type", "menu" ),
"simple_search", new XVar( "type", "simple_search" ),
"pagination", new XVar( "type", "pagination" ),
"list_options", new XVar( "type", "list_options",
"items", new XVar( 0, "edit_selected",
1, "export_selected",
2, "-3",
3, "advsearch_link",
4, "show_search_panel",
5, "hide_search_panel",
6, "-1",
7, "export" ) ),
"export", new XVar( "type", "export" ),
"-", new XVar( "type", "-" ),
"export_selected", new XVar( "type", "export_selected" ),
"-1", new XVar( "type", "-" ),
"-2", new XVar( "type", "-" ),
"advsearch_link", new XVar( "type", "advsearch_link" ),
"-3", new XVar( "type", "-" ),
"master_info", new XVar( "type", "master_info",
"tables", new XVar( "dbo.EMPLEADO", "true",
"dbo.ESTADO_COMPESADO", "true",
"Saldo_Horas_Empleado", "true",
"admin_members", "true" ) ),
"username_button", new XVar( "type", "username_button",
"items", new XVar( 0, "logout_link",
1, "adminarea_link",
2, "changepassword_link" ) ),
"changepassword_link", new XVar( "type", "changepassword_link" ),
"adminarea_link", new XVar( "type", "adminarea_link" ),
"loginform_login", new XVar( "type", "loginform_login",
"popup", false ),
"logout_link", new XVar( "type", "logout_link" ),
"edit_selected", new XVar( "type", "edit_selected" ),
"inline_save_all", new XVar( "type", "inline_save_all" ),
"inline_cancel_all", new XVar( "type", "inline_cancel_all" ),
"search_panel", new XVar( "type", "search_panel",
"items", new XVar( 0, "search_panel_field",
1, "search_panel_field7",
2, "search_panel_field6",
3, "search_panel_field5",
4, "search_panel_field4",
5, "search_panel_field3",
6, "search_panel_field2",
7, "search_panel_field1" ),
"_flexiblePanel", true ),
"search_panel_field", new XVar( "field", "fecha_creacion",
"type", "search_panel_field",
"required", false,
"alwaysOnPanel", false ),
"search_panel_field1", new XVar( "field", "desde",
"type", "search_panel_field",
"required", false,
"alwaysOnPanel", false ),
"search_panel_field2", new XVar( "field", "hasta",
"type", "search_panel_field",
"required", false,
"alwaysOnPanel", false ),
"search_panel_field3", new XVar( "field", "dias",
"type", "search_panel_field",
"required", false,
"alwaysOnPanel", false ),
"search_panel_field4", new XVar( "field", "horas",
"type", "search_panel_field",
"required", false,
"alwaysOnPanel", false ),
"search_panel_field5", new XVar( "field", "minutos",
"type", "search_panel_field",
"required", false,
"alwaysOnPanel", false ),
"show_search_panel", new XVar( "type", "show_search_panel" ),
"hide_search_panel", new XVar( "type", "hide_search_panel" ),
"search_panel_field6", new XVar( "field", "departamento",
"type", "search_panel_field",
"required", false,
"alwaysOnPanel", false ),
"search_panel_field7", new XVar( "field", "id_estado_compesado",
"type", "search_panel_field" ),
"simple_grid_field", new XVar( "field", "id_compesados",
"type", "grid_field",
"inlineAdd", false,
"inlineEdit", false,
"clickSort", true ),
"simple_grid_field11", new XVar( "type", "grid_field_label",
"field", "id_compesados",
"clickSort", true ),
"simple_grid_field2", new XVar( "field", "fecha_creacion",
"type", "grid_field",
"inlineAdd", false,
"inlineEdit", false ),
"simple_grid_field15", new XVar( "type", "grid_field_label",
"field", "fecha_creacion" ),
"simple_grid_field1", new XVar( "field", "ONI",
"type", "grid_field",
"inlineAdd", false,
"inlineEdit", false,
"clickSort", true ),
"simple_grid_field16", new XVar( "type", "grid_field_label",
"field", "ONI",
"clickSort", true ),
"simple_grid_field12", new XVar( "field", "nombre",
"type", "grid_field",
"inlineAdd", false,
"inlineEdit", false,
"clickSort", true ),
"simple_grid_field17", new XVar( "type", "grid_field_label",
"field", "nombre",
"clickSort", true ),
"simple_grid_field10", new XVar( "field", "departamento",
"type", "grid_field",
"inlineAdd", false,
"inlineEdit", false ),
"simple_grid_field18", new XVar( "type", "grid_field_label",
"field", "departamento" ),
"simple_grid_field3", new XVar( "field", "desde",
"type", "grid_field",
"inlineAdd", false,
"inlineEdit", false ),
"simple_grid_field19", new XVar( "type", "grid_field_label",
"field", "desde" ),
"simple_grid_field4", new XVar( "field", "hasta",
"type", "grid_field",
"inlineAdd", false,
"inlineEdit", false ),
"simple_grid_field20", new XVar( "type", "grid_field_label",
"field", "hasta" ),
"simple_grid_field6", new XVar( "field", "justificacion",
"type", "grid_field",
"inlineAdd", false,
"inlineEdit", false,
"clickSort", true ),
"simple_grid_field21", new XVar( "type", "grid_field_label",
"field", "justificacion",
"clickSort", true ),
"simple_grid_field7", new XVar( "field", "anexo",
"type", "grid_field",
"inlineAdd", false,
"inlineEdit", false,
"clickSort", true ),
"simple_grid_field22", new XVar( "type", "grid_field_label",
"field", "anexo",
"clickSort", true ),
"simple_grid_field5", new XVar( "field", "dias",
"type", "grid_field",
"inlineAdd", false,
"inlineEdit", false ),
"simple_grid_field23", new XVar( "type", "grid_field_label",
"field", "dias" ),
"simple_grid_field13", new XVar( "field", "horas",
"type", "grid_field",
"inlineAdd", false,
"inlineEdit", false ),
"simple_grid_field24", new XVar( "type", "grid_field_label",
"field", "horas" ),
"simple_grid_field14", new XVar( "field", "minutos",
"type", "grid_field",
"inlineAdd", false,
"inlineEdit", false ),
"simple_grid_field25", new XVar( "type", "grid_field_label",
"field", "minutos" ),
"simple_grid_field9", new XVar( "field", "id_estado_compesado",
"type", "grid_field",
"inlineAdd", false,
"inlineEdit", true,
"clickSort", true ),
"simple_grid_field26", new XVar( "type", "grid_field_label",
"field", "id_estado_compesado",
"clickSort", true ),
"simple_grid_field8", new XVar( "field", "observacion",
"type", "grid_field",
"inlineAdd", false,
"inlineEdit", true,
"clickSort", true ),
"simple_grid_field27", new XVar( "type", "grid_field_label",
"field", "observacion",
"clickSort", true ),
"grid_view", new XVar( "type", "grid_view",
"popup", false ),
"grid_checkbox", new XVar( "type", "grid_checkbox" ),
"grid_checkbox_head", new XVar( "type", "grid_checkbox_head" ),
"grid_inline_edit", new XVar( "type", "grid_inline_edit" ),
"grid_inline_save", new XVar( "type", "grid_inline_save" ),
"grid_inline_cancel", new XVar( "type", "grid_inline_cancel" ),
"inline_add", new XVar( "type", "inline_add",
"detailsOnly", true ) ),
"dbProps", new XVar(  ),
"version", 2,
"fixedTopbar", false );
				}
			}
		}