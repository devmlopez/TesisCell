using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Rol
{
    public partial class Rol_CU_Update : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
		 if (!IsPostBack)
            {
                LimpiarControlesEditar();
                CargaCombosFKUpdate();
            }
		
        }
        private void LimpiarControlesEditar()
        {
           
			txt_uidrol_update.Text = Guid.NewGuid().ToString();
			txt_rol_update.Text = "";
			checkb_permisolectura_update.Checked =false ;
			checkb_permisoescritura_update.Checked =false ;
			checkb_permisoconsultar_update.Checked =false ;
			checkb_perisocrear_update.Checked =false ;
			checkb_permisoeditar_update.Checked =false ;
			checkb_permisoeliminar_update.Checked =false ;
			checkb_permisototal_update.Checked =false ;
			checkb_permisonulo_update.Checked =false ;
            lblMensajeError_update.Text = "";
        }
        private void GuardarEditar()
        {
            string resultado = "";
            var objeto = GetClass_Control_Edit();
            if (Controlador.SqlRol.ValidarCamposNulos(objeto).Count() == 0)
            {
                SitioWeb.Controlador.SqlRol.Update(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, objeto, out resultado);
            }
            else
            {
                resultado = "ERROR||Existen campos obligatorios que llenar";
            }
            lblMensajeError_update.Text = resultado;

            if ((resultado + "|").Split('|')[0].Equals("OK"))
            {
                ExecScriptModalUpdate(false, resultado, true);
                LimpiarControlesEditar();
            }
            else
            {
                ExecScriptModalUpdate(true, resultado, true);
            }
        }

        private void ExecScriptModalUpdate(bool EsVisible, string mensajeRetorno, bool EsPorGuardar)
        {
            string typeMsg = (mensajeRetorno + "|").Split('|')[0];
            string CodigoErrorMsg = ((mensajeRetorno + "|").Split('|').Count() >= 2 ? (mensajeRetorno + "|").Split('|')[1] : "");
            string mesajeMsg = ((mensajeRetorno + "|").Split('|').Count() >= 3 ? (mensajeRetorno + "|").Split('|')[2] : "");
            string script = @"$('#Update-modal-default').modal('" + (EsVisible == true ? "show" : "hide") + "'); ";
            if (EsPorGuardar)
            {
                script += " ShowMessage('','" + CodigoErrorMsg + "', '" + mesajeMsg + "', '" + typeMsg + "')";
            }
            ScriptManager.RegisterStartupScript(this, this.GetType(), Guid.NewGuid().ToString().Replace("-", ""), script, true);
        }
        private SitioWeb.Controlador.ClassRol GetClass_Control_Edit()
        {
            var c = new SitioWeb.Controlador.ClassRol();
             
				 c.uidrol= ClasesUtiles.Util.ConvertStringToStringNull(txt_uidrol_update.Text);
				 c.rol= ClasesUtiles.Util.ConvertStringToStringNull(txt_rol_update.Text);
				 c.permisolectura= checkb_permisolectura_update.Checked;
				 c.permisoescritura= checkb_permisoescritura_update.Checked;
				 c.permisoconsultar= checkb_permisoconsultar_update.Checked;
				 c.perisocrear= checkb_perisocrear_update.Checked;
				 c.permisoeditar= checkb_permisoeditar_update.Checked;
				 c.permisoeliminar= checkb_permisoeliminar_update.Checked;
				 c.permisototal= checkb_permisototal_update.Checked;
				 c.permisonulo= checkb_permisonulo_update.Checked;
            return c;
        }
        private void SetControl_Class_Edit(SitioWeb.Controlador.ClassRol c)
        {

           
			txt_uidrol_update.Text= c.uidrol;
			txt_rol_update.Text= c.rol;
			checkb_permisolectura_update.Checked= ClasesUtiles.Util.ConvertBoolNullToBool(c.permisolectura);
			checkb_permisoescritura_update.Checked= ClasesUtiles.Util.ConvertBoolNullToBool(c.permisoescritura);
			checkb_permisoconsultar_update.Checked= ClasesUtiles.Util.ConvertBoolNullToBool(c.permisoconsultar);
			checkb_perisocrear_update.Checked= ClasesUtiles.Util.ConvertBoolNullToBool(c.perisocrear);
			checkb_permisoeditar_update.Checked= ClasesUtiles.Util.ConvertBoolNullToBool(c.permisoeditar);
			checkb_permisoeliminar_update.Checked= ClasesUtiles.Util.ConvertBoolNullToBool(c.permisoeliminar);
			checkb_permisototal_update.Checked= ClasesUtiles.Util.ConvertBoolNullToBool(c.permisototal);
			checkb_permisonulo_update.Checked= ClasesUtiles.Util.ConvertBoolNullToBool(c.permisonulo);

        }
        protected void btnGuardarEditar_Click(object sender, EventArgs e)
        {
            GuardarEditar();
        }

        protected void btnUpdateRolMostrarModal_Click(object sender, EventArgs e)
        {
            CargarControlesEditar();
        }
        private void CargarControlesEditar()
        {
            var uidRol = txt_buscarUpdateUIDRol.Text;

            string resultado = "";
            var retSelect = SitioWeb.Controlador.SqlRol.SelectFirst(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, uidRol, out resultado);
            LimpiarControlesEditar();
            SetControl_Class_Edit(retSelect);
            ExecScriptModalUpdate(true, "", false);
        }
		  private void CargaCombosFKUpdate()
        {
            string resultado = "";
			
        }


    }
}