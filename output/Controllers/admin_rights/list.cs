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
	public partial class admin_rightsController : BaseController
	{
		public ActionResult list()
		{
			try
			{
				dynamic mask = null, options = XVar.Array(), pageMask = XVar.Array(), pageObject = null, table = null, tables = XVar.Array();
				XTempl xt;
				MVCFunctions.Header("Expires", "Thu, 01 Jan 1970 00:00:01 GMT");
				admin_rights_Variables.Apply();
				if(XVar.Pack(!(XVar)(Security.processAdminPageSecurity(new XVar(false)))))
				{
					return MVCFunctions.GetBuferContentAndClearBufer();
				}
				tables = XVar.Clone(XVar.Array());
				pageMask = XVar.Clone(XVar.Array());
				table = new XVar("dbo.DEPARTAMENTO");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "dbo_DEPARTAMENTO", 1, MVCFunctions.Concat(" ", "DEPARTAMENTO")), table);
				table = new XVar("dbo.EMPLEADO");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "dbo_EMPLEADO", 1, MVCFunctions.Concat(" ", "EMPLEADO")), table);
				table = new XVar("dbo.ESTADO_COMPESADO");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "dbo_ESTADO_COMPESADO", 1, MVCFunctions.Concat(" ", "ESTADO COMPESADO")), table);
				table = new XVar("dbo.ESTADO_PERSONALES");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "dbo_ESTADO_PERSONALES", 1, MVCFunctions.Concat(" ", "ESTADO PERSONALES")), table);
				table = new XVar("dbo.HORARIOS");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "dbo_HORARIOS", 1, MVCFunctions.Concat(" ", "HORARIOS")), table);
				table = new XVar("dbo.Permisos2");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "dbo_Permisos2", 1, MVCFunctions.Concat(" ", "Permisos2")), table);
				table = new XVar("dbo.PERMISOSGRUPOS");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "dbo_PERMISOSGRUPOS", 1, MVCFunctions.Concat(" ", "PERMISOSGRUPOS")), table);
				table = new XVar("dbo.Preferencias");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "dbo_Preferencias", 1, MVCFunctions.Concat(" ", "Preferencias")), table);
				table = new XVar("dbo.REGISTRO_HORAS_COMPESADAS");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "dbo_REGISTRO_HORAS_COMPESADAS", 1, MVCFunctions.Concat(" ", "REGISTRO HORAS COMPESADAS")), table);
				table = new XVar("dbo.TIPOEMPLEADO");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "dbo_TIPOEMPLEADO", 1, MVCFunctions.Concat(" ", "TIPOEMPLEADO")), table);
				table = new XVar("dbo.TIPOPERMISO");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "dbo_TIPOPERMISO", 1, MVCFunctions.Concat(" ", "TIPOPERMISO")), table);
				table = new XVar("APROBAR_PERMISOS");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "APROBAR_PERMISOS", 1, MVCFunctions.Concat(" ", "APROBAR PERMISOS")), table);
				table = new XVar("VISTOBUENO_JEFEINMEDIATO");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "VISTOBUENO_JEFEINMEDIATO", 1, MVCFunctions.Concat(" ", "VISTOBUENO JEFEINMEDIATO")), table);
				table = new XVar("VISTOBUENO_JEFEDEPARTAMENTO");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "VISTOBUENO_JEFEDEPARTAMENTO", 1, MVCFunctions.Concat(" ", "VISTOBUENO JEFEDEPARTAMENTO")), table);
				table = new XVar("VER_PERMISOS");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "VER_PERMISOS", 1, MVCFunctions.Concat(" ", "VER PERMISOS")), table);
				table = new XVar("Saldo_Horas_Empleado");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "Saldo_Horas_Empleado", 1, MVCFunctions.Concat(" ", "Saldo Horas Empleado")), table);
				table = new XVar("VER_COMPESADOS");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "VER_COMPESADOS", 1, MVCFunctions.Concat(" ", "VER COMPESADOS")), table);
				table = new XVar("APROBACION_COMPESADOS_JEFEINMEDIATO");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "APROBACION_COMPESADOS_JEFEINMEDIATO", 1, MVCFunctions.Concat(" ", "APROBACION COMPESADOS JEFEINMEDIATO")), table);
				table = new XVar("APROBACION_COMPESADOS_JEFEDEPARTAMENTO");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "APROBACION_COMPESADOS_JEFEDEPARTAMENTO", 1, MVCFunctions.Concat(" ", "APROBACION COMPESADOS JEFEDEPARTAMENTO")), table);
				table = new XVar("APROBAR_COMPESADOS");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "APROBAR_COMPESADOS", 1, MVCFunctions.Concat(" ", "APROBAR COMPESADOS")), table);
				table = new XVar("INGRESAR PERMISO");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "INGRESAR_PERMISO", 1, MVCFunctions.Concat(" ", "INGRESAR PERMISO")), table);
				table = new XVar("INGRESAR_COMPESADO");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "INGRESAR_COMPESADO", 1, MVCFunctions.Concat(" ", "INGRESAR COMPESADO")), table);
				table = new XVar("dbo.GRUPOS");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "dbo_GRUPOS", 1, MVCFunctions.Concat(" ", "GRUPOS")), table);
				table = new XVar("dbo.acceso_ugmembers");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "dbo_acceso_ugmembers", 1, MVCFunctions.Concat(" ", "Acceso Ugmembers")), table);
				table = new XVar("Licencias_sin_goce_sueldo");
				mask = new XVar("");
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("add")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_add"))))
				{
					mask = MVCFunctions.Concat(mask, "A");
				}
				if((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("edit")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("inline_edit"))))
				{
					mask = MVCFunctions.Concat(mask, "E");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("delete"))))
				{
					mask = MVCFunctions.Concat(mask, "D");
				}
				if(XVar.Pack(CommonFunctions.pageEnabled((XVar)(table), new XVar("import"))))
				{
					mask = MVCFunctions.Concat(mask, "I");
				}
				if((XVar)((XVar)((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("view")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("list"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("chart"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("report"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("dashboard"))))
				{
					mask = MVCFunctions.Concat(mask, "S");
				}
				if((XVar)((XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("print")))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("rprint"))))  || (XVar)(CommonFunctions.pageEnabled((XVar)(table), new XVar("export"))))
				{
					mask = MVCFunctions.Concat(mask, "P");
				}
				pageMask.InitAndSetArrayItem(mask, table);
				tables.InitAndSetArrayItem(new XVar(0, "Licencias_sin_goce_sueldo", 1, MVCFunctions.Concat(" ", "Licencias Sin Goce Sueldo")), table);
{

TLayout t_layout = null;

t_layout = new TLayout(new XVar("admin_rights_list_bootstrap"), new XVar("OfficeOffice"), new XVar("MobileOffice"));
t_layout.version = 3;
	t_layout.bootstrapTheme = "default";
			t_layout.customCssPageName = "_admin_rights_list";
t_layout.blocks["top"] = XVar.Array();
t_layout.containers["top"] = XVar.Array();
t_layout.containers["top"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "menu" ));
t_layout.containers["menu"] = XVar.Array();
t_layout.containers["menu"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "hdr" ));
t_layout.containers["hdr"] = XVar.Array();
t_layout.containers["hdr"].Add(new XVar("name", "logo", "block", "logo_block", "substyle", 1  ));

