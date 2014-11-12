using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;

namespace Datos
{
    public abstract class aBase
    {
        private static dbFactory DBA;
        protected static string sql;
        protected static Type BusTipoObjeto;
        protected static dbFactory.TipoBases TipoBas;
        protected static string StrConec;
        protected static aBase to;
        protected static List<SqlParameter> lp = new List<SqlParameter>();
        public static string SQL { get { return sql; } set { sql = value; } }
        public static void BaseUtil(ConnectionContext.Datos basedato, dbFactory.TipoBases tipobase, Object objeto)
        {
            var c = new ConnectionContext();
            c.SetearBase(basedato);
            StrConec = c.CadenaConexion;
            TipoBas = tipobase;
            BusTipoObjeto = objeto.GetType();
            to = (aBase)objeto;
        }
        public static void BaseUtil(ConnectionContext.Datos basedato, dbFactory.TipoBases tipobase, Object objeto, string strcnn)
        {
            var c = new ConnectionContext { CadenaConexion = strcnn };
            c.SetearBase(basedato);
            StrConec = c.CadenaConexion;
            TipoBas = tipobase;
            BusTipoObjeto = objeto.GetType();
            to = (aBase)objeto;
        }

        public static List<aBase> LoadData()
        {
            DBA = new dbFactory(StrConec, TipoBas);
            var _lista = new List<aBase>();
            DataTable dtObjetoNegocio = lp.Count > 0 ? DBA.DevolverDataTable(sql, lp) : DBA.DevolverDataTable(sql);
            object[] atributos = BusTipoObjeto.GetCustomAttributes(typeof(Map), false);
            /*if (sql == "SELECT * FROM periodopagodetalle WHERE id_periodopago=3 AND dia_laborado=1 AND id_rutina_ppd=6 AND cod_duralita_ppd='10-02'") {
                var x = "ESTE ES EL PROBLEMA";
            }*/
            if (dtObjetoNegocio != null && dtObjetoNegocio.Rows.Count > 0)
            {
                for (int i = 0; i < dtObjetoNegocio.Rows.Count; i++)
                {
                    var busObjeto = (aBase)Activator.CreateInstance(BusTipoObjeto);
                    for (int j = 0; j < atributos.Length; j++)
                    {
                        var mapeador = (Map)atributos[j];
                        object DBValor = dtObjetoNegocio.Rows[i][mapeador.CampoTabla];
                        PropertyInfo pinfo = BusTipoObjeto.GetProperty(mapeador.PropiedadClase);
                        pinfo.SetValue(busObjeto, DBValor.GetType() == typeof(DBNull) ? null : DBValor, null);
                    }
                    _lista.Add(busObjeto);
                }
            }
            DBA = null;
            return _lista;
        }
        /// <summary>
        /// Crear un registro.
        /// </summary>
        public static void Guardar()
        {
            DBA = new dbFactory(StrConec, TipoBas);
            object[] atributos = BusTipoObjeto.GetCustomAttributes(typeof(Map), false);
            var lpc = new List<SqlParameter>();
            for (int i = 0; i < atributos.Length; i++)
            {
                var mapeador = (Map)atributos[i];
                PropertyInfo pinfo = BusTipoObjeto.GetProperty(mapeador.PropiedadClase);
                object DBValor = pinfo.GetValue(to, null);
                var p = new SqlParameter("@" + mapeador.CampoTabla, DBValor);
                lpc.Add(p);
            }
            DBA.EjecutarSentencia("Guardar_" + BusTipoObjeto.Name, lpc);

        }
        public static int GuardarbyEntidad()
        {
            DBA = new dbFactory(StrConec, TipoBas);
            object[] atributos = BusTipoObjeto.GetCustomAttributes(typeof(Map), false);
            var lpc = new List<SqlParameter>();
            for (int i = 0; i < atributos.Length; i++)
            {
                var mapeador = (Map)atributos[i];
                PropertyInfo pinfo = BusTipoObjeto.GetProperty(mapeador.PropiedadClase);
                object DBValor = pinfo.GetValue(to, null);
                var p = new SqlParameter("@" + mapeador.CampoTabla, DBValor);
                lpc.Add(p);
            }
            return DBA.EjecutarSentenciabyId("Guardar_" + BusTipoObjeto.Name, lpc);

        }
        /// <summary>
        /// Actualizar Registro
        /// </summary>
        public static void Actualizar()
        {
            DBA = new dbFactory(StrConec, TipoBas);
            object[] atributos = BusTipoObjeto.GetCustomAttributes(typeof(Map), false);
            var lpc = new List<SqlParameter>();
            for (int i = 0; i < atributos.Length; i++)
            {
                var mapeador = (Map)atributos[i];
                PropertyInfo pinfo = BusTipoObjeto.GetProperty(mapeador.PropiedadClase);
                object DBValor = pinfo.GetValue(to, null);
                var p = new SqlParameter("@" + mapeador.CampoTabla, DBValor);
                lpc.Add(p);
            }
            DBA.EjecutarSentencia("Actualizar_" + BusTipoObjeto.Name, lpc);
        }
        /// <summary>
        /// Eliminar un registro
        /// </summary>
        public static void Eliminar()
        {
            DBA = new dbFactory(StrConec, TipoBas);
            object[] atributos = BusTipoObjeto.GetCustomAttributes(typeof(Map), false);
            var lpc = new List<SqlParameter>();
            for (int i = 0; i < atributos.Length; i++)
            {
                var mapeador = (Map)atributos[i];
                PropertyInfo pinfo = BusTipoObjeto.GetProperty(mapeador.PropiedadClase);
                object DBValor = pinfo.GetValue(to, null);
                var p = new SqlParameter("@" + mapeador.CampoTabla, DBValor);
                lpc.Add(p);
            }
            DBA.EjecutarSentencia("Eliminar_" + BusTipoObjeto.Name, lpc);
        }
        /// <summary>
        /// Ejecuta una sentencia Sql 
        /// </summary>
        public static void EjecutarSql()
        {
            DBA = new dbFactory(StrConec, TipoBas);
            DBA.EjecutarSentencia(sql);
        }
        /// <summary>
        /// Ejecuta un Procedimiento Almacenado
        /// </summary>
        /// <param name="lpr"> Lista de Paramtros Tipo SqlParameter</param>
        public static void EjecutarSP(List<SqlParameter> lpr)
        {
            DBA = new dbFactory(StrConec, TipoBas);
            DBA.EjecutarSentencia(sql, lpr);

        }
        public static void EjecutarSP()
        {
            DBA = new dbFactory(StrConec, TipoBas);
            DBA.EjecutarSentenciaSP(sql);
            DBA = null;
        }

        public static DataTable DevolverTabla()
        {
            DBA = new dbFactory(StrConec, TipoBas);
            DataTable dtObjetoNegocio = lp.Count > 0 ? DBA.DevolverDataTable(sql, lp) : DBA.DevolverDataTable(sql);
            return dtObjetoNegocio;
        }
    }
}
