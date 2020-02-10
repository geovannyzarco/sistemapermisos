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
	public static partial class Settings_dbo_ESTADO_COMPESADO
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), popupPagesLayoutNames = SettingsMap.GetArray(), query = null, queryData_Array = new XVar(), reportGroupFields = SettingsMap.GetArray(), rgroupField = SettingsMap.GetArray(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["dbo_ESTADO_COMPESADO"] = SettingsMap.GetArray();
			tdataArray["dbo_ESTADO_COMPESADO"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["dbo_ESTADO_COMPESADO"][".truncateText"] = true;
			tdataArray["dbo_ESTADO_COMPESADO"][".NumberOfChars"] = 80;
			tdataArray["dbo_ESTADO_COMPESADO"][".ShortName"] = "dbo_ESTADO_COMPESADO";
			tdataArray["dbo_ESTADO_COMPESADO"][".OwnerID"] = "";
			tdataArray["dbo_ESTADO_COMPESADO"][".OriginalTable"] = "dbo.ESTADO_COMPESADO";
			GlobalVars.defaultPages = MVCFunctions.my_json_decode(new XVar("{\"add\":\"add\",\"edit\":\"edit\",\"export\":\"export\",\"list\":\"list\",\"masterlist\":\"masterlist\",\"masterprint\":\"masterprint\",\"search\":\"search\"}"));
			tdataArray["dbo_ESTADO_COMPESADO"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"add\":[\"add\"],\"edit\":[\"edit\"],\"export\":[\"export\"],\"list\":[\"list\"],\"masterlist\":[\"masterlist\"],\"masterprint\":[\"masterprint\"],\"search\":[\"search\"]}")));
			tdataArray["dbo_ESTADO_COMPESADO"][".defaultPages"] = GlobalVars.defaultPages;
			fieldLabelsArray["dbo_ESTADO_COMPESADO"] = SettingsMap.GetArray();
			fieldToolTipsArray["dbo_ESTADO_COMPESADO"] = SettingsMap.GetArray();
			pageTitlesArray["dbo_ESTADO_COMPESADO"] = SettingsMap.GetArray();
			placeHoldersArray["dbo_ESTADO_COMPESADO"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "Spanish")
			{
				fieldLabelsArray["dbo_ESTADO_COMPESADO"]["Spanish"] = SettingsMap.GetArray();
				fieldToolTipsArray["dbo_ESTADO_COMPESADO"]["Spanish"] = SettingsMap.GetArray();
				placeHoldersArray["dbo_ESTADO_COMPESADO"]["Spanish"] = SettingsMap.GetArray();
				pageTitlesArray["dbo_ESTADO_COMPESADO"]["Spanish"] = SettingsMap.GetArray();
				fieldLabelsArray["dbo_ESTADO_COMPESADO"]["Spanish"]["id_estado_compesado"] = "ID";
				fieldToolTipsArray["dbo_ESTADO_COMPESADO"]["Spanish"]["id_estado_compesado"] = "";
				placeHoldersArray["dbo_ESTADO_COMPESADO"]["Spanish"]["id_estado_compesado"] = "";
				fieldLabelsArray["dbo_ESTADO_COMPESADO"]["Spanish"]["estado_compesado"] = "Estado Compesado";
				fieldToolTipsArray["dbo_ESTADO_COMPESADO"]["Spanish"]["estado_compesado"] = "";
				placeHoldersArray["dbo_ESTADO_COMPESADO"]["Spanish"]["estado_compesado"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["dbo_ESTADO_COMPESADO"]["Spanish"])))
				{
					tdataArray["dbo_ESTADO_COMPESADO"][".isUseToolTips"] = true;
				}
			}
			tdataArray["dbo_ESTADO_COMPESADO"][".NCSearch"] = true;
			tdataArray["dbo_ESTADO_COMPESADO"][".shortTableName"] = "dbo_ESTADO_COMPESADO";
			tdataArray["dbo_ESTADO_COMPESADO"][".nSecOptions"] = 0;
			tdataArray["dbo_ESTADO_COMPESADO"][".mainTableOwnerID"] = "";
			tdataArray["dbo_ESTADO_COMPESADO"][".entityType"] = 0;
			tdataArray["dbo_ESTADO_COMPESADO"][".strOriginalTableName"] = "dbo.ESTADO_COMPESADO";
			tdataArray["dbo_ESTADO_COMPESADO"][".showAddInPopup"] = false;
			tdataArray["dbo_ESTADO_COMPESADO"][".showEditInPopup"] = false;
			tdataArray["dbo_ESTADO_COMPESADO"][".showViewInPopup"] = false;
			popupPagesLayoutNames = SettingsMap.GetArray();
			tdataArray["dbo_ESTADO_COMPESADO"][".popupPagesLayoutNames"] = popupPagesLayoutNames;
			tdataArray["dbo_ESTADO_COMPESADO"][".listAjax"] = false;
			tdataArray["dbo_ESTADO_COMPESADO"][".listAjax"] = false;
			tdataArray["dbo_ESTADO_COMPESADO"][".audit"] = true;
			tdataArray["dbo_ESTADO_COMPESADO"][".locking"] = false;
			GlobalVars.pages = tdataArray["dbo_ESTADO_COMPESADO"][".pages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["dbo_ESTADO_COMPESADO"][".edit"] = true;
				tdataArray["dbo_ESTADO_COMPESADO"][".afterEditAction"] = 1;
				tdataArray["dbo_ESTADO_COMPESADO"][".closePopupAfterEdit"] = 1;
				tdataArray["dbo_ESTADO_COMPESADO"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["dbo_ESTADO_COMPESADO"][".add"] = true;
				tdataArray["dbo_ESTADO_COMPESADO"][".afterAddAction"] = 1;
				tdataArray["dbo_ESTADO_COMPESADO"][".closePopupAfterAdd"] = 1;
				tdataArray["dbo_ESTADO_COMPESADO"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["dbo_ESTADO_COMPESADO"][".list"] = true;
			}
			tdataArray["dbo_ESTADO_COMPESADO"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["dbo_ESTADO_COMPESADO"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["dbo_ESTADO_COMPESADO"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["dbo_ESTADO_COMPESADO"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["dbo_ESTADO_COMPESADO"][".printFriendly"] = true;
			}
			tdataArray["dbo_ESTADO_COMPESADO"][".showSimpleSearchOptions"] = true;
			tdataArray["dbo_ESTADO_COMPESADO"][".allowShowHideFields"] = true;
			tdataArray["dbo_ESTADO_COMPESADO"][".allowFieldsReordering"] = true;
			tdataArray["dbo_ESTADO_COMPESADO"][".isUseAjaxSuggest"] = true;
			tdataArray["dbo_ESTADO_COMPESADO"][".rowHighlite"] = true;


			tdataArray["dbo_ESTADO_COMPESADO"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["dbo_ESTADO_COMPESADO"][".buttonsAdded"] = false;
			tdataArray["dbo_ESTADO_COMPESADO"][".addPageEvents"] = false;
			tdataArray["dbo_ESTADO_COMPESADO"][".isUseTimeForSearch"] = false;
			tdataArray["dbo_ESTADO_COMPESADO"][".badgeColor"] = "6493EA";
			tdataArray["dbo_ESTADO_COMPESADO"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["dbo_ESTADO_COMPESADO"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["dbo_ESTADO_COMPESADO"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["dbo_ESTADO_COMPESADO"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["dbo_ESTADO_COMPESADO"][".googleLikeFields"].Add("id_estado_compesado");
			tdataArray["dbo_ESTADO_COMPESADO"][".googleLikeFields"].Add("estado_compesado");
			tdataArray["dbo_ESTADO_COMPESADO"][".tableType"] = "list";
			tdataArray["dbo_ESTADO_COMPESADO"][".printerPageOrientation"] = 0;
			tdataArray["dbo_ESTADO_COMPESADO"][".nPrinterPageScale"] = 100;
			tdataArray["dbo_ESTADO_COMPESADO"][".nPrinterSplitRecords"] = 40;
			tdataArray["dbo_ESTADO_COMPESADO"][".nPrinterPDFSplitRecords"] = 40;
			tdataArray["dbo_ESTADO_COMPESADO"][".geocodingEnabled"] = false;
			tdataArray["dbo_ESTADO_COMPESADO"][".pageSize"] = 20;
			tdataArray["dbo_ESTADO_COMPESADO"][".warnLeavingPages"] = true;
			tstrOrderBy = "";
			if(MVCFunctions.strlen(tstrOrderBy) && MVCFunctions.strtolower(MVCFunctions.substr(tstrOrderBy, new XVar(0), new XVar(8))) != "order by")
			{
				tstrOrderBy = MVCFunctions.Concat("order by ", tstrOrderBy);
			}
			tdataArray["dbo_ESTADO_COMPESADO"][".strOrderBy"] = tstrOrderBy;
			tdataArray["dbo_ESTADO_COMPESADO"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["dbo_ESTADO_COMPESADO"][".sqlHead"] = "SELECT id_estado_compesado,  	estado_compesado";
			tdataArray["dbo_ESTADO_COMPESADO"][".sqlFrom"] = "FROM dbo.ESTADO_COMPESADO";
			tdataArray["dbo_ESTADO_COMPESADO"][".sqlWhereExpr"] = "";
			tdataArray["dbo_ESTADO_COMPESADO"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["dbo_ESTADO_COMPESADO"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["dbo_ESTADO_COMPESADO"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["dbo_ESTADO_COMPESADO"][".highlightSearchResults"] = true;
			tableKeysArray["dbo_ESTADO_COMPESADO"] = SettingsMap.GetArray();
			tableKeysArray["dbo_ESTADO_COMPESADO"].Add("id_estado_compesado");
			tdataArray["dbo_ESTADO_COMPESADO"][".Keys"] = tableKeysArray["dbo_ESTADO_COMPESADO"];
			tdataArray["dbo_ESTADO_COMPESADO"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "id_estado_compesado";
			fdata["GoodName"] = "id_estado_compesado";
			fdata["ownerTable"] = "dbo.ESTADO_COMPESADO";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_ESTADO_COMPESADO","id_estado_compesado");
			fdata["FieldType"] = 3;
			fdata["strField"] = "id_estado_compesado";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "id_estado_compesado";
			fdata["UploadFolder"] = "files";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "");
			vdata["NeedEncode"] = true;
			fdata["ViewFormats"]["view"] = vdata;
			fdata["EditFormats"] = SettingsMap.GetArray();
			edata = new XVar("EditFormat", "Text field");
			edata["IsRequired"] = true;
			edata["acceptFileTypes"] = ".+$";
			edata["maxNumberOfFiles"] = 1;
			edata["HTML5InuptType"] = "text";
			edata["EditParams"] = "";
			edata["controlWidth"] = 200;
			edata["validateAs"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"] = SettingsMap.GetArray();
			edata["validateAs"]["customMessages"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"].Add(CommonFunctions.getJsValidatorName(new XVar("Number")));
			edata["validateAs"]["basicValidate"].Add("IsRequired");
			fdata["EditFormats"]["edit"] = edata;
			fdata["isSeparate"] = false;
			fdata["defaultSearchOption"] = "Contains";
			fdata["searchOptionsList"] = new XVar(0, "Contains", 1, "Equals", 2, "Starts with", 3, "More than", 4, "Less than", 5, "Between", 6, "Empty", 7, Constants.NOT_EMPTY);
			fdata["filterTotals"] = 0;
			fdata["filterMultiSelect"] = 0;
			fdata["filterFormat"] = "Values list";
			fdata["showCollapsed"] = false;
			fdata["sortValueType"] = 0;
			fdata["numberOfVisibleItems"] = 10;
			tdataArray["dbo_ESTADO_COMPESADO"]["id_estado_compesado"] = fdata;
			tdataArray["dbo_ESTADO_COMPESADO"][".searchableFields"].Add("id_estado_compesado");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "estado_compesado";
			fdata["GoodName"] = "estado_compesado";
			fdata["ownerTable"] = "dbo.ESTADO_COMPESADO";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_ESTADO_COMPESADO","estado_compesado");
			fdata["FieldType"] = 200;
			fdata["strField"] = "estado_compesado";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "estado_compesado";
			fdata["UploadFolder"] = "files";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "");
			vdata["NeedEncode"] = true;
			fdata["ViewFormats"]["view"] = vdata;
			fdata["EditFormats"] = SettingsMap.GetArray();
			edata = new XVar("EditFormat", "Text field");
			edata["IsRequired"] = true;
			edata["acceptFileTypes"] = ".+$";
			edata["maxNumberOfFiles"] = 1;
			edata["HTML5InuptType"] = "text";
			edata["EditParams"] = "";
			edata["EditParams"] = MVCFunctions.Concat(edata["EditParams"], " maxlength=10");
			edata["controlWidth"] = 200;
			edata["validateAs"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"] = SettingsMap.GetArray();
			edata["validateAs"]["customMessages"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"].Add("IsRequired");
			fdata["EditFormats"]["edit"] = edata;
			fdata["isSeparate"] = false;
			fdata["defaultSearchOption"] = "Contains";
			fdata["searchOptionsList"] = new XVar(0, "Contains", 1, "Equals", 2, "Starts with", 3, "More than", 4, "Less than", 5, "Between", 6, "Empty", 7, Constants.NOT_EMPTY);
			fdata["filterTotals"] = 0;
			fdata["filterMultiSelect"] = 0;
			fdata["filterFormat"] = "Values list";
			fdata["showCollapsed"] = false;
			fdata["sortValueType"] = 0;
			fdata["numberOfVisibleItems"] = 10;
			tdataArray["dbo_ESTADO_COMPESADO"]["estado_compesado"] = fdata;
			tdataArray["dbo_ESTADO_COMPESADO"][".searchableFields"].Add("estado_compesado");
			GlobalVars.tables_data["dbo.ESTADO_COMPESADO"] = tdataArray["dbo_ESTADO_COMPESADO"];
			GlobalVars.field_labels["dbo_ESTADO_COMPESADO"] = fieldLabelsArray["dbo_ESTADO_COMPESADO"];
			GlobalVars.fieldToolTips["dbo_ESTADO_COMPESADO"] = fieldToolTipsArray["dbo_ESTADO_COMPESADO"];
			GlobalVars.placeHolders["dbo_ESTADO_COMPESADO"] = placeHoldersArray["dbo_ESTADO_COMPESADO"];
			GlobalVars.page_titles["dbo_ESTADO_COMPESADO"] = pageTitlesArray["dbo_ESTADO_COMPESADO"];
			GlobalVars.detailsTablesData["dbo.ESTADO_COMPESADO"] = SettingsMap.GetArray();


			dIndex = 0;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "dbo.REGISTRO_HORAS_COMPESADAS";
			detailsParam["dOriginalTable"] = "dbo.REGISTRO_HORAS_COMPESADAS";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "dbo_REGISTRO_HORAS_COMPESADAS";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("dbo_REGISTRO_HORAS_COMPESADAS"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.ESTADO_COMPESADO"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["dbo.ESTADO_COMPESADO"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.ESTADO_COMPESADO"][dIndex]["masterKeys"].Add("id_estado_compesado");
			GlobalVars.detailsTablesData["dbo.ESTADO_COMPESADO"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.ESTADO_COMPESADO"][dIndex]["detailKeys"].Add("id_estado_compesado");


			dIndex = 1;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "VER_COMPESADOS";
			detailsParam["dOriginalTable"] = "dbo.REGISTRO_HORAS_COMPESADAS";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "VER_COMPESADOS";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("VER_COMPESADOS"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.ESTADO_COMPESADO"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["dbo.ESTADO_COMPESADO"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.ESTADO_COMPESADO"][dIndex]["masterKeys"].Add("id_estado_compesado");
			GlobalVars.detailsTablesData["dbo.ESTADO_COMPESADO"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.ESTADO_COMPESADO"][dIndex]["detailKeys"].Add("id_estado_compesado");


			dIndex = 2;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "APROBACION_COMPESADOS_JEFEINMEDIATO";
			detailsParam["dOriginalTable"] = "dbo.REGISTRO_HORAS_COMPESADAS";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "APROBACION_COMPESADOS_JEFEINMEDIATO";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("APROBACION_COMPESADOS_JEFEINMEDIATO"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.ESTADO_COMPESADO"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["dbo.ESTADO_COMPESADO"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.ESTADO_COMPESADO"][dIndex]["masterKeys"].Add("id_estado_compesado");
			GlobalVars.detailsTablesData["dbo.ESTADO_COMPESADO"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.ESTADO_COMPESADO"][dIndex]["detailKeys"].Add("id_estado_compesado");


			dIndex = 3;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "APROBACION_COMPESADOS_JEFEDEPARTAMENTO";
			detailsParam["dOriginalTable"] = "dbo.REGISTRO_HORAS_COMPESADAS";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "APROBACION_COMPESADOS_JEFEDEPARTAMENTO";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("APROBACION_COMPESADOS_JEFEDEPARTAMENTO"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.ESTADO_COMPESADO"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["dbo.ESTADO_COMPESADO"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.ESTADO_COMPESADO"][dIndex]["masterKeys"].Add("id_estado_compesado");
			GlobalVars.detailsTablesData["dbo.ESTADO_COMPESADO"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.ESTADO_COMPESADO"][dIndex]["detailKeys"].Add("id_estado_compesado");


			dIndex = 4;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "APROBAR_COMPESADOS";
			detailsParam["dOriginalTable"] = "dbo.REGISTRO_HORAS_COMPESADAS";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "APROBAR_COMPESADOS";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("APROBAR_COMPESADOS"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.ESTADO_COMPESADO"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["dbo.ESTADO_COMPESADO"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.ESTADO_COMPESADO"][dIndex]["masterKeys"].Add("id_estado_compesado");
			GlobalVars.detailsTablesData["dbo.ESTADO_COMPESADO"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.ESTADO_COMPESADO"][dIndex]["detailKeys"].Add("id_estado_compesado");


			dIndex = 5;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "INGRESAR_COMPESADO";
			detailsParam["dOriginalTable"] = "dbo.REGISTRO_HORAS_COMPESADAS";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "INGRESAR_COMPESADO";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("INGRESAR_COMPESADO"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.ESTADO_COMPESADO"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["dbo.ESTADO_COMPESADO"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.ESTADO_COMPESADO"][dIndex]["masterKeys"].Add("id_estado_compesado");
			GlobalVars.detailsTablesData["dbo.ESTADO_COMPESADO"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.ESTADO_COMPESADO"][dIndex]["detailKeys"].Add("id_estado_compesado");
			GlobalVars.masterTablesData["dbo.ESTADO_COMPESADO"] = SettingsMap.GetArray();

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "id_estado_compesado,  	estado_compesado";
protoArray["0"]["m_strFrom"] = "FROM dbo.ESTADO_COMPESADO";
protoArray["0"]["m_strWhere"] = "";
protoArray["0"]["m_strOrderBy"] = "";
	
		
protoArray["0"]["cipherer"] = null;
protoArray["2"] = SettingsMap.GetArray();
protoArray["2"]["m_sql"] = "";
protoArray["2"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLNonParsed(new XVar("m_sql", ""));

protoArray["2"]["m_column"] = obj;
protoArray["2"]["m_contained"] = SettingsMap.GetArray();
protoArray["2"]["m_strCase"] = "";
protoArray["2"]["m_havingmode"] = false;
protoArray["2"]["m_inBrackets"] = false;
protoArray["2"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["2"]);

protoArray["0"]["m_where"] = obj;
protoArray["4"] = SettingsMap.GetArray();
protoArray["4"]["m_sql"] = "";
protoArray["4"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLNonParsed(new XVar("m_sql", ""));

protoArray["4"]["m_column"] = obj;
protoArray["4"]["m_contained"] = SettingsMap.GetArray();
protoArray["4"]["m_strCase"] = "";
protoArray["4"]["m_havingmode"] = false;
protoArray["4"]["m_inBrackets"] = false;
protoArray["4"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["4"]);

protoArray["0"]["m_having"] = obj;
protoArray["0"]["m_fieldlist"] = SettingsMap.GetArray();
protoArray["6"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "id_estado_compesado", "m_strTable", "dbo.ESTADO_COMPESADO", "m_srcTableName", "dbo.ESTADO_COMPESADO"));

protoArray["6"]["m_sql"] = "id_estado_compesado";
protoArray["6"]["m_srcTableName"] = "dbo.ESTADO_COMPESADO";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "estado_compesado", "m_strTable", "dbo.ESTADO_COMPESADO", "m_srcTableName", "dbo.ESTADO_COMPESADO"));

protoArray["8"]["m_sql"] = "estado_compesado";
protoArray["8"]["m_srcTableName"] = "dbo.ESTADO_COMPESADO";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["10"] = SettingsMap.GetArray();
protoArray["10"]["m_link"] = "SQLL_MAIN";
protoArray["11"] = SettingsMap.GetArray();
protoArray["11"]["m_strName"] = "dbo.ESTADO_COMPESADO";
protoArray["11"]["m_srcTableName"] = "dbo.ESTADO_COMPESADO";
protoArray["11"]["m_columns"] = SettingsMap.GetArray();
protoArray["11"]["m_columns"].Add("id_estado_compesado");
protoArray["11"]["m_columns"].Add("estado_compesado");
obj = new SQLTable(protoArray["11"]);

protoArray["10"]["m_table"] = obj;
protoArray["10"]["m_sql"] = "dbo.ESTADO_COMPESADO";
protoArray["10"]["m_alias"] = "";
protoArray["10"]["m_srcTableName"] = "dbo.ESTADO_COMPESADO";
protoArray["12"] = SettingsMap.GetArray();
protoArray["12"]["m_sql"] = "";
protoArray["12"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLNonParsed(new XVar("m_sql", ""));

protoArray["12"]["m_column"] = obj;
protoArray["12"]["m_contained"] = SettingsMap.GetArray();
protoArray["12"]["m_strCase"] = "";
protoArray["12"]["m_havingmode"] = false;
protoArray["12"]["m_inBrackets"] = false;
protoArray["12"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["12"]);

protoArray["10"]["m_joinon"] = obj;
obj = new SQLFromListItem(protoArray["10"]);

protoArray["0"]["m_fromlist"].Add(obj);
protoArray["0"]["m_groupby"] = SettingsMap.GetArray();
protoArray["0"]["m_orderby"] = SettingsMap.GetArray();
protoArray["0"]["m_srcTableName"] = "dbo.ESTADO_COMPESADO";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["dbo_ESTADO_COMPESADO"] = obj;

				
		
			tdataArray["dbo_ESTADO_COMPESADO"][".sqlquery"] = queryData_Array["dbo_ESTADO_COMPESADO"];
			GlobalVars.tableEvents["dbo.ESTADO_COMPESADO"] = new eventsBase();
			tdataArray["dbo_ESTADO_COMPESADO"][".hasEvents"] = false;
			GlobalVars.tables_data["dbo_ESTADO_COMPESADO"] = tdataArray["dbo_ESTADO_COMPESADO"];
		}
	}

}
