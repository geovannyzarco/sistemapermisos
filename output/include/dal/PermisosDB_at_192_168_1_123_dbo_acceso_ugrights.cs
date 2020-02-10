using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_PermisosDB_at_192_168_1_123_dbo_acceso_ugrights : tDALTable
    {
        public XVar fldTableName;
        public XVar GroupID;
        public XVar AccessMask;
        public static void Init()
        {
            XVar dalTableacceso_ugrights = XVar.Array();
            dalTableacceso_ugrights["TableName"] = new XVar("type", 200, "varname", "fldTableName");
            dalTableacceso_ugrights["GroupID"] = new XVar("type", 3, "varname", "GroupID");
            dalTableacceso_ugrights["AccessMask"] = new XVar("type", 200, "varname", "AccessMask");
	        dalTableacceso_ugrights.InitAndSetArrayItem(true, "TableName", "key");
	        dalTableacceso_ugrights.InitAndSetArrayItem(true, "GroupID", "key");
            GlobalVars.dal_info["PermisosDB_at_192_168_1_123_dbo_acceso_ugrights"] = dalTableacceso_ugrights;
        }

        public  dalTable_PermisosDB_at_192_168_1_123_dbo_acceso_ugrights()
        {
            			this.m_TableName = "dbo.acceso_ugrights";
            this.m_infoKey = "PermisosDB_at_192_168_1_123_dbo_acceso_ugrights";
        }
    }
}