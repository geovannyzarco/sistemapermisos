using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Reflection;
using runnerDotNet;
namespace runnerDotNet
{
	public partial class GlobalController : BaseController
	{
		public XVar buttonhandler()
		{
			try
			{
				dynamic buttId = null, eventId = null, page = null, table = null, var_params = XVar.Array();
				var_params = XVar.Clone(MVCFunctions.my_json_decode((XVar)(MVCFunctions.postvalue(new XVar("params")))));
				buttId = XVar.Clone(var_params["buttId"]);
				eventId = XVar.Clone(MVCFunctions.postvalue(new XVar("event")));
				table = XVar.Clone(var_params["table"]);
				page = XVar.Clone(var_params["page"]);
				if(buttId == "Guia_de_Permisos")
				{
					if((XVar)(table != Constants.GLOBAL_PAGES)  && (XVar)(CommonFunctions.GetTableURL((XVar)(table))))
					{
						Assembly.GetExecutingAssembly().GetType(MVCFunctions.Concat("runnerDotNet.", MVCFunctions.Concat("", CommonFunctions.GetTableURL((XVar)(table)), ""),
							"_Variables")).InvokeMember("Apply", BindingFlags.InvokeMethod, null, null, null);
						GlobalVars.cipherer = XVar.Clone(new RunnerCipherer((XVar)(table)));
					}
					buttonHandler_Guia_de_Permisos((XVar)(var_params));
				}
				if(buttId == "Ver_Instrutivo")
				{
					if((XVar)(table != Constants.GLOBAL_PAGES)  && (XVar)(CommonFunctions.GetTableURL((XVar)(table))))
					{
						Assembly.GetExecutingAssembly().GetType(MVCFunctions.Concat("runnerDotNet.", MVCFunctions.Concat("", CommonFunctions.GetTableURL((XVar)(table)), ""),
							"_Variables")).InvokeMember("Apply", BindingFlags.InvokeMethod, null, null, null);
						GlobalVars.cipherer = XVar.Clone(new RunnerCipherer((XVar)(table)));
					}
					buttonHandler_Ver_Instrutivo((XVar)(var_params));
				}
				return MVCFunctions.GetBuferContentAndClearBufer();
			}
			catch(RunnerRedirectException ex)
			{ return Redirect(ex.Message); }
		}
		public static XVar buttonHandler_Guia_de_Permisos(dynamic _param_params)
		{
			#region pass-by-value parameters
			dynamic var_params = XVar.Clone(_param_params);
			#endregion

			dynamic ajax = null, button = null, contextParams = XVar.Array(), keys = null, masterData = null, result = null;
			result = XVar.Clone(XVar.Array());
			var_params.InitAndSetArrayItem(MVCFunctions.my_json_decode((XVar)(MVCFunctions.postvalue(new XVar("keys")))), "keys");
			var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("isManyKeys")), "isManyKeys");
			var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("location")), "location");
			button = XVar.Clone(new Button((XVar)(var_params)));
			ajax = XVar.Clone(button);
			keys = XVar.Clone(button.getKeys());
			masterData = new XVar(false);
			if((XVar)(var_params.KeyExists("masterData"))  && (XVar)(0 < MVCFunctions.count(var_params["masterData"])))
			{
				masterData = XVar.Clone(var_params["masterData"]);
			}
			else
			{
				if(XVar.Pack(var_params.KeyExists("masterTable")))
				{
					masterData = XVar.Clone(button.getMasterData((XVar)(var_params["masterTable"])));
				}
			}
			contextParams = XVar.Clone(XVar.Array());
			if(var_params["location"] == Constants.PAGE_VIEW)
			{
				contextParams.InitAndSetArrayItem(button.getRecordData(), "data");
				contextParams.InitAndSetArrayItem(masterData, "masterData");
			}
			else
			{
				if(var_params["location"] == Constants.PAGE_EDIT)
				{
					contextParams.InitAndSetArrayItem(button.getRecordData(), "data");
					contextParams.InitAndSetArrayItem(var_params["fieldsData"], "newData");
					contextParams.InitAndSetArrayItem(masterData, "masterData");
				}
				else
				{
					if(var_params["location"] == "grid")
					{
						var_params.InitAndSetArrayItem("list", "location");
						contextParams.InitAndSetArrayItem(button.getRecordData(), "data");
						contextParams.InitAndSetArrayItem(var_params["fieldsData"], "newData");
						contextParams.InitAndSetArrayItem(masterData, "masterData");
					}
					else
					{
						contextParams.InitAndSetArrayItem(masterData, "masterData");
					}
				}
			}
			RunnerContext.push((XVar)(new RunnerContextItem((XVar)(var_params["location"]), (XVar)(contextParams))));
			
