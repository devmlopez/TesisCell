using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Paginagrupo
{
    public partial class Paginagrupo_CU_Update : System.Web.UI.UserControl
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
           
			txt_uidpaginagrupo_update.Text = Guid.NewGuid().ToString();
			cb_uidpagina_update.SelectedIndex =-1;
			cb_uidgrupo_update.SelectedIndex =-1;
            lblMensajeError_update.Text = "";
        }
        private void GuardarEditar()
        {
            string resultado = "";
            var objeto = GetClass_Control_Edit();
            SitioWeb.Controlador.SqlPaginagrupo.Update(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, objeto, out resultado);
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
        private SitioWeb.Controlador.ClassPaginagrupo GetClass_Control_Edit()
        {
            var c = new SitioWeb.Controlador.ClassPaginagrupo();
             
				 c.uidpaginagrupo= ClasesUtiles.Util.ConvertStringToStringNull(txt_uidpaginagrupo_update.Text);
				 c.uidpagina= ClasesUtiles.Util.ConvertStringToStringNull(cb_uidpagina_update.SelectedValue as string);
				 c.uidgrupo= ClasesUtiles.Util.ConvertStringToStringNull(cb_uidgrupo_update.SelectedValue as string);
            return c;
        }
        private void SetControl_Class_Edit(SitioWeb.Controlador.ClassPaginagrupo c)
        {

           
			txt_uidpaginagrupo_update.Text= c.uidpaginagrupo;
			cb_uidpagina_update.SelectedIndex = cb_uidpagina_update.Items.IndexOf(cb_uidpagina_update.Items.FindByValue(c.uidpagina));
			cb_uidgrupo_update.SelectedIndex = cb_uidgrupo_update.Items.IndexOf(cb_uidgrupo_update.Items.FindByValue(c.uidgrupo));

        }
        protected void btnGuardarEditar_Click(object sender, EventArgs e)
        {
            GuardarEditar();
        }

        protected void btnUpdatePaginagrupoMostrarModal_Click(object sender, EventArgs e)
        {
            CargarControlesEditar();
        }
        private void CargarControlesEditar()
        {
            var uidPaginagrupo = txt_buscarUpdateUIDPaginagrupo.Text;

            string resultado = "";
            var retSelect = SitioWeb.Controlador.SqlPaginagrupo.SelectFirst(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, uidPaginagrupo, out resultado);
            LimpiarControlesEditar();
            SetControl_Class_Edit(retSelect);
            ExecScriptModalUpdate(true, "", false);
        }
		  private void CargaCombosFKUpdate()
        {
            string resultado = "";
			
			  cb_uidpagina_update.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlPagina.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidpagina_update.DataTextField = "text"; 
			  cb_uidpagina_update.DataValueField = "value"; 
			  cb_uidpagina_update.DataBind(); 
			  cb_uidgrupo_update.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlGrupo.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidgrupo_update.DataTextField = "text"; 
			  cb_uidgrupo_update.DataValueField = "value"; 
			  cb_uidgrupo_update.DataBind(); 
        }


    }
}