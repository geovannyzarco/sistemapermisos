using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Data.Common;
using runnerDotNet;

namespace runnerDotNet
{
	public class ConnectionManager : XClass
	{
		private Dictionary<string, Connection> cache = new Dictionary<string, Connection>();
		
		private XVar _connectionsData = XVar.Array();
		private XVar _connectionsIdByName = XVar.Array();
		
		protected Dictionary<string, string> _tablesConnectionIds = new Dictionary<string, string>();
		
		public ConnectionManager()
		{
			_setConnectionsData();
			_setTablesConnectionIds();
		}
		
		public Connection byTable(XVar tName)
		{
			var connId = _tablesConnectionIds.ContainsKey(tName) ? _tablesConnectionIds[tName] : "";
			return byId(connId);
		}
		
		public Connection byId(XVar connId)
		{
			if(!cache.ContainsKey(connId))
				cache[connId] = getConnection(connId);

			return cache[connId];
		}

		public Connection byName(XVar connName)
		{
			XVar connId = _connectionsIdByName[ connName ];
			
			if( !cache.ContainsKey( connId ) )
				cache[ connId ] = getConnection( connId );

			return cache[ connId ];
		}
		
		public Connection getDefault()
		{
			return byId("PermisosDB_at_192_168_1_123");
		}
		
		public Connection getForLogin()
		{
			return byId( "PermisosDB_at_192_168_1_123" );
		}
	
		public Connection getForAudit()
		{
			return getDefault();
		}
	
		public Connection getForLocking()
		{
			return getDefault();
		}
	
		public Connection getForUserGroups()
		{
			return byId( "PermisosDB_at_192_168_1_123" );
		}

		public Connection getForSavedSearches()
		{
			return getDefault();
		}

		public Connection getForWebReports()
		{
			return getDefault();
		}
		
		private Connection getConnection(XVar connId)
		{
			if(connId == "")
				return getDefault();
			
			XVar data = _connectionsData[connId];	
			
			switch(data["connStringType"].ToString())
			{
				case "mssql":
						return new MSSQLConnection(data);
				case "msaccess":
				case "odbc":
				case "odbcdsn":
				case "custom":
				case "file":
				{
					String firstClause = GlobalVars.ConnectionStrings[connId].ToString().Substring(0,9).ToUpper();
					if(  firstClause == "PROVIDER=" )
						return new OLEDBConnection(data);
					else
						return new ODBCConnection(data);
				}
				default:
					return null;
			}
		}
		
		/**
		 * Set the data representing the project's 
		 * db connection properties
		 */	 
		protected void _setConnectionsData()
		{
			// content of this function can be modified on demo account
			// variable names data and connectionsData are important
			
			var connectionsData = XVar.Array();
			XVar data;
			data = XVar.Array();
			data["dbType"] = "2";
			data["connStringType"] = "mssql";
			data["connId"] = "PermisosDB_at_192_168_1_123";
			data["connName"] = "PermisosDB at DESKTOP-63PFRJH";
			data["leftWrap"] = "[";
			data["rightWrap"] = "]";
			
			_connectionsIdByName["PermisosDB at DESKTOP-63PFRJH"] = "PermisosDB_at_192_168_1_123";
			
			data["EncryptInfo"] = XVar.Array();
				data["EncryptInfo"]["mode"] = 0;
			data["EncryptInfo"]["alg"]  = 128;
			data["EncryptInfo"]["key"]  = "";
					data["EncryptInfo"]["slqserverkey"] = "";
			data["EncryptInfo"]["slqservercert"] = "";

			connectionsData["PermisosDB_at_192_168_1_123"] = data;
			_connectionsData = connectionsData;
		}
		
