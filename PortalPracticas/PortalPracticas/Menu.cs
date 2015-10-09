using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace PortalPracticas
{
    public class Menu
    {
        public Menu(Panel nav) {
            nav.Controls.Add(navbar());
        }
        public Literal navbar()
        {
            Literal nav = new Literal();

            nav.Text =

                        "<div class='cabecera'>"
                + "<img id='FondoCab'  style='width:100%; position:absolute; max-height:90'>" + "<a><img src='imagenes/logo uni.png' id='loguito'></a>"
                + "<a><label id='TituloSis' >Portal Practicas</label></a>"
                + "<ul id='referencias'>"
                + "<li><a href='#'>Inicio</a></li>"
                + "<li><a href='#'>Salida</a></li>"
                + "</ul>"

                + "</div>"
            +"<div>"
                +"<nav class='cbp-spmenu cbp-spmenu-vertical cbp-spmenu-left' id='cbp-spmenu-s1'>"
                    + "<h3><a href='#'>Menu</a></h3>"
                    + "<a href='#'>Alta Alumnos</a>"
                    + "<a href='#'>Alta Archivos</a>"
                    + "<a href='#'>Alta Responsable</a>"
                    + "<a href='#'>Consulta Alumnos</a>"
                    + "</nav>"
                    +"</div>";
                
               

            return nav;
        }
        
    }
}