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
	public partial class CommonFunctions
	{
		public static XVar getMenuNodes_adminarea(dynamic _param_menuNodesObject)
		{
			#region pass-by-value parameters
			dynamic menuNodesObject = XVar.Clone(_param_menuNodesObject);
			#endregion

			dynamic menuNode = XVar.Array();
			menuNodesObject.menuNodes.InitAndSetArrayItem(XVar.Array(), "adminarea");
			menuNode = XVar.Clone(XVar.Array());
			menuNode.InitAndSetArrayItem("1", "id");
			menuNode.InitAndSetArrayItem("admin_rights", "name");
			menuNode.InitAndSetArrayItem("Leaf", "type");
			menuNode.InitAndSetArrayItem("admin_rights", "table");
			menuNode.InitAndSetArrayItem("", "style");
			menuNode.InitAndSetArrayItem("", "params");
			menuNode.InitAndSetArrayItem("0", "parent");
			menuNode.InitAndSetArrayItem("Text", "nameType");
			menuNode.InitAndSetArrayItem("External", "linkType");
			menuNode.InitAndSetArrayItem("AdminArea", "pageType");
			menuNode.InitAndSetArrayItem("None", "openType");
			menuNode.InitAndSetArrayItem("Permisos", "title");
			menuNode.InitAndSetArrayItem(MVCFunctions.GetTableLink(new XVar("admin_rights"), new XVar("list")), "href");
			menuNodesObject.menuNodes.InitAndSetArrayItem(menuNode, "adminarea", null);
			menuNode = XVar.Clone(XVar.Array());
			menuNode.InitAndSetArrayItem("2", "id");
			menuNode.InitAndSetArrayItem("admin_members", "name");
			menuNode.InitAndSetArrayItem("Leaf", "type");
			menuNode.InitAndSetArrayItem("admin_members", "table");
			menuNode.InitAndSetArrayItem("", "style");
			menuNode.InitAndSetArrayItem("", "params");
			menuNode.InitAndSetArrayItem("0", "parent");
			menuNode.InitAndSetArrayItem("Text", "nameType");
			menuNode.InitAndSetArrayItem("External", "linkType");
			menuNode.InitAndSetArrayItem("AdminArea", "pageType");
			menuNode.InitAndSetArrayItem("None", "openType");
			menuNode.InitAndSetArrayItem("Asignar usuarios a grupos", "title");
			menuNode.InitAndSetArrayItem(MVCFunctions.GetTableLink(new XVar("admin_members"), new XVar("list")), "href");
			menuNodesObject.menuNodes.InitAndSetArrayItem(menuNode, "adminarea", null);
			menuNode = XVar.Clone(XVar.Array());
			menuNode.InitAndSetArrayItem("3", "id");
			menuNode.InitAndSetArrayItem("admin_users", "name");
			menuNode.InitAndSetArrayItem("Leaf", "type");
			menuNode.InitAndSetArrayItem("admin_users", "table");
			menuNode.InitAndSetArrayItem("", "style");
			menuNode.InitAndSetArrayItem("", "params");
			menuNode.InitAndSetArrayItem("0", "parent");
			menuNode.InitAndSetArrayItem("Text", "nameType");
			menuNode.InitAndSetArrayItem("External", "linkType");
			menuNode.InitAndSetArrayItem("AdminArea", "pageType");
			menuNode.InitAndSetArrayItem("None", "openType");
			menuNode.InitAndSetArrayItem("Añadir/Editar usuarios", "title");
			menuNode.InitAndSetArrayItem(MVCFunctions.GetTableLink(new XVar("admin_users"), new XVar("list")), "href");
			menuNodesObject.menuNodes.InitAndSetArrayItem(menuNode, "adminarea", null);
			return null;
		}
	}
}
