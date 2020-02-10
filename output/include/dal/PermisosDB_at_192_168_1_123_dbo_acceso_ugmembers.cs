using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_PermisosDB_at_192_168_1_123_dbo_acceso_ugmembers : tDALTable
    {
        public XVar UserName;
        public XVar GroupID;
        public static void Init()
        {
            XVar dalTableacceso_ugmembers = XVar.Array();
            dalTableacceso_ugmembers["UserName"] = new XVar("type", 200, "varname", "UserName");
            dalTableacceso_ugmembers["GroupID"] = new XVar("type", 3, "varname", "GroupID");
	        dalTableacceso_ugmembers.InitAndSetArrayItem(true, "UserName", "key");
	        dalTableacceso_ugmembers.InitAndSetArrayItem(true, "GroupID", "key");
            GlobalVars.dal_info["PermisosDB_at_192_168_1_123_dbo_acceso_ugmembers"] = dalTableacceso_ugmembers;
        }

        public  dalTable_PermisosDB_at_192_168_1_123_dbo_acceso_ugmembers()
        {
            			this.m_TableName = "dbo.acceso_ugmembers";
            this.m_infoKey = "PermisosDB_at_192_168_1_123_dbo_acceso_ugmembers";
        }
    }
}