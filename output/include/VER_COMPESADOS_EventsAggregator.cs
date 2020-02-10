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
	public interface IEventProviderCS_VER_COMPESADOS
	{

		//	handlers

		XVar IsRecordEditable(dynamic values, dynamic isEditable);





	}

	public interface IEventProviderVB_VER_COMPESADOS
	{

		//	handlers



	}

	public class eventclass_VER_COMPESADOS : EventsAggregatorBase
	{
		[Import(typeof(IEventProviderCS_VER_COMPESADOS))]
		public IEventProviderCS_VER_COMPESADOS EventProviderCS;

		[Import(typeof(IEventProviderVB_VER_COMPESADOS))]
		public IEventProviderVB_VER_COMPESADOS EventProviderVB;


		public eventclass_VER_COMPESADOS()
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