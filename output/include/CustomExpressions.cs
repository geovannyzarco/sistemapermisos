using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Dynamic;
using System.ComponentModel.Composition;
using runnerDotNet;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using System.Reflection;

namespace runnerDotNet
{
	[Export(typeof(ICustomExpressionProviderCS))]
	public class CustomExpressionProvider : ICustomExpressionProviderCS
	{
		public XVar GetCustomExpression(XVar value, XVar data, XVar field, XVar ptype, XVar table = null)
		{
			return value;
		}

		public XVar GetFileCustomExpression(XVar file, XVar data, XVar field, XVar ptype, XVar table = null)
		{
			XVar value = "";
			if(table == "dbo.Permisos2"  &&  field == "adjunto")
			{

;return value;
			}
			if(table == "dbo.REGISTRO_HORAS_COMPESADAS"  &&  field == "anexo")
			{

;return value;
			}
			if(table == "APROBAR_PERMISOS"  &&  field == "adjunto")
			{

;return value;
			}
			if(table == "VISTOBUENO_JEFEINMEDIATO"  &&  field == "adjunto")
			{

;return value;
			}
			if(table == "VISTOBUENO_JEFEDEPARTAMENTO"  &&  field == "adjunto")
			{

;return value;
			}
			if(table == "VER_PERMISOS"  &&  field == "adjunto")
			{

;return value;
			}
			if(table == "VER_COMPESADOS"  &&  field == "anexo")
			{

;return value;
			}
			if(table == "APROBACION_COMPESADOS_JEFEINMEDIATO"  &&  field == "anexo")
			{

;return value;
			}
			if(table == "APROBACION_COMPESADOS_JEFEDEPARTAMENTO"  &&  field == "anexo")
			{

;return value;
			}
			if(table == "APROBAR_COMPESADOS"  &&  field == "anexo")
			{

;return value;
			}
			if(table == "INGRESAR PERMISO"  &&  field == "adjunto")
			{

;return value;
			}
			if(table == "INGRESAR_COMPESADO"  &&  field == "anexo")
			{

;return value;
			}
			if(table == "Licencias_sin_goce_sueldo"  &&  field == "adjunto")
			{

;return value;
			}
			return value;
		}

		public XVar GetLWWhere(XVar field, XVar ptype, XVar table = null)
		{
			return "";
		}

		public XVar GetDefaultValue(XVar field, XVar ptype, XVar table = null)
		{
			if(table == "dbo.Permisos2"  &&  field == "ONI")
			{
				var tmpVal = XSession.Session["ONI"];
				return XVar.Pack(tmpVal);
			}
			if(table == "dbo.Permisos2"  &&  field == "fecha_solicitud")
			{
				var tmpVal = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
				return XVar.Pack(tmpVal);
			}
			if(table == "dbo.REGISTRO_HORAS_COMPESADAS"  &&  field == "ONI")
			{
				var tmpVal = XSession.Session["ONI"];
				return XVar.Pack(tmpVal);
			}
			if(table == "dbo.REGISTRO_HORAS_COMPESADAS"  &&  field == "fecha_creacion")
			{
				var tmpVal = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
				return XVar.Pack(tmpVal);
			}
			if(table == "dbo.TIPOPERMISO"  &&  field == "horas_asignada")
			{
				var tmpVal = 0;
				return XVar.Pack(tmpVal);
			}
			if(table == "dbo.TIPOPERMISO"  &&  field == "dias_asignados")
			{
				var tmpVal = 0;
				return XVar.Pack(tmpVal);
			}
			if(table == "dbo.TIPOPERMISO"  &&  field == "cantidad_permisos")
			{
				var tmpVal = 0;
				return XVar.Pack(tmpVal);
			}
			if(table == "VISTOBUENO_JEFEINMEDIATO"  &&  field == "ONI")
			{
				var tmpVal = XSession.Session["ONI"];
				return XVar.Pack(tmpVal);
			}
			if(table == "VISTOBUENO_JEFEINMEDIATO"  &&  field == "fecha_solicitud")
			{
				var tmpVal = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
				return XVar.Pack(tmpVal);
			}
			if(table == "VISTOBUENO_JEFEDEPARTAMENTO"  &&  field == "ONI")
			{
				var tmpVal = XSession.Session["ONI"];
				return XVar.Pack(tmpVal);
			}
			if(table == "VISTOBUENO_JEFEDEPARTAMENTO"  &&  field == "fecha_solicitud")
			{
				var tmpVal = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
				return XVar.Pack(tmpVal);
			}
			if(table == "VER_PERMISOS"  &&  field == "ONI")
			{
				var tmpVal = XSession.Session["ONI"];
				return XVar.Pack(tmpVal);
			}
			if(table == "VER_PERMISOS"  &&  field == "fecha_solicitud")
			{
				var tmpVal = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
				return XVar.Pack(tmpVal);
			}
			if(table == "Saldo_Horas_Empleado"  &&  field == "Horas_personales_tomadas")
			{
				var tmpVal = 0;
				return XVar.Pack(tmpVal);
			}
			if(table == "Saldo_Horas_Empleado"  &&  field == "Horas_personales_asignadas")
			{
				var tmpVal = 0;
				return XVar.Pack(tmpVal);
			}
			if(table == "Saldo_Horas_Empleado"  &&  field == "Horas_compesadas_disponible")
			{
				var tmpVal = 0;
				return XVar.Pack(tmpVal);
			}
			if(table == "APROBAR_COMPESADOS"  &&  field == "ONI")
			{
				var tmpVal = XSession.Session["ONI"];
				return XVar.Pack(tmpVal);
			}
			if(table == "INGRESAR PERMISO"  &&  field == "fecha_solicitud")
			{
				var tmpVal = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
				return XVar.Pack(tmpVal);
			}
			if(table == "INGRESAR_COMPESADO"  &&  field == "fecha_creacion")
			{
				var tmpVal = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
				return XVar.Pack(tmpVal);
			}
			if(table == "Licencias_sin_goce_sueldo"  &&  field == "ONI")
			{
				var tmpVal = XSession.Session["ONI"];
				return XVar.Pack(tmpVal);
			}
			if(table == "Licencias_sin_goce_sueldo"  &&  field == "fecha_solicitud")
			{
				var tmpVal = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
				return XVar.Pack(tmpVal);
			}
			return "";
		}

		public XVar GetAutoUpdateValue(XVar field, XVar ptype, XVar table = null)
		{
			return "";
		}

		public XVar getCustomMapIcon(XVar field, XVar table, XVar data)
		{
			XVar icon = "";
			return "";
		}

		public XVar getDashMapCustomIcon(XVar dashName, XVar dashElementName, XVar data)
		{
			XVar icon = "";
			return "";
		}

		public XVar GetUploadFolderExpression(XVar field, XVar file, XVar table = null)
		{
			return "";
		}

		public XVar GetIntervalLimitsExprs(XVar table, XVar field, XVar idx, XVar isLowerBound)
		{
			return "";
		}
	}
}