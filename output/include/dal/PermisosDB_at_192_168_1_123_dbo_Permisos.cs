using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_PermisosDB_at_192_168_1_123_dbo_Permisos : tDALTable
    {
        public XVar id_permisos;
        public XVar ONI;
        public XVar id_tipopermiso;
        public XVar fecha_solicitud;
        public XVar motivo;
        public XVar adjunto;
        public XVar id_estado_personal;
        public XVar Observaciones;
        public XVar total_horas;
        public static void Init()
        {
            XVar dalTablePermisos = XVar.Array();
            dalTablePermisos["id_permisos"] = new XVar("type", 3, "varname", "id_permisos");
            dalTablePermisos["ONI"] = new XVar("type", 200, "varname", "ONI");
            dalTablePermisos["id_tipopermiso"] = new XVar("type", 3, "varname", "id_tipopermiso");
            dalTablePermisos["fecha_solicitud"] = new XVar("type", 7, "varname", "fecha_solicitud");
            dalTablePermisos["motivo"] = new XVar("type", 201, "varname", "motivo");
            dalTablePermisos["adjunto"] = new XVar("type", 201, "varname", "adjunto");
            dalTablePermisos["id_estado_personal"] = new XVar("type", 3, "varname", "id_estado_personal");
            dalTablePermisos["Observaciones"] = new XVar("type", 201, "varname", "Observaciones");
            dalTablePermisos["total_horas"] = new XVar("type", 3, "varname", "total_horas");
	        dalTablePermisos.InitAndSetArrayItem(true, "id_permisos", "key");
            GlobalVars.dal_info["PermisosDB_at_192_168_1_123_dbo_Permisos"] = dalTablePermisos;
        }

        public  dalTable_PermisosDB_at_192_168_1_123_dbo_Permisos()
        {
            			this.m_TableName = "dbo.Permisos";
            this.m_infoKey = "PermisosDB_at_192_168_1_123_dbo_Permisos";
        }
    }
}