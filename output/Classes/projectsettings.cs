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
	public partial class ProjectSettings : XClass
	{
		public dynamic _table;
		public dynamic _pageMode;
		public dynamic _pageType;
		public dynamic _page;
		public dynamic _viewPage = XVar.Pack(Constants.PAGE_VIEW);
		public dynamic _defaultViewPage = XVar.Pack(Constants.PAGE_VIEW);
		public dynamic _editPage = XVar.Pack(Constants.PAGE_EDIT);
		public dynamic _defaultEditPage = XVar.Pack(Constants.PAGE_EDIT);
		public dynamic _tableData = XVar.Array();
		public dynamic _optionsFile = XVar.Array();
		public dynamic _auxTable = XVar.Pack("");
		public dynamic _auxTableData = XVar.Array();
		public dynamic _pageOptions = XVar.Array();
		public dynamic _mastersTableData = XVar.Array();
		public dynamic _detailsTableData = XVar.Array();
		public dynamic _dashboardElemPSet = XVar.Array();
		public ProjectSettings(dynamic _param_table = null, dynamic _param_pageType = null, dynamic _param_page = null, dynamic _param_pageTable = null)
		{
			#region default values
			if(_param_table as Object == null) _param_table = new XVar("");
			if(_param_pageType as Object == null) _param_pageType = new XVar("");
			if(_param_page as Object == null) _param_page = new XVar("");
			if(_param_pageTable as Object == null) _param_pageTable = new XVar("");
			#endregion

			#region pass-by-value parameters
			dynamic table = XVar.Clone(_param_table);
			dynamic pageType = XVar.Clone(_param_pageType);
			dynamic page = XVar.Clone(_param_page);
			dynamic pageTable = XVar.Clone(_param_pageTable);
			#endregion

			if(XVar.Pack(!(XVar)(table)))
			{
				table = new XVar(Constants.GLOBAL_PAGES);
			}
			if(XVar.Pack(!(XVar)(pageTable)))
			{
				pageTable = XVar.Clone(table);
			}
			setTable((XVar)(table));
			if(table == pageTable)
			{
				this._auxTableData = this._tableData;
				this._auxTable = XVar.Clone(this._table);
			}
			else
			{
				loadAuxTable((XVar)(pageTable));
			}
			if((XVar)(page)  && (XVar)(getPageIds().KeyExists(page)))
			{
				setPage((XVar)(page));
			}
			else
			{
				if(XVar.Pack(pageType))
				{
					this._pageType = XVar.Clone(pageType);
					page = XVar.Clone(getDefaultPage((XVar)(pageType)));
					if(XVar.Pack(page))
					{
						setPage((XVar)(page));
					}
				}
			}
			if((XVar)(page)  && (XVar)(!(XVar)(pageType)))
			{
				pageType = XVar.Clone(getPageType());
			}
			if(XVar.Pack(pageType))
			{
				setPageType((XVar)(pageType));
			}
		}
		public virtual XVar loadPageOptions(dynamic _param_option = null)
		{
			#region default values
			if(_param_option as Object == null) _param_option = new XVar("");
			#endregion

			#region pass-by-value parameters
			dynamic var_option = XVar.Clone(_param_option);
			#endregion

			MVCFunctions.importPageOptions((XVar)(this._auxTable), (XVar)(this._page));
			return null;
		}
		public virtual XVar setPage(dynamic _param_page)
		{
			#region pass-by-value parameters
			dynamic page = XVar.Clone(_param_page);
			#endregion

			this._page = XVar.Clone(page);
			if(XVar.Equals(XVar.Pack(MVCFunctions.array_search((XVar)(page), (XVar)(getPageIds()))), XVar.Pack(false)))
			{
				return null;
			}
			this._optionsFile = XVar.Clone(MVCFunctions.getabspath((XVar)(MVCFunctions.Concat("include/pages/", CommonFunctions.GetTableURL((XVar)(this._auxTable)), "_", page, ".json"))));
			return null;
		}
		public virtual XVar setTable(dynamic _param_table)
		{
			#region pass-by-value parameters
			dynamic table = XVar.Clone(_param_table);
			#endregion

			dynamic tableType = null;
			this._table = XVar.Clone(table);
			if(CommonFunctions.GetTableURL((XVar)(table)) != "")
			{
				MVCFunctions.importTableSettings((XVar)(table));
			}
			if(XVar.Pack(GlobalVars.tables_data.KeyExists(this._table)))
			{
				this._tableData = GlobalVars.tables_data[this._table];
			}
			this._mastersTableData = GlobalVars.masterTablesData[this._table];
			this._detailsTableData = GlobalVars.detailsTablesData[this._table];
			tableType = XVar.Clone(getTableType());
			this._editPage = XVar.Clone(getDefaultEditPageType((XVar)(tableType)));
			this._viewPage = XVar.Clone(getDefaultViewPageType((XVar)(tableType)));
			this._defaultEditPage = XVar.Clone(this._editPage);
			this._defaultViewPage = XVar.Clone(this._viewPage);
			return null;
		}
		public virtual XVar loadAuxTable(dynamic _param_auxTable)
		{
			#region pass-by-value parameters
			dynamic auxTable = XVar.Clone(_param_auxTable);
			#endregion

			this._auxTable = XVar.Clone(auxTable);
			if(CommonFunctions.GetTableURL((XVar)(auxTable)) != "")
			{
				MVCFunctions.importTableSettings((XVar)(auxTable));
			}
			if(XVar.Pack(GlobalVars.tables_data.KeyExists(this._auxTable)))
			{
				this._auxTableData = GlobalVars.tables_data[this._auxTable];
			}
			return null;
		}
		public virtual XVar pageName()
		{
			return this._page;
		}
		public virtual XVar getDefaultViewPageType(dynamic _param_tableType)
		{
			#region pass-by-value parameters
			dynamic tableType = XVar.Clone(_param_tableType);
			#endregion

			if((XVar)(tableType == Constants.PAGE_CHART)  || (XVar)(tableType == Constants.PAGE_REPORT))
			{
				return tableType;
			}
			return Constants.PAGE_VIEW;
		}
		public virtual XVar getDefaultEditPageType(dynamic _param_tableType)
		{
			#region pass-by-value parameters
			dynamic tableType = XVar.Clone(_param_tableType);
			#endregion

			if((XVar)(tableType == Constants.PAGE_CHART)  || (XVar)(tableType == Constants.PAGE_REPORT))
			{
				return Constants.PAGE_SEARCH;
			}
			return Constants.PAGE_EDIT;
		}
		public virtual XVar setPageType(dynamic _param_page)
		{
			#region pass-by-value parameters
			dynamic page = XVar.Clone(_param_page);
			#endregion

			if(XVar.Pack(isPageTypeForView((XVar)(page))))
			{
				dynamic tableType = null;
				tableType = XVar.Clone(getTableType());
				if((XVar)((XVar)(tableType != "report")  && (XVar)(tableType != "chart"))  && (XVar)((XVar)(page == Constants.PAGE_CHART)  || (XVar)(page == Constants.PAGE_REPORT)))
				{
					this._viewPage = new XVar(Constants.PAGE_LIST);
				}
				else
				{
					this._viewPage = XVar.Clone(page);
				}
				this._defaultViewPage = XVar.Clone(getDefaultViewPageType((XVar)(tableType)));
			}
			if(XVar.Pack(isPageTypeForEdit((XVar)(page))))
			{
				this._editPage = XVar.Clone(page);
				this._defaultEditPage = XVar.Clone(getDefaultEditPageType((XVar)(getTableType())));
			}
			return null;
		}
		public virtual XVar getDefaultPages()
		{
			return getAuxTableData(new XVar(".defaultPages"));
		}
		public virtual XVar getDefaultPage(dynamic _param_type, dynamic _param_pageTable = null)
		{
			#region default values
			if(_param_pageTable as Object == null) _param_pageTable = new XVar("");
			#endregion

			#region pass-by-value parameters
			dynamic var_type = XVar.Clone(_param_type);
			dynamic pageTable = XVar.Clone(_param_pageTable);
			#endregion

			dynamic defPage = null, defPages = XVar.Array();
			if(XVar.Pack(CommonFunctions.isAdminPage((XVar)(this._auxTable))))
			{
				return this._pageType;
			}
			defPages = getAuxTableData(new XVar(".defaultPages"));
			defPage = XVar.Clone(defPages[var_type]);
			if(XVar.Pack(defPage))
			{
				return defPage;
			}
			return null;
		}
		public virtual XVar getPageIds()
		{
			dynamic ret = null;
			ret = XVar.Clone(getAuxTableData(new XVar(".pages")));
			if(XVar.Pack(!(XVar)(MVCFunctions.is_array((XVar)(ret)))))
			{
				return XVar.Array();
			}
			return ret;
		}
		public virtual XVar getEditPageType()
		{
			return this._editPage;
		}
		public virtual XVar isPageTypeForView(dynamic _param_ptype)
		{
			#region pass-by-value parameters
			dynamic ptype = XVar.Clone(_param_ptype);
			#endregion

			return MVCFunctions.in_array((XVar)(MVCFunctions.strtolower((XVar)(ptype))), (XVar)(GlobalVars.pageTypesForView));
		}
		public virtual XVar isPageTypeForEdit(dynamic _param_ptype)
		{
			#region pass-by-value parameters
			dynamic ptype = XVar.Clone(_param_ptype);
			#endregion

			return MVCFunctions.in_array((XVar)(MVCFunctions.strtolower((XVar)(ptype))), (XVar)(GlobalVars.pageTypesForEdit));
		}
		public virtual XVar getTable(dynamic _param_table, dynamic _param_page = null)
		{
			#region default values
			if(_param_page as Object == null) _param_page = new XVar("");
			#endregion

			#region pass-by-value parameters
			dynamic table = XVar.Clone(_param_table);
			dynamic page = XVar.Clone(_param_page);
			#endregion

			return new ProjectSettings((XVar)(table), (XVar)(page));
		}
		public virtual XVar getPageTypeByFieldEditFormat(dynamic _param_field, dynamic _param_editFormat)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			dynamic editFormat = XVar.Clone(_param_editFormat);
			#endregion

			if((XVar)(this._tableData.KeyExists(field))  && (XVar)(this._tableData[field].KeyExists(Constants.FORMAT_EDIT)))
			{
				foreach (KeyValuePair<XVar, dynamic> editSettings in this._tableData[field][Constants.FORMAT_EDIT].GetEnumerator())
				{
					if((XVar)(editSettings.Value.KeyExists("EditFormat"))  && (XVar)(editSettings.Value["EditFormat"] == editFormat))
					{
						return editSettings.Key;
					}
				}
			}
			return "";
		}
		public virtual XVar getTableData(dynamic _param_key)
		{
			#region pass-by-value parameters
			dynamic key = XVar.Clone(_param_key);
			#endregion

			if(XVar.Pack(!(XVar)(isExistsTableKey((XVar)(key)))))
			{
				return getDefaultValueByKey((XVar)(MVCFunctions.substr((XVar)(key), new XVar(1))));
			}
			return this._tableData[key];
		}
		public virtual XVar getAuxTableData(dynamic _param_key)
		{
			#region pass-by-value parameters
			dynamic key = XVar.Clone(_param_key);
			#endregion

			if(XVar.Pack(!(XVar)(isExistsAuxTableKey((XVar)(key)))))
			{
				return getDefaultValueByKey((XVar)(MVCFunctions.substr((XVar)(key), new XVar(1))));
			}
			return this._auxTableData[key];
		}
		public virtual XVar getPageOption(dynamic _param_key1, dynamic _param_key2 = null, dynamic _param_key3 = null, dynamic _param_key4 = null, dynamic _param_key5 = null)
		{
			#region default values
			if(_param_key2 as Object == null) _param_key2 = new XVar(false);
			if(_param_key3 as Object == null) _param_key3 = new XVar(false);
			if(_param_key4 as Object == null) _param_key4 = new XVar(false);
			if(_param_key5 as Object == null) _param_key5 = new XVar(false);
			#endregion

			#region pass-by-value parameters
			dynamic key1 = XVar.Clone(_param_key1);
			dynamic key2 = XVar.Clone(_param_key2);
			dynamic key3 = XVar.Clone(_param_key3);
			dynamic key4 = XVar.Clone(_param_key4);
			dynamic key5 = XVar.Clone(_param_key5);
			#endregion

			dynamic keys = XVar.Array(), opt = XVar.Array(), pageOptions = XVar.Array();
			loadPageOptions((XVar)(MVCFunctions.Concat(key1, key2)));
			pageOptions = GlobalVars.page_options[this._auxTable][this._page];
			if(XVar.Pack(!(XVar)(pageOptions.KeyExists(key1))))
			{
				return false;
			}
			keys = XVar.Clone(new XVar(0, key1));
			if(!XVar.Equals(XVar.Pack(key2), XVar.Pack(false)))
			{
				keys.InitAndSetArrayItem(key2, null);
			}
			if(!XVar.Equals(XVar.Pack(key3), XVar.Pack(false)))
			{
				keys.InitAndSetArrayItem(key3, null);
			}
			if(!XVar.Equals(XVar.Pack(key4), XVar.Pack(false)))
			{
				keys.InitAndSetArrayItem(key4, null);
			}
			if(!XVar.Equals(XVar.Pack(key5), XVar.Pack(false)))
			{
				keys.InitAndSetArrayItem(key5, null);
			}
			opt = pageOptions;
			foreach (KeyValuePair<XVar, dynamic> k in keys.GetEnumerator())
			{
				if(XVar.Pack(!(XVar)(MVCFunctions.is_array((XVar)(opt)))))
				{
					return false;
				}
				if(XVar.Pack(!(XVar)(opt.KeyExists(k.Value))))
				{
					return false;
				}
				opt = opt[k.Value];
			}
			return opt;
		}
		public virtual XVar getPageOptionArray(dynamic _param_keys)
		{
			#region pass-by-value parameters
			dynamic keys = XVar.Clone(_param_keys);
			#endregion

			dynamic opt = XVar.Array(), pageOptions = null;
			loadPageOptions();
			pageOptions = GlobalVars.page_options[this._auxTable][this._page];
			opt = pageOptions;
			foreach (KeyValuePair<XVar, dynamic> k in keys.GetEnumerator())
			{
				if(XVar.Pack(!(XVar)(MVCFunctions.is_array((XVar)(opt)))))
				{
					return false;
				}
				if(XVar.Pack(!(XVar)(opt.KeyExists(k.Value))))
				{
					return false;
				}
				opt = opt[k.Value];
			}
			return opt;
		}
		private XVar getEffectiveEditPage(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			if(XVar.Pack(isSeparate((XVar)(field))))
			{
				return this._editPage;
			}
			return this._defaultEditPage;
		}
		private XVar getEffectiveViewPage(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			if(XVar.Pack(isSeparate((XVar)(field))))
			{
				if((XVar)(this._pageMode == Constants.EDIT_INLINE)  && (XVar)(this._viewPage != Constants.PAGE_VIEW))
				{
					return Constants.PAGE_LIST;
				}
				else
				{
					if((XVar)(this._pageMode == Constants.LIST_MASTER)  && (XVar)(this._viewPage == Constants.PAGE_LIST))
					{
						return Constants.PAGE_MASTER_INFO_LIST;
					}
					else
					{
						if((XVar)(this._pageMode == Constants.LIST_MASTER)  && (XVar)(this._viewPage == Constants.PAGE_REPORT))
						{
							return Constants.PAGE_MASTER_INFO_REPORT;
						}
						else
						{
							if((XVar)(this._pageMode == Constants.PRINT_MASTER)  && (XVar)(this._viewPage == Constants.PAGE_RPRINT))
							{
								return Constants.PAGE_MASTER_INFO_RPRINT;
							}
							else
							{
								if(this._pageMode == Constants.PRINT_MASTER)
								{
									return Constants.PAGE_MASTER_INFO_PRINT;
								}
							}
						}
					}
				}
				return this._viewPage;
			}
			return this._defaultViewPage;
		}
		public virtual XVar getFieldData(dynamic _param_field, dynamic _param_key)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			dynamic key = XVar.Clone(_param_key);
			#endregion

			dynamic editPage = null, settingType = null, viewPage = null;
			if(getEntityType() == Constants.titDASHBOARD)
			{
				return getDashFieldData((XVar)(field), (XVar)(key));
			}
			if(XVar.Pack(!(XVar)(this._tableData.KeyExists(field))))
			{
				return getDefaultValueByKey((XVar)(key));
			}
			settingType = XVar.Clone(GlobalVars.g_settingsType[key]);
			if(settingType == null)
			{
				settingType = new XVar("");
			}
			switch(((XVar)settingType).ToString())
			{
				case Constants.SETTING_TYPE_VIEW:
					viewPage = XVar.Clone(getEffectiveViewPage((XVar)(field)));
					if(XVar.Pack(this._tableData[field][Constants.FORMAT_VIEW][viewPage].KeyExists(key)))
					{
						return this._tableData[field][Constants.FORMAT_VIEW][viewPage][key];
					}
					break;
				case Constants.SETTING_TYPE_EDIT:
					editPage = XVar.Clone(getEffectiveEditPage((XVar)(field)));
					if(XVar.Pack(this._tableData[field][Constants.FORMAT_EDIT][editPage].KeyExists(key)))
					{
						return this._tableData[field][Constants.FORMAT_EDIT][editPage][key];
					}
					break;
				default:
					if(XVar.Pack(this._tableData[field].KeyExists(key)))
					{
						return this._tableData[field][key];
					}
					break;
			}
			return getDefaultValueByKey((XVar)(key));
		}
		public virtual XVar setFieldData(dynamic _param_field, dynamic _param_key, dynamic _param_value)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			dynamic key = XVar.Clone(_param_key);
			dynamic value = XVar.Clone(_param_value);
			#endregion

			dynamic editPage = null, oldValue = null, settingType = null, viewPage = null;
			oldValue = XVar.Clone(getFieldData((XVar)(field), (XVar)(key)));
			settingType = XVar.Clone(GlobalVars.g_settingsType[key]);
			if(settingType == null)
			{
				settingType = new XVar("");
			}
			switch(((XVar)settingType).ToString())
			{
				case Constants.SETTING_TYPE_VIEW:
					viewPage = XVar.Clone(getEffectiveViewPage((XVar)(field)));
					this._tableData.InitAndSetArrayItem(value, field, Constants.FORMAT_VIEW, viewPage, key);
					break;
				case Constants.SETTING_TYPE_EDIT:
					editPage = XVar.Clone(getEffectiveEditPage((XVar)(field)));
					this._tableData.InitAndSetArrayItem(value, field, Constants.FORMAT_EDIT, editPage, key);
					break;
				default:
					this._tableData.InitAndSetArrayItem(value, field, key);
					break;
			}
			return oldValue;
		}
		public virtual XVar getTableName()
		{
			return this._table;
		}
		public virtual XVar findField(dynamic _param_f)
		{
			#region pass-by-value parameters
			dynamic f = XVar.Clone(_param_f);
			#endregion

			dynamic fields = XVar.Array(), gTable = null;
			fields = XVar.Clone(getFieldsList());
			if(!XVar.Equals(XVar.Pack(MVCFunctions.array_search((XVar)(f), (XVar)(fields))), XVar.Pack(false)))
			{
				return f;
			}
			gTable = XVar.Clone(MVCFunctions.GoodFieldName((XVar)(this._table)));
			if(XVar.Pack(GlobalVars.field_labels[GlobalVars.mlang_defaultlang].KeyExists(f)))
			{
				return getFieldByGoodFieldName((XVar)(f));
			}
			f = XVar.Clone(MVCFunctions.strtoupper((XVar)(f)));
			foreach (KeyValuePair<XVar, dynamic> ff in fields.GetEnumerator())
			{
				if(MVCFunctions.strtoupper((XVar)(ff.Value)) == f)
				{
					return ff.Value;
				}
				if(MVCFunctions.strtoupper((XVar)(MVCFunctions.GoodFieldName((XVar)(ff.Value)))) == f)
				{
					return ff.Value;
				}
			}
			return "";
		}
		public virtual XVar addCustomExpressionIndex(dynamic _param_mainTable, dynamic _param_mainField, dynamic _param_index)
		{
			#region pass-by-value parameters
			dynamic mainTable = XVar.Clone(_param_mainTable);
			dynamic mainField = XVar.Clone(_param_mainField);
			dynamic index = XVar.Clone(_param_index);
			#endregion

			if(XVar.Pack(!(XVar)(isExistsTableKey(new XVar(".customExpressionIndexes")))))
			{
				this._tableData.InitAndSetArrayItem(XVar.Array(), ".customExpressionIndexes");
			}
			if(XVar.Pack(!(XVar)(this._tableData[".customExpressionIndexes"].KeyExists(mainTable))))
			{
				this._tableData.InitAndSetArrayItem(XVar.Array(), ".customExpressionIndexes", mainTable);
			}
			this._tableData.InitAndSetArrayItem(index, ".customExpressionIndexes", mainTable, mainField);
			return null;
		}
		public virtual XVar getCustomExpressionIndex(dynamic _param_mainTable, dynamic _param_mainField)
		{
			#region pass-by-value parameters
			dynamic mainTable = XVar.Clone(_param_mainTable);
			dynamic mainField = XVar.Clone(_param_mainField);
			#endregion

			if(XVar.Pack(!(XVar)(isExistsTableKey(new XVar(".customExpressionIndexes")))))
			{
				this._tableData.InitAndSetArrayItem(XVar.Array(), ".customExpressionIndexes");
			}
			if((XVar)(this._tableData[".customExpressionIndexes"].KeyExists(mainTable))  && (XVar)(this._tableData[".customExpressionIndexes"][mainTable].KeyExists(mainField)))
			{
				return this._tableData[".customExpressionIndexes"][mainTable][mainField];
			}
			return false;
		}
		public virtual XVar isExistsTableKey(dynamic _param_key)
		{
			#region pass-by-value parameters
			dynamic key = XVar.Clone(_param_key);
			#endregion

			if(XVar.Pack(!(XVar)(this._tableData.KeyExists(key))))
			{
				return false;
			}
			return true;
		}
		public virtual XVar isExistsAuxTableKey(dynamic _param_key)
		{
			#region pass-by-value parameters
			dynamic key = XVar.Clone(_param_key);
			#endregion

			if(XVar.Pack(!(XVar)(this._auxTableData.KeyExists(key))))
			{
				return false;
			}
			return true;
		}
		public virtual XVar isExistsFieldKey(dynamic _param_field, dynamic _param_key)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			dynamic key = XVar.Clone(_param_key);
			#endregion

			if(XVar.Pack(!(XVar)(isExistsTableKey((XVar)(field)))))
			{
				return false;
			}
			if(XVar.Pack(!(XVar)(this._tableData[field].KeyExists(key))))
			{
				return false;
			}
			return true;
		}
		public virtual XVar getDefaultValueByKey(dynamic _param_key)
		{
			#region pass-by-value parameters
			dynamic key = XVar.Clone(_param_key);
			#endregion

			if(XVar.Pack(GlobalVars.g_defaultOptionValues.KeyExists(key)))
			{
				return GlobalVars.g_defaultOptionValues[key];
			}
			return false;
		}
		public virtual XVar getMasterTablesArr(dynamic _param_tName)
		{
			#region pass-by-value parameters
			dynamic tName = XVar.Clone(_param_tName);
			#endregion

			return this._mastersTableData;
		}
		public virtual XVar getMasterKeysByDetailTable(dynamic _param_dTableName, dynamic _param_default = null)
		{
			#region default values
			if(_param_default as Object == null) _param_default = new XVar(XVar.Array());
			#endregion

			#region pass-by-value parameters
			dynamic dTableName = XVar.Clone(_param_dTableName);
			dynamic var_default = XVar.Clone(_param_default);
			#endregion

			if(XVar.Pack(!(XVar)(dTableName)))
			{
				return var_default;
			}
			foreach (KeyValuePair<XVar, dynamic> dTableDataArr in this._detailsTableData.GetEnumerator())
			{
				if(dTableDataArr.Value["dDataSourceTable"] == dTableName)
				{
					return dTableDataArr.Value["masterKeys"];
				}
			}
			return var_default;
		}
		public virtual XVar getDetailTablesArr()
		{
			return this._detailsTableData;
		}
		public virtual XVar getDetailKeysByMasterTable(dynamic _param_mTableName = null, dynamic _param_default = null)
		{
			#region default values
			if(_param_mTableName as Object == null) _param_mTableName = new XVar("");
			if(_param_default as Object == null) _param_default = new XVar(XVar.Array());
			#endregion

			#region pass-by-value parameters
			dynamic mTableName = XVar.Clone(_param_mTableName);
			dynamic var_default = XVar.Clone(_param_default);
			#endregion

			if(XVar.Pack(!(XVar)(mTableName)))
			{
				return var_default;
			}
			foreach (KeyValuePair<XVar, dynamic> mTableDataArr in this._mastersTableData.GetEnumerator())
			{
				if(mTableDataArr.Value["mDataSourceTable"] == mTableName)
				{
					return mTableDataArr.Value["detailKeys"];
				}
			}
			return var_default;
		}
		public virtual XVar getDetailKeysByDetailTable(dynamic _param_dTableName, dynamic _param_default = null)
		{
			#region default values
			if(_param_default as Object == null) _param_default = new XVar(XVar.Array());
			#endregion

			#region pass-by-value parameters
			dynamic dTableName = XVar.Clone(_param_dTableName);
			dynamic var_default = XVar.Clone(_param_default);
			#endregion

			foreach (KeyValuePair<XVar, dynamic> dTableDataArr in this._detailsTableData.GetEnumerator())
			{
				if(dTableDataArr.Value["dDataSourceTable"] == dTableName)
				{
					return dTableDataArr.Value["detailKeys"];
				}
			}
			return var_default;
		}
		public virtual XVar getDPType(dynamic _param_dTableName)
		{
			#region pass-by-value parameters
			dynamic dTableName = XVar.Clone(_param_dTableName);
			#endregion

			if(XVar.Pack(!(XVar)(dTableName)))
			{
				return false;
			}
			foreach (KeyValuePair<XVar, dynamic> dTableDataArr in this._detailsTableData.GetEnumerator())
			{
				if(dTableDataArr.Value["dDataSourceTable"] == dTableName)
				{
					return dTableDataArr.Value["previewOnList"];
				}
			}
			return false;
		}
		public virtual XVar GetFieldByIndex(dynamic _param_index)
		{
			#region pass-by-value parameters
			dynamic index = XVar.Clone(_param_index);
			#endregion

			foreach (KeyValuePair<XVar, dynamic> value in this._tableData.GetEnumerator())
			{
				if(XVar.Pack(!(XVar)(MVCFunctions.is_array((XVar)(value.Value)))))
				{
					continue;
				}
				else
				{
					if(XVar.Pack(!(XVar)(value.Value.KeyExists("Index"))))
					{
						continue;
					}
				}
				if((XVar)(value.Value["Index"] == index)  && (XVar)(getFieldIndex((XVar)(value.Key))))
				{
					return value.Key;
				}
			}
			return null;
		}
		public virtual XVar isSeparate(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			if(XVar.Pack(this._tableData[field].KeyExists("isSeparate")))
			{
				return this._tableData[field]["isSeparate"];
			}
			return false;
		}
		public virtual XVar label(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			dynamic result = null;
			result = XVar.Clone(CommonFunctions.GetFieldLabel((XVar)(MVCFunctions.GoodFieldName((XVar)(this._table))), (XVar)(MVCFunctions.GoodFieldName((XVar)(field)))));
			return (XVar.Pack(result != XVar.Pack("")) ? XVar.Pack(result) : XVar.Pack(field));
		}
		public virtual XVar getFilenameField(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("Filename"));
		}
		public virtual XVar getLinkPrefix(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("LinkPrefix"));
		}
		public virtual XVar getLinkType(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("hlType"));
		}
		public virtual XVar getLinkDisplayField(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("hlTitleField"));
		}
		public virtual XVar openLinkInNewWindow(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("hlNewWindow"));
		}
		public virtual XVar getLinkWordNameType(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("hlLinkWordNameType"));
		}
		public virtual XVar getLinkWordText(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("hlLinkWordText"));
		}
		public virtual XVar getFieldType(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("FieldType"));
		}
		public virtual XVar isAutoincField(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("AutoInc"));
		}
		public virtual XVar getOraSequenceName(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("OraSequenceName"));
		}
		public virtual XVar getDefaultValue(dynamic _param_field, dynamic _param_table = null)
		{
			#region default values
			if(_param_table as Object == null) _param_table = new XVar("");
			#endregion

			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			dynamic table = XVar.Clone(_param_table);
			#endregion

			dynamic editPage = null, tableName = null;
			tableName = XVar.Clone((XVar.Pack(table) ? XVar.Pack(table) : XVar.Pack(this._table)));
			editPage = XVar.Clone(this._editPage);
			if(XVar.Pack(!(XVar)(isSeparate((XVar)(field)))))
			{
				return null;
			}
			return MVCFunctions.GetDefaultValue((XVar)(field), (XVar)(editPage), (XVar)(tableName));
		}
		public virtual XVar isAutoUpdatable(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("autoUpdatable"));
		}
		public virtual XVar getAutoUpdateValue(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			dynamic editPage = null;
			editPage = XVar.Clone(this._editPage);
			if(XVar.Pack(!(XVar)(isSeparate((XVar)(field)))))
			{
				editPage = XVar.Clone(getDefaultEditPageType((XVar)(getTableType())));
			}
			return MVCFunctions.GetAutoUpdateValue((XVar)(field), (XVar)(editPage), (XVar)(this._table));
		}
		public virtual XVar getEditFormat(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("EditFormat"));
		}
		public virtual XVar isReadonly(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			if(getEditFormat((XVar)(field)) == Constants.EDIT_FORMAT_READONLY)
			{
				return true;
			}
			return false;
		}
		public virtual XVar getViewFormat(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("ViewFormat"));
		}
		public virtual XVar dateEditShowTime(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("ShowTime"));
		}
		public virtual XVar lookupControlType(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("LCType"));
		}
		public virtual XVar isDeleteAssociatedFile(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("DeleteAssociatedFile"));
		}
		public virtual XVar useCategory(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("UseCategory"));
		}
		public virtual XVar multiSelect(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("Multiselect"));
		}
		public virtual XVar selectSize(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("SelectSize"));
		}
		public virtual XVar showThumbnail(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("ShowThumbnail"));
		}
		public virtual XVar isImageURL(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("fieldIsImageUrl"));
		}
		public virtual XVar showCustomExpr(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("ShowCustomExpr"));
		}
		public virtual XVar showFileSize(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("ShowFileSize"));
		}
		public virtual XVar showIcon(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("ShowIcon"));
		}
		public virtual XVar getImageWidth(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("ImageWidth"));
		}
		public virtual XVar getImageHeight(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("ImageHeight"));
		}
		public virtual XVar getThumbnailWidth(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("ThumbWidth"));
		}
		public virtual XVar getThumbnailHeight(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("ThumbHeight"));
		}
		public virtual XVar getLookupType(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("LookupType"));
		}
		public virtual XVar getLookupTable(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("LookupTable"));
		}
		public virtual XVar isLookupWhereCode(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("LookupWhereCode"));
		}
		public virtual XVar isLookupWhereSet(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			if(XVar.Pack(isLookupWhereCode((XVar)(field))))
			{
				return true;
			}
			return 0 != MVCFunctions.strlen((XVar)(getFieldData((XVar)(field), new XVar("LookupWhere"))));
		}
		public virtual XVar getLookupWhere(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			if(XVar.Pack(isLookupWhereCode((XVar)(field))))
			{
				dynamic tName = null;
				tName = XVar.Clone(this._table);
				if(getEntityType() == Constants.titDASHBOARD)
				{
					dynamic dashSearchFields = XVar.Array();
					dashSearchFields = XVar.Clone(getDashboardSearchFields());
					if(XVar.Pack(dashSearchFields.KeyExists(field)))
					{
						tName = XVar.Clone(dashSearchFields[field][0]["table"]);
						field = XVar.Clone(dashSearchFields[field][0]["field"]);
					}
				}
				return MVCFunctions.GetLWWhere((XVar)(field), (XVar)(getEffectiveEditPage((XVar)(field))), (XVar)(tName));
			}
			return getFieldData((XVar)(field), new XVar("LookupWhere"));
		}
		public virtual XVar getNotProjectLookupTableConnId(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("LookupConnId"));
		}
		public virtual XVar getLinkField(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("LinkField"));
		}
		public virtual XVar getLWLinkFieldType(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("LinkFieldType"));
		}
		public virtual XVar getDisplayField(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("DisplayField"));
		}
		public virtual XVar getCustomDisplay(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("CustomDisplay"));
		}
		public virtual XVar NeedEncode(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("NeedEncode"));
		}
		public virtual XVar getValidation(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("validateAs"));
		}
		public virtual XVar getFieldItems(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getPageOption(new XVar("fields"), new XVar("fieldItems"), (XVar)(field));
		}
		public virtual XVar getGroupFields()
		{
			return getPageOption(new XVar("dataGrid"), new XVar("groupFields"));
		}
		public virtual XVar appearOnListPage(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return !XVar.Equals(XVar.Pack(MVCFunctions.array_search((XVar)(field), (XVar)(getPageOption(new XVar("fields"), new XVar("gridFields"))))), XVar.Pack(false));
		}
		public virtual XVar appearOnAddPage(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return !XVar.Equals(XVar.Pack(MVCFunctions.array_search((XVar)(field), (XVar)(getPageOption(new XVar("fields"), new XVar("gridFields"))))), XVar.Pack(false));
		}
		public virtual XVar appearOnInlineAdd(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return !XVar.Equals(XVar.Pack(MVCFunctions.array_search((XVar)(field), (XVar)(getInlineAddFields()))), XVar.Pack(false));
		}
		public virtual XVar appearOnEditPage(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return !XVar.Equals(XVar.Pack(MVCFunctions.array_search((XVar)(field), (XVar)(getPageOption(new XVar("fields"), new XVar("gridFields"))))), XVar.Pack(false));
		}
		public virtual XVar appearOnInlineEdit(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return !XVar.Equals(XVar.Pack(MVCFunctions.array_search((XVar)(field), (XVar)(getInlineEditFields()))), XVar.Pack(false));
		}
		public virtual XVar appearOnUpdateSelected(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			dynamic updateOnEditFields = null;
			updateOnEditFields = XVar.Clone(getPageOption(new XVar("fields"), new XVar("updateOnEditFields")));
			if(XVar.Pack(!(XVar)(updateOnEditFields)))
			{
				return false;
			}
			return !XVar.Equals(XVar.Pack(MVCFunctions.array_search((XVar)(field), (XVar)(getPageOption(new XVar("fields"), new XVar("updateOnEditFields"))))), XVar.Pack(false));
		}
		public virtual XVar appearOnPage(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			dynamic gridFields = null;
			gridFields = XVar.Clone(getPageOption(new XVar("fields"), new XVar("gridFields")));
			if(XVar.Pack(!(XVar)(gridFields)))
			{
				return false;
			}
			return !XVar.Equals(XVar.Pack(MVCFunctions.array_search((XVar)(field), (XVar)(gridFields))), XVar.Pack(false));
		}
		public virtual XVar getPageFields()
		{
			return getPageOption(new XVar("fields"), new XVar("gridFields"));
		}
		public virtual XVar appearOnViewPage(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return !XVar.Equals(XVar.Pack(MVCFunctions.array_search((XVar)(field), (XVar)(getPageOption(new XVar("fields"), new XVar("gridFields"))))), XVar.Pack(false));
		}
		public virtual XVar appearOnPrinterPage(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return !XVar.Equals(XVar.Pack(MVCFunctions.array_search((XVar)(field), (XVar)(getPageOption(new XVar("fields"), new XVar("gridFields"))))), XVar.Pack(false));
		}
		public virtual XVar isVideoUrlField(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("fieldIsVideoUrl"));
		}
		public virtual XVar isAbsolute(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("Absolute"));
		}
		public virtual XVar getAudioTitleField(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("audioTitleField"));
		}
		public virtual XVar getVideoWidth(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("videoWidth"));
		}
		public virtual XVar getVideoHeight(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("videoHeight"));
		}
		public virtual XVar isRewindEnabled(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("RewindEnabled"));
		}
		public virtual XVar getParentFieldsData(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("categoryFields"));
		}
		public virtual XVar getLookupParentFNames(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			dynamic fNames = XVar.Array();
			fNames = XVar.Clone(XVar.Array());
			foreach (KeyValuePair<XVar, dynamic> data in getParentFieldsData((XVar)(field)).GetEnumerator())
			{
				fNames.InitAndSetArrayItem(data.Value["main"], null);
			}
			return fNames;
		}
		public virtual XVar isLookupUnique(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("LookupUnique"));
		}
		public virtual XVar getLookupOrderBy(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("LookupOrderBy"));
		}
		public virtual XVar isLookupDesc(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("LookupDesc"));
		}
		public virtual XVar getOwnerTable(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("ownerTable"));
		}
		public virtual XVar isFieldEncrypted(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("bIsEncrypted"));
		}
		public virtual XVar isAllowToAdd(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("AllowToAdd"));
		}
		public virtual XVar isSimpleAdd(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("SimpleAdd"));
		}
		public virtual XVar getAutoCompleteFields(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			dynamic editPageType = null;
			editPageType = XVar.Clone(getEditPageType());
			if((XVar)((XVar)(editPageType == Constants.PAGE_REGISTER)  || (XVar)(editPageType == Constants.PAGE_ADD))  || (XVar)((XVar)(editPageType == Constants.PAGE_EDIT)  && (XVar)((XVar)(isSeparate((XVar)(field)))  || (XVar)(isAutoCompleteFieldsOnEdit((XVar)(field))))))
			{
				return getFieldData((XVar)(field), new XVar("autoCompleteFields"));
			}
			return getDefaultValueByKey(new XVar("autoCompleteFields"));
		}
		public virtual XVar isAutoCompleteFieldsOnEdit(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("autoCompleteFieldsOnEdit"));
		}
		public virtual XVar isFreeInput(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("freeInput"));
		}
		public virtual XVar getMapData(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("mapData"));
		}
		public virtual XVar getFormatTimeAttrs(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("FormatTimeAttrs"));
		}
		public virtual XVar appearOnExportPage(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return appearOnPage((XVar)(field));
		}
		public virtual XVar getStrOriginalTableName()
		{
			return getTableData(new XVar(".strOriginalTableName"));
		}
		public virtual XVar getSearchableFields()
		{
			if(getEntityType() == Constants.titDASHBOARD)
			{
				return getTableData(new XVar(".allSearchFields"));
			}
			return getTableData(new XVar(".searchableFields"));
		}
		public virtual XVar getAllSearchFields()
		{
			return (XVar.Pack(getEntityType() == Constants.titDASHBOARD) ? XVar.Pack(getTableData(new XVar(".allSearchFields"))) : XVar.Pack(getPageOption(new XVar("fields"), new XVar("searchPanelFields"))));
		}
		public virtual XVar getAdvSearchFields()
		{
			return (XVar.Pack(getEntityType() == Constants.titDASHBOARD) ? XVar.Pack(getAllSearchFields()) : XVar.Pack(getPageOption(new XVar("fields"), new XVar("gridFields"))));
		}
		public virtual XVar isUseTimeForSearch()
		{
			return getTableData(new XVar(".isUseTimeForSearch"));
		}
		public virtual XVar isUseToolTips()
		{
			return getTableData(new XVar(".isUseToolTips"));
		}
		public virtual XVar isUseVideo()
		{
			return getTableData(new XVar(".isUseVideo"));
		}
		public virtual XVar isUseAudio()
		{
			return getTableData(new XVar(".isUseAudio"));
		}
		public virtual XVar isUseAudioOnDetails()
		{
			dynamic i = null;
			i = new XVar(0);
			for(;i < MVCFunctions.count(this._detailsTableData); i++)
			{
				if(XVar.Pack(this._detailsTableData[i]["isUseAudio"]))
				{
					return true;
				}
			}
			return false;
		}
		public virtual XVar getTableType()
		{
			return getTableData(new XVar(".tableType"));
		}
		public virtual XVar getShortTableName()
		{
			return CommonFunctions.GetTableURL((XVar)(this._table));
		}
		public virtual XVar isShowAddInPopup()
		{
			return getPageOption(new XVar("list"), new XVar("addInPopup"));
		}
		public virtual XVar isShowEditInPopup()
		{
			return getPageOption(new XVar("list"), new XVar("editInPopup"));
		}
		public virtual XVar isShowViewInPopup()
		{
			return getPageOption(new XVar("list"), new XVar("viewInPopup"));
		}
		public virtual XVar getPopupPagesLayoutNames()
		{
			return getTableData(new XVar(".popupPagesLayoutNames"));
		}
		public virtual XVar isResizeColumns()
		{
			return getTableData(new XVar(".isResizeColumns"));
		}
		public virtual XVar isUseAjaxSuggest()
		{
			return getTableData(new XVar(".isUseAjaxSuggest"));
		}
		public virtual XVar getPanelSearchFields()
		{
			return getPageOption(new XVar("listSearch"), new XVar("alwaysOnPanelFields"));
		}
		public virtual XVar getSearchPanelOptions()
		{
			return getTableData(new XVar(".searchPanelOptions"));
		}
		public virtual XVar getGoogleLikeFields()
		{
			return getTableData(new XVar(".googleLikeFields"));
		}
		public virtual XVar getInlineEditFields()
		{
			return getPageOption(new XVar("fields"), new XVar("inlineEditFields"));
		}
		public virtual XVar getUpdateSelectedFields()
		{
			return getPageOption(new XVar("fields"), new XVar("updateOnEditFields"));
		}
		public virtual XVar getExportFields()
		{
			return getPageOption(new XVar("fields"), new XVar("exportFields"));
		}
		public virtual XVar getImportFields()
		{
			return getPageOption(new XVar("fields"), new XVar("gridFields"));
		}
		public virtual XVar getEditFields()
		{
			return getPageOption(new XVar("fields"), new XVar("gridFields"));
		}
		public virtual XVar getInlineAddFields()
		{
			return getPageOption(new XVar("fields"), new XVar("inlineAddFields"));
		}
		public virtual XVar getAddFields()
		{
			return getPageOption(new XVar("fields"), new XVar("gridFields"));
		}
		public virtual XVar getMasterListFields()
		{
			return getTableData(new XVar(".masterListFields"));
		}
		public virtual XVar getViewFields()
		{
			return getPageOption(new XVar("fields"), new XVar("gridFields"));
		}
		public virtual XVar getPrinterFields()
		{
			return getPageOption(new XVar("fields"), new XVar("gridFields"));
		}
		public virtual XVar getListFields()
		{
			return getPageOption(new XVar("fields"), new XVar("gridFields"));
		}
		public virtual XVar isAddPageEvents()
		{
			return getTableData(new XVar(".addPageEvents"));
		}
		public virtual XVar hasAjaxSnippet()
		{
			return getTableData(new XVar(".ajaxCodeSnippetAdded"));
		}
		public virtual XVar hasButtonsAdded()
		{
			return getTableData(new XVar(".buttonsAdded"));
		}
		public virtual XVar isUseFieldsMaps()
		{
			return getTableData(new XVar(".isUseFieldsMaps"));
		}
		public virtual XVar getOrderIndexes()
		{
			return getTableData(new XVar(".orderindexes"));
		}
		public virtual XVar getStrOrderBy()
		{
			return getTableData(new XVar(".strOrderBy"));
		}
		public virtual SQLQuery getSQLQuery()
		{
			dynamic query = null;
			query = XVar.Clone(getTableData(new XVar(".sqlquery")));
			if(query != null)
			{
				return query;
			}
			return null;
		}
		public virtual XVar getSQLQueryByField(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			dynamic query = null;
			if(getTableType() == Constants.PAGE_DASHBOARD)
			{
				query = XVar.Clone(getDashTableData((XVar)(field), new XVar(".sqlquery")));
				if(query != null)
				{
					return query;
				}
				return null;
			}
			else
			{
				query = XVar.Clone(getTableData(new XVar(".sqlquery")));
				if(query != null)
				{
					return query;
				}
				return null;
			}
			return null;
		}
		public virtual XVar getCreateThumbnail(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("CreateThumbnail"));
		}
		public virtual XVar getStrThumbnail(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("StrThumbnail"));
		}
		public virtual XVar getThumbnailSize(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("ThumbnailSize"));
		}
		public virtual XVar getResizeOnUpload(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("ResizeImage"));
		}
		public virtual XVar isBasicUploadUsed(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("CompatibilityMode"));
		}
		public virtual XVar isAutoUpload(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("autoUpload"));
		}
		public virtual XVar getNewImageSize(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("NewSize"));
		}
		public virtual XVar getAcceptFileTypes(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("acceptFileTypes"));
		}
		public virtual XVar getMaxFileSize(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("maxFileSize"));
		}
		public virtual XVar getMaxTotalFilesSize(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("maxTotalFilesSize"));
		}
		public virtual XVar getMaxNumberOfFiles(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("maxNumberOfFiles"));
		}
		public virtual XVar getMaxImageWidth(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("maxImageWidth"));
		}
		public virtual XVar getMaxImageHeight(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("maxImageHeight"));
		}
		public virtual XVar getStrFilename(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("strFilename"));
		}
		public virtual XVar getNRows(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("nRows"));
		}
		public virtual XVar getNCols(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("nCols"));
		}
		public virtual XVar getOriginalTableName()
		{
			dynamic result = null;
			result = XVar.Clone(getTableData(new XVar(".OriginalTable")));
			return (XVar.Pack(result != XVar.Pack("")) ? XVar.Pack(result) : XVar.Pack(this._table));
		}
		public virtual XVar getTableKeys()
		{
			return getTableData(new XVar(".Keys"));
		}
		public virtual XVar isLargeTextTruncationSet()
		{
			return getTableData(new XVar(".truncateText"));
		}
		public virtual XVar getNumberOfChars()
		{
			return getTableData(new XVar(".NumberOfChars"));
		}
		public virtual XVar isSQLExpression(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("isSQLExpression"));
		}
		public virtual XVar getFullFieldName(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("FullName"));
		}
		public virtual XVar setFullFieldName(dynamic _param_field, dynamic _param_value)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			dynamic value = XVar.Clone(_param_value);
			#endregion

			return setFieldData((XVar)(field), new XVar("FullName"), (XVar)(value));
		}
		public virtual XVar getTableOwnerID()
		{
			return getTableData(new XVar(".OwnerID"));
		}
		public virtual XVar isRequired(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("IsRequired"));
		}
		public virtual XVar isUseRTE(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("UseRTE"));
		}
		public virtual XVar isUseRTEBasic(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return (XVar)(isUseRTE((XVar)(field)))  && (XVar)(GlobalVars.isUseRTEBasic);
		}
		public virtual XVar isUseRTEFCK(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return (XVar)(isUseRTE((XVar)(field)))  && (XVar)(GlobalVars.isUseRTECK);
		}
		public virtual XVar isUseRTEInnova(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return (XVar)(isUseRTE((XVar)(field)))  && (XVar)(GlobalVars.isUseRTEInnova);
		}
		public virtual XVar isUseTimestamp(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("UseTimestamp"));
		}
		public virtual XVar getFieldIndex(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("Index"));
		}
		public virtual XVar getEntityType()
		{
			return getTableData(new XVar(".entityType"));
		}
		public virtual XVar getDateEditType(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("DateEditType"));
		}
		public virtual XVar getHTML5InputType(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("HTML5InuptType"));
		}
		public virtual XVar getEditParams(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("EditParams"));
		}
		public virtual XVar getControlWidth(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("controlWidth"));
		}
		public virtual XVar checkFieldPermissions(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return appearOnPage((XVar)(field));
		}
		public virtual XVar getTableOwnerIdField()
		{
			return getTableData(new XVar(".mainTableOwnerID"));
		}
		public virtual XVar isHorizontalLookup(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("HorizontalLookup"));
		}
		public virtual XVar isDecimalDigits(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("DecimalDigits"));
		}
		public virtual XVar getLookupValues(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("LookupValues"));
		}
		public virtual XVar hasEditPage()
		{
			return !(XVar)(!(XVar)(getDefaultPage(new XVar("edit"))));
		}
		public virtual XVar hasAddPage()
		{
			return !(XVar)(!(XVar)(getDefaultPage(new XVar("add"))));
		}
		public virtual XVar hasListPage()
		{
			return !(XVar)(!(XVar)(getDefaultPage(new XVar("list"))));
		}
		public virtual XVar hasImportPage()
		{
			return !(XVar)(!(XVar)(getDefaultPage(new XVar("import"))));
		}
		public virtual XVar hasInlineEdit()
		{
			return getPageOption(new XVar("list"), new XVar("inlineEdit"));
		}
		public virtual XVar hasUpdateSelected()
		{
			return getPageOption(new XVar("list"), new XVar("updateSelected"));
		}
		public virtual XVar updateSelectedButtons()
		{
			dynamic data = XVar.Array();
			data = XVar.Clone(labeledButtons());
			return data["update_records"];
		}
		public virtual XVar activatonMessages()
		{
			dynamic data = XVar.Array();
			data = XVar.Clone(labeledButtons());
			if(XVar.Pack(!(XVar)(MVCFunctions.is_array((XVar)(data["register_activate_message"])))))
			{
				return XVar.Array();
			}
			return data["register_activate_message"];
		}
		public virtual XVar labeledButtons()
		{
			return getPageOption(new XVar("page"), new XVar("labeledButtons"));
		}
		public virtual XVar printPagesLabelsData()
		{
			dynamic data = XVar.Array();
			data = XVar.Clone(labeledButtons());
			return data["print_pages"];
		}
		public virtual XVar hasSortByDropdown()
		{
			return getPageOption(new XVar("list"), new XVar("sortDropdown"));
		}
		public virtual XVar getSortControlSettingsJSONString()
		{
			return getTableData(new XVar(".strSortControlSettingsJSON"));
		}
		public virtual XVar getClickActionJSONString()
		{
			return getTableData(new XVar(".strClickActionJSON"));
		}
		public virtual XVar hasCopyPage()
		{
			return true;
		}
		public virtual XVar hasViewPage()
		{
			return !(XVar)(!(XVar)(getDefaultPage(new XVar("view"))));
		}
		public virtual XVar hasExportPage()
		{
			return !(XVar)(!(XVar)(getDefaultPage(new XVar("export"))));
		}
		public virtual XVar hasPrintPage()
		{
			return (XVar)(!(XVar)(!(XVar)(getDefaultPage(new XVar("print")))))  || (XVar)(!(XVar)(!(XVar)(getDefaultPage(new XVar("rprint")))));
		}
		public virtual XVar hasDelete()
		{
			return getPageOption(new XVar("list"), new XVar("delete"));
		}
		public virtual XVar getTotalsFields()
		{
			dynamic ret = XVar.Array();
			ret = XVar.Clone(XVar.Array());
			foreach (KeyValuePair<XVar, dynamic> totals in getPageOption(new XVar("totals")).GetEnumerator())
			{
				if((XVar)(totals.Value)  && (XVar)(totals.Value["totalsType"]))
				{
					ret.InitAndSetArrayItem(new XVar("fName", totals.Key, "numRows", 0, "totalsType", totals.Value["totalsType"], "viewFormat", getViewFormat((XVar)(totals.Key))), null);
				}
			}
			return ret;
		}
		public virtual XVar getExportTxtFormattingType()
		{
			return getPageOption(new XVar("export"), new XVar("format"));
		}
		public virtual XVar getExportDelimiter()
		{
			return getPageOption(new XVar("export"), new XVar("delimiter"));
		}
		public virtual XVar chekcExportDelimiterSelection()
		{
			return getPageOption(new XVar("export"), new XVar("selectDelimiter"));
		}
		public virtual XVar checkExportFieldsSelection()
		{
			return getPageOption(new XVar("export"), new XVar("selectFields"));
		}
		public virtual XVar getLoginFormType()
		{
			return getPageOption(new XVar("loginForm"), new XVar("loginForm"));
		}
		public virtual XVar getAdvancedSecurityType()
		{
			if((XVar)(!(XVar)(CommonFunctions.GetGlobalData(new XVar("createLoginPage"), new XVar(null))))  || (XVar)((XVar)(CommonFunctions.GetGlobalData(new XVar("nLoginMethod"), new XVar(null)) != Constants.SECURITY_TABLE)  && (XVar)(CommonFunctions.GetGlobalData(new XVar("nLoginMethod"), new XVar(null)) != Constants.SECURITY_AD)))
			{
				return Constants.ADVSECURITY_ALL;
			}
			return getTableData(new XVar(".nSecOptions"));
		}
		public virtual XVar displayLoading()
		{
			return getTableData(new XVar(".isDisplayLoading"));
		}
		public virtual XVar getRecordsPerPageArray()
		{
			return getTableData(new XVar(".arrRecsPerPage"));
		}
		public virtual XVar getGroupsPerPageArray()
		{
			return getTableData(new XVar(".arrGroupsPerPage"));
		}
		public virtual XVar isReportWithGroups()
		{
			return getTableData(new XVar(".reportGroupFields"));
		}
		public virtual XVar isCrossTabReport()
		{
			return getTableData(new XVar(".crossTabReport"));
		}
		public virtual XVar getReportGroupFieldsData()
		{
			return getTableData(new XVar(".reportGroupFieldsData"));
		}
		public virtual XVar reportHasHorizontalSummary()
		{
			return getTableData(new XVar(".reportHorizontalSummary"));
		}
		public virtual XVar reportHasVerticalSummary()
		{
			return getTableData(new XVar(".reportVerticalSummary"));
		}
		public virtual XVar reportHasPageSummary()
		{
			return getTableData(new XVar(".reportPageSummary"));
		}
		public virtual XVar reportHasGlobalSummary()
		{
			return getTableData(new XVar(".reportGlobalSummary"));
		}
		public virtual XVar getReportLayout()
		{
			return getTableData(new XVar(".reportLayout"));
		}
		public virtual XVar isGroupSummaryCountShown()
		{
			return getTableData(new XVar(".showGroupSummaryCount"));
		}
		public virtual XVar reportDetailsShown()
		{
			return getTableData(new XVar(".repShowDet"));
		}
		public virtual XVar reportTotalFieldsExist()
		{
			return getTableData(new XVar(".isExistTotalFields"));
		}
		public virtual XVar noRecordsOnFirstPage()
		{
			return getTableData(new XVar(".noRecordsFirstPage"));
		}
		public virtual XVar isViewPagePDF()
		{
			return getTableData(new XVar(".isViewPagePDF"));
		}
		public virtual XVar isLandscapeViewPDFOrientation()
		{
			return getTableData(new XVar(".isLandscapeViewPDFOrientation"));
		}
		public virtual XVar isViewPagePDFFitToPage()
		{
			return getTableData(new XVar(".isViewPagePDFFitToPage"));
		}
		public virtual XVar getViewPagePDFScale()
		{
			return getTableData(new XVar(".nViewPagePDFScale"));
		}
		public virtual XVar isLandscapePrinterPagePDFOrientation()
		{
			return getTableData(new XVar(".isLandscapePrinterPagePDFOrientation"));
		}
		public virtual XVar isPrinterPagePDFFitToPage()
		{
			return getTableData(new XVar(".isPrinterPagePDFFitToPage"));
		}
		public virtual XVar getPrinterPagePDFScale()
		{
			return getTableData(new XVar(".nPrinterPagePDFScale"));
		}
		public virtual XVar isPrinterPageFitToPage()
		{
			return getTableData(new XVar(".isPrinterPageFitToPage"));
		}
		public virtual XVar getPrinterPageScale()
		{
			return getTableData(new XVar(".nPrinterPageScale"));
		}
		public virtual XVar getPrinterSplitRecords()
		{
			return getTableData(new XVar(".nPrinterSplitRecords"));
		}
		public virtual XVar getPrinterPDFSplitRecords()
		{
			return getTableData(new XVar(".nPrinterPDFSplitRecords"));
		}
		public virtual XVar isPrinterPagePDF()
		{
			return getPageOption(new XVar("pdf"), new XVar("pdfView"));
		}
		public virtual XVar hasCaptcha()
		{
			return getPageOption(new XVar("captcha"), new XVar("captcha"));
		}
		public virtual XVar hasBreadcrumb()
		{
			return getPageOption(new XVar("misc"), new XVar("breadcrumb"));
		}
		public virtual XVar isSearchRequiredForFiltering()
		{
			return getTableData(new XVar(".searchIsRequiredForFilters"));
		}
		public virtual XVar warnLeavingPages()
		{
			return getTableData(new XVar(".warnLeavingPages"));
		}
		public virtual XVar hideEmptyViewFields()
		{
			return getTableData(new XVar(".hideEmptyFieldsOnView"));
		}
		public virtual XVar getInitialPageSize()
		{
			return getTableData(new XVar(".pageSize"));
		}
		public virtual XVar getRecordsPerRowList()
		{
			return getPageOption(new XVar("page"), new XVar("recsPerRow"));
		}
		public virtual XVar getRecordsPerRowPrint()
		{
			return getPageOption(new XVar("page"), new XVar("recsPerRow"));
		}
		public virtual XVar getRecordsLimit()
		{
			return getTableData(new XVar(".recsLimit"));
		}
		public virtual XVar useMoveNext()
		{
			return getPageOption(new XVar("misc"), new XVar("nextPrev"));
		}
		public virtual XVar highlightRows()
		{
			return getTableData(new XVar(".rowHighlite"));
		}
		public virtual XVar hasInlineAdd()
		{
			return getPageOption(new XVar("list"), new XVar("inlineAdd"));
		}
		public virtual XVar getListGridLayout()
		{
			return getPageOption(new XVar("page"), new XVar("gridType"));
		}
		public virtual XVar getPrintGridLayout()
		{
			return getPageOption(new XVar("page"), new XVar("gridType"));
		}
		public virtual XVar getReportPrintLayout()
		{
			return getTableData(new XVar(".printReportLayout"));
		}
		public virtual XVar getPrinterPageOrientation()
		{
			return getTableData(new XVar(".printerPageOrientation"));
		}
		public virtual XVar getReportPrintPartitionType()
		{
			return getTableData(new XVar(".reportPrintPartitionType"));
		}
		public virtual XVar getReportPrintGroupsPerPage()
		{
			return getTableData(new XVar(".reportPrintGroupsPerPage"));
		}
		public virtual XVar getReportPrintPDFGroupsPerPage()
		{
			return getTableData(new XVar(".reportPrintPDFGroupsPerPage"));
		}
		public virtual XVar getLowGroup()
		{
			return getTableData(new XVar(".lowGroup"));
		}
		public virtual XVar ajaxBasedListPage()
		{
			return getTableData(new XVar(".listAjax"));
		}
		public virtual XVar isMultistepped()
		{
			return getPageOption(new XVar("page"), new XVar("multiStep"));
		}
		public virtual XVar getGridTabs()
		{
			return getTableData(new XVar(".arrGridTabs"));
		}
		public virtual XVar highlightSearchResults()
		{
			return getTableData(new XVar(".highlightSearchResults"));
		}
		public virtual XVar getFieldsList()
		{
			dynamic arr = XVar.Array(), t = XVar.Array();
			if(XVar.Pack(this._tableData == null))
			{
				return XVar.Array();
			}
			t = XVar.Clone(MVCFunctions.array_keys((XVar)(this._tableData)));
			arr = XVar.Clone(XVar.Array());
			foreach (KeyValuePair<XVar, dynamic> f in t.GetEnumerator())
			{
				if(MVCFunctions.substr((XVar)(f.Value), new XVar(0), new XVar(1)) != ".")
				{
					arr.InitAndSetArrayItem(f.Value, null);
				}
			}
			return arr;
		}
		public virtual XVar getBinaryFieldsIndices()
		{
			dynamic fields = XVar.Array(), var_out = XVar.Array();
			fields = XVar.Clone(getFieldsList());
			var_out = XVar.Clone(XVar.Array());
			foreach (KeyValuePair<XVar, dynamic> f in fields.GetEnumerator())
			{
				if(XVar.Pack(CommonFunctions.IsBinaryType((XVar)(getFieldType((XVar)(f.Value))))))
				{
					var_out.InitAndSetArrayItem(f.Key + 1, null);
				}
			}
			return var_out;
		}
		public virtual XVar getNBFieldsList()
		{
			dynamic arr = XVar.Array(), t = XVar.Array();
			t = XVar.Clone(getFieldsList());
			arr = XVar.Clone(XVar.Array());
			foreach (KeyValuePair<XVar, dynamic> f in t.GetEnumerator())
			{
				if(XVar.Pack(!(XVar)(CommonFunctions.IsBinaryType((XVar)(getFieldType((XVar)(f.Value)))))))
				{
					arr.InitAndSetArrayItem(f.Value, null);
				}
			}
			return arr;
		}
		public virtual XVar getFieldByGoodFieldName(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			foreach (KeyValuePair<XVar, dynamic> value in this._tableData.GetEnumerator())
			{
				if(1 < MVCFunctions.count(value.Value))
				{
					if(value.Value["GoodName"] == field)
					{
						return value.Key;
					}
				}
			}
			return "";
		}
		public virtual XVar getUploadFolder(dynamic _param_field, dynamic _param_fileData = null)
		{
			#region default values
			if(_param_fileData as Object == null) _param_fileData = new XVar(XVar.Array());
			#endregion

			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			dynamic fileData = XVar.Clone(_param_fileData);
			#endregion

			dynamic path = null;
			if(XVar.Pack(isUploadCodeExpression((XVar)(field))))
			{
				path = XVar.Clone(MVCFunctions.GetUploadFolderExpression((XVar)(field), (XVar)(fileData)));
			}
			else
			{
				path = XVar.Clone(getFieldData((XVar)(field), new XVar("UploadFolder")));
			}
			if((XVar)(MVCFunctions.strlen((XVar)(path)))  && (XVar)(MVCFunctions.substr((XVar)(path), (XVar)(MVCFunctions.strlen((XVar)(path)) - 1)) != "/"))
			{
				path = MVCFunctions.Concat(path, "/");
			}
			return path;
		}
		public virtual XVar isMakeDirectoryNeeded(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return (XVar)(isUploadCodeExpression((XVar)(field)))  || (XVar)(!(XVar)(isAbsolute((XVar)(field))));
		}
		public virtual XVar getFinalUploadFolder(dynamic _param_field, dynamic _param_fileData = null)
		{
			#region default values
			if(_param_fileData as Object == null) _param_fileData = new XVar(XVar.Array());
			#endregion

			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			dynamic fileData = XVar.Clone(_param_fileData);
			#endregion

			dynamic path = null;
			if(XVar.Pack(isAbsolute((XVar)(field))))
			{
				path = XVar.Clone(getUploadFolder((XVar)(field), (XVar)(fileData)));
			}
			else
			{
				path = XVar.Clone(MVCFunctions.getabspath((XVar)(getUploadFolder((XVar)(field), (XVar)(fileData)))));
			}
			if((XVar)(MVCFunctions.strlen((XVar)(path)))  && (XVar)(MVCFunctions.substr((XVar)(path), (XVar)(MVCFunctions.strlen((XVar)(path)) - 1)) != "\\"))
			{
				path = MVCFunctions.Concat(path, "\\");
			}
			return path;
		}
		public virtual XVar isUploadCodeExpression(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("UploadCodeExpression"));
		}
		public virtual XVar getQueryObject()
		{
			dynamic queryObj = null;
			queryObj = XVar.Clone(getSQLQuery());
			return queryObj;
		}
		public virtual XVar getListOfFieldsByExprType(dynamic _param_needaggregate)
		{
			#region pass-by-value parameters
			dynamic needaggregate = XVar.Clone(_param_needaggregate);
			#endregion

			dynamic fields = XVar.Array(), query = null, var_out = XVar.Array();
			query = getSQLQuery();
			fields = XVar.Clone(getFieldsList());
			var_out = XVar.Clone(XVar.Array());
			foreach (KeyValuePair<XVar, dynamic> f in fields.GetEnumerator())
			{
				dynamic aggr = null;
				aggr = XVar.Clone(query.IsAggrFuncField((XVar)(f.Key)));
				if((XVar)((XVar)(needaggregate)  && (XVar)(aggr))  || (XVar)((XVar)(!(XVar)(needaggregate))  && (XVar)(!(XVar)(aggr))))
				{
					var_out.InitAndSetArrayItem(f.Value, null);
				}
			}
			return var_out;
		}
		public virtual XVar isAggregateField(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			dynamic idx = null, query = null;
			query = getSQLQuery();
			idx = XVar.Clone(getFieldIndex((XVar)(field)) - 1);
			return query.IsAggrFuncField((XVar)(idx));
		}
		public virtual XVar getNCSearch()
		{
			return getTableData(new XVar(".NCSearch"));
		}
		public virtual XVar getChartType()
		{
			return getTableData(new XVar(".chartType"));
		}
		public virtual XVar getChartRefreshTime()
		{
			return getTableData(new XVar(".ChartRefreshTime"));
		}
		public virtual XVar getChartXml()
		{
			return getTableData(new XVar(".chartXml"));
		}
		public virtual XVar auditEnabled()
		{
			return getTableData(new XVar(".audit"));
		}
		public virtual XVar isSearchSavingEnabled()
		{
			return getPageOption(new XVar("listSearch"), new XVar("searchSaving"));
		}
		public virtual XVar isAllowShowHideFields()
		{
			if(XVar.Pack(getScrollGridBody()))
			{
				return false;
			}
			return getPageOption(new XVar("list"), new XVar("showHideFields"));
		}
		public virtual XVar isAllowFieldsReordering()
		{
			if((XVar)(getScrollGridBody())  || (XVar)(1 < getRecordsPerRowList()))
			{
				return false;
			}
			return getPageOption(new XVar("list"), new XVar("reorderFields"));
		}
		public virtual XVar lockingEnabled()
		{
			return getTableData(new XVar(".locking"));
		}
		public virtual XVar hasEncryptedFields()
		{
			return getTableData(new XVar(".hasEncryptedFields"));
		}
		public virtual XVar showSearchPanel()
		{
			return getPageOption(new XVar("listSearch"), new XVar("searchPanel"));
		}
		public virtual XVar isFlexibleSearch()
		{
			return !(XVar)(getPageOption(new XVar("listSearch"), new XVar("fixedSearchPanel")));
		}
		public virtual XVar getSearchRequiredFields()
		{
			return getPageOption(new XVar("fields"), new XVar("searchRequiredFields"));
		}
		public virtual XVar showSimpleSearchOptions()
		{
			return getPageOption(new XVar("listSearch"), new XVar("simpleSearchOptions"));
		}
		public virtual XVar getFilterFields()
		{
			return getPageOption(new XVar("fields"), new XVar("filterFields"));
		}
		public virtual XVar getFilterFieldFormat(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("filterFormat"));
		}
		public virtual XVar getFilterFieldTotal(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("filterTotals"));
		}
		public virtual XVar showWithNoRecords(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("showWithNoRecords"));
		}
		public virtual XVar getFilterSortValueType(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("sortValueType"));
		}
		public virtual XVar isFilterSortOrderDescending(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("descendingOrder"));
		}
		public virtual XVar getNumberOfVisibleFilterItems(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("numberOfVisibleItems"));
		}
		public virtual XVar getParentFilterName(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("parentFilterField"));
		}
		public virtual XVar getParentFiltersNames(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("parentFilters"));
		}
		public virtual XVar hasDependentFilter(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getDependentFilterName((XVar)(field)) != "";
		}
		public virtual XVar getDependentFilterName(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("dependentFilterName"));
		}
		public virtual XVar getDependentFiltersNames(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("dependentFilters"));
		}
		public virtual XVar getFilterIntervals(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("filterIntervals"));
		}
		public virtual XVar showCollapsed(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("showCollapsed"));
		}
		public virtual XVar getFilterIntervalDatabyIndex(dynamic _param_field, dynamic _param_idx)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			dynamic idx = XVar.Clone(_param_idx);
			#endregion

			dynamic filterIntervalsData = XVar.Array(), intervalData = null;
			intervalData = XVar.Clone(XVar.Array());
			filterIntervalsData = XVar.Clone(getFilterIntervals((XVar)(field)));
			foreach (KeyValuePair<XVar, dynamic> interval in filterIntervalsData.GetEnumerator())
			{
				if(interval.Value["index"] == idx)
				{
					intervalData = XVar.Clone(interval.Value);
					break;
				}
			}
			return intervalData;
		}
		public virtual XVar getFilterTotalsField(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("filterTotalFields"));
		}
		public virtual XVar getFilterFiledMultiSelect(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("filterMultiSelect"));
		}
		public virtual XVar getFilterCheckedMessage(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("filterCheckedMessageText"));
		}
		public virtual XVar getFilterCheckedMessageType(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("filterCheckedMessageType"));
		}
		public virtual XVar getFilterUncheckedMessage(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("filterUncheckedMessageText"));
		}
		public virtual XVar getFilterUncheckedMessageType(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("filterUncheckedMessageType"));
		}
		public virtual XVar getFilterStepType(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("filterSliderStepType"));
		}
		public virtual XVar getFilterStepValue(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("filterSliderStepValue"));
		}
		public virtual XVar getFilterKnobsType(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("filterKnobsType"));
		}
		public virtual XVar isFilterApplyBtnSet(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("filterApplyBtn"));
		}
		public virtual XVar isCaseInsensitiveUsername()
		{
			return GlobalVars.caseInsensitiveUsername;
		}
		public virtual XVar getCaseSensitiveUsername(dynamic _param_value)
		{
			#region pass-by-value parameters
			dynamic value = XVar.Clone(_param_value);
			#endregion

			if(XVar.Pack(!(XVar)(isCaseInsensitiveUsername())))
			{
				return value;
			}
			return MVCFunctions.strtoupper((XVar)(value));
		}
		public virtual XVar usersTableInProject()
		{
			return CommonFunctions.GetGlobalData(new XVar("usersTableInProject"), new XVar(false));
		}
		public virtual XVar getStrField(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("strField"));
		}
		public virtual XVar getScrollGridBody()
		{
			return getTableData(new XVar(".scrollGridBody"));
		}
		public virtual XVar isUpdateLatLng()
		{
			return getTableData(new XVar(".geocodingEnabled"));
		}
		public virtual XVar getGeocodingData()
		{
			return getTableData(new XVar(".geocodingData"));
		}
		public virtual XVar allowDuplicateValues(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return !(XVar)(getFieldData((XVar)(field), new XVar("denyDuplicates")));
		}
		public virtual XVar getDashFieldData(dynamic _param_field, dynamic _param_key)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			dynamic key = XVar.Clone(_param_key);
			#endregion

			dynamic dashSearchFields = XVar.Array(), dfield = XVar.Array(), table = null;
			dashSearchFields = XVar.Clone(getDashboardSearchFields());
			dfield = XVar.Clone(dashSearchFields[field]);
			if(XVar.Pack(dfield))
			{
				table = XVar.Clone(dfield[0]["table"]);
			}
			if((XVar)(!(XVar)(dfield))  || (XVar)(!(XVar)(table)))
			{
				return getDefaultValueByKey((XVar)(key));
			}
			if(XVar.Pack(!(XVar)(this._dashboardElemPSet[table])))
			{
				this._dashboardElemPSet.InitAndSetArrayItem(new ProjectSettings((XVar)(table), (XVar)(this._editPage)), table);
			}
			return this._dashboardElemPSet[table].getFieldData((XVar)(dfield[0]["field"]), (XVar)(key));
		}
		public virtual XVar getDashTableData(dynamic _param_field, dynamic _param_key)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			dynamic key = XVar.Clone(_param_key);
			#endregion

			dynamic dashSearchFields = XVar.Array(), tableSettings = null;
			dashSearchFields = XVar.Clone(getDashboardSearchFields());
			tableSettings = XVar.Clone(new ProjectSettings((XVar)(dashSearchFields[field][0]["table"]), (XVar)(this._editPage)));
			return tableSettings.getTableData((XVar)(key));
		}
		public virtual XVar getSearchOptionsList(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("searchOptionsList"));
		}
		public virtual XVar getDefaultSearchOption(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			dynamic defaultOpt = null;
			defaultOpt = XVar.Clone(getFieldData((XVar)(field), new XVar("defaultSearchOption")));
			if(XVar.Pack(!(XVar)(defaultOpt)))
			{
				dynamic searchOptionsList = XVar.Array();
				searchOptionsList = XVar.Clone(getSearchOptionsList((XVar)(field)));
				if(XVar.Pack(MVCFunctions.count(searchOptionsList)))
				{
					defaultOpt = XVar.Clone(searchOptionsList[0]);
				}
			}
			return defaultOpt;
		}
		public virtual XVar showListOfThumbnails(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			return getFieldData((XVar)(field), new XVar("ShowListOfThumbnails"));
		}
		public static XVar isMenuTreelike(dynamic _param_menuName)
		{
			#region pass-by-value parameters
			dynamic menuName = XVar.Clone(_param_menuName);
			#endregion

			return GlobalVars.menuTreelikeFlags[menuName];
		}
		public static XVar isMenuDrillDown(dynamic _param_menuName)
		{
			#region pass-by-value parameters
			dynamic menuName = XVar.Clone(_param_menuName);
			#endregion

			return GlobalVars.menuDrillDownFlags[menuName];
		}
		public virtual XVar setPageMode(dynamic _param_pageMode)
		{
			#region pass-by-value parameters
			dynamic pageMode = XVar.Clone(_param_pageMode);
			#endregion

			this._pageMode = XVar.Clone(pageMode);
			return null;
		}
		public virtual XVar editPageHasDenyDuplicatesFields()
		{
			foreach (KeyValuePair<XVar, dynamic> fieldName in getEditFields().GetEnumerator())
			{
				if(XVar.Pack(!(XVar)(allowDuplicateValues((XVar)(fieldName.Value)))))
				{
					return true;
				}
			}
			return false;
		}
		public virtual XVar getRTEType(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			if(XVar.Pack(isUseRTEBasic((XVar)(field))))
			{
				return "RTE";
			}
			if(XVar.Pack(isUseRTEFCK((XVar)(field))))
			{
				return "RTECK";
			}
			if(XVar.Pack(isUseRTEInnova((XVar)(field))))
			{
				return "RTEINNOVA";
			}
			return "";
		}
		public virtual XVar getHiddenFields(dynamic _param_device)
		{
			#region pass-by-value parameters
			dynamic device = XVar.Clone(_param_device);
			#endregion

			dynamic list = XVar.Array();
			list = XVar.Clone(getTableData(new XVar(".hideMobileList")));
			if(XVar.Pack(list.KeyExists(device)))
			{
				return list[device];
			}
			return XVar.Array();
		}
		public virtual XVar getHiddenGoodNameFields(dynamic _param_device)
		{
			#region pass-by-value parameters
			dynamic device = XVar.Clone(_param_device);
			#endregion

			dynamic hFields = XVar.Array(), hGoodFields = XVar.Array();
			hGoodFields = XVar.Clone(XVar.Array());
			hFields = XVar.Clone(getHiddenFields((XVar)(device)));
			foreach (KeyValuePair<XVar, dynamic> isShow in hFields.GetEnumerator())
			{
				hGoodFields.InitAndSetArrayItem(isShow.Value, MVCFunctions.GoodFieldName((XVar)(isShow.Key)));
			}
			return hGoodFields;
		}
		public virtual XVar columnsByDeviceEnabled()
		{
			dynamic list = XVar.Array();
			list = XVar.Clone(getTableData(new XVar(".hideMobileList")));
			foreach (KeyValuePair<XVar, dynamic> v in list.GetEnumerator())
			{
				if(XVar.Pack(v.Value))
				{
					return true;
				}
			}
			return false;
		}
		public static XVar getDeviceMediaClause(dynamic _param_device)
		{
			#region pass-by-value parameters
			dynamic device = XVar.Clone(_param_device);
			#endregion

			if(device == Constants.DESKTOP)
			{
				return "@media (min-device-width: 1281px)";
			}
			else
			{
				if(device == Constants.TABLET_10_IN)
				{
					return MVCFunctions.Concat("@media (device-width: 768px) and (device-height: 1024px)", " , (min-device-width: 1025px) and (max-device-width: 1280px) and (max-device-height: 1023px) , (min-device-height: 1025px) and (max-device-height: 1280px) and (max-device-width: 1023px)");
				}
				else
				{
					if(device == Constants.TABLET_7_IN)
					{
						return "@media (min-device-height: 401px) and (max-device-height: 800px) and (min-device-width: 401px) and (max-device-width: 1024px) , (min-device-height: 401px) and (min-device-width: 401px) and (max-device-height: 1024px) and (max-device-width: 800px)";
					}
					else
					{
						if(device == Constants.SMARTPHONE_LANDSCAPE)
						{
							return "@media (orientation: landscape) and (max-device-height: 400px), (orientation: landscape) and (max-device-width: 400px)";
						}
						else
						{
							if(device == Constants.SMARTPHONE_PORTRAIT)
							{
								return "@media (orientation: portrait) and (max-device-height: 400px), (orientation: portrait) and (max-device-width: 400px)";
							}
						}
					}
				}
			}
			return null;
		}
		public static XVar getForLogin()
		{
			return new ProjectSettings(new XVar("dbo.EMPLEADO"), new XVar(Constants.PAGE_LIST));
			return null;
		}
		public virtual XVar getDashboardSearchFields()
		{
			return getTableData(new XVar(".searchFields"));
		}
		public virtual XVar getDashboardElements()
		{
			return getTableData(new XVar(".dashElements"));
		}
		public virtual XVar getDashboardElementData(dynamic _param_dashElementName)
		{
			#region pass-by-value parameters
			dynamic dashElementName = XVar.Clone(_param_dashElementName);
			#endregion

			dynamic dElements = XVar.Array();
			dElements = XVar.Clone(getTableData(new XVar(".dashElements")));
			foreach (KeyValuePair<XVar, dynamic> dElemData in dElements.GetEnumerator())
			{
				if(dElemData.Value["elementName"] == dashElementName)
				{
					return dElemData.Value;
				}
			}
			return XVar.Array();
		}
		public virtual XVar getAfterAddAction()
		{
			return getTableData(new XVar(".afterAddAction"));
		}
		public virtual XVar getAADetailTable()
		{
			return getTableData(new XVar(".afterAddActionDetTable"));
		}
		public virtual XVar checkClosePopupAfterAdd()
		{
			return getTableData(new XVar(".closePopupAfterAdd"));
		}
		public virtual XVar getAfterEditAction()
		{
			return getTableData(new XVar(".afterEditAction"));
		}
		public virtual XVar getAEDetailTable()
		{
			return getTableData(new XVar(".afterEditActionDetTable"));
		}
		public virtual XVar checkClosePopupAfterEdit()
		{
			return getTableData(new XVar(".closePopupAfterEdit"));
		}
		public virtual XVar getMapIcon(dynamic _param_field, dynamic _param_data)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			dynamic data = XVar.Clone(_param_data);
			#endregion

			if(XVar.Pack(!(XVar)(isMapIconCustom((XVar)(field)))))
			{
				dynamic mapData = XVar.Array();
				mapData = XVar.Clone(getMapData((XVar)(field)));
				if(mapData["mapIcon"] != "")
				{
					return MVCFunctions.Concat("images/menuicons/", mapData["mapIcon"]);
				}
				return "";
			}
			else
			{
				return MVCFunctions.getCustomMapIcon((XVar)(field), new XVar(""), (XVar)(data));
			}
			return null;
		}
		public virtual XVar getDashMapIcon(dynamic _param_dashElementName, dynamic _param_data)
		{
			#region pass-by-value parameters
			dynamic dashElementName = XVar.Clone(_param_dashElementName);
			dynamic data = XVar.Clone(_param_data);
			#endregion

			dynamic dashElementData = XVar.Array();
			dashElementData = XVar.Clone(getDashboardElementData((XVar)(dashElementName)));
			if(XVar.Pack(dashElementData["isMarkerIconCustom"]))
			{
				return MVCFunctions.getDashMapCustomIcon((XVar)(this._table), (XVar)(dashElementName), (XVar)(data));
			}
			if(XVar.Pack(dashElementData["iconF"]))
			{
				return dashElementData["iconF"];
			}
			return "";
		}
		public virtual XVar isMapIconCustom(dynamic _param_field)
		{
			#region pass-by-value parameters
			dynamic field = XVar.Clone(_param_field);
			#endregion

			dynamic mapData = XVar.Array();
			mapData = XVar.Clone(getMapData((XVar)(field)));
			return mapData["isMapIconCustom"];
		}
		public virtual XVar getDetailsBadgeColor()
		{
			return getTableData(new XVar(".badgeColor"));
		}
		public virtual XVar helperFormItems()
		{
			return getPageOption(new XVar("layoutHelper"), new XVar("formItems"));
		}
		public virtual XVar helperItemsByType()
		{
			return getPageOption(new XVar("layoutHelper"), new XVar("itemsByType"));
		}
		public virtual XVar allFieldItems()
		{
			return getPageOption(new XVar("fields"), new XVar("fieldItems"));
		}
		public virtual XVar helperItemVisibility()
		{
			return getPageOption(new XVar("layoutHelper"), new XVar("itemVisibility"));
		}
		public virtual XVar helperCellMaps()
		{
			return getPageOption(new XVar("layoutHelper"), new XVar("cellMaps"));
		}
		public virtual XVar detailsShowCount(dynamic _param_dTable)
		{
			#region pass-by-value parameters
			dynamic dTable = XVar.Clone(_param_dTable);
			#endregion

			return getPageOption(new XVar("details"), (XVar)(dTable), new XVar("showCount"));
		}
		public virtual XVar detailsHideEmpty(dynamic _param_dTable)
		{
			#region pass-by-value parameters
			dynamic dTable = XVar.Clone(_param_dTable);
			#endregion

			return getPageOption(new XVar("details"), (XVar)(dTable), new XVar("hideEmptyChild"));
		}
		public virtual XVar detailsPreview(dynamic _param_dTable)
		{
			#region pass-by-value parameters
			dynamic dTable = XVar.Clone(_param_dTable);
			#endregion

			return getPageOption(new XVar("details"), (XVar)(dTable), new XVar("displayPreview"));
		}
		public virtual XVar detailsProceedLink(dynamic _param_dTable)
		{
			#region pass-by-value parameters
			dynamic dTable = XVar.Clone(_param_dTable);
			#endregion

			return getPageOption(new XVar("details"), (XVar)(dTable), new XVar("showProceedLink"));
		}
		public virtual XVar detailsPrint(dynamic _param_dTable)
		{
			#region pass-by-value parameters
			dynamic dTable = XVar.Clone(_param_dTable);
			#endregion

			return getPageOption(new XVar("details"), (XVar)(dTable), new XVar("printDetails"));
		}
		public virtual XVar detailsLinks()
		{
			return getPageOption(new XVar("allDetails"), new XVar("linkType"));
		}
		public virtual XVar detailsPageId(dynamic _param_dTable)
		{
			#region pass-by-value parameters
			dynamic dTable = XVar.Clone(_param_dTable);
			#endregion

			return getPageOption(new XVar("details"), (XVar)(dTable), new XVar("previewPageId"));
		}
		public virtual XVar masterPreview(dynamic _param_mTable)
		{
			#region pass-by-value parameters
			dynamic mTable = XVar.Clone(_param_mTable);
			#endregion

			return getPageOption(new XVar("master"), (XVar)(mTable), new XVar("preview"));
		}
		public virtual XVar hasMap()
		{
			return !(XVar)(!(XVar)(getPageOption(new XVar("events"), new XVar("maps"))));
		}
		public virtual XVar maps()
		{
			return getPageOption(new XVar("events"), new XVar("maps"));
		}
		public virtual XVar mapsData()
		{
			return getPageOption(new XVar("events"), new XVar("mapsData"));
		}
		public virtual XVar buttons()
		{
			return getPageOption(new XVar("events"), new XVar("buttons"));
		}
		public virtual XVar getPageType()
		{
			return this._auxTableData[".pages"][this._page];
		}
		public virtual XVar welcomeItems()
		{
			return getPageOption(new XVar("welcome"), new XVar("welcomeItems"));
		}
	}
	// Included file globals
	public partial class CommonFunctions
	{
		public static XVar fillProjectEntites()
		{
			if(XVar.Pack(MVCFunctions.count(GlobalVars.projectEntities)))
			{
				return null;
			}
			GlobalVars.projectEntities.InitAndSetArrayItem(new XVar("url", "dbo_DEPARTAMENTO", "type", 0), "dbo.DEPARTAMENTO");
			GlobalVars.projectEntitiesReverse.InitAndSetArrayItem("dbo.DEPARTAMENTO", "dbo_DEPARTAMENTO");
			GlobalVars.projectEntities.InitAndSetArrayItem(new XVar("url", "dbo_EMPLEADO", "type", 0), "dbo.EMPLEADO");
			GlobalVars.projectEntitiesReverse.InitAndSetArrayItem("dbo.EMPLEADO", "dbo_EMPLEADO");
			GlobalVars.projectEntities.InitAndSetArrayItem(new XVar("url", "dbo_ESTADO_COMPESADO", "type", 0), "dbo.ESTADO_COMPESADO");
			GlobalVars.projectEntitiesReverse.InitAndSetArrayItem("dbo.ESTADO_COMPESADO", "dbo_ESTADO_COMPESADO");
			GlobalVars.projectEntities.InitAndSetArrayItem(new XVar("url", "dbo_ESTADO_PERSONALES", "type", 0), "dbo.ESTADO_PERSONALES");
			GlobalVars.projectEntitiesReverse.InitAndSetArrayItem("dbo.ESTADO_PERSONALES", "dbo_ESTADO_PERSONALES");
			GlobalVars.projectEntities.InitAndSetArrayItem(new XVar("url", "dbo_HORARIOS", "type", 0), "dbo.HORARIOS");
			GlobalVars.projectEntitiesReverse.InitAndSetArrayItem("dbo.HORARIOS", "dbo_HORARIOS");
			GlobalVars.projectEntities.InitAndSetArrayItem(new XVar("url", "dbo_Permisos2", "type", 0), "dbo.Permisos2");
			GlobalVars.projectEntitiesReverse.InitAndSetArrayItem("dbo.Permisos2", "dbo_Permisos2");
			GlobalVars.projectEntities.InitAndSetArrayItem(new XVar("url", "dbo_PERMISOSGRUPOS", "type", 0), "dbo.PERMISOSGRUPOS");
			GlobalVars.projectEntitiesReverse.InitAndSetArrayItem("dbo.PERMISOSGRUPOS", "dbo_PERMISOSGRUPOS");
			GlobalVars.projectEntities.InitAndSetArrayItem(new XVar("url", "dbo_Preferencias", "type", 0), "dbo.Preferencias");
			GlobalVars.projectEntitiesReverse.InitAndSetArrayItem("dbo.Preferencias", "dbo_Preferencias");
			GlobalVars.projectEntities.InitAndSetArrayItem(new XVar("url", "dbo_REGISTRO_HORAS_COMPESADAS", "type", 0), "dbo.REGISTRO_HORAS_COMPESADAS");
			GlobalVars.projectEntitiesReverse.InitAndSetArrayItem("dbo.REGISTRO_HORAS_COMPESADAS", "dbo_REGISTRO_HORAS_COMPESADAS");
			GlobalVars.projectEntities.InitAndSetArrayItem(new XVar("url", "dbo_TIPOEMPLEADO", "type", 0), "dbo.TIPOEMPLEADO");
			GlobalVars.projectEntitiesReverse.InitAndSetArrayItem("dbo.TIPOEMPLEADO", "dbo_TIPOEMPLEADO");
			GlobalVars.projectEntities.InitAndSetArrayItem(new XVar("url", "dbo_TIPOPERMISO", "type", 0), "dbo.TIPOPERMISO");
			GlobalVars.projectEntitiesReverse.InitAndSetArrayItem("dbo.TIPOPERMISO", "dbo_TIPOPERMISO");
			GlobalVars.projectEntities.InitAndSetArrayItem(new XVar("url", "APROBAR_PERMISOS", "type", 1), "APROBAR_PERMISOS");
			GlobalVars.projectEntitiesReverse.InitAndSetArrayItem("APROBAR_PERMISOS", "APROBAR_PERMISOS");
			GlobalVars.projectEntities.InitAndSetArrayItem(new XVar("url", "admin_rights", "type", 1), "admin_rights");
			GlobalVars.projectEntitiesReverse.InitAndSetArrayItem("admin_rights", "admin_rights");
			GlobalVars.projectEntities.InitAndSetArrayItem(new XVar("url", "admin_members", "type", 1), "admin_members");
			GlobalVars.projectEntitiesReverse.InitAndSetArrayItem("admin_members", "admin_members");
			GlobalVars.projectEntities.InitAndSetArrayItem(new XVar("url", "admin_users", "type", 1), "admin_users");
			GlobalVars.projectEntitiesReverse.InitAndSetArrayItem("admin_users", "admin_users");
			GlobalVars.projectEntities.InitAndSetArrayItem(new XVar("url", "VISTOBUENO_JEFEINMEDIATO", "type", 1), "VISTOBUENO_JEFEINMEDIATO");
			GlobalVars.projectEntitiesReverse.InitAndSetArrayItem("VISTOBUENO_JEFEINMEDIATO", "VISTOBUENO_JEFEINMEDIATO");
			GlobalVars.projectEntities.InitAndSetArrayItem(new XVar("url", "VISTOBUENO_JEFEDEPARTAMENTO", "type", 1), "VISTOBUENO_JEFEDEPARTAMENTO");
			GlobalVars.projectEntitiesReverse.InitAndSetArrayItem("VISTOBUENO_JEFEDEPARTAMENTO", "VISTOBUENO_JEFEDEPARTAMENTO");
			GlobalVars.projectEntities.InitAndSetArrayItem(new XVar("url", "VER_PERMISOS", "type", 1), "VER_PERMISOS");
			GlobalVars.projectEntitiesReverse.InitAndSetArrayItem("VER_PERMISOS", "VER_PERMISOS");
			GlobalVars.projectEntities.InitAndSetArrayItem(new XVar("url", "Saldo_Horas_Empleado", "type", 1), "Saldo_Horas_Empleado");
			GlobalVars.projectEntitiesReverse.InitAndSetArrayItem("Saldo_Horas_Empleado", "Saldo_Horas_Empleado");
			GlobalVars.projectEntities.InitAndSetArrayItem(new XVar("url", "VER_COMPESADOS", "type", 1), "VER_COMPESADOS");
			GlobalVars.projectEntitiesReverse.InitAndSetArrayItem("VER_COMPESADOS", "VER_COMPESADOS");
			GlobalVars.projectEntities.InitAndSetArrayItem(new XVar("url", "APROBACION_COMPESADOS_JEFEINMEDIATO", "type", 1), "APROBACION_COMPESADOS_JEFEINMEDIATO");
			GlobalVars.projectEntitiesReverse.InitAndSetArrayItem("APROBACION_COMPESADOS_JEFEINMEDIATO", "APROBACION_COMPESADOS_JEFEINMEDIATO");
			GlobalVars.projectEntities.InitAndSetArrayItem(new XVar("url", "APROBACION_COMPESADOS_JEFEDEPARTAMENTO", "type", 1), "APROBACION_COMPESADOS_JEFEDEPARTAMENTO");
			GlobalVars.projectEntitiesReverse.InitAndSetArrayItem("APROBACION_COMPESADOS_JEFEDEPARTAMENTO", "APROBACION_COMPESADOS_JEFEDEPARTAMENTO");
			GlobalVars.projectEntities.InitAndSetArrayItem(new XVar("url", "APROBAR_COMPESADOS", "type", 1), "APROBAR_COMPESADOS");
			GlobalVars.projectEntitiesReverse.InitAndSetArrayItem("APROBAR_COMPESADOS", "APROBAR_COMPESADOS");
			GlobalVars.projectEntities.InitAndSetArrayItem(new XVar("url", "INGRESAR_PERMISO", "type", 1), "INGRESAR PERMISO");
			GlobalVars.projectEntitiesReverse.InitAndSetArrayItem("INGRESAR PERMISO", "INGRESAR_PERMISO");
			GlobalVars.projectEntities.InitAndSetArrayItem(new XVar("url", "INGRESAR_COMPESADO", "type", 1), "INGRESAR_COMPESADO");
			GlobalVars.projectEntitiesReverse.InitAndSetArrayItem("INGRESAR_COMPESADO", "INGRESAR_COMPESADO");
			GlobalVars.projectEntities.InitAndSetArrayItem(new XVar("url", "dbo_GRUPOS", "type", 0), "dbo.GRUPOS");
			GlobalVars.projectEntitiesReverse.InitAndSetArrayItem("dbo.GRUPOS", "dbo_GRUPOS");
			GlobalVars.projectEntities.InitAndSetArrayItem(new XVar("url", "dbo_acceso_ugmembers", "type", 0), "dbo.acceso_ugmembers");
			GlobalVars.projectEntitiesReverse.InitAndSetArrayItem("dbo.acceso_ugmembers", "dbo_acceso_ugmembers");
			GlobalVars.projectEntities.InitAndSetArrayItem(new XVar("url", "Licencias_sin_goce_sueldo", "type", 1), "Licencias_sin_goce_sueldo");
			GlobalVars.projectEntitiesReverse.InitAndSetArrayItem("Licencias_sin_goce_sueldo", "Licencias_sin_goce_sueldo");
			return null;
		}
		public static XVar findTable(dynamic _param_table)
		{
			#region pass-by-value parameters
			dynamic table = XVar.Clone(_param_table);
			#endregion

			dynamic uTable = null;
			CommonFunctions.fillProjectEntites();
			if(XVar.Pack(GlobalVars.projectEntities.KeyExists(table)))
			{
				return table;
			}
			uTable = XVar.Clone(MVCFunctions.strtoupper((XVar)(table)));
			foreach (KeyValuePair<XVar, dynamic> d in GlobalVars.projectEntities.GetEnumerator())
			{
				dynamic gt = null;
				if(uTable == MVCFunctions.strtoupper((XVar)(d.Key)))
				{
					return d.Key;
				}
				gt = XVar.Clone(MVCFunctions.GoodFieldName((XVar)(d.Key)));
				if((XVar)(table == gt)  || (XVar)(uTable == MVCFunctions.strtoupper((XVar)(gt))))
				{
					return d.Key;
				}
			}
			if(XVar.Pack(GlobalVars.projectEntitiesReverse.KeyExists(table)))
			{
				return GlobalVars.projectEntitiesReverse[table];
			}
			foreach (KeyValuePair<XVar, dynamic> v in GlobalVars.projectEntitiesReverse.GetEnumerator())
			{
				if(uTable == MVCFunctions.strtoupper((XVar)(v.Key)))
				{
					return v.Value;
				}
			}
			return "";
		}
		public static XVar GetTableURL(dynamic _param_table = null)
		{
			#region default values
			if(_param_table as Object == null) _param_table = new XVar("");
			#endregion

			#region pass-by-value parameters
			dynamic table = XVar.Clone(_param_table);
			#endregion

			if(table == "<global>")
			{
				return ".global";
			}
			if(XVar.Pack(!(XVar)(table)))
			{
				table = XVar.Clone(GlobalVars.strTableName);
			}
			CommonFunctions.fillProjectEntites();
			if(XVar.Pack(GlobalVars.projectEntities.KeyExists(table)))
			{
				return GlobalVars.projectEntities[table]["url"];
			}
			return "";
		}
		public static XVar GetEntityType(dynamic _param_table = null)
		{
			#region default values
			if(_param_table as Object == null) _param_table = new XVar("");
			#endregion

			#region pass-by-value parameters
			dynamic table = XVar.Clone(_param_table);
			#endregion

			if(XVar.Pack(!(XVar)(table)))
			{
				table = XVar.Clone(GlobalVars.strTableName);
			}
			CommonFunctions.fillProjectEntites();
			if(XVar.Pack(GlobalVars.projectEntities.KeyExists(table)))
			{
				return GlobalVars.projectEntities[table]["type"];
			}
			return "";
		}
		public static XVar GetTableByShort(dynamic _param_shortTName)
		{
			#region pass-by-value parameters
			dynamic shortTName = XVar.Clone(_param_shortTName);
			#endregion

			CommonFunctions.fillProjectEntites();
			if(XVar.Pack(!(XVar)(shortTName)))
			{
				return false;
			}
			return GlobalVars.projectEntitiesReverse[shortTName];
		}
	}
}
