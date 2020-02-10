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
	public interface IEventProviderCS_APROBACION_COMPESADOS_JEFEDEPARTAMENTO
	{

		//	handlers

		XVar BeforeQueryList(dynamic strSQL, ref dynamic strWhereClause, ref dynamic strOrderBy, dynamic pageObject);





	}

	public interface IEventProviderVB_APROBACION_COMPESADOS_JEFEDEPARTAMENTO
	{

		//	handlers



	}

	public class eventclass_APROBACION_COMPESADOS_JEFEDEPARTAMENTO : EventsAggregatorBase
	{
		[Import(typeof(IEventProviderCS_APROBACION_COMPESADOS_JEFEDEPARTAMENTO))]
		public IEventProviderCS_APROBACION_COMPESADOS_JEFEDEPARTAMENTO EventProviderCS;

		[Import(typeof(IEventProviderVB_APROBACION_COMPESADOS_JEFEDEPARTAMENTO))]
		public IEventProviderVB_APROBACION_COMPESADOS_JEFEDEPARTAMENTO EventProviderVB;


		public eventclass_APROBACION_COMPESADOS_JEFEDEPARTAMENTO()
		{
			DoImport();

			// fill list of events

			events["BeforeQueryList"]=true;


		}


		//	handlers


		public XVar BeforeQueryList(dynamic strSQL, ref dynamic strWhereClause, ref dynamic strOrderBy, dynamic pageObject)
		{
			return EventProviderCS.BeforeQueryList(strSQL, ref strWhereClause, ref strOrderBy, pageObject);
		}





	}
}