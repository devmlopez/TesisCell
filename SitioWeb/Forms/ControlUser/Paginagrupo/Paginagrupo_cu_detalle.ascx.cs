using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Paginagrupo
{
    public partial class Paginagrupo_CU_Detalle : System.Web.UI.UserControl
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
            var objeto = new SitioWeb.Controlador.ClassPaginagrupo();
            var retSelect = SitioWeb.Controlador.SqlPaginagrupo.Select(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, objeto, out resultado);
            GridViewTable.DataSource = retSelect;
            GridViewTable.DataBind();
        }
    }
}





