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
	public static partial class Settings_dbo_TIPOPERMISO
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), popupPagesLayoutNames = SettingsMap.GetArray(), query = null, queryData_Array = new XVar(), reportGroupFields = SettingsMap.GetArray(), rgroupField = SettingsMap.GetArray(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["dbo_TIPOPERMISO"] = SettingsMap.GetArray();
			tdataArray["dbo_TIPOPERMISO"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["dbo_TIPOPERMISO"][".truncateText"] = true;
			tdataArray["dbo_TIPOPERMISO"][".NumberOfChars"] = 80;
			tdataArray["dbo_TIPOPERMISO"][".ShortName"] = "dbo_TIPOPERMISO";
			tdataArray["dbo_TIPOPERMISO"][".OwnerID"] = "";
			tdataArray["dbo_TIPOPERMISO"][".OriginalTable"] = "dbo.TIPOPERMISO";
			GlobalVars.defaultPages = MVCFunctions.my_json_decode(new XVar("{\"add\":\"add\",\"edit\":\"edit\",\"export\":\"export\",\"list\":\"list\",\"masterlist\":\"masterlist\",\"masterprint\":\"masterprint\",\"search\":\"search\"}"));
			tdataArray["dbo_TIPOPERMISO"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"add\":[\"add\"],\"edit\":[\"edit\"],\"export\":[\"export\"],\"list\":[\"list\"],\"masterlist\":[\"masterlist\"],\"masterprint\":[\"masterprint\"],\"search\":[\"search\"]}")));
			tdataArray["dbo_TIPOPERMISO"][".defaultPages"] = GlobalVars.defaultPages;
			fieldLabelsArray["dbo_TIPOPERMISO"] = SettingsMap.GetArray();
			fieldToolTipsArray["dbo_TIPOPERMISO"] = SettingsMap.GetArray();
			pageTitlesArray["dbo_TIPOPERMISO"] = SettingsMap.GetArray();
			placeHoldersArray["dbo_TIPOPERMISO"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "Spanish")
			{
				fieldLabelsArray["dbo_TIPOPERMISO"]["Spanish"] = SettingsMap.GetArray();
				fieldToolTipsArray["dbo_TIPOPERMISO"]["Spanish"] = SettingsMap.GetArray();
				placeHoldersArray["dbo_TIPOPERMISO"]["Spanish"] = SettingsMap.GetArray();
				pageTitlesArray["dbo_TIPOPERMISO"]["Spanish"] = SettingsMap.GetArray();
				fieldLabelsArray["dbo_TIPOPERMISO"]["Spanish"]["id_tipopermiso"] = "ID";
				fieldToolTipsArray["dbo_TIPOPERMISO"]["Spanish"]["id_tipopermiso"] = "";
				placeHoldersArray["dbo_TIPOPERMISO"]["Spanish"]["id_tipopermiso"] = "";
				fieldLabelsArray["dbo_TIPOPERMISO"]["Spanish"]["tipo_permiso"] = "Tipo Permiso";
				fieldToolTipsArray["dbo_TIPOPERMISO"]["Spanish"]["tipo_permiso"] = "";
				placeHoldersArray["dbo_TIPOPERMISO"]["Spanish"]["tipo_permiso"] = "";
				fieldLabelsArray["dbo_TIPOPERMISO"]["Spanish"]["horas_asignada"] = "Cantidad Horas Asignada";
				fieldToolTipsArray["dbo_TIPOPERMISO"]["Spanish"]["horas_asignada"] = "";
				placeHoldersArray["dbo_TIPOPERMISO"]["Spanish"]["horas_asignada"] = "";
				fieldLabelsArray["dbo_TIPOPERMISO"]["Spanish"]["dias_asignados"] = "Cantidad Dias Asignados";
				fieldToolTipsArray["dbo_TIPOPERMISO"]["Spanish"]["dias_asignados"] = "";
				placeHoldersArray["dbo_TIPOPERMISO"]["Spanish"]["dias_asignados"] = "";
				fieldLabelsArray["dbo_TIPOPERMISO"]["Spanish"]["cantidad_permisos"] = "Cantidad Permisos Limite";
				fieldToolTipsArray["dbo_TIPOPERMISO"]["Spanish"]["cantidad_permisos"] = "";
				placeHoldersArray["dbo_TIPOPERMISO"]["Spanish"]["cantidad_permisos"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["dbo_TIPOPERMISO"]["Spanish"])))
				{
					tdataArray["dbo_TIPOPERMISO"][".isUseToolTips"] = true;
				}
			}
			tdataArray["dbo_TIPOPERMISO"][".NCSearch"] = true;
			tdataArray["dbo_TIPOPERMISO"][".shortTableName"] = "dbo_TIPOPERMISO";
			tdataArray["dbo_TIPOPERMISO"][".nSecOptions"] = 0;
			tdataArray["dbo_TIPOPERMISO"][".mainTableOwnerID"] = "";
			tdataArray["dbo_TIPOPERMISO"][".entityType"] = 0;
			tdataArray["dbo_TIPOPERMISO"][".strOriginalTableName"] = "dbo.TIPOPERMISO";
			tdataArray["dbo_TIPOPERMISO"][".showAddInPopup"] = false;
			tdataArray["dbo_TIPOPERMISO"][".showEditInPopup"] = false;
			tdataArray["dbo_TIPOPERMISO"][".showViewInPopup"] = false;
			popupPagesLayoutNames = SettingsMap.GetArray();
			tdataArray["dbo_TIPOPERMISO"][".popupPagesLayoutNames"] = popupPagesLayoutNames;
			tdataArray["dbo_TIPOPERMISO"][".listAjax"] = false;
			tdataArray["dbo_TIPOPERMISO"][".listAjax"] = false;
			tdataArray["dbo_TIPOPERMISO"][".audit"] = true;
			tdataArray["dbo_TIPOPERMISO"][".locking"] = false;
			GlobalVars.pages = tdataArray["dbo_TIPOPERMISO"][".pages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["dbo_TIPOPERMISO"][".edit"] = true;
				tdataArray["dbo_TIPOPERMISO"][".afterEditAction"] = 1;
				tdataArray["dbo_TIPOPERMISO"][".closePopupAfterEdit"] = 1;
				tdataArray["dbo_TIPOPERMISO"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["dbo_TIPOPERMISO"][".add"] = true;
				tdataArray["dbo_TIPOPERMISO"][".afterAddAction"] = 1;
				tdataArray["dbo_TIPOPERMISO"][".closePopupAfterAdd"] = 1;
				tdataArray["dbo_TIPOPERMISO"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["dbo_TIPOPERMISO"][".list"] = true;
			}
			tdataArray["dbo_TIPOPERMISO"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["dbo_TIPOPERMISO"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["dbo_TIPOPERMISO"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["dbo_TIPOPERMISO"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["dbo_TIPOPERMISO"][".printFriendly"] = true;
			}
			tdataArray["dbo_TIPOPERMISO"][".showSimpleSearchOptions"] = true;
			tdataArray["dbo_TIPOPERMISO"][".allowShowHideFields"] = true;
			tdataArray["dbo_TIPOPERMISO"][".allowFieldsReordering"] = true;
			tdataArray["dbo_TIPOPERMISO"][".isUseAjaxSuggest"] = true;
			tdataArray["dbo_TIPOPERMISO"][".rowHighlite"] = true;


			tdataArray["dbo_TIPOPERMISO"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["dbo_TIPOPERMISO"][".buttonsAdded"] = false;
			tdataArray["dbo_TIPOPERMISO"][".addPageEvents"] = false;
			tdataArray["dbo_TIPOPERMISO"][".isUseTimeForSearch"] = false;
			tdataArray["dbo_TIPOPERMISO"][".badgeColor"] = "D2AF80";
			tdataArray["dbo_TIPOPERMISO"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["dbo_TIPOPERMISO"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["dbo_TIPOPERMISO"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["dbo_TIPOPERMISO"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["dbo_TIPOPERMISO"][".googleLikeFields"].Add("id_tipopermiso");
			tdataArray["dbo_TIPOPERMISO"][".googleLikeFields"].Add("tipo_permiso");
			tdataArray["dbo_TIPOPERMISO"][".googleLikeFields"].Add("horas_asignada");
			tdataArray["dbo_TIPOPERMISO"][".googleLikeFields"].Add("dias_asignados");
			tdataArray["dbo_TIPOPERMISO"][".googleLikeFields"].Add("cantidad_permisos");
			tdataArray["dbo_TIPOPERMISO"][".tableType"] = "list";
			tdataArray["dbo_TIPOPERMISO"][".printerPageOrientation"] = 0;
			tdataArray["dbo_TIPOPERMISO"][".nPrinterPageScale"] = 100;
			tdataArray["dbo_TIPOPERMISO"][".nPrinterSplitRecords"] = 40;
			tdataArray["dbo_TIPOPERMISO"][".nPrinterPDFSplitRecords"] = 40;
			tdataArray["dbo_TIPOPERMISO"][".geocodingEnabled"] = false;
			tdataArray["dbo_TIPOPERMISO"][".isDisplayLoading"] = true;
			tdataArray["dbo_TIPOPERMISO"][".pageSize"] = 20;
			tdataArray["dbo_TIPOPERMISO"][".warnLeavingPages"] = true;
			tstrOrderBy = "";
			if(MVCFunctions.strlen(tstrOrderBy) && MVCFunctions.strtolower(MVCFunctions.substr(tstrOrderBy, new XVar(0), new XVar(8))) != "order by")
			{
				tstrOrderBy = MVCFunctions.Concat("order by ", tstrOrderBy);
			}
			tdataArray["dbo_TIPOPERMISO"][".strOrderBy"] = tstrOrderBy;
			tdataArray["dbo_TIPOPERMISO"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["dbo_TIPOPERMISO"][".sqlHead"] = "SELECT id_tipopermiso,  	tipo_permiso,  	horas_asignada,  	dias_asignados,  	cantidad_permisos";
			tdataArray["dbo_TIPOPERMISO"][".sqlFrom"] = "FROM dbo.TIPOPERMISO";
			tdataArray["dbo_TIPOPERMISO"][".sqlWhereExpr"] = "";
			tdataArray["dbo_TIPOPERMISO"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["dbo_TIPOPERMISO"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["dbo_TIPOPERMISO"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["dbo_TIPOPERMISO"][".highlightSearchResults"] = true;
			tableKeysArray["dbo_TIPOPERMISO"] = SettingsMap.GetArray();
			tableKeysArray["dbo_TIPOPERMISO"].Add("id_tipopermiso");
			tdataArray["dbo_TIPOPERMISO"][".Keys"] = tableKeysArray["dbo_TIPOPERMISO"];
			tdataArray["dbo_TIPOPERMISO"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "id_tipopermiso";
			fdata["GoodName"] = "id_tipopermiso";
			fdata["ownerTable"] = "dbo.TIPOPERMISO";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_TIPOPERMISO","id_tipopermiso");
			fdata["FieldType"] = 3;
			fdata["AutoInc"] = true;
			fdata["strField"] = "id_tipopermiso";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "id_tipopermiso";
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
			tdataArray["dbo_TIPOPERMISO"]["id_tipopermiso"] = fdata;
			tdataArray["dbo_TIPOPERMISO"][".searchableFields"].Add("id_tipopermiso");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "tipo_permiso";
			fdata["GoodName"] = "tipo_permiso";
			fdata["ownerTable"] = "dbo.TIPOPERMISO";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_TIPOPERMISO","tipo_permiso");
			fdata["FieldType"] = 200;
			fdata["strField"] = "tipo_permiso";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "tipo_permiso";
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
			edata["validateAs"]["customMessages"]["DenyDuplicated"] = new XVar("message", "Este Permiso %value% ya exite", "messageType", "Text");
			edata["denyDuplicates"] = true;
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
			tdataArray["dbo_TIPOPERMISO"]["tipo_permiso"] = fdata;
			tdataArray["dbo_TIPOPERMISO"][".searchableFields"].Add("tipo_permiso");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 3;
			fdata["strName"] = "horas_asignada";
			fdata["GoodName"] = "horas_asignada";
			fdata["ownerTable"] = "dbo.TIPOPERMISO";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_TIPOPERMISO","horas_asignada");
			fdata["FieldType"] = 3;
			fdata["strField"] = "horas_asignada";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "horas_asignada";
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
			tdataArray["dbo_TIPOPERMISO"]["horas_asignada"] = fdata;
			tdataArray["dbo_TIPOPERMISO"][".searchableFields"].Add("horas_asignada");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 4;
			fdata["strName"] = "dias_asignados";
			fdata["GoodName"] = "dias_asignados";
			fdata["ownerTable"] = "dbo.TIPOPERMISO";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_TIPOPERMISO","dias_asignados");
			fdata["FieldType"] = 3;
			fdata["strField"] = "dias_asignados";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "dias_asignados";
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
			tdataArray["dbo_TIPOPERMISO"]["dias_asignados"] = fdata;
			tdataArray["dbo_TIPOPERMISO"][".searchableFields"].Add("dias_asignados");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 5;
			fdata["strName"] = "cantidad_permisos";
			fdata["GoodName"] = "cantidad_permisos";
			fdata["ownerTable"] = "dbo.TIPOPERMISO";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_TIPOPERMISO","cantidad_permisos");
			fdata["FieldType"] = 3;
			fdata["strField"] = "cantidad_permisos";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "cantidad_permisos";
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
			tdataArray["dbo_TIPOPERMISO"]["cantidad_permisos"] = fdata;
			tdataArray["dbo_TIPOPERMISO"][".searchableFields"].Add("cantidad_permisos");
			GlobalVars.tables_data["dbo.TIPOPERMISO"] = tdataArray["dbo_TIPOPERMISO"];
			GlobalVars.field_labels["dbo_TIPOPERMISO"] = fieldLabelsArray["dbo_TIPOPERMISO"];
			GlobalVars.fieldToolTips["dbo_TIPOPERMISO"] = fieldToolTipsArray["dbo_TIPOPERMISO"];
			GlobalVars.placeHolders["dbo_TIPOPERMISO"] = placeHoldersArray["dbo_TIPOPERMISO"];
			GlobalVars.page_titles["dbo_TIPOPERMISO"] = pageTitlesArray["dbo_TIPOPERMISO"];
			GlobalVars.detailsTablesData["dbo.TIPOPERMISO"] = SettingsMap.GetArray();


			dIndex = 0;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "dbo.Permisos2";
			detailsParam["dOriginalTable"] = "dbo.Permisos2";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "dbo_Permisos2";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("dbo_Permisos2"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.TIPOPERMISO"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["dbo.TIPOPERMISO"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.TIPOPERMISO"][dIndex]["masterKeys"].Add("id_tipopermiso");
			GlobalVars.detailsTablesData["dbo.TIPOPERMISO"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.TIPOPERMISO"][dIndex]["detailKeys"].Add("id_tipopermiso");


			dIndex = 1;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "APROBAR_PERMISOS";
			detailsParam["dOriginalTable"] = "dbo.Permisos2";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "APROBAR_PERMISOS";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("APROBAR_PERMISOS"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.TIPOPERMISO"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["dbo.TIPOPERMISO"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.TIPOPERMISO"][dIndex]["masterKeys"].Add("id_tipopermiso");
			GlobalVars.detailsTablesData["dbo.TIPOPERMISO"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.TIPOPERMISO"][dIndex]["detailKeys"].Add("id_tipopermiso");


			dIndex = 2;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "VISTOBUENO_JEFEINMEDIATO";
			detailsParam["dOriginalTable"] = "dbo.Permisos2";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "VISTOBUENO_JEFEINMEDIATO";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("VISTOBUENO_JEFEINMEDIATO"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.TIPOPERMISO"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["dbo.TIPOPERMISO"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.TIPOPERMISO"][dIndex]["masterKeys"].Add("id_tipopermiso");
			GlobalVars.detailsTablesData["dbo.TIPOPERMISO"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.TIPOPERMISO"][dIndex]["detailKeys"].Add("id_tipopermiso");


			dIndex = 3;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "VISTOBUENO_JEFEDEPARTAMENTO";
			detailsParam["dOriginalTable"] = "dbo.Permisos2";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "VISTOBUENO_JEFEDEPARTAMENTO";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("VISTOBUENO_JEFEDEPARTAMENTO"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.TIPOPERMISO"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["dbo.TIPOPERMISO"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.TIPOPERMISO"][dIndex]["masterKeys"].Add("id_tipopermiso");
			GlobalVars.detailsTablesData["dbo.TIPOPERMISO"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.TIPOPERMISO"][dIndex]["detailKeys"].Add("id_tipopermiso");


			dIndex = 4;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "VER_PERMISOS";
			detailsParam["dOriginalTable"] = "dbo.Permisos2";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "VER_PERMISOS";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("VER_PERMISOS"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.TIPOPERMISO"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["dbo.TIPOPERMISO"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.TIPOPERMISO"][dIndex]["masterKeys"].Add("id_tipopermiso");
			GlobalVars.detailsTablesData["dbo.TIPOPERMISO"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.TIPOPERMISO"][dIndex]["detailKeys"].Add("id_tipopermiso");


			dIndex = 5;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "INGRESAR PERMISO";
			detailsParam["dOriginalTable"] = "dbo.Permisos2";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "INGRESAR_PERMISO";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("INGRESAR_PERMISO"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.TIPOPERMISO"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["dbo.TIPOPERMISO"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.TIPOPERMISO"][dIndex]["masterKeys"].Add("id_tipopermiso");
			GlobalVars.detailsTablesData["dbo.TIPOPERMISO"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.TIPOPERMISO"][dIndex]["detailKeys"].Add("id_tipopermiso");


			dIndex = 6;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "Licencias_sin_goce_sueldo";
			detailsParam["dOriginalTable"] = "dbo.Permisos2";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "Licencias_sin_goce_sueldo";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("Licencias_sin_goce_sueldo"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.TIPOPERMISO"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["dbo.TIPOPERMISO"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.TIPOPERMISO"][dIndex]["masterKeys"].Add("id_tipopermiso");
			GlobalVars.detailsTablesData["dbo.TIPOPERMISO"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.TIPOPERMISO"][dIndex]["detailKeys"].Add("id_tipopermiso");
			GlobalVars.masterTablesData["dbo.TIPOPERMISO"] = SettingsMap.GetArray();

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "id_tipopermiso,  	tipo_permiso,  	horas_asignada,  	dias_asignados,  	cantidad_permisos";
protoArray["0"]["m_strFrom"] = "FROM dbo.TIPOPERMISO";
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
obj = new SQLField(new XVar("m_strName", "id_tipopermiso", "m_strTable", "dbo.TIPOPERMISO", "m_srcTableName", "dbo.TIPOPERMISO"));

protoArray["6"]["m_sql"] = "id_tipopermiso";
protoArray["6"]["m_srcTableName"] = "dbo.TIPOPERMISO";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "tipo_permiso", "m_strTable", "dbo.TIPOPERMISO", "m_srcTableName", "dbo.TIPOPERMISO"));

protoArray["8"]["m_sql"] = "tipo_permiso";
protoArray["8"]["m_srcTableName"] = "dbo.TIPOPERMISO";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["10"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "horas_asignada", "m_strTable", "dbo.TIPOPERMISO", "m_srcTableName", "dbo.TIPOPERMISO"));

protoArray["10"]["m_sql"] = "horas_asignada";
protoArray["10"]["m_srcTableName"] = "dbo.TIPOPERMISO";
protoArray["10"]["m_expr"] = obj;
protoArray["10"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["10"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["12"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "dias_asignados", "m_strTable", "dbo.TIPOPERMISO", "m_srcTableName", "dbo.TIPOPERMISO"));

protoArray["12"]["m_sql"] = "dias_asignados";
protoArray["12"]["m_srcTableName"] = "dbo.TIPOPERMISO";
protoArray["12"]["m_expr"] = obj;
protoArray["12"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["12"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["14"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "cantidad_permisos", "m_strTable", "dbo.TIPOPERMISO", "m_srcTableName", "dbo.TIPOPERMISO"));

protoArray["14"]["m_sql"] = "cantidad_permisos";
protoArray["14"]["m_srcTableName"] = "dbo.TIPOPERMISO";
protoArray["14"]["m_expr"] = obj;
protoArray["14"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["14"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["16"] = SettingsMap.GetArray();
protoArray["16"]["m_link"] = "SQLL_MAIN";
protoArray["17"] = SettingsMap.GetArray();
protoArray["17"]["m_strName"] = "dbo.TIPOPERMISO";
protoArray["17"]["m_srcTableName"] = "dbo.TIPOPERMISO";
protoArray["17"]["m_columns"] = SettingsMap.GetArray();
protoArray["17"]["m_columns"].Add("id_tipopermiso");
protoArray["17"]["m_columns"].Add("tipo_permiso");
protoArray["17"]["m_columns"].Add("horas_asignada");
protoArray["17"]["m_columns"].Add("dias_asignados");
protoArray["17"]["m_columns"].Add("cantidad_permisos");
obj = new SQLTable(protoArray["17"]);

protoArray["16"]["m_table"] = obj;
protoArray["16"]["m_sql"] = "dbo.TIPOPERMISO";
protoArray["16"]["m_alias"] = "";
protoArray["16"]["m_srcTableName"] = "dbo.TIPOPERMISO";
protoArray["18"] = SettingsMap.GetArray();
protoArray["18"]["m_sql"] = "";
protoArray["18"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLNonParsed(new XVar("m_sql", ""));

protoArray["18"]["m_column"] = obj;
protoArray["18"]["m_contained"] = SettingsMap.GetArray();
protoArray["18"]["m_strCase"] = "";
protoArray["18"]["m_havingmode"] = false;
protoArray["18"]["m_inBrackets"] = false;
protoArray["18"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["18"]);

protoArray["16"]["m_joinon"] = obj;
obj = new SQLFromListItem(protoArray["16"]);

protoArray["0"]["m_fromlist"].Add(obj);
protoArray["0"]["m_groupby"] = SettingsMap.GetArray();
protoArray["0"]["m_orderby"] = SettingsMap.GetArray();
protoArray["0"]["m_srcTableName"] = "dbo.TIPOPERMISO";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["dbo_TIPOPERMISO"] = obj;

				
		
			tdataArray["dbo_TIPOPERMISO"][".sqlquery"] = queryData_Array["dbo_TIPOPERMISO"];
			GlobalVars.tableEvents["dbo.TIPOPERMISO"] = new eventsBase();
			tdataArray["dbo_TIPOPERMISO"][".hasEvents"] = false;
			GlobalVars.tables_data["dbo_TIPOPERMISO"] = tdataArray["dbo_TIPOPERMISO"];
		}
	}

}
