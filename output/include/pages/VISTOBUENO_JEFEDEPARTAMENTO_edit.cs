
		// VISTOBUENO_JEFEDEPARTAMENTO
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
			public static partial class Options_VISTOBUENO_JEFEDEPARTAMENTO_edit
			{
				static public XVar options()
				{
					return new XVar( "master", new XVar( "dbo.EMPLEADO", new XVar( "preview", false ),
"dbo.TIPOPERMISO", new XVar( "preview", false ),
"dbo.ESTADO_PERSONALES", new XVar( "preview", false ) ),
"captcha", new XVar( "captcha", false ),
"fields", new XVar( "gridFields", new XVar( 0, "vistobueno2",
1, "Observaciones",
2, "id_permisos",
3, "ONI",
4, "id_tipopermiso",
5, "fecha_solicitud",
6, "motivo",
7, "adjunto",
8, "fecha_inicio",
9, "fecha_final",
10, "Dias",
11, "Horas",
12, "Minutos",
13, "vistobueno1",
14, "id_estado_personal" ),
"searchRequiredFields", XVar.Array(),
"searchPanelFields", XVar.Array(),
"updateOnEditFields", XVar.Array(),
"fieldItems", new XVar( "vistobueno2", new XVar( 0, "integrated_edit_field12" ),
"Observaciones", new XVar( 0, "integrated_edit_field14" ),
"id_permisos", new XVar( 0, "integrated_edit_field" ),
"ONI", new XVar( 0, "integrated_edit_field1" ),
"id_tipopermiso", new XVar( 0, "integrated_edit_field2" ),
"fecha_solicitud", new XVar( 0, "integrated_edit_field3" ),
"motivo", new XVar( 0, "integrated_edit_field4" ),
"adjunto", new XVar( 0, "integrated_edit_field5" ),
"fecha_inicio", new XVar( 0, "integrated_edit_field6" ),
"fecha_final", new XVar( 0, "integrated_edit_field7" ),
"Dias", new XVar( 0, "integrated_edit_field8" ),
"Horas", new XVar( 0, "integrated_edit_field9" ),
"Minutos", new XVar( 0, "integrated_edit_field10" ),
"vistobueno1", new XVar( 0, "integrated_edit_field11" ),
"id_estado_personal", new XVar( 0, "integrated_edit_field13" ) ) ),
"pageLinks", new XVar( "edit", false,
"add", false,
"view", true,
"print", false ),
"layoutHelper", new XVar( "formItems", new XVar( "formItems", new XVar( "top", new XVar( 0, "edit_header" ),
"above-grid", new XVar( 0, "edit_message" ),
"below-grid", new XVar( 0, "edit_save",
1, "edit_back_list",
2, "edit_close",
3, "hamburger" ),
"grid", new XVar( 0, "integrated_edit_field",
1, "integrated_edit_field1",
2, "integrated_edit_field2",
3, "integrated_edit_field3",
4, "integrated_edit_field6",
5, "integrated_edit_field7",
6, "integrated_edit_field4",
7, "integrated_edit_field5",
8, "integrated_edit_field8",
9, "integrated_edit_field9",
10, "integrated_edit_field10",
11, "integrated_edit_field12",
12, "integrated_edit_field11",
13, "integrated_edit_field14",
14, "integrated_edit_field13" ) ),
"formXtTags", new XVar( "above-grid", new XVar( 0, "message_block" ) ),
"itemForms", new XVar( "edit_header", "top",
"edit_message", "above-grid",
"edit_save", "below-grid",
"edit_back_list", "below-grid",
"edit_close", "below-grid",
"hamburger", "below-grid",
"integrated_edit_field", "grid",
"integrated_edit_field1", "grid",
"integrated_edit_field2", "grid",
"integrated_edit_field3", "grid",
"integrated_edit_field6", "grid",
"integrated_edit_field7", "grid",
"integrated_edit_field4", "grid",
"integrated_edit_field5", "grid",
"integrated_edit_field8", "grid",
"integrated_edit_field9", "grid",
"integrated_edit_field10", "grid",
"integrated_edit_field12", "grid",
"integrated_edit_field11", "grid",
"integrated_edit_field14", "grid",
"integrated_edit_field13", "grid" ),
"itemLocations", new XVar( "integrated_edit_field", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_edit_field1", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_edit_field2", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_edit_field3", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_edit_field6", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_edit_field7", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_edit_field4", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_edit_field5", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_edit_field8", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_edit_field9", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_edit_field10", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_edit_field12", new XVar( "location", "grid",
"cellId", "c" ),
"integrated_edit_field11", new XVar( "location", "grid",
"cellId", "c" ),
"integrated_edit_field14", new XVar( "location", "grid",
"cellId", "c" ),
"integrated_edit_field13", new XVar( "location", "grid",
"cellId", "c" ) ),
"itemVisiblity", new XVar(  ) ),
"itemsByType", new XVar( "edit_header", new XVar( 0, "edit_header" ),
"hamburger", new XVar( 0, "hamburger" ),
"edit_reset", new XVar( 0, "edit_reset" ),
"edit_message", new XVar( 0, "edit_message" ),
"edit_save", new XVar( 0, "edit_save" ),
"edit_back_list", new XVar( 0, "edit_back_list" ),
"edit_close", new XVar( 0, "edit_close" ),
"edit_view", new XVar( 0, "edit_view" ),
"integrated_edit_field", new XVar( 0, "integrated_edit_field12",
1, "integrated_edit_field14",
2, "integrated_edit_field",
3, "integrated_edit_field1",
4, "integrated_edit_field2",
5, "integrated_edit_field3",
6, "integrated_edit_field4",
7, "integrated_edit_field5",
8, "integrated_edit_field6",
9, "integrated_edit_field7",
10, "integrated_edit_field8",
11, "integrated_edit_field9",
12, "integrated_edit_field10",
13, "integrated_edit_field11",
14, "integrated_edit_field13" ) ),
"cellMaps", new XVar( "grid", new XVar( "cells", new XVar( "c3", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 0 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field",
1, "integrated_edit_field1",
2, "integrated_edit_field2",
3, "integrated_edit_field3",
4, "integrated_edit_field6",
5, "integrated_edit_field7",
6, "integrated_edit_field4",
7, "integrated_edit_field5",
8, "integrated_edit_field8",
9, "integrated_edit_field9",
10, "integrated_edit_field10" ),
"fixedAtServer", true,
"fixedAtClient", false ),
"c", new XVar( "cols", new XVar( 0, 1 ),
"rows", new XVar( 0, 0 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field12",
1, "integrated_edit_field11",
2, "integrated_edit_field14",
3, "integrated_edit_field13" ),
"fixedAtServer", true,
"fixedAtClient", false ) ),
"width", 2,
"height", 1 ) ) ),
"loginForm", new XVar( "loginForm", 3 ),
"page", new XVar( "labeledButtons", new XVar( "update_records", new XVar(  ),
"print_pages", new XVar(  ),
"register_activate_message", new XVar(  ) ) ),
"misc", new XVar( "type", "edit",
"breadcrumb", false,
"nextPrev", false ),
"events", new XVar( "maps", XVar.Array(),
"mapsData", new XVar(  ),
"buttons", XVar.Array() ),
"edit", new XVar( "updateSelected", false ) );
				}
				static public XVar page()
				{
					return new XVar( "id", "edit",
"type", "edit",
"layoutId", "nomenu",
"disabled", 0,
"default", 0,
"forms", new XVar( "top", new XVar( "modelId", "edit-header",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "edit_header" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"above-grid", new XVar( "modelId", "edit-above-grid",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1",
"rowspan", 1 ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "edit_message" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"below-grid", new XVar( "modelId", "edit-below-grid",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ),
1, new XVar( "cell", "c2" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "edit_save",
1, "edit_back_list",
2, "edit_close" ),
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
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c3" ),
1, new XVar( "cell", "c" ) ),
"section", "" ) ),
"cells", new XVar( "c3", new XVar( "model", "c3",
"items", new XVar( 0, "integrated_edit_field",
1, "integrated_edit_field1",
2, "integrated_edit_field2",
3, "integrated_edit_field3",
4, "integrated_edit_field6",
5, "integrated_edit_field7",
6, "integrated_edit_field4",
7, "integrated_edit_field5",
8, "integrated_edit_field8",
9, "integrated_edit_field9",
10, "integrated_edit_field10" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ),
"c", new XVar( "model", "c3",
"items", new XVar( 0, "integrated_edit_field12",
1, "integrated_edit_field11",
2, "integrated_edit_field14",
3, "integrated_edit_field13" ),
"customCSS", "/* Put  your custom CSS code here */\n.container .jumbotron, .container-fluid .jumbotron {\n    width: 650px;\n}\n" ) ),
"deferredItems", XVar.Array(),
"columnCount", 1,
"inlineLabels", false,
"separateLabels", false ) ),
"items", new XVar( "edit_header", new XVar( "type", "edit_header",
"title", new XVar( "page", "edit",
"table", "dbo.Permisos2",
"type", 7 ) ),
"hamburger", new XVar( "type", "hamburger",
"items", new XVar( 0, "edit_reset",
1, "edit_view" ) ),
"edit_reset", new XVar( "type", "edit_reset" ),
"edit_message", new XVar( "type", "edit_message" ),
"edit_save", new XVar( "type", "edit_save" ),
"edit_back_list", new XVar( "type", "edit_back_list" ),
"edit_close", new XVar( "type", "edit_close" ),
"edit_view", new XVar( "type", "edit_view" ),
"integrated_edit_field12", new XVar( "field", "vistobueno2",
"type", "integrated_edit_field",
"orientation", 0,
"updateOnEdit", false ),
"integrated_edit_field14", new XVar( "field", "Observaciones",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field", new XVar( "field", "id_permisos",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field1", new XVar( "field", "ONI",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field2", new XVar( "field", "id_tipopermiso",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field3", new XVar( "field", "fecha_solicitud",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field4", new XVar( "field", "motivo",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field5", new XVar( "field", "adjunto",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field6", new XVar( "field", "fecha_inicio",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field7", new XVar( "field", "fecha_final",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field8", new XVar( "field", "Dias",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field9", new XVar( "field", "Horas",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field10", new XVar( "field", "Minutos",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field11", new XVar( "field", "vistobueno1",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field13", new XVar( "field", "id_estado_personal",
"type", "integrated_edit_field",
"orientation", 0,
"updateOnEdit", false ) ),
"dbProps", new XVar(  ),
"version", 2 );
				}
			}
		}