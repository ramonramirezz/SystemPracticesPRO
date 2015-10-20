<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AltaAlumnos.aspx.cs" Inherits="PortalPracticas.AltaAlumnos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="css/Style2.css" rel="stylesheet" />
<script src="//code.jquery.com/jquery-1.11.3.min.js"></script>
<script src="//code.jquery.com/jquery-migrate-1.2.1.min.js"></script>
<script src="jquery-1.11.3.js"></script>
<script src="js/classie.js"></script>
<link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/css/bootstrap.min.css"/>
<script src="http://ajax.googleapis.com/ajax/libs/jquery/1.11.2/jquery.min.js"></script>
<script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/js/bootstrap.min.js"></script>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
  
    <form id="form1" runat="server">       
<%--     <asp:ScriptManager ID="ScriptManager1" runat="server">
                 </asp:ScriptManager>--%>
        <div>
    <div class="nav-bar">
             <asp:Panel ID="Nav" runat="server" Width="100%">

                 </asp:Panel>
         
         </div>
            <div class="formulario">
                <label>Expediente:</label>
                <asp:TextBox runat="server" ID="txExpediente"></asp:TextBox> <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" /><br/>
                <label>Nombre:</label>
                <asp:TextBox runat="server" ID="txNombre" Enabled="False" Width="150px"></asp:TextBox>
                <asp:Label id="labUsuario"  Visible="false" runat="server" Text="Usuario: "></asp:Label><asp:Label id="labUsu" visible="false" runat="server" Text=""></asp:Label>
                <br/>
                <label>Carrera:</label>
                <asp:TextBox runat="server" ID="txCarrera" Enabled="False" Width="150px"></asp:TextBox>
                <asp:Label id="labContraseña" Visible="false" Text="Contraseña: " runat="server"></asp:Label><asp:Label id="labCon" Visible="false" runat="server" Text=""></asp:Label><asp:Button ID="btnTerminar" runat="server" Text="Terminar" Visible="false" OnClick="btnTerminar_Click" /><br/>
                <label>Créditos:</label>
                <asp:TextBox runat="server" ID="txCreditos" Enabled="False" Width="150px"></asp:TextBox><br />
                <asp:Button ID="btnAlta" runat="server" Text="Alta" OnClick="btnAlta_Click" />
                <br/>
            </div>
               </div>
        <asp:GridView ID="Tabla" runat="server" Visible="False"></asp:GridView>
            </form>
            
      
  

   
     
      
  
</body>
</html>
