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
	public partial class ViewMapField : ViewControl
	{
		protected static bool skipViewMapFieldCtor = false;
		public ViewMapField(dynamic _param_field, dynamic _param_container, dynamic _param_pageObject) // proxy constructor
			:base((XVar)_param_field, (XVar)_param_container, (XVar)_param_pageObject) {}

		public override XVar showDBValue(dynamic data, dynamic _param_keylink, dynamic _param_html = null)
		{
			#region default values
			if(_param_html as Object == null) _param_html = new XVar(true);
			#endregion

			#region pass-by-value parameters
			dynamic keylink = XVar.Clone(_param_keylink);
			dynamic html = XVar.Clone(_param_html);
			#endregion

			dynamic icon = null, location = null, mapData = XVar.Array();
			if(XVar.Pack(!(XVar)(this.pageObject)))
			{
				return MVCFunctions.runner_htmlspecialchars((XVar)(data[this.field]));
			}
			else
			{
				if((XVar)(this.pageObject.pageType == Constants.PAGE_EXPORT)  || (XVar)((XVar)(this.pageObject.pageType == Constants.PAGE_RPRINT)  && (XVar)(this.container.forExport == "excel")))
				{
					return MVCFunctions.runner_htmlspecialchars((XVar)(data[this.field]));
				}
			}
			if(this.pageObject.pageType != Constants.PAGE_LIST)
			{
				mapData = XVar.Clone(this.pageObject.addGoogleMapData((XVar)(this.field), (XVar)(data)));
			}
			if((XVar)((XVar)((XVar)((XVar)(this.pageObject.pageType != Constants.PAGE_PRINT)  && (XVar)(this.pageObject.pageType != Constants.PAGE_MASTER_INFO_PRINT))  && (XVar)(this.pageObject.pageType != Constants.PAGE_RPRINT))  && (XVar)(this.pageObject.pageType != Constants.PAGE_REPORT))  && (XVar)(!(XVar)((XVar)(this.pageObject.mode == Constants.VIEW_SIMPLE)  && (XVar)(this.pageObject.pdfMode))))
			{
				return MVCFunctions.Concat("<div id=\"littleMap_", MVCFunctions.GoodFieldName((XVar)(this.field)), "_", this.pageObject.recId, "\" style=\"width:", (XVar.Pack(!(XVar)(this.pageObject.googleMapCfg.KeyExists("fieldsAsMap"))) ? XVar.Pack("300") : XVar.Pack(this.pageObject.googleMapCfg["fieldsAsMap"][this.field]["width"])), "px; ", "height: ", (XVar.Pack(!(XVar)(this.pageObject.googleMapCfg.KeyExists("fieldsAsMap"))) ? XVar.Pack("225") : XVar.Pack(this.pageObject.googleMapCfg["fieldsAsMap"][this.field]["height"])), "px; ", "\" data-gridlink class=\"littleMap\"></div>");
			}
			location = XVar.Clone(getLocation((XVar)(mapData["markers"][0])));
			icon = XVar.Clone(mapData["markers"][0]["mapIcon"]);
			return MVCFunctions.Concat("<img border=\"0\" alt=\"\" src=\"", getStaticMapURL((XVar)(location), (XVar)(mapData["zoom"]), (XVar)(icon)), "\">");
		}
		public virtual XVar getLocation(dynamic _param_markerData)
		{
			#region pass-by-value parameters
			dynamic markerData = XVar.Clone(_param_markerData);
			#endregion

			if((XVar)(markerData["lat"] == "")  && (XVar)(markerData["lng"] == ""))
			{
				dynamic locationByAddress = XVar.Array();
				if(XVar.Pack(!(XVar)(markerData["address"])))
				{
					return "";
				}
				if(CommonFunctions.getMapProvider() == Constants.GOOGLE_MAPS)
				{
					return markerData["address"];
				}
				locationByAddress = XVar.Clone(CommonFunctions.getLatLngByAddr((XVar)(markerData["address"])));
				return MVCFunctions.Concat(locationByAddress["lat"], ",", locationByAddress["lng"]);
			}
			return MVCFunctions.Concat(markerData["lat"], ",", markerData["lng"]);
		}
		public virtual XVar getStaticMapURL(dynamic _param_location, dynamic _param_zoom, dynamic _param_icon)
		{
			#region pass-by-value parameters
			dynamic location = XVar.Clone(_param_location);
			dynamic zoom = XVar.Clone(_param_zoom);
			dynamic icon = XVar.Clone(_param_icon);
			#endregion

			dynamic apiKey = null, height = null, markerLocation = null, width = null;
			markerLocation = XVar.Clone(location);
			apiKey = XVar.Clone(this.pageObject.googleMapCfg["APIcode"]);
			width = new XVar("300");
			height = new XVar("225");
			if(XVar.Pack(this.pageObject.googleMapCfg.KeyExists("fieldsAsMap")))
			{
				width = XVar.Clone(this.pageObject.googleMapCfg["fieldsAsMap"][this.field]["width"]);
				height = XVar.Clone(this.pageObject.googleMapCfg["fieldsAsMap"][this.field]["height"]);
			}
			switch(((XVar)CommonFunctions.getMapProvider()).ToInt())
			{
				case Constants.GOOGLE_MAPS:
					if((XVar)(icon)  && (XVar)(GlobalVars.showCustomMarkerOnPrint))
					{
						dynamic here = null, pos = null;
						here = XVar.Clone(MVCFunctions.Concat("http://", MVCFunctions.GetServerVariable("HTTP_HOST"), MVCFunctions.GetServerVariable("REQUEST_URI")));
						pos = XVar.Clone(MVCFunctions.strrpos((XVar)(here), new XVar("/")));
						here = XVar.Clone(MVCFunctions.Concat(MVCFunctions.substr((XVar)(here), new XVar(0), (XVar)(pos)), "/images/menuicons/", icon));
						markerLocation = XVar.Clone(MVCFunctions.Concat("icon:", here, "|", location));
					}
					return MVCFunctions.Concat("http://maps.googleapis.com/maps/api/staticmap?center=", location, "&zoom=", zoom, "&size=", width, "x", height, "&maptype=mobile&markers=", markerLocation, "&key=", apiKey);
				case Constants.OPEN_STREET_MAPS:
					return MVCFunctions.Concat("http://staticmap.openstreetmap.de/staticmap.php?center=", location, "&zoom=", zoom, "&size=", width, "x", height, "&maptype=mobile&markers=", markerLocation, ",ol-marker");
				case Constants.BING_MAPS:
					return MVCFunctions.Concat("http://dev.virtualearth.net/REST/v1/Imagery/Map/Road/", location, "/", zoom, "?mapSize=", width, ",", height, "&pp=", markerLocation, ";63;&key=", apiKey);
				default:
					return "";
			}
			return null;
		}
		public override XVar getPdfValue(dynamic data, dynamic _param_keylink = null)
		{
			#region default values
			if(_param_keylink as Object == null) _param_keylink = new XVar("");
			#endregion

			#region pass-by-value parameters
			dynamic keylink = XVar.Clone(_param_keylink);
			#endregion

			dynamic content = null, imageType = null, location = null, mapData = XVar.Array(), staticUrl = null;
			mapData = XVar.Clone(this.pageObject.addGoogleMapData((XVar)(this.field), (XVar)(data)));
			location = XVar.Clone(getLocation((XVar)(mapData["markers"][0])));
			staticUrl = XVar.Clone(getStaticMapURL((XVar)(location), (XVar)(mapData["zoom"]), (XVar)(mapData["markers"][0]["mapIcon"])));
			content = XVar.Clone(MVCFunctions.myurl_get_contents_binary((XVar)(staticUrl)));
			imageType = XVar.Clone(MVCFunctions.SupposeImageType((XVar)(content)));
			if((XVar)(imageType == "image/jpeg")  || (XVar)(imageType == "image/png"))
			{
				return MVCFunctions.Concat("{ \r\n\t\t\t\timage: \"", CommonFunctions.jsreplace((XVar)(MVCFunctions.Concat("data:", imageType, ";base64,", MVCFunctions.base64_encode((XVar)(content))))), "\",\r\n\t\t\t}");
			}
			return "\"\"";
		}
	}
}
