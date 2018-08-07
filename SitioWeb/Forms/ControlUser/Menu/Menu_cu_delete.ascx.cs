using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Menu
{
    public partial class Menu_CU_Delete : System.Web.UI.UserControl
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
            var objeto = new Controlador.ClassMenu()
            {
			  
                uidmenu =  txt_buscarDeleteUIDMenu.Text
            };
            SitioWeb.Controlador.SqlMenu.Delete(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, objeto, out resultado);

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
      

        protected void btnDeleteMenuMostrarModal_Click(object sender, EventArgs e)
        {
            CargarControlesDelete();
        }
        private void CargarControlesDelete()
        {
            var uid =txt_buscarDeleteUIDMenu.Text;

            string resultado = "";
            var retSelect = SitioWeb.Controlador.SqlMenu.SelectFirst(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, uid, out resultado);
            LimpiarControlesDelete();
            SetControl_Class_Delete(retSelect);
            ExecScriptModalDelete(true, "", false);
        }
        private void LimpiarControlesDelete()
        {
            
			txt_uidmenu_delete.Text = Guid.NewGuid().ToString();
			cb_uidrol_delete.SelectedIndex =-1;
			cb_uidpagina_delete.SelectedIndex =-1;
			checkb_esvisible_delete.Checked =false ;
			checkb_semuestra_delete.Checked =false ;
            lblMensajeError_delete.Text = "";
        }    
    private void SetControl_Class_Delete(SitioWeb.Controlador.ClassMenu c)
    {
       
			txt_uidmenu_delete.Text= c.uidmenu;
			cb_uidrol_delete.SelectedIndex = cb_uidrol_delete.Items.IndexOf(cb_uidrol_delete.Items.FindByValue(c.uidrol));
			cb_uidpagina_delete.SelectedIndex = cb_uidpagina_delete.Items.IndexOf(cb_uidpagina_delete.Items.FindByValue(c.uidpagina));
			checkb_esvisible_delete.Checked= ClasesUtiles.Util.ConvertBoolNullToBool(c.esvisible);
			checkb_semuestra_delete.Checked= ClasesUtiles.Util.ConvertBoolNullToBool(c.semuestra);
    }

	
	    private void CargaCombosFKDelete()
        {
            string resultado = "";
			
			  cb_uidrol_delete.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlRol.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidrol_delete.DataTextField = "text"; 
			  cb_uidrol_delete.DataValueField = "value"; 
			  cb_uidrol_delete.DataBind(); 
			  cb_uidpagina_delete.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlPagina.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidpagina_delete.DataTextField = "text"; 
			  cb_uidpagina_delete.DataValueField = "value"; 
			  cb_uidpagina_delete.DataBind(); 
        }

    }
}


