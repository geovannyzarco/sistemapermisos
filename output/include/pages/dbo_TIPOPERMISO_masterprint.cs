
		// dbo.TIPOPERMISO
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
			public static partial class Options_dbo_TIPOPERMISO_masterprint
			{
				static public XVar options()
				{
					return new XVar( "fields", new XVar( "gridFields", new XVar( 0, "id_tipopermiso",
1, "tipo_permiso",
2, "horas_asignada",
3, "dias_asignados",
4, "cantidad_permisos" ),
"searchRequiredFields", XVar.Array(),
"searchPanelFields", XVar.Array(),
"fieldItems", new XVar( "id_tipopermiso", new XVar( 0, "simple_grid_field",
1, "simple_grid_field5" ),
"tipo_permiso", new XVar( 0, "simple_grid_field1",
1, "simple_grid_field6" ),
"horas_asignada", new XVar( 0, "simple_grid_field2",
1, "simple_grid_field7" ),
"dias_asignados", new XVar( 0, "simple_grid_field3",
1, "simple_grid_field8" ),
"cantidad_permisos", new XVar( 0, "simple_grid_field4",
1, "simple_grid_field9" ) ) ),
"pageLinks", new XVar( "edit", false,
"add", false,
"view", false,
"print", false ),
"layoutHelper", new XVar( "formItems", new XVar( "formItems", new XVar( "top", new XVar( 0, "masterprint_header" ),
"above-grid", XVar.Array(),
"below-grid", XVar.Array(),
"grid", new XVar( 0, "simple_grid_field5",
1, "simple_grid_field",
2, "simple_grid_field6",
3, "simple_grid_field1",
4, "simple_grid_field7",
5, "simple_grid_field2",
6, "simple_grid_field8",
7, "simple_grid_field3",
8, "simple_grid_field9",
9, "simple_grid_field4" ) ),
"formXtTags", new XVar( "above-grid", XVar.Array(),
"below-grid", XVar.Array() ),
"itemForms", new XVar( "masterprint_header", "top",
"simple_grid_field5", "grid",
"simple_grid_field", "grid",
"simple_grid_field6", "grid",
"simple_grid_field1", "grid",
"simple_grid_field7", "grid",
"simple_grid_field2", "grid",
"simple_grid_field8", "grid",
"simple_grid_field3", "grid",
"simple_grid_field9", "grid",
"simple_grid_field4", "grid" ),
"itemLocations", new XVar( "simple_grid_field5", new XVar( "location", "grid",
"cellId", "headcell_field" ),
"simple_grid_field", new XVar( "location", "grid",
"cellId", "cell_field" ),
"simple_grid_field6", new XVar( "location", "grid",
"cellId", "headcell_field1" ),
"simple_grid_field1", new XVar( "location", "grid",
"cellId", "cell_field1" ),
"simple_grid_field7", new XVar( "location", "grid",
"cellId", "headcell_field2" ),
"simple_grid_field2", new XVar( "location", "grid",
"cellId", "cell_field2" ),
"simple_grid_field8", new XVar( "location", "grid",
"cellId", "headcell_field3" ),
"simple_grid_field3", new XVar( "location", "grid",
"cellId", "cell_field3" ),
"simple_grid_field9", new XVar( "location", "grid",
"cellId", "headcell_field4" ),
"simple_grid_field4", new XVar( "location", "grid",
"cellId", "cell_field4" ) ),
"itemVisiblity", new XVar(  ) ),
"itemsByType", new XVar( "masterprint_header", new XVar( 0, "masterprint_header" ),
"grid_field", new XVar( 0, "simple_grid_field",
1, "simple_grid_field1",
2, "simple_grid_field2",
3, "simple_grid_field3",
4, "simple_grid_field4" ),
"grid_field_label", new XVar( 0, "simple_grid_field5",
1, "simple_grid_field6",
2, "simple_grid_field7",
3, "simple_grid_field8",
4, "simple_grid_field9" ) ),
"cellMaps", new XVar( "grid", new XVar( "cells", new XVar( "headcell_field", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "id_tipopermiso_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field5" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field1", new XVar( "cols", new XVar( 0, 1 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "tipo_permiso_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field6" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field2", new XVar( "cols", new XVar( 0, 2 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "horas_asignada_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field7" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field3", new XVar( "cols", new XVar( 0, 3 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "dias_asignados_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field8" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field4", new XVar( "cols", new XVar( 0, 4 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "cantidad_permisos_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field9" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "id_tipopermiso_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field1", new XVar( "cols", new XVar( 0, 1 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "tipo_permiso_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field1" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field2", new XVar( "cols", new XVar( 0, 2 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "horas_asignada_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field2" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field3", new XVar( "cols", new XVar( 0, 3 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "dias_asignados_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field3" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field4", new XVar( "cols", new XVar( 0, 4 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "cantidad_permisos_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field4" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field1", new XVar( "cols", new XVar( 0, 1 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field2", new XVar( "cols", new XVar( 0, 2 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field3", new XVar( "cols", new XVar( 0, 3 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field4", new XVar( "cols", new XVar( 0, 4 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ) ),
"width", 5,
"height", 3 ) ) ),
"loginForm", new XVar( "loginForm", 3 ),
"page", new XVar( "labeledButtons", new XVar( "update_records", new XVar(  ),
"print_pages", new XVar(  ),
"register_activate_message", new XVar(  ) ),
"gridType", 0 ),
"misc", new XVar( "type", "masterprint",
"breadcrumb", false ),
"events", new XVar( "maps", XVar.Array(),
"mapsData", new XVar(  ),
"buttons", XVar.Array() ) );
				}
				static public XVar page()
				{
					return new XVar( "id", "masterprint",
"type", "masterprint",
"layoutId", "masterprint",
"disabled", 0,
"default", 0,
"forms", new XVar( "top", new XVar( "modelId", "masterlist-top",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "masterprint_header" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"above-grid", new XVar( "modelId", "empty-above-grid",
"grid", XVar.Array(),
"cells", new XVar(  ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"below-grid", new XVar( "modelId", "empty-above-grid",
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
4, new XVar( "cell", "headcell_field4" ) ) ),
1, new XVar( "section", "body",
"cells", new XVar( 0, new XVar( "cell", "cell_field" ),
1, new XVar( "cell", "cell_field1" ),
2, new XVar( "cell", "cell_field2" ),
3, new XVar( "cell", "cell_field3" ),
4, new XVar( "cell", "cell_field4" ) ) ),
2, new XVar( "section", "foot",
"cells", new XVar( 0, new XVar( "cell", "footcell_field" ),
1, new XVar( "cell", "footcell_field1" ),
2, new XVar( "cell", "footcell_field2" ),
3, new XVar( "cell", "footcell_field3" ),
4, new XVar( "cell", "footcell_field4" ) ) ) ),
"cells", new XVar( "headcell_field", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field5" ),
"field", "id_tipopermiso",
"columnName", "field" ),
"cell_field", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field" ),
"field", "id_tipopermiso",
"columnName", "field" ),
"footcell_field", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field1", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field6" ),
"field", "tipo_permiso",
"columnName", "field" ),
"cell_field1", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field1" ),
"field", "tipo_permiso",
"columnName", "field" ),
"footcell_field1", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field2", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field7" ),
"field", "horas_asignada",
"columnName", "field" ),
"cell_field2", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field2" ),
"field", "horas_asignada",
"columnName", "field" ),
"footcell_field2", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field3", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field8" ),
"field", "dias_asignados",
"columnName", "field" ),
"cell_field3", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field3" ),
"field", "dias_asignados",
"columnName", "field" ),
"footcell_field3", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field4", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field9" ),
"field", "cantidad_permisos",
"columnName", "field" ),
"cell_field4", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field4" ),
"field", "cantidad_permisos",
"columnName", "field" ),
"footcell_field4", new XVar( "model", "footcell_field",
"items", XVar.Array() ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ) ),
"items", new XVar( "masterprint_header", new XVar( "type", "masterprint_header" ),
"simple_grid_field", new XVar( "field", "id_tipopermiso",
"type", "grid_field" ),
"simple_grid_field5", new XVar( "type", "grid_field_label",
"field", "id_tipopermiso" ),
"simple_grid_field1", new XVar( "field", "tipo_permiso",
"type", "grid_field" ),
"simple_grid_field6", new XVar( "type", "grid_field_label",
"field", "tipo_permiso" ),
"simple_grid_field2", new XVar( "field", "horas_asignada",
"type", "grid_field" ),
"simple_grid_field7", new XVar( "type", "grid_field_label",
"field", "horas_asignada" ),
"simple_grid_field3", new XVar( "field", "dias_asignados",
"type", "grid_field" ),
"simple_grid_field8", new XVar( "type", "grid_field_label",
"field", "dias_asignados" ),
"simple_grid_field4", new XVar( "field", "cantidad_permisos",
"type", "grid_field" ),
"simple_grid_field9", new XVar( "type", "grid_field_label",
"field", "cantidad_permisos" ) ),
"dbProps", new XVar(  ),
"version", 2 );
				}
			}
		}