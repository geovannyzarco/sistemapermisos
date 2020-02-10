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
	public interface IEventProviderCS_APROBAR_PERMISOS
	{

		//	handlers

		XVar AfterEdit(dynamic values, dynamic where, dynamic oldvalues, dynamic keys, dynamic inline, dynamic pageObject);





	}

	public interface IEventProviderVB_APROBAR_PERMISOS
	{

		//	handlers



	}

	public class eventclass_APROBAR_PERMISOS : EventsAggregatorBase
	{
		[Import(typeof(IEventProviderCS_APROBAR_PERMISOS))]
		public IEventProviderCS_APROBAR_PERMISOS EventProviderCS;

		[Import(typeof(IEventProviderVB_APROBAR_PERMISOS))]
		public IEventProviderVB_APROBAR_PERMISOS EventProviderVB;


		public eventclass_APROBAR_PERMISOS()
		{
			DoImport();

			// fill list of events

			events["AfterEdit"]=true;


		}


		//	handlers


		public XVar AfterEdit(dynamic values, dynamic where, dynamic oldvalues, dynamic keys, dynamic inline, dynamic pageObject)
		{
			return EventProviderCS.AfterEdit(values, where, oldvalues, keys, inline, pageObject);
		}





	}
}