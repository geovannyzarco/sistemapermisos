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
	[Export(typeof(IGlobalEventProviderCS))]
	public class CommonEvents : IGlobalEventProviderCS
	{

		// handlers

// After successful login
		public XVar AfterSuccessfulLogin(dynamic username, dynamic password, dynamic data, dynamic pageObject)
		{
try 
{
	XSession.Session["ONI"] = data["ONI"];
	
	dynamic record;
	//string query = string.Format("EXEC get_empleado '{0}'", data["ONI"].ToString());
	//dynamic rs = DB.Query(query);
	dynamic rs = DB.Query("EXEC get_empleado '"+data["ONI"].ToString()+"'");

	while(record= rs.fetchAssoc())
	{
	XSession.Session["nombre"] = record["nombre"];
	XSession.Session["departamento"] = record["departamento"];
	XSession.Session["tipo_empleado"] = record["tipo_empleado"];
	XSession.Session["horarios"] = record["horarios"];
	XSession.Session["id_departamento"] = record["id_departamento"];
	XSession.Session["id_tipo"] = record["id_tipo"];
	XSession.Session["id_horarios"] = record["id_horarios"];
	XSession.Session["GrupoID"] = record["GrupoID"];
	XSession.Session["id_grupo_depar"] = record["id_grupo"];
	}
}catch (Exception e)
{
	  MVCFunctions.EchoToOutput("<div class=\"alert alert-danger\" ><strong>Error!</strong> en el evento AfterSuccessfulLogin al asignar las variables session: "+e.Message+"</div>");
}


return null;

		} // AfterSuccessfulLogin


// After application initialized
		public XVar AfterAppInit()
		{
  //GlobalVars.dDebug = true;

// Place event code here.
// Use "Add Action" button to add code snippets.
return null;

		} // AfterAppInit


		// onscreen events
		public XVar event_Informacion_usuario(dynamic header)
		{

try 
{
	//Obtener Horas personales
	//dynamic personales;
	//dynamic rsp = DB.Query("EXEC getCantidadHorasPersonales '"+XSession.Session["ONI"].ToString()+"'");
	//personales = rsp.fetchAssoc();

	//Obtener Horas compesadas disponibles
	//string sqlcompesado= "SELECT dbo.EMPLEADO.saldo_compesado FROM dbo.EMPLEADO WHERE dbo.EMPLEADO.ONI='"+XSession.Session["ONI"].ToString()+"'";
	//XVar rsc = CommonFunctions.db_query(sqlcompesado, null);
	//XVar compesados = CommonFunctions.db_fetch_array(rsc);

	//dynamic compesados;
	//dynamic rsc = DB.Query("EXEC getCantidadHorasCompesadas '"+XSession.Session["ONI"].ToString()+"'");
	//compesados = rsc.fetchAssoc();


	//Obtener cantidad de permisos personales asignados
	string strSQLExists = string.Format("SELECT horas_permisos_personales from dbo.HORARIOS where id_horarios = '{0}'",XSession.Session["id_horarios"].ToString());
	XVar rsExists = CommonFunctions.db_query(strSQLExists, null);
	XVar data = CommonFunctions.db_fetch_array(rsExists);

	MVCFunctions.Echo("<div class =\"jumbotron\">");
		MVCFunctions.Echo("<div class =\"container\">");
			MVCFunctions.Echo("<h2 class =\"display-3\">Informacion de usuario</h2>");
			MVCFunctions.Echo("</br>");
			MVCFunctions.Echo("<p>ONI: "+XSession.Session["ONI"].ToString()+"</p>");
			MVCFunctions.Echo("<p>Nombre: "+XSession.Session["nombre"].ToString()+"</p>");
			MVCFunctions.Echo("<p>Cargo: "+XSession.Session["tipo_empleado"].ToString()+"</p>");
			MVCFunctions.Echo("<p>Departamento: "+XSession.Session["departamento"].ToString()+"</p>");
			MVCFunctions.Echo("<p>Horario: "+XSession.Session["horarios"].ToString()+"</p>");
			MVCFunctions.Echo("<p>Horas Personales Asignadas: "+data["horas_permisos_personales"].ToString()+"</p>");
			//MVCFunctions.Echo("<p>Horas Personales Usada: "+personales["total_horas"].ToString()+"</p>");
			//MVCFunctions.Echo("<p>Horas Compesadas Acumuladas: "+compesados["saldo_compesado"].ToString()+"</p>");
		MVCFunctions.Echo("</div>");
	MVCFunctions.Echo("</div>");

}
catch (Exception e)
{
MVCFunctions.EchoToOutput("<div class=\"alert alert-danger\" role=\"alert\"><strong>Error!</strong>Se presentado el siguiente error: "+e.Message+"</div>");
}





			return null;
		}
		public XVar event_dbo_Permisos2_snippet(dynamic header)
		{

			return null;
		}
		public XVar event_Mostrar_Horas(dynamic header)
		{
//Obtener segundos personales
try 
{
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



//Tiempo Personal

	 int tsegundos = personales["total_segundos"];
	 int horas = (tsegundos/3600);
	 int minutos = ((tsegundos-horas*3600)/60);
	 int segundos = tsegundos-(horas*3600+minutos*60);


//Tiempo compesado acumulado

	 int CAtsegundos = compesados["total_comp_segundos"];
	 int CAhoras = (CAtsegundos/3600);
	 int CAminutos = ((CAtsegundos-CAhoras*3600)/60);
	 int CAsegundos = CAtsegundos-(CAhoras*3600+CAminutos*60);


//Tiempo en los permisos compesados

	 int PCtsegundos = permisos_compesados["total_segundos"];
	 int PChoras = (PCtsegundos/3600);
	 int PCminutos = ((PCtsegundos-PChoras*3600)/60);
	 int PCsegundos = PCtsegundos-(horas*3600+PCminutos*60);

int compesado_disponible = CAtsegundos - PCtsegundos;

	 int PDtsegundos = compesado_disponible;
	 int PDhoras = (PDtsegundos/3600);
	 int PDminutos = ((PDtsegundos-PDhoras*3600)/60);
	 int PDsegundos = PDtsegundos-(PDhoras*3600+PDminutos*60);

//Mostrar en pantalla los tiempos

	//MVCFunctions.Echo("<h4>Horas personales: <font size=\"4\" color=\"red\">"+personales["total_horas"].ToString()+"</font><font size=\"4\">/"+data["horas_permisos_personales"].ToString()+"</font> Horas Compesadas: <font size=\"4\" color=\"blue\">"+compesados["saldo_compesado"].ToString()+"</font></h4>");
	MVCFunctions.Echo("<p>TIEMPO PERSONAL TOMADO: <font size=\"4\" color=\"red\">"+horas.ToString() + ":" + minutos.ToString() + "</font></p>");
	MVCFunctions.Echo("<p>HORAS PERSONALES ASIGNADAS: <font size=\"4\">"+data["horas_permisos_personales"].ToString()+"</font></p>");
	MVCFunctions.Echo("<p>TIEMPO COMPESADO ACUMULADO: <font size=\"4\" color=\"blue\">"+CAhoras.ToString() + ":" + CAminutos.ToString()+"</font></p>");
	MVCFunctions.Echo("<p>TIEMPO COMPESADO TOMANDO: <font size=\"4\" color=\"blue\">"+PChoras.ToString() + ":" + PCminutos.ToString()+"</font></p>");
	MVCFunctions.Echo("<p>TIEMPO COMPESADO DISPONIBLE: <font size=\"4\" color=\"blue\">"+PDhoras.ToString() + ":" + PDminutos.ToString()+"</font></p>");
}
catch (Exception e)
{
	MVCFunctions.EchoToOutput("<div class=\"alert alert-danger\" ><strong>Error!</strong> en el code_snippets Mostrar_Horas: "+e.Message+"</div>");
}


			return null;
		}
		public XVar event_Tabla_permisos_grupos(dynamic header)
		{
//Obtener los permisos por mes actual de cada departamento  y mostarlos en una tabla 
dynamic record;
dynamic rs = DB.Query("EXEC getPermisosDepartamentoMesActual "+XSession.Session["departamento"].ToString());

MVCFunctions.Echo("<div class=\"jumbotron\">");
	MVCFunctions.Echo("<div class=\"container\">");
			MVCFunctions.Echo("<table class=\"table\">");
					MVCFunctions.Echo("<thead>");
						MVCFunctions.Echo("<tr>");
							MVCFunctions.Echo("<th scope=\"col\">Fecha</th>");
							MVCFunctions.Echo("<th scope=\"col\">Permisos</th>");
							MVCFunctions.Echo("<th scope=\"col\">Limite</th>");
							MVCFunctions.Echo("<th scope=\"col\">Disponibles</th>");
						MVCFunctions.Echo("</tr>");
					MVCFunctions.Echo("</thead>");					
					MVCFunctions.Echo("<tbody>");
				if(rs!= null){
					while(record= rs.fetchAssoc())
							{
								MVCFunctions.Echo("<tr>");
								MVCFunctions.Echo("<td>"+record["fecha_permisos"].ToString()+"</td>");
								MVCFunctions.Echo("<td>"+record["cant_permisos"].ToString()+"</td>");
								MVCFunctions.Echo("<td>"+record["limite_permisos"].ToString()+"</td>");
								MVCFunctions.Echo("<td>"+record["dias_disponible"].ToString()+"</td>");
								MVCFunctions.Echo("</tr>");
							}

					}else
					{
						MVCFunctions.Echo("Todavia no hay fechas solicitadas para este mes");
					}
					MVCFunctions.Echo("</tbody>");
			MVCFunctions.Echo("</table>");
	MVCFunctions.Echo("</div>");	
MVCFunctions.Echo("</div>");
			return null;
		}

		// table maps, buttons
		public XVar event_Guia_de_Permisos(dynamic context)
		{
			// context unpacking
			var parameters = context["var_params"];
			var result = context["result"];
			var keys = context["keys"];
			var button = context["button"];
			var ajax = button;
			// event code


			// context packing
			context["var_params"] = parameters;
			context["result"] = result;
			context["keys"] = keys;
			context["button"] = button;
			return null;
		}
		public XVar event_Ver_Instrutivo(dynamic context)
		{
			// context unpacking
			var parameters = context["var_params"];
			var result = context["result"];
			var keys = context["keys"];
			var button = context["button"];
			var ajax = button;
			// event code


			// context packing
			context["var_params"] = parameters;
			context["result"] = result;
			context["keys"] = keys;
			context["button"] = button;
			return null;
		}




		public XVar AfterTableInit(dynamic context)
		{
			var table = context["table"];
			var query = context["query"];
			context["query"] = query;
			return null;
		}

		public XVar GetTablePermissions(dynamic permissions, dynamic table = null)
		{
			return permissions;
		}

		public XVar IsRecordEditable(dynamic values, dynamic isEditable, dynamic table = null)
		{
			if(table == "dbo.Permisos2")
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
			}
			if(table == "dbo.REGISTRO_HORAS_COMPESADAS")
			{
if (values["id_estado_compesado"]==2 || values["vistobueno2"]=="APROBADO" || values["vistobueno1"]=="APROBADO")
{
	return false;
}else if (values["id_estado_compesado"]==3 || values["vistobueno2"]=="DENEGADO" || values["vistobueno1"]=="DENEGADO")
{
	return false;
}else if (values["id_estado_compesado"]==4 || values["vistobueno2"]=="ANULADO" || values["vistobueno1"]=="ANULADO")
{
	return false;
}else 
{
	return true;
}



			}
			if(table == "INGRESAR PERMISO")
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
			}
			if(table == "INGRESAR_COMPESADO")
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


			}
			return isEditable;
		}
	}
}