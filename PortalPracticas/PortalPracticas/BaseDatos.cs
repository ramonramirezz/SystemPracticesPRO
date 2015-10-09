using System;
using System.Collections;
using System.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Data.Sql;

namespace PortalPracticas
{
    public class BaseDatos
    {
        static string strCon = "Data Source=.\\SQLExpress;Integrated Security=true;Initial Catalog=estudiantes";
        SqlConnection con = new SqlConnection(strCon);
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        

        public string consulta_carrera (long expediente) {
            string resultado;
            
            con.Open();
            
            cmd = new SqlCommand("SELECT carrera FROM alumnos WHERE expediente=" + expediente,con);
            resultado = Convert.ToString(cmd.ExecuteScalar());
          
           con.Close();
           return resultado;
        }
        public string consulta_nombre(long expediente)
        {
            string resultado;
                con.Open();        
                cmd = new SqlCommand("SELECT nombre_alumno FROM alumnos WHERE expediente=" + expediente, con);
                resultado = Convert.ToString(cmd.ExecuteScalar());
                con.Close();
                return resultado;                                  
        }
        public string consulta_creditos(long expediente)
        {
            string resultado;

            con.Open();

            cmd = new SqlCommand("SELECT creditos_aprobados FROM alumnos WHERE expediente=" + expediente, con);
            resultado = Convert.ToString(cmd.ExecuteScalar());

            con.Close();
            return resultado;
        }
        public bool agregar_usuario(string Name,string password,int tipo) {
            bool status = false;
            using (cmd = new SqlCommand("Insert into usuarios (nombreUsuario,contraseña,tipo) values(@userName,@password,@tipo)",con)) {
                cmd.Parameters.AddWithValue("@userName", Name);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@tipo", Convert.ToInt32(tipo));
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                status = true;
            }
            return status;
        }

    }

   
}