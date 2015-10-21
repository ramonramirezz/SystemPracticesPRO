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
    <form id="form1" runat="server" class="form-horizontal" enctype="multipart/form-data" method="post">
    <div>
          <div class="nav-bar">
                <asp:Panel ID="Nav" runat="server" Width="100%"> </asp:Panel>   
          </div>
       
          <div class="container">
                <div class="row">
                    
                     <div class="form-group">
                          <asp:Label  ID="Label1" runat="server" CssClass="control-label col-md-6" Text="Subir archivos" ></asp:Label>
                     </div>

                     <div class="form-group">                     
                          <asp:Label ID="Label2" runat="server" CssClass="control-label col-md-4" Text="Tipo"></asp:Label>

                          <div class="col-md-4">
                               <asp:DropDownList ID="cbTipo" CssClass="form-control" runat="server"></asp:DropDownList>                       

                          </div>
                     </div>
                     

                     <div class="form-group">
                       
                          <asp:Label ID="Label3" runat="server" CssClass="control-label col-md-4" Text="Archivo"></asp:Label>

                          <div class="col-md-4">
                          <%--<asp:TextBox ID="File" CssClass="form-control" Type="file" runat="server" placeholder="Archivo"></asp:TextBox>--%> 
                               
                               <asp:FileUpload ID="FileUp" runat="server" CssClass="form-control" />   <br />

                          <%--<asp:Button ID="btExaminar" class="btn btn-primary" runat="server" Text="Examinar" OnClick="btExaminar_Click" />--%>

                          </div>

                        
                     </div>
                     
                     <div class="form-group">   
                          <div class="col-md-2 col-md-offset-7">
                               <asp:Button ID="btSubir" class="btn btn-primary" runat="server" Text="Aceptar" OnClick="btSubir_Click"  />  
                          </div>                   
                     
                     </div>

                </div>

          </div>
           
             
    </div>
    </form>
</body>
</html>
