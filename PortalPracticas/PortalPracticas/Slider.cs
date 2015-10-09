using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace PortalPracticas
{
    public class Slider
    {
         public Slider(Panel nav) {
            nav.Controls.Add(navbar());
        }
        public Literal navbar()
        {
            Literal nav = new Literal();

            nav.Text =  "<nav class='cbp-spmenu cbp-spmenu-vertical cbp-spmenu-left' id='cbp-spmenu-s1'>"
                        +"<h3><a href='#'>Menu</a></h3>"
                        +"<a href='#'>Alta Alumnos</a>"
                        +"<a href='#'>Alta Archivos</a>"
                        +"<a href='#'>Alta Responsable</a>"
                        +"<a href='#'>Consulta Alumnos</a>"
                        +"</nav>";
            return nav;
        }
        
    }

    }
