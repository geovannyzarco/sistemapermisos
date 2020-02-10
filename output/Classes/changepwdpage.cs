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
	public partial class ChangePasswordPage : RunnerPage
	{
		protected dynamic pwdStrong = XVar.Pack(false);
		public dynamic token = XVar.Pack("");
		public dynamic action;
		protected dynamic passwordField;
		protected dynamic usernameField;
		protected dynamic auditObj = XVar.Pack(null);
		protected dynamic changePwdFields;
		protected dynamic changedSuccess = XVar.Pack(false);
		protected static bool skipChangePasswordPageCtor = false;
		public ChangePasswordPage(dynamic var_params = null)
			:base((XVar)var_params)
		{
			if(skipChangePasswordPageCtor)
			{
				skipChangePasswordPageCtor = false;
				return;
			}
			#region default values
			if(var_params as Object == null) var_params = new XVar("");
			#endregion

			if((XVar)(!(XVar)(this.action))  && (XVar)(!(XVar)(checkToken())))
			{
				Security.saveRedirectURL();
				MVCFunctions.HeaderRedirect(new XVar("login"));
				return;
			}
			this.passwordField = XVar.Clone(CommonFunctions.GetPasswordField());
			this.usernameField = XVar.Clone(CommonFunctions.GetUserNameField());
			this.auditObj = XVar.Clone(CommonFunctions.GetAuditObject());
			if(XVar.Pack(this.token))
			{
				this.changePwdFields = XVar.Clone(new XVar(0, "newpass", 1, "confirm"));
				setProxyValue(new XVar("token"), (XVar)(this.token));
			}
			else
			{
				this.changePwdFields = XVar.Clone(new XVar(0, "oldpass", 1, "newpass", 2, "confirm"));
			}
			this.pwdStrong = XVar.Clone(CommonFunctions.GetGlobalData(new XVar("pwdStrong"), new XVar(false)));
			if(XVar.Pack(this.pwdStrong))
			{
				this.settingsMap.InitAndSetArrayItem(true, "globalSettings", "pwdStrong");
				this.settingsMap.InitAndSetArrayItem(CommonFunctions.GetGlobalData(new XVar("pwdLen"), new XVar(0)), "globalSettings", "pwdLen");
				this.settingsMap.InitAndSetArrayItem(CommonFunctions.GetGlobalData(new XVar("pwdUnique"), new XVar(0)), "globalSettings", "pwdUnique");
				this.settingsMap.InitAndSetArrayItem(CommonFunctions.GetGlobalData(new XVar("pwdDigits"), new XVar(0)), "globalSettings", "pwdDigits");
				this.settingsMap.InitAndSetArrayItem(CommonFunctions.GetGlobalData(new XVar("pwdUpperLower"), new XVar(false)), "globalSettings", "pwdUpperLower");
			}
			this.formBricks.InitAndSetArrayItem("changeheader", "header");
			this.formBricks.InitAndSetArrayItem("changebuttons", "footer");
			assignFormFooterAndHeaderBricks(new XVar(true));
		}
		protected override XVar setTableConnection()
		{
			this.connection = XVar.Clone(GlobalVars.cman.getForLogin());
			return null;
		}
		protected override XVar assignCipherer()
		{
			this.cipherer = XVar.Clone(RunnerCipherer.getForLogin());
			return null;
		}
		protected virtual XVar setReferer()
		{
			dynamic referer = null;
			referer = XVar.Clone((XVar.Pack((XVar)(MVCFunctions.GetServerVariable("HTTP_REFERER") != "")  && (XVar)(MVCFunctions.strpos((XVar)(MVCFunctions.GetServerVariable("HTTP_REFERER")), (XVar)(MVCFunctions.GetTableLink(new XVar("changepwd")))) != MVCFunctions.strlen((XVar)(MVCFunctions.GetServerVariable("HTTP_REFERER"))) - MVCFunctions.strlen((XVar)(MVCFunctions.GetTableLink(new XVar("changepwd")))))) ? XVar.Pack(MVCFunctions.GetServerVariable("HTTP_REFERER")) : XVar.Pack("")));
			if(XVar.Pack(!(XVar)(XSession.Session.KeyExists("changepwd_referer"))))
			{
				XSession.Session["changepwd_referer"] = (XVar.Pack(referer != XVar.Pack("")) ? XVar.Pack(referer) : XVar.Pack(MVCFunctions.GetTableLink(new XVar("menu"))));
			}
			else
			{
				if(referer != XVar.Pack(""))
				{
					XSession.Session["changepwd_referer"] = referer;
				}
			}
			return null;
		}
		protected virtual XVar getSQLWhere()
		{
			dynamic sWhere = null, value = null;
			if(XVar.Pack(this.token))
			{
				return MVCFunctions.Concat(" where", this.connection.addFieldWrappers(new XVar("")), "=", this.connection.prepareString((XVar)(this.token)));
			}
			value = XVar.Clone(getSqlPreparedLoginTableValue((XVar)(XSession.Session["UserID"]), (XVar)(this.usernameField), (XVar)(GlobalVars.cUserNameFieldType)));
			if(XVar.Pack(this.pSet.usersTableInProject()))
			{
				sWhere = XVar.Clone(MVCFunctions.Concat(" where ", this.connection.comparisonSQL((XVar)(getFieldSQLDecrypt((XVar)(this.usernameField))), (XVar)(value), (XVar)(this.pSet.isCaseInsensitiveUsername()))));
			}
			else
			{
				sWhere = XVar.Clone(MVCFunctions.Concat(" where ", this.connection.comparisonSQL((XVar)(this.connection.addFieldWrappers((XVar)(this.usernameField))), (XVar)(value), (XVar)(this.pSet.isCaseInsensitiveUsername()))));
			}
			return sWhere;
		}
		protected virtual XVar getSelectSQL(dynamic _param_where)
		{
			#region pass-by-value parameters
			dynamic where = XVar.Clone(_param_where);
			#endregion

			if(XVar.Pack(this.pSet.usersTableInProject()))
			{
				GlobalVars.strSQL = XVar.Clone(MVCFunctions.Concat("select ", getFieldSQLDecrypt((XVar)(this.passwordField))));
			}
			else
			{
				GlobalVars.strSQL = XVar.Clone(MVCFunctions.Concat("select ", this.connection.addFieldWrappers((XVar)(this.passwordField))));
			}
			return MVCFunctions.Concat(GlobalVars.strSQL, " from ", this.connection.addTableWrappers((XVar)(GlobalVars.cLoginTable)), where);
		}
		protected virtual XVar getUpdateSQL(dynamic _param_newpass, dynamic _param_where)
		{
			#region pass-by-value parameters
			dynamic newpass = XVar.Clone(_param_newpass);
			dynamic where = XVar.Clone(_param_where);
			#endregion

			dynamic passvalue = null, setPart = null;
			passvalue = XVar.Clone(this.cipherer.AddDBQuotes((XVar)(this.passwordField), (XVar)(newpass)));
			setPart = XVar.Clone(MVCFunctions.Concat(" set ", this.connection.addFieldWrappers((XVar)(this.passwordField)), "=", passvalue));
			if(XVar.Pack(this.token))
			{
				setPart = MVCFunctions.Concat(setPart, ", ", this.connection.addFieldWrappers(new XVar("")), "=", this.connection.prepareString(new XVar("")), ", ", this.connection.addFieldWrappers(new XVar("")), "=", this.connection.addDateQuotes(new XVar(null)));
			}
			return MVCFunctions.Concat("update ", this.connection.addTableWrappers((XVar)(GlobalVars.cLoginTable)), setPart, " ", where);
		}
		protected virtual XVar getControlValues()
		{
			dynamic blobfields = null, filename_values = null, values = null;
			filename_values = XVar.Clone(XVar.Array());
			blobfields = XVar.Clone(XVar.Array());
			values = XVar.Clone(XVar.Array());
			foreach (KeyValuePair<XVar, dynamic> fName in this.changePwdFields.GetEnumerator())
			{
				dynamic fControl = null;
				fControl = XVar.Clone(getControl((XVar)(fName.Value), (XVar)(this.id)));
				fControl.readWebValue((XVar)(values), (XVar)(blobfields), new XVar(null), new XVar(null), (XVar)(filename_values));
			}
			return values;
		}
		protected virtual XVar checkOldPasswordValue(dynamic _param_oldPass, dynamic _param_row, dynamic _param_bcrypted)
		{
			#region pass-by-value parameters
			dynamic oldPass = XVar.Clone(_param_oldPass);
			dynamic row = XVar.Clone(_param_row);
			dynamic bcrypted = XVar.Clone(_param_bcrypted);
			#endregion

			if(XVar.Pack(!(XVar)(row)))
			{
				return false;
			}
			if(XVar.Pack(this.token))
			{
				return true;
			}
			if(XVar.Pack(bcrypted))
			{
				return MVCFunctions.passwordVerify((XVar)(oldPass), (XVar)(row[0]));
			}
			return oldPass == row[0];
		}
		protected virtual XVar changePassword()
		{
			dynamic _row = XVar.Array(), bcrypted = null, data = null, nData = XVar.Array(), oldPass = null, qResult = null, retval = null, row = XVar.Array(), sqlWhere = null, values = XVar.Array();
			values = XVar.Clone(getControlValues());
			oldPass = XVar.Clone(values["oldpass"]);
			bcrypted = new XVar(false);
			sqlWhere = XVar.Clone(getSQLWhere());
			qResult = XVar.Clone(this.connection.query((XVar)(getSelectSQL((XVar)(sqlWhere)))));
			nData = XVar.Clone(qResult.fetchNumeric());
			data = XVar.Clone(new XVar(GlobalVars.cPasswordField, nData[0]));
			row = XVar.Clone(this.cipherer.DecryptFetchedArray((XVar)(data)));
			_row = XVar.Clone(XVar.Array());
			if(XVar.Pack(row))
			{
				_row = XVar.Clone(new XVar(0, row[GlobalVars.cPasswordField]));
			}
			if(XVar.Pack(!(XVar)(checkOldPasswordValue((XVar)(oldPass), (XVar)(_row), (XVar)(bcrypted)))))
			{
				this.message = new XVar("Cambiar contraseña");
				return false;
			}
			oldPass = XVar.Clone(_row[0]);
			if((XVar)(this.pwdStrong)  && (XVar)(!(XVar)(CommonFunctions.checkpassword((XVar)(values["newpass"])))))
			{
				this.message = XVar.Clone(getPwdStrongFailedMessage());
				this.jsSettings.InitAndSetArrayItem(this.message, "tableSettings", GlobalVars.cLoginTable, "msg_passwordError");
				return false;
			}
			retval = new XVar(true);
			if(XVar.Pack(GlobalVars.globalEvents.exists(new XVar("BeforeChangePassword"))))
			{
				retval = XVar.Clone(GlobalVars.globalEvents.BeforeChangePassword((XVar)(oldPass), (XVar)(values["newpass"]), this));
			}
			if(XVar.Pack(retval))
			{
				GlobalVars.strSQL = XVar.Clone(getUpdateSQL((XVar)(values["newpass"]), (XVar)(sqlWhere)));
				this.connection.exec((XVar)(GlobalVars.strSQL));
				if(XVar.Pack(this.auditObj))
				{
					this.auditObj.LogChPassword();
				}
				if(XVar.Pack(GlobalVars.globalEvents.exists(new XVar("AfterChangePassword"))))
				{
					GlobalVars.globalEvents.AfterChangePassword((XVar)(oldPass), (XVar)(values["newpass"]), this);
				}
			}
			return retval;
		}
		protected virtual XVar getPwdStrongFailedMessage()
		{
			dynamic fmt = null, msg = null, pwdDigits = null, pwdLen = null, pwdUnique = null;
			msg = new XVar("");
			pwdLen = XVar.Clone(CommonFunctions.GetGlobalData(new XVar("pwdLen"), new XVar(0)));
			if(XVar.Pack(pwdLen))
			{
				fmt = new XVar("La contraseña debe contener por lo menos %% carácteres ");
				fmt = XVar.Clone(MVCFunctions.str_replace(new XVar("%%"), (XVar)(MVCFunctions.Concat("", pwdLen)), (XVar)(fmt)));
				msg = MVCFunctions.Concat(msg, "<br>", fmt);
			}
			pwdUnique = XVar.Clone(CommonFunctions.GetGlobalData(new XVar("pwdUnique"), new XVar(0)));
			if(XVar.Pack(pwdUnique))
			{
				fmt = new XVar("La contraseña debe contener %% carácteres únicos");
				fmt = XVar.Clone(MVCFunctions.str_replace(new XVar("%%"), (XVar)(MVCFunctions.Concat("", pwdUnique)), (XVar)(fmt)));
				msg = MVCFunctions.Concat(msg, "<br>", fmt);
			}
			pwdDigits = XVar.Clone(CommonFunctions.GetGlobalData(new XVar("pwdDigits"), new XVar(0)));
			if(XVar.Pack(pwdDigits))
			{
				fmt = new XVar("La contraseña debe contener por lo menos %% dígitos o símbolos");
				fmt = XVar.Clone(MVCFunctions.str_replace(new XVar("%%"), (XVar)(MVCFunctions.Concat("", pwdDigits)), (XVar)(fmt)));
				msg = MVCFunctions.Concat(msg, "<br>", fmt);
			}
			if(XVar.Pack(CommonFunctions.GetGlobalData(new XVar("pwdUpperLower"), new XVar(false))))
			{
				fmt = new XVar("La contraseña debe contener letras en mayúscula y minúscula");
				msg = MVCFunctions.Concat(msg, "<br>", fmt);
			}
			if(XVar.Pack(msg))
			{
				msg = XVar.Clone(MVCFunctions.substr((XVar)(msg), new XVar(4)));
			}
			return msg;
		}
		public virtual XVar process()
		{
			setReferer();
			if(XVar.Pack(GlobalVars.globalEvents.exists(new XVar("BeforeProcessChangePwd"))))
			{
				GlobalVars.globalEvents.BeforeProcessChangePwd(this);
			}
			if(this.action == "Change")
			{
				this.changedSuccess = XVar.Clone(changePassword());
			}
			if(XVar.Pack(!(XVar)(this.changedSuccess)))
			{
				prepareEditControls();
			}
			else
			{
				this.pageName = XVar.Clone(this.pSet.getDefaultPage((XVar)(successPageType())));
				this.pSet = XVar.UnPackProjectSettings(new ProjectSettings((XVar)(this.tName), (XVar)(successPageType()), (XVar)(this.pageName), (XVar)(this.pageTable)));
				this.pageData.InitAndSetArrayItem(MVCFunctions.array_merge((XVar)(this.pageData["buttons"]), (XVar)(this.pSet.buttons())), "buttons");
				foreach (KeyValuePair<XVar, dynamic> b in this.pSet.buttons().GetEnumerator())
				{
					AddJSFile((XVar)(MVCFunctions.Concat("include/button_", b.Value, ".js")));
				}
			}
			addCommonJs();
			fillSetCntrlMaps();
			addButtonHandlers();
			doCommonAssignments();
			showPage();
			return null;
		}
		protected virtual XVar prepareEditControls()
		{
			foreach (KeyValuePair<XVar, dynamic> fName in this.changePwdFields.GetEnumerator())
			{
				dynamic controls = XVar.Array(), parameters = XVar.Array();
				parameters = XVar.Clone(XVar.Array());
				parameters.InitAndSetArrayItem(this.id, "id");
				parameters.InitAndSetArrayItem("add", "mode");
				parameters.InitAndSetArrayItem(fName.Value, "field");
				parameters.InitAndSetArrayItem("Password", "format");
				parameters.InitAndSetArrayItem(this, "pageObj");
				parameters.InitAndSetArrayItem(true, "suggest");
				parameters.InitAndSetArrayItem(new XVar("basicValidate", new XVar(0, "IsRequired")), "validate");
				parameters.InitAndSetArrayItem(XVar.Array(), "extraParams");
				parameters.InitAndSetArrayItem(true, "extraParams", "getConrirmFieldCtrl");
				controls = XVar.Clone(new XVar("controls", XVar.Array()));
				controls.InitAndSetArrayItem(this.id, "controls", "id");
				controls.InitAndSetArrayItem("add", "controls", "mode");
				controls.InitAndSetArrayItem(0, "controls", "ctrlInd");
				controls.InitAndSetArrayItem(fName.Value, "controls", "fieldName");
				controls.InitAndSetArrayItem(parameters["suggest"], "controls", "suggest");
				this.xt.assign_function((XVar)(MVCFunctions.Concat(fName.Value, "_editcontrol")), new XVar("xt_buildeditcontrol"), (XVar)(parameters));
				this.xt.assign((XVar)(MVCFunctions.Concat(fName.Value, "_label")), new XVar(true));
				if(XVar.Pack(isBootstrap()))
				{
					this.xt.assign((XVar)(MVCFunctions.Concat("labelfor_", MVCFunctions.GoodFieldName((XVar)(fName.Value)))), (XVar)(MVCFunctions.Concat("value_", fName.Value, "_", this.id)));
				}
				if(XVar.Pack(this.is508))
				{
					this.xt.assign_section((XVar)(MVCFunctions.Concat(fName.Value, "_label")), (XVar)(MVCFunctions.Concat("<label for=\"value_", fName.Value, "_", this.id, "\">")), new XVar("</label>"));
				}
				this.xt.assign((XVar)(MVCFunctions.Concat(fName.Value, "_block")), new XVar(true));
				fillControlsMap((XVar)(controls));
			}
			return null;
		}
		protected override XVar assignBody()
		{
			this.body["begin"] = MVCFunctions.Concat(this.body["begin"], CommonFunctions.GetBaseScriptsForPage(new XVar(false)));
			this.body.InitAndSetArrayItem(XTempl.create_method_assignment(new XVar("assignBodyEnd"), this), "end");
			this.xt.assignbyref(new XVar("body"), (XVar)(this.body));
			return null;
		}
		protected virtual XVar doCommonAssignments()
		{
			this.xt.assign(new XVar("id"), (XVar)(this.id));
			this.xt.assign(new XVar("submit_attrs"), (XVar)(MVCFunctions.Concat("id=\"saveButton", this.id, "\"")));
			this.xt.assign(new XVar("backlink_attrs"), (XVar)(MVCFunctions.Concat("href=\"", MVCFunctions.runner_htmlspecialchars((XVar)(XSession.Session["changepwd_referer"])), "\"")));
			if(XVar.Pack(this.message))
			{
				if(XVar.Pack(isBootstrap()))
				{
					this.xt.assign(new XVar("message_class"), new XVar("alert-danger"));
					this.xt.assign(new XVar("message"), (XVar)(this.message));
				}
				else
				{
					this.xt.assign(new XVar("message"), (XVar)(MVCFunctions.Concat("<div class='message rnr-error'>", this.message, "</div>")));
				}
				this.xt.assign(new XVar("message_block"), new XVar(true));
			}
			assignBody();
			return null;
		}
		protected virtual XVar showPage()
		{
			if(XVar.Pack(this.changedSuccess))
			{
				switchToSuccessPage();
			}
			if(XVar.Pack(GlobalVars.globalEvents.exists(new XVar("BeforeShowChangePwd"))))
			{
				GlobalVars.globalEvents.BeforeShowChangePwd((XVar)(this.xt), ref this.templatefile, this);
			}
			display((XVar)(this.templatefile));
			return null;
		}
		public static XVar readActionFromRequest()
		{
			if(XVar.Pack(MVCFunctions.postvalue("btnSubmit")))
			{
				return MVCFunctions.postvalue("btnSubmit");
			}
			return "";
		}
		protected virtual XVar checkToken()
		{
			dynamic data = XVar.Array(), sqlSelect = null;
			if(XVar.Pack(!(XVar)(this.token)))
			{
				return true;
			}
			sqlSelect = XVar.Clone(MVCFunctions.Concat("select ", this.connection.addFieldWrappers(new XVar("")), " from", this.connection.addTableWrappers(new XVar("dbo.EMPLEADO")), " where", this.connection.addFieldWrappers(new XVar("")), "=", this.connection.prepareString((XVar)(this.token))));
			data = XVar.Clone(this.cipherer.DecryptFetchedArray((XVar)(this.connection.query((XVar)(sqlSelect)).fetchAssoc())));
			if(XVar.Pack(data))
			{
				return MVCFunctions.secondsPassedFrom((XVar)(data[""])) < 86400;
			}
			return false;
		}
	}
}
