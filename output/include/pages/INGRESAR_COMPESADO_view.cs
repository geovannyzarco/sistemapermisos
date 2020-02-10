
		// INGRESAR_COMPESADO
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
			public static partial class Options_INGRESAR_COMPESADO_view
			{
				static public XVar options()
				{
					return new XVar( "pdf", new XVar( "pdfView", false ),
"master", new XVar( "dbo.EMPLEADO", new XVar( "preview", false ),
"dbo.ESTADO_COMPESADO", new XVar( "preview", false ) ),
"fields", new XVar( "gridFields", new XVar( 0, "id_compesados",
1, "ONI",
2, "dias",
3, "horas",
4, "minutos",
5, "justificacion",
6, "anexo",
7, "observacion",
8, "id_estado_compesado",
9, "desde",
10, "hasta",
11, "fecha_creacion" ),
"searchRequiredFields", XVar.Array(),
"searchPanelFields", XVar.Array(),
"fieldItems", new XVar( "id_compesados", new XVar( 0, "integrated_edit_field" ),
"ONI", new XVar( 0, "integrated_edit_field1" ),
"dias", new XVar( 0, "integrated_edit_field2" ),
"horas", new XVar( 0, "integrated_edit_field3" ),
"minutos", new XVar( 0, "integrated_edit_field4" ),
"justificacion", new XVar( 0, "integrated_edit_field6" ),
"anexo", new XVar( 0, "integrated_edit_field7" ),
"observacion", new XVar( 0, "integrated_edit_field8" ),
"id_estado_compesado", new XVar( 0, "integrated_edit_field9" ),
"desde", new XVar( 0, "integrated_edit_field12" ),
"hasta", new XVar( 0, "integrated_edit_field13" ),
"fecha_creacion", new XVar( 0, "integrated_edit_field14" ) ) ),
"pageLinks", new XVar( "edit", true,
"add", false,
"view", false,
"print", false ),
"layoutHelper", new XVar( "formItems", new XVar( "formItems", new XVar( "top", new XVar( 0, "view_header" ),
"above-grid", XVar.Array(),
"below-grid", new XVar( 0, "view_back_list",
1, "view_close",
2, "hamburger" ),
"grid", new XVar( 0, "integrated_edit_field",
1, "integrated_edit_field14",
2, "integrated_edit_field1",
3, "integrated_edit_field6",
4, "integrated_edit_field12",
5, "integrated_edit_field13",
6, "integrated_edit_field2",
7, "integrated_edit_field3",
8, "integrated_edit_field4",
9, "integrated_edit_field7",
10, "integrated_edit_field8",
11, "integrated_edit_field9" ) ),
"formXtTags", new XVar( "above-grid", XVar.Array() ),
"itemForms", new XVar( "view_header", "top",
"view_back_list", "below-grid",
"view_close", "below-grid",
"hamburger", "below-grid",
"integrated_edit_field", "grid",
"integrated_edit_field14", "grid",
"integrated_edit_field1", "grid",
"integrated_edit_field6", "grid",
"integrated_edit_field12", "grid",
"integrated_edit_field13", "grid",
"integrated_edit_field2", "grid",
"integrated_edit_field3", "grid",
"integrated_edit_field4", "grid",
"integrated_edit_field7", "grid",
"integrated_edit_field8", "grid",
"integrated_edit_field9", "grid" ),
"itemLocations", new XVar( "integrated_edit_field", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_edit_field14", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_edit_field1", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_edit_field6", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_edit_field12", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_edit_field13", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_edit_field2", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_edit_field3", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_edit_field4", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_edit_field7", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_edit_field8", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_edit_field9", new XVar( "location", "grid",
"cellId", "c3" ) ),
"itemVisiblity", new XVar(  ) ),
"itemsByType", new XVar( "view_header", new XVar( 0, "view_header" ),
"view_back_list", new XVar( 0, "view_back_list" ),
"view_close", new XVar( 0, "view_close" ),
"hamburger", new XVar( 0, "hamburger" ),
"view_edit", new XVar( 0, "view_edit" ),
"integrated_edit_field", new XVar( 0, "integrated_edit_field",
1, "integrated_edit_field1",
2, "integrated_edit_field2",
3, "integrated_edit_field3",
4, "integrated_edit_field4",
5, "integrated_edit_field6",
6, "integrated_edit_field7",
7, "integrated_edit_field8",
8, "integrated_edit_field9",
9, "integrated_edit_field12",
10, "integrated_edit_field13",
11, "integrated_edit_field14" ) ),
"cellMaps", new XVar( "grid", new XVar( "cells", new XVar( "c3", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 0 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field",
1, "integrated_edit_field14",
2, "integrated_edit_field1",
3, "integrated_edit_field6",
4, "integrated_edit_field12",
5, "integrated_edit_field13",
6, "integrated_edit_field2",
7, "integrated_edit_field3",
8, "integrated_edit_field4",
9, "integrated_edit_field7",
10, "integrated_edit_field8",
11, "integrated_edit_field9" ),
"fixedAtServer", true,
"fixedAtClient", false ) ),
"width", 1,
"height", 1 ) ) ),
"loginForm", new XVar( "loginForm", 3 ),
"page", new XVar( "labeledButtons", new XVar( "update_records", new XVar(  ),
"print_pages", new XVar(  ),
"register_activate_message", new XVar(  ) ) ),
"misc", new XVar( "type", "view",
"breadcrumb", false,
"nextPrev", false ),
"events", new XVar( "maps", XVar.Array(),
"mapsData", new XVar(  ),
"buttons", XVar.Array() ) );
				}
				static public XVar page()
				{
					return new XVar( "id", "view",
"type", "view",
"layoutId", "nomenu",
"disabled", 0,
"default", 0,
"forms", new XVar( "top", new XVar( "modelId", "view-header",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "view_header" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"above-grid", new XVar( "modelId", "view-above-grid",
"grid", XVar.Array(),
"cells", new XVar(  ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"below-grid", new XVar( "modelId", "view-below-grid",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ),
1, new XVar( "cell", "c2" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "view_back_list",
1, "view_close" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ),
"c2", new XVar( "model", "c2",
"items", new XVar( 0, "hamburger" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"grid", new XVar( "modelId", "simple-edit",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c3" ) ),
"section", "" ) ),
"cells", new XVar( "c3", new XVar( "model", "c3",
"items", new XVar( 0, "integrated_edit_field",
1, "integrated_edit_field14",
2, "integrated_edit_field1",
3, "integrated_edit_field6",
4, "integrated_edit_field12",
5, "integrated_edit_field13",
6, "integrated_edit_field2",
7, "integrated_edit_field3",
8, "integrated_edit_field4",
9, "integrated_edit_field7",
10, "integrated_edit_field8",
11, "integrated_edit_field9" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ) ),
"deferredItems", XVar.Array(),
"columnCount", 1,
"inlineLabels", false,
"separateLabels", false ) ),
"items", new XVar( "view_header", new XVar( "type", "view_header" ),
"view_back_list", new XVar( "type", "view_back_list" ),
"view_close", new XVar( "type", "view_close" ),
"hamburger", new XVar( "type", "hamburger",
"items", new XVar( 0, "view_edit" ) ),
"view_edit", new XVar( "type", "view_edit" ),
"integrated_edit_field", new XVar( "field", "id_compesados",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field1", new XVar( "field", "ONI",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field2", new XVar( "field", "dias",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field3", new XVar( "field", "horas",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field4", new XVar( "field", "minutos",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field6", new XVar( "field", "justificacion",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field7", new XVar( "field", "anexo",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field8", new XVar( "field", "observacion",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field9", new XVar( "field", "id_estado_compesado",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field12", new XVar( "field", "desde",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field13", new XVar( "field", "hasta",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field14", new XVar( "field", "fecha_creacion",
"type", "integrated_edit_field",
"orientation", 0 ) ),
"dbProps", new XVar(  ),
"version", 2 );
				}
			}
		}