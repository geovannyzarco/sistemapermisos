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
	public static partial class Settings_admin_members
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), popupPagesLayoutNames = SettingsMap.GetArray(), query = null, queryData_Array = new XVar(), reportGroupFields = SettingsMap.GetArray(), rgroupField = SettingsMap.GetArray(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["admin_members"] = SettingsMap.GetArray();
			tdataArray["admin_members"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["admin_members"][".truncateText"] = true;
			tdataArray["admin_members"][".NumberOfChars"] = 80;
			tdataArray["admin_members"][".ShortName"] = "admin_members";
			tdataArray["admin_members"][".OwnerID"] = "";
			tdataArray["admin_members"][".OriginalTable"] = "dbo.EMPLEADO";
			GlobalVars.defaultPages = MVCFunctions.my_json_decode(new XVar("{\"search\":\"search\"}"));
			tdataArray["admin_members"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"search\":[\"search\"]}")));
			tdataArray["admin_members"][".defaultPages"] = GlobalVars.defaultPages;
			fieldLabelsArray["admin_members"] = SettingsMap.GetArray();
			fieldToolTipsArray["admin_members"] = SettingsMap.GetArray();
			pageTitlesArray["admin_members"] = SettingsMap.GetArray();
			placeHoldersArray["admin_members"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "Spanish")
			{
				fieldLabelsArray["admin_members"]["Spanish"] = SettingsMap.GetArray();
				fieldToolTipsArray["admin_members"]["Spanish"] = SettingsMap.GetArray();
				placeHoldersArray["admin_members"]["Spanish"] = SettingsMap.GetArray();
				pageTitlesArray["admin_members"]["Spanish"] = SettingsMap.GetArray();
				fieldLabelsArray["admin_members"]["Spanish"]["foto"] = "Foto";
				fieldToolTipsArray["admin_members"]["Spanish"]["foto"] = "";
				placeHoldersArray["admin_members"]["Spanish"]["foto"] = "";
				fieldLabelsArray["admin_members"]["Spanish"]["ONI"] = "ONI";
				fieldToolTipsArray["admin_members"]["Spanish"]["ONI"] = "";
				placeHoldersArray["admin_members"]["Spanish"]["ONI"] = "";
				fieldLabelsArray["admin_members"]["Spanish"]["nombre"] = "Nombre";
				fieldToolTipsArray["admin_members"]["Spanish"]["nombre"] = "";
				placeHoldersArray["admin_members"]["Spanish"]["nombre"] = "";
				fieldLabelsArray["admin_members"]["Spanish"]["password"] = "Password";
				fieldToolTipsArray["admin_members"]["Spanish"]["password"] = "";
				placeHoldersArray["admin_members"]["Spanish"]["password"] = "";
				fieldLabelsArray["admin_members"]["Spanish"]["id_tipo"] = "Tipo de Empleado";
				fieldToolTipsArray["admin_members"]["Spanish"]["id_tipo"] = "";
				placeHoldersArray["admin_members"]["Spanish"]["id_tipo"] = "";
				fieldLabelsArray["admin_members"]["Spanish"]["id_departamento"] = "Departamento";
				fieldToolTipsArray["admin_members"]["Spanish"]["id_departamento"] = "";
				placeHoldersArray["admin_members"]["Spanish"]["id_departamento"] = "";
				fieldLabelsArray["admin_members"]["Spanish"]["id_horarios"] = "Horarios";
				fieldToolTipsArray["admin_members"]["Spanish"]["id_horarios"] = "";
				placeHoldersArray["admin_members"]["Spanish"]["id_horarios"] = "";
				fieldLabelsArray["admin_members"]["Spanish"]["saldo_personales"] = "Saldo Horas Personales";
				fieldToolTipsArray["admin_members"]["Spanish"]["saldo_personales"] = "";
				placeHoldersArray["admin_members"]["Spanish"]["saldo_personales"] = "";
				fieldLabelsArray["admin_members"]["Spanish"]["saldo_compesado"] = "Saldo Horas Compesado";
				fieldToolTipsArray["admin_members"]["Spanish"]["saldo_compesado"] = "";
				placeHoldersArray["admin_members"]["Spanish"]["saldo_compesado"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["admin_members"]["Spanish"])))
				{
					tdataArray["admin_members"][".isUseToolTips"] = true;
				}
			}
			tdataArray["admin_members"][".NCSearch"] = true;
			tdataArray["admin_members"][".shortTableName"] = "admin_members";
			tdataArray["admin_members"][".nSecOptions"] = 0;
			tdataArray["admin_members"][".mainTableOwnerID"] = "";
			tdataArray["admin_members"][".entityType"] = 1;
			tdataArray["admin_members"][".strOriginalTableName"] = "dbo.EMPLEADO";
			tdataArray["admin_members"][".showAddInPopup"] = false;
			tdataArray["admin_members"][".showEditInPopup"] = false;
			tdataArray["admin_members"][".showViewInPopup"] = false;
			popupPagesLayoutNames = SettingsMap.GetArray();
			tdataArray["admin_members"][".popupPagesLayoutNames"] = popupPagesLayoutNames;
			tdataArray["admin_members"][".listAjax"] = false;
			tdataArray["admin_members"][".listAjax"] = false;
			tdataArray["admin_members"][".audit"] = true;
			tdataArray["admin_members"][".locking"] = false;
			GlobalVars.pages = tdataArray["admin_members"][".pages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["admin_members"][".edit"] = true;
				tdataArray["admin_members"][".afterEditAction"] = 1;
				tdataArray["admin_members"][".closePopupAfterEdit"] = 1;
				tdataArray["admin_members"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["admin_members"][".add"] = true;
				tdataArray["admin_members"][".afterAddAction"] = 1;
				tdataArray["admin_members"][".closePopupAfterAdd"] = 1;
				tdataArray["admin_members"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["admin_members"][".list"] = true;
			}
			tdataArray["admin_members"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["admin_members"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["admin_members"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["admin_members"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["admin_members"][".printFriendly"] = true;
			}
			tdataArray["admin_members"][".showSimpleSearchOptions"] = true;
			tdataArray["admin_members"][".allowShowHideFields"] = true;
			tdataArray["admin_members"][".allowFieldsReordering"] = true;
			tdataArray["admin_members"][".isUseAjaxSuggest"] = true;
			tdataArray["admin_members"][".rowHighlite"] = true;


			tdataArray["admin_members"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["admin_members"][".buttonsAdded"] = false;
			tdataArray["admin_members"][".addPageEvents"] = false;
			tdataArray["admin_members"][".isUseTimeForSearch"] = false;
			tdataArray["admin_members"][".badgeColor"] = "4682B4";
			tdataArray["admin_members"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["admin_members"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["admin_members"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["admin_members"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["admin_members"][".googleLikeFields"].Add("foto");
			tdataArray["admin_members"][".googleLikeFields"].Add("ONI");
			tdataArray["admin_members"][".googleLikeFields"].Add("nombre");
			tdataArray["admin_members"][".googleLikeFields"].Add("password");
			tdataArray["admin_members"][".googleLikeFields"].Add("id_tipo");
			tdataArray["admin_members"][".googleLikeFields"].Add("id_departamento");
			tdataArray["admin_members"][".googleLikeFields"].Add("id_horarios");
			tdataArray["admin_members"][".googleLikeFields"].Add("saldo_personales");
			tdataArray["admin_members"][".googleLikeFields"].Add("saldo_compesado");
			tdataArray["admin_members"][".tableType"] = "list";
			tdataArray["admin_members"][".printerPageOrientation"] = 0;
			tdataArray["admin_members"][".nPrinterPageScale"] = 100;
			tdataArray["admin_members"][".nPrinterSplitRecords"] = 40;
			tdataArray["admin_members"][".nPrinterPDFSplitRecords"] = 40;
			tdataArray["admin_members"][".geocodingEnabled"] = false;
			tdataArray["admin_members"][".pageSize"] = 20;
			tdataArray["admin_members"][".warnLeavingPages"] = true;
			tstrOrderBy = "";
			if(MVCFunctions.strlen(tstrOrderBy) && MVCFunctions.strtolower(MVCFunctions.substr(tstrOrderBy, new XVar(0), new XVar(8))) != "order by")
			{
				tstrOrderBy = MVCFunctions.Concat("order by ", tstrOrderBy);
			}
			tdataArray["admin_members"][".strOrderBy"] = tstrOrderBy;
			tdataArray["admin_members"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["admin_members"][".sqlHead"] = "SELECT foto,	  ONI,  	nombre,  	password,  	id_tipo,  	id_departamento,  	id_horarios,  	saldo_personales,  	saldo_compesado";
			tdataArray["admin_members"][".sqlFrom"] = "FROM dbo.EMPLEADO";
			tdataArray["admin_members"][".sqlWhereExpr"] = "";
			tdataArray["admin_members"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["admin_members"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["admin_members"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["admin_members"][".highlightSearchResults"] = true;
			tableKeysArray["admin_members"] = SettingsMap.GetArray();
			tableKeysArray["admin_members"].Add("ONI");
			tdataArray["admin_members"][".Keys"] = tableKeysArray["admin_members"];
			tdataArray["admin_members"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "foto";
			fdata["GoodName"] = "foto";
			fdata["ownerTable"] = "dbo.EMPLEADO";
			fdata["Label"] = CommonFunctions.GetFieldLabel("admin_members","foto");
			fdata["FieldType"] = 200;
			fdata["strField"] = "foto";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "foto";
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
			edata["EditParams"] = MVCFunctions.Concat(edata["EditParams"], " maxlength=1000");
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
			tdataArray["admin_members"]["foto"] = fdata;
			tdataArray["admin_members"][".searchableFields"].Add("foto");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "ONI";
			fdata["GoodName"] = "ONI";
			fdata["ownerTable"] = "dbo.EMPLEADO";
			fdata["Label"] = CommonFunctions.GetFieldLabel("admin_members","ONI");
			fdata["FieldType"] = 200;
			fdata["strField"] = "ONI";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "ONI";
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
			edata["EditParams"] = MVCFunctions.Concat(edata["EditParams"], " maxlength=15");
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
			tdataArray["admin_members"]["ONI"] = fdata;
			tdataArray["admin_members"][".searchableFields"].Add("ONI");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 3;
			fdata["strName"] = "nombre";
			fdata["GoodName"] = "nombre";
			fdata["ownerTable"] = "dbo.EMPLEADO";
			fdata["Label"] = CommonFunctions.GetFieldLabel("admin_members","nombre");
			fdata["FieldType"] = 200;
			fdata["strField"] = "nombre";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "nombre";
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
			tdataArray["admin_members"]["nombre"] = fdata;
			tdataArray["admin_members"][".searchableFields"].Add("nombre");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 4;
			fdata["strName"] = "password";
			fdata["GoodName"] = "password";
			fdata["ownerTable"] = "dbo.EMPLEADO";
			fdata["Label"] = CommonFunctions.GetFieldLabel("admin_members","password");
			fdata["FieldType"] = 200;
			fdata["strField"] = "password";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "password";
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
			tdataArray["admin_members"]["password"] = fdata;
			tdataArray["admin_members"][".searchableFields"].Add("password");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 5;
			fdata["strName"] = "id_tipo";
			fdata["GoodName"] = "id_tipo";
			fdata["ownerTable"] = "dbo.EMPLEADO";
			fdata["Label"] = CommonFunctions.GetFieldLabel("admin_members","id_tipo");
			fdata["FieldType"] = 3;
			fdata["strField"] = "id_tipo";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "id_tipo";
			fdata["UploadFolder"] = "files";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "");
			vdata["NeedEncode"] = true;
			fdata["ViewFormats"]["view"] = vdata;
			fdata["EditFormats"] = SettingsMap.GetArray();
			edata = new XVar("EditFormat", "Lookup wizard");
			edata["LookupType"] = 2;
			edata["LookupTable"] = "dbo.TIPOEMPLEADO";
			edata["autoCompleteFieldsOnEdit"] = 0;
			edata["autoCompleteFields"] = SettingsMap.GetArray();
			edata["LCType"] = 0;
			edata["LinkField"] = "id_tipo";
			edata["LinkFieldType"] = 0;
			edata["DisplayField"] = "tipo_empleado";
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
			tdataArray["admin_members"]["id_tipo"] = fdata;
			tdataArray["admin_members"][".searchableFields"].Add("id_tipo");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 6;
			fdata["strName"] = "id_departamento";
			fdata["GoodName"] = "id_departamento";
			fdata["ownerTable"] = "dbo.EMPLEADO";
			fdata["Label"] = CommonFunctions.GetFieldLabel("admin_members","id_departamento");
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
			tdataArray["admin_members"]["id_departamento"] = fdata;
			tdataArray["admin_members"][".searchableFields"].Add("id_departamento");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 7;
			fdata["strName"] = "id_horarios";
			fdata["GoodName"] = "id_horarios";
			fdata["ownerTable"] = "dbo.EMPLEADO";
			fdata["Label"] = CommonFunctions.GetFieldLabel("admin_members","id_horarios");
			fdata["FieldType"] = 3;
			fdata["strField"] = "id_horarios";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "id_horarios";
			fdata["UploadFolder"] = "files";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "");
			vdata["NeedEncode"] = true;
			fdata["ViewFormats"]["view"] = vdata;
			fdata["EditFormats"] = SettingsMap.GetArray();
			edata = new XVar("EditFormat", "Lookup wizard");
			edata["LookupType"] = 2;
			edata["LookupTable"] = "dbo.HORARIOS";
			edata["autoCompleteFieldsOnEdit"] = 0;
			edata["autoCompleteFields"] = SettingsMap.GetArray();
			edata["LCType"] = 0;
			edata["LinkField"] = "id_horarios";
			edata["LinkFieldType"] = 0;
			edata["DisplayField"] = "horarios";
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
			tdataArray["admin_members"]["id_horarios"] = fdata;
			tdataArray["admin_members"][".searchableFields"].Add("id_horarios");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 8;
			fdata["strName"] = "saldo_personales";
			fdata["GoodName"] = "saldo_personales";
			fdata["ownerTable"] = "dbo.EMPLEADO";
			fdata["Label"] = CommonFunctions.GetFieldLabel("admin_members","saldo_personales");
			fdata["FieldType"] = 3;
			fdata["strField"] = "saldo_personales";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "saldo_personales";
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
			tdataArray["admin_members"]["saldo_personales"] = fdata;
			tdataArray["admin_members"][".searchableFields"].Add("saldo_personales");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 9;
			fdata["strName"] = "saldo_compesado";
			fdata["GoodName"] = "saldo_compesado";
			fdata["ownerTable"] = "dbo.EMPLEADO";
			fdata["Label"] = CommonFunctions.GetFieldLabel("admin_members","saldo_compesado");
			fdata["FieldType"] = 200;
			fdata["strField"] = "saldo_compesado";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "saldo_compesado";
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
			edata["EditParams"] = MVCFunctions.Concat(edata["EditParams"], " maxlength=1");
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
			tdataArray["admin_members"]["saldo_compesado"] = fdata;
			tdataArray["admin_members"][".searchableFields"].Add("saldo_compesado");
			GlobalVars.tables_data["admin_members"] = tdataArray["admin_members"];
			GlobalVars.field_labels["admin_members"] = fieldLabelsArray["admin_members"];
			GlobalVars.fieldToolTips["admin_members"] = fieldToolTipsArray["admin_members"];
			GlobalVars.placeHolders["admin_members"] = placeHoldersArray["admin_members"];
			GlobalVars.page_titles["admin_members"] = pageTitlesArray["admin_members"];
			GlobalVars.detailsTablesData["admin_members"] = SettingsMap.GetArray();


			dIndex = 0;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "dbo.REGISTRO_HORAS_COMPESADAS";
			detailsParam["dOriginalTable"] = "dbo.REGISTRO_HORAS_COMPESADAS";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "dbo_REGISTRO_HORAS_COMPESADAS";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("dbo_REGISTRO_HORAS_COMPESADAS"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["admin_members"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["admin_members"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["admin_members"][dIndex]["masterKeys"].Add("ONI");
			GlobalVars.detailsTablesData["admin_members"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["admin_members"][dIndex]["detailKeys"].Add("ONI");


			dIndex = 1;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "dbo.Permisos2";
			detailsParam["dOriginalTable"] = "dbo.Permisos2";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "dbo_Permisos2";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("dbo_Permisos2"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["admin_members"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["admin_members"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["admin_members"][dIndex]["masterKeys"].Add("ONI");
			GlobalVars.detailsTablesData["admin_members"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["admin_members"][dIndex]["detailKeys"].Add("ONI");
			GlobalVars.masterTablesData["admin_members"] = SettingsMap.GetArray();

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "foto,	  ONI,  	nombre,  	password,  	id_tipo,  	id_departamento,  	id_horarios,  	saldo_personales,  	saldo_compesado";
protoArray["0"]["m_strFrom"] = "FROM dbo.EMPLEADO";
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
obj = new SQLField(new XVar("m_strName", "foto", "m_strTable", "dbo.EMPLEADO", "m_srcTableName", "admin_members"));

protoArray["6"]["m_sql"] = "foto";
protoArray["6"]["m_srcTableName"] = "admin_members";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "ONI", "m_strTable", "dbo.EMPLEADO", "m_srcTableName", "admin_members"));

protoArray["8"]["m_sql"] = "ONI";
protoArray["8"]["m_srcTableName"] = "admin_members";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["10"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "nombre", "m_strTable", "dbo.EMPLEADO", "m_srcTableName", "admin_members"));

protoArray["10"]["m_sql"] = "nombre";
protoArray["10"]["m_srcTableName"] = "admin_members";
protoArray["10"]["m_expr"] = obj;
protoArray["10"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["10"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["12"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "password", "m_strTable", "dbo.EMPLEADO", "m_srcTableName", "admin_members"));

protoArray["12"]["m_sql"] = "password";
protoArray["12"]["m_srcTableName"] = "admin_members";
protoArray["12"]["m_expr"] = obj;
protoArray["12"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["12"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["14"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "id_tipo", "m_strTable", "dbo.EMPLEADO", "m_srcTableName", "admin_members"));

protoArray["14"]["m_sql"] = "id_tipo";
protoArray["14"]["m_srcTableName"] = "admin_members";
protoArray["14"]["m_expr"] = obj;
protoArray["14"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["14"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["16"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "id_departamento", "m_strTable", "dbo.EMPLEADO", "m_srcTableName", "admin_members"));

protoArray["16"]["m_sql"] = "id_departamento";
protoArray["16"]["m_srcTableName"] = "admin_members";
protoArray["16"]["m_expr"] = obj;
protoArray["16"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["16"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["18"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "id_horarios", "m_strTable", "dbo.EMPLEADO", "m_srcTableName", "admin_members"));

protoArray["18"]["m_sql"] = "id_horarios";
protoArray["18"]["m_srcTableName"] = "admin_members";
protoArray["18"]["m_expr"] = obj;
protoArray["18"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["18"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["20"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "saldo_personales", "m_strTable", "dbo.EMPLEADO", "m_srcTableName", "admin_members"));

protoArray["20"]["m_sql"] = "saldo_personales";
protoArray["20"]["m_srcTableName"] = "admin_members";
protoArray["20"]["m_expr"] = obj;
protoArray["20"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["20"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["22"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "saldo_compesado", "m_strTable", "dbo.EMPLEADO", "m_srcTableName", "admin_members"));

protoArray["22"]["m_sql"] = "saldo_compesado";
protoArray["22"]["m_srcTableName"] = "admin_members";
protoArray["22"]["m_expr"] = obj;
protoArray["22"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["22"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["24"] = SettingsMap.GetArray();
protoArray["24"]["m_link"] = "SQLL_MAIN";
protoArray["25"] = SettingsMap.GetArray();
protoArray["25"]["m_strName"] = "dbo.EMPLEADO";
protoArray["25"]["m_srcTableName"] = "admin_members";
protoArray["25"]["m_columns"] = SettingsMap.GetArray();
protoArray["25"]["m_columns"].Add("ONI");
protoArray["25"]["m_columns"].Add("nombre");
protoArray["25"]["m_columns"].Add("password");
protoArray["25"]["m_columns"].Add("id_tipo");
protoArray["25"]["m_columns"].Add("id_departamento");
protoArray["25"]["m_columns"].Add("id_horarios");
protoArray["25"]["m_columns"].Add("saldo_personales");
protoArray["25"]["m_columns"].Add("saldo_compesado");
protoArray["25"]["m_columns"].Add("foto");
protoArray["25"]["m_columns"].Add("id_grupo");
obj = new SQLTable(protoArray["25"]);

protoArray["24"]["m_table"] = obj;
protoArray["24"]["m_sql"] = "dbo.EMPLEADO";
protoArray["24"]["m_alias"] = "";
protoArray["24"]["m_srcTableName"] = "admin_members";
protoArray["26"] = SettingsMap.GetArray();
protoArray["26"]["m_sql"] = "";
protoArray["26"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLNonParsed(new XVar("m_sql", ""));

protoArray["26"]["m_column"] = obj;
protoArray["26"]["m_contained"] = SettingsMap.GetArray();
protoArray["26"]["m_strCase"] = "";
protoArray["26"]["m_havingmode"] = false;
protoArray["26"]["m_inBrackets"] = false;
protoArray["26"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["26"]);

protoArray["24"]["m_joinon"] = obj;
obj = new SQLFromListItem(protoArray["24"]);

protoArray["0"]["m_fromlist"].Add(obj);
protoArray["0"]["m_groupby"] = SettingsMap.GetArray();
protoArray["0"]["m_orderby"] = SettingsMap.GetArray();
protoArray["0"]["m_srcTableName"] = "admin_members";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["admin_members"] = obj;

				
		
			tdataArray["admin_members"][".sqlquery"] = queryData_Array["admin_members"];
			GlobalVars.tableEvents["admin_members"] = new eventsBase();
			tdataArray["admin_members"][".hasEvents"] = false;
			GlobalVars.tables_data["admin_members"] = tdataArray["admin_members"];
		}
	}

}
