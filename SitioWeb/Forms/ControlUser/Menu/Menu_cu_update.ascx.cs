using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Menu
{
    public partial class Menu_CU_Update : System.Web.UI.UserControl
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
           
			txt_uidmenu_update.Text = Guid.NewGuid().ToString();
			cb_uidrol_update.SelectedIndex =-1;
			cb_uidpagina_update.SelectedIndex =-1;
			checkb_esvisible_update.Checked =false ;
			checkb_semuestra_update.Checked =false ;
            lblMensajeError_update.Text = "";
        }
        private void GuardarEditar()
        {
            string resultado = "";
            var objeto = GetClass_Control_Edit();
            if (Controlador.SqlMenu.ValidarCamposNulos(objeto).Count() == 0)
            {
                SitioWeb.Controlador.SqlMenu.Update(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, objeto, out resultado);
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
        private SitioWeb.Controlador.ClassMenu GetClass_Control_Edit()
        {
            var c = new SitioWeb.Controlador.ClassMenu();
             
				 c.uidmenu= ClasesUtiles.Util.ConvertStringToStringNull(txt_uidmenu_update.Text);
				 c.uidrol= ClasesUtiles.Util.ConvertStringToStringNull(cb_uidrol_update.SelectedValue as string);
				 c.uidpagina= ClasesUtiles.Util.ConvertStringToStringNull(cb_uidpagina_update.SelectedValue as string);
				 c.esvisible= checkb_esvisible_update.Checked;
				 c.semuestra= checkb_semuestra_update.Checked;
            return c;
        }
        private void SetControl_Class_Edit(SitioWeb.Controlador.ClassMenu c)
        {

           
			txt_uidmenu_update.Text= c.uidmenu;
			cb_uidrol_update.SelectedIndex = cb_uidrol_update.Items.IndexOf(cb_uidrol_update.Items.FindByValue(c.uidrol));
			cb_uidpagina_update.SelectedIndex = cb_uidpagina_update.Items.IndexOf(cb_uidpagina_update.Items.FindByValue(c.uidpagina));
			checkb_esvisible_update.Checked= ClasesUtiles.Util.ConvertBoolNullToBool(c.esvisible);
			checkb_semuestra_update.Checked= ClasesUtiles.Util.ConvertBoolNullToBool(c.semuestra);

        }
        protected void btnGuardarEditar_Click(object sender, EventArgs e)
        {
            GuardarEditar();
        }

        protected void btnUpdateMenuMostrarModal_Click(object sender, EventArgs e)
        {
            CargarControlesEditar();
        }
        private void CargarControlesEditar()
        {
            var uidMenu = txt_buscarUpdateUIDMenu.Text;

            string resultado = "";
            var retSelect = SitioWeb.Controlador.SqlMenu.SelectFirst(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, uidMenu, out resultado);
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
			  cb_uidpagina_update.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlPagina.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidpagina_update.DataTextField = "text"; 
			  cb_uidpagina_update.DataValueField = "value"; 
			  cb_uidpagina_update.DataBind(); 
        }


    }
}