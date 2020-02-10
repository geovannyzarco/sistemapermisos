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
	public interface IEventProviderCS_dbo_REGISTRO_HORAS_COMPESADAS
	{

		//	handlers

		XVar IsRecordEditable(dynamic values, dynamic isEditable);


		XVar BeforeQueryList(dynamic strSQL, ref dynamic strWhereClause, ref dynamic strOrderBy, dynamic pageObject);


		XVar AfterAdd(dynamic values, dynamic keys, dynamic inline, dynamic pageObject);


		XVar AfterEdit(dynamic values, dynamic where, dynamic oldvalues, dynamic keys, dynamic inline, dynamic pageObject);


		XVar BeforeAdd(dynamic values, ref dynamic message, dynamic inline, dynamic pageObject);


		XVar BeforeEdit(dynamic values, dynamic where, dynamic oldvalues, dynamic keys, ref dynamic message, dynamic inline, dynamic pageObject);





	}

	public interface IEventProviderVB_dbo_REGISTRO_HORAS_COMPESADAS
	{

		//	handlers



	}

	public class eventclass_dbo_REGISTRO_HORAS_COMPESADAS : EventsAggregatorBase
	{
		[Import(typeof(IEventProviderCS_dbo_REGISTRO_HORAS_COMPESADAS))]
		public IEventProviderCS_dbo_REGISTRO_HORAS_COMPESADAS EventProviderCS;

		[Import(typeof(IEventProviderVB_dbo_REGISTRO_HORAS_COMPESADAS))]
		public IEventProviderVB_dbo_REGISTRO_HORAS_COMPESADAS EventProviderVB;


		public eventclass_dbo_REGISTRO_HORAS_COMPESADAS()
		{
			DoImport();

			// fill list of events

			events["IsRecordEditable"]=true;


			events["BeforeQueryList"]=true;


			events["AfterAdd"]=true;


			events["AfterEdit"]=true;


			events["BeforeAdd"]=true;


			events["BeforeEdit"]=true;


		}


		//	handlers


		public XVar IsRecordEditable(dynamic values, dynamic isEditable)
		{
			return EventProviderCS.IsRecordEditable(values, isEditable);
		}



		public XVar BeforeQueryList(dynamic strSQL, ref dynamic strWhereClause, ref dynamic strOrderBy, dynamic pageObject)
		{
			return EventProviderCS.BeforeQueryList(strSQL, ref strWhereClause, ref strOrderBy, pageObject);
		}



		public XVar AfterAdd(dynamic values, dynamic keys, dynamic inline, dynamic pageObject)
		{
			return EventProviderCS.AfterAdd(values, keys, inline, pageObject);
		}



		public XVar AfterEdit(dynamic values, dynamic where, dynamic oldvalues, dynamic keys, dynamic inline, dynamic pageObject)
		{
			return EventProviderCS.AfterEdit(values, where, oldvalues, keys, inline, pageObject);
		}



		public XVar BeforeAdd(dynamic values, ref dynamic message, dynamic inline, dynamic pageObject)
		{
			return EventProviderCS.BeforeAdd(values, ref message, inline, pageObject);
		}



		public XVar BeforeEdit(dynamic values, dynamic where, dynamic oldvalues, dynamic keys, ref dynamic message, dynamic inline, dynamic pageObject)
		{
			return EventProviderCS.BeforeEdit(values, where, oldvalues, keys, ref message, inline, pageObject);
		}





	}
}