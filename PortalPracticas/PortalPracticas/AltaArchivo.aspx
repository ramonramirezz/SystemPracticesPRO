<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AltaArchivo.aspx.cs" Inherits="PortalPracticas.AltaArchivo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link href="css/Style2.css" rel="stylesheet" />
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css"/>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js"></script>

    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
          <div class="nav-bar">
                <asp:Panel ID="Nav" runat="server" Width="100%"> </asp:Panel>   
          </div>
       
          <div class="container">
                <div class="row">
                     <div class="col-md-15">
                          <asp:Label ID="Label1" runat="server" Text="Subir archivos"></asp:Label>
                     </div>

                     <div class="form-group">
                       <div class="col-xs-9">
                          <asp:Label ID="Label2" runat="server" Text="Tipo"></asp:Label>
                          <asp:DropDownList ID="DropDownList1" CssClass="form-control" runat="server"></asp:DropDownList>
                       </div>
                     </div>

                     <div class="form-group">
                        <div class="col-xs-9">
                          <asp:Label ID="Label3" runat="server" Text="Archivo"></asp:Label>
                          <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server"></asp:TextBox>
                          <asp:Button ID="Button1" CssClass="form-control" runat="server" Text="Examinar" />
                        </div>
                     </div>

                     <div class="form-group">
                        <div class="col-md-9">
                           <asp:Button ID="Button2" CssClass="form-control" runat="server" Text="Aceptar" />
                        </div>
                     </div>

                </div>

          </div>
           
             
    </div>
    </form>
</body>
</html>
