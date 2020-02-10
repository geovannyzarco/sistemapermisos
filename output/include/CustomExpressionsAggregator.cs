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
	public interface ICustomExpressionProvider
	{
		XVar GetCustomExpression(XVar value, XVar data, XVar field, XVar ptype, XVar table = null);
		XVar GetFileCustomExpression(XVar file, XVar data, XVar field, XVar ptype, XVar table = null);
		XVar GetLWWhere(XVar field, XVar ptype, XVar table = null);
		XVar GetDefaultValue(XVar field, XVar ptype, XVar table = null);
		XVar GetAutoUpdateValue(XVar field, XVar ptype, XVar table = null);
		XVar GetUploadFolderExpression(XVar field, XVar file, XVar table = null);
		XVar GetIntervalLimitsExprs(XVar table, XVar field, XVar idx, XVar isLowerBound);
		XVar getCustomMapIcon(XVar field, XVar table, XVar data);
		XVar getDashMapCustomIcon(XVar dashName, XVar dashElementName, XVar data);
	}

	public interface ICustomExpressionProviderVB : ICustomExpressionProvider {}

	public interface ICustomExpressionProviderCS : ICustomExpressionProvider {}

	public class CustomExpressionProvider
	{
		private static CustomExpressionProvider _instance;

		public static CustomExpressionProvider Instance
		{
			get
			{
				if(_instance == null)
					_instance = new CustomExpressionProvider();

				return _instance;
			}
		}

		[Import(typeof(ICustomExpressionProviderCS))]
		public ICustomExpressionProviderCS CustomExpressionProviderCS;

		[Import(typeof(ICustomExpressionProviderVB))]
		public ICustomExpressionProviderVB CustomExpressionProviderVB;

		public void DoImport()
        {
            var catalog = new AggregateCatalog();
            catalog.Catalogs.Add(new DirectoryCatalog(MVCFunctions.getabspath("\\bin\\Events")));
            CompositionContainer container = new CompositionContainer(catalog);
            container.ComposeParts(this);
        }

		private CustomExpressionProvider()
		{
			DoImport();
		}

		public XVar GetCustomExpression(XVar value, XVar data, XVar field, XVar ptype, XVar table = null)
		{
			if(!table)
			{
				table = GlobalVars.strTableName;
			}

			return value;
		}

		public XVar GetFileCustomExpression(XVar file, XVar data, XVar field, XVar ptype, XVar table = null)
		{
			if(!table)
			{
				table = GlobalVars.strTableName;
			}

			if(table == "dbo.Permisos2"  &&  field == "adjunto")
			{
				return CustomExpressionProviderCS.GetFileCustomExpression(file, data, field, ptype, table);
			}
			if(table == "dbo.REGISTRO_HORAS_COMPESADAS"  &&  field == "anexo")
			{
				return CustomExpressionProviderCS.GetFileCustomExpression(file, data, field, ptype, table);
			}
			if(table == "APROBAR_PERMISOS"  &&  field == "adjunto")
			{
				return CustomExpressionProviderCS.GetFileCustomExpression(file, data, field, ptype, table);
			}
			if(table == "VISTOBUENO_JEFEINMEDIATO"  &&  field == "adjunto")
			{
				return CustomExpressionProviderCS.GetFileCustomExpression(file, data, field, ptype, table);
			}
			if(table == "VISTOBUENO_JEFEDEPARTAMENTO"  &&  field == "adjunto")
			{
				return CustomExpressionProviderCS.GetFileCustomExpression(file, data, field, ptype, table);
			}
			if(table == "VER_PERMISOS"  &&  field == "adjunto")
			{
				return CustomExpressionProviderCS.GetFileCustomExpression(file, data, field, ptype, table);
			}
			if(table == "VER_COMPESADOS"  &&  field == "anexo")
			{
				return CustomExpressionProviderCS.GetFileCustomExpression(file, data, field, ptype, table);
			}
			if(table == "APROBACION_COMPESADOS_JEFEINMEDIATO"  &&  field == "anexo")
			{
				return CustomExpressionProviderCS.GetFileCustomExpression(file, data, field, ptype, table);
			}
			if(table == "APROBACION_COMPESADOS_JEFEDEPARTAMENTO"  &&  field == "anexo")
			{
				return CustomExpressionProviderCS.GetFileCustomExpression(file, data, field, ptype, table);
			}
			if(table == "APROBAR_COMPESADOS"  &&  field == "anexo")
			{
				return CustomExpressionProviderCS.GetFileCustomExpression(file, data, field, ptype, table);
			}
			if(table == "INGRESAR PERMISO"  &&  field == "adjunto")
			{
				return CustomExpressionProviderCS.GetFileCustomExpression(file, data, field, ptype, table);
			}
			if(table == "INGRESAR_COMPESADO"  &&  field == "anexo")
			{
				return CustomExpressionProviderCS.GetFileCustomExpression(file, data, field, ptype, table);
			}
			if(table == "Licencias_sin_goce_sueldo"  &&  field == "adjunto")
			{
				return CustomExpressionProviderCS.GetFileCustomExpression(file, data, field, ptype, table);
			}
			return "";
		}

		public XVar GetLWWhere(XVar field, XVar ptype, XVar table = null)
		{
			if(!table)
			{
				table = GlobalVars.strTableName;
			}

			return "";
		}

		public XVar GetDefaultValue(XVar field, XVar ptype, XVar table = null)
		{
			if(!table)
			{
				table = GlobalVars.strTableName;
			}

			if(table == "dbo.Permisos2"  &&  field == "ONI")
			{
				return CustomExpressionProviderCS.GetDefaultValue(field, ptype, table);
			}
			if(table == "dbo.Permisos2"  &&  field == "fecha_solicitud")
			{
				return CustomExpressionProviderCS.GetDefaultValue(field, ptype, table);
			}
			if(table == "dbo.REGISTRO_HORAS_COMPESADAS"  &&  field == "ONI")
			{
				return CustomExpressionProviderCS.GetDefaultValue(field, ptype, table);
			}
			if(table == "dbo.REGISTRO_HORAS_COMPESADAS"  &&  field == "fecha_creacion")
			{
				return CustomExpressionProviderCS.GetDefaultValue(field, ptype, table);
			}
			if(table == "dbo.TIPOPERMISO"  &&  field == "horas_asignada")
			{
				return CustomExpressionProviderCS.GetDefaultValue(field, ptype, table);
			}
			if(table == "dbo.TIPOPERMISO"  &&  field == "dias_asignados")
			{
				return CustomExpressionProviderCS.GetDefaultValue(field, ptype, table);
			}
			if(table == "dbo.TIPOPERMISO"  &&  field == "cantidad_permisos")
			{
				return CustomExpressionProviderCS.GetDefaultValue(field, ptype, table);
			}
			if(table == "VISTOBUENO_JEFEINMEDIATO"  &&  field == "ONI")
			{
				return CustomExpressionProviderCS.GetDefaultValue(field, ptype, table);
			}
			if(table == "VISTOBUENO_JEFEINMEDIATO"  &&  field == "fecha_solicitud")
			{
				return CustomExpressionProviderCS.GetDefaultValue(field, ptype, table);
			}
			if(table == "VISTOBUENO_JEFEDEPARTAMENTO"  &&  field == "ONI")
			{
				return CustomExpressionProviderCS.GetDefaultValue(field, ptype, table);
			}
			if(table == "VISTOBUENO_JEFEDEPARTAMENTO"  &&  field == "fecha_solicitud")
			{
				return CustomExpressionProviderCS.GetDefaultValue(field, ptype, table);
			}
			if(table == "VER_PERMISOS"  &&  field == "ONI")
			{
				return CustomExpressionProviderCS.GetDefaultValue(field, ptype, table);
			}
			if(table == "VER_PERMISOS"  &&  field == "fecha_solicitud")
			{
				return CustomExpressionProviderCS.GetDefaultValue(field, ptype, table);
			}
			if(table == "Saldo_Horas_Empleado"  &&  field == "Horas_personales_tomadas")
			{
				return CustomExpressionProviderCS.GetDefaultValue(field, ptype, table);
			}
			if(table == "Saldo_Horas_Empleado"  &&  field == "Horas_personales_asignadas")
			{
				return CustomExpressionProviderCS.GetDefaultValue(field, ptype, table);
			}
			if(table == "Saldo_Horas_Empleado"  &&  field == "Horas_compesadas_disponible")
			{
				return CustomExpressionProviderCS.GetDefaultValue(field, ptype, table);
			}
			if(table == "APROBAR_COMPESADOS"  &&  field == "ONI")
			{
				return CustomExpressionProviderCS.GetDefaultValue(field, ptype, table);
			}
			if(table == "INGRESAR PERMISO"  &&  field == "fecha_solicitud")
			{
				return CustomExpressionProviderCS.GetDefaultValue(field, ptype, table);
			}
			if(table == "INGRESAR_COMPESADO"  &&  field == "fecha_creacion")
			{
				return CustomExpressionProviderCS.GetDefaultValue(field, ptype, table);
			}
			if(table == "Licencias_sin_goce_sueldo"  &&  field == "ONI")
			{
				return CustomExpressionProviderCS.GetDefaultValue(field, ptype, table);
			}
			if(table == "Licencias_sin_goce_sueldo"  &&  field == "fecha_solicitud")
			{
				return CustomExpressionProviderCS.GetDefaultValue(field, ptype, table);
			}
			return "";
		}

		public XVar GetAutoUpdateValue(XVar field, XVar ptype, XVar table = null)
		{
			if(!table)
			{
				table = GlobalVars.strTableName;
			}

			return "";
		}

		public XVar getCustomMapIcon(XVar field, XVar ptype, XVar table, XVar data)
		{
			if(!table)
			{
				table = GlobalVars.strTableName;
			}

			return "";
		}

		public XVar getDashMapCustomIcon(XVar dashName, XVar dashElementName, XVar data)
		{

			return "";
		}



		public XVar GetUploadFolderExpression(XVar field, XVar file, XVar table = null)
		{
			if(!table)
			{
				table = GlobalVars.strTableName;
			}

			return "";
		}

		public XVar GetIntervalLimitsExprs(XVar table, XVar field, XVar idx, XVar isLowerBound)
		{
			return "";
		}
	}
}