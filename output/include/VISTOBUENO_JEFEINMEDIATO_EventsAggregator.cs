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
	public interface IEventProviderCS_VISTOBUENO_JEFEINMEDIATO
	{

		//	handlers

		XVar BeforeProcessAdd(dynamic pageObject);


		XVar BeforeAdd(dynamic values, ref dynamic message, dynamic inline, dynamic pageObject);


		XVar BeforeQueryList(dynamic strSQL, ref dynamic strWhereClause, ref dynamic strOrderBy, dynamic pageObject);





	}

	public interface IEventProviderVB_VISTOBUENO_JEFEINMEDIATO
	{

		//	handlers



	}

	public class eventclass_VISTOBUENO_JEFEINMEDIATO : EventsAggregatorBase
	{
		[Import(typeof(IEventProviderCS_VISTOBUENO_JEFEINMEDIATO))]
		public IEventProviderCS_VISTOBUENO_JEFEINMEDIATO EventProviderCS;

		[Import(typeof(IEventProviderVB_VISTOBUENO_JEFEINMEDIATO))]
		public IEventProviderVB_VISTOBUENO_JEFEINMEDIATO EventProviderVB;


		public eventclass_VISTOBUENO_JEFEINMEDIATO()
		{
			DoImport();

			// fill list of events

			events["BeforeProcessAdd"]=true;


			events["BeforeAdd"]=true;


			events["BeforeQueryList"]=true;


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



		public XVar BeforeQueryList(dynamic strSQL, ref dynamic strWhereClause, ref dynamic strOrderBy, dynamic pageObject)
		{
			return EventProviderCS.BeforeQueryList(strSQL, ref strWhereClause, ref strOrderBy, pageObject);
		}





	}
}