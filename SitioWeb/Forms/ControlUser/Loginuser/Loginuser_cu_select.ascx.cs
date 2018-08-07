using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Loginuser
{
    public partial class Loginuser_CU_MostrarUnico : System.Web.UI.UserControl
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
        protected void btnSelectLoginuserMostrarModal_Click(object sender, EventArgs e)
        {
            CargarControlesSelect();
        }
        private void CargarControlesSelect()
        {
            var uidLoginuser = txt_buscarSelectUIDLoginuser.Text;

            string resultado = "";
            var retSelect = SitioWeb.Controlador.SqlLoginuser.SelectFirst(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, uidLoginuser, out resultado);
            LimpiarControlesSelect();
            SetControl_Class_Select(retSelect);
          if (EsModal == true)
            {
                ExecScriptModalSelect(true, "");
            }
        }

		        private void ExecScriptModalSelect(bool EsVisible, string mensajeRetorno)
        {
            string script = @"$('#Select-modal-default-Loginuser').modal('" + (EsVisible == true ? "show" : "hide") + "'); ";           
            ScriptManager.RegisterStartupScript(this, this.GetType(), Guid.NewGuid().ToString().Replace("-", ""), script, true);
        }

        private void SetControl_Class_Select(SitioWeb.Controlador.ClassLoginuser c)
        {

           
			txt_uidsuario_select.Text= c.uidsuario;
			txt_usuario_select.Text= c.usuario;
			txt_email_select.Text= c.email;
			txt_nombre_select.Text= c.nombre;
			txt_contrasenia_select.Text= c.contrasenia;
			cb_uidrol_select.SelectedIndex = cb_uidrol_select.Items.IndexOf(cb_uidrol_select.Items.FindByValue(c.uidrol));

        }

        private void LimpiarControlesSelect()
        {
		     
			txt_uidsuario_select.Text = Guid.NewGuid().ToString();
			txt_usuario_select.Text = "";
			txt_email_select.Text = "";
			txt_nombre_select.Text = "";
			txt_contrasenia_select.Text = "";
			cb_uidrol_select.SelectedIndex =-1;
        }

		  private void CargaCombosFKSelect()
        {
            string resultado = "";
			
			  cb_uidrol_select.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlRol.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidrol_select.DataTextField = "text"; 
			  cb_uidrol_select.DataValueField = "value"; 
			  cb_uidrol_select.DataBind(); 
        }

    }
}