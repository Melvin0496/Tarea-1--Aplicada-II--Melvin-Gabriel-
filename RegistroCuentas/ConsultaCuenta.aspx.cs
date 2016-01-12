using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BLL;

namespace RegistroCuentas
{
    public partial class ConsultaCuenta : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
        
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            Cuentas cuenta = new Cuentas();
            DataTable dataTable = new DataTable();
            string condicion;

                if (ConsultaDropDownList.SelectedIndex == 0)
                {
                    if (DatosTextBox.Text.Trim().Length == 0)
                    {
                        condicion = "1=1";
                    }
                    else
                    {
                        condicion = "CuentaId = " + DatosTextBox.Text;
                    }
                    dataTable = cuenta.Listado(" CuentaId, Descripcion, Balance", condicion, "");
                    ConsultaGridView.DataSource = dataTable;
                    ConsultaGridView.DataBind();
                }
            if (ConsultaDropDownList.SelectedIndex == 1)
            {
                if (DatosTextBox.Text.Trim().Length == 0)
                {
                    condicion = "2=2";
                }
                else
                {
                    condicion = string.Format("Descripcion = '{0}' ", DatosTextBox.Text);
                }
                dataTable = cuenta.Listado(" CuentaId, Descripcion, Balance", condicion, "");
                ConsultaGridView.DataSource = dataTable;
                ConsultaGridView.DataBind();

            }
            if (ConsultaDropDownList.SelectedIndex == 2)
            {
                if (DatosTextBox.Text.Trim().Length == 0)
                {
                    condicion = "3=3";
                }
                else
                {
                    condicion = string.Format("Balance = {0}", DatosTextBox.Text);
                }
                dataTable = cuenta.Listado(" CuentaId, Descripcion, Balance", condicion, "");
                ConsultaGridView.DataSource = dataTable;
                ConsultaGridView.DataBind();

            }
        }
    }
}
