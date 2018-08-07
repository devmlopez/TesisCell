using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Pagina
{
    public partial class Pagina_CU_Delete : System.Web.UI.UserControl
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
            var objeto = new Controlador.ClassPagina()
            {
			  
                uidpagina =  txt_buscarDeleteUIDPagina.Text
            };
            SitioWeb.Controlador.SqlPagina.Delete(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, objeto, out resultado);

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
      

        protected void btnDeletePaginaMostrarModal_Click(object sender, EventArgs e)
        {
            CargarControlesDelete();
        }
        private void CargarControlesDelete()
        {
            var uid =txt_buscarDeleteUIDPagina.Text;

            string resultado = "";
            var retSelect = SitioWeb.Controlador.SqlPagina.SelectFirst(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, uid, out resultado);
            LimpiarControlesDelete();
            SetControl_Class_Delete(retSelect);
            ExecScriptModalDelete(true, "", false);
        }
        private void LimpiarControlesDelete()
        {
            
			txt_uidpagina_delete.Text = Guid.NewGuid().ToString();
			txt_pagina_delete.Text = "";
			txt_fullurl_delete.Text = "";
			cb_uidtipoiconoimg_delete.SelectedIndex =-1;
			txt_iconoimg_delete.Text = "";
			txt_orden_delete.Text = "";
			cb_uidpaginapadre_delete.SelectedIndex =-1;
            lblMensajeError_delete.Text = "";
        }    
    private void SetControl_Class_Delete(SitioWeb.Controlador.ClassPagina c)
    {
       
			txt_uidpagina_delete.Text= c.uidpagina;
			txt_pagina_delete.Text= c.pagina;
			txt_fullurl_delete.Text= c.fullurl;
			cb_uidtipoiconoimg_delete.SelectedIndex = cb_uidtipoiconoimg_delete.Items.IndexOf(cb_uidtipoiconoimg_delete.Items.FindByValue(c.uidtipoiconoimg));
			txt_iconoimg_delete.Text= c.iconoimg;
			txt_orden_delete.Text= ClasesUtiles.Util.ConvertIntToString(c.orden);
			cb_uidpaginapadre_delete.SelectedIndex = cb_uidpaginapadre_delete.Items.IndexOf(cb_uidpaginapadre_delete.Items.FindByValue(c.uidpaginapadre));
    }

	
	    private void CargaCombosFKDelete()
        {
            string resultado = "";
			
			  cb_uidtipoiconoimg_delete.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlTipoiconoimg.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidtipoiconoimg_delete.DataTextField = "text"; 
			  cb_uidtipoiconoimg_delete.DataValueField = "value"; 
			  cb_uidtipoiconoimg_delete.DataBind(); 
			  cb_uidpaginapadre_delete.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlPagina.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidpaginapadre_delete.DataTextField = "text"; 
			  cb_uidpaginapadre_delete.DataValueField = "value"; 
			  cb_uidpaginapadre_delete.DataBind(); 
        }

    }
}


