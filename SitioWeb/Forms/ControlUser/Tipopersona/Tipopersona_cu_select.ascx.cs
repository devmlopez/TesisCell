using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Tipopersona
{
    public partial class Tipopersona_CU_MostrarUnico : System.Web.UI.UserControl
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
        protected void btnSelectTipopersonaMostrarModal_Click(object sender, EventArgs e)
        {
            CargarControlesSelect();
        }
        private void CargarControlesSelect()
        {
            var uidTipopersona = txt_buscarSelectUIDTipopersona.Text;

            string resultado = "";
            var retSelect = SitioWeb.Controlador.SqlTipopersona.SelectFirst(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, uidTipopersona, out resultado);
            LimpiarControlesSelect();
            SetControl_Class_Select(retSelect);
          if (EsModal == true)
            {
                ExecScriptModalSelect(true, "");
            }
        }

		        private void ExecScriptModalSelect(bool EsVisible, string mensajeRetorno)
        {
            string script = @"$('#Select-modal-default-Tipopersona').modal('" + (EsVisible == true ? "show" : "hide") + "'); ";           
            ScriptManager.RegisterStartupScript(this, this.GetType(), Guid.NewGuid().ToString().Replace("-", ""), script, true);
        }

        private void SetControl_Class_Select(SitioWeb.Controlador.ClassTipopersona c)
        {

           
			txt_uidtipopersona_select.Text= c.uidtipopersona;
			txt_tipopersona_select.Text= c.tipopersona;

        }

        private void LimpiarControlesSelect()
        {
		     
			txt_uidtipopersona_select.Text = Guid.NewGuid().ToString();
			txt_tipopersona_select.Text = "";
        }

		  private void CargaCombosFKSelect()
        {
            string resultado = "";
			
        }

    }
}