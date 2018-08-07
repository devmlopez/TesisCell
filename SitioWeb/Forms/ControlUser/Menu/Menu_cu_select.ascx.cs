using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Menu
{
    public partial class Menu_CU_MostrarUnico : System.Web.UI.UserControl
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
        protected void btnSelectMenuMostrarModal_Click(object sender, EventArgs e)
        {
            CargarControlesSelect();
        }
        private void CargarControlesSelect()
        {
            var uidMenu = txt_buscarSelectUIDMenu.Text;

            string resultado = "";
            var retSelect = SitioWeb.Controlador.SqlMenu.SelectFirst(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, uidMenu, out resultado);
            LimpiarControlesSelect();
            SetControl_Class_Select(retSelect);
          if (EsModal == true)
            {
                ExecScriptModalSelect(true, "");
            }
        }

		        private void ExecScriptModalSelect(bool EsVisible, string mensajeRetorno)
        {
            string script = @"$('#Select-modal-default-Menu').modal('" + (EsVisible == true ? "show" : "hide") + "'); ";           
            ScriptManager.RegisterStartupScript(this, this.GetType(), Guid.NewGuid().ToString().Replace("-", ""), script, true);
        }

        private void SetControl_Class_Select(SitioWeb.Controlador.ClassMenu c)
        {

           
			txt_uidmenu_select.Text= c.uidmenu;
			cb_uidrol_select.SelectedIndex = cb_uidrol_select.Items.IndexOf(cb_uidrol_select.Items.FindByValue(c.uidrol));
			cb_uidpagina_select.SelectedIndex = cb_uidpagina_select.Items.IndexOf(cb_uidpagina_select.Items.FindByValue(c.uidpagina));
			checkb_esvisible_select.Checked= ClasesUtiles.Util.ConvertBoolNullToBool(c.esvisible);
			checkb_semuestra_select.Checked= ClasesUtiles.Util.ConvertBoolNullToBool(c.semuestra);

        }

        private void LimpiarControlesSelect()
        {
		     
			txt_uidmenu_select.Text = Guid.NewGuid().ToString();
			cb_uidrol_select.SelectedIndex =-1;
			cb_uidpagina_select.SelectedIndex =-1;
			checkb_esvisible_select.Checked =false ;
			checkb_semuestra_select.Checked =false ;
        }

		  private void CargaCombosFKSelect()
        {
            string resultado = "";
			
			  cb_uidrol_select.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlRol.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidrol_select.DataTextField = "text"; 
			  cb_uidrol_select.DataValueField = "value"; 
			  cb_uidrol_select.DataBind(); 
			  cb_uidpagina_select.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlPagina.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidpagina_select.DataTextField = "text"; 
			  cb_uidpagina_select.DataValueField = "value"; 
			  cb_uidpagina_select.DataBind(); 
        }

    }
}