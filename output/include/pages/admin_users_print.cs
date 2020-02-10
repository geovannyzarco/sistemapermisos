
		// admin_users
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
			public static partial class Options_admin_users_print
			{
				static public XVar options()
				{
					return new XVar( "pdf", new XVar( "pdfView", false ),
"totals", new XVar( "foto", new XVar( "totalsType", "" ),
"ONI", new XVar( "totalsType", "" ),
"nombre", new XVar( "totalsType", "" ),
"password", new XVar( "totalsType", "" ),
"id_tipo", new XVar( "totalsType", "" ),
"id_departamento", new XVar( "totalsType", "" ),
"id_horarios", new XVar( "totalsType", "" ),
"saldo_personales", new XVar( "totalsType", "" ),
"saldo_compesado", new XVar( "totalsType", "" ) ),
"fields", new XVar( "gridFields", new XVar( 0, "ONI",
1, "nombre",
2, "password",
3, "id_tipo",
4, "id_departamento",
5, "id_horarios",
6, "saldo_personales",
7, "saldo_compesado",
8, "foto" ),
"searchRequiredFields", XVar.Array(),
"searchPanelFields", XVar.Array(),
"fieldItems", new XVar( "ONI", new XVar( 0, "simple_grid_field",
1, "simple_grid_field9" ),
"nombre", new XVar( 0, "simple_grid_field1",
1, "simple_grid_field10" ),
"password", new XVar( 0, "simple_grid_field2",
1, "simple_grid_field11" ),
"id_tipo", new XVar( 0, "simple_grid_field3",
1, "simple_grid_field12" ),
"id_departamento", new XVar( 0, "simple_grid_field4",
1, "simple_grid_field13" ),
"id_horarios", new XVar( 0, "simple_grid_field5",
1, "simple_grid_field14" ),
"saldo_personales", new XVar( 0, "simple_grid_field6",
1, "simple_grid_field15" ),
"saldo_compesado", new XVar( 0, "simple_grid_field7",
1, "simple_grid_field16" ),
"foto", new XVar( 0, "simple_grid_field8",
1, "simple_grid_field17" ) ) ),
"pageLinks", new XVar( "edit", false,
"add", false,
"view", false,
"print", false ),
"layoutHelper", new XVar( "formItems", new XVar( "formItems", new XVar( "top", new XVar( 0, "print_header",
1, "print_subheader" ),
"above-grid", new XVar( 0, "print_pages" ),
"below-grid", XVar.Array(),
"grid", new XVar( 0, "simple_grid_field9",
1, "simple_grid_field",
2, "simple_grid_field10",
3, "simple_grid_field1",
4, "simple_grid_field11",
5, "simple_grid_field2",
6, "simple_grid_field12",
7, "simple_grid_field3",
8, "simple_grid_field13",
9, "simple_grid_field4",
10, "simple_grid_field14",
11, "simple_grid_field5",
12, "simple_grid_field15",
13, "simple_grid_field6",
14, "simple_grid_field16",
15, "simple_grid_field7",
16, "simple_grid_field17",
17, "simple_grid_field8",
18, "details_preview",
19, "details_preview1",
20, "details_preview2" ) ),
"formXtTags", new XVar( "above-grid", new XVar( 0, "print_pages" ),
"below-grid", XVar.Array() ),
"itemForms", new XVar( "print_header", "top",
"print_subheader", "top",
"print_pages", "above-grid",
"simple_grid_field9", "grid",
"simple_grid_field", "grid",
"simple_grid_field10", "grid",
"simple_grid_field1", "grid",
"simple_grid_field11", "grid",
"simple_grid_field2", "grid",
"simple_grid_field12", "grid",
"simple_grid_field3", "grid",
"simple_grid_field13", "grid",
"simple_grid_field4", "grid",
"simple_grid_field14", "grid",
"simple_grid_field5", "grid",
"simple_grid_field15", "grid",
"simple_grid_field6", "grid",
"simple_grid_field16", "grid",
"simple_grid_field7", "grid",
"simple_grid_field17", "grid",
"simple_grid_field8", "grid",
"details_preview", "grid",
"details_preview1", "grid",
"details_preview2", "grid" ),
"itemLocations", new XVar( "simple_grid_field9", new XVar( "location", "grid",
"cellId", "headcell_field" ),
"simple_grid_field", new XVar( "location", "grid",
"cellId", "cell_field" ),
"simple_grid_field10", new XVar( "location", "grid",
"cellId", "headcell_field1" ),
"simple_grid_field1", new XVar( "location", "grid",
"cellId", "cell_field1" ),
"simple_grid_field11", new XVar( "location", "grid",
"cellId", "headcell_field2" ),
"simple_grid_field2", new XVar( "location", "grid",
"cellId", "cell_field2" ),
"simple_grid_field12", new XVar( "location", "grid",
"cellId", "headcell_field3" ),
"simple_grid_field3", new XVar( "location", "grid",
"cellId", "cell_field3" ),
"simple_grid_field13", new XVar( "location", "grid",
"cellId", "headcell_field4" ),
"simple_grid_field4", new XVar( "location", "grid",
"cellId", "cell_field4" ),
"simple_grid_field14", new XVar( "location", "grid",
"cellId", "headcell_field5" ),
"simple_grid_field5", new XVar( "location", "grid",
"cellId", "cell_field5" ),
"simple_grid_field15", new XVar( "location", "grid",
"cellId", "headcell_field6" ),
"simple_grid_field6", new XVar( "location", "grid",
"cellId", "cell_field6" ),
"simple_grid_field16", new XVar( "location", "grid",
"cellId", "headcell_field7" ),
"simple_grid_field7", new XVar( "location", "grid",
"cellId", "cell_field7" ),
"simple_grid_field17", new XVar( "location", "grid",
"cellId", "headcell_field8" ),
"simple_grid_field8", new XVar( "location", "grid",
"cellId", "cell_field8" ),
"details_preview", new XVar( "location", "grid",
"cellId", "cell_dpreview" ),
"details_preview1", new XVar( "location", "grid",
"cellId", "cell_dpreview" ),
"details_preview2", new XVar( "location", "grid",
"cellId", "cell_dpreview" ) ),
"itemVisiblity", new XVar(  ) ),
"itemsByType", new XVar( "print_header", new XVar( 0, "print_header" ),
"print_subheader", new XVar( 0, "print_subheader" ),
"print_pages", new XVar( 0, "print_pages" ),
"grid_field", new XVar( 0, "simple_grid_field",
1, "simple_grid_field1",
2, "simple_grid_field2",
3, "simple_grid_field3",
4, "simple_grid_field4",
5, "simple_grid_field5",
6, "simple_grid_field6",
7, "simple_grid_field7",
8, "simple_grid_field8" ),
"grid_field_label", new XVar( 0, "simple_grid_field9",
1, "simple_grid_field10",
2, "simple_grid_field11",
3, "simple_grid_field12",
4, "simple_grid_field13",
5, "simple_grid_field14",
6, "simple_grid_field15",
7, "simple_grid_field16",
8, "simple_grid_field17" ),
"details_preview", new XVar( 0, "details_preview",
1, "details_preview1",
2, "details_preview2" ) ),
"cellMaps", new XVar( "grid", new XVar( "cells", new XVar( "headcell_field", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "ONI_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field9" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field1", new XVar( "cols", new XVar( 0, 1 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "nombre_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field10" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field2", new XVar( "cols", new XVar( 0, 2 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "password_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field11" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field3", new XVar( "cols", new XVar( 0, 3 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "id_tipo_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field12" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field4", new XVar( "cols", new XVar( 0, 4 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "id_departamento_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field13" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field5", new XVar( "cols", new XVar( 0, 5 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "id_horarios_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field14" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field6", new XVar( "cols", new XVar( 0, 6 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "saldo_personales_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field15" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field7", new XVar( "cols", new XVar( 0, 7 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "saldo_compesado_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field16" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field8", new XVar( "cols", new XVar( 0, 8 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "foto_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field17" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "ONI_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field1", new XVar( "cols", new XVar( 0, 1 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "nombre_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field1" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field2", new XVar( "cols", new XVar( 0, 2 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "password_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field2" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field3", new XVar( "cols", new XVar( 0, 3 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "id_tipo_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field3" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field4", new XVar( "cols", new XVar( 0, 4 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "id_departamento_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field4" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field5", new XVar( "cols", new XVar( 0, 5 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "id_horarios_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field5" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field6", new XVar( "cols", new XVar( 0, 6 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "saldo_personales_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field6" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field7", new XVar( "cols", new XVar( 0, 7 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "saldo_compesado_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field7" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field8", new XVar( "cols", new XVar( 0, 8 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "foto_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field8" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_dpreview", new XVar( "cols", new XVar( 0, 0,
1, 1,
2, 2,
3, 3,
4, 4,
5, 5,
6, 6,
7, 7,
8, 8 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", new XVar( 0, "details_preview",
1, "details_preview1",
2, "details_preview2" ),
"fixedAtServer", true,
"fixedAtClient", false ),
"footcell_field", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 3 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field1", new XVar( "cols", new XVar( 0, 1 ),
"rows", new XVar( 0, 3 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field2", new XVar( "cols", new XVar( 0, 2 ),
"rows", new XVar( 0, 3 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field3", new XVar( "cols", new XVar( 0, 3 ),
"rows", new XVar( 0, 3 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field4", new XVar( "cols", new XVar( 0, 4 ),
"rows", new XVar( 0, 3 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field5", new XVar( "cols", new XVar( 0, 5 ),
"rows", new XVar( 0, 3 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field6", new XVar( "cols", new XVar( 0, 6 ),
"rows", new XVar( 0, 3 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field7", new XVar( "cols", new XVar( 0, 7 ),
"rows", new XVar( 0, 3 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field8", new XVar( "cols", new XVar( 0, 8 ),
"rows", new XVar( 0, 3 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ) ),
"width", 9,
"height", 4 ) ) ),
"loginForm", new XVar( "loginForm", 3 ),
"page", new XVar( "labeledButtons", new XVar( "update_records", new XVar(  ),
"print_pages", new XVar( "print_pages", new XVar( "tag", "PRINT_PAGES",
"type", 2 ) ),
"register_activate_message", new XVar(  ) ),
"gridType", 0,
"recsPerRow", 1 ),
"misc", new XVar( "type", "print",
"breadcrumb", false ),
"events", new XVar( "maps", XVar.Array(),
"mapsData", new XVar(  ),
"buttons", XVar.Array() ),
"dataGrid", new XVar( "groupFields", XVar.Array() ) );
				}
				static public XVar page()
				{
					return new XVar( "id", "print",
"type", "print",
"layoutId", "basic",
"disabled", 0,
"default", 0,
"forms", new XVar( "top", new XVar( "modelId", "print-header",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c2" ) ),
"section", "" ) ),
"cells", new XVar( "c2", new XVar( "model", "c2",
"items", new XVar( 0, "print_header",
1, "print_subheader" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"above-grid", new XVar( "modelId", "print-above-grid",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "print_pages" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"below-grid", new XVar( "modelId", "print-below-grid",
"grid", XVar.Array(),
"cells", new XVar(  ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"grid", new XVar( "modelId", "horizontal-grid",
"grid", new XVar( 0, new XVar( "section", "head",
"cells", new XVar( 0, new XVar( "cell", "headcell_field" ),
1, new XVar( "cell", "headcell_field1" ),
2, new XVar( "cell", "headcell_field2" ),
3, new XVar( "cell", "headcell_field3" ),
4, new XVar( "cell", "headcell_field4" ),
5, new XVar( "cell", "headcell_field5" ),
6, new XVar( "cell", "headcell_field6" ),
7, new XVar( "cell", "headcell_field7" ),
8, new XVar( "cell", "headcell_field8" ) ) ),
1, new XVar( "section", "body",
"cells", new XVar( 0, new XVar( "cell", "cell_field" ),
1, new XVar( "cell", "cell_field1" ),
2, new XVar( "cell", "cell_field2" ),
3, new XVar( "cell", "cell_field3" ),
4, new XVar( "cell", "cell_field4" ),
5, new XVar( "cell", "cell_field5" ),
6, new XVar( "cell", "cell_field6" ),
7, new XVar( "cell", "cell_field7" ),
8, new XVar( "cell", "cell_field8" ) ) ),
2, new XVar( "cells", new XVar( 0, new XVar( "cell", "cell_dpreview",
"colspan", 9 ) ),
"section", "body" ),
3, new XVar( "section", "foot",
"cells", new XVar( 0, new XVar( "cell", "footcell_field" ),
1, new XVar( "cell", "footcell_field1" ),
2, new XVar( "cell", "footcell_field2" ),
3, new XVar( "cell", "footcell_field3" ),
4, new XVar( "cell", "footcell_field4" ),
5, new XVar( "cell", "footcell_field5" ),
6, new XVar( "cell", "footcell_field6" ),
7, new XVar( "cell", "footcell_field7" ),
8, new XVar( "cell", "footcell_field8" ) ) ) ),
"cells", new XVar( "headcell_field", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field9" ),
"field", "ONI",
"columnName", "field" ),
"cell_field", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field" ),
"field", "ONI",
"columnName", "field" ),
"footcell_field", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field1", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field10" ),
"field", "nombre",
"columnName", "field" ),
"cell_field1", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field1" ),
"field", "nombre",
"columnName", "field" ),
"footcell_field1", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field2", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field11" ),
"field", "password",
"columnName", "field" ),
"cell_field2", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field2" ),
"field", "password",
"columnName", "field" ),
"footcell_field2", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field3", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field12" ),
"field", "id_tipo",
"columnName", "field" ),
"cell_field3", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field3" ),
"field", "id_tipo",
"columnName", "field" ),
"footcell_field3", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field4", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field13" ),
"field", "id_departamento",
"columnName", "field" ),
"cell_field4", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field4" ),
"field", "id_departamento",
"columnName", "field" ),
"footcell_field4", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field5", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field14" ),
"field", "id_horarios",
"columnName", "field" ),
"cell_field5", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field5" ),
"field", "id_horarios",
"columnName", "field" ),
"footcell_field5", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field6", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field15" ),
"field", "saldo_personales",
"columnName", "field" ),
"cell_field6", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field6" ),
"field", "saldo_personales",
"columnName", "field" ),
"footcell_field6", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field7", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field16" ),
"field", "saldo_compesado",
"columnName", "field" ),
"cell_field7", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field7" ),
"field", "saldo_compesado",
"columnName", "field" ),
"footcell_field7", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field8", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field17" ),
"field", "foto",
"columnName", "field" ),
"cell_field8", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field8" ),
"field", "foto",
"columnName", "field" ),
"footcell_field8", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"cell_dpreview", new XVar( "model", "cell_dpreview",
"items", new XVar( 0, "details_preview",
1, "details_preview1",
2, "details_preview2" ) ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ) ),
"items", new XVar( "print_header", new XVar( "type", "print_header" ),
"print_subheader", new XVar( "type", "print_subheader" ),
"print_pages", new XVar( "type", "print_pages" ),
"simple_grid_field", new XVar( "field", "ONI",
"type", "grid_field" ),
"simple_grid_field9", new XVar( "type", "grid_field_label",
"field", "ONI" ),
"simple_grid_field1", new XVar( "field", "nombre",
"type", "grid_field" ),
"simple_grid_field10", new XVar( "type", "grid_field_label",
"field", "nombre" ),
"simple_grid_field2", new XVar( "field", "password",
"type", "grid_field" ),
"simple_grid_field11", new XVar( "type", "grid_field_label",
"field", "password" ),
"simple_grid_field3", new XVar( "field", "id_tipo",
"type", "grid_field" ),
"simple_grid_field12", new XVar( "type", "grid_field_label",
"field", "id_tipo" ),
"simple_grid_field4", new XVar( "field", "id_departamento",
"type", "grid_field" ),
"simple_grid_field13", new XVar( "type", "grid_field_label",
"field", "id_departamento" ),
"simple_grid_field5", new XVar( "field", "id_horarios",
"type", "grid_field" ),
"simple_grid_field14", new XVar( "type", "grid_field_label",
"field", "id_horarios" ),
"simple_grid_field6", new XVar( "field", "saldo_personales",
"type", "grid_field" ),
"simple_grid_field15", new XVar( "type", "grid_field_label",
"field", "saldo_personales" ),
"simple_grid_field7", new XVar( "field", "saldo_compesado",
"type", "grid_field" ),
"simple_grid_field16", new XVar( "type", "grid_field_label",
"field", "saldo_compesado" ),
"simple_grid_field8", new XVar( "field", "foto",
"type", "grid_field" ),
"simple_grid_field17", new XVar( "type", "grid_field_label",
"field", "foto" ),
"details_preview", new XVar( "type", "details_preview",
"table", "dbo.Permisos2",
"items", XVar.Array(),
"popup", false ),
"details_preview1", new XVar( "type", "details_preview",
"table", "dbo.REGISTRO_HORAS_COMPESADAS",
"items", XVar.Array(),
"popup", false ),
"details_preview2", new XVar( "type", "details_preview",
"table", "APROBAR_PERMISOS",
"items", XVar.Array(),
"popup", false ) ),
"dbProps", new XVar(  ),
"version", 2 );
				}
			}
		}