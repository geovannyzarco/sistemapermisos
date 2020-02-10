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
	public interface IEventProviderCS_dbo_Permisos2
	{

		//	handlers

		XVar IsRecordEditable(dynamic values, dynamic isEditable);


		XVar BeforeAdd(dynamic values, ref dynamic message, dynamic inline, dynamic pageObject);


		XVar BeforeQueryList(dynamic strSQL, ref dynamic strWhereClause, ref dynamic strOrderBy, dynamic pageObject);


		XVar BeforeEdit(dynamic values, dynamic where, dynamic oldvalues, dynamic keys, ref dynamic message, dynamic inline, dynamic pageObject);





	}

	public interface IEventProviderVB_dbo_Permisos2
	{

		//	handlers



	}

	public class eventclass_dbo_Permisos2 : EventsAggregatorBase
	{
		[Import(typeof(IEventProviderCS_dbo_Permisos2))]
		public IEventProviderCS_dbo_Permisos2 EventProviderCS;

		[Import(typeof(IEventProviderVB_dbo_Permisos2))]
		public IEventProviderVB_dbo_Permisos2 EventProviderVB;


		public eventclass_dbo_Permisos2()
		{
			DoImport();

			// fill list of events

			events["IsRecordEditable"]=true;


			events["BeforeAdd"]=true;


			events["BeforeQueryList"]=true;


			events["BeforeEdit"]=true;


		}


		//	handlers


		public XVar IsRecordEditable(dynamic values, dynamic isEditable)
		{
			return EventProviderCS.IsRecordEditable(values, isEditable);
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