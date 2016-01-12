using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace RegistroCuentas
{
    public partial class CuentasFaciles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void Limpiar()
        {
            CuentaIdTextBox.Text = "";
            DescripcionTextBox.Text = "";
            BalanceTextBox.Text = "";
        }
        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        public void LLenarDatos(Cuentas cuenta)
        {
            float balance;
            float.TryParse(BalanceTextBox.Text, out balance);
            cuenta.Descripcion = DescripcionTextBox.Text;
            cuenta.Balance = balance;
        }
        public int ConvertirId()
        {
            int id;
            int.TryParse(CuentaIdTextBox.Text, out id);
            return id;
        }
        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            Cuentas cuenta = new Cuentas();
            if (CuentaIdTextBox.Text.Length <= 0)
            {
                LLenarDatos(cuenta);
                if (cuenta.Insertar())
                {
                    HttpContext.Current.Response.Write("<SCRIPT>alert('Guardado Correctamente')</SCRIPT>");
                    Limpiar();
                    
                }
                else
                {
                    HttpContext.Current.Response.Write("<SCRIPT>alert('Error al Guardar')</SCRIPT>");
                }
            }
            else
            {
                cuenta.CuentaId = ConvertirId();
                LLenarDatos(cuenta);
                if (cuenta.Editar())
                {
                    HttpContext.Current.Response.Write("<SCRIPT>alert('Editado Correctamente')</SCRIPT>");
                    Limpiar();
                }
                else
                {
                    HttpContext.Current.Response.Write("<SCRIPT>alert('Error al editar')</SCRIPT>");
                    
                }
            }
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            Cuentas cuenta = new Cuentas();
            cuenta.CuentaId = ConvertirId();
            if (cuenta.Eliminar())
            {
                HttpContext.Current.Response.Write("<SCRIPT>alert('Datos eliminados')</SCRIPT>");
                Limpiar();
            }
            else
            {
                HttpContext.Current.Response.Write("<SCRIPT>alert('Error al eliminar')</SCRIPT>");
                
            }
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            Cuentas cuenta = new Cuentas();

            if (cuenta.Buscar(ConvertirId()))
            {
                DescripcionTextBox.Text = cuenta.Descripcion;
                BalanceTextBox.Text = cuenta.Balance.ToString();
            }
            else
            {
                HttpContext.Current.Response.Write("<SCRIPT>alert('Error al buscar)</SCRIPT>");
            }
        }

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {
            
        }
    }
}