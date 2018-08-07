using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Rol
{
    public partial class Rol_CU_MostrarUnico : System.Web.UI.UserControl
    {
	  public bool EsModal { get; set; } = false;

        protected void Page_Load(object sender, EventArgs e)
        {
		if (!IsPostBack)
            {
                LimpiarControlesSelect();
                CargaCombosFKSelect();
            }
        }
        protected void btnSelectRolMostrarModal_Click(object sender, EventArgs e)
        {
            CargarControlesSelect();
        }
        private void CargarControlesSelect()
        {
            var uidRol = txt_buscarSelectUIDRol.Text;

            string resultado = "";
            var retSelect = SitioWeb.Controlador.SqlRol.SelectFirst(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, uidRol, out resultado);
            LimpiarControlesSelect();
            SetControl_Class_Select(retSelect);
          if (EsModal == true)
            {
                ExecScriptModalSelect(true, "");
            }
        }

		        private void ExecScriptModalSelect(bool EsVisible, string mensajeRetorno)
        {
            string script = @"$('#Select-modal-default-Rol').modal('" + (EsVisible == true ? "show" : "hide") + "'); ";           
            ScriptManager.RegisterStartupScript(this, this.GetType(), Guid.NewGuid().ToString().Replace("-", ""), script, true);
        }

        private void SetControl_Class_Select(SitioWeb.Controlador.ClassRol c)
        {

           
			txt_uidrol_select.Text= c.uidrol;
			txt_rol_select.Text= c.rol;
			checkb_permisolectura_select.Checked= ClasesUtiles.Util.ConvertBoolNullToBool(c.permisolectura);
			checkb_permisoescritura_select.Checked= ClasesUtiles.Util.ConvertBoolNullToBool(c.permisoescritura);
			checkb_permisoconsultar_select.Checked= ClasesUtiles.Util.ConvertBoolNullToBool(c.permisoconsultar);
			checkb_perisocrear_select.Checked= ClasesUtiles.Util.ConvertBoolNullToBool(c.perisocrear);
			checkb_permisoeditar_select.Checked= ClasesUtiles.Util.ConvertBoolNullToBool(c.permisoeditar);
			checkb_permisoeliminar_select.Checked= ClasesUtiles.Util.ConvertBoolNullToBool(c.permisoeliminar);
			checkb_permisototal_select.Checked= ClasesUtiles.Util.ConvertBoolNullToBool(c.permisototal);
			checkb_permisonulo_select.Checked= ClasesUtiles.Util.ConvertBoolNullToBool(c.permisonulo);

        }

        private void LimpiarControlesSelect()
        {
		     
			txt_uidrol_select.Text = Guid.NewGuid().ToString();
			txt_rol_select.Text = "";
			checkb_permisolectura_select.Checked =false ;
			checkb_permisoescritura_select.Checked =false ;
			checkb_permisoconsultar_select.Checked =false ;
			checkb_perisocrear_select.Checked =false ;
			checkb_permisoeditar_select.Checked =false ;
			checkb_permisoeliminar_select.Checked =false ;
			checkb_permisototal_select.Checked =false ;
			checkb_permisonulo_select.Checked =false ;
        }

		  private void CargaCombosFKSelect()
        {
            string resultado = "";
			
        }

    }
}