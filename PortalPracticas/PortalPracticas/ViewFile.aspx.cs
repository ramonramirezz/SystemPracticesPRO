using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PortalPracticas
{
     public partial class ViewFile : System.Web.UI.Page
     {
          protected void Page_Load(object sender, EventArgs e)
          {
               Menu nav_bar = new Menu(Nav);

               lb01.Visible = false;
               lb02.Visible = false;
               lb03.Visible = false;
               lbArchivos.Visible = false;
               txtAlumnos.Text = null;
               txtCarrera.Text = null;
               txtCreditos.Text = null;
          }

          protected void btAceptar_Click(object sender, EventArgs e)
          {

               if (txtExpediente.Text.Equals("212208557"))
               {
                    lb01.Visible = true;
                    lb02.Visible = true;
                    lb03.Visible = true;
                    lbArchivos.Visible = true;

                    txtAlumnos.Text = "Ramon Ramirez Preciado";
                    txtCarrera.Text = "Ing. Sistemas de Informacion";
                    txtCreditos.Text = "278";
               }
               else
               {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "tmp", "alert('No se encontro alumno')", true);
               }


          }



     }
}