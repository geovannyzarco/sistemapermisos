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
	[Export(typeof(IEventProviderCS_APROBAR_PERMISOS))]
	public class eventclassCS_APROBAR_PERMISOS : IEventProviderCS_APROBAR_PERMISOS
	{


		//	handlers
// After record updated
		public XVar AfterEdit(dynamic values, dynamic where, dynamic oldvalues, dynamic keys, dynamic inline, dynamic pageObject)
		{
/*
if(values["id_estado_personal"]==2)
{
	DateTime fechaInicio = DateTime.Now();
	DateTime fechaFin = DateTime.Now.AddDays(5);
	for (var d = fechaInicio; d < fechaFin; d = d.AddDays(1))
		{
			MessageBox.Show(d.ToShortDateString());
		}
		
	
if(values["id_tipopermiso"]==1)
	{
		
	}else if (values["id_tipopermiso"]==2)
	{
			//Actualizar el campo saldo_compesado de la tabla empleado

			try
			{
			string UpdateSaldoCompesado = "UPDATE EMPLEADO SET saldo_compesado = saldo_compesado - "+ values["Horas"].ToString()+" WHERE ONI='"+values["ONI"].ToString()+"'";
			CommonFunctions.db_exec(UpdateSaldoCompesado, null);
			}
			catch (Exception e)
			{
				MVCFunctions.EchoToOutput(e.Message);
			}
	}
}*/




// Place event code here.
// Use "Add Action" button to add code snippets.
return null;

		} // AfterEdit


	}

}