using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Pagina
{
    public partial class Pagina_CU_Update : System.Web.UI.UserControl
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
           
			txt_uidpagina_update.Text = Guid.NewGuid().ToString();
			txt_pagina_update.Text = "";
			txt_fullurl_update.Text = "";
			cb_uidtipoiconoimg_update.SelectedIndex =-1;
			txt_iconoimg_update.Text = "";
			txt_orden_update.Text = "";
			cb_uidpaginapadre_update.SelectedIndex =-1;
            lblMensajeError_update.Text = "";
        }
        private void GuardarEditar()
        {
            string resultado = "";
            var objeto = GetClass_Control_Edit();
            if (Controlador.SqlPagina.ValidarCamposNulos(objeto).Count() == 0)
            {

                SitioWeb.Controlador.SqlPagina.Update(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, objeto, out resultado);
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
        private SitioWeb.Controlador.ClassPagina GetClass_Control_Edit()
        {
            var c = new SitioWeb.Controlador.ClassPagina();
             
				 c.uidpagina= ClasesUtiles.Util.ConvertStringToStringNull(txt_uidpagina_update.Text);
				 c.pagina= ClasesUtiles.Util.ConvertStringToStringNull(txt_pagina_update.Text);
				 c.fullurl= ClasesUtiles.Util.ConvertStringToStringNull(txt_fullurl_update.Text);
				 c.uidtipoiconoimg= ClasesUtiles.Util.ConvertStringToStringNull(cb_uidtipoiconoimg_update.SelectedValue as string);
				 c.iconoimg= ClasesUtiles.Util.ConvertStringToStringNull(txt_iconoimg_update.Text);
				 c.orden= ClasesUtiles.Util.ConvertStringToInt(txt_orden_update.Text);
				 c.uidpaginapadre= ClasesUtiles.Util.ConvertStringToStringNull(cb_uidpaginapadre_update.SelectedValue as string);
            return c;
        }
        private void SetControl_Class_Edit(SitioWeb.Controlador.ClassPagina c)
        {

           
			txt_uidpagina_update.Text= c.uidpagina;
			txt_pagina_update.Text= c.pagina;
			txt_fullurl_update.Text= c.fullurl;
			cb_uidtipoiconoimg_update.SelectedIndex = cb_uidtipoiconoimg_update.Items.IndexOf(cb_uidtipoiconoimg_update.Items.FindByValue(c.uidtipoiconoimg));
			txt_iconoimg_update.Text= c.iconoimg;
			txt_orden_update.Text= ClasesUtiles.Util.ConvertIntToString(c.orden);
			cb_uidpaginapadre_update.SelectedIndex = cb_uidpaginapadre_update.Items.IndexOf(cb_uidpaginapadre_update.Items.FindByValue(c.uidpaginapadre));

        }
        protected void btnGuardarEditar_Click(object sender, EventArgs e)
        {
            GuardarEditar();
        }

        protected void btnUpdatePaginaMostrarModal_Click(object sender, EventArgs e)
        {
            CargarControlesEditar();
        }
        private void CargarControlesEditar()
        {
            var uidPagina = txt_buscarUpdateUIDPagina.Text;

            string resultado = "";
            var retSelect = SitioWeb.Controlador.SqlPagina.SelectFirst(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, uidPagina, out resultado);
            LimpiarControlesEditar();
            SetControl_Class_Edit(retSelect);
            ExecScriptModalUpdate(true, "", false);
        }
		  private void CargaCombosFKUpdate()
        {
            string resultado = "";
			
			  cb_uidtipoiconoimg_update.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlTipoiconoimg.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidtipoiconoimg_update.DataTextField = "text"; 
			  cb_uidtipoiconoimg_update.DataValueField = "value"; 
			  cb_uidtipoiconoimg_update.DataBind(); 
			  cb_uidpaginapadre_update.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlPagina.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidpaginapadre_update.DataTextField = "text"; 
			  cb_uidpaginapadre_update.DataValueField = "value"; 
			  cb_uidpaginapadre_update.DataBind(); 
        }


    }
}