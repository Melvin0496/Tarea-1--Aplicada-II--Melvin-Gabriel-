using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ConexionDb
    {
        private SqlConnection con;
        private SqlCommand cmd;

        public ConexionDb()
        {
            con = new SqlConnection("Data Source = JUNIOR-PC\\ROOT;Initial Catalog = CuentasFaciles;Integrated Security = true");
            cmd = new SqlCommand();
        }
        public bool Ejecutar(string ComandoSql)
        {
            bool retorno = false;
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = ComandoSql;
                cmd.ExecuteNonQuery();
                return retorno = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return retorno;
        }
        public DataTable ObtenerDatos(string ComandoSql)
        {
            SqlDataAdapter adapter;
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = ComandoSql;

                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return dt;
        }
    }
}
