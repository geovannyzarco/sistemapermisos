using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_PermisosDB_at_192_168_1_123_dbo_Preferencias : tDALTable
    {
        public XVar nombre_jefe;
        public XVar division;
        public XVar ID;
        public static void Init()
        {
            XVar dalTablePreferencias = XVar.Array();
            dalTablePreferencias["nombre_jefe"] = new XVar("type", 200, "varname", "nombre_jefe");
            dalTablePreferencias["division"] = new XVar("type", 200, "varname", "division");
            dalTablePreferencias["ID"] = new XVar("type", 3, "varname", "ID");
	        dalTablePreferencias.InitAndSetArrayItem(true, "ID", "key");
            GlobalVars.dal_info["PermisosDB_at_192_168_1_123_dbo_Preferencias"] = dalTablePreferencias;
        }

        public  dalTable_PermisosDB_at_192_168_1_123_dbo_Preferencias()
        {
            			this.m_TableName = "dbo.Preferencias";
            this.m_infoKey = "PermisosDB_at_192_168_1_123_dbo_Preferencias";
        }
    }
}