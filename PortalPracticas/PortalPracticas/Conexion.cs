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
    public class Conexion
    {
        static string strcon = "Data Source=.\\SQLExpress;Integrated Security=true;Initial Catalog=bdpracticas";
        //static string strcon = "Data Source=.DELL-61000-06\\usuario;Integrated Security=true;User Instance=true;Initial Catalog=bdpracticas";
        SqlConnection con = new SqlConnection(strcon);
        SqlConnection con2 = new SqlConnection(strcon);
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;

        string str;
        object obj;
        public Conexion()
        {


        }
        public bool login(string user, string contra)
        {
            bool resp;
            con.Open();
            str = "select count(*) from usuarios where nombre_usuario=@UserName and password =@Password";
            cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@UserName", user);
            cmd.Parameters.AddWithValue("@Password", contra);
            obj = cmd.ExecuteScalar();
            if (Convert.ToInt32(obj) != 0)
            {
                resp = true;
            }
            else
            {
                resp = false;
            }
            con.Close();
            return resp;
        }
    }
}