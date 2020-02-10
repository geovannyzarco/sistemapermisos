using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Dynamic;
using System.ComponentModel.Composition;
using System.Web;
using runnerDotNet;

namespace runnerDotNet
{
	[Export(typeof(IEventProviderCS_Licencias_sin_goce_sueldo))]
	public class eventclassCS_Licencias_sin_goce_sueldo : IEventProviderCS_Licencias_sin_goce_sueldo
	{


		//	handlers
// Is Record Editable
		public XVar IsRecordEditable(dynamic values, dynamic isEditable)
		{



return null;

		} // IsRecordEditable


	}

}