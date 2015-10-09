using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PortalPracticas
{
    public partial class AltaAlumnos : System.Web.UI.Page
    {
        long expediente;
        string userName;
        string contraseña;
        public static BaseDatos bd = new BaseDatos();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            Menu nav_bar = new Menu(Nav);
            txExpediente.Focus();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
           expediente= Convert.ToInt64(txExpediente.Text);

            try
            {
                string nombre = bd.consulta_nombre(expediente);
                string carrera = bd.consulta_carrera(expediente);
                string cred = bd.consulta_creditos(expediente);
                txNombre.Text = nombre;
                txCarrera.Text = carrera;
                txCreditos.Text = cred;
            }
            catch (Exception ex) {
                txExpediente.Text = "";
                txExpediente.Focus();
                ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "tmp", "<script type='text/javascript'>alert('No se Encontró Expediente');</script>", false);
            }
            
            //DataSet datos = bd.consulta_alumno(expediente);
            //Tabla.DataSource = datos;
            //Tabla.DataBind();
            
            
            //bool stat = bd.probar_conexion();
           //txNombre.Text = Convert.ToString(estudiante.ElementAt(1));
        }

        protected void btnAlta_Click(object sender, EventArgs e)
        {
             userName = txExpediente.Text + "." + txCarrera.Text;
             contraseña = userName;
            labContraseña.Visible = true;
            labUsuario.Visible = true;
            labCon.Visible = true;
            labUsu.Visible = true;

            labCon.Text = contraseña;
            labUsu.Text = userName;

            btnTerminar.Visible = true;
            btnAlta.Visible = false;
           


        }

        protected void btnTerminar_Click(object sender, EventArgs e)
        {
            bool resp = bd.agregar_usuario(labUsu.Text, labCon.Text, 1);
            if (resp)
            {
                txCarrera.Text = "";
                txCreditos.Text = "";
                txExpediente.Text = "";
                txExpediente.Focus();
                labCon.Visible = false;
                labUsu.Visible = false;
                labContraseña.Visible = false;
                labUsuario.Visible = false;
                labCon.Text = "";
                labUsu.Text = "";
                labContraseña.Text = "";
                labUsuario.Text = "";
                userName = "";
                contraseña = "";
                txNombre.Text = "";
                btnTerminar.Visible = false;
                btnAlta.Visible = false;
                ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "tmp", "<script type='text/javascript'>alert('Se agrego el Usuario Exitosamente');</script>", false);
            }
            else {
                ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "tmp", "<script type='text/javascript'>alert('Error');</script>", false);
            }
           

        }
    }
}