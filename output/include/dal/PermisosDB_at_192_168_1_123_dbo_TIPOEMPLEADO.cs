using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_PermisosDB_at_192_168_1_123_dbo_TIPOEMPLEADO : tDALTable
    {
        public XVar id_tipo;
        public XVar tipo_empleado;
        public static void Init()
        {
            XVar dalTableTIPOEMPLEADO = XVar.Array();
            dalTableTIPOEMPLEADO["id_tipo"] = new XVar("type", 3, "varname", "id_tipo");
            dalTableTIPOEMPLEADO["tipo_empleado"] = new XVar("type", 200, "varname", "tipo_empleado");
	        dalTableTIPOEMPLEADO.InitAndSetArrayItem(true, "id_tipo", "key");
            GlobalVars.dal_info["PermisosDB_at_192_168_1_123_dbo_TIPOEMPLEADO"] = dalTableTIPOEMPLEADO;
        }

        public  dalTable_PermisosDB_at_192_168_1_123_dbo_TIPOEMPLEADO()
        {
            			this.m_TableName = "dbo.TIPOEMPLEADO";
            this.m_infoKey = "PermisosDB_at_192_168_1_123_dbo_TIPOEMPLEADO";
        }
    }
}