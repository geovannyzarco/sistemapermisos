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
	public static partial class Settings_dbo_acceso_uggroups
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), popupPagesLayoutNames = SettingsMap.GetArray(), query = null, queryData_Array = new XVar(), reportGroupFields = SettingsMap.GetArray(), rgroupField = SettingsMap.GetArray(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["dbo_acceso_uggroups"] = SettingsMap.GetArray();
			tdataArray["dbo_acceso_uggroups"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["dbo_acceso_uggroups"][".truncateText"] = true;
			tdataArray["dbo_acceso_uggroups"][".NumberOfChars"] = 80;
			tdataArray["dbo_acceso_uggroups"][".ShortName"] = "dbo_acceso_uggroups";
			tdataArray["dbo_acceso_uggroups"][".OwnerID"] = "";
			tdataArray["dbo_acceso_uggroups"][".OriginalTable"] = "dbo.acceso_uggroups";
			GlobalVars.defaultPages = MVCFunctions.my_json_decode(new XVar("{\"add\":\"add\",\"edit\":\"edit\",\"export\":\"export\",\"import\":\"import\",\"list\":\"list\",\"print\":\"print\",\"search\":\"search\",\"view\":\"view\"}"));
			tdataArray["dbo_acceso_uggroups"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"add\":[\"add\"],\"edit\":[\"edit\"],\"export\":[\"export\"],\"import\":[\"import\"],\"list\":[\"list\"],\"print\":[\"print\"],\"search\":[\"search\"],\"view\":[\"view\"]}")));
			tdataArray["dbo_acceso_uggroups"][".defaultPages"] = GlobalVars.defaultPages;
			fieldLabelsArray["dbo_acceso_uggroups"] = SettingsMap.GetArray();
			fieldToolTipsArray["dbo_acceso_uggroups"] = SettingsMap.GetArray();
			pageTitlesArray["dbo_acceso_uggroups"] = SettingsMap.GetArray();
			placeHoldersArray["dbo_acceso_uggroups"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "Spanish")
			{
				fieldLabelsArray["dbo_acceso_uggroups"]["Spanish"] = SettingsMap.GetArray();
				fieldToolTipsArray["dbo_acceso_uggroups"]["Spanish"] = SettingsMap.GetArray();
				placeHoldersArray["dbo_acceso_uggroups"]["Spanish"] = SettingsMap.GetArray();
				pageTitlesArray["dbo_acceso_uggroups"]["Spanish"] = SettingsMap.GetArray();
				fieldLabelsArray["dbo_acceso_uggroups"]["Spanish"]["GroupID"] = "Group ID";
				fieldToolTipsArray["dbo_acceso_uggroups"]["Spanish"]["GroupID"] = "";
				placeHoldersArray["dbo_acceso_uggroups"]["Spanish"]["GroupID"] = "";
				fieldLabelsArray["dbo_acceso_uggroups"]["Spanish"]["Label"] = "Label";
				fieldToolTipsArray["dbo_acceso_uggroups"]["Spanish"]["Label"] = "";
				placeHoldersArray["dbo_acceso_uggroups"]["Spanish"]["Label"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["dbo_acceso_uggroups"]["Spanish"])))
				{
					tdataArray["dbo_acceso_uggroups"][".isUseToolTips"] = true;
				}
			}
			tdataArray["dbo_acceso_uggroups"][".NCSearch"] = true;
			tdataArray["dbo_acceso_uggroups"][".shortTableName"] = "dbo_acceso_uggroups";
			tdataArray["dbo_acceso_uggroups"][".nSecOptions"] = 0;
			tdataArray["dbo_acceso_uggroups"][".mainTableOwnerID"] = "";
			tdataArray["dbo_acceso_uggroups"][".entityType"] = 0;
			tdataArray["dbo_acceso_uggroups"][".strOriginalTableName"] = "dbo.acceso_uggroups";
			tdataArray["dbo_acceso_uggroups"][".showAddInPopup"] = false;
			tdataArray["dbo_acceso_uggroups"][".showEditInPopup"] = false;
			tdataArray["dbo_acceso_uggroups"][".showViewInPopup"] = false;
			popupPagesLayoutNames = SettingsMap.GetArray();
			tdataArray["dbo_acceso_uggroups"][".popupPagesLayoutNames"] = popupPagesLayoutNames;
			tdataArray["dbo_acceso_uggroups"][".listAjax"] = false;
			tdataArray["dbo_acceso_uggroups"][".listAjax"] = false;
			tdataArray["dbo_acceso_uggroups"][".audit"] = false;
			tdataArray["dbo_acceso_uggroups"][".locking"] = false;
			GlobalVars.pages = tdataArray["dbo_acceso_uggroups"][".pages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["dbo_acceso_uggroups"][".edit"] = true;
				tdataArray["dbo_acceso_uggroups"][".afterEditAction"] = 1;
				tdataArray["dbo_acceso_uggroups"][".closePopupAfterEdit"] = 1;
				tdataArray["dbo_acceso_uggroups"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["dbo_acceso_uggroups"][".add"] = true;
				tdataArray["dbo_acceso_uggroups"][".afterAddAction"] = 1;
				tdataArray["dbo_acceso_uggroups"][".closePopupAfterAdd"] = 1;
				tdataArray["dbo_acceso_uggroups"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["dbo_acceso_uggroups"][".list"] = true;
			}
			tdataArray["dbo_acceso_uggroups"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["dbo_acceso_uggroups"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["dbo_acceso_uggroups"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["dbo_acceso_uggroups"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["dbo_acceso_uggroups"][".printFriendly"] = true;
			}
			tdataArray["dbo_acceso_uggroups"][".showSimpleSearchOptions"] = true;
			tdataArray["dbo_acceso_uggroups"][".allowShowHideFields"] = true;
			tdataArray["dbo_acceso_uggroups"][".allowFieldsReordering"] = true;
			tdataArray["dbo_acceso_uggroups"][".isUseAjaxSuggest"] = true;
			tdataArray["dbo_acceso_uggroups"][".rowHighlite"] = true;


			tdataArray["dbo_acceso_uggroups"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["dbo_acceso_uggroups"][".buttonsAdded"] = false;
			tdataArray["dbo_acceso_uggroups"][".addPageEvents"] = false;
			tdataArray["dbo_acceso_uggroups"][".isUseTimeForSearch"] = false;
			tdataArray["dbo_acceso_uggroups"][".badgeColor"] = "CD853F";
			tdataArray["dbo_acceso_uggroups"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["dbo_acceso_uggroups"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["dbo_acceso_uggroups"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["dbo_acceso_uggroups"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["dbo_acceso_uggroups"][".googleLikeFields"].Add("GroupID");
			tdataArray["dbo_acceso_uggroups"][".googleLikeFields"].Add("Label");
			tdataArray["dbo_acceso_uggroups"][".tableType"] = "list";
			tdataArray["dbo_acceso_uggroups"][".printerPageOrientation"] = 0;
			tdataArray["dbo_acceso_uggroups"][".nPrinterPageScale"] = 100;
			tdataArray["dbo_acceso_uggroups"][".nPrinterSplitRecords"] = 40;
			tdataArray["dbo_acceso_uggroups"][".nPrinterPDFSplitRecords"] = 40;
			tdataArray["dbo_acceso_uggroups"][".geocodingEnabled"] = false;
			tdataArray["dbo_acceso_uggroups"][".pageSize"] = 20;
			tdataArray["dbo_acceso_uggroups"][".warnLeavingPages"] = true;
			tstrOrderBy = "";
			if(MVCFunctions.strlen(tstrOrderBy) && MVCFunctions.strtolower(MVCFunctions.substr(tstrOrderBy, new XVar(0), new XVar(8))) != "order by")
			{
				tstrOrderBy = MVCFunctions.Concat("order by ", tstrOrderBy);
			}
			tdataArray["dbo_acceso_uggroups"][".strOrderBy"] = tstrOrderBy;
			tdataArray["dbo_acceso_uggroups"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["dbo_acceso_uggroups"][".sqlHead"] = "SELECT GroupID,  	[Label]";
			tdataArray["dbo_acceso_uggroups"][".sqlFrom"] = "FROM dbo.acceso_uggroups";
			tdataArray["dbo_acceso_uggroups"][".sqlWhereExpr"] = "";
			tdataArray["dbo_acceso_uggroups"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["dbo_acceso_uggroups"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["dbo_acceso_uggroups"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["dbo_acceso_uggroups"][".highlightSearchResults"] = true;
			tableKeysArray["dbo_acceso_uggroups"] = SettingsMap.GetArray();
			tableKeysArray["dbo_acceso_uggroups"].Add("GroupID");
			tdataArray["dbo_acceso_uggroups"][".Keys"] = tableKeysArray["dbo_acceso_uggroups"];
			tdataArray["dbo_acceso_uggroups"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "GroupID";
			fdata["GoodName"] = "GroupID";
			fdata["ownerTable"] = "dbo.acceso_uggroups";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_acceso_uggroups","GroupID");
			fdata["FieldType"] = 3;
			fdata["AutoInc"] = true;
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
			tdataArray["dbo_acceso_uggroups"]["GroupID"] = fdata;
			tdataArray["dbo_acceso_uggroups"][".searchableFields"].Add("GroupID");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "Label";
			fdata["GoodName"] = "Label";
			fdata["ownerTable"] = "dbo.acceso_uggroups";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_acceso_uggroups","Label");
			fdata["FieldType"] = 200;
			fdata["strField"] = "Label";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "[Label]";
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
			tdataArray["dbo_acceso_uggroups"]["Label"] = fdata;
			tdataArray["dbo_acceso_uggroups"][".searchableFields"].Add("Label");
			GlobalVars.tables_data["dbo.acceso_uggroups"] = tdataArray["dbo_acceso_uggroups"];
			GlobalVars.field_labels["dbo_acceso_uggroups"] = fieldLabelsArray["dbo_acceso_uggroups"];
			GlobalVars.fieldToolTips["dbo_acceso_uggroups"] = fieldToolTipsArray["dbo_acceso_uggroups"];
			GlobalVars.placeHolders["dbo_acceso_uggroups"] = placeHoldersArray["dbo_acceso_uggroups"];
			GlobalVars.page_titles["dbo_acceso_uggroups"] = pageTitlesArray["dbo_acceso_uggroups"];
			GlobalVars.detailsTablesData["dbo.acceso_uggroups"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.acceso_uggroups"] = SettingsMap.GetArray();

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "GroupID,  	[Label]";
protoArray["0"]["m_strFrom"] = "FROM dbo.acceso_uggroups";
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
obj = new SQLField(new XVar("m_strName", "GroupID", "m_strTable", "dbo.acceso_uggroups", "m_srcTableName", "dbo.acceso_uggroups"));

protoArray["6"]["m_sql"] = "GroupID";
protoArray["6"]["m_srcTableName"] = "dbo.acceso_uggroups";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "Label", "m_strTable", "dbo.acceso_uggroups", "m_srcTableName", "dbo.acceso_uggroups"));

protoArray["8"]["m_sql"] = "[Label]";
protoArray["8"]["m_srcTableName"] = "dbo.acceso_uggroups";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["10"] = SettingsMap.GetArray();
protoArray["10"]["m_link"] = "SQLL_MAIN";
protoArray["11"] = SettingsMap.GetArray();
protoArray["11"]["m_strName"] = "dbo.acceso_uggroups";
protoArray["11"]["m_srcTableName"] = "dbo.acceso_uggroups";
protoArray["11"]["m_columns"] = SettingsMap.GetArray();
protoArray["11"]["m_columns"].Add("GroupID");
protoArray["11"]["m_columns"].Add("Label");
obj = new SQLTable(protoArray["11"]);

protoArray["10"]["m_table"] = obj;
protoArray["10"]["m_sql"] = "dbo.acceso_uggroups";
protoArray["10"]["m_alias"] = "";
protoArray["10"]["m_srcTableName"] = "dbo.acceso_uggroups";
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
protoArray["0"]["m_srcTableName"] = "dbo.acceso_uggroups";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["dbo_acceso_uggroups"] = obj;

				
		
			tdataArray["dbo_acceso_uggroups"][".sqlquery"] = queryData_Array["dbo_acceso_uggroups"];
			GlobalVars.tableEvents["dbo.acceso_uggroups"] = new eventsBase();
			tdataArray["dbo_acceso_uggroups"][".hasEvents"] = false;
			GlobalVars.tables_data["dbo_acceso_uggroups"] = tdataArray["dbo_acceso_uggroups"];
		}
	}

}
