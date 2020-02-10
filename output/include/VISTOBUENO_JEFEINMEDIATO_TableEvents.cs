using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Dynamic;
using System.ComponentModel.Composition;
using System.Web;
using runnerDotNet;

namespace runnerDotNet
{
	[Export(typeof(IEventProviderCS_VISTOBUENO_JEFEINMEDIATO))]
	public class eventclassCS_VISTOBUENO_JEFEINMEDIATO : IEventProviderCS_VISTOBUENO_JEFEINMEDIATO
	{


		//	handlers
// Add page: Before process
		public XVar BeforeProcessAdd(dynamic pageObject)
		{





// Place event code here.
// Use "Add Action" button to add code snippets.
return null;

		} // BeforeProcessAdd

// Before record added
		public XVar BeforeAdd(dynamic values, ref dynamic message, dynamic inline, dynamic pageObject)
		{

string strSQLUpdate = "update dbo.Permisos2 set id_estado_personal = 1 where id_permisos ="+values["id_permisos"].ToString();
CommonFunctions.db_exec(strSQLUpdate, null);

return true;
return null;

		} // BeforeAdd

// List page: Before SQL query
		public XVar BeforeQueryList(dynamic strSQL, ref dynamic strWhereClause, ref dynamic strOrderBy, dynamic pageObject)
		{
//strWhereClause = "dbo.EMPLEADO.id_departamento = "+XSession.Session["id_departamento"].ToString();
// Place event code here.
// Use "Add Action" button to add code snippets.


	if (string.IsNullOrEmpty(XSession.Session["id_grupo_depar"]))//Si la variable de session no tiene valor 
	{
		strWhereClause = "dbo.EMPLEADO.id_departamento = "+XSession.Session["id_departamento"].ToString()+" and dbo.acceso_ugmembers.GroupID=1";
	}else
	{
		strWhereClause = "dbo.EMPLEADO.id_departamento = "+XSession.Session["id_departamento"].ToString()+" and dbo.EMPLEADO.id_grupo = " +XSession.Session["id_grupo_depar"].ToString()+"and dbo.acceso_ugmembers.GroupID=1";
	}

return null;

		} // BeforeQueryList


	}

}