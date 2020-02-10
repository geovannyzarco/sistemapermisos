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
	[Export(typeof(IEventProviderCS_VER_COMPESADOS))]
	public class eventclassCS_VER_COMPESADOS : IEventProviderCS_VER_COMPESADOS
	{


		//	handlers
// Is Record Editable
		public XVar IsRecordEditable(dynamic values, dynamic isEditable)
		{
if (values["id_estado_compesado"]>1)
{
	return false;
}else{
	return true;
}
return null;

		} // IsRecordEditable


	}

}