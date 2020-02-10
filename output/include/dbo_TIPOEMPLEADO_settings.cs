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
	public static partial class Settings_dbo_TIPOEMPLEADO
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), popupPagesLayoutNames = SettingsMap.GetArray(), query = null, queryData_Array = new XVar(), reportGroupFields = SettingsMap.GetArray(), rgroupField = SettingsMap.GetArray(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["dbo_TIPOEMPLEADO"] = SettingsMap.GetArray();
			tdataArray["dbo_TIPOEMPLEADO"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["dbo_TIPOEMPLEADO"][".truncateText"] = true;
			tdataArray["dbo_TIPOEMPLEADO"][".NumberOfChars"] = 80;
			tdataArray["dbo_TIPOEMPLEADO"][".ShortName"] = "dbo_TIPOEMPLEADO";
			tdataArray["dbo_TIPOEMPLEADO"][".OwnerID"] = "";
			tdataArray["dbo_TIPOEMPLEADO"][".OriginalTable"] = "dbo.TIPOEMPLEADO";
			GlobalVars.defaultPages = MVCFunctions.my_json_decode(new XVar("{\"add\":\"add\",\"edit\":\"edit\",\"export\":\"export\",\"list\":\"list\",\"masterlist\":\"masterlist\",\"masterprint\":\"masterprint\",\"search\":\"search\"}"));
			tdataArray["dbo_TIPOEMPLEADO"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"add\":[\"add\"],\"edit\":[\"edit\"],\"export\":[\"export\"],\"list\":[\"list\"],\"masterlist\":[\"masterlist\"],\"masterprint\":[\"masterprint\"],\"search\":[\"search\"]}")));
			tdataArray["dbo_TIPOEMPLEADO"][".defaultPages"] = GlobalVars.defaultPages;
			fieldLabelsArray["dbo_TIPOEMPLEADO"] = SettingsMap.GetArray();
			fieldToolTipsArray["dbo_TIPOEMPLEADO"] = SettingsMap.GetArray();
			pageTitlesArray["dbo_TIPOEMPLEADO"] = SettingsMap.GetArray();
			placeHoldersArray["dbo_TIPOEMPLEADO"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "Spanish")
			{
				fieldLabelsArray["dbo_TIPOEMPLEADO"]["Spanish"] = SettingsMap.GetArray();
				fieldToolTipsArray["dbo_TIPOEMPLEADO"]["Spanish"] = SettingsMap.GetArray();
				placeHoldersArray["dbo_TIPOEMPLEADO"]["Spanish"] = SettingsMap.GetArray();
				pageTitlesArray["dbo_TIPOEMPLEADO"]["Spanish"] = SettingsMap.GetArray();
				fieldLabelsArray["dbo_TIPOEMPLEADO"]["Spanish"]["id_tipo"] = "ID";
				fieldToolTipsArray["dbo_TIPOEMPLEADO"]["Spanish"]["id_tipo"] = "";
				placeHoldersArray["dbo_TIPOEMPLEADO"]["Spanish"]["id_tipo"] = "";
				fieldLabelsArray["dbo_TIPOEMPLEADO"]["Spanish"]["tipo_empleado"] = "Tipo Empleado";
				fieldToolTipsArray["dbo_TIPOEMPLEADO"]["Spanish"]["tipo_empleado"] = "";
				placeHoldersArray["dbo_TIPOEMPLEADO"]["Spanish"]["tipo_empleado"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["dbo_TIPOEMPLEADO"]["Spanish"])))
				{
					tdataArray["dbo_TIPOEMPLEADO"][".isUseToolTips"] = true;
				}
			}
			tdataArray["dbo_TIPOEMPLEADO"][".NCSearch"] = true;
			tdataArray["dbo_TIPOEMPLEADO"][".shortTableName"] = "dbo_TIPOEMPLEADO";
			tdataArray["dbo_TIPOEMPLEADO"][".nSecOptions"] = 0;
			tdataArray["dbo_TIPOEMPLEADO"][".mainTableOwnerID"] = "";
			tdataArray["dbo_TIPOEMPLEADO"][".entityType"] = 0;
			tdataArray["dbo_TIPOEMPLEADO"][".strOriginalTableName"] = "dbo.TIPOEMPLEADO";
			tdataArray["dbo_TIPOEMPLEADO"][".showAddInPopup"] = false;
			tdataArray["dbo_TIPOEMPLEADO"][".showEditInPopup"] = false;
			tdataArray["dbo_TIPOEMPLEADO"][".showViewInPopup"] = false;
			popupPagesLayoutNames = SettingsMap.GetArray();
			tdataArray["dbo_TIPOEMPLEADO"][".popupPagesLayoutNames"] = popupPagesLayoutNames;
			tdataArray["dbo_TIPOEMPLEADO"][".listAjax"] = false;
			tdataArray["dbo_TIPOEMPLEADO"][".listAjax"] = false;
			tdataArray["dbo_TIPOEMPLEADO"][".audit"] = true;
			tdataArray["dbo_TIPOEMPLEADO"][".locking"] = false;
			GlobalVars.pages = tdataArray["dbo_TIPOEMPLEADO"][".pages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["dbo_TIPOEMPLEADO"][".edit"] = true;
				tdataArray["dbo_TIPOEMPLEADO"][".afterEditAction"] = 1;
				tdataArray["dbo_TIPOEMPLEADO"][".closePopupAfterEdit"] = 1;
				tdataArray["dbo_TIPOEMPLEADO"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["dbo_TIPOEMPLEADO"][".add"] = true;
				tdataArray["dbo_TIPOEMPLEADO"][".afterAddAction"] = 1;
				tdataArray["dbo_TIPOEMPLEADO"][".closePopupAfterAdd"] = 1;
				tdataArray["dbo_TIPOEMPLEADO"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["dbo_TIPOEMPLEADO"][".list"] = true;
			}
			tdataArray["dbo_TIPOEMPLEADO"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["dbo_TIPOEMPLEADO"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["dbo_TIPOEMPLEADO"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["dbo_TIPOEMPLEADO"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["dbo_TIPOEMPLEADO"][".printFriendly"] = true;
			}
			tdataArray["dbo_TIPOEMPLEADO"][".showSimpleSearchOptions"] = true;
			tdataArray["dbo_TIPOEMPLEADO"][".allowShowHideFields"] = true;
			tdataArray["dbo_TIPOEMPLEADO"][".allowFieldsReordering"] = true;
			tdataArray["dbo_TIPOEMPLEADO"][".isUseAjaxSuggest"] = true;
			tdataArray["dbo_TIPOEMPLEADO"][".rowHighlite"] = true;


			tdataArray["dbo_TIPOEMPLEADO"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["dbo_TIPOEMPLEADO"][".buttonsAdded"] = false;
			tdataArray["dbo_TIPOEMPLEADO"][".addPageEvents"] = false;
			tdataArray["dbo_TIPOEMPLEADO"][".isUseTimeForSearch"] = false;
			tdataArray["dbo_TIPOEMPLEADO"][".badgeColor"] = "008B8B";
			tdataArray["dbo_TIPOEMPLEADO"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["dbo_TIPOEMPLEADO"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["dbo_TIPOEMPLEADO"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["dbo_TIPOEMPLEADO"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["dbo_TIPOEMPLEADO"][".googleLikeFields"].Add("id_tipo");
			tdataArray["dbo_TIPOEMPLEADO"][".googleLikeFields"].Add("tipo_empleado");
			tdataArray["dbo_TIPOEMPLEADO"][".tableType"] = "list";
			tdataArray["dbo_TIPOEMPLEADO"][".printerPageOrientation"] = 0;
			tdataArray["dbo_TIPOEMPLEADO"][".nPrinterPageScale"] = 100;
			tdataArray["dbo_TIPOEMPLEADO"][".nPrinterSplitRecords"] = 40;
			tdataArray["dbo_TIPOEMPLEADO"][".nPrinterPDFSplitRecords"] = 40;
			tdataArray["dbo_TIPOEMPLEADO"][".geocodingEnabled"] = false;
			tdataArray["dbo_TIPOEMPLEADO"][".pageSize"] = 20;
			tdataArray["dbo_TIPOEMPLEADO"][".warnLeavingPages"] = true;
			tstrOrderBy = "";
			if(MVCFunctions.strlen(tstrOrderBy) && MVCFunctions.strtolower(MVCFunctions.substr(tstrOrderBy, new XVar(0), new XVar(8))) != "order by")
			{
				tstrOrderBy = MVCFunctions.Concat("order by ", tstrOrderBy);
			}
			tdataArray["dbo_TIPOEMPLEADO"][".strOrderBy"] = tstrOrderBy;
			tdataArray["dbo_TIPOEMPLEADO"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["dbo_TIPOEMPLEADO"][".sqlHead"] = "SELECT id_tipo,  	tipo_empleado";
			tdataArray["dbo_TIPOEMPLEADO"][".sqlFrom"] = "FROM dbo.TIPOEMPLEADO";
			tdataArray["dbo_TIPOEMPLEADO"][".sqlWhereExpr"] = "";
			tdataArray["dbo_TIPOEMPLEADO"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["dbo_TIPOEMPLEADO"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["dbo_TIPOEMPLEADO"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["dbo_TIPOEMPLEADO"][".highlightSearchResults"] = true;
			tableKeysArray["dbo_TIPOEMPLEADO"] = SettingsMap.GetArray();
			tableKeysArray["dbo_TIPOEMPLEADO"].Add("id_tipo");
			tdataArray["dbo_TIPOEMPLEADO"][".Keys"] = tableKeysArray["dbo_TIPOEMPLEADO"];
			tdataArray["dbo_TIPOEMPLEADO"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "id_tipo";
			fdata["GoodName"] = "id_tipo";
			fdata["ownerTable"] = "dbo.TIPOEMPLEADO";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_TIPOEMPLEADO","id_tipo");
			fdata["FieldType"] = 3;
			fdata["AutoInc"] = true;
			fdata["strField"] = "id_tipo";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "id_tipo";
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
			tdataArray["dbo_TIPOEMPLEADO"]["id_tipo"] = fdata;
			tdataArray["dbo_TIPOEMPLEADO"][".searchableFields"].Add("id_tipo");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "tipo_empleado";
			fdata["GoodName"] = "tipo_empleado";
			fdata["ownerTable"] = "dbo.TIPOEMPLEADO";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_TIPOEMPLEADO","tipo_empleado");
			fdata["FieldType"] = 200;
			fdata["strField"] = "tipo_empleado";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "tipo_empleado";
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
			tdataArray["dbo_TIPOEMPLEADO"]["tipo_empleado"] = fdata;
			tdataArray["dbo_TIPOEMPLEADO"][".searchableFields"].Add("tipo_empleado");
			GlobalVars.tables_data["dbo.TIPOEMPLEADO"] = tdataArray["dbo_TIPOEMPLEADO"];
			GlobalVars.field_labels["dbo_TIPOEMPLEADO"] = fieldLabelsArray["dbo_TIPOEMPLEADO"];
			GlobalVars.fieldToolTips["dbo_TIPOEMPLEADO"] = fieldToolTipsArray["dbo_TIPOEMPLEADO"];
			GlobalVars.placeHolders["dbo_TIPOEMPLEADO"] = placeHoldersArray["dbo_TIPOEMPLEADO"];
			GlobalVars.page_titles["dbo_TIPOEMPLEADO"] = pageTitlesArray["dbo_TIPOEMPLEADO"];
			GlobalVars.detailsTablesData["dbo.TIPOEMPLEADO"] = SettingsMap.GetArray();


			dIndex = 0;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "dbo.EMPLEADO";
			detailsParam["dOriginalTable"] = "dbo.EMPLEADO";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "dbo_EMPLEADO";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("dbo_EMPLEADO"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.TIPOEMPLEADO"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["dbo.TIPOEMPLEADO"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.TIPOEMPLEADO"][dIndex]["masterKeys"].Add("id_tipo");
			GlobalVars.detailsTablesData["dbo.TIPOEMPLEADO"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.TIPOEMPLEADO"][dIndex]["detailKeys"].Add("id_tipo");


			dIndex = 1;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "Saldo_Horas_Empleado";
			detailsParam["dOriginalTable"] = "dbo.EMPLEADO";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "Saldo_Horas_Empleado";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("Saldo_Horas_Empleado"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.TIPOEMPLEADO"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["dbo.TIPOEMPLEADO"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.TIPOEMPLEADO"][dIndex]["masterKeys"].Add("id_tipo");
			GlobalVars.detailsTablesData["dbo.TIPOEMPLEADO"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.TIPOEMPLEADO"][dIndex]["detailKeys"].Add("id_tipo");
			GlobalVars.masterTablesData["dbo.TIPOEMPLEADO"] = SettingsMap.GetArray();

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "id_tipo,  	tipo_empleado";
protoArray["0"]["m_strFrom"] = "FROM dbo.TIPOEMPLEADO";
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
obj = new SQLField(new XVar("m_strName", "id_tipo", "m_strTable", "dbo.TIPOEMPLEADO", "m_srcTableName", "dbo.TIPOEMPLEADO"));

protoArray["6"]["m_sql"] = "id_tipo";
protoArray["6"]["m_srcTableName"] = "dbo.TIPOEMPLEADO";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "tipo_empleado", "m_strTable", "dbo.TIPOEMPLEADO", "m_srcTableName", "dbo.TIPOEMPLEADO"));

protoArray["8"]["m_sql"] = "tipo_empleado";
protoArray["8"]["m_srcTableName"] = "dbo.TIPOEMPLEADO";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["10"] = SettingsMap.GetArray();
protoArray["10"]["m_link"] = "SQLL_MAIN";
protoArray["11"] = SettingsMap.GetArray();
protoArray["11"]["m_strName"] = "dbo.TIPOEMPLEADO";
protoArray["11"]["m_srcTableName"] = "dbo.TIPOEMPLEADO";
protoArray["11"]["m_columns"] = SettingsMap.GetArray();
protoArray["11"]["m_columns"].Add("id_tipo");
protoArray["11"]["m_columns"].Add("tipo_empleado");
obj = new SQLTable(protoArray["11"]);

protoArray["10"]["m_table"] = obj;
protoArray["10"]["m_sql"] = "dbo.TIPOEMPLEADO";
protoArray["10"]["m_alias"] = "";
protoArray["10"]["m_srcTableName"] = "dbo.TIPOEMPLEADO";
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
protoArray["0"]["m_srcTableName"] = "dbo.TIPOEMPLEADO";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["dbo_TIPOEMPLEADO"] = obj;

				
		
			tdataArray["dbo_TIPOEMPLEADO"][".sqlquery"] = queryData_Array["dbo_TIPOEMPLEADO"];
			GlobalVars.tableEvents["dbo.TIPOEMPLEADO"] = new eventsBase();
			tdataArray["dbo_TIPOEMPLEADO"][".hasEvents"] = false;
			GlobalVars.tables_data["dbo_TIPOEMPLEADO"] = tdataArray["dbo_TIPOEMPLEADO"];
		}
	}

}
