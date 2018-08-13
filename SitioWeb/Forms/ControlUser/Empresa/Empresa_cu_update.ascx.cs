using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Empresa
{
    public partial class Empresa_CU_Update : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
		 if (!IsPostBack)
            {
                LimpiarControlesEditar();
                CargaCombosFKUpdate();
            }
		
        }
        private void LimpiarControlesEditar()
        {
           
			txt_uid_empresa_update.Text = Guid.NewGuid().ToString();
			txt_ruc_update.Text = "";
			txt_nombre_update.Text = "";
			txt_descripcion_update.Text = "";
			txt_direccion_update.Text = "";
			txt_telefono_update.Text = "";
			txt_representantelegal_update.Text = "";
            lblMensajeError_update.Text = "";
        }
        private void GuardarEditar()
        {
            string resultado = "";
            var objeto = GetClass_Control_Edit();
             if (Controlador.SqlEmpresa.ValidarCamposNulos(objeto).Count() == 0)
            {
                SitioWeb.Controlador.SqlEmpresa.Update(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, objeto, out resultado);
            }
            else
            {
                resultado = "ERROR||Existen campos obligatorios que llenar";
            }
            lblMensajeError_update.Text = resultado;

            if ((resultado + "|").Split('|')[0].Equals("OK"))
            {
                ExecScriptModalUpdate(false, resultado, true);
                LimpiarControlesEditar();
            }
            else
            {
                ExecScriptModalUpdate(true, resultado, true);
            }
        }

        private void ExecScriptModalUpdate(bool EsVisible, string mensajeRetorno, bool EsPorGuardar)
        {
            string typeMsg = (mensajeRetorno + "|").Split('|')[0];
            string CodigoErrorMsg = ((mensajeRetorno + "|").Split('|').Count() >= 2 ? (mensajeRetorno + "|").Split('|')[1] : "");
            string mesajeMsg = ((mensajeRetorno + "|").Split('|').Count() >= 3 ? (mensajeRetorno + "|").Split('|')[2] : "");
            string script = @"$('#Update-modal-default').modal('" + (EsVisible == true ? "show" : "hide") + "'); ";
            if (EsPorGuardar)
            {
                script += " ShowMessage('','" + CodigoErrorMsg + "', '" + mesajeMsg + "', '" + typeMsg + "')";
            }
            ScriptManager.RegisterStartupScript(this, this.GetType(), Guid.NewGuid().ToString().Replace("-", ""), script, true);
        }
        private SitioWeb.Controlador.ClassEmpresa GetClass_Control_Edit()
        {
            var c = new SitioWeb.Controlador.ClassEmpresa();
             
				 c.uid_empresa= ClasesUtiles.Util.ConvertStringToStringNull(txt_uid_empresa_update.Text);
				 c.ruc= ClasesUtiles.Util.ConvertStringToStringNull(txt_ruc_update.Text);
				 c.nombre= ClasesUtiles.Util.ConvertStringToStringNull(txt_nombre_update.Text);
				 c.descripcion= ClasesUtiles.Util.ConvertStringToStringNull(txt_descripcion_update.Text);
				 c.direccion= ClasesUtiles.Util.ConvertStringToStringNull(txt_direccion_update.Text);
				 c.telefono= ClasesUtiles.Util.ConvertStringToStringNull(txt_telefono_update.Text);
				 c.representantelegal= ClasesUtiles.Util.ConvertStringToStringNull(txt_representantelegal_update.Text);
            return c;
        }
        private void SetControl_Class_Edit(SitioWeb.Controlador.ClassEmpresa c)
        {

           
			txt_uid_empresa_update.Text= c.uid_empresa;
			txt_ruc_update.Text= c.ruc;
			txt_nombre_update.Text= c.nombre;
			txt_descripcion_update.Text= c.descripcion;
			txt_direccion_update.Text= c.direccion;
			txt_telefono_update.Text= c.telefono;
			txt_representantelegal_update.Text= c.representantelegal;

        }
        protected void btnGuardarEditar_Click(object sender, EventArgs e)
        {
            GuardarEditar();
        }

        protected void btnUpdateEmpresaMostrarModal_Click(object sender, EventArgs e)
        {
            CargarControlesEditar();
        }
        private void CargarControlesEditar()
        {
            var uidEmpresa = txt_buscarUpdateUIDEmpresa.Text;

            string resultado = "";
            var retSelect = SitioWeb.Controlador.SqlEmpresa.SelectFirst(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, uidEmpresa, out resultado);
            LimpiarControlesEditar();
            SetControl_Class_Edit(retSelect);
            ExecScriptModalUpdate(true, "", false);
        }
		  private void CargaCombosFKUpdate()
        {
            string resultado = "";
			
        }


    }
}