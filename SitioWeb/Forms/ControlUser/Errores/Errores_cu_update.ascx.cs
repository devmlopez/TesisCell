using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Errores
{
    public partial class Errores_CU_Update : System.Web.UI.UserControl
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
           
			txt_uid_error_update.Text = Guid.NewGuid().ToString();
			txt_cod_error_update.Text = "";
			txt_mensajeusuario_update.Text = "";
			txt_mensajenativo_update.Text = "";
			txt_origenerror_update.Text = "";
			txt_tipoerror_update.Text = "";
            lblMensajeError_update.Text = "";
        }
        private void GuardarEditar()
        {
            string resultado = "";
            var objeto = GetClass_Control_Edit();
            if (Controlador.SqlErrores.ValidarCamposNulos(objeto).Count() == 0)
            {
                SitioWeb.Controlador.SqlErrores.Update(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, objeto, out resultado);
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
        private SitioWeb.Controlador.ClassErrores GetClass_Control_Edit()
        {
            var c = new SitioWeb.Controlador.ClassErrores();
             
				 c.uid_error= ClasesUtiles.Util.ConvertStringToStringNull(txt_uid_error_update.Text);
				 c.cod_error= ClasesUtiles.Util.ConvertStringToStringNull(txt_cod_error_update.Text);
				 c.mensajeusuario= ClasesUtiles.Util.ConvertStringToStringNull(txt_mensajeusuario_update.Text);
				 c.mensajenativo= ClasesUtiles.Util.ConvertStringToStringNull(txt_mensajenativo_update.Text);
				 c.origenerror= ClasesUtiles.Util.ConvertStringToStringNull(txt_origenerror_update.Text);
				 c.tipoerror= ClasesUtiles.Util.ConvertStringToStringNull(txt_tipoerror_update.Text);
            return c;
        }
        private void SetControl_Class_Edit(SitioWeb.Controlador.ClassErrores c)
        {

           
			txt_uid_error_update.Text= c.uid_error;
			txt_cod_error_update.Text= c.cod_error;
			txt_mensajeusuario_update.Text= c.mensajeusuario;
			txt_mensajenativo_update.Text= c.mensajenativo;
			txt_origenerror_update.Text= c.origenerror;
			txt_tipoerror_update.Text= c.tipoerror;

        }
        protected void btnGuardarEditar_Click(object sender, EventArgs e)
        {
            GuardarEditar();
        }

        protected void btnUpdateErroresMostrarModal_Click(object sender, EventArgs e)
        {
            CargarControlesEditar();
        }
        private void CargarControlesEditar()
        {
            var uidErrores = txt_buscarUpdateUIDErrores.Text;

            string resultado = "";
            var retSelect = SitioWeb.Controlador.SqlErrores.SelectFirst(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, uidErrores, out resultado);
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