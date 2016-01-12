using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Cuentas : ClaseMaestra
    {
        public int CuentaId { get; set; }
        public string Descripcion { get; set; }
        public float Balance { get; set; }

        public Cuentas()
        {
            CuentaId = 0;
            Descripcion = "";
            Balance = 0.0f;
        }
        public Cuentas(int cuentaId, string descripcion, float balance)
        {
            this.CuentaId = cuentaId;
            this.Descripcion = descripcion;
            this.Balance = balance;
        }

        public override bool Insertar()
        {
            bool retorno = false;
            ConexionDb conexion = new ConexionDb();

            retorno = conexion.Ejecutar(string.Format("Insert into Cuentas(Descripcion,Balance) values('{0}',{1})", this.Descripcion, this.Balance));

            return retorno;
        }

        public override bool Editar()
        {
            bool retorno = false;
            ConexionDb conexion = new ConexionDb();

            retorno = conexion.Ejecutar(string.Format("Update Cuentas set Descripcion = '{0}', Balance = {1} where CuentaId = {2}",this.Descripcion,this.Balance,this.CuentaId));

            return retorno;
        }

        public override bool Buscar(int idBuscado)
        {
            DataTable dt = new DataTable();
            ConexionDb conexion = new ConexionDb();
            dt = (conexion.ObtenerDatos(String.Format("Select CuentaId, Descripcion, Balance From Cuentas where CuentaId = {0}", idBuscado)));
            if (dt.Rows.Count > 0)
            {
                this.CuentaId = (int)dt.Rows[0]["CuentaId"];
                this.Descripcion = dt.Rows[0]["Descripcion"].ToString();
                this.Balance = Convert.ToSingle(dt.Rows[0]["Balance"]);
            }
            return dt.Rows.Count > 0;
        }

        public override bool Eliminar()
        {
            bool retorno = false;
            ConexionDb conexion = new ConexionDb();

            retorno = conexion.Ejecutar(string.Format("Delete Cuentas where CuentaId = {0}",this.CuentaId));

            return retorno;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            ConexionDb conexion = new ConexionDb();
            string ordenFinal = "";
            if (!Orden.Equals(""))
                ordenFinal = " Orden by  " + Orden;

            return conexion.ObtenerDatos("Select " + Campos +
                " From Cuentas Where " + Condicion + "" + ordenFinal);
        }
    }
}
