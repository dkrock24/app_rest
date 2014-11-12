using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;

namespace Datos
{
    public class dbFactory
    {
        public enum TipoBases
        {
            Sql = 0,
            Excel = 1
        }

        private SqlCommand cmd;
        private SqlConnection cnn;
        private SqlDataReader dr;
        private DataTable dttable;

        private OleDbConnection odcnn;
        private OleDbCommand odcmd;
        private OleDbDataReader oddr;


        public string StrCnn { get; set; }

        public TipoBases TipoBase { get; set; }

        public dbFactory(string str, TipoBases tipb)
        {
            StrCnn = str;
            TipoBase = tipb;
        }
        public void DBWork(int dbt)
        {

        }

        public DataTable DevolverDataTableExcel(string Sql)
        {
            try
            {
                dttable = new DataTable();
                if (TipoBase == TipoBases.Sql)
                {
                    cnn = new SqlConnection(StrCnn);
                    cmd = cnn.CreateCommand();
                    cmd.CommandText = Sql;
                    cmd.CommandTimeout = 100000;
                    cnn.Open();
                    dr = cmd.ExecuteReader();
                    if (dr != null && dr.HasRows)
                    {
                        dttable.Load(dr);
                    }

                }
            }
            finally
            {
                cnn.Close();
            }
            return dttable;
        }

        /// <summary>
        /// Devuelve una datatable dado una consulta
        /// </summary>
        /// <param name="Sql">Consulta Sql</param>
        /// <returns></returns>
        public DataTable DevolverDataTable(string Sql)
        {
            try
            {
                dttable = new DataTable();
                if (TipoBase == TipoBases.Sql)
                {
                    cnn = new SqlConnection(StrCnn);
                    cmd = cnn.CreateCommand();
                    cmd.CommandText = Sql;
                    cmd.CommandTimeout = 100000;
                    cnn.Open();
                    dr = cmd.ExecuteReader();
                    if (dr != null && dr.HasRows)
                    {
                        dttable.Load(dr);
                    }

                }
                if (TipoBase == TipoBases.Excel)
                {
                    odcnn = new OleDbConnection(StrCnn);
                    odcmd = odcnn.CreateCommand();
                    odcmd.CommandText = Sql;
                    odcmd.CommandTimeout = 100000;
                    odcnn.Open();
                    oddr = odcmd.ExecuteReader();
                    if (oddr != null && oddr.HasRows)
                    {
                        dttable.Load(oddr);
                    }
                }

            }
            finally
            {
                if (TipoBase == TipoBases.Sql)
                {
                    cnn.Close();
                }
                if (TipoBase == TipoBases.Excel)
                {
                    odcnn.Close();
                }

            }
            return dttable;
        }
        /// <summary>
        /// Devuelve un DataTable basado en un procedimiento almacenado
        /// </summary>
        /// <param name="stprocnombre">Nombre del Procedimiento Almacenado</param>
        /// <param name="pcolec">Parametros del Procedimiento Almacenado</param>
        /// <returns></returns>
        public DataTable DevolverDataTable(string stprocnombre, List<SqlParameter> pcolec)
        {
            try
            {
                if (TipoBase == TipoBases.Sql)
                {
                    dttable = new DataTable();
                    cnn = new SqlConnection(StrCnn);
                    cmd = cnn.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = stprocnombre;
                    cmd.CommandTimeout = 100000;

                    // Agregando Parametros
                    if (pcolec != null)
                    {
                        for (int i = 0; i < pcolec.Count; i++)
                        {
                            cmd.Parameters.Add(pcolec[i]);
                        }
                    }
                    cnn.Open();
                    dr = cmd.ExecuteReader();
                    if (dr != null && dr.HasRows)
                    {
                        dttable.Load(dr);
                    }
                }
            }
            finally
            {
                cnn.Close();
            }
            return dttable;
        }
        public void EjecutarSentencia(string Sql)
        {
            try
            {
                if (TipoBase == TipoBases.Sql)
                {
                    cnn = new SqlConnection(StrCnn);
                    cmd = cnn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = Sql;
                    cmd.CommandTimeout = 100000;
                    cnn.Open();
                    cmd.ExecuteNonQuery();

                }
            }
            finally
            {

                cnn.Close();
            }
        }
        /// <summary>
        /// Ejecuta una sentencia Sql con parametros
        /// </summary>
        /// <param name="Sql"></param>
        /// <param name="pcolec"></param>
        public void EjecutarSentencia(string Sql, List<SqlParameter> pcolec)
        {
            try
            {
                if (TipoBase == TipoBases.Sql)
                {
                    cnn = new SqlConnection(StrCnn);
                    cmd = cnn.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = Sql;
                    cmd.CommandTimeout = 100000;
                    // Agregando Parametros

                    if (pcolec != null)
                    {
                        for (int i = 0; i < pcolec.Count; i++)
                        {
                            cmd.Parameters.Add(pcolec[i]);
                        }
                    }
                    cnn.Open();
                    cmd.ExecuteNonQuery();

                }


            }
            finally
            {

                cnn.Close();

            }
        }

        public int EjecutarSentenciabyId(string Sql, List<SqlParameter> pcolec)
        {
            try
            {
                if (TipoBase == TipoBases.Sql)
                {
                    cnn = new SqlConnection(StrCnn);
                    cmd = cnn.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = Sql;
                    cmd.CommandTimeout = 100000;
                    // Agregando Parametros

                    if (pcolec != null)
                    {
                        foreach (SqlParameter t in pcolec)
                        {
                            cmd.Parameters.Add(t);
                        }
                        //cmd.Parameters.Add(new SqlParameter("?idgenerado", SqlDbType.Int64));
                    }
                    cnn.Open();

                    return Convert.ToInt32(cmd.ExecuteScalar());

                }


            }
            finally
            {

                cnn.Close();


            }
            return 0;
        }

        public void EjecutarSentenciaSP(string Sql)
        {
            try
            {
                if (TipoBase == TipoBases.Sql)
                {
                    cnn = new SqlConnection(StrCnn);
                    cmd = cnn.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = Sql;
                    cmd.CommandTimeout = 100000;
                    cnn.Open();
                    cmd.ExecuteNonQuery();

                }


            }
            finally
            {
                cnn.Close();
            }
        }
    }
}
