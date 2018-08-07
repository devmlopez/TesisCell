using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Paginagrupo
{
    public partial class Paginagrupo_CU_MostrarUnico : System.Web.UI.UserControl
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
        protected void btnSelectPaginagrupoMostrarModal_Click(object sender, EventArgs e)
        {
            CargarControlesSelect();
        }
        private void CargarControlesSelect()
        {
            var uidPaginagrupo = txt_buscarSelectUIDPaginagrupo.Text;

            string resultado = "";
            var retSelect = SitioWeb.Controlador.SqlPaginagrupo.SelectFirst(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, uidPaginagrupo, out resultado);
            LimpiarControlesSelect();
            SetControl_Class_Select(retSelect);
          if (EsModal == true)
            {
                ExecScriptModalSelect(true, "");
            }
        }

		        private void ExecScriptModalSelect(bool EsVisible, string mensajeRetorno)
        {
            string script = @"$('#Select-modal-default-Paginagrupo').modal('" + (EsVisible == true ? "show" : "hide") + "'); ";           
            ScriptManager.RegisterStartupScript(this, this.GetType(), Guid.NewGuid().ToString().Replace("-", ""), script, true);
        }

        private void SetControl_Class_Select(SitioWeb.Controlador.ClassPaginagrupo c)
        {

           
			txt_uidpaginagrupo_select.Text= c.uidpaginagrupo;
			cb_uidpagina_select.SelectedIndex = cb_uidpagina_select.Items.IndexOf(cb_uidpagina_select.Items.FindByValue(c.uidpagina));
			cb_uidgrupo_select.SelectedIndex = cb_uidgrupo_select.Items.IndexOf(cb_uidgrupo_select.Items.FindByValue(c.uidgrupo));

        }

        private void LimpiarControlesSelect()
        {
		     
			txt_uidpaginagrupo_select.Text = Guid.NewGuid().ToString();
			cb_uidpagina_select.SelectedIndex =-1;
			cb_uidgrupo_select.SelectedIndex =-1;
        }

		  private void CargaCombosFKSelect()
        {
            string resultado = "";
			
			  cb_uidpagina_select.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlPagina.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidpagina_select.DataTextField = "text"; 
			  cb_uidpagina_select.DataValueField = "value"; 
			  cb_uidpagina_select.DataBind(); 
			  cb_uidgrupo_select.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlGrupo.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidgrupo_select.DataTextField = "text"; 
			  cb_uidgrupo_select.DataValueField = "value"; 
			  cb_uidgrupo_select.DataBind(); 
        }

    }
}