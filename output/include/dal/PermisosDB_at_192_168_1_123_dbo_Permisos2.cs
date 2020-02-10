using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_PermisosDB_at_192_168_1_123_dbo_Permisos2 : tDALTable
    {
        public XVar id_permisos;
        public XVar ONI;
        public XVar id_tipopermiso;
        public XVar fecha_solicitud;
        public XVar motivo;
        public XVar adjunto;
        public XVar id_estado_personal;
        public XVar Observaciones;
        public XVar fecha_inicio;
        public XVar fecha_final;
        public XVar vistobueno1;
        public XVar vistobueno2;
        public static void Init()
        {
            XVar dalTablePermisos2 = XVar.Array();
            dalTablePermisos2["id_permisos"] = new XVar("type", 3, "varname", "id_permisos");
            dalTablePermisos2["ONI"] = new XVar("type", 200, "varname", "ONI");
            dalTablePermisos2["id_tipopermiso"] = new XVar("type", 3, "varname", "id_tipopermiso");
            dalTablePermisos2["fecha_solicitud"] = new XVar("type", 7, "varname", "fecha_solicitud");
            dalTablePermisos2["motivo"] = new XVar("type", 201, "varname", "motivo");
            dalTablePermisos2["adjunto"] = new XVar("type", 201, "varname", "adjunto");
            dalTablePermisos2["id_estado_personal"] = new XVar("type", 3, "varname", "id_estado_personal");
            dalTablePermisos2["Observaciones"] = new XVar("type", 201, "varname", "Observaciones");
            dalTablePermisos2["fecha_inicio"] = new XVar("type", 135, "varname", "fecha_inicio");
            dalTablePermisos2["fecha_final"] = new XVar("type", 135, "varname", "fecha_final");
            dalTablePermisos2["vistobueno1"] = new XVar("type", 200, "varname", "vistobueno1");
            dalTablePermisos2["vistobueno2"] = new XVar("type", 200, "varname", "vistobueno2");
	        dalTablePermisos2.InitAndSetArrayItem(true, "id_permisos", "key");
            GlobalVars.dal_info["PermisosDB_at_192_168_1_123_dbo_Permisos2"] = dalTablePermisos2;
        }

        public  dalTable_PermisosDB_at_192_168_1_123_dbo_Permisos2()
        {
            			this.m_TableName = "dbo.Permisos2";
            this.m_infoKey = "PermisosDB_at_192_168_1_123_dbo_Permisos2";
        }
    }
}