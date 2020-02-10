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
		public XVar searchsuggest()
		{
			try
			{
				dynamic _connection = null, allSearchFields = null, dashSearchFields = XVar.Array(), dashSettings = null, detailKeys = XVar.Array(), forDashboardSimpleSearch = null, numberOfSuggests = null, pSetList = null, pageType = null, result = XVar.Array(), returnJSON = XVar.Array(), searchClauseObj = null, searchField = null, searchFor = null, searchOpt = null, table = null, whereClauses = XVar.Array();
				ProjectSettings pSet;
				CommonFunctions.add_nocache_headers();
				table = XVar.Clone(MVCFunctions.postvalue(new XVar("table")));
				GlobalVars.strTableName = XVar.Clone(CommonFunctions.GetTableByShort((XVar)(table)));
				if(XVar.Pack(!(XVar)(CommonFunctions.checkTableName((XVar)(table)))))
				{
					MVCFunctions.Echo(new XVar(0));
					return MVCFunctions.GetBuferContentAndClearBufer();
				}
				Assembly.GetExecutingAssembly().GetType(MVCFunctions.Concat("runnerDotNet.", MVCFunctions.Concat("", table, ""),
					"_Variables")).InvokeMember("Apply", BindingFlags.InvokeMethod, null, null, null);
				if(XVar.Pack(!(XVar)(CommonFunctions.isLogged())))
				{
					return MVCFunctions.GetBuferContentAndClearBufer();
				}
				if(XVar.Pack(!(XVar)(CommonFunctions.CheckSecurity((XVar)(XSession.Session[MVCFunctions.Concat("_", GlobalVars.strTableName, "_OwnerID")]), new XVar("Search")))))
				{
					return MVCFunctions.GetBuferContentAndClearBufer();
				}
				searchFor = XVar.Clone(MVCFunctions.trim((XVar)(MVCFunctions.postvalue(new XVar("searchFor")))));
				if(searchFor == XVar.Pack(""))
				{
					MVCFunctions.Echo(CommonFunctions.printJSON((XVar)(new XVar("success", true, "result", ""))));
					return MVCFunctions.GetBuferContentAndClearBufer();
				}
				searchOpt = XVar.Clone((XVar.Pack(MVCFunctions.postvalue(new XVar("start"))) ? XVar.Pack("Starts with") : XVar.Pack("Contains")));
				searchField = XVar.Clone(MVCFunctions.GoodFieldName((XVar)(MVCFunctions.postvalue(new XVar("searchField")))));
				numberOfSuggests = XVar.Clone(CommonFunctions.GetGlobalData(new XVar("searchSuggestsNumber"), new XVar(10)));
				whereClauses = XVar.Clone(XVar.Array());
				pageType = XVar.Clone(MVCFunctions.postvalue(new XVar("pageType")));
				if(XVar.Pack(!(XVar)(pageType)))
				{
					pageType = new XVar(Constants.PAGE_LIST);
				}
				forDashboardSimpleSearch = XVar.Clone((XVar)(!(XVar)(searchField))  && (XVar)(pageType == Constants.PAGE_DASHBOARD));
				if(XVar.Pack(forDashboardSimpleSearch))
				{
					dynamic dashGoogleLikeFields = XVar.Array(), sfdata = XVar.Array();
					dashSettings = XVar.Clone(new ProjectSettings((XVar)(GlobalVars.strTableName), new XVar(Constants.PAGE_DASHBOARD)));
					dashGoogleLikeFields = XVar.Clone(dashSettings.getGoogleLikeFields());
					dashSearchFields = XVar.Clone(dashSettings.getDashboardSearchFields());
					sfdata = XVar.Clone(XVar.Array());
					foreach (KeyValuePair<XVar, dynamic> g in dashGoogleLikeFields.GetEnumerator())
					{
						foreach (KeyValuePair<XVar, dynamic> data in dashSearchFields[g.Value].GetEnumerator())
						{
							sfdata.InitAndSetArrayItem(data.Value["field"], data.Value["table"], null);
						}
					}
					foreach (KeyValuePair<XVar, dynamic> fields in sfdata.GetEnumerator())
					{
						dynamic _result = XVar.Array();
						if(numberOfSuggests <= MVCFunctions.count(result))
						{
							break;
						}
						if(XVar.Pack(!(XVar)(MVCFunctions.count(result))))
						{
							result = XVar.Clone(XVar.Array());
						}
						_result = XVar.Clone(CommonFunctions.getListOfSuggests((XVar)(fields.Value), (XVar)(fields.Key), (XVar)(whereClauses), (XVar)(numberOfSuggests - MVCFunctions.count(result)), (XVar)(searchOpt), (XVar)(searchFor)));
						foreach (KeyValuePair<XVar, dynamic> _data in _result.GetEnumerator())
						{
							dynamic found = null;
							found = new XVar(false);
							foreach (KeyValuePair<XVar, dynamic> data in result.GetEnumerator())
							{
								if(data.Value["realValue"] == _data.Value["realValue"])
								{
									found = new XVar(true);
									break;
								}
							}
							if(XVar.Pack(!(XVar)(found)))
							{
								result.InitAndSetArrayItem(_data.Value, null);
							}
						}
					}
					MVCFunctions.Echo(CommonFunctions.printJSON((XVar)(new XVar("success", true, "result", result))));
					MVCFunctions.Echo(new XVar(""));
					return MVCFunctions.GetBuferContentAndClearBufer();
				}
				if(pageType == Constants.PAGE_DASHBOARD)
				{
					dynamic sfData = XVar.Array();
					dashSettings = XVar.Clone(new ProjectSettings((XVar)(GlobalVars.strTableName), new XVar(Constants.PAGE_DASHBOARD)));
					dashSearchFields = XVar.Clone(dashSettings.getDashboardSearchFields());
					sfData = XVar.Clone(dashSearchFields[searchField][0]);
					searchField = XVar.Clone(MVCFunctions.GoodFieldName((XVar)(sfData["field"])));
					table = XVar.Clone(MVCFunctions.GoodFieldName((XVar)(sfData["table"])));
					if(XVar.Pack(!(XVar)(CommonFunctions.checkTableName((XVar)(table)))))
					{
						MVCFunctions.Echo(new XVar(0));
						return MVCFunctions.GetBuferContentAndClearBufer();
					}
					GlobalVars.strTableName = XVar.Clone(CommonFunctions.GetTableByShort((XVar)(table)));
					Assembly.GetExecutingAssembly().GetType(MVCFunctions.Concat("runnerDotNet.", MVCFunctions.Concat("", table, ""),
						"_Variables")).InvokeMember("Apply", BindingFlags.InvokeMethod, null, null, null);
					foreach (KeyValuePair<XVar, dynamic> elem in dashSettings.getDashboardElements().GetEnumerator())
					{
						if(elem.Value["table"] == GlobalVars.strTableName)
						{
							pageType = new XVar(Constants.PAGE_LIST);
							if(elem.Value["type"] == Constants.DASHBOARD_CHART)
							{
								pageType = new XVar(Constants.PAGE_CHART);
							}
							else
							{
								if(elem.Value["type"] == Constants.DASHBOARD_REPORT)
								{
									pageType = new XVar(Constants.PAGE_REPORT);
								}
							}
							break;
						}
					}
				}
				pSetList = XVar.Clone(new ProjectSettings((XVar)(GlobalVars.strTableName), (XVar)(pageType)));
				if(searchField == XVar.Pack(""))
				{
					allSearchFields = XVar.Clone(pSetList.getGoogleLikeFields());
				}
				else
				{
					allSearchFields = XVar.Clone(pSetList.getAllSearchFields());
				}
				pSet = XVar.UnPackProjectSettings(new ProjectSettings((XVar)(GlobalVars.strTableName), new XVar(Constants.PAGE_SEARCH)));
				GlobalVars.cipherer = XVar.Clone(new RunnerCipherer((XVar)(GlobalVars.strTableName)));
				_connection = XVar.Clone(GlobalVars.cman.byTable((XVar)(GlobalVars.strTableName)));
				detailKeys = XVar.Clone(XVar.Array());
				if(XSession.Session[MVCFunctions.Concat(GlobalVars.strTableName, "_mastertable")] != "")
				{
					dynamic i = null, j = null, masterTablesInfoArr = XVar.Array(), masterWhere = null, mastervalue = null;
					masterWhere = new XVar("");
					masterTablesInfoArr = XVar.Clone(pSet.getMasterTablesArr((XVar)(GlobalVars.strTableName)));
					i = new XVar(0);
					for(;i < MVCFunctions.count(masterTablesInfoArr); i++)
					{
						if(XSession.Session[MVCFunctions.Concat(GlobalVars.strTableName, "_mastertable")] != masterTablesInfoArr[i]["mDataSourceTable"])
						{
							continue;
						}
						detailKeys = XVar.Clone(masterTablesInfoArr[i]["detailKeys"]);
						j = new XVar(0);
						for(;j < MVCFunctions.count(detailKeys); j++)
						{
							mastervalue = XVar.Clone(GlobalVars.cipherer.MakeDBValue((XVar)(detailKeys[j]), (XVar)(XSession.Session[MVCFunctions.Concat(GlobalVars.strTableName, "_masterkey", j + 1)]), new XVar(""), new XVar(true)));
							if(mastervalue == "null")
							{
								masterWhere = MVCFunctions.Concat(masterWhere, RunnerPage._getFieldSQL((XVar)(detailKeys[j]), (XVar)(_connection), (XVar)(pSet)), " is NULL ");
							}
							else
							{
								masterWhere = MVCFunctions.Concat(masterWhere, RunnerPage._getFieldSQLDecrypt((XVar)(detailKeys[j]), (XVar)(_connection), (XVar)(pSet), (XVar)(GlobalVars.cipherer)), "=", mastervalue);
							}
						}
						break;
					}
					whereClauses.InitAndSetArrayItem(masterWhere, null);
				}
				searchClauseObj = XVar.Clone(SearchClause.getSearchObject((XVar)(GlobalVars.strTableName), new XVar(""), (XVar)(GlobalVars.strTableName), (XVar)(GlobalVars.cipherer)));
				searchClauseObj.processFiltersWhere((XVar)(_connection));
				foreach (KeyValuePair<XVar, dynamic> filteredField in searchClauseObj.filteredFields.GetEnumerator())
				{
					whereClauses.InitAndSetArrayItem(filteredField.Value["where"], null);
				}
				result = XVar.Clone(CommonFunctions.getListOfSuggests((XVar)(allSearchFields), (XVar)(GlobalVars.strTableName), (XVar)(whereClauses), (XVar)(numberOfSuggests), (XVar)(searchOpt), (XVar)(searchFor), (XVar)(searchField), (XVar)(detailKeys)));
				returnJSON = XVar.Clone(XVar.Array());
				returnJSON.InitAndSetArrayItem(true, "success");
				returnJSON.InitAndSetArrayItem(result, "result");
				MVCFunctions.Echo(CommonFunctions.printJSON((XVar)(returnJSON)));
				MVCFunctions.Echo(new XVar(""));
				return MVCFunctions.GetBuferContentAndClearBufer();
			}
			catch(RunnerRedirectException ex)
			{ return Redirect(ex.Message); }
		}
	}
}
