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
	public static partial class Settings_dbo_PERMISOSGRUPOS
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), popupPagesLayoutNames = SettingsMap.GetArray(), query = null, queryData_Array = new XVar(), reportGroupFields = SettingsMap.GetArray(), rgroupField = SettingsMap.GetArray(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["dbo_PERMISOSGRUPOS"] = SettingsMap.GetArray();
			tdataArray["dbo_PERMISOSGRUPOS"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["dbo_PERMISOSGRUPOS"][".truncateText"] = true;
			tdataArray["dbo_PERMISOSGRUPOS"][".NumberOfChars"] = 80;
			tdataArray["dbo_PERMISOSGRUPOS"][".ShortName"] = "dbo_PERMISOSGRUPOS";
			tdataArray["dbo_PERMISOSGRUPOS"][".OwnerID"] = "";
			tdataArray["dbo_PERMISOSGRUPOS"][".OriginalTable"] = "dbo.PERMISOSGRUPOS";
			GlobalVars.defaultPages = MVCFunctions.my_json_decode(new XVar("{\"export\":\"export\",\"list\":\"list\",\"search\":\"search\"}"));
			tdataArray["dbo_PERMISOSGRUPOS"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"export\":[\"export\"],\"list\":[\"list\",\"list1\",\"list2\"],\"search\":[\"search\"]}")));
			tdataArray["dbo_PERMISOSGRUPOS"][".defaultPages"] = GlobalVars.defaultPages;
			fieldLabelsArray["dbo_PERMISOSGRUPOS"] = SettingsMap.GetArray();
			fieldToolTipsArray["dbo_PERMISOSGRUPOS"] = SettingsMap.GetArray();
			pageTitlesArray["dbo_PERMISOSGRUPOS"] = SettingsMap.GetArray();
			placeHoldersArray["dbo_PERMISOSGRUPOS"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "Spanish")
			{
				fieldLabelsArray["dbo_PERMISOSGRUPOS"]["Spanish"] = SettingsMap.GetArray();
				fieldToolTipsArray["dbo_PERMISOSGRUPOS"]["Spanish"] = SettingsMap.GetArray();
				placeHoldersArray["dbo_PERMISOSGRUPOS"]["Spanish"] = SettingsMap.GetArray();
				pageTitlesArray["dbo_PERMISOSGRUPOS"]["Spanish"] = SettingsMap.GetArray();
				fieldLabelsArray["dbo_PERMISOSGRUPOS"]["Spanish"]["id_departamento"] = "Departamento";
				fieldToolTipsArray["dbo_PERMISOSGRUPOS"]["Spanish"]["id_departamento"] = "";
				placeHoldersArray["dbo_PERMISOSGRUPOS"]["Spanish"]["id_departamento"] = "";
				fieldLabelsArray["dbo_PERMISOSGRUPOS"]["Spanish"]["fecha_permisos"] = "Fecha Permisos";
				fieldToolTipsArray["dbo_PERMISOSGRUPOS"]["Spanish"]["fecha_permisos"] = "";
				placeHoldersArray["dbo_PERMISOSGRUPOS"]["Spanish"]["fecha_permisos"] = "";
				fieldLabelsArray["dbo_PERMISOSGRUPOS"]["Spanish"]["id_grupo"] = "Id Grupo";
				fieldToolTipsArray["dbo_PERMISOSGRUPOS"]["Spanish"]["id_grupo"] = "";
				placeHoldersArray["dbo_PERMISOSGRUPOS"]["Spanish"]["id_grupo"] = "";
				fieldLabelsArray["dbo_PERMISOSGRUPOS"]["Spanish"]["id_permisos"] = "Id Permisos";
				fieldToolTipsArray["dbo_PERMISOSGRUPOS"]["Spanish"]["id_permisos"] = "";
				placeHoldersArray["dbo_PERMISOSGRUPOS"]["Spanish"]["id_permisos"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["dbo_PERMISOSGRUPOS"]["Spanish"])))
				{
					tdataArray["dbo_PERMISOSGRUPOS"][".isUseToolTips"] = true;
				}
			}
			tdataArray["dbo_PERMISOSGRUPOS"][".NCSearch"] = true;
			tdataArray["dbo_PERMISOSGRUPOS"][".shortTableName"] = "dbo_PERMISOSGRUPOS";
			tdataArray["dbo_PERMISOSGRUPOS"][".nSecOptions"] = 0;
			tdataArray["dbo_PERMISOSGRUPOS"][".mainTableOwnerID"] = "";
			tdataArray["dbo_PERMISOSGRUPOS"][".entityType"] = 0;
			tdataArray["dbo_PERMISOSGRUPOS"][".strOriginalTableName"] = "dbo.PERMISOSGRUPOS";
			tdataArray["dbo_PERMISOSGRUPOS"][".showAddInPopup"] = false;
			tdataArray["dbo_PERMISOSGRUPOS"][".showEditInPopup"] = false;
			tdataArray["dbo_PERMISOSGRUPOS"][".showViewInPopup"] = false;
			popupPagesLayoutNames = SettingsMap.GetArray();
			tdataArray["dbo_PERMISOSGRUPOS"][".popupPagesLayoutNames"] = popupPagesLayoutNames;
			tdataArray["dbo_PERMISOSGRUPOS"][".listAjax"] = false;
			tdataArray["dbo_PERMISOSGRUPOS"][".listAjax"] = false;
			tdataArray["dbo_PERMISOSGRUPOS"][".audit"] = true;
			tdataArray["dbo_PERMISOSGRUPOS"][".locking"] = false;
			GlobalVars.pages = tdataArray["dbo_PERMISOSGRUPOS"][".pages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["dbo_PERMISOSGRUPOS"][".edit"] = true;
				tdataArray["dbo_PERMISOSGRUPOS"][".afterEditAction"] = 1;
				tdataArray["dbo_PERMISOSGRUPOS"][".closePopupAfterEdit"] = 1;
				tdataArray["dbo_PERMISOSGRUPOS"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["dbo_PERMISOSGRUPOS"][".add"] = true;
				tdataArray["dbo_PERMISOSGRUPOS"][".afterAddAction"] = 1;
				tdataArray["dbo_PERMISOSGRUPOS"][".closePopupAfterAdd"] = 1;
				tdataArray["dbo_PERMISOSGRUPOS"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["dbo_PERMISOSGRUPOS"][".list"] = true;
			}
			tdataArray["dbo_PERMISOSGRUPOS"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["dbo_PERMISOSGRUPOS"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["dbo_PERMISOSGRUPOS"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["dbo_PERMISOSGRUPOS"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["dbo_PERMISOSGRUPOS"][".printFriendly"] = true;
			}
			tdataArray["dbo_PERMISOSGRUPOS"][".showSimpleSearchOptions"] = true;
			tdataArray["dbo_PERMISOSGRUPOS"][".allowShowHideFields"] = true;
			tdataArray["dbo_PERMISOSGRUPOS"][".allowFieldsReordering"] = true;
			tdataArray["dbo_PERMISOSGRUPOS"][".isUseAjaxSuggest"] = true;
			tdataArray["dbo_PERMISOSGRUPOS"][".rowHighlite"] = true;


			tdataArray["dbo_PERMISOSGRUPOS"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["dbo_PERMISOSGRUPOS"][".buttonsAdded"] = false;
			tdataArray["dbo_PERMISOSGRUPOS"][".addPageEvents"] = false;
			tdataArray["dbo_PERMISOSGRUPOS"][".isUseTimeForSearch"] = false;
			tdataArray["dbo_PERMISOSGRUPOS"][".badgeColor"] = "B22222";
			tdataArray["dbo_PERMISOSGRUPOS"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["dbo_PERMISOSGRUPOS"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["dbo_PERMISOSGRUPOS"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["dbo_PERMISOSGRUPOS"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["dbo_PERMISOSGRUPOS"][".googleLikeFields"].Add("id_departamento");
			tdataArray["dbo_PERMISOSGRUPOS"][".googleLikeFields"].Add("fecha_permisos");
			tdataArray["dbo_PERMISOSGRUPOS"][".googleLikeFields"].Add("id_grupo");
			tdataArray["dbo_PERMISOSGRUPOS"][".googleLikeFields"].Add("id_permisos");
			tdataArray["dbo_PERMISOSGRUPOS"][".tableType"] = "list";
			tdataArray["dbo_PERMISOSGRUPOS"][".printerPageOrientation"] = 0;
			tdataArray["dbo_PERMISOSGRUPOS"][".nPrinterPageScale"] = 100;
			tdataArray["dbo_PERMISOSGRUPOS"][".nPrinterSplitRecords"] = 40;
			tdataArray["dbo_PERMISOSGRUPOS"][".nPrinterPDFSplitRecords"] = 40;
			tdataArray["dbo_PERMISOSGRUPOS"][".geocodingEnabled"] = false;
			tdataArray["dbo_PERMISOSGRUPOS"][".pageSize"] = 20;
			tdataArray["dbo_PERMISOSGRUPOS"][".warnLeavingPages"] = true;
			tstrOrderBy = "";
			if(MVCFunctions.strlen(tstrOrderBy) && MVCFunctions.strtolower(MVCFunctions.substr(tstrOrderBy, new XVar(0), new XVar(8))) != "order by")
			{
				tstrOrderBy = MVCFunctions.Concat("order by ", tstrOrderBy);
			}
			tdataArray["dbo_PERMISOSGRUPOS"][".strOrderBy"] = tstrOrderBy;
			tdataArray["dbo_PERMISOSGRUPOS"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["dbo_PERMISOSGRUPOS"][".sqlHead"] = "SELECT id_departamento,  	fecha_permisos,  	id_grupo,  	id_permisos";
			tdataArray["dbo_PERMISOSGRUPOS"][".sqlFrom"] = "FROM dbo.PERMISOSGRUPOS";
			tdataArray["dbo_PERMISOSGRUPOS"][".sqlWhereExpr"] = "";
			tdataArray["dbo_PERMISOSGRUPOS"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["dbo_PERMISOSGRUPOS"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["dbo_PERMISOSGRUPOS"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["dbo_PERMISOSGRUPOS"][".highlightSearchResults"] = true;
			tableKeysArray["dbo_PERMISOSGRUPOS"] = SettingsMap.GetArray();
			tdataArray["dbo_PERMISOSGRUPOS"][".Keys"] = tableKeysArray["dbo_PERMISOSGRUPOS"];
			tdataArray["dbo_PERMISOSGRUPOS"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "id_departamento";
			fdata["GoodName"] = "id_departamento";
			fdata["ownerTable"] = "dbo.PERMISOSGRUPOS";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_PERMISOSGRUPOS","id_departamento");
			fdata["FieldType"] = 3;
			fdata["strField"] = "id_departamento";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "id_departamento";
			fdata["UploadFolder"] = "files";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "");
			vdata["NeedEncode"] = true;
			fdata["ViewFormats"]["view"] = vdata;
			fdata["EditFormats"] = SettingsMap.GetArray();
			edata = new XVar("EditFormat", "Lookup wizard");
			edata["LookupType"] = 2;
			edata["LookupTable"] = "dbo.DEPARTAMENTO";
			edata["autoCompleteFieldsOnEdit"] = 0;
			edata["autoCompleteFields"] = SettingsMap.GetArray();
			edata["LCType"] = 0;
			edata["LinkField"] = "id_departamento";
			edata["LinkFieldType"] = 3;
			edata["DisplayField"] = "departamento";
			edata["LookupOrderBy"] = "";
			edata["SelectSize"] = 1;
			edata["IsRequired"] = true;
			edata["acceptFileTypes"] = ".+$";
			edata["maxNumberOfFiles"] = 1;
			edata["controlWidth"] = 200;
			edata["validateAs"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"] = SettingsMap.GetArray();
			edata["validateAs"]["customMessages"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"].Add("IsRequired");
			fdata["EditFormats"]["edit"] = edata;
			fdata["isSeparate"] = false;
			fdata["defaultSearchOption"] = "Equals";
			fdata["searchOptionsList"] = new XVar(0, "Contains", 1, "Equals", 2, "Starts with", 3, "More than", 4, "Less than", 5, "Between", 6, "Empty", 7, Constants.NOT_EMPTY);
			fdata["filterTotals"] = 0;
			fdata["filterMultiSelect"] = 0;
			fdata["filterFormat"] = "Values list";
			fdata["showCollapsed"] = false;
			fdata["sortValueType"] = 0;
			fdata["numberOfVisibleItems"] = 10;
			tdataArray["dbo_PERMISOSGRUPOS"]["id_departamento"] = fdata;
			tdataArray["dbo_PERMISOSGRUPOS"][".searchableFields"].Add("id_departamento");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "fecha_permisos";
			fdata["GoodName"] = "fecha_permisos";
			fdata["ownerTable"] = "dbo.PERMISOSGRUPOS";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_PERMISOSGRUPOS","fecha_permisos");
			fdata["FieldType"] = 7;
			fdata["strField"] = "fecha_permisos";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "fecha_permisos";
			fdata["UploadFolder"] = "files";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "Short Date");
			vdata["NeedEncode"] = true;
			fdata["ViewFormats"]["view"] = vdata;
			fdata["EditFormats"] = SettingsMap.GetArray();
			edata = new XVar("EditFormat", "Date");
			edata["acceptFileTypes"] = ".+$";
			edata["maxNumberOfFiles"] = 1;
			edata["DateEditType"] = 13;
			edata["InitialYearFactor"] = 100;
			edata["LastYearFactor"] = 10;
			edata["controlWidth"] = 200;
			edata["validateAs"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"] = SettingsMap.GetArray();
			edata["validateAs"]["customMessages"] = SettingsMap.GetArray();
			fdata["EditFormats"]["edit"] = edata;
			fdata["isSeparate"] = false;
			fdata["defaultSearchOption"] = "Equals";
			fdata["searchOptionsList"] = new XVar(0, "Equals", 1, "More than", 2, "Less than", 3, "Between", 4, Constants.EMPTY_SEARCH, 5, Constants.NOT_EMPTY);
			fdata["filterTotals"] = 0;
			fdata["filterMultiSelect"] = 0;
			fdata["filterFormat"] = "Values list";
			fdata["showCollapsed"] = false;
			fdata["sortValueType"] = 0;
			fdata["numberOfVisibleItems"] = 10;
			tdataArray["dbo_PERMISOSGRUPOS"]["fecha_permisos"] = fdata;
			tdataArray["dbo_PERMISOSGRUPOS"][".searchableFields"].Add("fecha_permisos");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 3;
			fdata["strName"] = "id_grupo";
			fdata["GoodName"] = "id_grupo";
			fdata["ownerTable"] = "dbo.PERMISOSGRUPOS";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_PERMISOSGRUPOS","id_grupo");
			fdata["FieldType"] = 3;
			fdata["strField"] = "id_grupo";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "id_grupo";
			fdata["UploadFolder"] = "files";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "");
			vdata["NeedEncode"] = true;
			fdata["ViewFormats"]["view"] = vdata;
			fdata["EditFormats"] = SettingsMap.GetArray();
			edata = new XVar("EditFormat", "Lookup wizard");
			edata["LookupType"] = 2;
			edata["LookupTable"] = "dbo.GRUPOS";
			edata["autoCompleteFieldsOnEdit"] = 0;
			edata["autoCompleteFields"] = SettingsMap.GetArray();
			edata["LCType"] = 0;
			edata["LinkField"] = "id_grupo";
			edata["LinkFieldType"] = 0;
			edata["DisplayField"] = "grupo";
			edata["LookupOrderBy"] = "";
			edata["SelectSize"] = 1;
			edata["acceptFileTypes"] = ".+$";
			edata["maxNumberOfFiles"] = 1;
			edata["controlWidth"] = 200;
			edata["validateAs"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"] = SettingsMap.GetArray();
			edata["validateAs"]["customMessages"] = SettingsMap.GetArray();
			fdata["EditFormats"]["edit"] = edata;
			fdata["isSeparate"] = false;
			fdata["defaultSearchOption"] = "Equals";
			fdata["searchOptionsList"] = new XVar(0, "Contains", 1, "Equals", 2, "Starts with", 3, "More than", 4, "Less than", 5, "Between", 6, "Empty", 7, Constants.NOT_EMPTY);
			fdata["filterTotals"] = 0;
			fdata["filterMultiSelect"] = 0;
			fdata["filterFormat"] = "Values list";
			fdata["showCollapsed"] = false;
			fdata["sortValueType"] = 0;
			fdata["numberOfVisibleItems"] = 10;
			tdataArray["dbo_PERMISOSGRUPOS"]["id_grupo"] = fdata;
			tdataArray["dbo_PERMISOSGRUPOS"][".searchableFields"].Add("id_grupo");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 4;
			fdata["strName"] = "id_permisos";
			fdata["GoodName"] = "id_permisos";
			fdata["ownerTable"] = "dbo.PERMISOSGRUPOS";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_PERMISOSGRUPOS","id_permisos");
			fdata["FieldType"] = 3;
			fdata["strField"] = "id_permisos";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "id_permisos";
			fdata["UploadFolder"] = "files";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "");
			vdata["NeedEncode"] = true;
			fdata["ViewFormats"]["view"] = vdata;
			fdata["EditFormats"] = SettingsMap.GetArray();
			edata = new XVar("EditFormat", "Text field");
			edata["acceptFileTypes"] = ".+$";
			edata["maxNumberOfFiles"] = 1;
			edata["HTML5InuptType"] = "text";
			edata["EditParams"] = "";
			edata["controlWidth"] = 200;
			edata["validateAs"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"] = SettingsMap.GetArray();
			edata["validateAs"]["customMessages"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"].Add(CommonFunctions.getJsValidatorName(new XVar("Number")));
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
			tdataArray["dbo_PERMISOSGRUPOS"]["id_permisos"] = fdata;
			tdataArray["dbo_PERMISOSGRUPOS"][".searchableFields"].Add("id_permisos");
			GlobalVars.tables_data["dbo.PERMISOSGRUPOS"] = tdataArray["dbo_PERMISOSGRUPOS"];
			GlobalVars.field_labels["dbo_PERMISOSGRUPOS"] = fieldLabelsArray["dbo_PERMISOSGRUPOS"];
			GlobalVars.fieldToolTips["dbo_PERMISOSGRUPOS"] = fieldToolTipsArray["dbo_PERMISOSGRUPOS"];
			GlobalVars.placeHolders["dbo_PERMISOSGRUPOS"] = placeHoldersArray["dbo_PERMISOSGRUPOS"];
			GlobalVars.page_titles["dbo_PERMISOSGRUPOS"] = pageTitlesArray["dbo_PERMISOSGRUPOS"];
			GlobalVars.detailsTablesData["dbo.PERMISOSGRUPOS"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.PERMISOSGRUPOS"] = SettingsMap.GetArray();


			strOriginalDetailsTable = "dbo.DEPARTAMENTO";
			masterParams = SettingsMap.GetArray();
			masterParams["mDataSourceTable"] = "dbo.DEPARTAMENTO";
			masterParams["mOriginalTable"] = strOriginalDetailsTable;
			masterParams["mShortTable"] = "dbo_DEPARTAMENTO";
			masterParams["masterKeys"] = SettingsMap.GetArray();
			masterParams["detailKeys"] = SettingsMap.GetArray();
			masterParams["type"] = Constants.PAGE_LIST;
			GlobalVars.masterTablesData["dbo.PERMISOSGRUPOS"][0] = masterParams;
			GlobalVars.masterTablesData["dbo.PERMISOSGRUPOS"][0]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.PERMISOSGRUPOS"][0]["masterKeys"].Add("id_departamento");
			GlobalVars.masterTablesData["dbo.PERMISOSGRUPOS"][0]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.PERMISOSGRUPOS"][0]["detailKeys"].Add("id_departamento");

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "id_departamento,  	fecha_permisos,  	id_grupo,  	id_permisos";
protoArray["0"]["m_strFrom"] = "FROM dbo.PERMISOSGRUPOS";
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
obj = new SQLField(new XVar("m_strName", "id_departamento", "m_strTable", "dbo.PERMISOSGRUPOS", "m_srcTableName", "dbo.PERMISOSGRUPOS"));

protoArray["6"]["m_sql"] = "id_departamento";
protoArray["6"]["m_srcTableName"] = "dbo.PERMISOSGRUPOS";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "fecha_permisos", "m_strTable", "dbo.PERMISOSGRUPOS", "m_srcTableName", "dbo.PERMISOSGRUPOS"));

protoArray["8"]["m_sql"] = "fecha_permisos";
protoArray["8"]["m_srcTableName"] = "dbo.PERMISOSGRUPOS";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["10"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "id_grupo", "m_strTable", "dbo.PERMISOSGRUPOS", "m_srcTableName", "dbo.PERMISOSGRUPOS"));

protoArray["10"]["m_sql"] = "id_grupo";
protoArray["10"]["m_srcTableName"] = "dbo.PERMISOSGRUPOS";
protoArray["10"]["m_expr"] = obj;
protoArray["10"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["10"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["12"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "id_permisos", "m_strTable", "dbo.PERMISOSGRUPOS", "m_srcTableName", "dbo.PERMISOSGRUPOS"));

protoArray["12"]["m_sql"] = "id_permisos";
protoArray["12"]["m_srcTableName"] = "dbo.PERMISOSGRUPOS";
protoArray["12"]["m_expr"] = obj;
protoArray["12"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["12"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["14"] = SettingsMap.GetArray();
protoArray["14"]["m_link"] = "SQLL_MAIN";
protoArray["15"] = SettingsMap.GetArray();
protoArray["15"]["m_strName"] = "dbo.PERMISOSGRUPOS";
protoArray["15"]["m_srcTableName"] = "dbo.PERMISOSGRUPOS";
protoArray["15"]["m_columns"] = SettingsMap.GetArray();
protoArray["15"]["m_columns"].Add("id_departamento");
protoArray["15"]["m_columns"].Add("fecha_permisos");
protoArray["15"]["m_columns"].Add("id_grupo");
protoArray["15"]["m_columns"].Add("id_permisos");
obj = new SQLTable(protoArray["15"]);

protoArray["14"]["m_table"] = obj;
protoArray["14"]["m_sql"] = "dbo.PERMISOSGRUPOS";
protoArray["14"]["m_alias"] = "";
protoArray["14"]["m_srcTableName"] = "dbo.PERMISOSGRUPOS";
protoArray["16"] = SettingsMap.GetArray();
protoArray["16"]["m_sql"] = "";
protoArray["16"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLNonParsed(new XVar("m_sql", ""));

protoArray["16"]["m_column"] = obj;
protoArray["16"]["m_contained"] = SettingsMap.GetArray();
protoArray["16"]["m_strCase"] = "";
protoArray["16"]["m_havingmode"] = false;
protoArray["16"]["m_inBrackets"] = false;
protoArray["16"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["16"]);

protoArray["14"]["m_joinon"] = obj;
obj = new SQLFromListItem(protoArray["14"]);

protoArray["0"]["m_fromlist"].Add(obj);
protoArray["0"]["m_groupby"] = SettingsMap.GetArray();
protoArray["0"]["m_orderby"] = SettingsMap.GetArray();
protoArray["0"]["m_srcTableName"] = "dbo.PERMISOSGRUPOS";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["dbo_PERMISOSGRUPOS"] = obj;

				
		
			tdataArray["dbo_PERMISOSGRUPOS"][".sqlquery"] = queryData_Array["dbo_PERMISOSGRUPOS"];
			GlobalVars.tableEvents["dbo.PERMISOSGRUPOS"] = new eventsBase();
			tdataArray["dbo_PERMISOSGRUPOS"][".hasEvents"] = false;
			GlobalVars.tables_data["dbo_PERMISOSGRUPOS"] = tdataArray["dbo_PERMISOSGRUPOS"];
		}
	}

}