		/**
		 * Set the data representing the correspondence between 
		 * the project's table names and db connections
		 */	 
		protected void _setTablesConnectionIds()
		{
			_tablesConnectionIds = new Dictionary<string, string>();
			_tablesConnectionIds["dbo.DEPARTAMENTO"] = "PermisosDB_at_192_168_1_123";
			_tablesConnectionIds["dbo.EMPLEADO"] = "PermisosDB_at_192_168_1_123";
			_tablesConnectionIds["dbo.ESTADO_COMPESADO"] = "PermisosDB_at_192_168_1_123";
			_tablesConnectionIds["dbo.ESTADO_PERSONALES"] = "PermisosDB_at_192_168_1_123";
			_tablesConnectionIds["dbo.HORARIOS"] = "PermisosDB_at_192_168_1_123";
			_tablesConnectionIds["dbo.Permisos2"] = "PermisosDB_at_192_168_1_123";
			_tablesConnectionIds["dbo.PERMISOSGRUPOS"] = "PermisosDB_at_192_168_1_123";
			_tablesConnectionIds["dbo.Preferencias"] = "PermisosDB_at_192_168_1_123";
			_tablesConnectionIds["dbo.REGISTRO_HORAS_COMPESADAS"] = "PermisosDB_at_192_168_1_123";
			_tablesConnectionIds["dbo.TIPOEMPLEADO"] = "PermisosDB_at_192_168_1_123";
			_tablesConnectionIds["dbo.TIPOPERMISO"] = "PermisosDB_at_192_168_1_123";
			_tablesConnectionIds["APROBAR_PERMISOS"] = "PermisosDB_at_192_168_1_123";
			_tablesConnectionIds["admin_rights"] = "PermisosDB_at_192_168_1_123";
			_tablesConnectionIds["admin_members"] = "PermisosDB_at_192_168_1_123";
			_tablesConnectionIds["admin_users"] = "PermisosDB_at_192_168_1_123";
			_tablesConnectionIds["VISTOBUENO_JEFEINMEDIATO"] = "PermisosDB_at_192_168_1_123";
			_tablesConnectionIds["VISTOBUENO_JEFEDEPARTAMENTO"] = "PermisosDB_at_192_168_1_123";
			_tablesConnectionIds["VER_PERMISOS"] = "PermisosDB_at_192_168_1_123";
			_tablesConnectionIds["Saldo_Horas_Empleado"] = "PermisosDB_at_192_168_1_123";
			_tablesConnectionIds["VER_COMPESADOS"] = "PermisosDB_at_192_168_1_123";
			_tablesConnectionIds["APROBACION_COMPESADOS_JEFEINMEDIATO"] = "PermisosDB_at_192_168_1_123";
			_tablesConnectionIds["APROBACION_COMPESADOS_JEFEDEPARTAMENTO"] = "PermisosDB_at_192_168_1_123";
			_tablesConnectionIds["APROBAR_COMPESADOS"] = "PermisosDB_at_192_168_1_123";
			_tablesConnectionIds["INGRESAR PERMISO"] = "PermisosDB_at_192_168_1_123";
			_tablesConnectionIds["INGRESAR_COMPESADO"] = "PermisosDB_at_192_168_1_123";
			_tablesConnectionIds["dbo.GRUPOS"] = "PermisosDB_at_192_168_1_123";
			_tablesConnectionIds["dbo.acceso_ugmembers"] = "PermisosDB_at_192_168_1_123";
			_tablesConnectionIds["Licencias_sin_goce_sueldo"] = "PermisosDB_at_192_168_1_123";
		}
		
		public XVar checkTablesSubqueriesSupport(XVar dataSourceTName1, XVar dataSourceTName2)
		{
			var connId1 = _tablesConnectionIds[dataSourceTName1];
			var connId2 = _tablesConnectionIds[dataSourceTName2];

			if(connId1 != connId2)
				return false;

			if(_connectionsData[connId1]["dbType"] == Constants.nDATABASE_Access && dataSourceTName1 == dataSourceTName2)
				return false;

			return true;
		}
		
		public XVar CloseConnections() 
		{
			foreach(var con in cache.Values)
			{
				con.close();
			}
			return null;
		}
	}
}