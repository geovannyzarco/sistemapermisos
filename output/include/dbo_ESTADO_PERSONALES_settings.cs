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
	public static partial class Settings_dbo_ESTADO_PERSONALES
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), popupPagesLayoutNames = SettingsMap.GetArray(), query = null, queryData_Array = new XVar(), reportGroupFields = SettingsMap.GetArray(), rgroupField = SettingsMap.GetArray(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["dbo_ESTADO_PERSONALES"] = SettingsMap.GetArray();
			tdataArray["dbo_ESTADO_PERSONALES"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["dbo_ESTADO_PERSONALES"][".truncateText"] = true;
			tdataArray["dbo_ESTADO_PERSONALES"][".NumberOfChars"] = 80;
			tdataArray["dbo_ESTADO_PERSONALES"][".ShortName"] = "dbo_ESTADO_PERSONALES";
			tdataArray["dbo_ESTADO_PERSONALES"][".OwnerID"] = "";
			tdataArray["dbo_ESTADO_PERSONALES"][".OriginalTable"] = "dbo.ESTADO_PERSONALES";
			GlobalVars.defaultPages = MVCFunctions.my_json_decode(new XVar("{\"add\":\"add\",\"edit\":\"edit\",\"export\":\"export\",\"list\":\"list\",\"masterlist\":\"masterlist\",\"masterprint\":\"masterprint\",\"search\":\"search\"}"));
			tdataArray["dbo_ESTADO_PERSONALES"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"add\":[\"add\"],\"edit\":[\"edit\"],\"export\":[\"export\"],\"list\":[\"list\"],\"masterlist\":[\"masterlist\"],\"masterprint\":[\"masterprint\"],\"search\":[\"search\"]}")));
			tdataArray["dbo_ESTADO_PERSONALES"][".defaultPages"] = GlobalVars.defaultPages;
			fieldLabelsArray["dbo_ESTADO_PERSONALES"] = SettingsMap.GetArray();
			fieldToolTipsArray["dbo_ESTADO_PERSONALES"] = SettingsMap.GetArray();
			pageTitlesArray["dbo_ESTADO_PERSONALES"] = SettingsMap.GetArray();
			placeHoldersArray["dbo_ESTADO_PERSONALES"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "Spanish")
			{
				fieldLabelsArray["dbo_ESTADO_PERSONALES"]["Spanish"] = SettingsMap.GetArray();
				fieldToolTipsArray["dbo_ESTADO_PERSONALES"]["Spanish"] = SettingsMap.GetArray();
				placeHoldersArray["dbo_ESTADO_PERSONALES"]["Spanish"] = SettingsMap.GetArray();
				pageTitlesArray["dbo_ESTADO_PERSONALES"]["Spanish"] = SettingsMap.GetArray();
				fieldLabelsArray["dbo_ESTADO_PERSONALES"]["Spanish"]["id_estado_personal"] = "ID";
				fieldToolTipsArray["dbo_ESTADO_PERSONALES"]["Spanish"]["id_estado_personal"] = "";
				placeHoldersArray["dbo_ESTADO_PERSONALES"]["Spanish"]["id_estado_personal"] = "";
				fieldLabelsArray["dbo_ESTADO_PERSONALES"]["Spanish"]["estado_personal"] = "Estado Personal";
				fieldToolTipsArray["dbo_ESTADO_PERSONALES"]["Spanish"]["estado_personal"] = "";
				placeHoldersArray["dbo_ESTADO_PERSONALES"]["Spanish"]["estado_personal"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["dbo_ESTADO_PERSONALES"]["Spanish"])))
				{
					tdataArray["dbo_ESTADO_PERSONALES"][".isUseToolTips"] = true;
				}
			}
			tdataArray["dbo_ESTADO_PERSONALES"][".NCSearch"] = true;
			tdataArray["dbo_ESTADO_PERSONALES"][".shortTableName"] = "dbo_ESTADO_PERSONALES";
			tdataArray["dbo_ESTADO_PERSONALES"][".nSecOptions"] = 0;
			tdataArray["dbo_ESTADO_PERSONALES"][".mainTableOwnerID"] = "";
			tdataArray["dbo_ESTADO_PERSONALES"][".entityType"] = 0;
			tdataArray["dbo_ESTADO_PERSONALES"][".strOriginalTableName"] = "dbo.ESTADO_PERSONALES";
			tdataArray["dbo_ESTADO_PERSONALES"][".showAddInPopup"] = false;
			tdataArray["dbo_ESTADO_PERSONALES"][".showEditInPopup"] = false;
			tdataArray["dbo_ESTADO_PERSONALES"][".showViewInPopup"] = false;
			popupPagesLayoutNames = SettingsMap.GetArray();
			tdataArray["dbo_ESTADO_PERSONALES"][".popupPagesLayoutNames"] = popupPagesLayoutNames;
			tdataArray["dbo_ESTADO_PERSONALES"][".listAjax"] = false;
			tdataArray["dbo_ESTADO_PERSONALES"][".listAjax"] = false;
			tdataArray["dbo_ESTADO_PERSONALES"][".audit"] = true;
			tdataArray["dbo_ESTADO_PERSONALES"][".locking"] = false;
			GlobalVars.pages = tdataArray["dbo_ESTADO_PERSONALES"][".pages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["dbo_ESTADO_PERSONALES"][".edit"] = true;
				tdataArray["dbo_ESTADO_PERSONALES"][".afterEditAction"] = 1;
				tdataArray["dbo_ESTADO_PERSONALES"][".closePopupAfterEdit"] = 1;
				tdataArray["dbo_ESTADO_PERSONALES"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["dbo_ESTADO_PERSONALES"][".add"] = true;
				tdataArray["dbo_ESTADO_PERSONALES"][".afterAddAction"] = 1;
				tdataArray["dbo_ESTADO_PERSONALES"][".closePopupAfterAdd"] = 1;
				tdataArray["dbo_ESTADO_PERSONALES"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["dbo_ESTADO_PERSONALES"][".list"] = true;
			}
			tdataArray["dbo_ESTADO_PERSONALES"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["dbo_ESTADO_PERSONALES"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["dbo_ESTADO_PERSONALES"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["dbo_ESTADO_PERSONALES"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["dbo_ESTADO_PERSONALES"][".printFriendly"] = true;
			}
			tdataArray["dbo_ESTADO_PERSONALES"][".showSimpleSearchOptions"] = true;
			tdataArray["dbo_ESTADO_PERSONALES"][".allowShowHideFields"] = true;
			tdataArray["dbo_ESTADO_PERSONALES"][".allowFieldsReordering"] = true;
			tdataArray["dbo_ESTADO_PERSONALES"][".isUseAjaxSuggest"] = true;
			tdataArray["dbo_ESTADO_PERSONALES"][".rowHighlite"] = true;


			tdataArray["dbo_ESTADO_PERSONALES"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["dbo_ESTADO_PERSONALES"][".buttonsAdded"] = false;
			tdataArray["dbo_ESTADO_PERSONALES"][".addPageEvents"] = false;
			tdataArray["dbo_ESTADO_PERSONALES"][".isUseTimeForSearch"] = false;
			tdataArray["dbo_ESTADO_PERSONALES"][".badgeColor"] = "4682B4";
			tdataArray["dbo_ESTADO_PERSONALES"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["dbo_ESTADO_PERSONALES"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["dbo_ESTADO_PERSONALES"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["dbo_ESTADO_PERSONALES"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["dbo_ESTADO_PERSONALES"][".googleLikeFields"].Add("id_estado_personal");
			tdataArray["dbo_ESTADO_PERSONALES"][".googleLikeFields"].Add("estado_personal");
			tdataArray["dbo_ESTADO_PERSONALES"][".tableType"] = "list";
			tdataArray["dbo_ESTADO_PERSONALES"][".printerPageOrientation"] = 0;
			tdataArray["dbo_ESTADO_PERSONALES"][".nPrinterPageScale"] = 100;
			tdataArray["dbo_ESTADO_PERSONALES"][".nPrinterSplitRecords"] = 40;
			tdataArray["dbo_ESTADO_PERSONALES"][".nPrinterPDFSplitRecords"] = 40;
			tdataArray["dbo_ESTADO_PERSONALES"][".geocodingEnabled"] = false;
			tdataArray["dbo_ESTADO_PERSONALES"][".pageSize"] = 20;
			tdataArray["dbo_ESTADO_PERSONALES"][".warnLeavingPages"] = true;
			tstrOrderBy = "";
			if(MVCFunctions.strlen(tstrOrderBy) && MVCFunctions.strtolower(MVCFunctions.substr(tstrOrderBy, new XVar(0), new XVar(8))) != "order by")
			{
				tstrOrderBy = MVCFunctions.Concat("order by ", tstrOrderBy);
			}
			tdataArray["dbo_ESTADO_PERSONALES"][".strOrderBy"] = tstrOrderBy;
			tdataArray["dbo_ESTADO_PERSONALES"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["dbo_ESTADO_PERSONALES"][".sqlHead"] = "SELECT id_estado_personal,  	estado_personal";
			tdataArray["dbo_ESTADO_PERSONALES"][".sqlFrom"] = "FROM dbo.ESTADO_PERSONALES";
			tdataArray["dbo_ESTADO_PERSONALES"][".sqlWhereExpr"] = "";
			tdataArray["dbo_ESTADO_PERSONALES"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["dbo_ESTADO_PERSONALES"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["dbo_ESTADO_PERSONALES"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["dbo_ESTADO_PERSONALES"][".highlightSearchResults"] = true;
			tableKeysArray["dbo_ESTADO_PERSONALES"] = SettingsMap.GetArray();
			tableKeysArray["dbo_ESTADO_PERSONALES"].Add("id_estado_personal");
			tdataArray["dbo_ESTADO_PERSONALES"][".Keys"] = tableKeysArray["dbo_ESTADO_PERSONALES"];
			tdataArray["dbo_ESTADO_PERSONALES"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "id_estado_personal";
			fdata["GoodName"] = "id_estado_personal";
			fdata["ownerTable"] = "dbo.ESTADO_PERSONALES";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_ESTADO_PERSONALES","id_estado_personal");
			fdata["FieldType"] = 3;
			fdata["AutoInc"] = true;
			fdata["strField"] = "id_estado_personal";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "id_estado_personal";
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
			tdataArray["dbo_ESTADO_PERSONALES"]["id_estado_personal"] = fdata;
			tdataArray["dbo_ESTADO_PERSONALES"][".searchableFields"].Add("id_estado_personal");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "estado_personal";
			fdata["GoodName"] = "estado_personal";
			fdata["ownerTable"] = "dbo.ESTADO_PERSONALES";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_ESTADO_PERSONALES","estado_personal");
			fdata["FieldType"] = 200;
			fdata["strField"] = "estado_personal";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "estado_personal";
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
			tdataArray["dbo_ESTADO_PERSONALES"]["estado_personal"] = fdata;
			tdataArray["dbo_ESTADO_PERSONALES"][".searchableFields"].Add("estado_personal");
			GlobalVars.tables_data["dbo.ESTADO_PERSONALES"] = tdataArray["dbo_ESTADO_PERSONALES"];
			GlobalVars.field_labels["dbo_ESTADO_PERSONALES"] = fieldLabelsArray["dbo_ESTADO_PERSONALES"];
			GlobalVars.fieldToolTips["dbo_ESTADO_PERSONALES"] = fieldToolTipsArray["dbo_ESTADO_PERSONALES"];
			GlobalVars.placeHolders["dbo_ESTADO_PERSONALES"] = placeHoldersArray["dbo_ESTADO_PERSONALES"];
			GlobalVars.page_titles["dbo_ESTADO_PERSONALES"] = pageTitlesArray["dbo_ESTADO_PERSONALES"];
			GlobalVars.detailsTablesData["dbo.ESTADO_PERSONALES"] = SettingsMap.GetArray();


			dIndex = 0;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "dbo.Permisos2";
			detailsParam["dOriginalTable"] = "dbo.Permisos2";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "dbo_Permisos2";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("dbo_Permisos2"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.ESTADO_PERSONALES"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["dbo.ESTADO_PERSONALES"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.ESTADO_PERSONALES"][dIndex]["masterKeys"].Add("id_estado_personal");
			GlobalVars.detailsTablesData["dbo.ESTADO_PERSONALES"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.ESTADO_PERSONALES"][dIndex]["detailKeys"].Add("id_estado_personal");


			dIndex = 1;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "APROBAR_PERMISOS";
			detailsParam["dOriginalTable"] = "dbo.Permisos2";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "APROBAR_PERMISOS";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("APROBAR_PERMISOS"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.ESTADO_PERSONALES"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["dbo.ESTADO_PERSONALES"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.ESTADO_PERSONALES"][dIndex]["masterKeys"].Add("id_estado_personal");
			GlobalVars.detailsTablesData["dbo.ESTADO_PERSONALES"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.ESTADO_PERSONALES"][dIndex]["detailKeys"].Add("id_estado_personal");


			dIndex = 2;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "VISTOBUENO_JEFEINMEDIATO";
			detailsParam["dOriginalTable"] = "dbo.Permisos2";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "VISTOBUENO_JEFEINMEDIATO";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("VISTOBUENO_JEFEINMEDIATO"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.ESTADO_PERSONALES"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["dbo.ESTADO_PERSONALES"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.ESTADO_PERSONALES"][dIndex]["masterKeys"].Add("id_estado_personal");
			GlobalVars.detailsTablesData["dbo.ESTADO_PERSONALES"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.ESTADO_PERSONALES"][dIndex]["detailKeys"].Add("id_estado_personal");


			dIndex = 3;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "VISTOBUENO_JEFEDEPARTAMENTO";
			detailsParam["dOriginalTable"] = "dbo.Permisos2";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "VISTOBUENO_JEFEDEPARTAMENTO";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("VISTOBUENO_JEFEDEPARTAMENTO"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.ESTADO_PERSONALES"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["dbo.ESTADO_PERSONALES"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.ESTADO_PERSONALES"][dIndex]["masterKeys"].Add("id_estado_personal");
			GlobalVars.detailsTablesData["dbo.ESTADO_PERSONALES"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.ESTADO_PERSONALES"][dIndex]["detailKeys"].Add("id_estado_personal");


			dIndex = 4;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "VER_PERMISOS";
			detailsParam["dOriginalTable"] = "dbo.Permisos2";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "VER_PERMISOS";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("VER_PERMISOS"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.ESTADO_PERSONALES"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["dbo.ESTADO_PERSONALES"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.ESTADO_PERSONALES"][dIndex]["masterKeys"].Add("id_estado_personal");
			GlobalVars.detailsTablesData["dbo.ESTADO_PERSONALES"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.ESTADO_PERSONALES"][dIndex]["detailKeys"].Add("id_estado_personal");


			dIndex = 5;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "INGRESAR PERMISO";
			detailsParam["dOriginalTable"] = "dbo.Permisos2";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "INGRESAR_PERMISO";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("INGRESAR_PERMISO"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.ESTADO_PERSONALES"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["dbo.ESTADO_PERSONALES"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.ESTADO_PERSONALES"][dIndex]["masterKeys"].Add("id_estado_personal");
			GlobalVars.detailsTablesData["dbo.ESTADO_PERSONALES"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.ESTADO_PERSONALES"][dIndex]["detailKeys"].Add("id_estado_personal");


			dIndex = 6;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "Licencias_sin_goce_sueldo";
			detailsParam["dOriginalTable"] = "dbo.Permisos2";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "Licencias_sin_goce_sueldo";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("Licencias_sin_goce_sueldo"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.ESTADO_PERSONALES"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["dbo.ESTADO_PERSONALES"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.ESTADO_PERSONALES"][dIndex]["masterKeys"].Add("id_estado_personal");
			GlobalVars.detailsTablesData["dbo.ESTADO_PERSONALES"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.ESTADO_PERSONALES"][dIndex]["detailKeys"].Add("id_estado_personal");
			GlobalVars.masterTablesData["dbo.ESTADO_PERSONALES"] = SettingsMap.GetArray();

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "id_estado_personal,  	estado_personal";
protoArray["0"]["m_strFrom"] = "FROM dbo.ESTADO_PERSONALES";
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
obj = new SQLField(new XVar("m_strName", "id_estado_personal", "m_strTable", "dbo.ESTADO_PERSONALES", "m_srcTableName", "dbo.ESTADO_PERSONALES"));

protoArray["6"]["m_sql"] = "id_estado_personal";
protoArray["6"]["m_srcTableName"] = "dbo.ESTADO_PERSONALES";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "estado_personal", "m_strTable", "dbo.ESTADO_PERSONALES", "m_srcTableName", "dbo.ESTADO_PERSONALES"));

protoArray["8"]["m_sql"] = "estado_personal";
protoArray["8"]["m_srcTableName"] = "dbo.ESTADO_PERSONALES";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["10"] = SettingsMap.GetArray();
protoArray["10"]["m_link"] = "SQLL_MAIN";
protoArray["11"] = SettingsMap.GetArray();
protoArray["11"]["m_strName"] = "dbo.ESTADO_PERSONALES";
protoArray["11"]["m_srcTableName"] = "dbo.ESTADO_PERSONALES";
protoArray["11"]["m_columns"] = SettingsMap.GetArray();
protoArray["11"]["m_columns"].Add("id_estado_personal");
protoArray["11"]["m_columns"].Add("estado_personal");
obj = new SQLTable(protoArray["11"]);

protoArray["10"]["m_table"] = obj;
protoArray["10"]["m_sql"] = "dbo.ESTADO_PERSONALES";
protoArray["10"]["m_alias"] = "";
protoArray["10"]["m_srcTableName"] = "dbo.ESTADO_PERSONALES";
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
protoArray["0"]["m_srcTableName"] = "dbo.ESTADO_PERSONALES";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["dbo_ESTADO_PERSONALES"] = obj;

				
		
			tdataArray["dbo_ESTADO_PERSONALES"][".sqlquery"] = queryData_Array["dbo_ESTADO_PERSONALES"];
			GlobalVars.tableEvents["dbo.ESTADO_PERSONALES"] = new eventsBase();
			tdataArray["dbo_ESTADO_PERSONALES"][".hasEvents"] = false;
			GlobalVars.tables_data["dbo_ESTADO_PERSONALES"] = tdataArray["dbo_ESTADO_PERSONALES"];
		}
	}

}
