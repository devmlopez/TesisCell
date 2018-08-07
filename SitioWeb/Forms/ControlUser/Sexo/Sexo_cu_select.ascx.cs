using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Sexo
{
    public partial class Sexo_CU_MostrarUnico : System.Web.UI.UserControl
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
        protected void btnSelectSexoMostrarModal_Click(object sender, EventArgs e)
        {
            CargarControlesSelect();
        }
        private void CargarControlesSelect()
        {
            var uidSexo = txt_buscarSelectUIDSexo.Text;

            string resultado = "";
            var retSelect = SitioWeb.Controlador.SqlSexo.SelectFirst(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, uidSexo, out resultado);
            LimpiarControlesSelect();
            SetControl_Class_Select(retSelect);
          if (EsModal == true)
            {
                ExecScriptModalSelect(true, "");
            }
        }

		        private void ExecScriptModalSelect(bool EsVisible, string mensajeRetorno)
        {
            string script = @"$('#Select-modal-default-Sexo').modal('" + (EsVisible == true ? "show" : "hide") + "'); ";           
            ScriptManager.RegisterStartupScript(this, this.GetType(), Guid.NewGuid().ToString().Replace("-", ""), script, true);
        }

        private void SetControl_Class_Select(SitioWeb.Controlador.ClassSexo c)
        {

           
			txt_uidsexo_select.Text= c.uidsexo;
			txt_sexo_select.Text= c.sexo;

        }

        private void LimpiarControlesSelect()
        {
		     
			txt_uidsexo_select.Text = Guid.NewGuid().ToString();
			txt_sexo_select.Text = "";
        }

		  private void CargaCombosFKSelect()
        {
            string resultado = "";
			
        }

    }
}