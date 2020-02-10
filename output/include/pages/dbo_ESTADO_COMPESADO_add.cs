
		// dbo.ESTADO_COMPESADO
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
			public static partial class Options_dbo_ESTADO_COMPESADO_add
			{
				static public XVar options()
				{
					return new XVar( "details", new XVar( "dbo.REGISTRO_HORAS_COMPESADAS", new XVar( "displayPreview", 2,
"previewPageId", "" ),
"VER_COMPESADOS", new XVar( "displayPreview", 2,
"previewPageId", "" ),
"APROBACION_COMPESADOS_JEFEINMEDIATO", new XVar( "displayPreview", 2,
"previewPageId", "" ),
"APROBACION_COMPESADOS_JEFEDEPARTAMENTO", new XVar( "displayPreview", 2,
"previewPageId", "" ),
"APROBAR_COMPESADOS", new XVar( "displayPreview", 2,
"previewPageId", "" ),
"INGRESAR_COMPESADO", new XVar( "displayPreview", 2,
"previewPageId", "" ) ),
"captcha", new XVar( "captcha", false ),
"fields", new XVar( "gridFields", new XVar( 0, "id_estado_compesado",
1, "estado_compesado" ),
"searchRequiredFields", XVar.Array(),
"searchPanelFields", XVar.Array(),
"fieldItems", new XVar( "id_estado_compesado", new XVar( 0, "integrated_edit_field" ),
"estado_compesado", new XVar( 0, "integrated_edit_field1" ) ) ),
"pageLinks", new XVar( "edit", false,
"add", false,
"view", false,
"print", false ),
"layoutHelper", new XVar( "formItems", new XVar( "formItems", new XVar( "top", new XVar( 0, "add_header" ),
"above-grid", new XVar( 0, "add_message" ),
"below-grid", new XVar( 0, "add_save",
1, "add_back_list",
2, "add_cancel" ),
"grid", new XVar( 0, "integrated_edit_field",
1, "integrated_edit_field1" ) ),
"formXtTags", new XVar( "above-grid", new XVar( 0, "message_block" ) ),
"itemForms", new XVar( "add_header", "top",
"add_message", "above-grid",
"add_save", "below-grid",
"add_back_list", "below-grid",
"add_cancel", "below-grid",
"integrated_edit_field", "grid",
"integrated_edit_field1", "grid" ),
"itemLocations", new XVar( "integrated_edit_field", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_edit_field1", new XVar( "location", "grid",
"cellId", "c3" ) ),
"itemVisiblity", new XVar(  ) ),
"itemsByType", new XVar( "add_header", new XVar( 0, "add_header" ),
"add_back_list", new XVar( 0, "add_back_list" ),
"add_cancel", new XVar( 0, "add_cancel" ),
"add_message", new XVar( 0, "add_message" ),
"add_save", new XVar( 0, "add_save" ),
"integrated_edit_field", new XVar( 0, "integrated_edit_field",
1, "integrated_edit_field1" ) ),
"cellMaps", new XVar( "grid", new XVar( "cells", new XVar( "c3", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 0 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field",
1, "integrated_edit_field1" ),
"fixedAtServer", true,
"fixedAtClient", false ) ),
"width", 1,
"height", 1 ) ) ),
"loginForm", new XVar( "loginForm", 3 ),
"page", new XVar( "labeledButtons", new XVar( "update_records", new XVar(  ),
"print_pages", new XVar(  ),
"register_activate_message", new XVar(  ) ) ),
"misc", new XVar( "type", "add",
"breadcrumb", false ),
"events", new XVar( "maps", XVar.Array(),
"mapsData", new XVar(  ),
"buttons", XVar.Array() ) );
				}
				static public XVar page()
				{
					return new XVar( "id", "add",
"type", "add",
"layoutId", "nomenu",
"disabled", 0,
"default", 0,
"forms", new XVar( "top", new XVar( "modelId", "add-header",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "add_header" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"above-grid", new XVar( "modelId", "add-above-grid",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "add_message" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"below-grid", new XVar( "modelId", "add-below-grid",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "add_save",
1, "add_back_list",
2, "add_cancel" ),
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
1, "integrated_edit_field1" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ) ),
"deferredItems", XVar.Array(),
"columnCount", 1,
"inlineLabels", false,
"separateLabels", false ) ),
"items", new XVar( "add_header", new XVar( "type", "add_header" ),
"add_back_list", new XVar( "type", "add_back_list" ),
"add_cancel", new XVar( "type", "add_cancel" ),
"add_message", new XVar( "type", "add_message" ),
"add_save", new XVar( "type", "add_save" ),
"integrated_edit_field", new XVar( "field", "id_estado_compesado",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field1", new XVar( "field", "estado_compesado",
"type", "integrated_edit_field",
"orientation", 0 ) ),
"dbProps", new XVar(  ),
"version", 2 );
				}
			}
		}