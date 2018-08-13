using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Loginuser
{
    public partial class Loginuser_CU_Update : System.Web.UI.UserControl
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
           
			txt_uidsuario_update.Text = Guid.NewGuid().ToString();
			txt_usuario_update.Text = "";
			txt_email_update.Text = "";
			txt_nombre_update.Text = "";
			txt_contrasenia_update.Text = "";
			cb_uidrol_update.SelectedIndex =-1;
            lblMensajeError_update.Text = "";
        }
        private void GuardarEditar()
        {
            string resultado = "";
            var objeto = GetClass_Control_Edit();
            if (Controlador.SqlLoginuser.ValidarCamposNulos(objeto).Count() == 0)
            {
                SitioWeb.Controlador.SqlLoginuser.Update(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, objeto, out resultado);
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
        private SitioWeb.Controlador.ClassLoginuser GetClass_Control_Edit()
        {
            var c = new SitioWeb.Controlador.ClassLoginuser();
             
				 c.uidsuario= ClasesUtiles.Util.ConvertStringToStringNull(txt_uidsuario_update.Text);
				 c.usuario= ClasesUtiles.Util.ConvertStringToStringNull(txt_usuario_update.Text);
				 c.email= ClasesUtiles.Util.ConvertStringToStringNull(txt_email_update.Text);
				 c.nombre= ClasesUtiles.Util.ConvertStringToStringNull(txt_nombre_update.Text);
				 c.contrasenia= ClasesUtiles.Util.ConvertStringToStringNull(txt_contrasenia_update.Text);
				 c.uidrol= ClasesUtiles.Util.ConvertStringToStringNull(cb_uidrol_update.SelectedValue as string);
            return c;
        }
        private void SetControl_Class_Edit(SitioWeb.Controlador.ClassLoginuser c)
        {

           
			txt_uidsuario_update.Text= c.uidsuario;
			txt_usuario_update.Text= c.usuario;
			txt_email_update.Text= c.email;
			txt_nombre_update.Text= c.nombre;
			txt_contrasenia_update.Text= c.contrasenia;
			cb_uidrol_update.SelectedIndex = cb_uidrol_update.Items.IndexOf(cb_uidrol_update.Items.FindByValue(c.uidrol));

        }
        protected void btnGuardarEditar_Click(object sender, EventArgs e)
        {
            GuardarEditar();
        }

        protected void btnUpdateLoginuserMostrarModal_Click(object sender, EventArgs e)
        {
            CargarControlesEditar();
        }
        private void CargarControlesEditar()
        {
            var uidLoginuser = txt_buscarUpdateUIDLoginuser.Text;

            string resultado = "";
            var retSelect = SitioWeb.Controlador.SqlLoginuser.SelectFirst(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, uidLoginuser, out resultado);
            LimpiarControlesEditar();
            SetControl_Class_Edit(retSelect);
            ExecScriptModalUpdate(true, "", false);
        }
		  private void CargaCombosFKUpdate()
        {
            string resultado = "";
			
			  cb_uidrol_update.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlRol.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidrol_update.DataTextField = "text"; 
			  cb_uidrol_update.DataValueField = "value"; 
			  cb_uidrol_update.DataBind(); 
        }


    }
}