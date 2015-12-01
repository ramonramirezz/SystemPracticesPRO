<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewFile.aspx.cs" Inherits="PortalPracticas.ViewFile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <link href="css/Style2.css" rel="stylesheet" />
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css"/>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div >
          <div class="nav-bar">
                <asp:Panel ID="Nav" runat="server" Width="100%"> </asp:Panel>   
          </div>

         <div class="container">
         <div class="row">


                 <div class="form-group">                     
                          <asp:Label ID="Label2" runat="server" >Expediente</asp:Label>
                      
                                <asp:TextBox runat="server" ID="txtExpediente" CssClass="form-control"  ></asp:TextBox>                     
                          
                    </div>
   

                     <div class="form-group">   
                         
                               <asp:Button ID="btAceptar" class="btn btn-primary" runat="server" Text="Aceptar" OnClick="btAceptar_Click"  />  
                                             
                     
                     </div>
             
              <div id="invisible">
                    <div class="form-group">                     
                          <asp:Label ID="Label5" runat="server" >ALumno</asp:Label>
                          
                                <asp:TextBox runat="server" ID="txtAlumnos" CssClass="form-control" Enabled="False" ></asp:TextBox>                     
                          
                    </div>

                    <div class="form-group">                     
                          <asp:Label ID="Label6" runat="server" >Carrera</asp:Label>
                          
                                <asp:TextBox runat="server" ID="txtCarrera" CssClass="form-control" Enabled="False" ></asp:TextBox>                     
                          
                    </div>


                    <div class="form-group">                     
                          <asp:Label ID="Label7" runat="server" >Creditos</asp:Label>
                         
                                <asp:TextBox runat="server" ID="txtCreditos" CssClass="form-control" Enabled="False" ></asp:TextBox>                     
                          
                    </div>
                   
                   <div class="form-group">                     
                          <asp:Label ID="lbArchivos" runat="server" >Archivos</asp:Label>
                                          
                          
                    </div>

                     <div class="form-group">                     
                          <a href="Reportes/sofe.pdf" target="_blank"><asp:Label ID="lb01" runat="server" >FPP-01</asp:Label></a>

                           </div>
                   <br />
                     <div class="form-group">                     
                          <a href="Reportes/Encuesta Preliminar Cuidador ver 3.doc" target="_blank"><asp:Label ID="lb02" runat="server" >FPP-02</asp:Label></a>

                           </div>
              
                      <div class="form-group">                     
                         <a> <asp:Label ID="lb03" runat="server" >FPP-03 (No encontrado)</asp:Label></a>

                           </div>

                   </div> 
              </div>



          </div>
    </div>

    </form>
</body>
</html>
