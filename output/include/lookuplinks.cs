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
	public partial class CommonFunctions
	{
		public static XVar getLookupMainTableSettings(dynamic _param_lookupTable, dynamic _param_mainTableShortName, dynamic _param_mainField, dynamic _param_desiredPage = null)
		{
			#region default values
			if(_param_desiredPage as Object == null) _param_desiredPage = new XVar("");
			#endregion

			#region pass-by-value parameters
			dynamic lookupTable = XVar.Clone(_param_lookupTable);
			dynamic mainTableShortName = XVar.Clone(_param_mainTableShortName);
			dynamic mainField = XVar.Clone(_param_mainField);
			dynamic desiredPage = XVar.Clone(_param_desiredPage);
			#endregion

			dynamic arr = XVar.Array(), effectivePage = null;
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists(lookupTable))))
			{
				return null;
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks[lookupTable].KeyExists(MVCFunctions.Concat(mainTableShortName, ".", mainField)))))
			{
				return null;
			}
			arr = GlobalVars.lookupTableLinks[lookupTable][MVCFunctions.Concat(mainTableShortName, ".", mainField)];
			effectivePage = XVar.Clone(desiredPage);
			if(XVar.Pack(!(XVar)(arr.KeyExists(effectivePage))))
			{
				effectivePage = new XVar(Constants.PAGE_EDIT);
				if(XVar.Pack(!(XVar)(arr.KeyExists(effectivePage))))
				{
					if((XVar)(desiredPage == XVar.Pack(""))  && (XVar)(0 < MVCFunctions.count(arr)))
					{
						effectivePage = XVar.Clone(arr[0]);
					}
					else
					{
						return null;
					}
				}
			}
			return new ProjectSettings((XVar)(arr[effectivePage]["table"]), (XVar)(effectivePage));
		}
		public static XVar InitLookupLinks()
		{
			GlobalVars.lookupTableLinks = XVar.Clone(XVar.Array());
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.EMPLEADO", "field", "id_tipo", "page", "edit"), "dbo.TIPOEMPLEADO", "dbo_EMPLEADO.id_tipo", "edit");
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.EMPLEADO", "field", "id_departamento", "page", "edit"), "dbo.DEPARTAMENTO", "dbo_EMPLEADO.id_departamento", "edit");
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.EMPLEADO", "field", "id_grupo", "page", "edit"), "dbo.GRUPOS", "dbo_EMPLEADO.id_grupo", "edit");
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.EMPLEADO", "field", "id_horarios", "page", "edit"), "dbo.HORARIOS", "dbo_EMPLEADO.id_horarios", "edit");
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.Permisos2", "field", "id_tipopermiso", "page", "edit"), "dbo.TIPOPERMISO", "dbo_Permisos2.id_tipopermiso", "edit");
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.Permisos2", "field", "id_estado_personal", "page", "edit"), "dbo.ESTADO_PERSONALES", "dbo_Permisos2.id_estado_personal", "edit");
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.PERMISOSGRUPOS", "field", "id_departamento", "page", "edit"), "dbo.DEPARTAMENTO", "dbo_PERMISOSGRUPOS.id_departamento", "edit");
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.PERMISOSGRUPOS", "field", "id_grupo", "page", "edit"), "dbo.GRUPOS", "dbo_PERMISOSGRUPOS.id_grupo", "edit");
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.REGISTRO_HORAS_COMPESADAS", "field", "id_estado_compesado", "page", "edit"), "dbo.ESTADO_COMPESADO", "dbo_REGISTRO_HORAS_COMPESADAS.id_estado_compesado", "edit");
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "APROBAR_PERMISOS", "field", "departamento", "page", "edit"), "dbo.DEPARTAMENTO", "APROBAR_PERMISOS.departamento", "edit");
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "APROBAR_PERMISOS", "field", "id_tipopermiso", "page", "edit"), "dbo.TIPOPERMISO", "APROBAR_PERMISOS.id_tipopermiso", "edit");
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "APROBAR_PERMISOS", "field", "id_estado_personal", "page", "edit"), "dbo.ESTADO_PERSONALES", "APROBAR_PERMISOS.id_estado_personal", "edit");
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "admin_members", "field", "id_tipo", "page", "edit"), "dbo.TIPOEMPLEADO", "admin_members.id_tipo", "edit");
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "admin_members", "field", "id_departamento", "page", "edit"), "dbo.DEPARTAMENTO", "admin_members.id_departamento", "edit");
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "admin_members", "field", "id_horarios", "page", "edit"), "dbo.HORARIOS", "admin_members.id_horarios", "edit");
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "admin_users", "field", "id_tipo", "page", "edit"), "dbo.TIPOEMPLEADO", "admin_users.id_tipo", "edit");
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "admin_users", "field", "id_departamento", "page", "edit"), "dbo.DEPARTAMENTO", "admin_users.id_departamento", "edit");
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "admin_users", "field", "id_horarios", "page", "edit"), "dbo.HORARIOS", "admin_users.id_horarios", "edit");
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "VISTOBUENO_JEFEINMEDIATO", "field", "id_tipopermiso", "page", "edit"), "dbo.TIPOPERMISO", "VISTOBUENO_JEFEINMEDIATO.id_tipopermiso", "edit");
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "VISTOBUENO_JEFEINMEDIATO", "field", "id_estado_personal", "page", "edit"), "dbo.ESTADO_PERSONALES", "VISTOBUENO_JEFEINMEDIATO.id_estado_personal", "edit");
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "VISTOBUENO_JEFEDEPARTAMENTO", "field", "id_tipopermiso", "page", "edit"), "dbo.TIPOPERMISO", "VISTOBUENO_JEFEDEPARTAMENTO.id_tipopermiso", "edit");
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "VISTOBUENO_JEFEDEPARTAMENTO", "field", "id_estado_personal", "page", "edit"), "dbo.ESTADO_PERSONALES", "VISTOBUENO_JEFEDEPARTAMENTO.id_estado_personal", "edit");
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "VER_PERMISOS", "field", "departamento", "page", "edit"), "dbo.DEPARTAMENTO", "VER_PERMISOS.departamento", "edit");
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "VER_PERMISOS", "field", "id_tipopermiso", "page", "edit"), "dbo.TIPOPERMISO", "VER_PERMISOS.id_tipopermiso", "edit");
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "VER_PERMISOS", "field", "id_estado_personal", "page", "edit"), "dbo.ESTADO_PERSONALES", "VER_PERMISOS.id_estado_personal", "edit");
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "VER_COMPESADOS", "field", "ONI", "page", "edit"), "dbo.EMPLEADO", "VER_COMPESADOS.ONI", "edit");
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "VER_COMPESADOS", "field", "departamento", "page", "edit"), "dbo.DEPARTAMENTO", "VER_COMPESADOS.departamento", "edit");
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "VER_COMPESADOS", "field", "id_estado_compesado", "page", "edit"), "dbo.ESTADO_COMPESADO", "VER_COMPESADOS.id_estado_compesado", "edit");
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "APROBACION_COMPESADOS_JEFEINMEDIATO", "field", "id_estado_compesado", "page", "edit"), "dbo.ESTADO_COMPESADO", "APROBACION_COMPESADOS_JEFEINMEDIATO.id_estado_compesado", "edit");
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "APROBACION_COMPESADOS_JEFEDEPARTAMENTO", "field", "id_estado_compesado", "page", "edit"), "dbo.ESTADO_COMPESADO", "APROBACION_COMPESADOS_JEFEDEPARTAMENTO.id_estado_compesado", "edit");
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "APROBAR_COMPESADOS", "field", "departamento", "page", "edit"), "dbo.DEPARTAMENTO", "APROBAR_COMPESADOS.departamento", "edit");
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "APROBAR_COMPESADOS", "field", "id_estado_compesado", "page", "edit"), "dbo.ESTADO_COMPESADO", "APROBAR_COMPESADOS.id_estado_compesado", "edit");
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "INGRESAR PERMISO", "field", "ONI", "page", "edit"), "dbo.EMPLEADO", "INGRESAR_PERMISO.ONI", "edit");
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "INGRESAR PERMISO", "field", "id_tipopermiso", "page", "edit"), "dbo.TIPOPERMISO", "INGRESAR_PERMISO.id_tipopermiso", "edit");
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "INGRESAR PERMISO", "field", "id_estado_personal", "page", "edit"), "dbo.ESTADO_PERSONALES", "INGRESAR_PERMISO.id_estado_personal", "edit");
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "INGRESAR_COMPESADO", "field", "ONI", "page", "edit"), "dbo.EMPLEADO", "INGRESAR_COMPESADO.ONI", "edit");
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "INGRESAR_COMPESADO", "field", "id_estado_compesado", "page", "edit"), "dbo.ESTADO_COMPESADO", "INGRESAR_COMPESADO.id_estado_compesado", "edit");
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.GRUPOS", "field", "id_departamento", "page", "edit"), "dbo.DEPARTAMENTO", "dbo_GRUPOS.id_departamento", "edit");
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "Licencias_sin_goce_sueldo", "field", "id_tipopermiso", "page", "edit"), "dbo.TIPOPERMISO", "Licencias_sin_goce_sueldo.id_tipopermiso", "edit");
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "Licencias_sin_goce_sueldo", "field", "id_estado_personal", "page", "edit"), "dbo.ESTADO_PERSONALES", "Licencias_sin_goce_sueldo.id_estado_personal", "edit");
			return null;
		}
	}
}
