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
	public static partial class Settings_admin_rights
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), popupPagesLayoutNames = SettingsMap.GetArray(), query = null, queryData_Array = new XVar(), reportGroupFields = SettingsMap.GetArray(), rgroupField = SettingsMap.GetArray(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["admin_rights"] = SettingsMap.GetArray();
			tdataArray["admin_rights"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["admin_rights"][".truncateText"] = true;
			tdataArray["admin_rights"][".NumberOfChars"] = 80;
			tdataArray["admin_rights"][".ShortName"] = "admin_rights";
			tdataArray["admin_rights"][".OwnerID"] = "";
			tdataArray["admin_rights"][".OriginalTable"] = "dbo.acceso_ugrights";
			GlobalVars.defaultPages = MVCFunctions.my_json_decode(new XVar("{}"));
			tdataArray["admin_rights"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{}")));
			tdataArray["admin_rights"][".defaultPages"] = GlobalVars.defaultPages;
			fieldLabelsArray["admin_rights"] = SettingsMap.GetArray();
			fieldToolTipsArray["admin_rights"] = SettingsMap.GetArray();
			pageTitlesArray["admin_rights"] = SettingsMap.GetArray();
			placeHoldersArray["admin_rights"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "Spanish")
			{
				fieldLabelsArray["admin_rights"]["Spanish"] = SettingsMap.GetArray();
				fieldToolTipsArray["admin_rights"]["Spanish"] = SettingsMap.GetArray();
				placeHoldersArray["admin_rights"]["Spanish"] = SettingsMap.GetArray();
				pageTitlesArray["admin_rights"]["Spanish"] = SettingsMap.GetArray();
				fieldLabelsArray["admin_rights"]["Spanish"]["TableName"] = "Nombre Tabla";
				fieldToolTipsArray["admin_rights"]["Spanish"]["TableName"] = "";
				placeHoldersArray["admin_rights"]["Spanish"]["TableName"] = "";
				fieldLabelsArray["admin_rights"]["Spanish"]["GroupID"] = "ID Grupo";
				fieldToolTipsArray["admin_rights"]["Spanish"]["GroupID"] = "";
				placeHoldersArray["admin_rights"]["Spanish"]["GroupID"] = "";
				fieldLabelsArray["admin_rights"]["Spanish"]["AccessMask"] = "Access Mask";
				fieldToolTipsArray["admin_rights"]["Spanish"]["AccessMask"] = "";
				placeHoldersArray["admin_rights"]["Spanish"]["AccessMask"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["admin_rights"]["Spanish"])))
				{
					tdataArray["admin_rights"][".isUseToolTips"] = true;
				}
			}
			tdataArray["admin_rights"][".NCSearch"] = true;
			tdataArray["admin_rights"][".shortTableName"] = "admin_rights";
			tdataArray["admin_rights"][".nSecOptions"] = 0;
			tdataArray["admin_rights"][".mainTableOwnerID"] = "";
			tdataArray["admin_rights"][".entityType"] = 1;
			tdataArray["admin_rights"][".strOriginalTableName"] = "dbo.acceso_ugrights";
			tdataArray["admin_rights"][".showAddInPopup"] = false;
			tdataArray["admin_rights"][".showEditInPopup"] = false;
			tdataArray["admin_rights"][".showViewInPopup"] = false;
			popupPagesLayoutNames = SettingsMap.GetArray();
			tdataArray["admin_rights"][".popupPagesLayoutNames"] = popupPagesLayoutNames;
			tdataArray["admin_rights"][".listAjax"] = false;
			tdataArray["admin_rights"][".listAjax"] = false;
			tdataArray["admin_rights"][".audit"] = true;
			tdataArray["admin_rights"][".locking"] = false;
			GlobalVars.pages = tdataArray["admin_rights"][".pages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["admin_rights"][".edit"] = true;
				tdataArray["admin_rights"][".afterEditAction"] = 1;
				tdataArray["admin_rights"][".closePopupAfterEdit"] = 1;
				tdataArray["admin_rights"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["admin_rights"][".add"] = true;
				tdataArray["admin_rights"][".afterAddAction"] = 1;
				tdataArray["admin_rights"][".closePopupAfterAdd"] = 1;
				tdataArray["admin_rights"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["admin_rights"][".list"] = true;
			}
			tdataArray["admin_rights"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["admin_rights"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["admin_rights"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["admin_rights"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["admin_rights"][".printFriendly"] = true;
			}
			tdataArray["admin_rights"][".showSimpleSearchOptions"] = true;
			tdataArray["admin_rights"][".allowShowHideFields"] = true;
			tdataArray["admin_rights"][".allowFieldsReordering"] = true;
			tdataArray["admin_rights"][".isUseAjaxSuggest"] = true;
			tdataArray["admin_rights"][".rowHighlite"] = true;


			tdataArray["admin_rights"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["admin_rights"][".buttonsAdded"] = false;
			tdataArray["admin_rights"][".addPageEvents"] = false;
			tdataArray["admin_rights"][".isUseTimeForSearch"] = false;
			tdataArray["admin_rights"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["admin_rights"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["admin_rights"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["admin_rights"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["admin_rights"][".googleLikeFields"].Add("TableName");
			tdataArray["admin_rights"][".googleLikeFields"].Add("GroupID");
			tdataArray["admin_rights"][".googleLikeFields"].Add("AccessMask");
			tdataArray["admin_rights"][".tableType"] = "list";
			tdataArray["admin_rights"][".printerPageOrientation"] = 0;
			tdataArray["admin_rights"][".nPrinterPageScale"] = 100;
			tdataArray["admin_rights"][".nPrinterSplitRecords"] = 40;
			tdataArray["admin_rights"][".nPrinterPDFSplitRecords"] = 40;
			tdataArray["admin_rights"][".geocodingEnabled"] = false;
			tdataArray["admin_rights"][".pageSize"] = 20;
			tdataArray["admin_rights"][".warnLeavingPages"] = true;
			tstrOrderBy = "";
			if(MVCFunctions.strlen(tstrOrderBy) && MVCFunctions.strtolower(MVCFunctions.substr(tstrOrderBy, new XVar(0), new XVar(8))) != "order by")
			{
				tstrOrderBy = MVCFunctions.Concat("order by ", tstrOrderBy);
			}
			tdataArray["admin_rights"][".strOrderBy"] = tstrOrderBy;
			tdataArray["admin_rights"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["admin_rights"][".sqlHead"] = "SELECT TableName,  	GroupID,  	AccessMask";
			tdataArray["admin_rights"][".sqlFrom"] = "FROM dbo.acceso_ugrights";
			tdataArray["admin_rights"][".sqlWhereExpr"] = "";
			tdataArray["admin_rights"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["admin_rights"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["admin_rights"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["admin_rights"][".highlightSearchResults"] = true;
			tableKeysArray["admin_rights"] = SettingsMap.GetArray();
			tableKeysArray["admin_rights"].Add("TableName");
			tableKeysArray["admin_rights"].Add("GroupID");
			tdataArray["admin_rights"][".Keys"] = tableKeysArray["admin_rights"];
			tdataArray["admin_rights"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "TableName";
			fdata["GoodName"] = "TableName";
			fdata["ownerTable"] = "dbo.acceso_ugrights";
			fdata["Label"] = CommonFunctions.GetFieldLabel("admin_rights","TableName");
			fdata["FieldType"] = 200;
			fdata["strField"] = "TableName";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "TableName";
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
			edata["EditParams"] = MVCFunctions.Concat(edata["EditParams"], " maxlength=300");
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
			tdataArray["admin_rights"]["TableName"] = fdata;
			tdataArray["admin_rights"][".searchableFields"].Add("TableName");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "GroupID";
			fdata["GoodName"] = "GroupID";
			fdata["ownerTable"] = "dbo.acceso_ugrights";
			fdata["Label"] = CommonFunctions.GetFieldLabel("admin_rights","GroupID");
			fdata["FieldType"] = 3;
			fdata["strField"] = "GroupID";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "GroupID";
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
			tdataArray["admin_rights"]["GroupID"] = fdata;
			tdataArray["admin_rights"][".searchableFields"].Add("GroupID");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 3;
			fdata["strName"] = "AccessMask";
			fdata["GoodName"] = "AccessMask";
			fdata["ownerTable"] = "dbo.acceso_ugrights";
			fdata["Label"] = CommonFunctions.GetFieldLabel("admin_rights","AccessMask");
			fdata["FieldType"] = 200;
			fdata["strField"] = "AccessMask";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "AccessMask";
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
			edata["EditParams"] = MVCFunctions.Concat(edata["EditParams"], " maxlength=10");
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
			tdataArray["admin_rights"]["AccessMask"] = fdata;
			tdataArray["admin_rights"][".searchableFields"].Add("AccessMask");
			GlobalVars.tables_data["admin_rights"] = tdataArray["admin_rights"];
			GlobalVars.field_labels["admin_rights"] = fieldLabelsArray["admin_rights"];
			GlobalVars.fieldToolTips["admin_rights"] = fieldToolTipsArray["admin_rights"];
			GlobalVars.placeHolders["admin_rights"] = placeHoldersArray["admin_rights"];
			GlobalVars.page_titles["admin_rights"] = pageTitlesArray["admin_rights"];
			GlobalVars.detailsTablesData["admin_rights"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["admin_rights"] = SettingsMap.GetArray();

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "TableName,  	GroupID,  	AccessMask";
protoArray["0"]["m_strFrom"] = "FROM dbo.acceso_ugrights";
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
obj = new SQLField(new XVar("m_strName", "TableName", "m_strTable", "dbo.acceso_ugrights", "m_srcTableName", "admin_rights"));

protoArray["6"]["m_sql"] = "TableName";
protoArray["6"]["m_srcTableName"] = "admin_rights";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "GroupID", "m_strTable", "dbo.acceso_ugrights", "m_srcTableName", "admin_rights"));

protoArray["8"]["m_sql"] = "GroupID";
protoArray["8"]["m_srcTableName"] = "admin_rights";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["10"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "AccessMask", "m_strTable", "dbo.acceso_ugrights", "m_srcTableName", "admin_rights"));

protoArray["10"]["m_sql"] = "AccessMask";
protoArray["10"]["m_srcTableName"] = "admin_rights";
protoArray["10"]["m_expr"] = obj;
protoArray["10"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["10"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["12"] = SettingsMap.GetArray();
protoArray["12"]["m_link"] = "SQLL_MAIN";
protoArray["13"] = SettingsMap.GetArray();
protoArray["13"]["m_strName"] = "dbo.acceso_ugrights";
protoArray["13"]["m_srcTableName"] = "admin_rights";
protoArray["13"]["m_columns"] = SettingsMap.GetArray();
protoArray["13"]["m_columns"].Add("TableName");
protoArray["13"]["m_columns"].Add("GroupID");
protoArray["13"]["m_columns"].Add("AccessMask");
obj = new SQLTable(protoArray["13"]);

protoArray["12"]["m_table"] = obj;
protoArray["12"]["m_sql"] = "dbo.acceso_ugrights";
protoArray["12"]["m_alias"] = "";
protoArray["12"]["m_srcTableName"] = "admin_rights";
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
protoArray["0"]["m_srcTableName"] = "admin_rights";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["admin_rights"] = obj;

				
		
			tdataArray["admin_rights"][".sqlquery"] = queryData_Array["admin_rights"];
			GlobalVars.tableEvents["admin_rights"] = new eventsBase();
			tdataArray["admin_rights"][".hasEvents"] = false;
			GlobalVars.tables_data["admin_rights"] = tdataArray["admin_rights"];
		}
	}

}
