using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Media
{
    public partial class Media_CU_Update : System.Web.UI.UserControl
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
           
			txt_uidmedia_update.Text = Guid.NewGuid().ToString();
			txt_codmedia_update.Text = Guid.NewGuid().ToString();
			cb_uidproceso_update.SelectedIndex =-1;
			cb_uidtipocomentario_update.SelectedIndex =-1;
			txt_cometario_update.Text = "";
			txt_imagen_update.Text = "";
			txt_url_update.Text = "";
            lblMensajeError_update.Text = "";
        }
        private void GuardarEditar()
        {
            string resultado = "";
            var objeto = GetClass_Control_Edit();
            if  (Controlador.SqlMedia.ValidarCamposNulos(objeto).Count() == 0)
            {
                SitioWeb.Controlador.SqlMedia.Update(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, objeto, out resultado);
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
        private SitioWeb.Controlador.ClassMedia GetClass_Control_Edit()
        {
            var c = new SitioWeb.Controlador.ClassMedia();
             
				 c.uidmedia= ClasesUtiles.Util.ConvertStringToStringNull(txt_uidmedia_update.Text);
				 c.codmedia= ClasesUtiles.Util.ConvertStringToInt(txt_codmedia_update.Text);
				 c.uidproceso= ClasesUtiles.Util.ConvertStringToStringNull(cb_uidproceso_update.SelectedValue as string);
				 c.uidtipocomentario= ClasesUtiles.Util.ConvertStringToStringNull(cb_uidtipocomentario_update.SelectedValue as string);
				 c.cometario= ClasesUtiles.Util.ConvertStringToStringNull(txt_cometario_update.Text);
				 c.imagen= ClasesUtiles.Util.ConvertStringToStringNull(txt_imagen_update.Text);
				 c.url= ClasesUtiles.Util.ConvertStringToStringNull(txt_url_update.Text);
            return c;
        }
        private void SetControl_Class_Edit(SitioWeb.Controlador.ClassMedia c)
        {

           
			txt_uidmedia_update.Text= c.uidmedia;
			txt_codmedia_update.Text= ClasesUtiles.Util.ConvertIntToString(c.codmedia);
			cb_uidproceso_update.SelectedIndex = cb_uidproceso_update.Items.IndexOf(cb_uidproceso_update.Items.FindByValue(c.uidproceso));
			cb_uidtipocomentario_update.SelectedIndex = cb_uidtipocomentario_update.Items.IndexOf(cb_uidtipocomentario_update.Items.FindByValue(c.uidtipocomentario));
			txt_cometario_update.Text= c.cometario;
			txt_imagen_update.Text= c.imagen;
			txt_url_update.Text= c.url;

        }
        protected void btnGuardarEditar_Click(object sender, EventArgs e)
        {
            GuardarEditar();
        }

        protected void btnUpdateMediaMostrarModal_Click(object sender, EventArgs e)
        {
            CargarControlesEditar();
        }
        private void CargarControlesEditar()
        {
            var uidMedia = txt_buscarUpdateUIDMedia.Text;

            string resultado = "";
            var retSelect = SitioWeb.Controlador.SqlMedia.SelectFirst(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, uidMedia, out resultado);
            LimpiarControlesEditar();
            SetControl_Class_Edit(retSelect);
            ExecScriptModalUpdate(true, "", false);
        }
		  private void CargaCombosFKUpdate()
        {
            string resultado = "";
			
			  cb_uidproceso_update.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlProceso.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidproceso_update.DataTextField = "text"; 
			  cb_uidproceso_update.DataValueField = "value"; 
			  cb_uidproceso_update.DataBind(); 
			  cb_uidtipocomentario_update.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlTipocomentario.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidtipocomentario_update.DataTextField = "text"; 
			  cb_uidtipocomentario_update.DataValueField = "value"; 
			  cb_uidtipocomentario_update.DataBind(); 
        }


    }
}