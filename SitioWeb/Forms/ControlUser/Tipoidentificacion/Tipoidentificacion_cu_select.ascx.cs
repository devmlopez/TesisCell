using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Tipoidentificacion
{
    public partial class Tipoidentificacion_CU_MostrarUnico : System.Web.UI.UserControl
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
        protected void btnSelectTipoidentificacionMostrarModal_Click(object sender, EventArgs e)
        {
            CargarControlesSelect();
        }
        private void CargarControlesSelect()
        {
            var uidTipoidentificacion = txt_buscarSelectUIDTipoidentificacion.Text;

            string resultado = "";
            var retSelect = SitioWeb.Controlador.SqlTipoidentificacion.SelectFirst(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, uidTipoidentificacion, out resultado);
            LimpiarControlesSelect();
            SetControl_Class_Select(retSelect);
          if (EsModal == true)
            {
                ExecScriptModalSelect(true, "");
            }
        }

		        private void ExecScriptModalSelect(bool EsVisible, string mensajeRetorno)
        {
            string script = @"$('#Select-modal-default-Tipoidentificacion').modal('" + (EsVisible == true ? "show" : "hide") + "'); ";           
            ScriptManager.RegisterStartupScript(this, this.GetType(), Guid.NewGuid().ToString().Replace("-", ""), script, true);
        }

        private void SetControl_Class_Select(SitioWeb.Controlador.ClassTipoidentificacion c)
        {

           
			txt_uidtipoidentificacion_select.Text= c.uidtipoidentificacion;
			txt_tipoidentificacion_select.Text= c.tipoidentificacion;

        }

        private void LimpiarControlesSelect()
        {
		     
			txt_uidtipoidentificacion_select.Text = Guid.NewGuid().ToString();
			txt_tipoidentificacion_select.Text = "";
        }

		  private void CargaCombosFKSelect()
        {
            string resultado = "";
			
        }

    }
}