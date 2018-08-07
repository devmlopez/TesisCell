using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Grupousuario
{
    public partial class Grupousuario_CU_MostrarUnico : System.Web.UI.UserControl
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
        protected void btnSelectGrupousuarioMostrarModal_Click(object sender, EventArgs e)
        {
            CargarControlesSelect();
        }
        private void CargarControlesSelect()
        {
            var uidGrupousuario = txt_buscarSelectUIDGrupousuario.Text;

            string resultado = "";
            var retSelect = SitioWeb.Controlador.SqlGrupousuario.SelectFirst(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, uidGrupousuario, out resultado);
            LimpiarControlesSelect();
            SetControl_Class_Select(retSelect);
          if (EsModal == true)
            {
                ExecScriptModalSelect(true, "");
            }
        }

		        private void ExecScriptModalSelect(bool EsVisible, string mensajeRetorno)
        {
            string script = @"$('#Select-modal-default-Grupousuario').modal('" + (EsVisible == true ? "show" : "hide") + "'); ";           
            ScriptManager.RegisterStartupScript(this, this.GetType(), Guid.NewGuid().ToString().Replace("-", ""), script, true);
        }

        private void SetControl_Class_Select(SitioWeb.Controlador.ClassGrupousuario c)
        {

           
			txt_uidgrupousuario_select.Text= c.uidgrupousuario;
			cb_uidgrupo_select.SelectedIndex = cb_uidgrupo_select.Items.IndexOf(cb_uidgrupo_select.Items.FindByValue(c.uidgrupo));
			cb_uidusuario_select.SelectedIndex = cb_uidusuario_select.Items.IndexOf(cb_uidusuario_select.Items.FindByValue(c.uidusuario));

        }

        private void LimpiarControlesSelect()
        {
		     
			txt_uidgrupousuario_select.Text = Guid.NewGuid().ToString();
			cb_uidgrupo_select.SelectedIndex =-1;
			cb_uidusuario_select.SelectedIndex =-1;
        }

		  private void CargaCombosFKSelect()
        {
            string resultado = "";
			
			  cb_uidgrupo_select.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlGrupo.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidgrupo_select.DataTextField = "text"; 
			  cb_uidgrupo_select.DataValueField = "value"; 
			  cb_uidgrupo_select.DataBind(); 
			  cb_uidusuario_select.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlLoginuser.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidusuario_select.DataTextField = "text"; 
			  cb_uidusuario_select.DataValueField = "value"; 
			  cb_uidusuario_select.DataBind(); 
        }

    }
}