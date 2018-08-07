using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Sexo
{
    public partial class Sexo_CU_Detalle : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarGridView();
            }
        }

        protected void btnRefrescarGridview_Click(object sender, EventArgs e)
        {
            CargarGridView();
        }
        private void CargarGridView()
        {
            string resultado = "";
            var objeto = new SitioWeb.Controlador.ClassSexo();
            var retSelect = SitioWeb.Controlador.SqlSexo.Select(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, objeto, out resultado);
            GridViewTable.DataSource = retSelect;
            GridViewTable.DataBind();
        }
    }
}





