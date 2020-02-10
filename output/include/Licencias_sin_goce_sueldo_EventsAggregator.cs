using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Dynamic;
using System.ComponentModel.Composition;
using runnerDotNet;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using System.Web;
using System.Reflection;

namespace runnerDotNet
{
	public interface IEventProviderCS_Licencias_sin_goce_sueldo
	{

		//	handlers

		XVar IsRecordEditable(dynamic values, dynamic isEditable);





	}

	public interface IEventProviderVB_Licencias_sin_goce_sueldo
	{

		//	handlers



	}

	public class eventclass_Licencias_sin_goce_sueldo : EventsAggregatorBase
	{
		[Import(typeof(IEventProviderCS_Licencias_sin_goce_sueldo))]
		public IEventProviderCS_Licencias_sin_goce_sueldo EventProviderCS;

		[Import(typeof(IEventProviderVB_Licencias_sin_goce_sueldo))]
		public IEventProviderVB_Licencias_sin_goce_sueldo EventProviderVB;


		public eventclass_Licencias_sin_goce_sueldo()
		{
			DoImport();

			// fill list of events

			events["IsRecordEditable"]=true;


		}


		//	handlers


		public XVar IsRecordEditable(dynamic values, dynamic isEditable)
		{
			return EventProviderCS.IsRecordEditable(values, isEditable);
		}





	}
}