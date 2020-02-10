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
	[Export(typeof(IEventProviderCS_dbo_Permisos2))]
	public class eventclassCS_dbo_Permisos2 : IEventProviderCS_dbo_Permisos2
	{


		//	handlers
// Is Record Editable
		public XVar IsRecordEditable(dynamic values, dynamic isEditable)
		{


if(values["id_tipopermiso"]!=7)
{
	if (values["id_estado_personal"]==2 && values["vistobueno1"]=="APROBADO" && values["vistobueno2"]=="APROBADO")
	{
		return false;
	}else if (values["id_estado_personal"]==2 && values["vistobueno1"]!="APROBADO" && values["vistobueno2"]!="APROBADO" )
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

	//Validar si una de la fechas solicitadas en el permiso ya se ha pasado de lo permitido por grupo o departamento.
	DateTime inicio = DateTime.Parse(fechaini);
	DateTime fin = DateTime.Parse(fechafin);
	DateTime temp = inicio;

	if (string.IsNullOrEmpty(XSession.Session["id_grupo_depar"]))// revisamos si el empleado tiene un grupo asignado
	{
	 while (temp <= fin)// Si el empleado no tiene grupo asignado se recorrera las fechas que comprenden el permiso desde la fecha inicio hasta la fecha fin. 
	 {
		 // Se consulta la cantidad de permisos del departamento del empleado que hay para esa fecha validar
		string SQLPermisoGrupo = "SELECT COUNT(id_permisos) as permisos FROM dbo.PERMISOSGRUPOS where fecha_permisos = '"+temp.ToString("yyyy/MM/dd")+"' and id_departamento = "+XSession.Session["id_departamento"].ToString();
		XVar rsPG = CommonFunctions.db_query(SQLPermisoGrupo, null);
		XVar PermisosxGrupos = CommonFunctions.db_fetch_array(rsPG);

		 if(PermisosxGrupos)//Si hay permisos para la fecha consultada se procede validar que no se haya alcanzado el valor limite de permisos diarios por departamento
			{
				//Consultamos el limite de permisos diarios asignado al departamento
				string SQLlimitepermisos = "SELECT limite_permisos FROM DEPARTAMENTO WHERE id_departamento = "+XSession.Session["id_departamento"].ToString();
				XVar rsLP = CommonFunctions.db_query(SQLlimitepermisos, null);
				XVar limitePermisos = CommonFunctions.db_fetch_array(rsLP);
				if(PermisosxGrupos["permisos"]>=limitePermisos["limite_permisos"])//Validamos si la cantidad de permisos para esta fecha ha alcanzado la cantidad de permisos permitido por dia  
				{
					//Si la condicion es verdadera se muestra un mensaje y no se ingresa el permiso
					message="La fecha "+temp.ToString()+"Compredida en periodo del permiso que esta solicitando, sobrepasa el limte de permiso diarios de "+limitePermisos["limite_permisos"].ToString();
					return false;
				}else
				{			
					//Si la condicion es falsa se inserta la fecha en la tabla PERMISOSGRUPOS.
					string strSQLInsert = "insert into PERMISOSGRUPOS (fecha_permisos, id_departamento ) values ('"+temp.ToString("yyyy/MM/dd")+"', "+XSession.Session["id_departamento"].ToString()+")";
					CommonFunctions.db_exec(strSQLInsert, null);
				}
			}
		 temp = temp.AddDays(1);//Se suma un dia al bucle
	 }
	}else//El empleado si tiene un grupo asignado  
		{
			while (temp <= fin)// Si el empleado tiene un grupo asignado se recorrera las fechas que comprenden el permiso desde la fecha inicio hasta la fecha fin.
			{
				 // Se consulta la cantidad de permisos del grupo del empleado que hay para esta fecha
				string SQLPermisoGrupo = "SELECT COUNT(id_permisos) as permisos FROM dbo.PERMISOSGRUPOS where fecha_permisos = '"+temp.ToString("yyyy/MM/dd")+"' and id_departamento = "+XSession.Session["id_departamento"].ToString()+"and id_grupo = "+XSession.Session["id_grupo_depar"].ToString();
				XVar rsPG = CommonFunctions.db_query(SQLPermisoGrupo, null);
				XVar PermisosxGrupos = CommonFunctions.db_fetch_array(rsPG);	

				if(PermisosxGrupos)//Si hay permisos para la fecha consultada se procede validar que no se haya alcanzado el valor limite de permisos diarios por departamento
				{
				//Consultamos el limite de permisos diarios asignado al departamento
				string SQLlimitepermisos = "SELECT limite_permisos FROM DEPARTAMENTO WHERE id_departamento = "+XSession.Session["id_departamento"].ToString();
				XVar rsLP = CommonFunctions.db_query(SQLlimitepermisos, null);
				XVar limitePermisos = CommonFunctions.db_fetch_array(rsLP);
				if(PermisosxGrupos["permisos"]>=limitePermisos["limite_permisos"])//Validamos si la cantidad de permisos para esta fecha ha alcanzado la cantidad de permisos permitido por dia  
					{
						//Si la condicion es verdadera se muestra un mensaje y no se ingresa el permiso
						message="La fecha "+temp.ToString()+"Compredida en periodo del permiso que esta solicitando, sobrepasa el limte de permiso diarios de "+limitePermisos["limite_permisos"].ToString();
						return false;
					}else
					{			
						//Si la condicion es falsa se inserta la fecha en la tabla PERMISOSGRUPOS.
						string strSQLInsert = "insert into PERMISOSGRUPOS (fecha_permisos, id_departamento, id_grupo) values ('"+temp.ToString("yyyy/MM/dd")+"', "+XSession.Session["id_departamento"].ToString()+","+XSession.Session["id_grupo_depar"].ToString()+")";
						CommonFunctions.db_exec(strSQLInsert, null);
					}
				}
				temp = temp.AddDays(1);//Se suma un dia al bucle
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


try 
{
	strWhereClause = "ONI = '"+XSession.Session["ONI"].ToString()+"'";
}
catch (Exception e)
{
	  MVCFunctions.EchoToOutput("<div class=\"alert alert-danger\" role=\"alert\"><strong>Error!</strong> en el evento BeforeQueryList al filtrar la tabla por ONI: "+e.Message+"</div>");

}
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

	//Validar si una de la fechas solicitadas en el permiso ya se ha pasado de lo permitido por grupo o departamento.
	DateTime inicio = DateTime.Parse(fechaini);
	DateTime fin = DateTime.Parse(fechafin);
	DateTime temp = inicio;
	if (string.IsNullOrEmpty(XSession.Session["id_grupo_depar"]))// revisamos si el empleado tiene un grupo asignado
	{
	 while (temp <= fin)// Si el empleado no tiene grupo asignado se recorrera las fechas que comprenden el permiso desde la fecha inicio hasta la fecha fin. 
	 {
		 // Se consulta la cantidad de permisos del departamento del empleado que hay para esa fecha validar
		string SQLPermisoGrupo = "SELECT COUNT(id_permisos) as permisos FROM dbo.PERMISOSGRUPOS where fecha_permisos = '"+temp.ToString("yyyy/MM/dd")+"' and id_departamento = "+XSession.Session["id_departamento"].ToString();
		XVar rsPG = CommonFunctions.db_query(SQLPermisoGrupo, null);
		XVar PermisosxGrupos = CommonFunctions.db_fetch_array(rsPG);

		 if(PermisosxGrupos)//Si hay permisos para la fecha consultada se procede validar que no se haya alcanzado el valor limite de permisos diarios por departamento
			{
				//Consultamos el limite de permisos diarios asignado al departamento
				string SQLlimitepermisos = "SELECT limite_permisos FROM DEPARTAMENTO WHERE id_departamento = "+XSession.Session["id_departamento"].ToString();
				XVar rsLP = CommonFunctions.db_query(SQLlimitepermisos, null);
				XVar limitePermisos = CommonFunctions.db_fetch_array(rsLP);
				if(PermisosxGrupos["permisos"]>=limitePermisos["limite_permisos"])//Validamos si la cantidad de permisos para esta fecha ha alcanzado la cantidad de permisos permitido por dia  
				{
					//Si la condicion es verdadera se muestra un mensaje y no se ingresa el permiso
					message="La fecha "+temp.ToString()+"Compredida en periodo del permiso que esta solicitando, sobrepasa el limte de permiso diarios de "+limitePermisos["limite_permisos"].ToString();
					return false;
				}else
				{			
					//Si la condicion es falsa se inserta la fecha en la tabla PERMISOSGRUPOS.
					string strSQLInsert = "insert into PERMISOSGRUPOS (fecha_permisos, id_departamento) values ('"+temp.ToString("yyyy/MM/dd")+"', "+XSession.Session["id_departamento"].ToString()+")";
					CommonFunctions.db_exec(strSQLInsert, null);
				}
			}
		 temp = temp.AddDays(1);//Se suma un dia al bucle
	 }
	}else//El empleado si tiene un grupo asignado  
		{
			while (temp <= fin)// Si el empleado tiene un grupo asignado se recorrera las fechas que comprenden el permiso desde la fecha inicio hasta la fecha fin.
			{
				 // Se consulta la cantidad de permisos del grupo del empleado que hay para esta fecha
				string SQLPermisoGrupo = "SELECT COUNT(id_permisos) as permisos FROM dbo.PERMISOSGRUPOS where fecha_permisos = '"+temp.ToString("yyyy/MM/dd")+"' and id_departamento = "+XSession.Session["id_departamento"].ToString()+"and id_grupo = "+XSession.Session["id_grupo_depar"].ToString();
				XVar rsPG = CommonFunctions.db_query(SQLPermisoGrupo, null);
				XVar PermisosxGrupos = CommonFunctions.db_fetch_array(rsPG);	

				if(PermisosxGrupos)//Si hay permisos para la fecha consultada se procede validar que no se haya alcanzado el valor limite de permisos diarios por departamento
				{
				//Consultamos el limite de permisos diarios asignado al departamento
				string SQLlimitepermisos = "SELECT limite_permisos FROM DEPARTAMENTO WHERE id_departamento = "+XSession.Session["id_departamento"].ToString();
				XVar rsLP = CommonFunctions.db_query(SQLlimitepermisos, null);
				XVar limitePermisos = CommonFunctions.db_fetch_array(rsLP);
				if(PermisosxGrupos["permisos"]>=limitePermisos["limite_permisos"])//Validamos si la cantidad de permisos para esta fecha ha alcanzado la cantidad de permisos permitido por dia  
					{
						//Si la condicion es verdadera se muestra un mensaje y no se ingresa el permiso
						message="La fecha "+temp.ToString()+"Compredida en periodo del permiso que esta solicitando, sobrepasa el limte de permiso diarios de "+limitePermisos["limite_permisos"].ToString();
						return false;
					}else
					{			
						//Si la condicion es falsa se inserta la fecha en la tabla PERMISOSGRUPOS.
						string strSQLInsert = "insert into PERMISOSGRUPOS (fecha_permisos, id_departamento, id_grupo) values ('"+temp.ToString("yyyy/MM/dd")+"', "+XSession.Session["id_departamento"].ToString()+","+XSession.Session["id_grupo_depar"].ToString()+")";
						CommonFunctions.db_exec(strSQLInsert, null);
					}
				}
				temp = temp.AddDays(1);//Se suma un dia al bucle
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