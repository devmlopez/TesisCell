using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Tipoiconoimg
{
    public partial class Tipoiconoimg_CU_MostrarUnico : System.Web.UI.UserControl
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
        protected void btnSelectTipoiconoimgMostrarModal_Click(object sender, EventArgs e)
        {
            CargarControlesSelect();
        }
        private void CargarControlesSelect()
        {
            var uidTipoiconoimg = txt_buscarSelectUIDTipoiconoimg.Text;

            string resultado = "";
            var retSelect = SitioWeb.Controlador.SqlTipoiconoimg.SelectFirst(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, uidTipoiconoimg, out resultado);
            LimpiarControlesSelect();
            SetControl_Class_Select(retSelect);
          if (EsModal == true)
            {
                ExecScriptModalSelect(true, "");
            }
        }

		        private void ExecScriptModalSelect(bool EsVisible, string mensajeRetorno)
        {
            string script = @"$('#Select-modal-default-Tipoiconoimg').modal('" + (EsVisible == true ? "show" : "hide") + "'); ";           
            ScriptManager.RegisterStartupScript(this, this.GetType(), Guid.NewGuid().ToString().Replace("-", ""), script, true);
        }

        private void SetControl_Class_Select(SitioWeb.Controlador.ClassTipoiconoimg c)
        {

           
			txt_uidtipoiconoimg_select.Text= c.uidtipoiconoimg;
			txt_tipoiconoimg_select.Text= c.tipoiconoimg;

        }

        private void LimpiarControlesSelect()
        {
		     
			txt_uidtipoiconoimg_select.Text = Guid.NewGuid().ToString();
			txt_tipoiconoimg_select.Text = "";
        }

		  private void CargaCombosFKSelect()
        {
            string resultado = "";
			
        }

    }
}