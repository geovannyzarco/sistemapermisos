using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_PermisosDB_at_192_168_1_123_dbo_acceso_uggroups : tDALTable
    {
        public XVar GroupID;
        public XVar Label;
        public static void Init()
        {
            XVar dalTableacceso_uggroups = XVar.Array();
            dalTableacceso_uggroups["GroupID"] = new XVar("type", 3, "varname", "GroupID");
            dalTableacceso_uggroups["Label"] = new XVar("type", 200, "varname", "Label");
	        dalTableacceso_uggroups.InitAndSetArrayItem(true, "GroupID", "key");
            GlobalVars.dal_info["PermisosDB_at_192_168_1_123_dbo_acceso_uggroups"] = dalTableacceso_uggroups;
        }

        public  dalTable_PermisosDB_at_192_168_1_123_dbo_acceso_uggroups()
        {
            			this.m_TableName = "dbo.acceso_uggroups";
            this.m_infoKey = "PermisosDB_at_192_168_1_123_dbo_acceso_uggroups";
        }
    }
}