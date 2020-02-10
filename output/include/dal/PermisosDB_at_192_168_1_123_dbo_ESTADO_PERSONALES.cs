using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_PermisosDB_at_192_168_1_123_dbo_ESTADO_PERSONALES : tDALTable
    {
        public XVar id_estado_personal;
        public XVar estado_personal;
        public static void Init()
        {
            XVar dalTableESTADO_PERSONALES = XVar.Array();
            dalTableESTADO_PERSONALES["id_estado_personal"] = new XVar("type", 3, "varname", "id_estado_personal");
            dalTableESTADO_PERSONALES["estado_personal"] = new XVar("type", 200, "varname", "estado_personal");
	        dalTableESTADO_PERSONALES.InitAndSetArrayItem(true, "id_estado_personal", "key");
            GlobalVars.dal_info["PermisosDB_at_192_168_1_123_dbo_ESTADO_PERSONALES"] = dalTableESTADO_PERSONALES;
        }

        public  dalTable_PermisosDB_at_192_168_1_123_dbo_ESTADO_PERSONALES()
        {
            			this.m_TableName = "dbo.ESTADO_PERSONALES";
            this.m_infoKey = "PermisosDB_at_192_168_1_123_dbo_ESTADO_PERSONALES";
        }
    }
}