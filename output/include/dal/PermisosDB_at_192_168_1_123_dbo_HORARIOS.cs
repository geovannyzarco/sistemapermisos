using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_PermisosDB_at_192_168_1_123_dbo_HORARIOS : tDALTable
    {
        public XVar id_horarios;
        public XVar horarios;
        public XVar dia_inicio;
        public XVar dia_final;
        public XVar hora_inicio;
        public XVar hora_final;
        public XVar cantidad_horas;
        public XVar horas_permisos_personales;
        public static void Init()
        {
            XVar dalTableHORARIOS = XVar.Array();
            dalTableHORARIOS["id_horarios"] = new XVar("type", 3, "varname", "id_horarios");
            dalTableHORARIOS["horarios"] = new XVar("type", 200, "varname", "horarios");
            dalTableHORARIOS["dia_inicio"] = new XVar("type", 200, "varname", "dia_inicio");
            dalTableHORARIOS["dia_final"] = new XVar("type", 200, "varname", "dia_final");
            dalTableHORARIOS["hora_inicio"] = new XVar("type", 134, "varname", "hora_inicio");
            dalTableHORARIOS["hora_final"] = new XVar("type", 134, "varname", "hora_final");
            dalTableHORARIOS["cantidad_horas"] = new XVar("type", 3, "varname", "cantidad_horas");
            dalTableHORARIOS["horas_permisos_personales"] = new XVar("type", 3, "varname", "horas_permisos_personales");
	        dalTableHORARIOS.InitAndSetArrayItem(true, "id_horarios", "key");
            GlobalVars.dal_info["PermisosDB_at_192_168_1_123_dbo_HORARIOS"] = dalTableHORARIOS;
        }

        public  dalTable_PermisosDB_at_192_168_1_123_dbo_HORARIOS()
        {
            			this.m_TableName = "dbo.HORARIOS";
            this.m_infoKey = "PermisosDB_at_192_168_1_123_dbo_HORARIOS";
        }
    }
}