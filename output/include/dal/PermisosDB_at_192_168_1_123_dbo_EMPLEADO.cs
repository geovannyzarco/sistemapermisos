using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_PermisosDB_at_192_168_1_123_dbo_EMPLEADO : tDALTable
    {
        public XVar ONI;
        public XVar nombre;
        public XVar password;
        public XVar id_tipo;
        public XVar id_departamento;
        public XVar id_horarios;
        public XVar saldo_personales;
        public XVar saldo_compesado;
        public XVar foto;
        public XVar id_grupo;
        public static void Init()
        {
            XVar dalTableEMPLEADO = XVar.Array();
            dalTableEMPLEADO["ONI"] = new XVar("type", 200, "varname", "ONI");
            dalTableEMPLEADO["nombre"] = new XVar("type", 200, "varname", "nombre");
            dalTableEMPLEADO["password"] = new XVar("type", 200, "varname", "password");
            dalTableEMPLEADO["id_tipo"] = new XVar("type", 3, "varname", "id_tipo");
            dalTableEMPLEADO["id_departamento"] = new XVar("type", 3, "varname", "id_departamento");
            dalTableEMPLEADO["id_horarios"] = new XVar("type", 3, "varname", "id_horarios");
            dalTableEMPLEADO["saldo_personales"] = new XVar("type", 3, "varname", "saldo_personales");
            dalTableEMPLEADO["saldo_compesado"] = new XVar("type", 200, "varname", "saldo_compesado");
            dalTableEMPLEADO["foto"] = new XVar("type", 200, "varname", "foto");
            dalTableEMPLEADO["id_grupo"] = new XVar("type", 3, "varname", "id_grupo");
	        dalTableEMPLEADO.InitAndSetArrayItem(true, "ONI", "key");
            GlobalVars.dal_info["PermisosDB_at_192_168_1_123_dbo_EMPLEADO"] = dalTableEMPLEADO;
        }

        public  dalTable_PermisosDB_at_192_168_1_123_dbo_EMPLEADO()
        {
            			this.m_TableName = "dbo.EMPLEADO";
            this.m_infoKey = "PermisosDB_at_192_168_1_123_dbo_EMPLEADO";
        }
    }
}