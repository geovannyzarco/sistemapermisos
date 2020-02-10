using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_PermisosDB_at_192_168_1_123_dbo_DEPARTAMENTO : tDALTable
    {
        public XVar id_departamento;
        public XVar departamento;
        public XVar limite_permisos;
        public static void Init()
        {
            XVar dalTableDEPARTAMENTO = XVar.Array();
            dalTableDEPARTAMENTO["id_departamento"] = new XVar("type", 3, "varname", "id_departamento");
            dalTableDEPARTAMENTO["departamento"] = new XVar("type", 200, "varname", "departamento");
            dalTableDEPARTAMENTO["limite_permisos"] = new XVar("type", 3, "varname", "limite_permisos");
	        dalTableDEPARTAMENTO.InitAndSetArrayItem(true, "id_departamento", "key");
            GlobalVars.dal_info["PermisosDB_at_192_168_1_123_dbo_DEPARTAMENTO"] = dalTableDEPARTAMENTO;
        }

        public  dalTable_PermisosDB_at_192_168_1_123_dbo_DEPARTAMENTO()
        {
            			this.m_TableName = "dbo.DEPARTAMENTO";
            this.m_infoKey = "PermisosDB_at_192_168_1_123_dbo_DEPARTAMENTO";
        }
    }
}