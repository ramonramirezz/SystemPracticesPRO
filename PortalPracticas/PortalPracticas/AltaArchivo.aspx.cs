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
          BaseDatos bd = new BaseDatos();
          protected void Page_Load(object sender, EventArgs e)
          {
               Menu nav_bar = new Menu(Nav);
               this.llenarCombo();

              // carpeta = Path.Combine(Request.PhysicalApplicationPath,"Reportes");
               
          }

          public void llenarCombo() { 
               ArrayList lista = new ArrayList();
               lista.Add("FPP-01");
               lista.Add("FPP-02");
               lista.Add("FPP-03");
               cbTipo.DataSource = lista;
               DataBind();
          }

          protected void btSubir_Click(object sender, EventArgs e)
          {
               if (FileUp.PostedFile.FileName == "" )
               {
                    //No Seleccionaste ningun archivo
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "tmp", "alert('No se a seleccionado ningun archivo')", true);
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
                         ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "tmp", "alert('Archivo no valido, solo se permiten PDF y DOCX')", true);
                         return;
                    }

                    try {
                         //string archivo = Path.GetFileName(FileUp.PostedFile.FileName);
                         //string carpeta_final = Path.Combine(carpeta, archivo);
                         //FileUp.PostedFile.SaveAs(carpeta_final);


                         string ruta = Server.MapPath("~/Reportes/") + FileUp.FileName;

                        bool status = bd.AddFile(ruta, 212208557, cbTipo.SelectedItem.ToString());

                         if(status){
                              FileUp.PostedFile.SaveAs(ruta);
                              //Mensaje de extito
                              ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "tmp", "alert('Se subio con exito su archivo')", true);
                         }
                         else
                         {
                              ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Error al subir')", true);
                         }

                         



                         

                    }
                    catch(Exception ex){
                        //mensaje de error
                         ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Error al subir' "+ex.ToString()+")", true);
                    }
               }
          }



         


     }
}