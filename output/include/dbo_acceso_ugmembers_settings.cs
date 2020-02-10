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
	public static partial class Settings_dbo_acceso_ugmembers
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), popupPagesLayoutNames = SettingsMap.GetArray(), query = null, queryData_Array = new XVar(), reportGroupFields = SettingsMap.GetArray(), rgroupField = SettingsMap.GetArray(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["dbo_acceso_ugmembers"] = SettingsMap.GetArray();
			tdataArray["dbo_acceso_ugmembers"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["dbo_acceso_ugmembers"][".truncateText"] = true;
			tdataArray["dbo_acceso_ugmembers"][".NumberOfChars"] = 80;
			tdataArray["dbo_acceso_ugmembers"][".ShortName"] = "dbo_acceso_ugmembers";
			tdataArray["dbo_acceso_ugmembers"][".OwnerID"] = "";
			tdataArray["dbo_acceso_ugmembers"][".OriginalTable"] = "dbo.acceso_ugmembers";
			GlobalVars.defaultPages = MVCFunctions.my_json_decode(new XVar("{\"add\":\"add\",\"edit\":\"edit\",\"export\":\"export\",\"import\":\"import\",\"list\":\"list\",\"print\":\"print\",\"search\":\"search\",\"view\":\"view\"}"));
			tdataArray["dbo_acceso_ugmembers"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"add\":[\"add\"],\"edit\":[\"edit\"],\"export\":[\"export\"],\"import\":[\"import\"],\"list\":[\"list\"],\"print\":[\"print\"],\"search\":[\"search\"],\"view\":[\"view\"]}")));
			tdataArray["dbo_acceso_ugmembers"][".defaultPages"] = GlobalVars.defaultPages;
			fieldLabelsArray["dbo_acceso_ugmembers"] = SettingsMap.GetArray();
			fieldToolTipsArray["dbo_acceso_ugmembers"] = SettingsMap.GetArray();
			pageTitlesArray["dbo_acceso_ugmembers"] = SettingsMap.GetArray();
			placeHoldersArray["dbo_acceso_ugmembers"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "Spanish")
			{
				fieldLabelsArray["dbo_acceso_ugmembers"]["Spanish"] = SettingsMap.GetArray();
				fieldToolTipsArray["dbo_acceso_ugmembers"]["Spanish"] = SettingsMap.GetArray();
				placeHoldersArray["dbo_acceso_ugmembers"]["Spanish"] = SettingsMap.GetArray();
				pageTitlesArray["dbo_acceso_ugmembers"]["Spanish"] = SettingsMap.GetArray();
				fieldLabelsArray["dbo_acceso_ugmembers"]["Spanish"]["UserName"] = "User Name";
				fieldToolTipsArray["dbo_acceso_ugmembers"]["Spanish"]["UserName"] = "";
				placeHoldersArray["dbo_acceso_ugmembers"]["Spanish"]["UserName"] = "";
				fieldLabelsArray["dbo_acceso_ugmembers"]["Spanish"]["GroupID"] = "Group ID";
				fieldToolTipsArray["dbo_acceso_ugmembers"]["Spanish"]["GroupID"] = "";
				placeHoldersArray["dbo_acceso_ugmembers"]["Spanish"]["GroupID"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["dbo_acceso_ugmembers"]["Spanish"])))
				{
					tdataArray["dbo_acceso_ugmembers"][".isUseToolTips"] = true;
				}
			}
			tdataArray["dbo_acceso_ugmembers"][".NCSearch"] = true;
			tdataArray["dbo_acceso_ugmembers"][".shortTableName"] = "dbo_acceso_ugmembers";
			tdataArray["dbo_acceso_ugmembers"][".nSecOptions"] = 0;
			tdataArray["dbo_acceso_ugmembers"][".mainTableOwnerID"] = "";
			tdataArray["dbo_acceso_ugmembers"][".entityType"] = 0;
			tdataArray["dbo_acceso_ugmembers"][".strOriginalTableName"] = "dbo.acceso_ugmembers";
			tdataArray["dbo_acceso_ugmembers"][".showAddInPopup"] = false;
			tdataArray["dbo_acceso_ugmembers"][".showEditInPopup"] = false;
			tdataArray["dbo_acceso_ugmembers"][".showViewInPopup"] = false;
			popupPagesLayoutNames = SettingsMap.GetArray();
			tdataArray["dbo_acceso_ugmembers"][".popupPagesLayoutNames"] = popupPagesLayoutNames;
			tdataArray["dbo_acceso_ugmembers"][".listAjax"] = false;
			tdataArray["dbo_acceso_ugmembers"][".listAjax"] = false;
			tdataArray["dbo_acceso_ugmembers"][".audit"] = false;
			tdataArray["dbo_acceso_ugmembers"][".locking"] = false;
			GlobalVars.pages = tdataArray["dbo_acceso_ugmembers"][".pages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["dbo_acceso_ugmembers"][".edit"] = true;
				tdataArray["dbo_acceso_ugmembers"][".afterEditAction"] = 1;
				tdataArray["dbo_acceso_ugmembers"][".closePopupAfterEdit"] = 1;
				tdataArray["dbo_acceso_ugmembers"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["dbo_acceso_ugmembers"][".add"] = true;
				tdataArray["dbo_acceso_ugmembers"][".afterAddAction"] = 1;
				tdataArray["dbo_acceso_ugmembers"][".closePopupAfterAdd"] = 1;
				tdataArray["dbo_acceso_ugmembers"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["dbo_acceso_ugmembers"][".list"] = true;
			}
			tdataArray["dbo_acceso_ugmembers"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["dbo_acceso_ugmembers"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["dbo_acceso_ugmembers"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["dbo_acceso_ugmembers"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["dbo_acceso_ugmembers"][".printFriendly"] = true;
			}
			tdataArray["dbo_acceso_ugmembers"][".showSimpleSearchOptions"] = true;
			tdataArray["dbo_acceso_ugmembers"][".allowShowHideFields"] = true;
			tdataArray["dbo_acceso_ugmembers"][".allowFieldsReordering"] = true;
			tdataArray["dbo_acceso_ugmembers"][".isUseAjaxSuggest"] = true;
			tdataArray["dbo_acceso_ugmembers"][".rowHighlite"] = true;


			tdataArray["dbo_acceso_ugmembers"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["dbo_acceso_ugmembers"][".buttonsAdded"] = false;
			tdataArray["dbo_acceso_ugmembers"][".addPageEvents"] = false;
			tdataArray["dbo_acceso_ugmembers"][".isUseTimeForSearch"] = false;
			tdataArray["dbo_acceso_ugmembers"][".badgeColor"] = "CFAE83";
			tdataArray["dbo_acceso_ugmembers"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["dbo_acceso_ugmembers"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["dbo_acceso_ugmembers"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["dbo_acceso_ugmembers"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["dbo_acceso_ugmembers"][".googleLikeFields"].Add("UserName");
			tdataArray["dbo_acceso_ugmembers"][".googleLikeFields"].Add("GroupID");
			tdataArray["dbo_acceso_ugmembers"][".tableType"] = "list";
			tdataArray["dbo_acceso_ugmembers"][".printerPageOrientation"] = 0;
			tdataArray["dbo_acceso_ugmembers"][".nPrinterPageScale"] = 100;
			tdataArray["dbo_acceso_ugmembers"][".nPrinterSplitRecords"] = 40;
			tdataArray["dbo_acceso_ugmembers"][".nPrinterPDFSplitRecords"] = 40;
			tdataArray["dbo_acceso_ugmembers"][".geocodingEnabled"] = false;
			tdataArray["dbo_acceso_ugmembers"][".pageSize"] = 20;
			tdataArray["dbo_acceso_ugmembers"][".warnLeavingPages"] = true;
			tstrOrderBy = "";
			if(MVCFunctions.strlen(tstrOrderBy) && MVCFunctions.strtolower(MVCFunctions.substr(tstrOrderBy, new XVar(0), new XVar(8))) != "order by")
			{
				tstrOrderBy = MVCFunctions.Concat("order by ", tstrOrderBy);
			}
			tdataArray["dbo_acceso_ugmembers"][".strOrderBy"] = tstrOrderBy;
			tdataArray["dbo_acceso_ugmembers"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["dbo_acceso_ugmembers"][".sqlHead"] = "SELECT UserName,  	GroupID";
			tdataArray["dbo_acceso_ugmembers"][".sqlFrom"] = "FROM dbo.acceso_ugmembers";
			tdataArray["dbo_acceso_ugmembers"][".sqlWhereExpr"] = "";
			tdataArray["dbo_acceso_ugmembers"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["dbo_acceso_ugmembers"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["dbo_acceso_ugmembers"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["dbo_acceso_ugmembers"][".highlightSearchResults"] = true;
			tableKeysArray["dbo_acceso_ugmembers"] = SettingsMap.GetArray();
			tableKeysArray["dbo_acceso_ugmembers"].Add("UserName");
			tableKeysArray["dbo_acceso_ugmembers"].Add("GroupID");
			tdataArray["dbo_acceso_ugmembers"][".Keys"] = tableKeysArray["dbo_acceso_ugmembers"];
			tdataArray["dbo_acceso_ugmembers"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "UserName";
			fdata["GoodName"] = "UserName";
			fdata["ownerTable"] = "dbo.acceso_ugmembers";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_acceso_ugmembers","UserName");
			fdata["FieldType"] = 200;
			fdata["strField"] = "UserName";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "UserName";
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
			tdataArray["dbo_acceso_ugmembers"]["UserName"] = fdata;
			tdataArray["dbo_acceso_ugmembers"][".searchableFields"].Add("UserName");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "GroupID";
			fdata["GoodName"] = "GroupID";
			fdata["ownerTable"] = "dbo.acceso_ugmembers";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_acceso_ugmembers","GroupID");
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
			tdataArray["dbo_acceso_ugmembers"]["GroupID"] = fdata;
			tdataArray["dbo_acceso_ugmembers"][".searchableFields"].Add("GroupID");
			GlobalVars.tables_data["dbo.acceso_ugmembers"] = tdataArray["dbo_acceso_ugmembers"];
			GlobalVars.field_labels["dbo_acceso_ugmembers"] = fieldLabelsArray["dbo_acceso_ugmembers"];
			GlobalVars.fieldToolTips["dbo_acceso_ugmembers"] = fieldToolTipsArray["dbo_acceso_ugmembers"];
			GlobalVars.placeHolders["dbo_acceso_ugmembers"] = placeHoldersArray["dbo_acceso_ugmembers"];
			GlobalVars.page_titles["dbo_acceso_ugmembers"] = pageTitlesArray["dbo_acceso_ugmembers"];
			GlobalVars.detailsTablesData["dbo.acceso_ugmembers"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.acceso_ugmembers"] = SettingsMap.GetArray();

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "UserName,  	GroupID";
protoArray["0"]["m_strFrom"] = "FROM dbo.acceso_ugmembers";
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
obj = new SQLField(new XVar("m_strName", "UserName", "m_strTable", "dbo.acceso_ugmembers", "m_srcTableName", "dbo.acceso_ugmembers"));

protoArray["6"]["m_sql"] = "UserName";
protoArray["6"]["m_srcTableName"] = "dbo.acceso_ugmembers";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "GroupID", "m_strTable", "dbo.acceso_ugmembers", "m_srcTableName", "dbo.acceso_ugmembers"));

protoArray["8"]["m_sql"] = "GroupID";
protoArray["8"]["m_srcTableName"] = "dbo.acceso_ugmembers";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["10"] = SettingsMap.GetArray();
protoArray["10"]["m_link"] = "SQLL_MAIN";
protoArray["11"] = SettingsMap.GetArray();
protoArray["11"]["m_strName"] = "dbo.acceso_ugmembers";
protoArray["11"]["m_srcTableName"] = "dbo.acceso_ugmembers";
protoArray["11"]["m_columns"] = SettingsMap.GetArray();
protoArray["11"]["m_columns"].Add("UserName");
protoArray["11"]["m_columns"].Add("GroupID");
obj = new SQLTable(protoArray["11"]);

protoArray["10"]["m_table"] = obj;
protoArray["10"]["m_sql"] = "dbo.acceso_ugmembers";
protoArray["10"]["m_alias"] = "";
protoArray["10"]["m_srcTableName"] = "dbo.acceso_ugmembers";
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
protoArray["0"]["m_srcTableName"] = "dbo.acceso_ugmembers";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["dbo_acceso_ugmembers"] = obj;

				
		
			tdataArray["dbo_acceso_ugmembers"][".sqlquery"] = queryData_Array["dbo_acceso_ugmembers"];
			GlobalVars.tableEvents["dbo.acceso_ugmembers"] = new eventsBase();
			tdataArray["dbo_acceso_ugmembers"][".hasEvents"] = false;
			GlobalVars.tables_data["dbo_acceso_ugmembers"] = tdataArray["dbo_acceso_ugmembers"];
		}
	}

}
