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
	[Export(typeof(IEventProviderCS_INGRESAR_PERMISO))]
	public class eventclassCS_INGRESAR_PERMISO : IEventProviderCS_INGRESAR_PERMISO
	{


		//	handlers
// Is Record Editable
		public XVar IsRecordEditable(dynamic values, dynamic isEditable)
		{
if(values["id_tipopermiso"]!=7)
{
	if (values["id_estado_personal"]==2 || values["vistobueno2"]=="APROBADO" || values["vistobueno1"]=="APROBADO")
	{
		return false;
	}else if (values["id_estado_personal"]==3)
	{
		return false;
	}else if (values["id_estado_personal"]==4)
	{
		return false;
	}else 
	{
		return true;
	}
}
return null;

		} // IsRecordEditable

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
try 
{
//Obtener segundos personales
	dynamic personales;
	dynamic rsp = DB.Query("EXEC getCantidadHorasPersonales '"+XSession.Session["ONI"].ToString()+"'");
	personales= rsp.fetchAssoc();

//Obtener Horas compesadas disponibles
	dynamic compesados;
	dynamic rsc = DB.Query("EXEC getCantidadHorasCompesadas '"+XSession.Session["ONI"].ToString()+"'");
	compesados= rsc.fetchAssoc();

//Obtener horas en los permisos compesados
	dynamic permisos_compesados;
	dynamic rspc = DB.Query("EXEC getHorasPermisoCompesados '"+XSession.Session["ONI"].ToString()+"'");
	permisos_compesados= rspc.fetchAssoc();

//Obtener cantidad de permisos personales asignados
	string strSQLExists = "SELECT horas_permisos_personales from dbo.HORARIOS where id_horarios = "+XSession.Session["id_horarios"].ToString();
	XVar rsExists = CommonFunctions.db_query(strSQLExists, null);
	XVar data = CommonFunctions.db_fetch_array(rsExists);

//Tiempo en el permisos 
	string SQLPermiso = "SELECT SUM(DATEDIFF(second, '"+values["fecha_inicio"].ToString()+"', '"+values["fecha_final"].ToString()+"')) as tiempo";
	XVar rst = CommonFunctions.db_query(SQLPermiso, null);
	XVar permiso = CommonFunctions.db_fetch_array(rst);

// tiempo personal -> personales["total_segundos"]
// segundos personales disponibles -> compesados["total_comp_segundos"]
//  segundos en los permisos compesados -> permisos_compesados["total_segundos"]
// cantidad de permisos personales asignados-> data["horas_permisos_personales"]
// tiempo del permiso -> permiso["tiempo"]

//crear variables para los calculos permiso
int tiempo_permiso = permiso["tiempo"];
int tiempo_acumuladas = personales["total_segundos"];
int tiempo_asignadas = data["horas_permisos_personales"]*3600;

//Validar las fechas del permiso
string fechaini = "";
string fechafin = "";
fechaini = values["fecha_inicio"];
fechafin = values["fecha_final"];

//Validar si las fechas  final no menor a la de inicio
 if(fechaini != "" && fechafin != "" && fechaini != null && fechafin != null)
	{
		 if(tiempo_permiso< 0)
			{
				message="La Fecha final debe ser mayor a la fecha inicial";
				MVCFunctions.EchoToOutput("La Fecha final debe ser mayor a la fecha inicial");
				return false;
			}
	}
	else
	{
		message = "Por favor revise fechas del Permiso";
		MVCFunctions.EchoToOutput("Por favor revise fechas del Permiso");
		return false;
	}



//validar el permiso
if(values["id_tipopermiso"]==1)// Si el permiso es personal
{
	if ((tiempo_permiso+tiempo_acumuladas)>tiempo_asignadas)// Si el tiempo del permiso mas el tiempo acumalado es mayo que el asignado
	{
		message="El tiempo solicitado en el permiso excede la cantidad de horas personales asignadas |tiempo_permiso="+tiempo_permiso.ToString()+"|tiempo_acumuladas="+tiempo_acumuladas.ToString()+"|tiempo_asignadas="+tiempo_asignadas.ToString()+"|SQLPermiso="+SQLPermiso.ToString();
		return false;
	}
}else if (values["id_tipopermiso"]==2)// Si el permiso es por tiempo compesado
{
	if (tiempo_permiso > compesados["total_comp_segundos"])//Si el tiempo de permiso es mayo a las horas acumuladas
	{
		message="El tiempo solicitado en el permiso excede la cantidad de horas compesadas disponibles |tiempo_permiso="+tiempo_permiso.ToString()+"|compesados="+compesados["total_comp_segundos"].ToString()+"|SQLPermiso="+SQLPermiso.ToString();
		return false;
	}
}

return true;

}catch (Exception e)
{
	MVCFunctions.EchoToOutput("<div class=\"alert alert-danger\" ><strong>Error!</strong> en el evento BeforeAdd del fomulario de permisos al validar el permiso: "+e.Message+"</div>");
}
return null;

		} // BeforeAdd

