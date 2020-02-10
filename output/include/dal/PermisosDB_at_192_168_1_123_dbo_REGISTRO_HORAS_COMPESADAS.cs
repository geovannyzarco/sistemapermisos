using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_PermisosDB_at_192_168_1_123_dbo_REGISTRO_HORAS_COMPESADAS : tDALTable
    {
        public XVar id_compesados;
        public XVar ONI;
        public XVar fecha_compesado;
        public XVar hora_realizado_inicio;
        public XVar hora_realizado_fin;
        public XVar cantidad_horas_compesadas;
        public XVar justificacion;
        public XVar anexo;
        public XVar observacion;
        public XVar id_estado_compesado;
        public XVar vistobueno1;
        public XVar vistobueno2;
        public XVar desde;
        public XVar hasta;
        public XVar fecha_creacion;
        public static void Init()
        {
            XVar dalTableREGISTRO_HORAS_COMPESADAS = XVar.Array();
            dalTableREGISTRO_HORAS_COMPESADAS["id_compesados"] = new XVar("type", 3, "varname", "id_compesados");
            dalTableREGISTRO_HORAS_COMPESADAS["ONI"] = new XVar("type", 200, "varname", "ONI");
            dalTableREGISTRO_HORAS_COMPESADAS["fecha_compesado"] = new XVar("type", 7, "varname", "fecha_compesado");
            dalTableREGISTRO_HORAS_COMPESADAS["hora_realizado_inicio"] = new XVar("type", 134, "varname", "hora_realizado_inicio");
            dalTableREGISTRO_HORAS_COMPESADAS["hora_realizado_fin"] = new XVar("type", 134, "varname", "hora_realizado_fin");
            dalTableREGISTRO_HORAS_COMPESADAS["cantidad_horas_compesadas"] = new XVar("type", 3, "varname", "cantidad_horas_compesadas");
            dalTableREGISTRO_HORAS_COMPESADAS["justificacion"] = new XVar("type", 201, "varname", "justificacion");
            dalTableREGISTRO_HORAS_COMPESADAS["anexo"] = new XVar("type", 201, "varname", "anexo");
            dalTableREGISTRO_HORAS_COMPESADAS["observacion"] = new XVar("type", 201, "varname", "observacion");
            dalTableREGISTRO_HORAS_COMPESADAS["id_estado_compesado"] = new XVar("type", 3, "varname", "id_estado_compesado");
            dalTableREGISTRO_HORAS_COMPESADAS["vistobueno1"] = new XVar("type", 200, "varname", "vistobueno1");
            dalTableREGISTRO_HORAS_COMPESADAS["vistobueno2"] = new XVar("type", 200, "varname", "vistobueno2");
            dalTableREGISTRO_HORAS_COMPESADAS["desde"] = new XVar("type", 135, "varname", "desde");
            dalTableREGISTRO_HORAS_COMPESADAS["hasta"] = new XVar("type", 135, "varname", "hasta");
            dalTableREGISTRO_HORAS_COMPESADAS["fecha_creacion"] = new XVar("type", 135, "varname", "fecha_creacion");
	        dalTableREGISTRO_HORAS_COMPESADAS.InitAndSetArrayItem(true, "id_compesados", "key");
            GlobalVars.dal_info["PermisosDB_at_192_168_1_123_dbo_REGISTRO_HORAS_COMPESADAS"] = dalTableREGISTRO_HORAS_COMPESADAS;
        }

        public  dalTable_PermisosDB_at_192_168_1_123_dbo_REGISTRO_HORAS_COMPESADAS()
        {
            			this.m_TableName = "dbo.REGISTRO_HORAS_COMPESADAS";
            this.m_infoKey = "PermisosDB_at_192_168_1_123_dbo_REGISTRO_HORAS_COMPESADAS";
        }
    }
}