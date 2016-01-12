<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CuentasFaciles.aspx.cs" Inherits="RegistroCuentas.CuentasFaciles" %>

<!DOCTYPE html>
 <html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cuentas Faciles</title>
   
    <link rel = "stylesheet" href = "Estilos.css">
    <style type="text/css">
        .btn {
            margin-left: 65px;
       }
    </style>
    
</head>
<body>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <a href = "ConsultaCuenta.aspx"> Consulta </a>
    <form id="Cuentasform" runat="server">
    <div>
        <p>
        &nbsp;<asp:Label ID="Label1" runat="server" Text="CuentaId:"></asp:Label><asp:TextBox ID="CuentaIdTextBox" runat="server" TextMode="Number" style="margin-left: 23px" Width="219px" BorderStyle="Groove"></asp:TextBox>
            <asp:Button ID="BuscarButton" runat="server" style="margin-left: 8px; margin-right: 15px; margin-top: 0px" Text="Buscar" Width="70px" OnClick="BuscarButton_Click" Height="20px" />
            <br /><br />
            <asp:Label ID="Label2" runat="server" Text="Descripcion:"></asp:Label><asp:TextBox ID="DescripcionTextBox" CssClass ="form-control" runat="server" style="margin-left: 7px" Width="301px" BorderStyle="Groove"></asp:TextBox><br /><br />
            <asp:Label ID="Label3" runat="server" Text="Balance:"></asp:Label><asp:TextBox ID="BalanceTextBox" runat="server" CssClass ="form-control" TextMode="Number" style="margin-left: 34px" Width="300px" BorderStyle="Groove" ></asp:TextBox><br /><br />
            
            <asp:Button Text ="Nuevo" runat="server" ID ="NuevoButton" CssClass ="btn" OnClick ="NuevoButton_Click" Width="70px"/>
            <asp:Button Text ="Guardar" runat="server" ID="GuardarButton" CssClass ="btn" OnClick="GuardarButton_Click" />
            <asp:Button Text ="Eliminar" runat="server" ID="EliminarButton" CssClass ="btn" OnClick="EliminarButton_Click" />
        </p>
    </div>
    </form>
</body>
</html>
