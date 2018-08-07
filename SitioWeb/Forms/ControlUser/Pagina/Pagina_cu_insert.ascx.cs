using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Pagina
{
    public partial class Pagina_CU_Insert : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LimpiarControlesNuevo();
                CargaCombosFKInsert();
            }
        }

        protected void btnGuardarNuevo_Click(object sender, EventArgs e)
        {
            GuardarNuevo();
        }

		 private void LimpiarControlesNuevo()
        {
		
			txt_uidpagina_insert.Text = Guid.NewGuid().ToString();
			txt_pagina_insert.Text = "";
			txt_fullurl_insert.Text = "";
			cb_uidtipoiconoimg_insert.SelectedIndex =-1;
			txt_iconoimg_insert.Text = "";
			txt_orden_insert.Text = "";
			cb_uidpaginapadre_insert.SelectedIndex =-1;
          
            lblMensajeError_Insert.Text = "";
        }
     

        private void GuardarNuevo()
        {
            string resultado = "";
            var objeto = GetClass_Control_New();
            SitioWeb.Controlador.SqlPagina.InsertInto(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, objeto, out resultado);
            lblMensajeError_Insert.Text = resultado;

            if ((resultado + "|").Split('|')[0].Equals("OK"))
            {
                ExecScriptModalInsert(false, resultado);
                LimpiarControlesNuevo();
            }
            else
            {
                ExecScriptModalInsert(true, resultado);
            }
        }


		  private SitioWeb.Controlador.ClassPagina GetClass_Control_New()
        {
            var c=new SitioWeb.Controlador.ClassPagina();

			
				 c.uidpagina =ClasesUtiles.Util.ConvertStringToStringNull(txt_uidpagina_insert.Text);
				 c.pagina =ClasesUtiles.Util.ConvertStringToStringNull(txt_pagina_insert.Text);
				 c.fullurl =ClasesUtiles.Util.ConvertStringToStringNull(txt_fullurl_insert.Text);
				 c.uidtipoiconoimg =ClasesUtiles.Util.ConvertStringToStringNull(cb_uidtipoiconoimg_insert.SelectedValue as string);
				 c.iconoimg =ClasesUtiles.Util.ConvertStringToStringNull(txt_iconoimg_insert.Text);
				c.orden= ClasesUtiles.Util.ConvertStringToInt(txt_orden_insert.Text);
				 c.uidpaginapadre =ClasesUtiles.Util.ConvertStringToStringNull(cb_uidpaginapadre_insert.SelectedValue as string);
            return c;
        }

        private void ExecScriptModalInsert(bool EsVisible, string mensajeRetorno)
        {
            string typeMsg = (mensajeRetorno + "|").Split('|')[0];
            string CodigoErrorMsg = ((mensajeRetorno + "|").Split('|').Count() >= 2 ? (mensajeRetorno + "|").Split('|')[1] : "");
            string mesajeMsg = ((mensajeRetorno + "|").Split('|').Count() >= 3 ? (mensajeRetorno + "|").Split('|')[2] : "");
            string script = @"$('#Inser-modal-default').modal('" + (EsVisible == true ? "show" : "hide") + "'); ";
            script += " ShowMessage('','" + CodigoErrorMsg + "', '" + mesajeMsg + "', '" + typeMsg + "')";
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), Guid.NewGuid().ToString().Replace("-", ""), script, true);
        }
        private void CargaCombosFKInsert()
        {
            string resultado = "";
			
			  cb_uidtipoiconoimg_insert.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlTipoiconoimg.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidtipoiconoimg_insert.DataTextField = "text"; 
			  cb_uidtipoiconoimg_insert.DataValueField = "value"; 
			  cb_uidtipoiconoimg_insert.DataBind(); 
			  cb_uidpaginapadre_insert.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlPagina.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidpaginapadre_insert.DataTextField = "text"; 
			  cb_uidpaginapadre_insert.DataValueField = "value"; 
			  cb_uidpaginapadre_insert.DataBind(); 
        }
    }
}



