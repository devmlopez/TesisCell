using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Media
{
    public partial class Media_CU_MostrarUnico : System.Web.UI.UserControl
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
        protected void btnSelectMediaMostrarModal_Click(object sender, EventArgs e)
        {
            CargarControlesSelect();
        }
        private void CargarControlesSelect()
        {
            var uidMedia = txt_buscarSelectUIDMedia.Text;

            string resultado = "";
            var retSelect = SitioWeb.Controlador.SqlMedia.SelectFirst(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, uidMedia, out resultado);
            LimpiarControlesSelect();
            SetControl_Class_Select(retSelect);
          if (EsModal == true)
            {
                ExecScriptModalSelect(true, "");
            }
        }

		        private void ExecScriptModalSelect(bool EsVisible, string mensajeRetorno)
        {
            string script = @"$('#Select-modal-default-Media').modal('" + (EsVisible == true ? "show" : "hide") + "'); ";           
            ScriptManager.RegisterStartupScript(this, this.GetType(), Guid.NewGuid().ToString().Replace("-", ""), script, true);
        }

        private void SetControl_Class_Select(SitioWeb.Controlador.ClassMedia c)
        {

           
			txt_uidmedia_select.Text= c.uidmedia;
			txt_codmedia_select.Text= ClasesUtiles.Util.ConvertIntToString(c.codmedia);
			cb_uidproceso_select.SelectedIndex = cb_uidproceso_select.Items.IndexOf(cb_uidproceso_select.Items.FindByValue(c.uidproceso));
			cb_uidtipocomentario_select.SelectedIndex = cb_uidtipocomentario_select.Items.IndexOf(cb_uidtipocomentario_select.Items.FindByValue(c.uidtipocomentario));
			txt_cometario_select.Text= c.cometario;
			txt_imagen_select.Text= c.imagen;
			txt_url_select.Text= c.url;

        }

        private void LimpiarControlesSelect()
        {
		     
			txt_uidmedia_select.Text = Guid.NewGuid().ToString();
			txt_codmedia_select.Text = Guid.NewGuid().ToString();
			cb_uidproceso_select.SelectedIndex =-1;
			cb_uidtipocomentario_select.SelectedIndex =-1;
			txt_cometario_select.Text = "";
			txt_imagen_select.Text = "";
			txt_url_select.Text = "";
        }

		  private void CargaCombosFKSelect()
        {
            string resultado = "";
			
			  cb_uidproceso_select.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlProceso.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidproceso_select.DataTextField = "text"; 
			  cb_uidproceso_select.DataValueField = "value"; 
			  cb_uidproceso_select.DataBind(); 
			  cb_uidtipocomentario_select.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlTipocomentario.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidtipocomentario_select.DataTextField = "text"; 
			  cb_uidtipocomentario_select.DataValueField = "value"; 
			  cb_uidtipocomentario_select.DataBind(); 
        }

    }
}