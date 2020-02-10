using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_PermisosDB_at_192_168_1_123_dbo_ESTADO_COMPESADO : tDALTable
    {
        public XVar id_estado_compesado;
        public XVar estado_compesado;
        public static void Init()
        {
            XVar dalTableESTADO_COMPESADO = XVar.Array();
            dalTableESTADO_COMPESADO["id_estado_compesado"] = new XVar("type", 3, "varname", "id_estado_compesado");
            dalTableESTADO_COMPESADO["estado_compesado"] = new XVar("type", 200, "varname", "estado_compesado");
	        dalTableESTADO_COMPESADO.InitAndSetArrayItem(true, "id_estado_compesado", "key");
            GlobalVars.dal_info["PermisosDB_at_192_168_1_123_dbo_ESTADO_COMPESADO"] = dalTableESTADO_COMPESADO;
        }

        public  dalTable_PermisosDB_at_192_168_1_123_dbo_ESTADO_COMPESADO()
        {
            			this.m_TableName = "dbo.ESTADO_COMPESADO";
            this.m_infoKey = "PermisosDB_at_192_168_1_123_dbo_ESTADO_COMPESADO";
        }
    }
}