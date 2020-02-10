
		// APROBAR_PERMISOS
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
			public static partial class Options_APROBAR_PERMISOS_search
			{
				static public XVar options()
				{
					return new XVar( "fields", new XVar( "gridFields", new XVar( 0, "id_permisos",
1, "ONI",
2, "id_tipopermiso",
3, "fecha_solicitud",
4, "motivo",
5, "adjunto",
6, "id_estado_personal",
7, "Observaciones",
8, "fecha_inicio",
9, "vistobueno1",
10, "fecha_final",
11, "Dias",
12, "Horas",
13, "Minutos",
14, "vistobueno2",
15, "nombre",
16, "departamento" ),
"searchRequiredFields", XVar.Array(),
"searchPanelFields", XVar.Array(),
"fieldItems", new XVar( "id_permisos", new XVar( 0, "integrated_search_field" ),
"ONI", new XVar( 0, "integrated_search_field1" ),
"id_tipopermiso", new XVar( 0, "integrated_search_field2" ),
"fecha_solicitud", new XVar( 0, "integrated_search_field3" ),
"motivo", new XVar( 0, "integrated_search_field4" ),
"adjunto", new XVar( 0, "integrated_search_field5" ),
"id_estado_personal", new XVar( 0, "integrated_search_field6" ),
"Observaciones", new XVar( 0, "integrated_search_field7" ),
"fecha_inicio", new XVar( 0, "integrated_search_field8" ),
"vistobueno1", new XVar( 0, "integrated_search_field9" ),
"fecha_final", new XVar( 0, "integrated_search_field10" ),
"Dias", new XVar( 0, "integrated_search_field11" ),
"Horas", new XVar( 0, "integrated_search_field12" ),
"Minutos", new XVar( 0, "integrated_search_field13" ),
"vistobueno2", new XVar( 0, "integrated_search_field14" ),
"nombre", new XVar( 0, "integrated_search_field15" ),
"departamento", new XVar( 0, "integrated_search_field16" ) ) ),
"pageLinks", new XVar( "edit", false,
"add", false,
"view", false,
"print", false ),
"layoutHelper", new XVar( "formItems", new XVar( "formItems", new XVar( "top", new XVar( 0, "search_header" ),
"above-grid", XVar.Array(),
"below-grid", new XVar( 0, "search_search",
1, "search_reset",
2, "search_back_list",
3, "search_cancel" ),
"grid", new XVar( 0, "integrated_search_field",
1, "integrated_search_field1",
2, "integrated_search_field2",
3, "integrated_search_field3",
4, "integrated_search_field4",
5, "integrated_search_field5",
6, "integrated_search_field6",
7, "integrated_search_field7",
8, "integrated_search_field8",
9, "integrated_search_field10",
10, "integrated_search_field11",
11, "integrated_search_field12",
12, "integrated_search_field13",
13, "integrated_search_field9",
14, "integrated_search_field14",
15, "integrated_search_field15",
16, "integrated_search_field16" ) ),
"formXtTags", new XVar( "above-grid", XVar.Array() ),
"itemForms", new XVar( "search_header", "top",
"search_search", "below-grid",
"search_reset", "below-grid",
"search_back_list", "below-grid",
"search_cancel", "below-grid",
"integrated_search_field", "grid",
"integrated_search_field1", "grid",
"integrated_search_field2", "grid",
"integrated_search_field3", "grid",
"integrated_search_field4", "grid",
"integrated_search_field5", "grid",
"integrated_search_field6", "grid",
"integrated_search_field7", "grid",
"integrated_search_field8", "grid",
"integrated_search_field10", "grid",
"integrated_search_field11", "grid",
"integrated_search_field12", "grid",
"integrated_search_field13", "grid",
"integrated_search_field9", "grid",
"integrated_search_field14", "grid",
"integrated_search_field15", "grid",
"integrated_search_field16", "grid" ),
"itemLocations", new XVar( "integrated_search_field", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field1", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field2", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field3", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field4", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field5", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field6", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field7", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field8", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field10", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field11", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field12", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field13", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field9", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field14", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field15", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field16", new XVar( "location", "grid",
"cellId", "c3" ) ),
"itemVisiblity", new XVar(  ) ),
"itemsByType", new XVar( "search_header", new XVar( 0, "search_header" ),
"search_reset", new XVar( 0, "search_reset" ),
"search_back_list", new XVar( 0, "search_back_list" ),
"search_search", new XVar( 0, "search_search" ),
"search_cancel", new XVar( 0, "search_cancel" ),
"integrated_search_field", new XVar( 0, "integrated_search_field",
1, "integrated_search_field1",
2, "integrated_search_field2",
3, "integrated_search_field3",
4, "integrated_search_field4",
5, "integrated_search_field5",
6, "integrated_search_field6",
7, "integrated_search_field7",
8, "integrated_search_field8",
9, "integrated_search_field9",
10, "integrated_search_field10",
11, "integrated_search_field11",
12, "integrated_search_field12",
13, "integrated_search_field13",
14, "integrated_search_field14",
15, "integrated_search_field15",
16, "integrated_search_field16" ) ),
"cellMaps", new XVar( "grid", new XVar( "cells", new XVar( "c3", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 0 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_search_field",
1, "integrated_search_field1",
2, "integrated_search_field2",
3, "integrated_search_field3",
4, "integrated_search_field4",
5, "integrated_search_field5",
6, "integrated_search_field6",
7, "integrated_search_field7",
8, "integrated_search_field8",
9, "integrated_search_field10",
10, "integrated_search_field11",
11, "integrated_search_field12",
12, "integrated_search_field13",
13, "integrated_search_field9",
14, "integrated_search_field14",
15, "integrated_search_field15",
16, "integrated_search_field16" ),
"fixedAtServer", true,
"fixedAtClient", false ) ),
"width", 1,
"height", 1 ) ) ),
"loginForm", new XVar( "loginForm", 3 ),
"page", new XVar( "labeledButtons", new XVar( "update_records", new XVar(  ),
"print_pages", new XVar(  ),
"register_activate_message", new XVar(  ) ) ),
"misc", new XVar( "type", "search",
"breadcrumb", false ),
"events", new XVar( "maps", XVar.Array(),
"mapsData", new XVar(  ),
"buttons", XVar.Array() ) );
				}
				static public XVar page()
				{
					return new XVar( "id", "search",
"type", "search",
"layoutId", "nomenu",
"disabled", 0,
"default", 0,
"forms", new XVar( "top", new XVar( "modelId", "search-header",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "search_header" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"above-grid", new XVar( "modelId", "search-above-grid",
"grid", XVar.Array(),
"cells", new XVar(  ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"below-grid", new XVar( "modelId", "search-below-grid",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "search_search",
1, "search_reset",
2, "search_back_list",
3, "search_cancel" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"grid", new XVar( "modelId", "simple-search",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c3" ) ),
"section", "" ) ),
"cells", new XVar( "c3", new XVar( "model", "c3",
"items", new XVar( 0, "integrated_search_field",
1, "integrated_search_field1",
2, "integrated_search_field2",
3, "integrated_search_field3",
4, "integrated_search_field4",
5, "integrated_search_field5",
6, "integrated_search_field6",
7, "integrated_search_field7",
8, "integrated_search_field8",
9, "integrated_search_field10",
10, "integrated_search_field11",
11, "integrated_search_field12",
12, "integrated_search_field13",
13, "integrated_search_field9",
14, "integrated_search_field14",
15, "integrated_search_field15",
16, "integrated_search_field16" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ) ),
"deferredItems", XVar.Array(),
"separateLabels", false ) ),
"items", new XVar( "search_header", new XVar( "type", "search_header" ),
"search_reset", new XVar( "type", "search_reset" ),
"search_back_list", new XVar( "type", "search_back_list" ),
"search_search", new XVar( "type", "search_search" ),
"search_cancel", new XVar( "type", "search_cancel" ),
"integrated_search_field", new XVar( "field", "id_permisos",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field1", new XVar( "field", "ONI",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field2", new XVar( "field", "id_tipopermiso",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field3", new XVar( "field", "fecha_solicitud",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field4", new XVar( "field", "motivo",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field5", new XVar( "field", "adjunto",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field6", new XVar( "field", "id_estado_personal",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field7", new XVar( "field", "Observaciones",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field8", new XVar( "field", "fecha_inicio",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field9", new XVar( "field", "vistobueno1",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field10", new XVar( "field", "fecha_final",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field11", new XVar( "field", "Dias",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field12", new XVar( "field", "Horas",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field13", new XVar( "field", "Minutos",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field14", new XVar( "field", "vistobueno2",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field15", new XVar( "field", "nombre",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field16", new XVar( "field", "departamento",
"type", "integrated_search_field",
"orientation", 0,
"required", false ) ),
"dbProps", new XVar(  ),
"version", 2 );
				}
			}
		}