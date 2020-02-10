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
	public static partial class Settings_dbo_EMPLEADO
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), popupPagesLayoutNames = SettingsMap.GetArray(), query = null, queryData_Array = new XVar(), reportGroupFields = SettingsMap.GetArray(), rgroupField = SettingsMap.GetArray(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["dbo_EMPLEADO"] = SettingsMap.GetArray();
			tdataArray["dbo_EMPLEADO"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["dbo_EMPLEADO"][".truncateText"] = true;
			tdataArray["dbo_EMPLEADO"][".NumberOfChars"] = 80;
			tdataArray["dbo_EMPLEADO"][".ShortName"] = "dbo_EMPLEADO";
			tdataArray["dbo_EMPLEADO"][".OwnerID"] = "";
			tdataArray["dbo_EMPLEADO"][".OriginalTable"] = "dbo.EMPLEADO";
			GlobalVars.defaultPages = MVCFunctions.my_json_decode(new XVar("{\"add\":\"add\",\"edit\":\"edit\",\"export\":\"export\",\"list\":\"list\",\"masterlist\":\"masterlist\",\"masterprint\":\"masterprint\",\"search\":\"search\",\"view\":\"view\"}"));
			tdataArray["dbo_EMPLEADO"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"add\":[\"add\"],\"edit\":[\"edit\"],\"export\":[\"export\"],\"list\":[\"list\"],\"masterlist\":[\"masterlist\"],\"masterprint\":[\"masterprint\"],\"search\":[\"search\"],\"view\":[\"view\"]}")));
			tdataArray["dbo_EMPLEADO"][".defaultPages"] = GlobalVars.defaultPages;
			fieldLabelsArray["dbo_EMPLEADO"] = SettingsMap.GetArray();
			fieldToolTipsArray["dbo_EMPLEADO"] = SettingsMap.GetArray();
			pageTitlesArray["dbo_EMPLEADO"] = SettingsMap.GetArray();
			placeHoldersArray["dbo_EMPLEADO"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "Spanish")
			{
				fieldLabelsArray["dbo_EMPLEADO"]["Spanish"] = SettingsMap.GetArray();
				fieldToolTipsArray["dbo_EMPLEADO"]["Spanish"] = SettingsMap.GetArray();
				placeHoldersArray["dbo_EMPLEADO"]["Spanish"] = SettingsMap.GetArray();
				pageTitlesArray["dbo_EMPLEADO"]["Spanish"] = SettingsMap.GetArray();
				fieldLabelsArray["dbo_EMPLEADO"]["Spanish"]["foto"] = "Foto";
				fieldToolTipsArray["dbo_EMPLEADO"]["Spanish"]["foto"] = "";
				placeHoldersArray["dbo_EMPLEADO"]["Spanish"]["foto"] = "";
				fieldLabelsArray["dbo_EMPLEADO"]["Spanish"]["ONI"] = "ONI";
				fieldToolTipsArray["dbo_EMPLEADO"]["Spanish"]["ONI"] = "";
				placeHoldersArray["dbo_EMPLEADO"]["Spanish"]["ONI"] = "";
				fieldLabelsArray["dbo_EMPLEADO"]["Spanish"]["nombre"] = "Nombre";
				fieldToolTipsArray["dbo_EMPLEADO"]["Spanish"]["nombre"] = "";
				placeHoldersArray["dbo_EMPLEADO"]["Spanish"]["nombre"] = "";
				fieldLabelsArray["dbo_EMPLEADO"]["Spanish"]["password"] = "Password";
				fieldToolTipsArray["dbo_EMPLEADO"]["Spanish"]["password"] = "";
				placeHoldersArray["dbo_EMPLEADO"]["Spanish"]["password"] = "";
				fieldLabelsArray["dbo_EMPLEADO"]["Spanish"]["id_tipo"] = "Cargo";
				fieldToolTipsArray["dbo_EMPLEADO"]["Spanish"]["id_tipo"] = "";
				placeHoldersArray["dbo_EMPLEADO"]["Spanish"]["id_tipo"] = "";
				fieldLabelsArray["dbo_EMPLEADO"]["Spanish"]["id_departamento"] = "Departamento";
				fieldToolTipsArray["dbo_EMPLEADO"]["Spanish"]["id_departamento"] = "";
				placeHoldersArray["dbo_EMPLEADO"]["Spanish"]["id_departamento"] = "";
				fieldLabelsArray["dbo_EMPLEADO"]["Spanish"]["id_horarios"] = "Horarios";
				fieldToolTipsArray["dbo_EMPLEADO"]["Spanish"]["id_horarios"] = "";
				placeHoldersArray["dbo_EMPLEADO"]["Spanish"]["id_horarios"] = "";
				fieldLabelsArray["dbo_EMPLEADO"]["Spanish"]["saldo_personales"] = "Saldo Horas Personales";
				fieldToolTipsArray["dbo_EMPLEADO"]["Spanish"]["saldo_personales"] = "";
				placeHoldersArray["dbo_EMPLEADO"]["Spanish"]["saldo_personales"] = "";
				fieldLabelsArray["dbo_EMPLEADO"]["Spanish"]["saldo_compesado"] = "Saldo Horas Compesado";
				fieldToolTipsArray["dbo_EMPLEADO"]["Spanish"]["saldo_compesado"] = "";
				placeHoldersArray["dbo_EMPLEADO"]["Spanish"]["saldo_compesado"] = "";
				fieldLabelsArray["dbo_EMPLEADO"]["Spanish"]["id_grupo"] = "Grupo";
				fieldToolTipsArray["dbo_EMPLEADO"]["Spanish"]["id_grupo"] = "";
				placeHoldersArray["dbo_EMPLEADO"]["Spanish"]["id_grupo"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["dbo_EMPLEADO"]["Spanish"])))
				{
					tdataArray["dbo_EMPLEADO"][".isUseToolTips"] = true;
				}
			}
			tdataArray["dbo_EMPLEADO"][".NCSearch"] = true;
			tdataArray["dbo_EMPLEADO"][".shortTableName"] = "dbo_EMPLEADO";
			tdataArray["dbo_EMPLEADO"][".nSecOptions"] = 0;
			tdataArray["dbo_EMPLEADO"][".mainTableOwnerID"] = "";
			tdataArray["dbo_EMPLEADO"][".entityType"] = 0;
			tdataArray["dbo_EMPLEADO"][".strOriginalTableName"] = "dbo.EMPLEADO";
			tdataArray["dbo_EMPLEADO"][".showAddInPopup"] = false;
			tdataArray["dbo_EMPLEADO"][".showEditInPopup"] = false;
			tdataArray["dbo_EMPLEADO"][".showViewInPopup"] = false;
			popupPagesLayoutNames = SettingsMap.GetArray();
			tdataArray["dbo_EMPLEADO"][".popupPagesLayoutNames"] = popupPagesLayoutNames;
			tdataArray["dbo_EMPLEADO"][".listAjax"] = false;
			tdataArray["dbo_EMPLEADO"][".listAjax"] = false;
			tdataArray["dbo_EMPLEADO"][".audit"] = true;
			tdataArray["dbo_EMPLEADO"][".locking"] = false;
			GlobalVars.pages = tdataArray["dbo_EMPLEADO"][".pages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["dbo_EMPLEADO"][".edit"] = true;
				tdataArray["dbo_EMPLEADO"][".afterEditAction"] = 1;
				tdataArray["dbo_EMPLEADO"][".closePopupAfterEdit"] = 1;
				tdataArray["dbo_EMPLEADO"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["dbo_EMPLEADO"][".add"] = true;
				tdataArray["dbo_EMPLEADO"][".afterAddAction"] = 1;
				tdataArray["dbo_EMPLEADO"][".closePopupAfterAdd"] = 1;
				tdataArray["dbo_EMPLEADO"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["dbo_EMPLEADO"][".list"] = true;
			}
			tdataArray["dbo_EMPLEADO"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["dbo_EMPLEADO"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["dbo_EMPLEADO"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["dbo_EMPLEADO"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["dbo_EMPLEADO"][".printFriendly"] = true;
			}
			tdataArray["dbo_EMPLEADO"][".showSimpleSearchOptions"] = true;
			tdataArray["dbo_EMPLEADO"][".allowShowHideFields"] = true;
			tdataArray["dbo_EMPLEADO"][".allowFieldsReordering"] = true;
			tdataArray["dbo_EMPLEADO"][".isUseAjaxSuggest"] = true;
			tdataArray["dbo_EMPLEADO"][".rowHighlite"] = true;


			tdataArray["dbo_EMPLEADO"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["dbo_EMPLEADO"][".buttonsAdded"] = false;
			tdataArray["dbo_EMPLEADO"][".addPageEvents"] = false;
			tdataArray["dbo_EMPLEADO"][".isUseTimeForSearch"] = false;
			tdataArray["dbo_EMPLEADO"][".badgeColor"] = "4682b4";
			tdataArray["dbo_EMPLEADO"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["dbo_EMPLEADO"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["dbo_EMPLEADO"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["dbo_EMPLEADO"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["dbo_EMPLEADO"][".googleLikeFields"].Add("foto");
			tdataArray["dbo_EMPLEADO"][".googleLikeFields"].Add("ONI");
			tdataArray["dbo_EMPLEADO"][".googleLikeFields"].Add("nombre");
			tdataArray["dbo_EMPLEADO"][".googleLikeFields"].Add("password");
			tdataArray["dbo_EMPLEADO"][".googleLikeFields"].Add("id_tipo");
			tdataArray["dbo_EMPLEADO"][".googleLikeFields"].Add("id_departamento");
			tdataArray["dbo_EMPLEADO"][".googleLikeFields"].Add("id_grupo");
			tdataArray["dbo_EMPLEADO"][".googleLikeFields"].Add("id_horarios");
			tdataArray["dbo_EMPLEADO"][".googleLikeFields"].Add("saldo_personales");
			tdataArray["dbo_EMPLEADO"][".googleLikeFields"].Add("saldo_compesado");
			tdataArray["dbo_EMPLEADO"][".tableType"] = "list";
			tdataArray["dbo_EMPLEADO"][".printerPageOrientation"] = 0;
			tdataArray["dbo_EMPLEADO"][".nPrinterPageScale"] = 100;
			tdataArray["dbo_EMPLEADO"][".nPrinterSplitRecords"] = 40;
			tdataArray["dbo_EMPLEADO"][".nPrinterPDFSplitRecords"] = 40;
			tdataArray["dbo_EMPLEADO"][".geocodingEnabled"] = false;
			tdataArray["dbo_EMPLEADO"][".pageSize"] = 20;
			tdataArray["dbo_EMPLEADO"][".warnLeavingPages"] = true;
			tstrOrderBy = "";
			if(MVCFunctions.strlen(tstrOrderBy) && MVCFunctions.strtolower(MVCFunctions.substr(tstrOrderBy, new XVar(0), new XVar(8))) != "order by")
			{
				tstrOrderBy = MVCFunctions.Concat("order by ", tstrOrderBy);
			}
			tdataArray["dbo_EMPLEADO"][".strOrderBy"] = tstrOrderBy;
			tdataArray["dbo_EMPLEADO"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["dbo_EMPLEADO"][".sqlHead"] = "SELECT foto,  ONI,  nombre,  password,  id_tipo,  id_departamento,  id_grupo,  id_horarios,  saldo_personales,  saldo_compesado";
			tdataArray["dbo_EMPLEADO"][".sqlFrom"] = "FROM dbo.EMPLEADO";
			tdataArray["dbo_EMPLEADO"][".sqlWhereExpr"] = "";
			tdataArray["dbo_EMPLEADO"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["dbo_EMPLEADO"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["dbo_EMPLEADO"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["dbo_EMPLEADO"][".highlightSearchResults"] = true;
			tableKeysArray["dbo_EMPLEADO"] = SettingsMap.GetArray();
			tableKeysArray["dbo_EMPLEADO"].Add("ONI");
			tdataArray["dbo_EMPLEADO"][".Keys"] = tableKeysArray["dbo_EMPLEADO"];
			tdataArray["dbo_EMPLEADO"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "foto";
			fdata["GoodName"] = "foto";
			fdata["ownerTable"] = "dbo.EMPLEADO";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_EMPLEADO","foto");
			fdata["FieldType"] = 200;
			fdata["strField"] = "foto";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "foto";
			fdata["UploadFolder"] = "files";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "File-based Image");
			vdata["ShowThumbnail"] = true;
			vdata["ThumbWidth"] = 72;
			vdata["ThumbHeight"] = 72;
			vdata["ImageWidth"] = 457;
			vdata["ImageHeight"] = 0;
			fdata["ViewFormats"]["view"] = vdata;
			fdata["EditFormats"] = SettingsMap.GetArray();
			edata = new XVar("EditFormat", "Document upload");
			edata["acceptFileTypes"] = "bmp";
			edata["acceptFileTypes"] = MVCFunctions.Concat(edata["acceptFileTypes"], "|gif");
			edata["acceptFileTypes"] = MVCFunctions.Concat(edata["acceptFileTypes"], "|jpg");
			edata["acceptFileTypes"] = MVCFunctions.Concat(edata["acceptFileTypes"], "|png");
			edata["acceptFileTypes"] = MVCFunctions.Concat("(", edata["acceptFileTypes"], ")$");
			edata["maxNumberOfFiles"] = 1;
			edata["controlWidth"] = 200;
			edata["validateAs"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"] = SettingsMap.GetArray();
			edata["validateAs"]["customMessages"] = SettingsMap.GetArray();
			edata["CreateThumbnail"] = true;
			edata["StrThumbnail"] = "th";
			edata["ThumbnailSize"] = 150;
			edata["ResizeImage"] = true;
			edata["NewSize"] = 200;
			fdata["EditFormats"]["edit"] = edata;
			fdata["isSeparate"] = false;
			fdata["defaultSearchOption"] = "Contains";
			fdata["searchOptionsList"] = SettingsMap.GetArray();
			fdata["searchOptionsList"].Add("Contains");
			fdata["filterTotals"] = 0;
			fdata["filterMultiSelect"] = 0;
			fdata["filterFormat"] = "Values list";
			fdata["showCollapsed"] = false;
			fdata["sortValueType"] = 0;
			fdata["numberOfVisibleItems"] = 10;
			tdataArray["dbo_EMPLEADO"]["foto"] = fdata;
			tdataArray["dbo_EMPLEADO"][".searchableFields"].Add("foto");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "ONI";
			fdata["GoodName"] = "ONI";
			fdata["ownerTable"] = "dbo.EMPLEADO";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_EMPLEADO","ONI");
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
			edata["validateAs"]["basicValidate"].Add("DenyDuplicated");
			edata["validateAs"]["customMessages"]["DenyDuplicated"] = new XVar("message", "ESTE ONI %value% YA EXITE", "messageType", "Text");
			edata["denyDuplicates"] = true;
			fdata["EditFormats"]["edit"] = edata;
			fdata["isSeparate"] = false;
			fdata["defaultSearchOption"] = "Contains";
			fdata["searchOptionsList"] = SettingsMap.GetArray();
			fdata["searchOptionsList"].Add("Contains");
			fdata["filterTotals"] = 0;
			fdata["filterMultiSelect"] = 0;
			fdata["filterFormat"] = "Values list";
			fdata["showCollapsed"] = false;
			fdata["sortValueType"] = 0;
			fdata["numberOfVisibleItems"] = 10;
			tdataArray["dbo_EMPLEADO"]["ONI"] = fdata;
			tdataArray["dbo_EMPLEADO"][".searchableFields"].Add("ONI");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 3;
			fdata["strName"] = "nombre";
			fdata["GoodName"] = "nombre";
			fdata["ownerTable"] = "dbo.EMPLEADO";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_EMPLEADO","nombre");
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
			fdata["searchOptionsList"] = SettingsMap.GetArray();
			fdata["searchOptionsList"].Add("Contains");
			fdata["filterTotals"] = 0;
			fdata["filterMultiSelect"] = 0;
			fdata["filterFormat"] = "Values list";
			fdata["showCollapsed"] = false;
			fdata["sortValueType"] = 0;
			fdata["numberOfVisibleItems"] = 10;
			tdataArray["dbo_EMPLEADO"]["nombre"] = fdata;
			tdataArray["dbo_EMPLEADO"][".searchableFields"].Add("nombre");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 4;
			fdata["strName"] = "password";
			fdata["GoodName"] = "password";
			fdata["ownerTable"] = "dbo.EMPLEADO";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_EMPLEADO","password");
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
			edata = new XVar("EditFormat", "Password");
			edata["acceptFileTypes"] = ".+$";
			edata["maxNumberOfFiles"] = 1;
			edata["EditParams"] = "";
			edata["EditParams"] = MVCFunctions.Concat(edata["EditParams"], " maxlength=100");
			edata["controlWidth"] = 200;
			edata["validateAs"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"] = SettingsMap.GetArray();
			edata["validateAs"]["customMessages"] = SettingsMap.GetArray();
			fdata["EditFormats"]["edit"] = edata;
			fdata["isSeparate"] = false;
			fdata["defaultSearchOption"] = "Contains";
			fdata["searchOptionsList"] = SettingsMap.GetArray();
			fdata["searchOptionsList"].Add("Contains");
			fdata["filterTotals"] = 0;
			fdata["filterMultiSelect"] = 0;
			fdata["filterFormat"] = "Values list";
			fdata["showCollapsed"] = false;
			fdata["sortValueType"] = 0;
			fdata["numberOfVisibleItems"] = 10;
			tdataArray["dbo_EMPLEADO"]["password"] = fdata;
			tdataArray["dbo_EMPLEADO"][".searchableFields"].Add("password");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 5;
			fdata["strName"] = "id_tipo";
			fdata["GoodName"] = "id_tipo";
			fdata["ownerTable"] = "dbo.EMPLEADO";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_EMPLEADO","id_tipo");
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
			fdata["defaultSearchOption"] = "Contains";
			fdata["searchOptionsList"] = SettingsMap.GetArray();
			fdata["searchOptionsList"].Add("Contains");
			fdata["filterTotals"] = 0;
			fdata["filterMultiSelect"] = 0;
			fdata["filterFormat"] = "Values list";
			fdata["showCollapsed"] = false;
			fdata["sortValueType"] = 0;
			fdata["numberOfVisibleItems"] = 10;
			tdataArray["dbo_EMPLEADO"]["id_tipo"] = fdata;
			tdataArray["dbo_EMPLEADO"][".searchableFields"].Add("id_tipo");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 6;
			fdata["strName"] = "id_departamento";
			fdata["GoodName"] = "id_departamento";
			fdata["ownerTable"] = "dbo.EMPLEADO";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_EMPLEADO","id_departamento");
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
			edata["DependentLookups"] = SettingsMap.GetArray();
			edata["DependentLookups"].Add("id_grupo");
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
			fdata["defaultSearchOption"] = "Contains";
			fdata["searchOptionsList"] = SettingsMap.GetArray();
			fdata["searchOptionsList"].Add("Contains");
			fdata["filterTotals"] = 0;
			fdata["filterMultiSelect"] = 0;
			fdata["filterFormat"] = "Values list";
			fdata["showCollapsed"] = false;
			fdata["sortValueType"] = 0;
			fdata["numberOfVisibleItems"] = 10;
			tdataArray["dbo_EMPLEADO"]["id_departamento"] = fdata;
			tdataArray["dbo_EMPLEADO"][".searchableFields"].Add("id_departamento");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 7;
			fdata["strName"] = "id_grupo";
			fdata["GoodName"] = "id_grupo";
			fdata["ownerTable"] = "dbo.EMPLEADO";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_EMPLEADO","id_grupo");
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
			edata["UseCategory"] = true;
			edata["categoryFields"] = SettingsMap.GetArray();
			edata["categoryFields"].Add(new XVar("main", "id_departamento", "lookup", "id_departamento"));
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
			tdataArray["dbo_EMPLEADO"]["id_grupo"] = fdata;
			tdataArray["dbo_EMPLEADO"][".searchableFields"].Add("id_grupo");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 8;
			fdata["strName"] = "id_horarios";
			fdata["GoodName"] = "id_horarios";
			fdata["ownerTable"] = "dbo.EMPLEADO";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_EMPLEADO","id_horarios");
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
			fdata["defaultSearchOption"] = "Contains";
			fdata["searchOptionsList"] = SettingsMap.GetArray();
			fdata["searchOptionsList"].Add("Contains");
			fdata["filterTotals"] = 0;
			fdata["filterMultiSelect"] = 0;
			fdata["filterFormat"] = "Values list";
			fdata["showCollapsed"] = false;
			fdata["sortValueType"] = 0;
			fdata["numberOfVisibleItems"] = 10;
			tdataArray["dbo_EMPLEADO"]["id_horarios"] = fdata;
			tdataArray["dbo_EMPLEADO"][".searchableFields"].Add("id_horarios");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 9;
			fdata["strName"] = "saldo_personales";
			fdata["GoodName"] = "saldo_personales";
			fdata["ownerTable"] = "dbo.EMPLEADO";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_EMPLEADO","saldo_personales");
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
			fdata["searchOptionsList"] = SettingsMap.GetArray();
			fdata["searchOptionsList"].Add("Contains");
			fdata["filterTotals"] = 0;
			fdata["filterMultiSelect"] = 0;
			fdata["filterFormat"] = "Values list";
			fdata["showCollapsed"] = false;
			fdata["sortValueType"] = 0;
			fdata["numberOfVisibleItems"] = 10;
			tdataArray["dbo_EMPLEADO"]["saldo_personales"] = fdata;
			tdataArray["dbo_EMPLEADO"][".searchableFields"].Add("saldo_personales");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 10;
			fdata["strName"] = "saldo_compesado";
			fdata["GoodName"] = "saldo_compesado";
			fdata["ownerTable"] = "dbo.EMPLEADO";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_EMPLEADO","saldo_compesado");
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
			fdata["searchOptionsList"] = SettingsMap.GetArray();
			fdata["searchOptionsList"].Add("Contains");
			fdata["filterTotals"] = 0;
			fdata["filterMultiSelect"] = 0;
			fdata["filterFormat"] = "Values list";
			fdata["showCollapsed"] = false;
			fdata["sortValueType"] = 0;
			fdata["numberOfVisibleItems"] = 10;
			tdataArray["dbo_EMPLEADO"]["saldo_compesado"] = fdata;
			tdataArray["dbo_EMPLEADO"][".searchableFields"].Add("saldo_compesado");
			GlobalVars.tables_data["dbo.EMPLEADO"] = tdataArray["dbo_EMPLEADO"];
			GlobalVars.field_labels["dbo_EMPLEADO"] = fieldLabelsArray["dbo_EMPLEADO"];
			GlobalVars.fieldToolTips["dbo_EMPLEADO"] = fieldToolTipsArray["dbo_EMPLEADO"];
			GlobalVars.placeHolders["dbo_EMPLEADO"] = placeHoldersArray["dbo_EMPLEADO"];
			GlobalVars.page_titles["dbo_EMPLEADO"] = pageTitlesArray["dbo_EMPLEADO"];
			GlobalVars.detailsTablesData["dbo.EMPLEADO"] = SettingsMap.GetArray();


			dIndex = 0;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "dbo.Permisos2";
			detailsParam["dOriginalTable"] = "dbo.Permisos2";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "dbo_Permisos2";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("dbo_Permisos2"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex]["masterKeys"].Add("ONI");
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex]["detailKeys"].Add("ONI");


			dIndex = 1;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "dbo.REGISTRO_HORAS_COMPESADAS";
			detailsParam["dOriginalTable"] = "dbo.REGISTRO_HORAS_COMPESADAS";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "dbo_REGISTRO_HORAS_COMPESADAS";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("dbo_REGISTRO_HORAS_COMPESADAS"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex]["masterKeys"].Add("ONI");
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex]["detailKeys"].Add("ONI");


			dIndex = 2;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "APROBAR_PERMISOS";
			detailsParam["dOriginalTable"] = "dbo.Permisos2";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "APROBAR_PERMISOS";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("APROBAR_PERMISOS"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex]["masterKeys"].Add("ONI");
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex]["detailKeys"].Add("ONI");


			dIndex = 3;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "VISTOBUENO_JEFEINMEDIATO";
			detailsParam["dOriginalTable"] = "dbo.Permisos2";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "VISTOBUENO_JEFEINMEDIATO";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("VISTOBUENO_JEFEINMEDIATO"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex]["masterKeys"].Add("ONI");
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex]["detailKeys"].Add("ONI");


			dIndex = 4;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "VISTOBUENO_JEFEDEPARTAMENTO";
			detailsParam["dOriginalTable"] = "dbo.Permisos2";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "VISTOBUENO_JEFEDEPARTAMENTO";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("VISTOBUENO_JEFEDEPARTAMENTO"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex]["masterKeys"].Add("ONI");
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex]["detailKeys"].Add("ONI");


			dIndex = 5;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "VER_PERMISOS";
			detailsParam["dOriginalTable"] = "dbo.Permisos2";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "VER_PERMISOS";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("VER_PERMISOS"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex]["masterKeys"].Add("ONI");
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex]["detailKeys"].Add("ONI");


			dIndex = 6;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "VER_COMPESADOS";
			detailsParam["dOriginalTable"] = "dbo.REGISTRO_HORAS_COMPESADAS";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "VER_COMPESADOS";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("VER_COMPESADOS"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex]["masterKeys"].Add("ONI");
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex]["detailKeys"].Add("ONI");


			dIndex = 7;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "APROBACION_COMPESADOS_JEFEINMEDIATO";
			detailsParam["dOriginalTable"] = "dbo.REGISTRO_HORAS_COMPESADAS";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "APROBACION_COMPESADOS_JEFEINMEDIATO";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("APROBACION_COMPESADOS_JEFEINMEDIATO"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex]["masterKeys"].Add("ONI");
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex]["detailKeys"].Add("ONI");


			dIndex = 8;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "APROBACION_COMPESADOS_JEFEDEPARTAMENTO";
			detailsParam["dOriginalTable"] = "dbo.REGISTRO_HORAS_COMPESADAS";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "APROBACION_COMPESADOS_JEFEDEPARTAMENTO";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("APROBACION_COMPESADOS_JEFEDEPARTAMENTO"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex]["masterKeys"].Add("ONI");
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex]["detailKeys"].Add("ONI");


			dIndex = 9;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "APROBAR_COMPESADOS";
			detailsParam["dOriginalTable"] = "dbo.REGISTRO_HORAS_COMPESADAS";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "APROBAR_COMPESADOS";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("APROBAR_COMPESADOS"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex]["masterKeys"].Add("ONI");
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex]["detailKeys"].Add("ONI");


			dIndex = 10;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "INGRESAR PERMISO";
			detailsParam["dOriginalTable"] = "dbo.Permisos2";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "INGRESAR_PERMISO";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("INGRESAR_PERMISO"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex]["masterKeys"].Add("ONI");
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex]["detailKeys"].Add("ONI");


			dIndex = 11;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "INGRESAR_COMPESADO";
			detailsParam["dOriginalTable"] = "dbo.REGISTRO_HORAS_COMPESADAS";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "INGRESAR_COMPESADO";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("INGRESAR_COMPESADO"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex]["masterKeys"].Add("ONI");
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex]["detailKeys"].Add("ONI");


			dIndex = 12;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "Licencias_sin_goce_sueldo";
			detailsParam["dOriginalTable"] = "dbo.Permisos2";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "Licencias_sin_goce_sueldo";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("Licencias_sin_goce_sueldo"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex]["masterKeys"].Add("ONI");
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.EMPLEADO"][dIndex]["detailKeys"].Add("ONI");
			GlobalVars.masterTablesData["dbo.EMPLEADO"] = SettingsMap.GetArray();


			strOriginalDetailsTable = "dbo.DEPARTAMENTO";
			masterParams = SettingsMap.GetArray();
			masterParams["mDataSourceTable"] = "dbo.DEPARTAMENTO";
			masterParams["mOriginalTable"] = strOriginalDetailsTable;
			masterParams["mShortTable"] = "dbo_DEPARTAMENTO";
			masterParams["masterKeys"] = SettingsMap.GetArray();
			masterParams["detailKeys"] = SettingsMap.GetArray();
			masterParams["type"] = Constants.PAGE_LIST;
			GlobalVars.masterTablesData["dbo.EMPLEADO"][0] = masterParams;
			GlobalVars.masterTablesData["dbo.EMPLEADO"][0]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.EMPLEADO"][0]["masterKeys"].Add("id_departamento");
			GlobalVars.masterTablesData["dbo.EMPLEADO"][0]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.EMPLEADO"][0]["detailKeys"].Add("id_departamento");


			strOriginalDetailsTable = "dbo.HORARIOS";
			masterParams = SettingsMap.GetArray();
			masterParams["mDataSourceTable"] = "dbo.HORARIOS";
			masterParams["mOriginalTable"] = strOriginalDetailsTable;
			masterParams["mShortTable"] = "dbo_HORARIOS";
			masterParams["masterKeys"] = SettingsMap.GetArray();
			masterParams["detailKeys"] = SettingsMap.GetArray();
			masterParams["type"] = Constants.PAGE_LIST;
			GlobalVars.masterTablesData["dbo.EMPLEADO"][1] = masterParams;
			GlobalVars.masterTablesData["dbo.EMPLEADO"][1]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.EMPLEADO"][1]["masterKeys"].Add("id_horarios");
			GlobalVars.masterTablesData["dbo.EMPLEADO"][1]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.EMPLEADO"][1]["detailKeys"].Add("id_horarios");


			strOriginalDetailsTable = "dbo.TIPOEMPLEADO";
			masterParams = SettingsMap.GetArray();
			masterParams["mDataSourceTable"] = "dbo.TIPOEMPLEADO";
			masterParams["mOriginalTable"] = strOriginalDetailsTable;
			masterParams["mShortTable"] = "dbo_TIPOEMPLEADO";
			masterParams["masterKeys"] = SettingsMap.GetArray();
			masterParams["detailKeys"] = SettingsMap.GetArray();
			masterParams["type"] = Constants.PAGE_LIST;
			GlobalVars.masterTablesData["dbo.EMPLEADO"][2] = masterParams;
			GlobalVars.masterTablesData["dbo.EMPLEADO"][2]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.EMPLEADO"][2]["masterKeys"].Add("id_tipo");
			GlobalVars.masterTablesData["dbo.EMPLEADO"][2]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.EMPLEADO"][2]["detailKeys"].Add("id_tipo");

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "foto,  ONI,  nombre,  password,  id_tipo,  id_departamento,  id_grupo,  id_horarios,  saldo_personales,  saldo_compesado";
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
obj = new SQLField(new XVar("m_strName", "foto", "m_strTable", "dbo.EMPLEADO", "m_srcTableName", "dbo.EMPLEADO"));

protoArray["6"]["m_sql"] = "foto";
protoArray["6"]["m_srcTableName"] = "dbo.EMPLEADO";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "ONI", "m_strTable", "dbo.EMPLEADO", "m_srcTableName", "dbo.EMPLEADO"));

protoArray["8"]["m_sql"] = "ONI";
protoArray["8"]["m_srcTableName"] = "dbo.EMPLEADO";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["10"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "nombre", "m_strTable", "dbo.EMPLEADO", "m_srcTableName", "dbo.EMPLEADO"));

protoArray["10"]["m_sql"] = "nombre";
protoArray["10"]["m_srcTableName"] = "dbo.EMPLEADO";
protoArray["10"]["m_expr"] = obj;
protoArray["10"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["10"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["12"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "password", "m_strTable", "dbo.EMPLEADO", "m_srcTableName", "dbo.EMPLEADO"));

protoArray["12"]["m_sql"] = "password";
protoArray["12"]["m_srcTableName"] = "dbo.EMPLEADO";
protoArray["12"]["m_expr"] = obj;
protoArray["12"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["12"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["14"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "id_tipo", "m_strTable", "dbo.EMPLEADO", "m_srcTableName", "dbo.EMPLEADO"));

protoArray["14"]["m_sql"] = "id_tipo";
protoArray["14"]["m_srcTableName"] = "dbo.EMPLEADO";
protoArray["14"]["m_expr"] = obj;
protoArray["14"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["14"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["16"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "id_departamento", "m_strTable", "dbo.EMPLEADO", "m_srcTableName", "dbo.EMPLEADO"));

protoArray["16"]["m_sql"] = "id_departamento";
protoArray["16"]["m_srcTableName"] = "dbo.EMPLEADO";
protoArray["16"]["m_expr"] = obj;
protoArray["16"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["16"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["18"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "id_grupo", "m_strTable", "dbo.EMPLEADO", "m_srcTableName", "dbo.EMPLEADO"));

protoArray["18"]["m_sql"] = "id_grupo";
protoArray["18"]["m_srcTableName"] = "dbo.EMPLEADO";
protoArray["18"]["m_expr"] = obj;
protoArray["18"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["18"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["20"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "id_horarios", "m_strTable", "dbo.EMPLEADO", "m_srcTableName", "dbo.EMPLEADO"));

protoArray["20"]["m_sql"] = "id_horarios";
protoArray["20"]["m_srcTableName"] = "dbo.EMPLEADO";
protoArray["20"]["m_expr"] = obj;
protoArray["20"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["20"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["22"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "saldo_personales", "m_strTable", "dbo.EMPLEADO", "m_srcTableName", "dbo.EMPLEADO"));

protoArray["22"]["m_sql"] = "saldo_personales";
protoArray["22"]["m_srcTableName"] = "dbo.EMPLEADO";
protoArray["22"]["m_expr"] = obj;
protoArray["22"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["22"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["24"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "saldo_compesado", "m_strTable", "dbo.EMPLEADO", "m_srcTableName", "dbo.EMPLEADO"));

protoArray["24"]["m_sql"] = "saldo_compesado";
protoArray["24"]["m_srcTableName"] = "dbo.EMPLEADO";
protoArray["24"]["m_expr"] = obj;
protoArray["24"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["24"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["26"] = SettingsMap.GetArray();
protoArray["26"]["m_link"] = "SQLL_MAIN";
protoArray["27"] = SettingsMap.GetArray();
protoArray["27"]["m_strName"] = "dbo.EMPLEADO";
protoArray["27"]["m_srcTableName"] = "dbo.EMPLEADO";
protoArray["27"]["m_columns"] = SettingsMap.GetArray();
protoArray["27"]["m_columns"].Add("ONI");
protoArray["27"]["m_columns"].Add("nombre");
protoArray["27"]["m_columns"].Add("password");
protoArray["27"]["m_columns"].Add("id_tipo");
protoArray["27"]["m_columns"].Add("id_departamento");
protoArray["27"]["m_columns"].Add("id_horarios");
protoArray["27"]["m_columns"].Add("saldo_personales");
protoArray["27"]["m_columns"].Add("saldo_compesado");
protoArray["27"]["m_columns"].Add("foto");
protoArray["27"]["m_columns"].Add("id_grupo");
obj = new SQLTable(protoArray["27"]);

protoArray["26"]["m_table"] = obj;
protoArray["26"]["m_sql"] = "dbo.EMPLEADO";
protoArray["26"]["m_alias"] = "";
protoArray["26"]["m_srcTableName"] = "dbo.EMPLEADO";
protoArray["28"] = SettingsMap.GetArray();
protoArray["28"]["m_sql"] = "";
protoArray["28"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLNonParsed(new XVar("m_sql", ""));

protoArray["28"]["m_column"] = obj;
protoArray["28"]["m_contained"] = SettingsMap.GetArray();
protoArray["28"]["m_strCase"] = "";
protoArray["28"]["m_havingmode"] = false;
protoArray["28"]["m_inBrackets"] = false;
protoArray["28"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["28"]);

protoArray["26"]["m_joinon"] = obj;
obj = new SQLFromListItem(protoArray["26"]);

protoArray["0"]["m_fromlist"].Add(obj);
protoArray["0"]["m_groupby"] = SettingsMap.GetArray();
protoArray["0"]["m_orderby"] = SettingsMap.GetArray();
protoArray["0"]["m_srcTableName"] = "dbo.EMPLEADO";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["dbo_EMPLEADO"] = obj;

				
		
			tdataArray["dbo_EMPLEADO"][".sqlquery"] = queryData_Array["dbo_EMPLEADO"];
			GlobalVars.tableEvents["dbo.EMPLEADO"] = new eventsBase();
			tdataArray["dbo_EMPLEADO"][".hasEvents"] = false;
			GlobalVars.tables_data["dbo_EMPLEADO"] = tdataArray["dbo_EMPLEADO"];
		}
	}

}
