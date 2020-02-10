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
	[Export(typeof(IEventProviderCS_VISTOBUENO_JEFEDEPARTAMENTO))]
	public class eventclassCS_VISTOBUENO_JEFEDEPARTAMENTO : IEventProviderCS_VISTOBUENO_JEFEDEPARTAMENTO
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
strWhereClause = "dbo.EMPLEADO.id_departamento = "+XSession.Session["id_departamento"].ToString();
// Place event code here.
// Use "Add Action" button to add code snippets.
return null;

		} // BeforeQueryList


	}

}