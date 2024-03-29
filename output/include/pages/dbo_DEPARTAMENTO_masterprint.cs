
		// dbo.DEPARTAMENTO
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
			public static partial class Options_dbo_DEPARTAMENTO_masterprint
			{
				static public XVar options()
				{
					return new XVar( "fields", new XVar( "gridFields", new XVar( 0, "id_departamento",
1, "departamento",
2, "limite_permisos" ),
"searchRequiredFields", XVar.Array(),
"searchPanelFields", XVar.Array(),
"fieldItems", new XVar( "id_departamento", new XVar( 0, "simple_grid_field",
1, "simple_grid_field3" ),
"departamento", new XVar( 0, "simple_grid_field1",
1, "simple_grid_field4" ),
"limite_permisos", new XVar( 0, "simple_grid_field2",
1, "simple_grid_field5" ) ) ),
"pageLinks", new XVar( "edit", false,
"add", false,
"view", false,
"print", false ),
"layoutHelper", new XVar( "formItems", new XVar( "formItems", new XVar( "top", new XVar( 0, "masterprint_header" ),
"above-grid", XVar.Array(),
"below-grid", XVar.Array(),
"grid", new XVar( 0, "simple_grid_field3",
1, "simple_grid_field",
2, "simple_grid_field4",
3, "simple_grid_field1",
4, "simple_grid_field5",
5, "simple_grid_field2" ) ),
"formXtTags", new XVar( "above-grid", XVar.Array(),
"below-grid", XVar.Array() ),
"itemForms", new XVar( "masterprint_header", "top",
"simple_grid_field3", "grid",
"simple_grid_field", "grid",
"simple_grid_field4", "grid",
"simple_grid_field1", "grid",
"simple_grid_field5", "grid",
"simple_grid_field2", "grid" ),
"itemLocations", new XVar( "simple_grid_field3", new XVar( "location", "grid",
"cellId", "headcell_field" ),
"simple_grid_field", new XVar( "location", "grid",
"cellId", "cell_field" ),
"simple_grid_field4", new XVar( "location", "grid",
"cellId", "headcell_field1" ),
"simple_grid_field1", new XVar( "location", "grid",
"cellId", "cell_field1" ),
"simple_grid_field5", new XVar( "location", "grid",
"cellId", "headcell_field2" ),
"simple_grid_field2", new XVar( "location", "grid",
"cellId", "cell_field2" ) ),
"itemVisiblity", new XVar(  ) ),
"itemsByType", new XVar( "masterprint_header", new XVar( 0, "masterprint_header" ),
"grid_field", new XVar( 0, "simple_grid_field",
1, "simple_grid_field1",
2, "simple_grid_field2" ),
"grid_field_label", new XVar( 0, "simple_grid_field3",
1, "simple_grid_field4",
2, "simple_grid_field5" ) ),
"cellMaps", new XVar( "grid", new XVar( "cells", new XVar( "headcell_field", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "id_departamento_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field3" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field1", new XVar( "cols", new XVar( 0, 1 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "departamento_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field4" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field2", new XVar( "cols", new XVar( 0, 2 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "limite_permisos_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field5" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "id_departamento_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field1", new XVar( "cols", new XVar( 0, 1 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "departamento_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field1" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field2", new XVar( "cols", new XVar( 0, 2 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "limite_permisos_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field2" ),
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
"fixedAtClient", false ) ),
"width", 3,
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
2, new XVar( "cell", "headcell_field2" ) ) ),
1, new XVar( "section", "body",
"cells", new XVar( 0, new XVar( "cell", "cell_field" ),
1, new XVar( "cell", "cell_field1" ),
2, new XVar( "cell", "cell_field2" ) ) ),
2, new XVar( "section", "foot",
"cells", new XVar( 0, new XVar( "cell", "footcell_field" ),
1, new XVar( "cell", "footcell_field1" ),
2, new XVar( "cell", "footcell_field2" ) ) ) ),
"cells", new XVar( "headcell_field", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field3" ),
"field", "id_departamento",
"columnName", "field" ),
"cell_field", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field" ),
"field", "id_departamento",
"columnName", "field" ),
"footcell_field", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field1", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field4" ),
"field", "departamento",
"columnName", "field" ),
"cell_field1", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field1" ),
"field", "departamento",
"columnName", "field" ),
"footcell_field1", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field2", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field5" ),
"field", "limite_permisos",
"columnName", "field" ),
"cell_field2", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field2" ),
"field", "limite_permisos",
"columnName", "field" ),
"footcell_field2", new XVar( "model", "footcell_field",
"items", XVar.Array() ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ) ),
"items", new XVar( "masterprint_header", new XVar( "type", "masterprint_header" ),
"simple_grid_field", new XVar( "field", "id_departamento",
"type", "grid_field" ),
"simple_grid_field3", new XVar( "type", "grid_field_label",
"field", "id_departamento" ),
"simple_grid_field1", new XVar( "field", "departamento",
"type", "grid_field" ),
"simple_grid_field4", new XVar( "type", "grid_field_label",
"field", "departamento" ),
"simple_grid_field2", new XVar( "field", "limite_permisos",
"type", "grid_field" ),
"simple_grid_field5", new XVar( "type", "grid_field_label",
"field", "limite_permisos" ) ),
"dbProps", new XVar(  ),
"version", 2 );
				}
			}
		}