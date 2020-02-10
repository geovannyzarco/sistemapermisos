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
	public static partial class Settings_Saldo_Horas_Empleado
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), popupPagesLayoutNames = SettingsMap.GetArray(), query = null, queryData_Array = new XVar(), reportGroupFields = SettingsMap.GetArray(), rgroupField = SettingsMap.GetArray(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["Saldo_Horas_Empleado"] = SettingsMap.GetArray();
			tdataArray["Saldo_Horas_Empleado"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["Saldo_Horas_Empleado"][".truncateText"] = true;
			tdataArray["Saldo_Horas_Empleado"][".NumberOfChars"] = 80;
			tdataArray["Saldo_Horas_Empleado"][".ShortName"] = "Saldo_Horas_Empleado";
			tdataArray["Saldo_Horas_Empleado"][".OwnerID"] = "";
			tdataArray["Saldo_Horas_Empleado"][".OriginalTable"] = "dbo.EMPLEADO";
			GlobalVars.defaultPages = MVCFunctions.my_json_decode(new XVar("{\"export\":\"export\",\"list\":\"list\",\"masterlist\":\"masterlist\",\"masterprint\":\"masterprint\",\"search\":\"search\"}"));
			tdataArray["Saldo_Horas_Empleado"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"export\":[\"export\"],\"list\":[\"list\"],\"masterlist\":[\"masterlist\"],\"masterprint\":[\"masterprint\"],\"search\":[\"search\"]}")));
			tdataArray["Saldo_Horas_Empleado"][".defaultPages"] = GlobalVars.defaultPages;
			fieldLabelsArray["Saldo_Horas_Empleado"] = SettingsMap.GetArray();
			fieldToolTipsArray["Saldo_Horas_Empleado"] = SettingsMap.GetArray();
			pageTitlesArray["Saldo_Horas_Empleado"] = SettingsMap.GetArray();
			placeHoldersArray["Saldo_Horas_Empleado"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "Spanish")
			{
				fieldLabelsArray["Saldo_Horas_Empleado"]["Spanish"] = SettingsMap.GetArray();
				fieldToolTipsArray["Saldo_Horas_Empleado"]["Spanish"] = SettingsMap.GetArray();
				placeHoldersArray["Saldo_Horas_Empleado"]["Spanish"] = SettingsMap.GetArray();
				pageTitlesArray["Saldo_Horas_Empleado"]["Spanish"] = SettingsMap.GetArray();
				fieldLabelsArray["Saldo_Horas_Empleado"]["Spanish"]["ONI"] = "ONI";
				fieldToolTipsArray["Saldo_Horas_Empleado"]["Spanish"]["ONI"] = "";
				placeHoldersArray["Saldo_Horas_Empleado"]["Spanish"]["ONI"] = "";
				fieldLabelsArray["Saldo_Horas_Empleado"]["Spanish"]["nombre"] = "Nombre";
				fieldToolTipsArray["Saldo_Horas_Empleado"]["Spanish"]["nombre"] = "";
				placeHoldersArray["Saldo_Horas_Empleado"]["Spanish"]["nombre"] = "";
				fieldLabelsArray["Saldo_Horas_Empleado"]["Spanish"]["Horas_personales_tomadas"] = "Horas Personales Tomadas";
				fieldToolTipsArray["Saldo_Horas_Empleado"]["Spanish"]["Horas_personales_tomadas"] = "";
				placeHoldersArray["Saldo_Horas_Empleado"]["Spanish"]["Horas_personales_tomadas"] = "";
				fieldLabelsArray["Saldo_Horas_Empleado"]["Spanish"]["Horas_personales_asignadas"] = "Horas Personales Asignadas";
				fieldToolTipsArray["Saldo_Horas_Empleado"]["Spanish"]["Horas_personales_asignadas"] = "";
				placeHoldersArray["Saldo_Horas_Empleado"]["Spanish"]["Horas_personales_asignadas"] = "";
				fieldLabelsArray["Saldo_Horas_Empleado"]["Spanish"]["Horas_compesadas_disponible"] = "Horas Compesadas Disponible";
				fieldToolTipsArray["Saldo_Horas_Empleado"]["Spanish"]["Horas_compesadas_disponible"] = "";
				placeHoldersArray["Saldo_Horas_Empleado"]["Spanish"]["Horas_compesadas_disponible"] = "";
				fieldLabelsArray["Saldo_Horas_Empleado"]["Spanish"]["tipo_empleado"] = "Tipo Empleado";
				fieldToolTipsArray["Saldo_Horas_Empleado"]["Spanish"]["tipo_empleado"] = "";
				placeHoldersArray["Saldo_Horas_Empleado"]["Spanish"]["tipo_empleado"] = "";
				fieldLabelsArray["Saldo_Horas_Empleado"]["Spanish"]["horarios"] = "Horarios";
				fieldToolTipsArray["Saldo_Horas_Empleado"]["Spanish"]["horarios"] = "";
				placeHoldersArray["Saldo_Horas_Empleado"]["Spanish"]["horarios"] = "";
				fieldLabelsArray["Saldo_Horas_Empleado"]["Spanish"]["departamento"] = "Departamento";
				fieldToolTipsArray["Saldo_Horas_Empleado"]["Spanish"]["departamento"] = "";
				placeHoldersArray["Saldo_Horas_Empleado"]["Spanish"]["departamento"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["Saldo_Horas_Empleado"]["Spanish"])))
				{
					tdataArray["Saldo_Horas_Empleado"][".isUseToolTips"] = true;
				}
			}
			tdataArray["Saldo_Horas_Empleado"][".NCSearch"] = true;
			tdataArray["Saldo_Horas_Empleado"][".shortTableName"] = "Saldo_Horas_Empleado";
			tdataArray["Saldo_Horas_Empleado"][".nSecOptions"] = 0;
			tdataArray["Saldo_Horas_Empleado"][".mainTableOwnerID"] = "";
			tdataArray["Saldo_Horas_Empleado"][".entityType"] = 1;
			tdataArray["Saldo_Horas_Empleado"][".strOriginalTableName"] = "dbo.EMPLEADO";
			tdataArray["Saldo_Horas_Empleado"][".showAddInPopup"] = false;
			tdataArray["Saldo_Horas_Empleado"][".showEditInPopup"] = false;
			tdataArray["Saldo_Horas_Empleado"][".showViewInPopup"] = false;
			popupPagesLayoutNames = SettingsMap.GetArray();
			tdataArray["Saldo_Horas_Empleado"][".popupPagesLayoutNames"] = popupPagesLayoutNames;
			tdataArray["Saldo_Horas_Empleado"][".listAjax"] = false;
			tdataArray["Saldo_Horas_Empleado"][".listAjax"] = false;
			tdataArray["Saldo_Horas_Empleado"][".audit"] = true;
			tdataArray["Saldo_Horas_Empleado"][".locking"] = false;
			GlobalVars.pages = tdataArray["Saldo_Horas_Empleado"][".pages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["Saldo_Horas_Empleado"][".edit"] = true;
				tdataArray["Saldo_Horas_Empleado"][".afterEditAction"] = 1;
				tdataArray["Saldo_Horas_Empleado"][".closePopupAfterEdit"] = 1;
				tdataArray["Saldo_Horas_Empleado"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["Saldo_Horas_Empleado"][".add"] = true;
				tdataArray["Saldo_Horas_Empleado"][".afterAddAction"] = 1;
				tdataArray["Saldo_Horas_Empleado"][".closePopupAfterAdd"] = 1;
				tdataArray["Saldo_Horas_Empleado"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["Saldo_Horas_Empleado"][".list"] = true;
			}
			tdataArray["Saldo_Horas_Empleado"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["Saldo_Horas_Empleado"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["Saldo_Horas_Empleado"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["Saldo_Horas_Empleado"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["Saldo_Horas_Empleado"][".printFriendly"] = true;
			}
			tdataArray["Saldo_Horas_Empleado"][".showSimpleSearchOptions"] = true;
			tdataArray["Saldo_Horas_Empleado"][".allowShowHideFields"] = true;
			tdataArray["Saldo_Horas_Empleado"][".allowFieldsReordering"] = true;
			tdataArray["Saldo_Horas_Empleado"][".isUseAjaxSuggest"] = true;
			tdataArray["Saldo_Horas_Empleado"][".rowHighlite"] = true;


			tdataArray["Saldo_Horas_Empleado"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["Saldo_Horas_Empleado"][".buttonsAdded"] = false;
			tdataArray["Saldo_Horas_Empleado"][".addPageEvents"] = false;
			tdataArray["Saldo_Horas_Empleado"][".isUseTimeForSearch"] = false;
			tdataArray["Saldo_Horas_Empleado"][".badgeColor"] = "5F9EA0";
			tdataArray["Saldo_Horas_Empleado"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["Saldo_Horas_Empleado"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["Saldo_Horas_Empleado"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["Saldo_Horas_Empleado"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["Saldo_Horas_Empleado"][".googleLikeFields"].Add("ONI");
			tdataArray["Saldo_Horas_Empleado"][".googleLikeFields"].Add("nombre");
			tdataArray["Saldo_Horas_Empleado"][".googleLikeFields"].Add("tipo_empleado");
			tdataArray["Saldo_Horas_Empleado"][".googleLikeFields"].Add("horarios");
			tdataArray["Saldo_Horas_Empleado"][".googleLikeFields"].Add("departamento");
			tdataArray["Saldo_Horas_Empleado"][".googleLikeFields"].Add("Horas_personales_tomadas");
			tdataArray["Saldo_Horas_Empleado"][".googleLikeFields"].Add("Horas_personales_asignadas");
			tdataArray["Saldo_Horas_Empleado"][".googleLikeFields"].Add("Horas_compesadas_disponible");
			tdataArray["Saldo_Horas_Empleado"][".tableType"] = "list";
			tdataArray["Saldo_Horas_Empleado"][".printerPageOrientation"] = 0;
			tdataArray["Saldo_Horas_Empleado"][".nPrinterPageScale"] = 100;
			tdataArray["Saldo_Horas_Empleado"][".nPrinterSplitRecords"] = 40;
			tdataArray["Saldo_Horas_Empleado"][".nPrinterPDFSplitRecords"] = 40;
			tdataArray["Saldo_Horas_Empleado"][".geocodingEnabled"] = false;
			tdataArray["Saldo_Horas_Empleado"][".pageSize"] = 20;
			tdataArray["Saldo_Horas_Empleado"][".warnLeavingPages"] = true;
			tstrOrderBy = "";
			if(MVCFunctions.strlen(tstrOrderBy) && MVCFunctions.strtolower(MVCFunctions.substr(tstrOrderBy, new XVar(0), new XVar(8))) != "order by")
			{
				tstrOrderBy = MVCFunctions.Concat("order by ", tstrOrderBy);
			}
			tdataArray["Saldo_Horas_Empleado"][".strOrderBy"] = tstrOrderBy;
			tdataArray["Saldo_Horas_Empleado"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["Saldo_Horas_Empleado"][".sqlHead"] = "SELECT dbo.EMPLEADO.ONI,  dbo.EMPLEADO.nombre,  dbo.TIPOEMPLEADO.tipo_empleado,  dbo.HORARIOS.horarios,  dbo.DEPARTAMENTO.departamento,  	(SELECT  		SUM(DATEDIFF(Hour, fecha_inicio, fecha_final))  		FROM  		dbo.Permisos2  		WHERE  		datepart(yy, dbo.Permisos2.fecha_solicitud)= datepart(yy, getdate())  		AND dbo.Permisos2.ONI=dbo.EMPLEADO.ONI  		AND dbo.Permisos2.id_estado_personal = 2) AS Horas_personales_tomadas,  dbo.HORARIOS.horas_permisos_personales as Horas_personales_asignadas,  	(SELECT  		sum(dbo.REGISTRO_HORAS_COMPESADAS.cantidad_horas_compesadas) as Horas_compesadas  		FROM  		dbo.REGISTRO_HORAS_COMPESADAS  		WHERE  		dbo.REGISTRO_HORAS_COMPESADAS.id_estado_compesado = 2 AND  		dbo.REGISTRO_HORAS_COMPESADAS.ONI = dbo.EMPLEADO.ONI) as Horas_compesadas_disponible";
			tdataArray["Saldo_Horas_Empleado"][".sqlFrom"] = "FROM  dbo.EMPLEADO  INNER JOIN dbo.HORARIOS ON dbo.EMPLEADO.id_horarios = dbo.HORARIOS.id_horarios  INNER JOIN dbo.TIPOEMPLEADO ON dbo.EMPLEADO.id_tipo = dbo.TIPOEMPLEADO.id_tipo  INNER JOIN dbo.DEPARTAMENTO ON dbo.EMPLEADO.id_departamento = dbo.DEPARTAMENTO.id_departamento";
			tdataArray["Saldo_Horas_Empleado"][".sqlWhereExpr"] = "";
			tdataArray["Saldo_Horas_Empleado"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["Saldo_Horas_Empleado"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["Saldo_Horas_Empleado"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["Saldo_Horas_Empleado"][".highlightSearchResults"] = true;
			tableKeysArray["Saldo_Horas_Empleado"] = SettingsMap.GetArray();
			tableKeysArray["Saldo_Horas_Empleado"].Add("ONI");
			tdataArray["Saldo_Horas_Empleado"][".Keys"] = tableKeysArray["Saldo_Horas_Empleado"];
			tdataArray["Saldo_Horas_Empleado"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "ONI";
			fdata["GoodName"] = "ONI";
			fdata["ownerTable"] = "dbo.EMPLEADO";
			fdata["Label"] = CommonFunctions.GetFieldLabel("Saldo_Horas_Empleado","ONI");
			fdata["FieldType"] = 200;
			fdata["strField"] = "ONI";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "dbo.EMPLEADO.ONI";
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
			fdata["searchOptionsList"] = SettingsMap.GetArray();
			fdata["searchOptionsList"].Add("Contains");
			fdata["filterTotals"] = 0;
			fdata["filterMultiSelect"] = 0;
			fdata["filterFormat"] = "Values list";
			fdata["showCollapsed"] = false;
			fdata["sortValueType"] = 0;
			fdata["numberOfVisibleItems"] = 10;
			tdataArray["Saldo_Horas_Empleado"]["ONI"] = fdata;
			tdataArray["Saldo_Horas_Empleado"][".searchableFields"].Add("ONI");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "nombre";
			fdata["GoodName"] = "nombre";
			fdata["ownerTable"] = "dbo.EMPLEADO";
			fdata["Label"] = CommonFunctions.GetFieldLabel("Saldo_Horas_Empleado","nombre");
			fdata["FieldType"] = 200;
			fdata["strField"] = "nombre";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "dbo.EMPLEADO.nombre";
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
			tdataArray["Saldo_Horas_Empleado"]["nombre"] = fdata;
			tdataArray["Saldo_Horas_Empleado"][".searchableFields"].Add("nombre");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 3;
			fdata["strName"] = "tipo_empleado";
			fdata["GoodName"] = "tipo_empleado";
			fdata["ownerTable"] = "dbo.TIPOEMPLEADO";
			fdata["Label"] = CommonFunctions.GetFieldLabel("Saldo_Horas_Empleado","tipo_empleado");
			fdata["FieldType"] = 200;
			fdata["strField"] = "tipo_empleado";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "dbo.TIPOEMPLEADO.tipo_empleado";
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
			tdataArray["Saldo_Horas_Empleado"]["tipo_empleado"] = fdata;
			tdataArray["Saldo_Horas_Empleado"][".searchableFields"].Add("tipo_empleado");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 4;
			fdata["strName"] = "horarios";
			fdata["GoodName"] = "horarios";
			fdata["ownerTable"] = "dbo.HORARIOS";
			fdata["Label"] = CommonFunctions.GetFieldLabel("Saldo_Horas_Empleado","horarios");
			fdata["FieldType"] = 200;
			fdata["strField"] = "horarios";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "dbo.HORARIOS.horarios";
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
			tdataArray["Saldo_Horas_Empleado"]["horarios"] = fdata;
			tdataArray["Saldo_Horas_Empleado"][".searchableFields"].Add("horarios");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 5;
			fdata["strName"] = "departamento";
			fdata["GoodName"] = "departamento";
			fdata["ownerTable"] = "dbo.DEPARTAMENTO";
			fdata["Label"] = CommonFunctions.GetFieldLabel("Saldo_Horas_Empleado","departamento");
			fdata["FieldType"] = 200;
			fdata["strField"] = "departamento";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "dbo.DEPARTAMENTO.departamento";
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
			tdataArray["Saldo_Horas_Empleado"]["departamento"] = fdata;
			tdataArray["Saldo_Horas_Empleado"][".searchableFields"].Add("departamento");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 6;
			fdata["strName"] = "Horas_personales_tomadas";
			fdata["GoodName"] = "Horas_personales_tomadas";
			fdata["ownerTable"] = "";
			fdata["Label"] = CommonFunctions.GetFieldLabel("Saldo_Horas_Empleado","Horas_personales_tomadas");
			fdata["FieldType"] = 3;
			fdata["strField"] = "Horas_personales_tomadas";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "(SELECT  		SUM(DATEDIFF(Hour, fecha_inicio, fecha_final))  		FROM  		dbo.Permisos2  		WHERE  		datepart(yy, dbo.Permisos2.fecha_solicitud)= datepart(yy, getdate())  		AND dbo.Permisos2.ONI=dbo.EMPLEADO.ONI  		AND dbo.Permisos2.id_estado_personal = 2)";
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
			tdataArray["Saldo_Horas_Empleado"]["Horas_personales_tomadas"] = fdata;
			tdataArray["Saldo_Horas_Empleado"][".searchableFields"].Add("Horas_personales_tomadas");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 7;
			fdata["strName"] = "Horas_personales_asignadas";
			fdata["GoodName"] = "Horas_personales_asignadas";
			fdata["ownerTable"] = "dbo.HORARIOS";
			fdata["Label"] = CommonFunctions.GetFieldLabel("Saldo_Horas_Empleado","Horas_personales_asignadas");
			fdata["FieldType"] = 3;
			fdata["strField"] = "horas_permisos_personales";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "dbo.HORARIOS.horas_permisos_personales";
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
			tdataArray["Saldo_Horas_Empleado"]["Horas_personales_asignadas"] = fdata;
			tdataArray["Saldo_Horas_Empleado"][".searchableFields"].Add("Horas_personales_asignadas");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 8;
			fdata["strName"] = "Horas_compesadas_disponible";
			fdata["GoodName"] = "Horas_compesadas_disponible";
			fdata["ownerTable"] = "";
			fdata["Label"] = CommonFunctions.GetFieldLabel("Saldo_Horas_Empleado","Horas_compesadas_disponible");
			fdata["FieldType"] = 3;
			fdata["strField"] = "Horas_compesadas_disponible";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "(SELECT  		sum(dbo.REGISTRO_HORAS_COMPESADAS.cantidad_horas_compesadas) as Horas_compesadas  		FROM  		dbo.REGISTRO_HORAS_COMPESADAS  		WHERE  		dbo.REGISTRO_HORAS_COMPESADAS.id_estado_compesado = 2 AND  		dbo.REGISTRO_HORAS_COMPESADAS.ONI = dbo.EMPLEADO.ONI)";
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
			tdataArray["Saldo_Horas_Empleado"]["Horas_compesadas_disponible"] = fdata;
			tdataArray["Saldo_Horas_Empleado"][".searchableFields"].Add("Horas_compesadas_disponible");
			GlobalVars.tables_data["Saldo_Horas_Empleado"] = tdataArray["Saldo_Horas_Empleado"];
			GlobalVars.field_labels["Saldo_Horas_Empleado"] = fieldLabelsArray["Saldo_Horas_Empleado"];
			GlobalVars.fieldToolTips["Saldo_Horas_Empleado"] = fieldToolTipsArray["Saldo_Horas_Empleado"];
			GlobalVars.placeHolders["Saldo_Horas_Empleado"] = placeHoldersArray["Saldo_Horas_Empleado"];
			GlobalVars.page_titles["Saldo_Horas_Empleado"] = pageTitlesArray["Saldo_Horas_Empleado"];
			GlobalVars.detailsTablesData["Saldo_Horas_Empleado"] = SettingsMap.GetArray();


			dIndex = 0;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "dbo.Permisos2";
			detailsParam["dOriginalTable"] = "dbo.Permisos2";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "dbo_Permisos2";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("dbo_Permisos2"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["Saldo_Horas_Empleado"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["Saldo_Horas_Empleado"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["Saldo_Horas_Empleado"][dIndex]["masterKeys"].Add("ONI");
			GlobalVars.detailsTablesData["Saldo_Horas_Empleado"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["Saldo_Horas_Empleado"][dIndex]["detailKeys"].Add("ONI");


			dIndex = 1;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "dbo.REGISTRO_HORAS_COMPESADAS";
			detailsParam["dOriginalTable"] = "dbo.REGISTRO_HORAS_COMPESADAS";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "dbo_REGISTRO_HORAS_COMPESADAS";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("dbo_REGISTRO_HORAS_COMPESADAS"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["Saldo_Horas_Empleado"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["Saldo_Horas_Empleado"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["Saldo_Horas_Empleado"][dIndex]["masterKeys"].Add("ONI");
			GlobalVars.detailsTablesData["Saldo_Horas_Empleado"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["Saldo_Horas_Empleado"][dIndex]["detailKeys"].Add("ONI");
			GlobalVars.masterTablesData["Saldo_Horas_Empleado"] = SettingsMap.GetArray();


			strOriginalDetailsTable = "dbo.TIPOEMPLEADO";
			masterParams = SettingsMap.GetArray();
			masterParams["mDataSourceTable"] = "dbo.TIPOEMPLEADO";
			masterParams["mOriginalTable"] = strOriginalDetailsTable;
			masterParams["mShortTable"] = "dbo_TIPOEMPLEADO";
			masterParams["masterKeys"] = SettingsMap.GetArray();
			masterParams["detailKeys"] = SettingsMap.GetArray();
			masterParams["type"] = Constants.PAGE_LIST;
			GlobalVars.masterTablesData["Saldo_Horas_Empleado"][0] = masterParams;
			GlobalVars.masterTablesData["Saldo_Horas_Empleado"][0]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["Saldo_Horas_Empleado"][0]["masterKeys"].Add("id_tipo");
			GlobalVars.masterTablesData["Saldo_Horas_Empleado"][0]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["Saldo_Horas_Empleado"][0]["detailKeys"].Add("id_tipo");


			strOriginalDetailsTable = "dbo.DEPARTAMENTO";
			masterParams = SettingsMap.GetArray();
			masterParams["mDataSourceTable"] = "dbo.DEPARTAMENTO";
			masterParams["mOriginalTable"] = strOriginalDetailsTable;
			masterParams["mShortTable"] = "dbo_DEPARTAMENTO";
			masterParams["masterKeys"] = SettingsMap.GetArray();
			masterParams["detailKeys"] = SettingsMap.GetArray();
			masterParams["type"] = Constants.PAGE_LIST;
			GlobalVars.masterTablesData["Saldo_Horas_Empleado"][1] = masterParams;
			GlobalVars.masterTablesData["Saldo_Horas_Empleado"][1]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["Saldo_Horas_Empleado"][1]["masterKeys"].Add("id_departamento");
			GlobalVars.masterTablesData["Saldo_Horas_Empleado"][1]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["Saldo_Horas_Empleado"][1]["detailKeys"].Add("id_departamento");


			strOriginalDetailsTable = "dbo.HORARIOS";
			masterParams = SettingsMap.GetArray();
			masterParams["mDataSourceTable"] = "dbo.HORARIOS";
			masterParams["mOriginalTable"] = strOriginalDetailsTable;
			masterParams["mShortTable"] = "dbo_HORARIOS";
			masterParams["masterKeys"] = SettingsMap.GetArray();
			masterParams["detailKeys"] = SettingsMap.GetArray();
			masterParams["type"] = Constants.PAGE_LIST;
			GlobalVars.masterTablesData["Saldo_Horas_Empleado"][2] = masterParams;
			GlobalVars.masterTablesData["Saldo_Horas_Empleado"][2]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["Saldo_Horas_Empleado"][2]["masterKeys"].Add("id_horarios");
			GlobalVars.masterTablesData["Saldo_Horas_Empleado"][2]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["Saldo_Horas_Empleado"][2]["detailKeys"].Add("id_horarios");

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "dbo.EMPLEADO.ONI,  dbo.EMPLEADO.nombre,  dbo.TIPOEMPLEADO.tipo_empleado,  dbo.HORARIOS.horarios,  dbo.DEPARTAMENTO.departamento,  	(SELECT  		SUM(DATEDIFF(Hour, fecha_inicio, fecha_final))  		FROM  		dbo.Permisos2  		WHERE  		datepart(yy, dbo.Permisos2.fecha_solicitud)= datepart(yy, getdate())  		AND dbo.Permisos2.ONI=dbo.EMPLEADO.ONI  		AND dbo.Permisos2.id_estado_personal = 2) AS Horas_personales_tomadas,  dbo.HORARIOS.horas_permisos_personales as Horas_personales_asignadas,  	(SELECT  		sum(dbo.REGISTRO_HORAS_COMPESADAS.cantidad_horas_compesadas) as Horas_compesadas  		FROM  		dbo.REGISTRO_HORAS_COMPESADAS  		WHERE  		dbo.REGISTRO_HORAS_COMPESADAS.id_estado_compesado = 2 AND  		dbo.REGISTRO_HORAS_COMPESADAS.ONI = dbo.EMPLEADO.ONI) as Horas_compesadas_disponible";
protoArray["0"]["m_strFrom"] = "FROM  dbo.EMPLEADO  INNER JOIN dbo.HORARIOS ON dbo.EMPLEADO.id_horarios = dbo.HORARIOS.id_horarios  INNER JOIN dbo.TIPOEMPLEADO ON dbo.EMPLEADO.id_tipo = dbo.TIPOEMPLEADO.id_tipo  INNER JOIN dbo.DEPARTAMENTO ON dbo.EMPLEADO.id_departamento = dbo.DEPARTAMENTO.id_departamento";
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
obj = new SQLField(new XVar("m_strName", "ONI", "m_strTable", "dbo.EMPLEADO", "m_srcTableName", "Saldo_Horas_Empleado"));

protoArray["6"]["m_sql"] = "dbo.EMPLEADO.ONI";
protoArray["6"]["m_srcTableName"] = "Saldo_Horas_Empleado";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "nombre", "m_strTable", "dbo.EMPLEADO", "m_srcTableName", "Saldo_Horas_Empleado"));

protoArray["8"]["m_sql"] = "dbo.EMPLEADO.nombre";
protoArray["8"]["m_srcTableName"] = "Saldo_Horas_Empleado";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["10"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "tipo_empleado", "m_strTable", "dbo.TIPOEMPLEADO", "m_srcTableName", "Saldo_Horas_Empleado"));

protoArray["10"]["m_sql"] = "dbo.TIPOEMPLEADO.tipo_empleado";
protoArray["10"]["m_srcTableName"] = "Saldo_Horas_Empleado";
protoArray["10"]["m_expr"] = obj;
protoArray["10"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["10"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["12"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "horarios", "m_strTable", "dbo.HORARIOS", "m_srcTableName", "Saldo_Horas_Empleado"));

protoArray["12"]["m_sql"] = "dbo.HORARIOS.horarios";
protoArray["12"]["m_srcTableName"] = "Saldo_Horas_Empleado";
protoArray["12"]["m_expr"] = obj;
protoArray["12"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["12"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["14"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "departamento", "m_strTable", "dbo.DEPARTAMENTO", "m_srcTableName", "Saldo_Horas_Empleado"));

protoArray["14"]["m_sql"] = "dbo.DEPARTAMENTO.departamento";
protoArray["14"]["m_srcTableName"] = "Saldo_Horas_Empleado";
protoArray["14"]["m_expr"] = obj;
protoArray["14"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["14"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["16"] = SettingsMap.GetArray();
protoArray["17"] = SettingsMap.GetArray();
protoArray["17"]["m_strHead"] = "SELECT";
protoArray["17"]["m_strFieldList"] = "SUM(DATEDIFF(Hour, fecha_inicio, fecha_final))";
protoArray["17"]["m_strFrom"] = "FROM  		dbo.Permisos2";
protoArray["17"]["m_strWhere"] = "datepart(yy, dbo.Permisos2.fecha_solicitud)= datepart(yy, getdate())  		AND dbo.Permisos2.ONI=dbo.EMPLEADO.ONI  		AND dbo.Permisos2.id_estado_personal = 2";
protoArray["17"]["m_strOrderBy"] = "";
	
		
protoArray["17"]["cipherer"] = null;
protoArray["19"] = SettingsMap.GetArray();
protoArray["19"]["m_sql"] = "datepart(yy, dbo.Permisos2.fecha_solicitud)= datepart(yy, getdate())  		AND dbo.Permisos2.ONI=dbo.EMPLEADO.ONI  		AND dbo.Permisos2.id_estado_personal = 2";
protoArray["19"]["m_uniontype"] = "SQLL_AND";
obj = new SQLNonParsed(new XVar("m_sql", "datepart(yy, dbo.Permisos2.fecha_solicitud)= datepart(yy, getdate())  		AND dbo.Permisos2.ONI=dbo.EMPLEADO.ONI  		AND dbo.Permisos2.id_estado_personal = 2"));

protoArray["19"]["m_column"] = obj;
protoArray["19"]["m_contained"] = SettingsMap.GetArray();
protoArray["21"] = SettingsMap.GetArray();
protoArray["21"]["m_sql"] = "datepart(yy, dbo.Permisos2.fecha_solicitud)= datepart(yy, getdate())";
protoArray["21"]["m_uniontype"] = "SQLL_UNKNOWN";
protoArray["22"] = SettingsMap.GetArray();
protoArray["22"]["m_functiontype"] = "SQLF_CUSTOM";
protoArray["22"]["m_arguments"] = SettingsMap.GetArray();
obj = new SQLNonParsed(new XVar("m_sql", "yy"));

protoArray["22"]["m_arguments"].Add(obj);
obj = new SQLNonParsed(new XVar("m_sql", "dbo.Permisos2.fecha_solicitud"));

protoArray["22"]["m_arguments"].Add(obj);
protoArray["22"]["m_strFunctionName"] = "datepart";
obj = new SQLFunctionCall(protoArray["22"]);

protoArray["21"]["m_column"] = obj;
protoArray["21"]["m_contained"] = SettingsMap.GetArray();
protoArray["21"]["m_strCase"] = "= datepart(yy, getdate())";
protoArray["21"]["m_havingmode"] = false;
protoArray["21"]["m_inBrackets"] = false;
protoArray["21"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["21"]);

protoArray["19"]["m_contained"].Add(obj);
protoArray["25"] = SettingsMap.GetArray();
protoArray["25"]["m_sql"] = "dbo.Permisos2.ONI=dbo.EMPLEADO.ONI";
protoArray["25"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLField(new XVar("m_strName", "ONI", "m_strTable", "dbo.Permisos2", "m_srcTableName", "Saldo_Horas_Empleado"));

protoArray["25"]["m_column"] = obj;
protoArray["25"]["m_contained"] = SettingsMap.GetArray();
protoArray["25"]["m_strCase"] = "=dbo.EMPLEADO.ONI";
protoArray["25"]["m_havingmode"] = false;
protoArray["25"]["m_inBrackets"] = false;
protoArray["25"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["25"]);

protoArray["19"]["m_contained"].Add(obj);
protoArray["27"] = SettingsMap.GetArray();
protoArray["27"]["m_sql"] = "dbo.Permisos2.id_estado_personal = 2";
protoArray["27"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLField(new XVar("m_strName", "id_estado_personal", "m_strTable", "dbo.Permisos2", "m_srcTableName", "Saldo_Horas_Empleado"));

protoArray["27"]["m_column"] = obj;
protoArray["27"]["m_contained"] = SettingsMap.GetArray();
protoArray["27"]["m_strCase"] = "= 2";
protoArray["27"]["m_havingmode"] = false;
protoArray["27"]["m_inBrackets"] = false;
protoArray["27"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["27"]);

protoArray["19"]["m_contained"].Add(obj);
protoArray["19"]["m_strCase"] = "";
protoArray["19"]["m_havingmode"] = false;
protoArray["19"]["m_inBrackets"] = false;
protoArray["19"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["19"]);

protoArray["17"]["m_where"] = obj;
protoArray["29"] = SettingsMap.GetArray();
protoArray["29"]["m_sql"] = "";
protoArray["29"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLNonParsed(new XVar("m_sql", ""));

protoArray["29"]["m_column"] = obj;
protoArray["29"]["m_contained"] = SettingsMap.GetArray();
protoArray["29"]["m_strCase"] = "";
protoArray["29"]["m_havingmode"] = false;
protoArray["29"]["m_inBrackets"] = false;
protoArray["29"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["29"]);

protoArray["17"]["m_having"] = obj;
protoArray["17"]["m_fieldlist"] = SettingsMap.GetArray();
protoArray["31"] = SettingsMap.GetArray();
protoArray["32"] = SettingsMap.GetArray();
protoArray["32"]["m_functiontype"] = "SQLF_SUM";
protoArray["32"]["m_arguments"] = SettingsMap.GetArray();
protoArray["33"] = SettingsMap.GetArray();
protoArray["33"]["m_functiontype"] = "SQLF_CUSTOM";
protoArray["33"]["m_arguments"] = SettingsMap.GetArray();
obj = new SQLNonParsed(new XVar("m_sql", "Hour"));

protoArray["33"]["m_arguments"].Add(obj);
obj = new SQLNonParsed(new XVar("m_sql", "fecha_inicio"));

protoArray["33"]["m_arguments"].Add(obj);
obj = new SQLNonParsed(new XVar("m_sql", "fecha_final"));

protoArray["33"]["m_arguments"].Add(obj);
protoArray["33"]["m_strFunctionName"] = "DATEDIFF";
obj = new SQLFunctionCall(protoArray["33"]);

protoArray["32"]["m_arguments"].Add(obj);
protoArray["32"]["m_strFunctionName"] = "SUM";
obj = new SQLFunctionCall(protoArray["32"]);

protoArray["31"]["m_sql"] = "SUM(DATEDIFF(Hour, fecha_inicio, fecha_final))";
protoArray["31"]["m_srcTableName"] = "Saldo_Horas_Empleado";
protoArray["31"]["m_expr"] = obj;
protoArray["31"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["31"]);

protoArray["17"]["m_fieldlist"].Add(obj);
protoArray["17"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["37"] = SettingsMap.GetArray();
protoArray["37"]["m_link"] = "SQLL_MAIN";
protoArray["38"] = SettingsMap.GetArray();
protoArray["38"]["m_strName"] = "dbo.Permisos2";
protoArray["38"]["m_srcTableName"] = "Saldo_Horas_Empleado";
protoArray["38"]["m_columns"] = SettingsMap.GetArray();
protoArray["38"]["m_columns"].Add("id_permisos");
protoArray["38"]["m_columns"].Add("ONI");
protoArray["38"]["m_columns"].Add("id_tipopermiso");
protoArray["38"]["m_columns"].Add("fecha_solicitud");
protoArray["38"]["m_columns"].Add("motivo");
protoArray["38"]["m_columns"].Add("adjunto");
protoArray["38"]["m_columns"].Add("id_estado_personal");
protoArray["38"]["m_columns"].Add("Observaciones");
protoArray["38"]["m_columns"].Add("fecha_inicio");
protoArray["38"]["m_columns"].Add("fecha_final");
protoArray["38"]["m_columns"].Add("vistobueno1");
protoArray["38"]["m_columns"].Add("vistobueno2");
obj = new SQLTable(protoArray["38"]);

protoArray["37"]["m_table"] = obj;
protoArray["37"]["m_sql"] = "dbo.Permisos2";
protoArray["37"]["m_alias"] = "";
protoArray["37"]["m_srcTableName"] = "Saldo_Horas_Empleado";
protoArray["39"] = SettingsMap.GetArray();
protoArray["39"]["m_sql"] = "";
protoArray["39"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLNonParsed(new XVar("m_sql", ""));

protoArray["39"]["m_column"] = obj;
protoArray["39"]["m_contained"] = SettingsMap.GetArray();
protoArray["39"]["m_strCase"] = "";
protoArray["39"]["m_havingmode"] = false;
protoArray["39"]["m_inBrackets"] = false;
protoArray["39"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["39"]);

protoArray["37"]["m_joinon"] = obj;
obj = new SQLFromListItem(protoArray["37"]);

protoArray["17"]["m_fromlist"].Add(obj);
protoArray["17"]["m_groupby"] = SettingsMap.GetArray();
protoArray["17"]["m_orderby"] = SettingsMap.GetArray();
protoArray["17"]["m_srcTableName"] = "Saldo_Horas_Empleado";
obj = new SQLQuery(protoArray["17"]);

protoArray["16"]["m_sql"] = "(SELECT  		SUM(DATEDIFF(Hour, fecha_inicio, fecha_final))  		FROM  		dbo.Permisos2  		WHERE  		datepart(yy, dbo.Permisos2.fecha_solicitud)= datepart(yy, getdate())  		AND dbo.Permisos2.ONI=dbo.EMPLEADO.ONI  		AND dbo.Permisos2.id_estado_personal = 2)";
protoArray["16"]["m_srcTableName"] = "Saldo_Horas_Empleado";
protoArray["16"]["m_expr"] = obj;
protoArray["16"]["m_alias"] = "Horas_personales_tomadas";
obj = new SQLFieldListItem(protoArray["16"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["41"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "horas_permisos_personales", "m_strTable", "dbo.HORARIOS", "m_srcTableName", "Saldo_Horas_Empleado"));

protoArray["41"]["m_sql"] = "dbo.HORARIOS.horas_permisos_personales";
protoArray["41"]["m_srcTableName"] = "Saldo_Horas_Empleado";
protoArray["41"]["m_expr"] = obj;
protoArray["41"]["m_alias"] = "Horas_personales_asignadas";
obj = new SQLFieldListItem(protoArray["41"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["43"] = SettingsMap.GetArray();
protoArray["44"] = SettingsMap.GetArray();
protoArray["44"]["m_strHead"] = "SELECT";
protoArray["44"]["m_strFieldList"] = "sum(dbo.REGISTRO_HORAS_COMPESADAS.cantidad_horas_compesadas) as Horas_compesadas";
protoArray["44"]["m_strFrom"] = "FROM  		dbo.REGISTRO_HORAS_COMPESADAS";
protoArray["44"]["m_strWhere"] = "dbo.REGISTRO_HORAS_COMPESADAS.id_estado_compesado = 2 AND  		dbo.REGISTRO_HORAS_COMPESADAS.ONI = dbo.EMPLEADO.ONI";
protoArray["44"]["m_strOrderBy"] = "";
	
		
protoArray["44"]["cipherer"] = null;
protoArray["46"] = SettingsMap.GetArray();
protoArray["46"]["m_sql"] = "dbo.REGISTRO_HORAS_COMPESADAS.id_estado_compesado = 2 AND  		dbo.REGISTRO_HORAS_COMPESADAS.ONI = dbo.EMPLEADO.ONI";
protoArray["46"]["m_uniontype"] = "SQLL_AND";
obj = new SQLNonParsed(new XVar("m_sql", "dbo.REGISTRO_HORAS_COMPESADAS.id_estado_compesado = 2 AND  		dbo.REGISTRO_HORAS_COMPESADAS.ONI = dbo.EMPLEADO.ONI"));

protoArray["46"]["m_column"] = obj;
protoArray["46"]["m_contained"] = SettingsMap.GetArray();
protoArray["48"] = SettingsMap.GetArray();
protoArray["48"]["m_sql"] = "dbo.REGISTRO_HORAS_COMPESADAS.id_estado_compesado = 2";
protoArray["48"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLField(new XVar("m_strName", "id_estado_compesado", "m_strTable", "dbo.REGISTRO_HORAS_COMPESADAS", "m_srcTableName", "Saldo_Horas_Empleado"));

protoArray["48"]["m_column"] = obj;
protoArray["48"]["m_contained"] = SettingsMap.GetArray();
protoArray["48"]["m_strCase"] = "= 2";
protoArray["48"]["m_havingmode"] = false;
protoArray["48"]["m_inBrackets"] = false;
protoArray["48"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["48"]);

protoArray["46"]["m_contained"].Add(obj);
protoArray["50"] = SettingsMap.GetArray();
protoArray["50"]["m_sql"] = "dbo.REGISTRO_HORAS_COMPESADAS.ONI = dbo.EMPLEADO.ONI";
protoArray["50"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLField(new XVar("m_strName", "ONI", "m_strTable", "dbo.REGISTRO_HORAS_COMPESADAS", "m_srcTableName", "Saldo_Horas_Empleado"));

protoArray["50"]["m_column"] = obj;
protoArray["50"]["m_contained"] = SettingsMap.GetArray();
protoArray["50"]["m_strCase"] = "= dbo.EMPLEADO.ONI";
protoArray["50"]["m_havingmode"] = false;
protoArray["50"]["m_inBrackets"] = false;
protoArray["50"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["50"]);

protoArray["46"]["m_contained"].Add(obj);
protoArray["46"]["m_strCase"] = "";
protoArray["46"]["m_havingmode"] = false;
protoArray["46"]["m_inBrackets"] = false;
protoArray["46"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["46"]);

protoArray["44"]["m_where"] = obj;
protoArray["52"] = SettingsMap.GetArray();
protoArray["52"]["m_sql"] = "";
protoArray["52"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLNonParsed(new XVar("m_sql", ""));

protoArray["52"]["m_column"] = obj;
protoArray["52"]["m_contained"] = SettingsMap.GetArray();
protoArray["52"]["m_strCase"] = "";
protoArray["52"]["m_havingmode"] = false;
protoArray["52"]["m_inBrackets"] = false;
protoArray["52"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["52"]);

protoArray["44"]["m_having"] = obj;
protoArray["44"]["m_fieldlist"] = SettingsMap.GetArray();
protoArray["54"] = SettingsMap.GetArray();
protoArray["55"] = SettingsMap.GetArray();
protoArray["55"]["m_functiontype"] = "SQLF_SUM";
protoArray["55"]["m_arguments"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "cantidad_horas_compesadas", "m_strTable", "dbo.REGISTRO_HORAS_COMPESADAS", "m_srcTableName", "Saldo_Horas_Empleado"));

protoArray["55"]["m_arguments"].Add(obj);
protoArray["55"]["m_strFunctionName"] = "sum";
obj = new SQLFunctionCall(protoArray["55"]);

protoArray["54"]["m_sql"] = "sum(dbo.REGISTRO_HORAS_COMPESADAS.cantidad_horas_compesadas)";
protoArray["54"]["m_srcTableName"] = "Saldo_Horas_Empleado";
protoArray["54"]["m_expr"] = obj;
protoArray["54"]["m_alias"] = "Horas_compesadas";
obj = new SQLFieldListItem(protoArray["54"]);

protoArray["44"]["m_fieldlist"].Add(obj);
protoArray["44"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["57"] = SettingsMap.GetArray();
protoArray["57"]["m_link"] = "SQLL_MAIN";
protoArray["58"] = SettingsMap.GetArray();
protoArray["58"]["m_strName"] = "dbo.REGISTRO_HORAS_COMPESADAS";
protoArray["58"]["m_srcTableName"] = "Saldo_Horas_Empleado";
protoArray["58"]["m_columns"] = SettingsMap.GetArray();
protoArray["58"]["m_columns"].Add("id_compesados");
protoArray["58"]["m_columns"].Add("ONI");
protoArray["58"]["m_columns"].Add("fecha_compesado");
protoArray["58"]["m_columns"].Add("hora_realizado_inicio");
protoArray["58"]["m_columns"].Add("hora_realizado_fin");
protoArray["58"]["m_columns"].Add("cantidad_horas_compesadas");
protoArray["58"]["m_columns"].Add("justificacion");
protoArray["58"]["m_columns"].Add("anexo");
protoArray["58"]["m_columns"].Add("observacion");
protoArray["58"]["m_columns"].Add("id_estado_compesado");
protoArray["58"]["m_columns"].Add("vistobueno1");
protoArray["58"]["m_columns"].Add("vistobueno2");
protoArray["58"]["m_columns"].Add("desde");
protoArray["58"]["m_columns"].Add("hasta");
protoArray["58"]["m_columns"].Add("fecha_creacion");
obj = new SQLTable(protoArray["58"]);

protoArray["57"]["m_table"] = obj;
protoArray["57"]["m_sql"] = "dbo.REGISTRO_HORAS_COMPESADAS";
protoArray["57"]["m_alias"] = "";
protoArray["57"]["m_srcTableName"] = "Saldo_Horas_Empleado";
protoArray["59"] = SettingsMap.GetArray();
protoArray["59"]["m_sql"] = "";
protoArray["59"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLNonParsed(new XVar("m_sql", ""));

protoArray["59"]["m_column"] = obj;
protoArray["59"]["m_contained"] = SettingsMap.GetArray();
protoArray["59"]["m_strCase"] = "";
protoArray["59"]["m_havingmode"] = false;
protoArray["59"]["m_inBrackets"] = false;
protoArray["59"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["59"]);

protoArray["57"]["m_joinon"] = obj;
obj = new SQLFromListItem(protoArray["57"]);

protoArray["44"]["m_fromlist"].Add(obj);
protoArray["44"]["m_groupby"] = SettingsMap.GetArray();
protoArray["44"]["m_orderby"] = SettingsMap.GetArray();
protoArray["44"]["m_srcTableName"] = "Saldo_Horas_Empleado";
obj = new SQLQuery(protoArray["44"]);

protoArray["43"]["m_sql"] = "(SELECT  		sum(dbo.REGISTRO_HORAS_COMPESADAS.cantidad_horas_compesadas) as Horas_compesadas  		FROM  		dbo.REGISTRO_HORAS_COMPESADAS  		WHERE  		dbo.REGISTRO_HORAS_COMPESADAS.id_estado_compesado = 2 AND  		dbo.REGISTRO_HORAS_COMPESADAS.ONI = dbo.EMPLEADO.ONI)";
protoArray["43"]["m_srcTableName"] = "Saldo_Horas_Empleado";
protoArray["43"]["m_expr"] = obj;
protoArray["43"]["m_alias"] = "Horas_compesadas_disponible";
obj = new SQLFieldListItem(protoArray["43"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["61"] = SettingsMap.GetArray();
protoArray["61"]["m_link"] = "SQLL_MAIN";
protoArray["62"] = SettingsMap.GetArray();
protoArray["62"]["m_strName"] = "dbo.EMPLEADO";
protoArray["62"]["m_srcTableName"] = "Saldo_Horas_Empleado";
protoArray["62"]["m_columns"] = SettingsMap.GetArray();
protoArray["62"]["m_columns"].Add("ONI");
protoArray["62"]["m_columns"].Add("nombre");
protoArray["62"]["m_columns"].Add("password");
protoArray["62"]["m_columns"].Add("id_tipo");
protoArray["62"]["m_columns"].Add("id_departamento");
protoArray["62"]["m_columns"].Add("id_horarios");
protoArray["62"]["m_columns"].Add("saldo_personales");
protoArray["62"]["m_columns"].Add("saldo_compesado");
protoArray["62"]["m_columns"].Add("foto");
protoArray["62"]["m_columns"].Add("id_grupo");
obj = new SQLTable(protoArray["62"]);

protoArray["61"]["m_table"] = obj;
protoArray["61"]["m_sql"] = "dbo.EMPLEADO";
protoArray["61"]["m_alias"] = "";
protoArray["61"]["m_srcTableName"] = "Saldo_Horas_Empleado";
protoArray["63"] = SettingsMap.GetArray();
protoArray["63"]["m_sql"] = "";
protoArray["63"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLNonParsed(new XVar("m_sql", ""));

protoArray["63"]["m_column"] = obj;
protoArray["63"]["m_contained"] = SettingsMap.GetArray();
protoArray["63"]["m_strCase"] = "";
protoArray["63"]["m_havingmode"] = false;
protoArray["63"]["m_inBrackets"] = false;
protoArray["63"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["63"]);

protoArray["61"]["m_joinon"] = obj;
obj = new SQLFromListItem(protoArray["61"]);

protoArray["0"]["m_fromlist"].Add(obj);
protoArray["65"] = SettingsMap.GetArray();
protoArray["65"]["m_link"] = "SQLL_INNERJOIN";
protoArray["66"] = SettingsMap.GetArray();
protoArray["66"]["m_strName"] = "dbo.HORARIOS";
protoArray["66"]["m_srcTableName"] = "Saldo_Horas_Empleado";
protoArray["66"]["m_columns"] = SettingsMap.GetArray();
protoArray["66"]["m_columns"].Add("id_horarios");
protoArray["66"]["m_columns"].Add("horarios");
protoArray["66"]["m_columns"].Add("dia_inicio");
protoArray["66"]["m_columns"].Add("dia_final");
protoArray["66"]["m_columns"].Add("hora_inicio");
protoArray["66"]["m_columns"].Add("hora_final");
protoArray["66"]["m_columns"].Add("cantidad_horas");
protoArray["66"]["m_columns"].Add("horas_permisos_personales");
obj = new SQLTable(protoArray["66"]);

protoArray["65"]["m_table"] = obj;
protoArray["65"]["m_sql"] = "INNER JOIN dbo.HORARIOS ON dbo.EMPLEADO.id_horarios = dbo.HORARIOS.id_horarios";
protoArray["65"]["m_alias"] = "";
protoArray["65"]["m_srcTableName"] = "Saldo_Horas_Empleado";
protoArray["67"] = SettingsMap.GetArray();
protoArray["67"]["m_sql"] = "dbo.EMPLEADO.id_horarios = dbo.HORARIOS.id_horarios";
protoArray["67"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLField(new XVar("m_strName", "id_horarios", "m_strTable", "dbo.EMPLEADO", "m_srcTableName", "Saldo_Horas_Empleado"));

protoArray["67"]["m_column"] = obj;
protoArray["67"]["m_contained"] = SettingsMap.GetArray();
protoArray["67"]["m_strCase"] = "= dbo.HORARIOS.id_horarios";
protoArray["67"]["m_havingmode"] = false;
protoArray["67"]["m_inBrackets"] = false;
protoArray["67"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["67"]);

protoArray["65"]["m_joinon"] = obj;
obj = new SQLFromListItem(protoArray["65"]);

protoArray["0"]["m_fromlist"].Add(obj);
protoArray["69"] = SettingsMap.GetArray();
protoArray["69"]["m_link"] = "SQLL_INNERJOIN";
protoArray["70"] = SettingsMap.GetArray();
protoArray["70"]["m_strName"] = "dbo.TIPOEMPLEADO";
protoArray["70"]["m_srcTableName"] = "Saldo_Horas_Empleado";
protoArray["70"]["m_columns"] = SettingsMap.GetArray();
protoArray["70"]["m_columns"].Add("id_tipo");
protoArray["70"]["m_columns"].Add("tipo_empleado");
obj = new SQLTable(protoArray["70"]);

protoArray["69"]["m_table"] = obj;
protoArray["69"]["m_sql"] = "INNER JOIN dbo.TIPOEMPLEADO ON dbo.EMPLEADO.id_tipo = dbo.TIPOEMPLEADO.id_tipo";
protoArray["69"]["m_alias"] = "";
protoArray["69"]["m_srcTableName"] = "Saldo_Horas_Empleado";
protoArray["71"] = SettingsMap.GetArray();
protoArray["71"]["m_sql"] = "dbo.EMPLEADO.id_tipo = dbo.TIPOEMPLEADO.id_tipo";
protoArray["71"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLField(new XVar("m_strName", "id_tipo", "m_strTable", "dbo.EMPLEADO", "m_srcTableName", "Saldo_Horas_Empleado"));

protoArray["71"]["m_column"] = obj;
protoArray["71"]["m_contained"] = SettingsMap.GetArray();
protoArray["71"]["m_strCase"] = "= dbo.TIPOEMPLEADO.id_tipo";
protoArray["71"]["m_havingmode"] = false;
protoArray["71"]["m_inBrackets"] = false;
protoArray["71"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["71"]);

protoArray["69"]["m_joinon"] = obj;
obj = new SQLFromListItem(protoArray["69"]);

protoArray["0"]["m_fromlist"].Add(obj);
protoArray["73"] = SettingsMap.GetArray();
protoArray["73"]["m_link"] = "SQLL_INNERJOIN";
protoArray["74"] = SettingsMap.GetArray();
protoArray["74"]["m_strName"] = "dbo.DEPARTAMENTO";
protoArray["74"]["m_srcTableName"] = "Saldo_Horas_Empleado";
protoArray["74"]["m_columns"] = SettingsMap.GetArray();
protoArray["74"]["m_columns"].Add("id_departamento");
protoArray["74"]["m_columns"].Add("departamento");
protoArray["74"]["m_columns"].Add("limite_permisos");
obj = new SQLTable(protoArray["74"]);

protoArray["73"]["m_table"] = obj;
protoArray["73"]["m_sql"] = "INNER JOIN dbo.DEPARTAMENTO ON dbo.EMPLEADO.id_departamento = dbo.DEPARTAMENTO.id_departamento";
protoArray["73"]["m_alias"] = "";
protoArray["73"]["m_srcTableName"] = "Saldo_Horas_Empleado";
protoArray["75"] = SettingsMap.GetArray();
protoArray["75"]["m_sql"] = "dbo.EMPLEADO.id_departamento = dbo.DEPARTAMENTO.id_departamento";
protoArray["75"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLField(new XVar("m_strName", "id_departamento", "m_strTable", "dbo.EMPLEADO", "m_srcTableName", "Saldo_Horas_Empleado"));

protoArray["75"]["m_column"] = obj;
protoArray["75"]["m_contained"] = SettingsMap.GetArray();
protoArray["75"]["m_strCase"] = "= dbo.DEPARTAMENTO.id_departamento";
protoArray["75"]["m_havingmode"] = false;
protoArray["75"]["m_inBrackets"] = false;
protoArray["75"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["75"]);

protoArray["73"]["m_joinon"] = obj;
obj = new SQLFromListItem(protoArray["73"]);

protoArray["0"]["m_fromlist"].Add(obj);
protoArray["0"]["m_groupby"] = SettingsMap.GetArray();
protoArray["0"]["m_orderby"] = SettingsMap.GetArray();
protoArray["0"]["m_srcTableName"] = "Saldo_Horas_Empleado";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["Saldo_Horas_Empleado"] = obj;

				
		
			tdataArray["Saldo_Horas_Empleado"][".sqlquery"] = queryData_Array["Saldo_Horas_Empleado"];
			GlobalVars.tableEvents["Saldo_Horas_Empleado"] = new eventsBase();
			tdataArray["Saldo_Horas_Empleado"][".hasEvents"] = false;
			GlobalVars.tables_data["Saldo_Horas_Empleado"] = tdataArray["Saldo_Horas_Empleado"];
		}
	}

}
