using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Tipocomentario
{
    public partial class Tipocomentario_CU_Detalle : System.Web.UI.UserControl
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
            var objeto = new SitioWeb.Controlador.ClassTipocomentario();
            var retSelect = SitioWeb.Controlador.SqlTipocomentario.SelectDataTable(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, objeto, out resultado);
            GridViewTable.DataSource = retSelect;
            GridViewTable.DataBind();
        }
    }
}





