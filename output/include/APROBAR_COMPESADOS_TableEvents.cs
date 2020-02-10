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
	[Export(typeof(IEventProviderCS_APROBAR_COMPESADOS))]
	public class eventclassCS_APROBAR_COMPESADOS : IEventProviderCS_APROBAR_COMPESADOS
	{


		//	handlers
// After record added
		public XVar AfterAdd(dynamic values, dynamic keys, dynamic inline, dynamic pageObject)
		{

return null;

		} // AfterAdd

// List page: Before SQL query
		public XVar BeforeQueryList(dynamic strSQL, ref dynamic strWhereClause, ref dynamic strOrderBy, dynamic pageObject)
		{

try 
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
	}

if(XSession.Session["GrupoID"]==4) // Si el  usuario tienen el rol de Jefe departamento entoses
	{
		strWhereClause = "dbo.EMPLEADO.id_departamento = "+XSession.Session["id_departamento"].ToString();
	}
}
catch (Exception e)
{
	  MVCFunctions.EchoToOutput("<div class=\"alert alert-danger\" role=\"alert\"><strong>Error!</strong> en el evento BeforeQueryList al filtrar la tabla por ONI: "+e.Message+"</div>");

}
return null;

		} // BeforeQueryList


	}

}