using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConexionSAP
{
    public partial class Prueba_de_Conexion_SAP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (ConexionSAP.Open())
            {
                Linfo.Text = "Se ejecuto cuando la pagina se inicio";
                Linfo.Visible = true;

            }
        }

        protected void BtnConexion_Click(object sender, EventArgs e)
        {
            if (ConexionSAP.Open())
            {
                Linfo.Text = "Se conecto a SAP desde un boton";
                Linfo.Visible = true;
            }
        }
    }
}