using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Errores
{
    public partial class Errores_CU_MostrarUnico : System.Web.UI.UserControl
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
        protected void btnSelectErroresMostrarModal_Click(object sender, EventArgs e)
        {
            CargarControlesSelect();
        }
        private void CargarControlesSelect()
        {
            var uidErrores = txt_buscarSelectUIDErrores.Text;

            string resultado = "";
            var retSelect = SitioWeb.Controlador.SqlErrores.SelectFirst(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, uidErrores, out resultado);
            LimpiarControlesSelect();
            SetControl_Class_Select(retSelect);
          if (EsModal == true)
            {
                ExecScriptModalSelect(true, "");
            }
        }

		        private void ExecScriptModalSelect(bool EsVisible, string mensajeRetorno)
        {
            string script = @"$('#Select-modal-default-Errores').modal('" + (EsVisible == true ? "show" : "hide") + "'); ";           
            ScriptManager.RegisterStartupScript(this, this.GetType(), Guid.NewGuid().ToString().Replace("-", ""), script, true);
        }

        private void SetControl_Class_Select(SitioWeb.Controlador.ClassErrores c)
        {

           
			txt_uid_error_select.Text= c.uid_error;
			txt_cod_error_select.Text= c.cod_error;
			txt_mensajeusuario_select.Text= c.mensajeusuario;
			txt_mensajenativo_select.Text= c.mensajenativo;
			txt_origenerror_select.Text= c.origenerror;
			txt_tipoerror_select.Text= c.tipoerror;

        }

        private void LimpiarControlesSelect()
        {
		     
			txt_uid_error_select.Text = Guid.NewGuid().ToString();
			txt_cod_error_select.Text = "";
			txt_mensajeusuario_select.Text = "";
			txt_mensajenativo_select.Text = "";
			txt_origenerror_select.Text = "";
			txt_tipoerror_select.Text = "";
        }

		  private void CargaCombosFKSelect()
        {
            string resultado = "";
			
        }

    }
}