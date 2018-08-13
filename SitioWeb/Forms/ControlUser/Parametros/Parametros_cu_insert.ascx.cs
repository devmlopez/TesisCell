using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Parametros
{
    public partial class Parametros_CU_Insert : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LimpiarControlesNuevo();
                CargaCombosFKInsert();
            }
        }

        protected void btnGuardarNuevo_Click(object sender, EventArgs e)
        {
            GuardarNuevo();
        }

		 private void LimpiarControlesNuevo()
        {
		
			txt_uidparmetro_insert.Text = Guid.NewGuid().ToString();
			txt_moduloreferencia_insert.Text = "";
			txt_value_insert.Text = "";
			txt_textshort_insert.Text = "";
			txt_textlong_insert.Text = "";
          
            lblMensajeError_Insert.Text = "";
        }
     

        private void GuardarNuevo()
        {
            string resultado = "";
            var objeto = GetClass_Control_New();
            if (Controlador.SqlParametros.ValidarCamposNulos(objeto).Count() == 0)
            {
                SitioWeb.Controlador.SqlParametros.InsertInto(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, objeto, out resultado);
            }
            else
            {
                resultado = "ERROR||Existen campos obligatorios que llenar";
            }

            lblMensajeError_Insert.Text = resultado;

            if ((resultado + "|").Split('|')[0].Equals("OK"))
            {
                ExecScriptModalInsert(false, resultado);
                LimpiarControlesNuevo();
            }
            else
            {
                ExecScriptModalInsert(true, resultado);
            }
        }


		  private SitioWeb.Controlador.ClassParametros GetClass_Control_New()
        {
            var c=new SitioWeb.Controlador.ClassParametros();

			
				 c.uidparmetro =ClasesUtiles.Util.ConvertStringToStringNull(txt_uidparmetro_insert.Text);
				 c.moduloreferencia =ClasesUtiles.Util.ConvertStringToStringNull(txt_moduloreferencia_insert.Text);
				 c.value =ClasesUtiles.Util.ConvertStringToStringNull(txt_value_insert.Text);
				 c.textshort =ClasesUtiles.Util.ConvertStringToStringNull(txt_textshort_insert.Text);
				 c.textlong =ClasesUtiles.Util.ConvertStringToStringNull(txt_textlong_insert.Text);
            return c;
        }

        private void ExecScriptModalInsert(bool EsVisible, string mensajeRetorno)
        {
            string typeMsg = (mensajeRetorno + "|").Split('|')[0];
            string CodigoErrorMsg = ((mensajeRetorno + "|").Split('|').Count() >= 2 ? (mensajeRetorno + "|").Split('|')[1] : "");
            string mesajeMsg = ((mensajeRetorno + "|").Split('|').Count() >= 3 ? (mensajeRetorno + "|").Split('|')[2] : "");
            string script = @"$('#Inser-modal-default').modal('" + (EsVisible == true ? "show" : "hide") + "'); ";
            script += " ShowMessage('','" + CodigoErrorMsg + "', '" + mesajeMsg + "', '" + typeMsg + "')";
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), Guid.NewGuid().ToString().Replace("-", ""), script, true);
        }
        private void CargaCombosFKInsert()
        {
            string resultado = "";
			
        }
    }
}



