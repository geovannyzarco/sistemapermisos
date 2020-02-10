using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_PermisosDB_at_192_168_1_123_dbo_TIPOPERMISO : tDALTable
    {
        public XVar id_tipopermiso;
        public XVar tipo_permiso;
        public XVar horas_asignada;
        public XVar dias_asignados;
        public XVar cantidad_permisos;
        public static void Init()
        {
            XVar dalTableTIPOPERMISO = XVar.Array();
            dalTableTIPOPERMISO["id_tipopermiso"] = new XVar("type", 3, "varname", "id_tipopermiso");
            dalTableTIPOPERMISO["tipo_permiso"] = new XVar("type", 200, "varname", "tipo_permiso");
            dalTableTIPOPERMISO["horas_asignada"] = new XVar("type", 3, "varname", "horas_asignada");
            dalTableTIPOPERMISO["dias_asignados"] = new XVar("type", 3, "varname", "dias_asignados");
            dalTableTIPOPERMISO["cantidad_permisos"] = new XVar("type", 3, "varname", "cantidad_permisos");
	        dalTableTIPOPERMISO.InitAndSetArrayItem(true, "id_tipopermiso", "key");
            GlobalVars.dal_info["PermisosDB_at_192_168_1_123_dbo_TIPOPERMISO"] = dalTableTIPOPERMISO;
        }

        public  dalTable_PermisosDB_at_192_168_1_123_dbo_TIPOPERMISO()
        {
            			this.m_TableName = "dbo.TIPOPERMISO";
            this.m_infoKey = "PermisosDB_at_192_168_1_123_dbo_TIPOPERMISO";
        }
    }
}