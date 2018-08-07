using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Parametros
{
    public partial class Parametros_CU_Update : System.Web.UI.UserControl
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
           
			txt_uidparmetro_update.Text = Guid.NewGuid().ToString();
			txt_moduloreferencia_update.Text = "";
			txt_value_update.Text = "";
			txt_textshort_update.Text = "";
			txt_textlong_update.Text = "";
            lblMensajeError_update.Text = "";
        }
        private void GuardarEditar()
        {
            string resultado = "";
            var objeto = GetClass_Control_Edit();
            SitioWeb.Controlador.SqlParametros.Update(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, objeto, out resultado);
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
        private SitioWeb.Controlador.ClassParametros GetClass_Control_Edit()
        {
            var c = new SitioWeb.Controlador.ClassParametros();
             
				 c.uidparmetro= ClasesUtiles.Util.ConvertStringToStringNull(txt_uidparmetro_update.Text);
				 c.moduloreferencia= ClasesUtiles.Util.ConvertStringToStringNull(txt_moduloreferencia_update.Text);
				 c.value= ClasesUtiles.Util.ConvertStringToStringNull(txt_value_update.Text);
				 c.textshort= ClasesUtiles.Util.ConvertStringToStringNull(txt_textshort_update.Text);
				 c.textlong= ClasesUtiles.Util.ConvertStringToStringNull(txt_textlong_update.Text);
            return c;
        }
        private void SetControl_Class_Edit(SitioWeb.Controlador.ClassParametros c)
        {

           
			txt_uidparmetro_update.Text= c.uidparmetro;
			txt_moduloreferencia_update.Text= c.moduloreferencia;
			txt_value_update.Text= c.value;
			txt_textshort_update.Text= c.textshort;
			txt_textlong_update.Text= c.textlong;

        }
        protected void btnGuardarEditar_Click(object sender, EventArgs e)
        {
            GuardarEditar();
        }

        protected void btnUpdateParametrosMostrarModal_Click(object sender, EventArgs e)
        {
            CargarControlesEditar();
        }
        private void CargarControlesEditar()
        {
            var uidParametros = txt_buscarUpdateUIDParametros.Text;

            string resultado = "";
            var retSelect = SitioWeb.Controlador.SqlParametros.SelectFirst(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, uidParametros, out resultado);
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