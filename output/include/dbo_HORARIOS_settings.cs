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
	public static partial class Settings_dbo_HORARIOS
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), popupPagesLayoutNames = SettingsMap.GetArray(), query = null, queryData_Array = new XVar(), reportGroupFields = SettingsMap.GetArray(), rgroupField = SettingsMap.GetArray(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["dbo_HORARIOS"] = SettingsMap.GetArray();
			tdataArray["dbo_HORARIOS"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["dbo_HORARIOS"][".truncateText"] = true;
			tdataArray["dbo_HORARIOS"][".NumberOfChars"] = 80;
			tdataArray["dbo_HORARIOS"][".ShortName"] = "dbo_HORARIOS";
			tdataArray["dbo_HORARIOS"][".OwnerID"] = "";
			tdataArray["dbo_HORARIOS"][".OriginalTable"] = "dbo.HORARIOS";
			GlobalVars.defaultPages = MVCFunctions.my_json_decode(new XVar("{\"add\":\"add\",\"edit\":\"edit\",\"export\":\"export\",\"list\":\"list\",\"masterlist\":\"masterlist\",\"masterprint\":\"masterprint\",\"search\":\"search\"}"));
			tdataArray["dbo_HORARIOS"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"add\":[\"add\"],\"edit\":[\"edit\"],\"export\":[\"export\"],\"list\":[\"list\"],\"masterlist\":[\"masterlist\"],\"masterprint\":[\"masterprint\"],\"search\":[\"search\"]}")));
			tdataArray["dbo_HORARIOS"][".defaultPages"] = GlobalVars.defaultPages;
			fieldLabelsArray["dbo_HORARIOS"] = SettingsMap.GetArray();
			fieldToolTipsArray["dbo_HORARIOS"] = SettingsMap.GetArray();
			pageTitlesArray["dbo_HORARIOS"] = SettingsMap.GetArray();
			placeHoldersArray["dbo_HORARIOS"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "Spanish")
			{
				fieldLabelsArray["dbo_HORARIOS"]["Spanish"] = SettingsMap.GetArray();
				fieldToolTipsArray["dbo_HORARIOS"]["Spanish"] = SettingsMap.GetArray();
				placeHoldersArray["dbo_HORARIOS"]["Spanish"] = SettingsMap.GetArray();
				pageTitlesArray["dbo_HORARIOS"]["Spanish"] = SettingsMap.GetArray();
				fieldLabelsArray["dbo_HORARIOS"]["Spanish"]["id_horarios"] = "ID";
				fieldToolTipsArray["dbo_HORARIOS"]["Spanish"]["id_horarios"] = "";
				placeHoldersArray["dbo_HORARIOS"]["Spanish"]["id_horarios"] = "";
				fieldLabelsArray["dbo_HORARIOS"]["Spanish"]["horarios"] = "Horario descricion";
				fieldToolTipsArray["dbo_HORARIOS"]["Spanish"]["horarios"] = "";
				placeHoldersArray["dbo_HORARIOS"]["Spanish"]["horarios"] = "";
				fieldLabelsArray["dbo_HORARIOS"]["Spanish"]["dia_inicio"] = "Dia Inicio";
				fieldToolTipsArray["dbo_HORARIOS"]["Spanish"]["dia_inicio"] = "";
				placeHoldersArray["dbo_HORARIOS"]["Spanish"]["dia_inicio"] = "";
				fieldLabelsArray["dbo_HORARIOS"]["Spanish"]["dia_final"] = "Dia Final";
				fieldToolTipsArray["dbo_HORARIOS"]["Spanish"]["dia_final"] = "";
				placeHoldersArray["dbo_HORARIOS"]["Spanish"]["dia_final"] = "";
				fieldLabelsArray["dbo_HORARIOS"]["Spanish"]["hora_inicio"] = "Hora Inicio";
				fieldToolTipsArray["dbo_HORARIOS"]["Spanish"]["hora_inicio"] = "";
				placeHoldersArray["dbo_HORARIOS"]["Spanish"]["hora_inicio"] = "";
				fieldLabelsArray["dbo_HORARIOS"]["Spanish"]["hora_final"] = "Hora Final";
				fieldToolTipsArray["dbo_HORARIOS"]["Spanish"]["hora_final"] = "";
				placeHoldersArray["dbo_HORARIOS"]["Spanish"]["hora_final"] = "";
				fieldLabelsArray["dbo_HORARIOS"]["Spanish"]["cantidad_horas"] = "Cantidad Horas";
				fieldToolTipsArray["dbo_HORARIOS"]["Spanish"]["cantidad_horas"] = "";
				placeHoldersArray["dbo_HORARIOS"]["Spanish"]["cantidad_horas"] = "";
				fieldLabelsArray["dbo_HORARIOS"]["Spanish"]["horas_permisos_personales"] = "Horas Permisos Personales";
				fieldToolTipsArray["dbo_HORARIOS"]["Spanish"]["horas_permisos_personales"] = "";
				placeHoldersArray["dbo_HORARIOS"]["Spanish"]["horas_permisos_personales"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["dbo_HORARIOS"]["Spanish"])))
				{
					tdataArray["dbo_HORARIOS"][".isUseToolTips"] = true;
				}
			}
			tdataArray["dbo_HORARIOS"][".NCSearch"] = true;
			tdataArray["dbo_HORARIOS"][".shortTableName"] = "dbo_HORARIOS";
			tdataArray["dbo_HORARIOS"][".nSecOptions"] = 0;
			tdataArray["dbo_HORARIOS"][".mainTableOwnerID"] = "";
			tdataArray["dbo_HORARIOS"][".entityType"] = 0;
			tdataArray["dbo_HORARIOS"][".strOriginalTableName"] = "dbo.HORARIOS";
			tdataArray["dbo_HORARIOS"][".showAddInPopup"] = false;
			tdataArray["dbo_HORARIOS"][".showEditInPopup"] = false;
			tdataArray["dbo_HORARIOS"][".showViewInPopup"] = false;
			popupPagesLayoutNames = SettingsMap.GetArray();
			tdataArray["dbo_HORARIOS"][".popupPagesLayoutNames"] = popupPagesLayoutNames;
			tdataArray["dbo_HORARIOS"][".listAjax"] = false;
			tdataArray["dbo_HORARIOS"][".listAjax"] = false;
			tdataArray["dbo_HORARIOS"][".audit"] = true;
			tdataArray["dbo_HORARIOS"][".locking"] = false;
			GlobalVars.pages = tdataArray["dbo_HORARIOS"][".pages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["dbo_HORARIOS"][".edit"] = true;
				tdataArray["dbo_HORARIOS"][".afterEditAction"] = 1;
				tdataArray["dbo_HORARIOS"][".closePopupAfterEdit"] = 1;
				tdataArray["dbo_HORARIOS"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["dbo_HORARIOS"][".add"] = true;
				tdataArray["dbo_HORARIOS"][".afterAddAction"] = 1;
				tdataArray["dbo_HORARIOS"][".closePopupAfterAdd"] = 1;
				tdataArray["dbo_HORARIOS"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["dbo_HORARIOS"][".list"] = true;
			}
			tdataArray["dbo_HORARIOS"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["dbo_HORARIOS"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["dbo_HORARIOS"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["dbo_HORARIOS"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["dbo_HORARIOS"][".printFriendly"] = true;
			}
			tdataArray["dbo_HORARIOS"][".showSimpleSearchOptions"] = true;
			tdataArray["dbo_HORARIOS"][".allowShowHideFields"] = true;
			tdataArray["dbo_HORARIOS"][".allowFieldsReordering"] = true;
			tdataArray["dbo_HORARIOS"][".isUseAjaxSuggest"] = true;
			tdataArray["dbo_HORARIOS"][".rowHighlite"] = true;


			tdataArray["dbo_HORARIOS"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["dbo_HORARIOS"][".buttonsAdded"] = false;
			tdataArray["dbo_HORARIOS"][".addPageEvents"] = false;
			tdataArray["dbo_HORARIOS"][".isUseTimeForSearch"] = true;
			tdataArray["dbo_HORARIOS"][".badgeColor"] = "CFAE83";
			tdataArray["dbo_HORARIOS"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["dbo_HORARIOS"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["dbo_HORARIOS"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["dbo_HORARIOS"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["dbo_HORARIOS"][".googleLikeFields"].Add("id_horarios");
			tdataArray["dbo_HORARIOS"][".googleLikeFields"].Add("horarios");
			tdataArray["dbo_HORARIOS"][".googleLikeFields"].Add("dia_inicio");
			tdataArray["dbo_HORARIOS"][".googleLikeFields"].Add("dia_final");
			tdataArray["dbo_HORARIOS"][".googleLikeFields"].Add("hora_inicio");
			tdataArray["dbo_HORARIOS"][".googleLikeFields"].Add("hora_final");
			tdataArray["dbo_HORARIOS"][".googleLikeFields"].Add("cantidad_horas");
			tdataArray["dbo_HORARIOS"][".googleLikeFields"].Add("horas_permisos_personales");
			tdataArray["dbo_HORARIOS"][".tableType"] = "list";
			tdataArray["dbo_HORARIOS"][".printerPageOrientation"] = 0;
			tdataArray["dbo_HORARIOS"][".nPrinterPageScale"] = 100;
			tdataArray["dbo_HORARIOS"][".nPrinterSplitRecords"] = 40;
			tdataArray["dbo_HORARIOS"][".nPrinterPDFSplitRecords"] = 40;
			tdataArray["dbo_HORARIOS"][".geocodingEnabled"] = false;
			tdataArray["dbo_HORARIOS"][".pageSize"] = 20;
			tdataArray["dbo_HORARIOS"][".warnLeavingPages"] = true;
			tstrOrderBy = "";
			if(MVCFunctions.strlen(tstrOrderBy) && MVCFunctions.strtolower(MVCFunctions.substr(tstrOrderBy, new XVar(0), new XVar(8))) != "order by")
			{
				tstrOrderBy = MVCFunctions.Concat("order by ", tstrOrderBy);
			}
			tdataArray["dbo_HORARIOS"][".strOrderBy"] = tstrOrderBy;
			tdataArray["dbo_HORARIOS"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["dbo_HORARIOS"][".sqlHead"] = "SELECT id_horarios,  	horarios,  	dia_inicio,  	dia_final,  	hora_inicio,  	hora_final,  	cantidad_horas,  	horas_permisos_personales";
			tdataArray["dbo_HORARIOS"][".sqlFrom"] = "FROM dbo.HORARIOS";
			tdataArray["dbo_HORARIOS"][".sqlWhereExpr"] = "";
			tdataArray["dbo_HORARIOS"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["dbo_HORARIOS"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["dbo_HORARIOS"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["dbo_HORARIOS"][".highlightSearchResults"] = true;
			tableKeysArray["dbo_HORARIOS"] = SettingsMap.GetArray();
			tableKeysArray["dbo_HORARIOS"].Add("id_horarios");
			tdataArray["dbo_HORARIOS"][".Keys"] = tableKeysArray["dbo_HORARIOS"];
			tdataArray["dbo_HORARIOS"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "id_horarios";
			fdata["GoodName"] = "id_horarios";
			fdata["ownerTable"] = "dbo.HORARIOS";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_HORARIOS","id_horarios");
			fdata["FieldType"] = 3;
			fdata["AutoInc"] = true;
			fdata["strField"] = "id_horarios";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "id_horarios";
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
			tdataArray["dbo_HORARIOS"]["id_horarios"] = fdata;
			tdataArray["dbo_HORARIOS"][".searchableFields"].Add("id_horarios");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "horarios";
			fdata["GoodName"] = "horarios";
			fdata["ownerTable"] = "dbo.HORARIOS";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_HORARIOS","horarios");
			fdata["FieldType"] = 200;
			fdata["strField"] = "horarios";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "horarios";
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
			edata["EditParams"] = MVCFunctions.Concat(edata["EditParams"], " maxlength=200");
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
			tdataArray["dbo_HORARIOS"]["horarios"] = fdata;
			tdataArray["dbo_HORARIOS"][".searchableFields"].Add("horarios");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 3;
			fdata["strName"] = "dia_inicio";
			fdata["GoodName"] = "dia_inicio";
			fdata["ownerTable"] = "dbo.HORARIOS";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_HORARIOS","dia_inicio");
			fdata["FieldType"] = 200;
			fdata["strField"] = "dia_inicio";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "dia_inicio";
			fdata["UploadFolder"] = "files";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "");
			vdata["NeedEncode"] = true;
			fdata["ViewFormats"]["view"] = vdata;
			fdata["EditFormats"] = SettingsMap.GetArray();
			edata = new XVar("EditFormat", "Lookup wizard");
			edata["LookupType"] = 0;
			edata["autoCompleteFieldsOnEdit"] = 0;
			edata["autoCompleteFields"] = SettingsMap.GetArray();
			edata["LCType"] = 0;
			edata["LookupValues"] = SettingsMap.GetArray();
			edata["LookupValues"].Add("LUNES");
			edata["LookupValues"].Add("MARTES");
			edata["LookupValues"].Add("MIERCOLES");
			edata["LookupValues"].Add("JUEVES");
			edata["LookupValues"].Add("VIERNES");
			edata["LookupValues"].Add("SABADO");
			edata["LookupValues"].Add("DOMINGO");
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
			tdataArray["dbo_HORARIOS"]["dia_inicio"] = fdata;
			tdataArray["dbo_HORARIOS"][".searchableFields"].Add("dia_inicio");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 4;
			fdata["strName"] = "dia_final";
			fdata["GoodName"] = "dia_final";
			fdata["ownerTable"] = "dbo.HORARIOS";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_HORARIOS","dia_final");
			fdata["FieldType"] = 200;
			fdata["strField"] = "dia_final";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "dia_final";
			fdata["UploadFolder"] = "files";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "");
			vdata["NeedEncode"] = true;
			fdata["ViewFormats"]["view"] = vdata;
			fdata["EditFormats"] = SettingsMap.GetArray();
			edata = new XVar("EditFormat", "Lookup wizard");
			edata["LookupType"] = 0;
			edata["autoCompleteFieldsOnEdit"] = 0;
			edata["autoCompleteFields"] = SettingsMap.GetArray();
			edata["LCType"] = 0;
			edata["LookupValues"] = SettingsMap.GetArray();
			edata["LookupValues"].Add("LUNES");
			edata["LookupValues"].Add("MARTES");
			edata["LookupValues"].Add("MIERCOLES");
			edata["LookupValues"].Add("JUEVES");
			edata["LookupValues"].Add("VIERNES");
			edata["LookupValues"].Add("SABADO");
			edata["LookupValues"].Add("DOMINGO");
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
			tdataArray["dbo_HORARIOS"]["dia_final"] = fdata;
			tdataArray["dbo_HORARIOS"][".searchableFields"].Add("dia_final");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 5;
			fdata["strName"] = "hora_inicio";
			fdata["GoodName"] = "hora_inicio";
			fdata["ownerTable"] = "dbo.HORARIOS";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_HORARIOS","hora_inicio");
			fdata["FieldType"] = 134;
			fdata["strField"] = "hora_inicio";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "hora_inicio";
			fdata["UploadFolder"] = "files";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "");
			vdata["NeedEncode"] = true;
			fdata["ViewFormats"]["view"] = vdata;
			fdata["EditFormats"] = SettingsMap.GetArray();
			edata = new XVar("EditFormat", "Time");
			edata["IsRequired"] = true;
			edata["acceptFileTypes"] = ".+$";
			edata["maxNumberOfFiles"] = 1;
			edata["EditParams"] = "";
			edata["controlWidth"] = 200;
			edata["validateAs"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"] = SettingsMap.GetArray();
			edata["validateAs"]["customMessages"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"].Add(CommonFunctions.getJsValidatorName(new XVar("Time")));
			edata["validateAs"]["basicValidate"].Add("IsRequired");
			hours = 24;
			edata["FormatTimeAttrs"] = new XVar("useTimePicker", 1, "hours", hours, "minutes", 1, "showSeconds", 0);
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
			tdataArray["dbo_HORARIOS"]["hora_inicio"] = fdata;
			tdataArray["dbo_HORARIOS"][".searchableFields"].Add("hora_inicio");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 6;
			fdata["strName"] = "hora_final";
			fdata["GoodName"] = "hora_final";
			fdata["ownerTable"] = "dbo.HORARIOS";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_HORARIOS","hora_final");
			fdata["FieldType"] = 134;
			fdata["strField"] = "hora_final";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "hora_final";
			fdata["UploadFolder"] = "files";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "");
			vdata["NeedEncode"] = true;
			fdata["ViewFormats"]["view"] = vdata;
			fdata["EditFormats"] = SettingsMap.GetArray();
			edata = new XVar("EditFormat", "Time");
			edata["IsRequired"] = true;
			edata["acceptFileTypes"] = ".+$";
			edata["maxNumberOfFiles"] = 1;
			edata["EditParams"] = "";
			edata["controlWidth"] = 200;
			edata["validateAs"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"] = SettingsMap.GetArray();
			edata["validateAs"]["customMessages"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"].Add(CommonFunctions.getJsValidatorName(new XVar("Time")));
			edata["validateAs"]["basicValidate"].Add("IsRequired");
			hours = 24;
			edata["FormatTimeAttrs"] = new XVar("useTimePicker", 1, "hours", hours, "minutes", 1, "showSeconds", 0);
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
			tdataArray["dbo_HORARIOS"]["hora_final"] = fdata;
			tdataArray["dbo_HORARIOS"][".searchableFields"].Add("hora_final");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 7;
			fdata["strName"] = "cantidad_horas";
			fdata["GoodName"] = "cantidad_horas";
			fdata["ownerTable"] = "dbo.HORARIOS";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_HORARIOS","cantidad_horas");
			fdata["FieldType"] = 3;
			fdata["strField"] = "cantidad_horas";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "cantidad_horas";
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
			tdataArray["dbo_HORARIOS"]["cantidad_horas"] = fdata;
			tdataArray["dbo_HORARIOS"][".searchableFields"].Add("cantidad_horas");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 8;
			fdata["strName"] = "horas_permisos_personales";
			fdata["GoodName"] = "horas_permisos_personales";
			fdata["ownerTable"] = "dbo.HORARIOS";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_HORARIOS","horas_permisos_personales");
			fdata["FieldType"] = 3;
			fdata["strField"] = "horas_permisos_personales";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "horas_permisos_personales";
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
			tdataArray["dbo_HORARIOS"]["horas_permisos_personales"] = fdata;
			tdataArray["dbo_HORARIOS"][".searchableFields"].Add("horas_permisos_personales");
			GlobalVars.tables_data["dbo.HORARIOS"] = tdataArray["dbo_HORARIOS"];
			GlobalVars.field_labels["dbo_HORARIOS"] = fieldLabelsArray["dbo_HORARIOS"];
			GlobalVars.fieldToolTips["dbo_HORARIOS"] = fieldToolTipsArray["dbo_HORARIOS"];
			GlobalVars.placeHolders["dbo_HORARIOS"] = placeHoldersArray["dbo_HORARIOS"];
			GlobalVars.page_titles["dbo_HORARIOS"] = pageTitlesArray["dbo_HORARIOS"];
			GlobalVars.detailsTablesData["dbo.HORARIOS"] = SettingsMap.GetArray();


			dIndex = 0;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "dbo.EMPLEADO";
			detailsParam["dOriginalTable"] = "dbo.EMPLEADO";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "dbo_EMPLEADO";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("dbo_EMPLEADO"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.HORARIOS"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["dbo.HORARIOS"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.HORARIOS"][dIndex]["masterKeys"].Add("id_horarios");
			GlobalVars.detailsTablesData["dbo.HORARIOS"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.HORARIOS"][dIndex]["detailKeys"].Add("id_horarios");


			dIndex = 1;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "Saldo_Horas_Empleado";
			detailsParam["dOriginalTable"] = "dbo.EMPLEADO";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "Saldo_Horas_Empleado";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("Saldo_Horas_Empleado"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.HORARIOS"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["dbo.HORARIOS"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.HORARIOS"][dIndex]["masterKeys"].Add("id_horarios");
			GlobalVars.detailsTablesData["dbo.HORARIOS"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.HORARIOS"][dIndex]["detailKeys"].Add("id_horarios");
			GlobalVars.masterTablesData["dbo.HORARIOS"] = SettingsMap.GetArray();

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "id_horarios,  	horarios,  	dia_inicio,  	dia_final,  	hora_inicio,  	hora_final,  	cantidad_horas,  	horas_permisos_personales";
protoArray["0"]["m_strFrom"] = "FROM dbo.HORARIOS";
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
obj = new SQLField(new XVar("m_strName", "id_horarios", "m_strTable", "dbo.HORARIOS", "m_srcTableName", "dbo.HORARIOS"));

protoArray["6"]["m_sql"] = "id_horarios";
protoArray["6"]["m_srcTableName"] = "dbo.HORARIOS";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "horarios", "m_strTable", "dbo.HORARIOS", "m_srcTableName", "dbo.HORARIOS"));

protoArray["8"]["m_sql"] = "horarios";
protoArray["8"]["m_srcTableName"] = "dbo.HORARIOS";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["10"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "dia_inicio", "m_strTable", "dbo.HORARIOS", "m_srcTableName", "dbo.HORARIOS"));

protoArray["10"]["m_sql"] = "dia_inicio";
protoArray["10"]["m_srcTableName"] = "dbo.HORARIOS";
protoArray["10"]["m_expr"] = obj;
protoArray["10"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["10"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["12"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "dia_final", "m_strTable", "dbo.HORARIOS", "m_srcTableName", "dbo.HORARIOS"));

protoArray["12"]["m_sql"] = "dia_final";
protoArray["12"]["m_srcTableName"] = "dbo.HORARIOS";
protoArray["12"]["m_expr"] = obj;
protoArray["12"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["12"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["14"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "hora_inicio", "m_strTable", "dbo.HORARIOS", "m_srcTableName", "dbo.HORARIOS"));

protoArray["14"]["m_sql"] = "hora_inicio";
protoArray["14"]["m_srcTableName"] = "dbo.HORARIOS";
protoArray["14"]["m_expr"] = obj;
protoArray["14"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["14"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["16"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "hora_final", "m_strTable", "dbo.HORARIOS", "m_srcTableName", "dbo.HORARIOS"));

protoArray["16"]["m_sql"] = "hora_final";
protoArray["16"]["m_srcTableName"] = "dbo.HORARIOS";
protoArray["16"]["m_expr"] = obj;
protoArray["16"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["16"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["18"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "cantidad_horas", "m_strTable", "dbo.HORARIOS", "m_srcTableName", "dbo.HORARIOS"));

protoArray["18"]["m_sql"] = "cantidad_horas";
protoArray["18"]["m_srcTableName"] = "dbo.HORARIOS";
protoArray["18"]["m_expr"] = obj;
protoArray["18"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["18"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["20"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "horas_permisos_personales", "m_strTable", "dbo.HORARIOS", "m_srcTableName", "dbo.HORARIOS"));

protoArray["20"]["m_sql"] = "horas_permisos_personales";
protoArray["20"]["m_srcTableName"] = "dbo.HORARIOS";
protoArray["20"]["m_expr"] = obj;
protoArray["20"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["20"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["22"] = SettingsMap.GetArray();
protoArray["22"]["m_link"] = "SQLL_MAIN";
protoArray["23"] = SettingsMap.GetArray();
protoArray["23"]["m_strName"] = "dbo.HORARIOS";
protoArray["23"]["m_srcTableName"] = "dbo.HORARIOS";
protoArray["23"]["m_columns"] = SettingsMap.GetArray();
protoArray["23"]["m_columns"].Add("id_horarios");
protoArray["23"]["m_columns"].Add("horarios");
protoArray["23"]["m_columns"].Add("dia_inicio");
protoArray["23"]["m_columns"].Add("dia_final");
protoArray["23"]["m_columns"].Add("hora_inicio");
protoArray["23"]["m_columns"].Add("hora_final");
protoArray["23"]["m_columns"].Add("cantidad_horas");
protoArray["23"]["m_columns"].Add("horas_permisos_personales");
obj = new SQLTable(protoArray["23"]);

protoArray["22"]["m_table"] = obj;
protoArray["22"]["m_sql"] = "dbo.HORARIOS";
protoArray["22"]["m_alias"] = "";
protoArray["22"]["m_srcTableName"] = "dbo.HORARIOS";
protoArray["24"] = SettingsMap.GetArray();
protoArray["24"]["m_sql"] = "";
protoArray["24"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLNonParsed(new XVar("m_sql", ""));

protoArray["24"]["m_column"] = obj;
protoArray["24"]["m_contained"] = SettingsMap.GetArray();
protoArray["24"]["m_strCase"] = "";
protoArray["24"]["m_havingmode"] = false;
protoArray["24"]["m_inBrackets"] = false;
protoArray["24"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["24"]);

protoArray["22"]["m_joinon"] = obj;
obj = new SQLFromListItem(protoArray["22"]);

protoArray["0"]["m_fromlist"].Add(obj);
protoArray["0"]["m_groupby"] = SettingsMap.GetArray();
protoArray["0"]["m_orderby"] = SettingsMap.GetArray();
protoArray["0"]["m_srcTableName"] = "dbo.HORARIOS";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["dbo_HORARIOS"] = obj;

				
		
			tdataArray["dbo_HORARIOS"][".sqlquery"] = queryData_Array["dbo_HORARIOS"];
			GlobalVars.tableEvents["dbo.HORARIOS"] = new eventsBase();
			tdataArray["dbo_HORARIOS"][".hasEvents"] = false;
			GlobalVars.tables_data["dbo_HORARIOS"] = tdataArray["dbo_HORARIOS"];
		}
	}

}
