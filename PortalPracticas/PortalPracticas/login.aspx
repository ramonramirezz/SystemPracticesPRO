<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="PortalPracticas.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/Style2.css" rel="stylesheet" />
    <title>Practicas Profesionales</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="nav-bar">
                <asp:Panel ID="Nav" runat="server" Width="100%"> </asp:Panel>   
          </div>
<div class="formulario">
               <asp:Label ID="Label1" runat="server" Text="Usuario: "></asp:Label>
                <asp:TextBox ID="usuario" runat="server" Class="form-control" placeholder="Usuario"   style="margin-left: 17.5px;"></asp:TextBox>
                <br /><br /><br />
               <asp:Label ID="Label2" runat="server" Text="Contraseña: "></asp:Label>
                <asp:TextBox ID="contra" type="Password" runat="server" Class="form-control" placeholder="Contraseña" ></asp:TextBox>
                <asp:Button ID="btnEnviar" runat="server" CssClass="form-control" Text="Entrar"  style="width:100px; margin-left: 300px;" BackColor="#0066FF" BorderColor="Black" ForeColor="White" OnClick="btnEnviar_Click1"  />                 
            </div>
    </div>
        <p>
                &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>