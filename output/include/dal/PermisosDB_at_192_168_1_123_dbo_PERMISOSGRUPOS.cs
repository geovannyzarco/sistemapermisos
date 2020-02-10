using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_PermisosDB_at_192_168_1_123_dbo_PERMISOSGRUPOS : tDALTable
    {
        public XVar id_departamento;
        public XVar fecha_permisos;
        public XVar id_grupo;
        public XVar id_permisos;
        public static void Init()
        {
            XVar dalTablePERMISOSGRUPOS = XVar.Array();
            dalTablePERMISOSGRUPOS["id_departamento"] = new XVar("type", 3, "varname", "id_departamento");
            dalTablePERMISOSGRUPOS["fecha_permisos"] = new XVar("type", 7, "varname", "fecha_permisos");
            dalTablePERMISOSGRUPOS["id_grupo"] = new XVar("type", 3, "varname", "id_grupo");
            dalTablePERMISOSGRUPOS["id_permisos"] = new XVar("type", 3, "varname", "id_permisos");
            GlobalVars.dal_info["PermisosDB_at_192_168_1_123_dbo_PERMISOSGRUPOS"] = dalTablePERMISOSGRUPOS;
        }

        public  dalTable_PermisosDB_at_192_168_1_123_dbo_PERMISOSGRUPOS()
        {
            			this.m_TableName = "dbo.PERMISOSGRUPOS";
            this.m_infoKey = "PermisosDB_at_192_168_1_123_dbo_PERMISOSGRUPOS";
        }
    }
}