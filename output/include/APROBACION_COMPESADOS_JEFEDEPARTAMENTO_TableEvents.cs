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
	[Export(typeof(IEventProviderCS_APROBACION_COMPESADOS_JEFEDEPARTAMENTO))]
	public class eventclassCS_APROBACION_COMPESADOS_JEFEDEPARTAMENTO : IEventProviderCS_APROBACION_COMPESADOS_JEFEDEPARTAMENTO
	{


		//	handlers
// List page: Before SQL query
		public XVar BeforeQueryList(dynamic strSQL, ref dynamic strWhereClause, ref dynamic strOrderBy, dynamic pageObject)
		{
if(XSession.Session["GrupoID"]==3)// Si el  usuario tienen el rol de supervisor entoses
{
	// revisamos si el supervisor tiene un grupo asignado
	if (string.IsNullOrEmpty(XSession.Session["id_grupo_depar"]))//Si la variable de session no tiene valor 
	{
		strWhereClause = "dbo.EMPLEADO.id_departamento = "+XSession.Session["id_departamento"].ToString()+" and dbo.acceso_ugmembers.GroupID=1";
	}else
	{
		strWhereClause = "dbo.EMPLEADO.id_departamento = "+XSession.Session["id_departamento"].ToString()+" and dbo.EMPLEADO.id_grupo = " +XSession.Session["id_grupo_depar"].ToString()+"and dbo.acceso_ugmembers.GroupID=1";
	}
}else if (XSession.Session["GrupoID"]==4) // Si el  usuario tienen el rol de Jefe departamento entoses
{
	strWhereClause = "dbo.EMPLEADO.id_departamento = "+XSession.Session["id_departamento"].ToString();
}

return null;

		} // BeforeQueryList


	}

}