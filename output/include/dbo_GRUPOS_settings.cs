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
	public static partial class Settings_dbo_GRUPOS
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), popupPagesLayoutNames = SettingsMap.GetArray(), query = null, queryData_Array = new XVar(), reportGroupFields = SettingsMap.GetArray(), rgroupField = SettingsMap.GetArray(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["dbo_GRUPOS"] = SettingsMap.GetArray();
			tdataArray["dbo_GRUPOS"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["dbo_GRUPOS"][".truncateText"] = true;
			tdataArray["dbo_GRUPOS"][".NumberOfChars"] = 80;
			tdataArray["dbo_GRUPOS"][".ShortName"] = "dbo_GRUPOS";
			tdataArray["dbo_GRUPOS"][".OwnerID"] = "";
			tdataArray["dbo_GRUPOS"][".OriginalTable"] = "dbo.GRUPOS";
			GlobalVars.defaultPages = MVCFunctions.my_json_decode(new XVar("{\"add\":\"add\",\"edit\":\"edit\",\"export\":\"export\",\"list\":\"list\",\"search\":\"search\"}"));
			tdataArray["dbo_GRUPOS"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"add\":[\"add\"],\"edit\":[\"edit\"],\"export\":[\"export\"],\"list\":[\"list\"],\"search\":[\"search\"]}")));
			tdataArray["dbo_GRUPOS"][".defaultPages"] = GlobalVars.defaultPages;
			fieldLabelsArray["dbo_GRUPOS"] = SettingsMap.GetArray();
			fieldToolTipsArray["dbo_GRUPOS"] = SettingsMap.GetArray();
			pageTitlesArray["dbo_GRUPOS"] = SettingsMap.GetArray();
			placeHoldersArray["dbo_GRUPOS"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "Spanish")
			{
				fieldLabelsArray["dbo_GRUPOS"]["Spanish"] = SettingsMap.GetArray();
				fieldToolTipsArray["dbo_GRUPOS"]["Spanish"] = SettingsMap.GetArray();
				placeHoldersArray["dbo_GRUPOS"]["Spanish"] = SettingsMap.GetArray();
				pageTitlesArray["dbo_GRUPOS"]["Spanish"] = SettingsMap.GetArray();
				fieldLabelsArray["dbo_GRUPOS"]["Spanish"]["id_grupo"] = "ID";
				fieldToolTipsArray["dbo_GRUPOS"]["Spanish"]["id_grupo"] = "";
				placeHoldersArray["dbo_GRUPOS"]["Spanish"]["id_grupo"] = "";
				fieldLabelsArray["dbo_GRUPOS"]["Spanish"]["grupo"] = "Grupo";
				fieldToolTipsArray["dbo_GRUPOS"]["Spanish"]["grupo"] = "";
				placeHoldersArray["dbo_GRUPOS"]["Spanish"]["grupo"] = "";
				fieldLabelsArray["dbo_GRUPOS"]["Spanish"]["id_departamento"] = "Departamento";
				fieldToolTipsArray["dbo_GRUPOS"]["Spanish"]["id_departamento"] = "";
				placeHoldersArray["dbo_GRUPOS"]["Spanish"]["id_departamento"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["dbo_GRUPOS"]["Spanish"])))
				{
					tdataArray["dbo_GRUPOS"][".isUseToolTips"] = true;
				}
			}
			tdataArray["dbo_GRUPOS"][".NCSearch"] = true;
			tdataArray["dbo_GRUPOS"][".shortTableName"] = "dbo_GRUPOS";
			tdataArray["dbo_GRUPOS"][".nSecOptions"] = 0;
			tdataArray["dbo_GRUPOS"][".mainTableOwnerID"] = "";
			tdataArray["dbo_GRUPOS"][".entityType"] = 0;
			tdataArray["dbo_GRUPOS"][".strOriginalTableName"] = "dbo.GRUPOS";
			tdataArray["dbo_GRUPOS"][".showAddInPopup"] = false;
			tdataArray["dbo_GRUPOS"][".showEditInPopup"] = false;
			tdataArray["dbo_GRUPOS"][".showViewInPopup"] = false;
			popupPagesLayoutNames = SettingsMap.GetArray();
			tdataArray["dbo_GRUPOS"][".popupPagesLayoutNames"] = popupPagesLayoutNames;
			tdataArray["dbo_GRUPOS"][".listAjax"] = false;
			tdataArray["dbo_GRUPOS"][".listAjax"] = false;
			tdataArray["dbo_GRUPOS"][".audit"] = false;
			tdataArray["dbo_GRUPOS"][".locking"] = false;
			GlobalVars.pages = tdataArray["dbo_GRUPOS"][".pages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["dbo_GRUPOS"][".edit"] = true;
				tdataArray["dbo_GRUPOS"][".afterEditAction"] = 1;
				tdataArray["dbo_GRUPOS"][".closePopupAfterEdit"] = 1;
				tdataArray["dbo_GRUPOS"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["dbo_GRUPOS"][".add"] = true;
				tdataArray["dbo_GRUPOS"][".afterAddAction"] = 1;
				tdataArray["dbo_GRUPOS"][".closePopupAfterAdd"] = 1;
				tdataArray["dbo_GRUPOS"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["dbo_GRUPOS"][".list"] = true;
			}
			tdataArray["dbo_GRUPOS"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["dbo_GRUPOS"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["dbo_GRUPOS"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["dbo_GRUPOS"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["dbo_GRUPOS"][".printFriendly"] = true;
			}
			tdataArray["dbo_GRUPOS"][".showSimpleSearchOptions"] = true;
			tdataArray["dbo_GRUPOS"][".allowShowHideFields"] = true;
			tdataArray["dbo_GRUPOS"][".allowFieldsReordering"] = true;
			tdataArray["dbo_GRUPOS"][".isUseAjaxSuggest"] = true;
			tdataArray["dbo_GRUPOS"][".rowHighlite"] = true;


			tdataArray["dbo_GRUPOS"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["dbo_GRUPOS"][".buttonsAdded"] = false;
			tdataArray["dbo_GRUPOS"][".addPageEvents"] = false;
			tdataArray["dbo_GRUPOS"][".isUseTimeForSearch"] = false;
			tdataArray["dbo_GRUPOS"][".badgeColor"] = "6493ea";
			tdataArray["dbo_GRUPOS"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["dbo_GRUPOS"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["dbo_GRUPOS"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["dbo_GRUPOS"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["dbo_GRUPOS"][".googleLikeFields"].Add("id_grupo");
			tdataArray["dbo_GRUPOS"][".googleLikeFields"].Add("id_departamento");
			tdataArray["dbo_GRUPOS"][".googleLikeFields"].Add("grupo");
			tdataArray["dbo_GRUPOS"][".tableType"] = "list";
			tdataArray["dbo_GRUPOS"][".printerPageOrientation"] = 0;
			tdataArray["dbo_GRUPOS"][".nPrinterPageScale"] = 100;
			tdataArray["dbo_GRUPOS"][".nPrinterSplitRecords"] = 40;
			tdataArray["dbo_GRUPOS"][".nPrinterPDFSplitRecords"] = 40;
			tdataArray["dbo_GRUPOS"][".geocodingEnabled"] = false;
			tdataArray["dbo_GRUPOS"][".pageSize"] = 20;
			tdataArray["dbo_GRUPOS"][".warnLeavingPages"] = true;
			tstrOrderBy = "";
			if(MVCFunctions.strlen(tstrOrderBy) && MVCFunctions.strtolower(MVCFunctions.substr(tstrOrderBy, new XVar(0), new XVar(8))) != "order by")
			{
				tstrOrderBy = MVCFunctions.Concat("order by ", tstrOrderBy);
			}
			tdataArray["dbo_GRUPOS"][".strOrderBy"] = tstrOrderBy;
			tdataArray["dbo_GRUPOS"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["dbo_GRUPOS"][".sqlHead"] = "SELECT id_grupo,  	id_departamento,  	grupo";
			tdataArray["dbo_GRUPOS"][".sqlFrom"] = "FROM dbo.GRUPOS";
			tdataArray["dbo_GRUPOS"][".sqlWhereExpr"] = "";
			tdataArray["dbo_GRUPOS"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["dbo_GRUPOS"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["dbo_GRUPOS"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["dbo_GRUPOS"][".highlightSearchResults"] = true;
			tableKeysArray["dbo_GRUPOS"] = SettingsMap.GetArray();
			tableKeysArray["dbo_GRUPOS"].Add("id_grupo");
			tdataArray["dbo_GRUPOS"][".Keys"] = tableKeysArray["dbo_GRUPOS"];
			tdataArray["dbo_GRUPOS"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "id_grupo";
			fdata["GoodName"] = "id_grupo";
			fdata["ownerTable"] = "dbo.GRUPOS";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_GRUPOS","id_grupo");
			fdata["FieldType"] = 3;
			fdata["AutoInc"] = true;
			fdata["strField"] = "id_grupo";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "id_grupo";
			fdata["UploadFolder"] = "files";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "");
			vdata["NeedEncode"] = true;
			fdata["ViewFormats"]["view"] = vdata;
			fdata["EditFormats"] = SettingsMap.GetArray();
			edata = new XVar("EditFormat", "Readonly");
			edata["acceptFileTypes"] = ".+$";
			edata["maxNumberOfFiles"] = 1;
			edata["controlWidth"] = 200;
			edata["validateAs"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"] = SettingsMap.GetArray();
			edata["validateAs"]["customMessages"] = SettingsMap.GetArray();
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
			tdataArray["dbo_GRUPOS"]["id_grupo"] = fdata;
			tdataArray["dbo_GRUPOS"][".searchableFields"].Add("id_grupo");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "id_departamento";
			fdata["GoodName"] = "id_departamento";
			fdata["ownerTable"] = "dbo.GRUPOS";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_GRUPOS","id_departamento");
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
			edata["LinkFieldType"] = 0;
			edata["DisplayField"] = "departamento";
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
			tdataArray["dbo_GRUPOS"]["id_departamento"] = fdata;
			tdataArray["dbo_GRUPOS"][".searchableFields"].Add("id_departamento");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 3;
			fdata["strName"] = "grupo";
			fdata["GoodName"] = "grupo";
			fdata["ownerTable"] = "dbo.GRUPOS";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_GRUPOS","grupo");
			fdata["FieldType"] = 200;
			fdata["strField"] = "grupo";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "grupo";
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
			edata["EditParams"] = MVCFunctions.Concat(edata["EditParams"], " maxlength=255");
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
			tdataArray["dbo_GRUPOS"]["grupo"] = fdata;
			tdataArray["dbo_GRUPOS"][".searchableFields"].Add("grupo");
			GlobalVars.tables_data["dbo.GRUPOS"] = tdataArray["dbo_GRUPOS"];
			GlobalVars.field_labels["dbo_GRUPOS"] = fieldLabelsArray["dbo_GRUPOS"];
			GlobalVars.fieldToolTips["dbo_GRUPOS"] = fieldToolTipsArray["dbo_GRUPOS"];
			GlobalVars.placeHolders["dbo_GRUPOS"] = placeHoldersArray["dbo_GRUPOS"];
			GlobalVars.page_titles["dbo_GRUPOS"] = pageTitlesArray["dbo_GRUPOS"];
			GlobalVars.detailsTablesData["dbo.GRUPOS"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.GRUPOS"] = SettingsMap.GetArray();


			strOriginalDetailsTable = "dbo.DEPARTAMENTO";
			masterParams = SettingsMap.GetArray();
			masterParams["mDataSourceTable"] = "dbo.DEPARTAMENTO";
			masterParams["mOriginalTable"] = strOriginalDetailsTable;
			masterParams["mShortTable"] = "dbo_DEPARTAMENTO";
			masterParams["masterKeys"] = SettingsMap.GetArray();
			masterParams["detailKeys"] = SettingsMap.GetArray();
			masterParams["type"] = Constants.PAGE_LIST;
			GlobalVars.masterTablesData["dbo.GRUPOS"][0] = masterParams;
			GlobalVars.masterTablesData["dbo.GRUPOS"][0]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.GRUPOS"][0]["masterKeys"].Add("id_departamento");
			GlobalVars.masterTablesData["dbo.GRUPOS"][0]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.GRUPOS"][0]["detailKeys"].Add("id_departamento");

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "id_grupo,  	id_departamento,  	grupo";
protoArray["0"]["m_strFrom"] = "FROM dbo.GRUPOS";
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
obj = new SQLField(new XVar("m_strName", "id_grupo", "m_strTable", "dbo.GRUPOS", "m_srcTableName", "dbo.GRUPOS"));

protoArray["6"]["m_sql"] = "id_grupo";
protoArray["6"]["m_srcTableName"] = "dbo.GRUPOS";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "id_departamento", "m_strTable", "dbo.GRUPOS", "m_srcTableName", "dbo.GRUPOS"));

protoArray["8"]["m_sql"] = "id_departamento";
protoArray["8"]["m_srcTableName"] = "dbo.GRUPOS";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["10"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "grupo", "m_strTable", "dbo.GRUPOS", "m_srcTableName", "dbo.GRUPOS"));

protoArray["10"]["m_sql"] = "grupo";
protoArray["10"]["m_srcTableName"] = "dbo.GRUPOS";
protoArray["10"]["m_expr"] = obj;
protoArray["10"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["10"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["12"] = SettingsMap.GetArray();
protoArray["12"]["m_link"] = "SQLL_MAIN";
protoArray["13"] = SettingsMap.GetArray();
protoArray["13"]["m_strName"] = "dbo.GRUPOS";
protoArray["13"]["m_srcTableName"] = "dbo.GRUPOS";
protoArray["13"]["m_columns"] = SettingsMap.GetArray();
protoArray["13"]["m_columns"].Add("id_grupo");
protoArray["13"]["m_columns"].Add("grupo");
protoArray["13"]["m_columns"].Add("id_departamento");
obj = new SQLTable(protoArray["13"]);

protoArray["12"]["m_table"] = obj;
protoArray["12"]["m_sql"] = "dbo.GRUPOS";
protoArray["12"]["m_alias"] = "";
protoArray["12"]["m_srcTableName"] = "dbo.GRUPOS";
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
protoArray["0"]["m_srcTableName"] = "dbo.GRUPOS";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["dbo_GRUPOS"] = obj;

				
		
			tdataArray["dbo_GRUPOS"][".sqlquery"] = queryData_Array["dbo_GRUPOS"];
			GlobalVars.tableEvents["dbo.GRUPOS"] = new eventsBase();
			tdataArray["dbo_GRUPOS"][".hasEvents"] = false;
			GlobalVars.tables_data["dbo_GRUPOS"] = tdataArray["dbo_GRUPOS"];
		}
	}

}
