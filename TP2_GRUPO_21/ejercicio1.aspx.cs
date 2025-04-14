using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Schema;

namespace TP2_GRUPO_21
{
    public partial class ejercicio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGenerarTabla_Click(object sender, EventArgs e)
        {

            string tabla = "<table border='1'>";

            tabla += "<tr><th>Producto</th><th>Cantidad</th></tr>";

            for (int i = 1; i <= 3; i++)
            {
                tabla += "<tr><td>&nbsp;</td><td>&nbsp;</td></tr>";
            }

            tabla += "</table>";

            litTabla.Text = tabla;
        }
    }
}