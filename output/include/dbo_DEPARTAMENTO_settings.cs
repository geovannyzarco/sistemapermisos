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
	public static partial class Settings_dbo_DEPARTAMENTO
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), popupPagesLayoutNames = SettingsMap.GetArray(), query = null, queryData_Array = new XVar(), reportGroupFields = SettingsMap.GetArray(), rgroupField = SettingsMap.GetArray(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["dbo_DEPARTAMENTO"] = SettingsMap.GetArray();
			tdataArray["dbo_DEPARTAMENTO"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["dbo_DEPARTAMENTO"][".truncateText"] = true;
			tdataArray["dbo_DEPARTAMENTO"][".NumberOfChars"] = 80;
			tdataArray["dbo_DEPARTAMENTO"][".ShortName"] = "dbo_DEPARTAMENTO";
			tdataArray["dbo_DEPARTAMENTO"][".OwnerID"] = "";
			tdataArray["dbo_DEPARTAMENTO"][".OriginalTable"] = "dbo.DEPARTAMENTO";
			GlobalVars.defaultPages = MVCFunctions.my_json_decode(new XVar("{\"add\":\"add\",\"edit\":\"edit\",\"export\":\"export\",\"list\":\"list\",\"masterlist\":\"masterlist\",\"masterprint\":\"masterprint\",\"search\":\"search\"}"));
			tdataArray["dbo_DEPARTAMENTO"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"add\":[\"add\"],\"edit\":[\"edit\"],\"export\":[\"export\"],\"list\":[\"list\"],\"masterlist\":[\"masterlist\"],\"masterprint\":[\"masterprint\"],\"search\":[\"search\"]}")));
			tdataArray["dbo_DEPARTAMENTO"][".defaultPages"] = GlobalVars.defaultPages;
			fieldLabelsArray["dbo_DEPARTAMENTO"] = SettingsMap.GetArray();
			fieldToolTipsArray["dbo_DEPARTAMENTO"] = SettingsMap.GetArray();
			pageTitlesArray["dbo_DEPARTAMENTO"] = SettingsMap.GetArray();
			placeHoldersArray["dbo_DEPARTAMENTO"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "Spanish")
			{
				fieldLabelsArray["dbo_DEPARTAMENTO"]["Spanish"] = SettingsMap.GetArray();
				fieldToolTipsArray["dbo_DEPARTAMENTO"]["Spanish"] = SettingsMap.GetArray();
				placeHoldersArray["dbo_DEPARTAMENTO"]["Spanish"] = SettingsMap.GetArray();
				pageTitlesArray["dbo_DEPARTAMENTO"]["Spanish"] = SettingsMap.GetArray();
				fieldLabelsArray["dbo_DEPARTAMENTO"]["Spanish"]["id_departamento"] = "ID";
				fieldToolTipsArray["dbo_DEPARTAMENTO"]["Spanish"]["id_departamento"] = "";
				placeHoldersArray["dbo_DEPARTAMENTO"]["Spanish"]["id_departamento"] = "";
				fieldLabelsArray["dbo_DEPARTAMENTO"]["Spanish"]["departamento"] = "Departamento";
				fieldToolTipsArray["dbo_DEPARTAMENTO"]["Spanish"]["departamento"] = "";
				placeHoldersArray["dbo_DEPARTAMENTO"]["Spanish"]["departamento"] = "";
				fieldLabelsArray["dbo_DEPARTAMENTO"]["Spanish"]["limite_permisos"] = "Limite de Permisos";
				fieldToolTipsArray["dbo_DEPARTAMENTO"]["Spanish"]["limite_permisos"] = "";
				placeHoldersArray["dbo_DEPARTAMENTO"]["Spanish"]["limite_permisos"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["dbo_DEPARTAMENTO"]["Spanish"])))
				{
					tdataArray["dbo_DEPARTAMENTO"][".isUseToolTips"] = true;
				}
			}
			tdataArray["dbo_DEPARTAMENTO"][".NCSearch"] = true;
			tdataArray["dbo_DEPARTAMENTO"][".shortTableName"] = "dbo_DEPARTAMENTO";
			tdataArray["dbo_DEPARTAMENTO"][".nSecOptions"] = 0;
			tdataArray["dbo_DEPARTAMENTO"][".mainTableOwnerID"] = "";
			tdataArray["dbo_DEPARTAMENTO"][".entityType"] = 0;
			tdataArray["dbo_DEPARTAMENTO"][".strOriginalTableName"] = "dbo.DEPARTAMENTO";
			tdataArray["dbo_DEPARTAMENTO"][".showAddInPopup"] = false;
			tdataArray["dbo_DEPARTAMENTO"][".showEditInPopup"] = false;
			tdataArray["dbo_DEPARTAMENTO"][".showViewInPopup"] = false;
			popupPagesLayoutNames = SettingsMap.GetArray();
			tdataArray["dbo_DEPARTAMENTO"][".popupPagesLayoutNames"] = popupPagesLayoutNames;
			tdataArray["dbo_DEPARTAMENTO"][".listAjax"] = false;
			tdataArray["dbo_DEPARTAMENTO"][".listAjax"] = false;
			tdataArray["dbo_DEPARTAMENTO"][".audit"] = true;
			tdataArray["dbo_DEPARTAMENTO"][".locking"] = false;
			GlobalVars.pages = tdataArray["dbo_DEPARTAMENTO"][".pages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["dbo_DEPARTAMENTO"][".edit"] = true;
				tdataArray["dbo_DEPARTAMENTO"][".afterEditAction"] = 1;
				tdataArray["dbo_DEPARTAMENTO"][".closePopupAfterEdit"] = 1;
				tdataArray["dbo_DEPARTAMENTO"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["dbo_DEPARTAMENTO"][".add"] = true;
				tdataArray["dbo_DEPARTAMENTO"][".afterAddAction"] = 1;
				tdataArray["dbo_DEPARTAMENTO"][".closePopupAfterAdd"] = 1;
				tdataArray["dbo_DEPARTAMENTO"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["dbo_DEPARTAMENTO"][".list"] = true;
			}
			tdataArray["dbo_DEPARTAMENTO"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["dbo_DEPARTAMENTO"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["dbo_DEPARTAMENTO"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["dbo_DEPARTAMENTO"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["dbo_DEPARTAMENTO"][".printFriendly"] = true;
			}
			tdataArray["dbo_DEPARTAMENTO"][".showSimpleSearchOptions"] = true;
			tdataArray["dbo_DEPARTAMENTO"][".allowShowHideFields"] = true;
			tdataArray["dbo_DEPARTAMENTO"][".allowFieldsReordering"] = true;
			tdataArray["dbo_DEPARTAMENTO"][".isUseAjaxSuggest"] = true;
			tdataArray["dbo_DEPARTAMENTO"][".rowHighlite"] = true;


			tdataArray["dbo_DEPARTAMENTO"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["dbo_DEPARTAMENTO"][".buttonsAdded"] = false;
			tdataArray["dbo_DEPARTAMENTO"][".addPageEvents"] = false;
			tdataArray["dbo_DEPARTAMENTO"][".isUseTimeForSearch"] = false;
			tdataArray["dbo_DEPARTAMENTO"][".badgeColor"] = "5F9EA0";
			tdataArray["dbo_DEPARTAMENTO"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["dbo_DEPARTAMENTO"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["dbo_DEPARTAMENTO"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["dbo_DEPARTAMENTO"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["dbo_DEPARTAMENTO"][".googleLikeFields"].Add("id_departamento");
			tdataArray["dbo_DEPARTAMENTO"][".googleLikeFields"].Add("departamento");
			tdataArray["dbo_DEPARTAMENTO"][".googleLikeFields"].Add("limite_permisos");
			tdataArray["dbo_DEPARTAMENTO"][".tableType"] = "list";
			tdataArray["dbo_DEPARTAMENTO"][".printerPageOrientation"] = 0;
			tdataArray["dbo_DEPARTAMENTO"][".nPrinterPageScale"] = 100;
			tdataArray["dbo_DEPARTAMENTO"][".nPrinterSplitRecords"] = 40;
			tdataArray["dbo_DEPARTAMENTO"][".nPrinterPDFSplitRecords"] = 40;
			tdataArray["dbo_DEPARTAMENTO"][".geocodingEnabled"] = false;
			tdataArray["dbo_DEPARTAMENTO"][".pageSize"] = 20;
			tdataArray["dbo_DEPARTAMENTO"][".warnLeavingPages"] = true;
			tstrOrderBy = "";
			if(MVCFunctions.strlen(tstrOrderBy) && MVCFunctions.strtolower(MVCFunctions.substr(tstrOrderBy, new XVar(0), new XVar(8))) != "order by")
			{
				tstrOrderBy = MVCFunctions.Concat("order by ", tstrOrderBy);
			}
			tdataArray["dbo_DEPARTAMENTO"][".strOrderBy"] = tstrOrderBy;
			tdataArray["dbo_DEPARTAMENTO"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["dbo_DEPARTAMENTO"][".sqlHead"] = "SELECT id_departamento,  	departamento,  	limite_permisos";
			tdataArray["dbo_DEPARTAMENTO"][".sqlFrom"] = "FROM dbo.DEPARTAMENTO";
			tdataArray["dbo_DEPARTAMENTO"][".sqlWhereExpr"] = "";
			tdataArray["dbo_DEPARTAMENTO"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["dbo_DEPARTAMENTO"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["dbo_DEPARTAMENTO"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["dbo_DEPARTAMENTO"][".highlightSearchResults"] = true;
			tableKeysArray["dbo_DEPARTAMENTO"] = SettingsMap.GetArray();
			tableKeysArray["dbo_DEPARTAMENTO"].Add("id_departamento");
			tdataArray["dbo_DEPARTAMENTO"][".Keys"] = tableKeysArray["dbo_DEPARTAMENTO"];
			tdataArray["dbo_DEPARTAMENTO"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "id_departamento";
			fdata["GoodName"] = "id_departamento";
			fdata["ownerTable"] = "dbo.DEPARTAMENTO";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_DEPARTAMENTO","id_departamento");
			fdata["FieldType"] = 3;
			fdata["AutoInc"] = true;
			fdata["strField"] = "id_departamento";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "id_departamento";
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
			fdata["searchOptionsList"] = SettingsMap.GetArray();
			fdata["searchOptionsList"].Add("Contains");
			fdata["filterTotals"] = 0;
			fdata["filterMultiSelect"] = 0;
			fdata["filterFormat"] = "Values list";
			fdata["showCollapsed"] = false;
			fdata["sortValueType"] = 0;
			fdata["numberOfVisibleItems"] = 10;
			tdataArray["dbo_DEPARTAMENTO"]["id_departamento"] = fdata;
			tdataArray["dbo_DEPARTAMENTO"][".searchableFields"].Add("id_departamento");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "departamento";
			fdata["GoodName"] = "departamento";
			fdata["ownerTable"] = "dbo.DEPARTAMENTO";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_DEPARTAMENTO","departamento");
			fdata["FieldType"] = 200;
			fdata["strField"] = "departamento";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "departamento";
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
			edata["EditParams"] = MVCFunctions.Concat(edata["EditParams"], " maxlength=100");
			edata["controlWidth"] = 200;
			edata["validateAs"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"] = SettingsMap.GetArray();
			edata["validateAs"]["customMessages"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"].Add("IsRequired");
			edata["validateAs"]["basicValidate"].Add("DenyDuplicated");
			edata["validateAs"]["customMessages"]["DenyDuplicated"] = new XVar("message", "YA EXITE EL DEPARTAMENTO %value% ", "messageType", "Text");
			edata["denyDuplicates"] = true;
			fdata["EditFormats"]["edit"] = edata;
			fdata["isSeparate"] = false;
			fdata["defaultSearchOption"] = "Contains";
			fdata["searchOptionsList"] = SettingsMap.GetArray();
			fdata["searchOptionsList"].Add("Contains");
			fdata["filterTotals"] = 0;
			fdata["filterMultiSelect"] = 0;
			fdata["filterFormat"] = "Values list";
			fdata["showCollapsed"] = false;
			fdata["sortValueType"] = 0;
			fdata["numberOfVisibleItems"] = 10;
			tdataArray["dbo_DEPARTAMENTO"]["departamento"] = fdata;
			tdataArray["dbo_DEPARTAMENTO"][".searchableFields"].Add("departamento");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 3;
			fdata["strName"] = "limite_permisos";
			fdata["GoodName"] = "limite_permisos";
			fdata["ownerTable"] = "dbo.DEPARTAMENTO";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_DEPARTAMENTO","limite_permisos");
			fdata["FieldType"] = 3;
			fdata["strField"] = "limite_permisos";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "limite_permisos";
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
			fdata["searchOptionsList"] = SettingsMap.GetArray();
			fdata["searchOptionsList"].Add("Contains");
			fdata["filterTotals"] = 0;
			fdata["filterMultiSelect"] = 0;
			fdata["filterFormat"] = "Values list";
			fdata["showCollapsed"] = false;
			fdata["sortValueType"] = 0;
			fdata["numberOfVisibleItems"] = 10;
			tdataArray["dbo_DEPARTAMENTO"]["limite_permisos"] = fdata;
			tdataArray["dbo_DEPARTAMENTO"][".searchableFields"].Add("limite_permisos");
			GlobalVars.tables_data["dbo.DEPARTAMENTO"] = tdataArray["dbo_DEPARTAMENTO"];
			GlobalVars.field_labels["dbo_DEPARTAMENTO"] = fieldLabelsArray["dbo_DEPARTAMENTO"];
			GlobalVars.fieldToolTips["dbo_DEPARTAMENTO"] = fieldToolTipsArray["dbo_DEPARTAMENTO"];
			GlobalVars.placeHolders["dbo_DEPARTAMENTO"] = placeHoldersArray["dbo_DEPARTAMENTO"];
			GlobalVars.page_titles["dbo_DEPARTAMENTO"] = pageTitlesArray["dbo_DEPARTAMENTO"];
			GlobalVars.detailsTablesData["dbo.DEPARTAMENTO"] = SettingsMap.GetArray();


			dIndex = 0;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "dbo.EMPLEADO";
			detailsParam["dOriginalTable"] = "dbo.EMPLEADO";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "dbo_EMPLEADO";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("dbo_EMPLEADO"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.DEPARTAMENTO"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["dbo.DEPARTAMENTO"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.DEPARTAMENTO"][dIndex]["masterKeys"].Add("id_departamento");
			GlobalVars.detailsTablesData["dbo.DEPARTAMENTO"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.DEPARTAMENTO"][dIndex]["detailKeys"].Add("id_departamento");


			dIndex = 1;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "dbo.PERMISOSGRUPOS";
			detailsParam["dOriginalTable"] = "dbo.PERMISOSGRUPOS";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "dbo_PERMISOSGRUPOS";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("dbo_PERMISOSGRUPOS"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.DEPARTAMENTO"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["dbo.DEPARTAMENTO"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.DEPARTAMENTO"][dIndex]["masterKeys"].Add("id_departamento");
			GlobalVars.detailsTablesData["dbo.DEPARTAMENTO"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.DEPARTAMENTO"][dIndex]["detailKeys"].Add("id_departamento");


			dIndex = 2;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "Saldo_Horas_Empleado";
			detailsParam["dOriginalTable"] = "dbo.EMPLEADO";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "Saldo_Horas_Empleado";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("Saldo_Horas_Empleado"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.DEPARTAMENTO"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["dbo.DEPARTAMENTO"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.DEPARTAMENTO"][dIndex]["masterKeys"].Add("id_departamento");
			GlobalVars.detailsTablesData["dbo.DEPARTAMENTO"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.DEPARTAMENTO"][dIndex]["detailKeys"].Add("id_departamento");


			dIndex = 3;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "dbo.GRUPOS";
			detailsParam["dOriginalTable"] = "dbo.GRUPOS";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "dbo_GRUPOS";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("dbo_GRUPOS"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.DEPARTAMENTO"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["dbo.DEPARTAMENTO"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.DEPARTAMENTO"][dIndex]["masterKeys"].Add("id_departamento");
			GlobalVars.detailsTablesData["dbo.DEPARTAMENTO"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.DEPARTAMENTO"][dIndex]["detailKeys"].Add("id_departamento");
			GlobalVars.masterTablesData["dbo.DEPARTAMENTO"] = SettingsMap.GetArray();

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "id_departamento,  	departamento,  	limite_permisos";
protoArray["0"]["m_strFrom"] = "FROM dbo.DEPARTAMENTO";
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
obj = new SQLField(new XVar("m_strName", "id_departamento", "m_strTable", "dbo.DEPARTAMENTO", "m_srcTableName", "dbo.DEPARTAMENTO"));

protoArray["6"]["m_sql"] = "id_departamento";
protoArray["6"]["m_srcTableName"] = "dbo.DEPARTAMENTO";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "departamento", "m_strTable", "dbo.DEPARTAMENTO", "m_srcTableName", "dbo.DEPARTAMENTO"));

protoArray["8"]["m_sql"] = "departamento";
protoArray["8"]["m_srcTableName"] = "dbo.DEPARTAMENTO";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["10"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "limite_permisos", "m_strTable", "dbo.DEPARTAMENTO", "m_srcTableName", "dbo.DEPARTAMENTO"));

protoArray["10"]["m_sql"] = "limite_permisos";
protoArray["10"]["m_srcTableName"] = "dbo.DEPARTAMENTO";
protoArray["10"]["m_expr"] = obj;
protoArray["10"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["10"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["12"] = SettingsMap.GetArray();
protoArray["12"]["m_link"] = "SQLL_MAIN";
protoArray["13"] = SettingsMap.GetArray();
protoArray["13"]["m_strName"] = "dbo.DEPARTAMENTO";
protoArray["13"]["m_srcTableName"] = "dbo.DEPARTAMENTO";
protoArray["13"]["m_columns"] = SettingsMap.GetArray();
protoArray["13"]["m_columns"].Add("id_departamento");
protoArray["13"]["m_columns"].Add("departamento");
protoArray["13"]["m_columns"].Add("limite_permisos");
obj = new SQLTable(protoArray["13"]);

protoArray["12"]["m_table"] = obj;
protoArray["12"]["m_sql"] = "dbo.DEPARTAMENTO";
protoArray["12"]["m_alias"] = "";
protoArray["12"]["m_srcTableName"] = "dbo.DEPARTAMENTO";
protoArray["14"] = SettingsMap.GetArray();
protoArray["14"]["m_sql"] = "";
protoArray["14"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLNonParsed(new XVar("m_sql", ""));

protoArray["14"]["m_column"] = obj;
protoArray["14"]["m_contained"] = SettingsMap.GetArray();
protoArray["14"]["m_strCase"] = "";
protoArray["14"]["m_havingmode"] = false;
protoArray["14"]["m_inBrackets"] = false;
protoArray["14"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["14"]);

protoArray["12"]["m_joinon"] = obj;
obj = new SQLFromListItem(protoArray["12"]);

protoArray["0"]["m_fromlist"].Add(obj);
protoArray["0"]["m_groupby"] = SettingsMap.GetArray();
protoArray["0"]["m_orderby"] = SettingsMap.GetArray();
protoArray["0"]["m_srcTableName"] = "dbo.DEPARTAMENTO";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["dbo_DEPARTAMENTO"] = obj;

				
		
			tdataArray["dbo_DEPARTAMENTO"][".sqlquery"] = queryData_Array["dbo_DEPARTAMENTO"];
			GlobalVars.tableEvents["dbo.DEPARTAMENTO"] = new eventsBase();
			tdataArray["dbo_DEPARTAMENTO"][".hasEvents"] = false;
			GlobalVars.tables_data["dbo_DEPARTAMENTO"] = tdataArray["dbo_DEPARTAMENTO"];
		}
	}

}
