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
	public interface IEventProviderCS_VER_PERMISOS
	{

		//	handlers

		XVar BeforeProcessAdd(dynamic pageObject);


		XVar BeforeAdd(dynamic values, ref dynamic message, dynamic inline, dynamic pageObject);





	}

	public interface IEventProviderVB_VER_PERMISOS
	{

		//	handlers



	}

	public class eventclass_VER_PERMISOS : EventsAggregatorBase
	{
		[Import(typeof(IEventProviderCS_VER_PERMISOS))]
		public IEventProviderCS_VER_PERMISOS EventProviderCS;

		[Import(typeof(IEventProviderVB_VER_PERMISOS))]
		public IEventProviderVB_VER_PERMISOS EventProviderVB;


		public eventclass_VER_PERMISOS()
		{
			DoImport();

			// fill list of events

			events["BeforeProcessAdd"]=true;


			events["BeforeAdd"]=true;


		}


		//	handlers


		public XVar BeforeProcessAdd(dynamic pageObject)
		{
			return EventProviderCS.BeforeProcessAdd(pageObject);
		}



		public XVar BeforeAdd(dynamic values, ref dynamic message, dynamic inline, dynamic pageObject)
		{
			return EventProviderCS.BeforeAdd(values, ref message, inline, pageObject);
		}





	}
}