t_layout.containers["hdr"].Add(new XVar("name", "bsnavbarcollapse", "block", "collapse_block", "substyle", 1  ));

t_layout.skins["hdr"] = "";


t_layout.containers["menu"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "menu_1" ));
t_layout.containers["menu_1"] = XVar.Array();
t_layout.containers["menu_1"].Add(new XVar("name", "hmenu", "block", "menu_block", "substyle", 1  ));

t_layout.containers["menu_1"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "more" ));
t_layout.containers["more"] = XVar.Array();
t_layout.containers["more"].Add(new XVar("name", "morebutton", "block", "more_list", "substyle", 1  ));

t_layout.containers["more"].Add(new XVar("name", "loggedas", "block", "security_block", "substyle", 1  ));

t_layout.skins["more"] = "";


t_layout.containers["menu_1"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "more_1" ));
t_layout.containers["more_1"] = XVar.Array();
t_layout.containers["more_1"].Add(new XVar("name", "search", "block", "searchform_block", "substyle", 1  ));

t_layout.skins["more_1"] = "";


t_layout.skins["menu_1"] = "";


t_layout.skins["menu"] = "";


t_layout.containers["top"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "breadcrumbs" ));
t_layout.containers["breadcrumbs"] = XVar.Array();
t_layout.containers["breadcrumbs"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "bc" ));
t_layout.containers["bc"] = XVar.Array();
t_layout.containers["bc"].Add(new XVar("name", "breadcrumbs", "block", "breadcrumbs", "substyle", 1  ));

