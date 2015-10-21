using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.IO;

namespace PortalPracticas
{
     public partial class AltaArchivo : System.Web.UI.Page
     {
          string carpeta;

          protected void Page_Load(object sender, EventArgs e)
          {
               Menu nav_bar = new Menu(Nav);
               this.llenarCombo();

               carpeta = Path.Combine(Request.PhysicalApplicationPath,"Reportes");
               
          }

          public void llenarCombo() { 
               ArrayList lista = new ArrayList();
               lista.Add("Carta");
               lista.Add("Reporte");
               cbTipo.DataSource = lista;
               DataBind();
          }

          protected void btSubir_Click(object sender, EventArgs e)
          {
               if (FileUp.PostedFile.FileName == "" )
               {
                    //Ni Seleccionaste ningun archivo
               }
               else
               {
                    //Verificar la extencion
                    string extencion = Path.GetExtension(FileUp.PostedFile.FileName);
                    //copiar archivo
                    switch(extencion.ToLower())
                    {
                              //validos
                         case ".pdf":
                         case ".docx":
                         break;

                              //No validos

                         default:
                              //mensaje  de extencion no valido
                         return;
                    }

                    try {
                         string archivo = Path.GetFileName(FileUp.PostedFile.FileName);
                         string carpeta_final = Path.Combine(carpeta, archivo);
                         FileUp.PostedFile.SaveAs(carpeta_final);

                         //Mensaje de extito

                    }
                    catch(Exception ex){
                        //mensaje de error
                    }
               }
          }



         


     }
}