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
	public static partial class Settings_dbo_Preferencias
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), popupPagesLayoutNames = SettingsMap.GetArray(), query = null, queryData_Array = new XVar(), reportGroupFields = SettingsMap.GetArray(), rgroupField = SettingsMap.GetArray(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["dbo_Preferencias"] = SettingsMap.GetArray();
			tdataArray["dbo_Preferencias"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["dbo_Preferencias"][".truncateText"] = true;
			tdataArray["dbo_Preferencias"][".NumberOfChars"] = 80;
			tdataArray["dbo_Preferencias"][".ShortName"] = "dbo_Preferencias";
			tdataArray["dbo_Preferencias"][".OwnerID"] = "";
			tdataArray["dbo_Preferencias"][".OriginalTable"] = "dbo.Preferencias";
			GlobalVars.defaultPages = MVCFunctions.my_json_decode(new XVar("{\"edit\":\"edit\",\"list\":\"list\",\"search\":\"search\"}"));
			tdataArray["dbo_Preferencias"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"edit\":[\"edit\"],\"list\":[\"list\"],\"search\":[\"search\"]}")));
			tdataArray["dbo_Preferencias"][".defaultPages"] = GlobalVars.defaultPages;
			fieldLabelsArray["dbo_Preferencias"] = SettingsMap.GetArray();
			fieldToolTipsArray["dbo_Preferencias"] = SettingsMap.GetArray();
			pageTitlesArray["dbo_Preferencias"] = SettingsMap.GetArray();
			placeHoldersArray["dbo_Preferencias"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "Spanish")
			{
				fieldLabelsArray["dbo_Preferencias"]["Spanish"] = SettingsMap.GetArray();
				fieldToolTipsArray["dbo_Preferencias"]["Spanish"] = SettingsMap.GetArray();
				placeHoldersArray["dbo_Preferencias"]["Spanish"] = SettingsMap.GetArray();
				pageTitlesArray["dbo_Preferencias"]["Spanish"] = SettingsMap.GetArray();
				fieldLabelsArray["dbo_Preferencias"]["Spanish"]["ID"] = "ID";
				fieldToolTipsArray["dbo_Preferencias"]["Spanish"]["ID"] = "";
				placeHoldersArray["dbo_Preferencias"]["Spanish"]["ID"] = "";
				fieldLabelsArray["dbo_Preferencias"]["Spanish"]["nombre_jefe"] = "Nombre Jefe";
				fieldToolTipsArray["dbo_Preferencias"]["Spanish"]["nombre_jefe"] = "";
				placeHoldersArray["dbo_Preferencias"]["Spanish"]["nombre_jefe"] = "";
				fieldLabelsArray["dbo_Preferencias"]["Spanish"]["division"] = "Division";
				fieldToolTipsArray["dbo_Preferencias"]["Spanish"]["division"] = "";
				placeHoldersArray["dbo_Preferencias"]["Spanish"]["division"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["dbo_Preferencias"]["Spanish"])))
				{
					tdataArray["dbo_Preferencias"][".isUseToolTips"] = true;
				}
			}
			tdataArray["dbo_Preferencias"][".NCSearch"] = true;
			tdataArray["dbo_Preferencias"][".shortTableName"] = "dbo_Preferencias";
			tdataArray["dbo_Preferencias"][".nSecOptions"] = 0;
			tdataArray["dbo_Preferencias"][".mainTableOwnerID"] = "";
			tdataArray["dbo_Preferencias"][".entityType"] = 0;
			tdataArray["dbo_Preferencias"][".strOriginalTableName"] = "dbo.Preferencias";
			tdataArray["dbo_Preferencias"][".showAddInPopup"] = false;
			tdataArray["dbo_Preferencias"][".showEditInPopup"] = false;
			tdataArray["dbo_Preferencias"][".showViewInPopup"] = false;
			popupPagesLayoutNames = SettingsMap.GetArray();
			tdataArray["dbo_Preferencias"][".popupPagesLayoutNames"] = popupPagesLayoutNames;
			tdataArray["dbo_Preferencias"][".listAjax"] = false;
			tdataArray["dbo_Preferencias"][".listAjax"] = false;
			tdataArray["dbo_Preferencias"][".audit"] = true;
			tdataArray["dbo_Preferencias"][".locking"] = false;
			GlobalVars.pages = tdataArray["dbo_Preferencias"][".pages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["dbo_Preferencias"][".edit"] = true;
				tdataArray["dbo_Preferencias"][".afterEditAction"] = 1;
				tdataArray["dbo_Preferencias"][".closePopupAfterEdit"] = 1;
				tdataArray["dbo_Preferencias"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["dbo_Preferencias"][".add"] = true;
				tdataArray["dbo_Preferencias"][".afterAddAction"] = 1;
				tdataArray["dbo_Preferencias"][".closePopupAfterAdd"] = 1;
				tdataArray["dbo_Preferencias"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["dbo_Preferencias"][".list"] = true;
			}
			tdataArray["dbo_Preferencias"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["dbo_Preferencias"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["dbo_Preferencias"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["dbo_Preferencias"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["dbo_Preferencias"][".printFriendly"] = true;
			}
			tdataArray["dbo_Preferencias"][".showSimpleSearchOptions"] = true;
			tdataArray["dbo_Preferencias"][".allowShowHideFields"] = true;
			tdataArray["dbo_Preferencias"][".allowFieldsReordering"] = true;
			tdataArray["dbo_Preferencias"][".isUseAjaxSuggest"] = true;
			tdataArray["dbo_Preferencias"][".rowHighlite"] = true;


			tdataArray["dbo_Preferencias"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["dbo_Preferencias"][".buttonsAdded"] = false;
			tdataArray["dbo_Preferencias"][".addPageEvents"] = false;
			tdataArray["dbo_Preferencias"][".isUseTimeForSearch"] = false;
			tdataArray["dbo_Preferencias"][".badgeColor"] = "D2691E";
			tdataArray["dbo_Preferencias"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["dbo_Preferencias"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["dbo_Preferencias"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["dbo_Preferencias"][".tableType"] = "list";
			tdataArray["dbo_Preferencias"][".printerPageOrientation"] = 0;
			tdataArray["dbo_Preferencias"][".nPrinterPageScale"] = 100;
			tdataArray["dbo_Preferencias"][".nPrinterSplitRecords"] = 40;
			tdataArray["dbo_Preferencias"][".nPrinterPDFSplitRecords"] = 40;
			tdataArray["dbo_Preferencias"][".geocodingEnabled"] = false;
			tdataArray["dbo_Preferencias"][".pageSize"] = 20;
			tdataArray["dbo_Preferencias"][".warnLeavingPages"] = true;
			tstrOrderBy = "";
			if(MVCFunctions.strlen(tstrOrderBy) && MVCFunctions.strtolower(MVCFunctions.substr(tstrOrderBy, new XVar(0), new XVar(8))) != "order by")
			{
				tstrOrderBy = MVCFunctions.Concat("order by ", tstrOrderBy);
			}
			tdataArray["dbo_Preferencias"][".strOrderBy"] = tstrOrderBy;
			tdataArray["dbo_Preferencias"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["dbo_Preferencias"][".sqlHead"] = "SELECT ID,  	nombre_jefe,  	division";
			tdataArray["dbo_Preferencias"][".sqlFrom"] = "FROM dbo.Preferencias";
			tdataArray["dbo_Preferencias"][".sqlWhereExpr"] = "";
			tdataArray["dbo_Preferencias"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["dbo_Preferencias"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["dbo_Preferencias"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["dbo_Preferencias"][".highlightSearchResults"] = true;
			tableKeysArray["dbo_Preferencias"] = SettingsMap.GetArray();
			tableKeysArray["dbo_Preferencias"].Add("ID");
			tdataArray["dbo_Preferencias"][".Keys"] = tableKeysArray["dbo_Preferencias"];
			tdataArray["dbo_Preferencias"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "ID";
			fdata["GoodName"] = "ID";
			fdata["ownerTable"] = "dbo.Preferencias";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_Preferencias","ID");
			fdata["FieldType"] = 3;
			fdata["AutoInc"] = true;
			fdata["strField"] = "ID";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "ID";
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
			tdataArray["dbo_Preferencias"]["ID"] = fdata;
			tdataArray["dbo_Preferencias"][".searchableFields"].Add("ID");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "nombre_jefe";
			fdata["GoodName"] = "nombre_jefe";
			fdata["ownerTable"] = "dbo.Preferencias";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_Preferencias","nombre_jefe");
			fdata["FieldType"] = 200;
			fdata["strField"] = "nombre_jefe";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "nombre_jefe";
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
			edata["EditParams"] = MVCFunctions.Concat(edata["EditParams"], " maxlength=50");
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
			tdataArray["dbo_Preferencias"]["nombre_jefe"] = fdata;
			tdataArray["dbo_Preferencias"][".searchableFields"].Add("nombre_jefe");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 3;
			fdata["strName"] = "division";
			fdata["GoodName"] = "division";
			fdata["ownerTable"] = "dbo.Preferencias";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_Preferencias","division");
			fdata["FieldType"] = 200;
			fdata["strField"] = "division";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "division";
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
			edata["EditParams"] = MVCFunctions.Concat(edata["EditParams"], " maxlength=100");
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
			tdataArray["dbo_Preferencias"]["division"] = fdata;
			tdataArray["dbo_Preferencias"][".searchableFields"].Add("division");
			GlobalVars.tables_data["dbo.Preferencias"] = tdataArray["dbo_Preferencias"];
			GlobalVars.field_labels["dbo_Preferencias"] = fieldLabelsArray["dbo_Preferencias"];
			GlobalVars.fieldToolTips["dbo_Preferencias"] = fieldToolTipsArray["dbo_Preferencias"];
			GlobalVars.placeHolders["dbo_Preferencias"] = placeHoldersArray["dbo_Preferencias"];
			GlobalVars.page_titles["dbo_Preferencias"] = pageTitlesArray["dbo_Preferencias"];
			GlobalVars.detailsTablesData["dbo.Preferencias"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.Preferencias"] = SettingsMap.GetArray();

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "ID,  	nombre_jefe,  	division";
protoArray["0"]["m_strFrom"] = "FROM dbo.Preferencias";
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
obj = new SQLField(new XVar("m_strName", "ID", "m_strTable", "dbo.Preferencias", "m_srcTableName", "dbo.Preferencias"));

protoArray["6"]["m_sql"] = "ID";
protoArray["6"]["m_srcTableName"] = "dbo.Preferencias";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "nombre_jefe", "m_strTable", "dbo.Preferencias", "m_srcTableName", "dbo.Preferencias"));

protoArray["8"]["m_sql"] = "nombre_jefe";
protoArray["8"]["m_srcTableName"] = "dbo.Preferencias";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["10"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "division", "m_strTable", "dbo.Preferencias", "m_srcTableName", "dbo.Preferencias"));

protoArray["10"]["m_sql"] = "division";
protoArray["10"]["m_srcTableName"] = "dbo.Preferencias";
protoArray["10"]["m_expr"] = obj;
protoArray["10"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["10"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["12"] = SettingsMap.GetArray();
protoArray["12"]["m_link"] = "SQLL_MAIN";
protoArray["13"] = SettingsMap.GetArray();
protoArray["13"]["m_strName"] = "dbo.Preferencias";
protoArray["13"]["m_srcTableName"] = "dbo.Preferencias";
protoArray["13"]["m_columns"] = SettingsMap.GetArray();
protoArray["13"]["m_columns"].Add("nombre_jefe");
protoArray["13"]["m_columns"].Add("division");
protoArray["13"]["m_columns"].Add("ID");
obj = new SQLTable(protoArray["13"]);

protoArray["12"]["m_table"] = obj;
protoArray["12"]["m_sql"] = "dbo.Preferencias";
protoArray["12"]["m_alias"] = "";
protoArray["12"]["m_srcTableName"] = "dbo.Preferencias";
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
protoArray["0"]["m_srcTableName"] = "dbo.Preferencias";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["dbo_Preferencias"] = obj;

				
		
			tdataArray["dbo_Preferencias"][".sqlquery"] = queryData_Array["dbo_Preferencias"];
			GlobalVars.tableEvents["dbo.Preferencias"] = new eventsBase();
			tdataArray["dbo_Preferencias"][".hasEvents"] = false;
			GlobalVars.tables_data["dbo_Preferencias"] = tdataArray["dbo_Preferencias"];
		}
	}

}