t_layout.skins["bc"] = "";


t_layout.skins["breadcrumbs"] = "";


t_layout.containers["top"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "messagerow" ));
t_layout.containers["messagerow"] = XVar.Array();
t_layout.containers["messagerow"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "message" ));
t_layout.containers["message"] = XVar.Array();
t_layout.containers["message"].Add(new XVar("name", "message", "block", "message_block", "substyle", 1  ));

t_layout.skins["message"] = "";


t_layout.skins["messagerow"] = "";


t_layout.containers["top"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "ugcontrols" ));
t_layout.containers["ugcontrols"] = XVar.Array();
t_layout.containers["ugcontrols"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "save" ));
t_layout.containers["save"] = XVar.Array();
t_layout.containers["save"].Add(new XVar("name", "ugbuttons", "block", "", "substyle", 1  ));

t_layout.skins["save"] = "";


t_layout.containers["ugcontrols"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "filter" ));
t_layout.containers["filter"] = XVar.Array();
t_layout.containers["filter"].Add(new XVar("name", "ugrightbuttons", "block", "savebuttons_block", "substyle", 1  ));

t_layout.skins["filter"] = "";


t_layout.skins["ugcontrols"] = "";


t_layout.containers["top"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "grcontrols" ));
t_layout.containers["grcontrols"] = XVar.Array();
t_layout.containers["grcontrols"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "groupcontrols" ));
t_layout.containers["groupcontrols"] = XVar.Array();
t_layout.containers["groupcontrols"].Add(new XVar("name", "bsugrights_groupbuttons", "block", "", "substyle", 1  ));

t_layout.skins["groupcontrols"] = "";


t_layout.skins["grcontrols"] = "";


t_layout.containers["top"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "uggroups" ));
t_layout.containers["uggroups"] = XVar.Array();
t_layout.containers["uggroups"].Add(new XVar("name", "bsugrightsgroups", "block", "", "substyle", 1  ));

t_layout.skins["uggroups"] = "";


t_layout.containers["top"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "permgrid" ));
t_layout.containers["permgrid"] = XVar.Array();
t_layout.containers["permgrid"].Add(new XVar("name", "ugrightsblock", "block", "", "substyle", 1  ));

t_layout.skins["permgrid"] = "";


t_layout.skins["top"] = "";

t_layout.blocks["top"].Add("top");
GlobalVars.page_layouts["admin_rights_list"] = t_layout;


}

				xt = XVar.UnPackXTempl(new XTempl());
				options = XVar.Clone(XVar.Array());
				options.InitAndSetArrayItem(Constants.PAGE_LIST, "pageType");
				options.InitAndSetArrayItem((XVar.Pack(CommonFunctions.postvalue_number(new XVar("id"))) ? XVar.Pack(CommonFunctions.postvalue_number(new XVar("id"))) : XVar.Pack(1)), "id");
				options.InitAndSetArrayItem(Constants.RIGHTS_PAGE, "mode");
				options.InitAndSetArrayItem(xt, "xt");
				options.InitAndSetArrayItem(tables, "tables");
				options.InitAndSetArrayItem(pageMask, "pageMasks");
				GlobalVars.pageObject = XVar.Clone(ListPage.createListPage((XVar)(GlobalVars.strTableName), (XVar)(options)));
				if(MVCFunctions.postvalue(new XVar("a")) == "saveRights")
				{
					dynamic modifiedRights = null;
					modifiedRights = XVar.Clone(MVCFunctions.my_json_decode((XVar)(MVCFunctions.postvalue(new XVar("values")))));
					GlobalVars.pageObject.saveRights((XVar)(modifiedRights));
					return MVCFunctions.GetBuferContentAndClearBufer();
				}
				GlobalVars.pageObject.prepareForBuildPage();
				GlobalVars.pageObject.showPage();
				ViewBag.xt = xt;
				return View(xt.GetViewPath());
			}
			catch(RunnerRedirectException ex)
			{ return Redirect(ex.Message); }
		}
	}
}
