
		// dbo.EMPLEADO
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
			public static partial class Options_dbo_EMPLEADO_masterlist
			{
				static public XVar options()
				{
					return new XVar( "fields", new XVar( "gridFields", new XVar( 0, "ONI",
1, "nombre",
2, "password",
3, "id_tipo",
4, "id_departamento",
5, "id_horarios",
6, "foto",
7, "id_grupo" ),
"searchRequiredFields", XVar.Array(),
"searchPanelFields", XVar.Array(),
"fieldItems", new XVar( "ONI", new XVar( 0, "simple_grid_field",
1, "simple_grid_field7" ),
"nombre", new XVar( 0, "simple_grid_field1",
1, "simple_grid_field9" ),
"password", new XVar( 0, "simple_grid_field2",
1, "simple_grid_field10" ),
"id_tipo", new XVar( 0, "simple_grid_field3",
1, "simple_grid_field11" ),
"id_departamento", new XVar( 0, "simple_grid_field4",
1, "simple_grid_field12" ),
"id_horarios", new XVar( 0, "simple_grid_field5",
1, "simple_grid_field13" ),
"foto", new XVar( 0, "simple_grid_field8",
1, "simple_grid_field14" ),
"id_grupo", new XVar( 0, "simple_grid_field6",
1, "simple_grid_field15" ) ) ),
"pageLinks", new XVar( "edit", false,
"add", false,
"view", false,
"print", false ),
"layoutHelper", new XVar( "formItems", new XVar( "formItems", new XVar( "top", new XVar( 0, "back_master",
1, "masterlist_header" ),
"above-grid", new XVar( 0, "inline_add" ),
"below-grid", XVar.Array(),
"grid", new XVar( 0, "simple_grid_field7",
1, "simple_grid_field",
2, "simple_grid_field9",
3, "simple_grid_field1",
4, "simple_grid_field10",
5, "simple_grid_field2",
6, "simple_grid_field11",
7, "simple_grid_field3",
8, "simple_grid_field12",
9, "simple_grid_field4",
10, "simple_grid_field13",
11, "simple_grid_field5",
12, "simple_grid_field14",
13, "simple_grid_field8",
14, "simple_grid_field15",
15, "simple_grid_field6",
16, "grid_inline_cancel" ) ),
"formXtTags", new XVar( "above-grid", new XVar( 0, "inlineadd_link" ),
"below-grid", XVar.Array() ),
"itemForms", new XVar( "back_master", "top",
"masterlist_header", "top",
"inline_add", "above-grid",
"simple_grid_field7", "grid",
"simple_grid_field", "grid",
"simple_grid_field9", "grid",
"simple_grid_field1", "grid",
"simple_grid_field10", "grid",
"simple_grid_field2", "grid",
"simple_grid_field11", "grid",
"simple_grid_field3", "grid",
"simple_grid_field12", "grid",
"simple_grid_field4", "grid",
"simple_grid_field13", "grid",
"simple_grid_field5", "grid",
"simple_grid_field14", "grid",
"simple_grid_field8", "grid",
"simple_grid_field15", "grid",
"simple_grid_field6", "grid",
"grid_inline_cancel", "grid" ),
"itemLocations", new XVar( "simple_grid_field7", new XVar( "location", "grid",
"cellId", "headcell_field" ),
"simple_grid_field", new XVar( "location", "grid",
"cellId", "cell_field" ),
"simple_grid_field9", new XVar( "location", "grid",
"cellId", "headcell_field1" ),
"simple_grid_field1", new XVar( "location", "grid",
"cellId", "cell_field1" ),
"simple_grid_field10", new XVar( "location", "grid",
"cellId", "headcell_field2" ),
"simple_grid_field2", new XVar( "location", "grid",
"cellId", "cell_field2" ),
"simple_grid_field11", new XVar( "location", "grid",
"cellId", "headcell_field3" ),
"simple_grid_field3", new XVar( "location", "grid",
"cellId", "cell_field3" ),
"simple_grid_field12", new XVar( "location", "grid",
"cellId", "headcell_field4" ),
"simple_grid_field4", new XVar( "location", "grid",
"cellId", "cell_field4" ),
"simple_grid_field13", new XVar( "location", "grid",
"cellId", "headcell_field5" ),
"simple_grid_field5", new XVar( "location", "grid",
"cellId", "cell_field5" ),
"simple_grid_field14", new XVar( "location", "grid",
"cellId", "headcell_field6" ),
"simple_grid_field8", new XVar( "location", "grid",
"cellId", "cell_field6" ),
"simple_grid_field15", new XVar( "location", "grid",
"cellId", "headcell_field7" ),
"simple_grid_field6", new XVar( "location", "grid",
"cellId", "cell_field7" ),
"grid_inline_cancel", new XVar( "location", "grid",
"cellId", "cell_icons" ) ),
"itemVisiblity", new XVar(  ) ),
"itemsByType", new XVar( "masterlist_header", new XVar( 0, "masterlist_header" ),
"back_master", new XVar( 0, "back_master" ),
"grid_field", new XVar( 0, "simple_grid_field",
1, "simple_grid_field1",
2, "simple_grid_field2",
3, "simple_grid_field3",
4, "simple_grid_field4",
5, "simple_grid_field5",
6, "simple_grid_field8",
7, "simple_grid_field6" ),
"grid_field_label", new XVar( 0, "simple_grid_field7",
1, "simple_grid_field9",
2, "simple_grid_field10",
3, "simple_grid_field11",
4, "simple_grid_field12",
5, "simple_grid_field13",
6, "simple_grid_field14",
7, "simple_grid_field15" ),
"inline_add", new XVar( 0, "inline_add" ),
"grid_inline_cancel", new XVar( 0, "grid_inline_cancel" ) ),
"cellMaps", new XVar( "grid", new XVar( "cells", new XVar( "headcell_icons", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 0 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field", new XVar( "cols", new XVar( 0, 1 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "ONI_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field7" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field1", new XVar( "cols", new XVar( 0, 2 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "nombre_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field9" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field2", new XVar( "cols", new XVar( 0, 3 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "password_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field10" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field3", new XVar( "cols", new XVar( 0, 4 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "id_tipo_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field11" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field4", new XVar( "cols", new XVar( 0, 5 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "id_departamento_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field12" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field5", new XVar( "cols", new XVar( 0, 6 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "id_horarios_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field13" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field6", new XVar( "cols", new XVar( 0, 7 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "foto_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field14" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field7", new XVar( "cols", new XVar( 0, 8 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "id_grupo_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field15" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_icons", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "inline_cancel" ),
"items", new XVar( 0, "grid_inline_cancel" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field", new XVar( "cols", new XVar( 0, 1 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "ONI_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field1", new XVar( "cols", new XVar( 0, 2 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "nombre_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field1" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field2", new XVar( "cols", new XVar( 0, 3 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "password_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field2" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field3", new XVar( "cols", new XVar( 0, 4 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "id_tipo_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field3" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field4", new XVar( "cols", new XVar( 0, 5 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "id_departamento_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field4" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field5", new XVar( "cols", new XVar( 0, 6 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "id_horarios_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field5" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field6", new XVar( "cols", new XVar( 0, 7 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "foto_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field8" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field7", new XVar( "cols", new XVar( 0, 8 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "id_grupo_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field6" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_icons", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field", new XVar( "cols", new XVar( 0, 1 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field1", new XVar( "cols", new XVar( 0, 2 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field2", new XVar( "cols", new XVar( 0, 3 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field3", new XVar( "cols", new XVar( 0, 4 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field4", new XVar( "cols", new XVar( 0, 5 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field5", new XVar( "cols", new XVar( 0, 6 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field6", new XVar( "cols", new XVar( 0, 7 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field7", new XVar( "cols", new XVar( 0, 8 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ) ),
"width", 9,
"height", 3 ) ) ),
"loginForm", new XVar( "loginForm", 3 ),
"page", new XVar( "labeledButtons", new XVar( "update_records", new XVar(  ),
"print_pages", new XVar(  ),
"register_activate_message", new XVar(  ) ),
"gridType", 0 ),
"misc", new XVar( "type", "masterlist",
"breadcrumb", false ),
"events", new XVar( "maps", XVar.Array(),
"mapsData", new XVar(  ),
"buttons", XVar.Array() ) );
				}
				static public XVar page()
				{
					return new XVar( "id", "masterlist",
"type", "masterlist",
"layoutId", "masterlist",
"disabled", 0,
"default", 0,
"forms", new XVar( "top", new XVar( "modelId", "masterlist-top",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "back_master",
1, "masterlist_header" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"above-grid", new XVar( "modelId", "empty-above-grid",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "inline_add" ) ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"below-grid", new XVar( "modelId", "empty-above-grid",
"grid", XVar.Array(),
"cells", new XVar(  ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"grid", new XVar( "modelId", "horizontal-grid",
"grid", new XVar( 0, new XVar( "section", "head",
"cells", new XVar( 0, new XVar( "cell", "headcell_icons" ),
1, new XVar( "cell", "headcell_field" ),
2, new XVar( "cell", "headcell_field1" ),
3, new XVar( "cell", "headcell_field2" ),
4, new XVar( "cell", "headcell_field3" ),
5, new XVar( "cell", "headcell_field4" ),
6, new XVar( "cell", "headcell_field5" ),
7, new XVar( "cell", "headcell_field6" ),
8, new XVar( "cell", "headcell_field7" ) ) ),
1, new XVar( "section", "body",
"cells", new XVar( 0, new XVar( "cell", "cell_icons" ),
1, new XVar( "cell", "cell_field" ),
2, new XVar( "cell", "cell_field1" ),
3, new XVar( "cell", "cell_field2" ),
4, new XVar( "cell", "cell_field3" ),
5, new XVar( "cell", "cell_field4" ),
6, new XVar( "cell", "cell_field5" ),
7, new XVar( "cell", "cell_field6" ),
8, new XVar( "cell", "cell_field7" ) ) ),
2, new XVar( "section", "foot",
"cells", new XVar( 0, new XVar( "cell", "footcell_icons" ),
1, new XVar( "cell", "footcell_field" ),
2, new XVar( "cell", "footcell_field1" ),
3, new XVar( "cell", "footcell_field2" ),
4, new XVar( "cell", "footcell_field3" ),
5, new XVar( "cell", "footcell_field4" ),
6, new XVar( "cell", "footcell_field5" ),
7, new XVar( "cell", "footcell_field6" ),
8, new XVar( "cell", "footcell_field7" ) ) ) ),
"cells", new XVar( "headcell_field", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field7" ),
"field", "ONI",
"columnName", "field" ),
"cell_field", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field" ),
"field", "ONI",
"columnName", "field" ),
"footcell_field", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field1", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field9" ),
"field", "nombre",
"columnName", "field" ),
"cell_field1", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field1" ),
"field", "nombre",
"columnName", "field" ),
"footcell_field1", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field2", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field10" ),
"field", "password",
"columnName", "field" ),
"cell_field2", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field2" ),
"field", "password",
"columnName", "field" ),
"footcell_field2", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field3", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field11" ),
"field", "id_tipo",
"columnName", "field" ),
"cell_field3", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field3" ),
"field", "id_tipo",
"columnName", "field" ),
"footcell_field3", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field4", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field12" ),
"field", "id_departamento",
"columnName", "field" ),
"cell_field4", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field4" ),
"field", "id_departamento",
"columnName", "field" ),
"footcell_field4", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field5", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field13" ),
"field", "id_horarios",
"columnName", "field" ),
"cell_field5", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field5" ),
"field", "id_horarios",
"columnName", "field" ),
"footcell_field5", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field6", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field14" ),
"field", "foto",
"columnName", "field" ),
"cell_field6", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field8" ),
"field", "foto",
"columnName", "field" ),
"footcell_field6", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field7", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field15" ),
"field", "id_grupo",
"columnName", "field" ),
"cell_field7", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field6" ),
"field", "id_grupo",
"columnName", "field" ),
"footcell_field7", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_icons", new XVar( "model", "headcell_icons",
"items", XVar.Array() ),
"cell_icons", new XVar( "model", "cell_icons",
"items", new XVar( 0, "grid_inline_cancel" ) ),
"footcell_icons", new XVar( "model", "footcell_icons",
"items", XVar.Array() ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ) ),
"items", new XVar( "masterlist_header", new XVar( "type", "masterlist_header" ),
"back_master", new XVar( "type", "back_master" ),
"simple_grid_field", new XVar( "field", "ONI",
"type", "grid_field" ),
"simple_grid_field7", new XVar( "type", "grid_field_label",
"field", "ONI" ),
"simple_grid_field1", new XVar( "field", "nombre",
"type", "grid_field" ),
"simple_grid_field9", new XVar( "type", "grid_field_label",
"field", "nombre" ),
"simple_grid_field2", new XVar( "field", "password",
"type", "grid_field" ),
"simple_grid_field10", new XVar( "type", "grid_field_label",
"field", "password" ),
"simple_grid_field3", new XVar( "field", "id_tipo",
"type", "grid_field" ),
"simple_grid_field11", new XVar( "type", "grid_field_label",
"field", "id_tipo" ),
"simple_grid_field4", new XVar( "field", "id_departamento",
"type", "grid_field" ),
"simple_grid_field12", new XVar( "type", "grid_field_label",
"field", "id_departamento" ),
"simple_grid_field5", new XVar( "field", "id_horarios",
"type", "grid_field" ),
"simple_grid_field13", new XVar( "type", "grid_field_label",
"field", "id_horarios" ),
"simple_grid_field8", new XVar( "field", "foto",
"type", "grid_field" ),
"simple_grid_field14", new XVar( "type", "grid_field_label",
"field", "foto" ),
"simple_grid_field6", new XVar( "field", "id_grupo",
"type", "grid_field" ),
"simple_grid_field15", new XVar( "type", "grid_field_label",
"field", "id_grupo" ),
"inline_add", new XVar( "type", "inline_add",
"detailsOnly", true ),
"grid_inline_cancel", new XVar( "type", "grid_inline_cancel" ) ),
"dbProps", new XVar(  ),
"version", 2 );
				}
			}
		}