var eventContext = XVar.Array();
eventContext["var_params"] = var_params;
eventContext["result"] = result;
eventContext["keys"] = keys;
eventContext["button"] = button;
GlobalVars.globalEvents.event_Guia_de_Permisos(eventContext);
result = eventContext["result"];

			RunnerContext.pop();
			MVCFunctions.Echo(MVCFunctions.my_json_encode((XVar)(result)));
			return null;
		}
		public static XVar buttonHandler_Ver_Instrutivo(dynamic _param_params)
		{
			#region pass-by-value parameters
			dynamic var_params = XVar.Clone(_param_params);
			#endregion

			dynamic ajax = null, button = null, contextParams = XVar.Array(), keys = null, masterData = null, result = null;
			result = XVar.Clone(XVar.Array());
			var_params.InitAndSetArrayItem(MVCFunctions.my_json_decode((XVar)(MVCFunctions.postvalue(new XVar("keys")))), "keys");
			var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("isManyKeys")), "isManyKeys");
			var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("location")), "location");
			button = XVar.Clone(new Button((XVar)(var_params)));
			ajax = XVar.Clone(button);
			keys = XVar.Clone(button.getKeys());
			masterData = new XVar(false);
			if((XVar)(var_params.KeyExists("masterData"))  && (XVar)(0 < MVCFunctions.count(var_params["masterData"])))
			{
				masterData = XVar.Clone(var_params["masterData"]);
			}
			else
			{
				if(XVar.Pack(var_params.KeyExists("masterTable")))
				{
					masterData = XVar.Clone(button.getMasterData((XVar)(var_params["masterTable"])));
				}
			}
			contextParams = XVar.Clone(XVar.Array());
			if(var_params["location"] == Constants.PAGE_VIEW)
			{
				contextParams.InitAndSetArrayItem(button.getRecordData(), "data");
				contextParams.InitAndSetArrayItem(masterData, "masterData");
			}
			else
			{
				if(var_params["location"] == Constants.PAGE_EDIT)
				{
					contextParams.InitAndSetArrayItem(button.getRecordData(), "data");
					contextParams.InitAndSetArrayItem(var_params["fieldsData"], "newData");
					contextParams.InitAndSetArrayItem(masterData, "masterData");
				}
				else
				{
					if(var_params["location"] == "grid")
					{
						var_params.InitAndSetArrayItem("list", "location");
						contextParams.InitAndSetArrayItem(button.getRecordData(), "data");
						contextParams.InitAndSetArrayItem(var_params["fieldsData"], "newData");
						contextParams.InitAndSetArrayItem(masterData, "masterData");
					}
					else
					{
						contextParams.InitAndSetArrayItem(masterData, "masterData");
					}
				}
			}
			RunnerContext.push((XVar)(new RunnerContextItem((XVar)(var_params["location"]), (XVar)(contextParams))));
			
var eventContext = XVar.Array();
eventContext["var_params"] = var_params;
eventContext["result"] = result;
eventContext["keys"] = keys;
eventContext["button"] = button;
GlobalVars.globalEvents.event_Ver_Instrutivo(eventContext);
result = eventContext["result"];

			RunnerContext.pop();
			MVCFunctions.Echo(MVCFunctions.my_json_encode((XVar)(result)));
			return null;
		}
	}
}
