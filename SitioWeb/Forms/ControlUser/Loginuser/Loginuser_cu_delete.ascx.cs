using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Loginuser
{
    public partial class Loginuser_CU_Delete : System.Web.UI.UserControl
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
            var objeto = new Controlador.ClassLoginuser()
            {
			  
                uidsuario =  txt_buscarDeleteUIDLoginuser.Text
            };
            SitioWeb.Controlador.SqlLoginuser.Delete(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, objeto, out resultado);

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
      

        protected void btnDeleteLoginuserMostrarModal_Click(object sender, EventArgs e)
        {
            CargarControlesDelete();
        }
        private void CargarControlesDelete()
        {
            var uid =txt_buscarDeleteUIDLoginuser.Text;

            string resultado = "";
            var retSelect = SitioWeb.Controlador.SqlLoginuser.SelectFirst(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, uid, out resultado);
            LimpiarControlesDelete();
            SetControl_Class_Delete(retSelect);
            ExecScriptModalDelete(true, "", false);
        }
        private void LimpiarControlesDelete()
        {
            
			txt_uidsuario_delete.Text = Guid.NewGuid().ToString();
			txt_usuario_delete.Text = "";
			txt_email_delete.Text = "";
			txt_nombre_delete.Text = "";
			txt_contrasenia_delete.Text = "";
			cb_uidrol_delete.SelectedIndex =-1;
            lblMensajeError_delete.Text = "";
        }    
    private void SetControl_Class_Delete(SitioWeb.Controlador.ClassLoginuser c)
    {
       
			txt_uidsuario_delete.Text= c.uidsuario;
			txt_usuario_delete.Text= c.usuario;
			txt_email_delete.Text= c.email;
			txt_nombre_delete.Text= c.nombre;
			txt_contrasenia_delete.Text= c.contrasenia;
			cb_uidrol_delete.SelectedIndex = cb_uidrol_delete.Items.IndexOf(cb_uidrol_delete.Items.FindByValue(c.uidrol));
    }

	
	    private void CargaCombosFKDelete()
        {
            string resultado = "";
			
			  cb_uidrol_delete.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlRol.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidrol_delete.DataTextField = "text"; 
			  cb_uidrol_delete.DataValueField = "value"; 
			  cb_uidrol_delete.DataBind(); 
        }

    }
}


