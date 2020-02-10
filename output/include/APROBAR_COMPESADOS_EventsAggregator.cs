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
	public interface IEventProviderCS_APROBAR_COMPESADOS
	{

		//	handlers

		XVar AfterAdd(dynamic values, dynamic keys, dynamic inline, dynamic pageObject);


		XVar BeforeQueryList(dynamic strSQL, ref dynamic strWhereClause, ref dynamic strOrderBy, dynamic pageObject);





	}

	public interface IEventProviderVB_APROBAR_COMPESADOS
	{

		//	handlers



	}

	public class eventclass_APROBAR_COMPESADOS : EventsAggregatorBase
	{
		[Import(typeof(IEventProviderCS_APROBAR_COMPESADOS))]
		public IEventProviderCS_APROBAR_COMPESADOS EventProviderCS;

		[Import(typeof(IEventProviderVB_APROBAR_COMPESADOS))]
		public IEventProviderVB_APROBAR_COMPESADOS EventProviderVB;


		public eventclass_APROBAR_COMPESADOS()
		{
			DoImport();

			// fill list of events

			events["AfterAdd"]=true;


			events["BeforeQueryList"]=true;


		}


		//	handlers


		public XVar AfterAdd(dynamic values, dynamic keys, dynamic inline, dynamic pageObject)
		{
			return EventProviderCS.AfterAdd(values, keys, inline, pageObject);
		}



		public XVar BeforeQueryList(dynamic strSQL, ref dynamic strWhereClause, ref dynamic strOrderBy, dynamic pageObject)
		{
			return EventProviderCS.BeforeQueryList(strSQL, ref strWhereClause, ref strOrderBy, pageObject);
		}





	}
}