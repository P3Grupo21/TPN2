using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_GRUPO_21
{
    public partial class ejercicio5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListItemCollection memoriaItems = new ListItemCollection();
                memoriaItems.Add(new ListItem("2GB", "200"));
                memoriaItems.Add(new ListItem("4GB", "375"));
                memoriaItems.Add(new ListItem("6GB", "500"));

                ddlMemoria.DataSource = memoriaItems;
                ddlMemoria.DataTextField = "Text";
                ddlMemoria.DataValueField = "Value";
                ddlMemoria.DataBind();
            }
        }

        protected void btnCalcularPrecio_Click(object sender, EventArgs e)
        {

        }
    }
}