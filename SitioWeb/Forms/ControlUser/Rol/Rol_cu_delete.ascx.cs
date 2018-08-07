using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Rol
{
    public partial class Rol_CU_Delete : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
		 if (!IsPostBack)
            {
                LimpiarControlesDelete();
                CargaCombosFKDelete();
            }
        }      
        private void ExecScriptModalDelete(bool EsVisible, string mensajeRetorno, bool EsPorGuardar)
        {
            string typeMsg = (mensajeRetorno + "|").Split('|')[0];
            string CodigoErrorMsg = ((mensajeRetorno + "|").Split('|').Count() >= 2 ? (mensajeRetorno + "|").Split('|')[1] : "");
            string mesajeMsg = ((mensajeRetorno + "|").Split('|').Count() >= 3 ? (mensajeRetorno + "|").Split('|')[2] : "");
            string script = @"$('#Delete-modal-default').modal('" + (EsVisible == true ? "show" : "hide") + "'); ";
            if (EsPorGuardar)
            {
                script += " ShowMessage('','" + CodigoErrorMsg + "', '" + mesajeMsg + "', '" + typeMsg + "')";
            }
            ScriptManager.RegisterStartupScript(this, this.GetType(), Guid.NewGuid().ToString().Replace("-", ""), script, true);
        }
        private void GuardarElimina()
        {
            string resultado = "";
            var objeto = new Controlador.ClassRol()
            {
			  
                uidrol =  txt_buscarDeleteUIDRol.Text
            };
            SitioWeb.Controlador.SqlRol.Delete(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, objeto, out resultado);

            if ((resultado + "|").Split('|')[0].Equals("OK"))
            {
                ExecScriptModalDelete(false, resultado, true);
                // CargarGridView();
            }
            else
            {
                ExecScriptModalDelete(true, resultado, true);
            }
        }

        protected void btnGuardarEliminar_Click(object sender, EventArgs e)
        {
            GuardarElimina();
        }
      

        protected void btnDeleteRolMostrarModal_Click(object sender, EventArgs e)
        {
            CargarControlesDelete();
        }
        private void CargarControlesDelete()
        {
            var uid =txt_buscarDeleteUIDRol.Text;

            string resultado = "";
            var retSelect = SitioWeb.Controlador.SqlRol.SelectFirst(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, uid, out resultado);
            LimpiarControlesDelete();
            SetControl_Class_Delete(retSelect);
            ExecScriptModalDelete(true, "", false);
        }
        private void LimpiarControlesDelete()
        {
            
			txt_uidrol_delete.Text = Guid.NewGuid().ToString();
			txt_rol_delete.Text = "";
			checkb_permisolectura_delete.Checked =false ;
			checkb_permisoescritura_delete.Checked =false ;
			checkb_permisoconsultar_delete.Checked =false ;
			checkb_perisocrear_delete.Checked =false ;
			checkb_permisoeditar_delete.Checked =false ;
			checkb_permisoeliminar_delete.Checked =false ;
			checkb_permisototal_delete.Checked =false ;
			checkb_permisonulo_delete.Checked =false ;
            lblMensajeError_delete.Text = "";
        }    
    private void SetControl_Class_Delete(SitioWeb.Controlador.ClassRol c)
    {
       
			txt_uidrol_delete.Text= c.uidrol;
			txt_rol_delete.Text= c.rol;
			checkb_permisolectura_delete.Checked= ClasesUtiles.Util.ConvertBoolNullToBool(c.permisolectura);
			checkb_permisoescritura_delete.Checked= ClasesUtiles.Util.ConvertBoolNullToBool(c.permisoescritura);
			checkb_permisoconsultar_delete.Checked= ClasesUtiles.Util.ConvertBoolNullToBool(c.permisoconsultar);
			checkb_perisocrear_delete.Checked= ClasesUtiles.Util.ConvertBoolNullToBool(c.perisocrear);
			checkb_permisoeditar_delete.Checked= ClasesUtiles.Util.ConvertBoolNullToBool(c.permisoeditar);
			checkb_permisoeliminar_delete.Checked= ClasesUtiles.Util.ConvertBoolNullToBool(c.permisoeliminar);
			checkb_permisototal_delete.Checked= ClasesUtiles.Util.ConvertBoolNullToBool(c.permisototal);
			checkb_permisonulo_delete.Checked= ClasesUtiles.Util.ConvertBoolNullToBool(c.permisonulo);
    }

	
	    private void CargaCombosFKDelete()
        {
            string resultado = "";
			
        }

    }
}


