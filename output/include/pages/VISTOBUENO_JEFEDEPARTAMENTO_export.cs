
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
			public static partial class Options_VISTOBUENO_JEFEDEPARTAMENTO_export
			{
				static public XVar options()
				{
					return new XVar( "totals", new XVar( "id_permisos", new XVar( "totalsType", "" ),
"ONI", new XVar( "totalsType", "" ),
"nombre", new XVar( "totalsType", "" ),
"id_tipopermiso", new XVar( "totalsType", "" ),
"fecha_solicitud", new XVar( "totalsType", "" ),
"motivo", new XVar( "totalsType", "" ),
"adjunto", new XVar( "totalsType", "" ),
"fecha_inicio", new XVar( "totalsType", "" ),
"fecha_final", new XVar( "totalsType", "" ),
"Dias", new XVar( "totalsType", "" ),
"Horas", new XVar( "totalsType", "" ),
"Minutos", new XVar( "totalsType", "" ),
"vistobueno1", new XVar( "totalsType", "" ),
"vistobueno2", new XVar( "totalsType", "" ),
"id_estado_personal", new XVar( "totalsType", "" ),
"Observaciones", new XVar( "totalsType", "" ) ),
"fields", new XVar( "gridFields", new XVar( 0, "id_permisos",
1, "ONI",
2, "id_tipopermiso",
3, "fecha_solicitud",
4, "motivo",
5, "adjunto",
6, "id_estado_personal",
7, "Observaciones",
8, "fecha_inicio",
9, "fecha_final",
10, "Dias",
11, "Horas",
12, "Minutos",
13, "vistobueno1",
14, "vistobueno2",
15, "nombre" ),
"exportFields", new XVar( 0, "id_permisos",
1, "ONI",
2, "id_tipopermiso",
3, "fecha_solicitud",
4, "motivo",
5, "adjunto",
6, "fecha_inicio",
7, "fecha_final",
8, "Dias",
9, "Horas",
10, "Minutos",
11, "vistobueno1",
12, "vistobueno2",
13, "id_estado_personal",
14, "Observaciones",
15, "nombre" ),
"searchRequiredFields", XVar.Array(),
"searchPanelFields", XVar.Array(),
"fieldItems", new XVar( "id_permisos", new XVar( 0, "export_field" ),
"ONI", new XVar( 0, "export_field1" ),
"id_tipopermiso", new XVar( 0, "export_field2" ),
"fecha_solicitud", new XVar( 0, "export_field3" ),
"motivo", new XVar( 0, "export_field4" ),
"adjunto", new XVar( 0, "export_field5" ),
"id_estado_personal", new XVar( 0, "export_field6" ),
"Observaciones", new XVar( 0, "export_field7" ),
"fecha_inicio", new XVar( 0, "export_field8" ),
"fecha_final", new XVar( 0, "export_field9" ),
"Dias", new XVar( 0, "export_field10" ),
"Horas", new XVar( 0, "export_field11" ),
"Minutos", new XVar( 0, "export_field12" ),
"vistobueno1", new XVar( 0, "export_field13" ),
"vistobueno2", new XVar( 0, "export_field14" ),
"nombre", new XVar( 0, "export_field15" ) ) ),
"pageLinks", new XVar( "edit", false,
"add", false,
"view", false,
"print", false ),
"layoutHelper", new XVar( "formItems", new XVar( "formItems", new XVar( "supertop", XVar.Array(),
"top", new XVar( 0, "export_header" ),
"grid", new XVar( 0, "export_field",
1, "export_field1",
2, "export_field2",
3, "export_field3",
4, "export_field4",
5, "export_field5",
6, "export_field8",
7, "export_field9",
8, "export_field10",
9, "export_field11",
10, "export_field12",
11, "export_field13",
12, "export_field14",
13, "export_field6",
14, "export_field7",
15, "export_field15" ),
"footer", new XVar( 0, "export_export",
1, "export_cancel" ) ),
"formXtTags", new XVar( "supertop", XVar.Array() ),
"itemForms", new XVar( "export_header", "top",
"export_field", "grid",
"export_field1", "grid",
"export_field2", "grid",
"export_field3", "grid",
"export_field4", "grid",
"export_field5", "grid",
"export_field8", "grid",
"export_field9", "grid",
"export_field10", "grid",
"export_field11", "grid",
"export_field12", "grid",
"export_field13", "grid",
"export_field14", "grid",
"export_field6", "grid",
"export_field7", "grid",
"export_field15", "grid",
"export_export", "footer",
"export_cancel", "footer" ),
"itemLocations", new XVar(  ),
"itemVisiblity", new XVar(  ) ),
"itemsByType", new XVar( "export_header", new XVar( 0, "export_header" ),
"export_export", new XVar( 0, "export_export" ),
"export_cancel", new XVar( 0, "export_cancel" ),
"export_field", new XVar( 0, "export_field",
1, "export_field1",
2, "export_field2",
3, "export_field3",
4, "export_field4",
5, "export_field5",
6, "export_field6",
7, "export_field7",
8, "export_field8",
9, "export_field9",
10, "export_field10",
11, "export_field11",
12, "export_field12",
13, "export_field13",
14, "export_field14",
15, "export_field15" ) ),
"cellMaps", new XVar(  ) ),
"loginForm", new XVar( "loginForm", 3 ),
"page", new XVar( "labeledButtons", new XVar( "update_records", new XVar(  ),
"print_pages", new XVar(  ),
"register_activate_message", new XVar(  ) ) ),
"events", new XVar( "maps", XVar.Array(),
"mapsData", new XVar(  ),
"buttons", XVar.Array() ),
"export", new XVar( "format", 2,
"selectFields", false,
"delimiter", ",",
"selectDelimiter", false,
"exportFileTypes", new XVar( "excel", true,
"word", true,
"csv", true,
"xml", false ) ) );
				}
				static public XVar page()
				{
					return new XVar( "id", "export",
"type", "export",
"layoutId", "first",
"disabled", 0,
"default", 0,
"forms", new XVar( "supertop", new XVar( "modelId", "panel-top",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", XVar.Array(),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"top", new XVar( "modelId", "export-header",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "export_header" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"grid", new XVar( "modelId", "export-grid",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "export_field",
1, "export_field1",
2, "export_field2",
3, "export_field3",
4, "export_field4",
5, "export_field5",
6, "export_field8",
7, "export_field9",
8, "export_field10",
9, "export_field11",
10, "export_field12",
11, "export_field13",
12, "export_field14",
13, "export_field6",
14, "export_field7",
15, "export_field15" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"footer", new XVar( "modelId", "export-footer",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ),
1, new XVar( "cell", "c2" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", XVar.Array(),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ),
"c2", new XVar( "model", "c2",
"items", new XVar( 0, "export_export",
1, "export_cancel" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ) ),
"items", new XVar( "export_header", new XVar( "type", "export_header" ),
"export_export", new XVar( "type", "export_export" ),
"export_cancel", new XVar( "type", "export_cancel" ),
"export_field", new XVar( "field", "id_permisos",
"type", "export_field" ),
"export_field1", new XVar( "field", "ONI",
"type", "export_field" ),
"export_field2", new XVar( "field", "id_tipopermiso",
"type", "export_field" ),
"export_field3", new XVar( "field", "fecha_solicitud",
"type", "export_field" ),
"export_field4", new XVar( "field", "motivo",
"type", "export_field" ),
"export_field5", new XVar( "field", "adjunto",
"type", "export_field" ),
"export_field6", new XVar( "field", "id_estado_personal",
"type", "export_field" ),
"export_field7", new XVar( "field", "Observaciones",
"type", "export_field" ),
"export_field8", new XVar( "field", "fecha_inicio",
"type", "export_field" ),
"export_field9", new XVar( "field", "fecha_final",
"type", "export_field" ),
"export_field10", new XVar( "field", "Dias",
"type", "export_field" ),
"export_field11", new XVar( "field", "Horas",
"type", "export_field" ),
"export_field12", new XVar( "field", "Minutos",
"type", "export_field" ),
"export_field13", new XVar( "field", "vistobueno1",
"type", "export_field" ),
"export_field14", new XVar( "field", "vistobueno2",
"type", "export_field" ),
"export_field15", new XVar( "field", "nombre",
"type", "export_field" ) ),
"dbProps", new XVar(  ),
"version", 2,
"exportFormat", 2,
"exportDelimiter", ",",
"exportSelectDelimiter", false,
"exportSelectFields", false );
				}
			}
		}