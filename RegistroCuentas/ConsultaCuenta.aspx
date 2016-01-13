<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultaCuenta.aspx.cs" Inherits="RegistroCuentas.ConsultaCuenta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Consulta de cuentas</title>
    <link rel = "stylesheet" href = "Estilos.css">
    
</head>
    
<body>
   
    <form id="form1" runat="server">
    <div>
        <a>
            <asp:DropDownList ID="ConsultaDropDownList" runat="server" style="margin-top: 0px">
                <asp:ListItem>CuentaId</asp:ListItem>
                <asp:ListItem>Descripcion</asp:ListItem>
                <asp:ListItem>Balance</asp:ListItem>
            </asp:DropDownList>
            <asp:TextBox ID="DatosTextBox" runat ="server"></asp:TextBox>
            <asp:Button ID="BuscarButton" runat="server" CssClass="btn" Text="Buscar" OnClick="BuscarButton_Click" />
       </a>
        <br /><br /><br />
            <asp:GridView ID ="ConsultaGridView" runat="server"></asp:GridView>
        
        
    </div>
    </form>
</body>
</html>
