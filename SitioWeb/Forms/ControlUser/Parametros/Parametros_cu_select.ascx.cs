using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Parametros
{
    public partial class Parametros_CU_MostrarUnico : System.Web.UI.UserControl
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
        protected void btnSelectParametrosMostrarModal_Click(object sender, EventArgs e)
        {
            CargarControlesSelect();
        }
        private void CargarControlesSelect()
        {
            var uidParametros = txt_buscarSelectUIDParametros.Text;

            string resultado = "";
            var retSelect = SitioWeb.Controlador.SqlParametros.SelectFirst(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, uidParametros, out resultado);
            LimpiarControlesSelect();
            SetControl_Class_Select(retSelect);
          if (EsModal == true)
            {
                ExecScriptModalSelect(true, "");
            }
        }

		        private void ExecScriptModalSelect(bool EsVisible, string mensajeRetorno)
        {
            string script = @"$('#Select-modal-default-Parametros').modal('" + (EsVisible == true ? "show" : "hide") + "'); ";           
            ScriptManager.RegisterStartupScript(this, this.GetType(), Guid.NewGuid().ToString().Replace("-", ""), script, true);
        }

        private void SetControl_Class_Select(SitioWeb.Controlador.ClassParametros c)
        {

           
			txt_uidparmetro_select.Text= c.uidparmetro;
			txt_moduloreferencia_select.Text= c.moduloreferencia;
			txt_value_select.Text= c.value;
			txt_textshort_select.Text= c.textshort;
			txt_textlong_select.Text= c.textlong;

        }

        private void LimpiarControlesSelect()
        {
		     
			txt_uidparmetro_select.Text = Guid.NewGuid().ToString();
			txt_moduloreferencia_select.Text = "";
			txt_value_select.Text = "";
			txt_textshort_select.Text = "";
			txt_textlong_select.Text = "";
        }

		  private void CargaCombosFKSelect()
        {
            string resultado = "";
			
        }

    }
}