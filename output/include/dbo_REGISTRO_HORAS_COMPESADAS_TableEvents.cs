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
	[Export(typeof(IEventProviderCS_dbo_REGISTRO_HORAS_COMPESADAS))]
	public class eventclassCS_dbo_REGISTRO_HORAS_COMPESADAS : IEventProviderCS_dbo_REGISTRO_HORAS_COMPESADAS
	{


		//	handlers
// Is Record Editable
		public XVar IsRecordEditable(dynamic values, dynamic isEditable)
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



return null;

		} // IsRecordEditable

// List page: Before SQL query
		public XVar BeforeQueryList(dynamic strSQL, ref dynamic strWhereClause, ref dynamic strOrderBy, dynamic pageObject)
		{
strWhereClause = "ONI = '"+XSession.Session["ONI"].ToString()+"'";

// Place event code here.
// Use "Add Action" button to add code snippets.
return null;

		} // BeforeQueryList

// After record added
		public XVar AfterAdd(dynamic values, dynamic keys, dynamic inline, dynamic pageObject)
		{
//string strSQLupdate = "setCantidadHorasCompesadas "+values["id_compesados"].ToString()+",'"+values["hora_realizado_inicio"].ToString()+"','"+values["hora_realizado_fin"].ToString()+"'";
//CommonFunctions.db_exec(strSQLupdate, null);

return null;

		} // AfterAdd

// After record updated
		public XVar AfterEdit(dynamic values, dynamic where, dynamic oldvalues, dynamic keys, dynamic inline, dynamic pageObject)
		{
//string strSQLupdate = "setCantidadHorasCompesadas "+values["id_compesados"].ToString()+",'"+values["hora_realizado_inicio"].ToString()+"','"+values["hora_realizado_fin"].ToString()+"'";
//CommonFunctions.db_exec(strSQLupdate, null);

// Place event code here.
// Use "Add Action" button to add code snippets.
return null;

		} // AfterEdit

// Before record added
		public XVar BeforeAdd(dynamic values, ref dynamic message, dynamic inline, dynamic pageObject)
		{


//obtener segundos de las fechas
try 
{
	string fechaini = "";
	string fechafin = "";
	fechaini = values["desde"];
	fechafin = values["hasta"];
	dynamic validarFechas;
	dynamic rsv = DB.Query("SELECT DATEDIFF(second, '"+values["desde"].ToString()+"', '"+values["hasta"].ToString()+"') as total_segundos");
	validarFechas= rsv.fetchAssoc();

 if(fechaini != "" && fechafin != "" && fechaini != null && fechafin != null)
            {
                if(validarFechas["total_segundos"] < 0)
						{
							message="La Fecha final debe ser mayor a la fecha inicial";
							MVCFunctions.EchoToOutput("La Fecha final debe ser mayor a la fecha inicial");
							return false;
						}
            }
            else
            {
               message = "Por favor revise fechas del compesado";
					MVCFunctions.EchoToOutput("Por favor revise fechas del compesado");
					return false;
            }
}catch (Exception e)
{
	  MVCFunctions.EchoToOutput("<div class=\"alert alert-danger\" ><strong>Error!</strong> en el evento BeforeAdd del formulario compensado al validar las fechas: "+e.Message+"</div>");

}
return true;
return null;

		} // BeforeAdd

// Before record updated
		public XVar BeforeEdit(dynamic values, dynamic where, dynamic oldvalues, dynamic keys, ref dynamic message, dynamic inline, dynamic pageObject)
		{


//obtener segundos de las fechas
try 
{
	string fechaini = "";
	string fechafin = "";
	fechaini = values["desde"];
	fechafin = values["hasta"];
	dynamic validarFechas;
	dynamic rsv = DB.Query("SELECT DATEDIFF(second, '"+values["desde"].ToString()+"', '"+values["hasta"].ToString()+"') as total_segundos");
	validarFechas= rsv.fetchAssoc();

 if(fechaini != "" && fechafin != "" && fechaini != null && fechafin != null)
            {
                if(validarFechas["total_segundos"] < 0)
						{
							message="La Fecha final debe ser mayor a la fecha inicial";
							MVCFunctions.EchoToOutput("La Fecha final debe ser mayor a la fecha inicial");
							return false;
						}
            }
            else
            {
               message = "Por favor revise fechas del compesado";
					MVCFunctions.EchoToOutput("Por favor revise fechas del compesado");
					return false;
            }
}catch (Exception e)
{
	  MVCFunctions.EchoToOutput("<div class=\"alert alert-danger\" ><strong>Error!</strong> en el evento BeforeEdit del formulario compensado al validar las fechas: "+e.Message+"</div>");

}

return true;
return null;

		} // BeforeEdit


	}

}