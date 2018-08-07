using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Grupousuario
{
    public partial class Grupousuario_CU_Update : System.Web.UI.UserControl
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
           
			txt_uidgrupousuario_update.Text = Guid.NewGuid().ToString();
			cb_uidgrupo_update.SelectedIndex =-1;
			cb_uidusuario_update.SelectedIndex =-1;
            lblMensajeError_update.Text = "";
        }
        private void GuardarEditar()
        {
            string resultado = "";
            var objeto = GetClass_Control_Edit();
            SitioWeb.Controlador.SqlGrupousuario.Update(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, objeto, out resultado);
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
        private SitioWeb.Controlador.ClassGrupousuario GetClass_Control_Edit()
        {
            var c = new SitioWeb.Controlador.ClassGrupousuario();
             
				 c.uidgrupousuario= ClasesUtiles.Util.ConvertStringToStringNull(txt_uidgrupousuario_update.Text);
				 c.uidgrupo= ClasesUtiles.Util.ConvertStringToStringNull(cb_uidgrupo_update.SelectedValue as string);
				 c.uidusuario= ClasesUtiles.Util.ConvertStringToStringNull(cb_uidusuario_update.SelectedValue as string);
            return c;
        }
        private void SetControl_Class_Edit(SitioWeb.Controlador.ClassGrupousuario c)
        {

           
			txt_uidgrupousuario_update.Text= c.uidgrupousuario;
			cb_uidgrupo_update.SelectedIndex = cb_uidgrupo_update.Items.IndexOf(cb_uidgrupo_update.Items.FindByValue(c.uidgrupo));
			cb_uidusuario_update.SelectedIndex = cb_uidusuario_update.Items.IndexOf(cb_uidusuario_update.Items.FindByValue(c.uidusuario));

        }
        protected void btnGuardarEditar_Click(object sender, EventArgs e)
        {
            GuardarEditar();
        }

        protected void btnUpdateGrupousuarioMostrarModal_Click(object sender, EventArgs e)
        {
            CargarControlesEditar();
        }
        private void CargarControlesEditar()
        {
            var uidGrupousuario = txt_buscarUpdateUIDGrupousuario.Text;

            string resultado = "";
            var retSelect = SitioWeb.Controlador.SqlGrupousuario.SelectFirst(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, uidGrupousuario, out resultado);
            LimpiarControlesEditar();
            SetControl_Class_Edit(retSelect);
            ExecScriptModalUpdate(true, "", false);
        }
		  private void CargaCombosFKUpdate()
        {
            string resultado = "";
			
			  cb_uidgrupo_update.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlGrupo.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidgrupo_update.DataTextField = "text"; 
			  cb_uidgrupo_update.DataValueField = "value"; 
			  cb_uidgrupo_update.DataBind(); 
			  cb_uidusuario_update.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlLoginuser.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidusuario_update.DataTextField = "text"; 
			  cb_uidusuario_update.DataValueField = "value"; 
			  cb_uidusuario_update.DataBind(); 
        }


    }
}