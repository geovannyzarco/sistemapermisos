using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_PermisosDB_at_192_168_1_123_dbo_GRUPOS : tDALTable
    {
        public XVar id_grupo;
        public XVar grupo;
        public XVar id_departamento;
        public static void Init()
        {
            XVar dalTableGRUPOS = XVar.Array();
            dalTableGRUPOS["id_grupo"] = new XVar("type", 3, "varname", "id_grupo");
            dalTableGRUPOS["grupo"] = new XVar("type", 200, "varname", "grupo");
            dalTableGRUPOS["id_departamento"] = new XVar("type", 3, "varname", "id_departamento");
	        dalTableGRUPOS.InitAndSetArrayItem(true, "id_grupo", "key");
            GlobalVars.dal_info["PermisosDB_at_192_168_1_123_dbo_GRUPOS"] = dalTableGRUPOS;
        }

        public  dalTable_PermisosDB_at_192_168_1_123_dbo_GRUPOS()
        {
            			this.m_TableName = "dbo.GRUPOS";
            this.m_infoKey = "PermisosDB_at_192_168_1_123_dbo_GRUPOS";
        }
    }
}