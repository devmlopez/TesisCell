using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Empresa
{
    public partial class Empresa_CU_MostrarUnico : System.Web.UI.UserControl
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
        protected void btnSelectEmpresaMostrarModal_Click(object sender, EventArgs e)
        {
            CargarControlesSelect();
        }
        private void CargarControlesSelect()
        {
            var uidEmpresa = txt_buscarSelectUIDEmpresa.Text;

            string resultado = "";
            var retSelect = SitioWeb.Controlador.SqlEmpresa.SelectFirst(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, uidEmpresa, out resultado);
            LimpiarControlesSelect();
            SetControl_Class_Select(retSelect);
          if (EsModal == true)
            {
                ExecScriptModalSelect(true, "");
            }
        }

		        private void ExecScriptModalSelect(bool EsVisible, string mensajeRetorno)
        {
            string script = @"$('#Select-modal-default-Empresa').modal('" + (EsVisible == true ? "show" : "hide") + "'); ";           
            ScriptManager.RegisterStartupScript(this, this.GetType(), Guid.NewGuid().ToString().Replace("-", ""), script, true);
        }

        private void SetControl_Class_Select(SitioWeb.Controlador.ClassEmpresa c)
        {

           
			txt_uid_empresa_select.Text= c.uid_empresa;
			txt_ruc_select.Text= c.ruc;
			txt_nombre_select.Text= c.nombre;
			txt_descripcion_select.Text= c.descripcion;
			txt_direccion_select.Text= c.direccion;
			txt_telefono_select.Text= c.telefono;
			txt_representantelegal_select.Text= c.representantelegal;

        }

        private void LimpiarControlesSelect()
        {
		     
			txt_uid_empresa_select.Text = Guid.NewGuid().ToString();
			txt_ruc_select.Text = "";
			txt_nombre_select.Text = "";
			txt_descripcion_select.Text = "";
			txt_direccion_select.Text = "";
			txt_telefono_select.Text = "";
			txt_representantelegal_select.Text = "";
        }

		  private void CargaCombosFKSelect()
        {
            string resultado = "";
			
        }

    }
}