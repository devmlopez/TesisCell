using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Empleado
{
    public partial class Empleado_CU_Detalle : System.Web.UI.UserControl
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
            var objeto = new SitioWeb.Controlador.ClassEmpleado();
            var retSelect = SitioWeb.Controlador.SqlEmpleado.Select(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, objeto, out resultado);
            GridViewTable.DataSource = retSelect;
            GridViewTable.DataBind();
        }
        protected void GridViewTable_DataBound(object sender, EventArgs e)
        {

            var gridview = (GridView)sender;
            bool PuedeEditar = ClasesUtiles.SessionClass.GetLoginUser(Page).ClassRol.permisoeditar.Value;
            bool PuedeEliminar = ClasesUtiles.SessionClass.GetLoginUser(Page).ClassRol.permisoeliminar.Value;
            bool PuedeVer = ClasesUtiles.SessionClass.GetLoginUser(Page).ClassRol.permisoconsultar.Value;

            foreach (GridViewRow row in gridview.Rows)
            {

                var btnGridVer = (LinkButton)row.FindControl("btnGridVer");
                var btnGridEditar = (LinkButton)row.FindControl("btnGridEditar");
                var btnGridEliminar = (LinkButton)row.FindControl("btnGridEliminar");

                btnGridVer.Visible = false;
                btnGridEditar.Visible = false;
                btnGridEliminar.Visible = false;

                if (PuedeVer == true)
                {
                    btnGridVer.Visible = true;
                }
                if (PuedeEditar == true)
                {
                    btnGridEditar.Visible = true;
                }
                if (PuedeEliminar == true)
                {
                    btnGridEliminar.Visible = true;
                }

            }

        }

    }
}