// List page: Before SQL query
		public XVar BeforeQueryList(dynamic strSQL, ref dynamic strWhereClause, ref dynamic strOrderBy, dynamic pageObject)
		{
//strWhereClause = "ONI = '"+XSession.Session["ONI"].ToString()+"'";

// Place event code here.
// Use "Add Action" button to add code snippets.
return null;

		} // BeforeQueryList

// Before record updated
		public XVar BeforeEdit(dynamic values, dynamic where, dynamic oldvalues, dynamic keys, ref dynamic message, dynamic inline, dynamic pageObject)
		{
try 
{
//Obtener segundos personales
	dynamic personales;
	dynamic rsp = DB.Query("EXEC getCantidadHorasPersonales '"+XSession.Session["ONI"].ToString()+"'");
	personales= rsp.fetchAssoc();

//Obtener Horas compesadas disponibles
	dynamic compesados;
	dynamic rsc = DB.Query("EXEC getCantidadHorasCompesadas '"+XSession.Session["ONI"].ToString()+"'");
	compesados= rsc.fetchAssoc();

//Obtener horas en los permisos compesados
	dynamic permisos_compesados;
	dynamic rspc = DB.Query("EXEC getHorasPermisoCompesados '"+XSession.Session["ONI"].ToString()+"'");
	permisos_compesados= rspc.fetchAssoc();

//Obtener cantidad de permisos personales asignados
	string strSQLExists = "SELECT horas_permisos_personales from dbo.HORARIOS where id_horarios = "+XSession.Session["id_horarios"].ToString();
	XVar rsExists = CommonFunctions.db_query(strSQLExists, null);
	XVar data = CommonFunctions.db_fetch_array(rsExists);

//Tiempo en el permisos 
	string SQLPermiso = "SELECT SUM(DATEDIFF(second, '"+values["fecha_inicio"].ToString()+"', '"+values["fecha_final"].ToString()+"')) as tiempo";
	XVar rst = CommonFunctions.db_query(SQLPermiso, null);
	XVar permiso = CommonFunctions.db_fetch_array(rst);

// tiempo personal -> personales["total_segundos"]
// segundos personales disponibles -> compesados["total_comp_segundos"]
//  segundos en los permisos compesados -> permisos_compesados["total_segundos"]
// cantidad de permisos personales asignados-> data["horas_permisos_personales"]
// tiempo del permiso -> permiso["tiempo"]

//crear variables para los calculos permiso
int tiempo_permiso = permiso["tiempo"];
int tiempo_acumuladas = personales["total_segundos"];
int tiempo_asignadas = data["horas_permisos_personales"]*3600;

//Validar las fechas del permiso
string fechaini = "";
string fechafin = "";
fechaini = values["fecha_inicio"];
fechafin = values["fecha_final"];

//Validar si las fechas  final no menor a la de inicio
 if(fechaini != "" && fechafin != "" && fechaini != null && fechafin != null)
	{
		 if(tiempo_permiso< 0)
			{
				message="La Fecha final debe ser mayor a la fecha inicial";
				MVCFunctions.EchoToOutput("La Fecha final debe ser mayor a la fecha inicial");
				return false;
			}
	}
	else
	{
		message = "Por favor revise fechas del Permiso";
		MVCFunctions.EchoToOutput("Por favor revise fechas del Permiso");
		return false;
	}

//validar el permiso
if(values["id_tipopermiso"]==1)// Si el permiso es personal
{
	if ((tiempo_permiso+tiempo_acumuladas)>tiempo_asignadas)// Si el tiempo del permiso mas el tiempo acumalado es mayo que el asignado
	{
		message="El tiempo solicitado en el permiso excede la cantidad de horas personales asignadas |tiempo_permiso="+tiempo_permiso.ToString()+"|tiempo_acumuladas="+tiempo_acumuladas.ToString()+"|tiempo_asignadas="+tiempo_asignadas.ToString()+"|SQLPermiso="+SQLPermiso.ToString();
		return false;
	}
}else if (values["id_tipopermiso"]==2)// Si el permiso es por tiempo compesado
{
	if (tiempo_permiso > compesados["total_comp_segundos"])//Si el tiempo de permiso es mayo a las horas acumuladas
	{
		message="El tiempo solicitado en el permiso excede la cantidad de horas compesadas disponibles |tiempo_permiso="+tiempo_permiso.ToString()+"|compesados="+compesados["total_comp_segundos"].ToString()+"|SQLPermiso="+SQLPermiso.ToString();
		return false;
	}
}

return true;

}catch (Exception e)
{
	MVCFunctions.EchoToOutput("<div class=\"alert alert-danger\" ><strong>Error!</strong> en el evento BeforeAdd del fomulario de permisos al validar el permiso: "+e.Message+"</div>");
}
return null;

		} // BeforeEdit


	}

}