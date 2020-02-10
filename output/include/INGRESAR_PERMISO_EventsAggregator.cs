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
	public interface IEventProviderCS_INGRESAR_PERMISO
	{

		//	handlers

		XVar IsRecordEditable(dynamic values, dynamic isEditable);


		XVar BeforeProcessAdd(dynamic pageObject);


		XVar BeforeAdd(dynamic values, ref dynamic message, dynamic inline, dynamic pageObject);


		XVar BeforeQueryList(dynamic strSQL, ref dynamic strWhereClause, ref dynamic strOrderBy, dynamic pageObject);


		XVar BeforeEdit(dynamic values, dynamic where, dynamic oldvalues, dynamic keys, ref dynamic message, dynamic inline, dynamic pageObject);





	}

	public interface IEventProviderVB_INGRESAR_PERMISO
	{

		//	handlers



	}

	public class eventclass_INGRESAR_PERMISO : EventsAggregatorBase
	{
		[Import(typeof(IEventProviderCS_INGRESAR_PERMISO))]
		public IEventProviderCS_INGRESAR_PERMISO EventProviderCS;

		[Import(typeof(IEventProviderVB_INGRESAR_PERMISO))]
		public IEventProviderVB_INGRESAR_PERMISO EventProviderVB;


		public eventclass_INGRESAR_PERMISO()
		{
			DoImport();

			// fill list of events

			events["IsRecordEditable"]=true;


			events["BeforeProcessAdd"]=true;


			events["BeforeAdd"]=true;


			events["BeforeQueryList"]=true;


			events["BeforeEdit"]=true;


		}


		//	handlers


		public XVar IsRecordEditable(dynamic values, dynamic isEditable)
		{
			return EventProviderCS.IsRecordEditable(values, isEditable);
		}



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



		public XVar BeforeEdit(dynamic values, dynamic where, dynamic oldvalues, dynamic keys, ref dynamic message, dynamic inline, dynamic pageObject)
		{
			return EventProviderCS.BeforeEdit(values, where, oldvalues, keys, ref message, inline, pageObject);
		}





	}
}