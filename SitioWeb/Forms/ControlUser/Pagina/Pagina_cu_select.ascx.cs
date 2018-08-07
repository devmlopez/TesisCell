using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Pagina
{
    public partial class Pagina_CU_MostrarUnico : System.Web.UI.UserControl
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
        protected void btnSelectPaginaMostrarModal_Click(object sender, EventArgs e)
        {
            CargarControlesSelect();
        }
        private void CargarControlesSelect()
        {
            var uidPagina = txt_buscarSelectUIDPagina.Text;

            string resultado = "";
            var retSelect = SitioWeb.Controlador.SqlPagina.SelectFirst(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, uidPagina, out resultado);
            LimpiarControlesSelect();
            SetControl_Class_Select(retSelect);
          if (EsModal == true)
            {
                ExecScriptModalSelect(true, "");
            }
        }

		        private void ExecScriptModalSelect(bool EsVisible, string mensajeRetorno)
        {
            string script = @"$('#Select-modal-default-Pagina').modal('" + (EsVisible == true ? "show" : "hide") + "'); ";           
            ScriptManager.RegisterStartupScript(this, this.GetType(), Guid.NewGuid().ToString().Replace("-", ""), script, true);
        }

        private void SetControl_Class_Select(SitioWeb.Controlador.ClassPagina c)
        {

           
			txt_uidpagina_select.Text= c.uidpagina;
			txt_pagina_select.Text= c.pagina;
			txt_fullurl_select.Text= c.fullurl;
			cb_uidtipoiconoimg_select.SelectedIndex = cb_uidtipoiconoimg_select.Items.IndexOf(cb_uidtipoiconoimg_select.Items.FindByValue(c.uidtipoiconoimg));
			txt_iconoimg_select.Text= c.iconoimg;
			txt_orden_select.Text= ClasesUtiles.Util.ConvertIntToString(c.orden);
			cb_uidpaginapadre_select.SelectedIndex = cb_uidpaginapadre_select.Items.IndexOf(cb_uidpaginapadre_select.Items.FindByValue(c.uidpaginapadre));

        }

        private void LimpiarControlesSelect()
        {
		     
			txt_uidpagina_select.Text = Guid.NewGuid().ToString();
			txt_pagina_select.Text = "";
			txt_fullurl_select.Text = "";
			cb_uidtipoiconoimg_select.SelectedIndex =-1;
			txt_iconoimg_select.Text = "";
			txt_orden_select.Text = "";
			cb_uidpaginapadre_select.SelectedIndex =-1;
        }

		  private void CargaCombosFKSelect()
        {
            string resultado = "";
			
			  cb_uidtipoiconoimg_select.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlTipoiconoimg.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidtipoiconoimg_select.DataTextField = "text"; 
			  cb_uidtipoiconoimg_select.DataValueField = "value"; 
			  cb_uidtipoiconoimg_select.DataBind(); 
			  cb_uidpaginapadre_select.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlPagina.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidpaginapadre_select.DataTextField = "text"; 
			  cb_uidpaginapadre_select.DataValueField = "value"; 
			  cb_uidpaginapadre_select.DataBind(); 
        }

    }
}