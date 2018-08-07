using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Errores
{
    public partial class Errores_CU_Insert : System.Web.UI.UserControl
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
		
			txt_uid_error_insert.Text = Guid.NewGuid().ToString();
			txt_cod_error_insert.Text = "";
			txt_mensajeusuario_insert.Text = "";
			txt_mensajenativo_insert.Text = "";
			txt_origenerror_insert.Text = "";
			txt_tipoerror_insert.Text = "";
          
            lblMensajeError_Insert.Text = "";
        }
     

        private void GuardarNuevo()
        {
            string resultado = "";
            var objeto = GetClass_Control_New();
            SitioWeb.Controlador.SqlErrores.InsertInto(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, objeto, out resultado);
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


		  private SitioWeb.Controlador.ClassErrores GetClass_Control_New()
        {
            var c=new SitioWeb.Controlador.ClassErrores();

			
				 c.uid_error =ClasesUtiles.Util.ConvertStringToStringNull(txt_uid_error_insert.Text);
				 c.cod_error =ClasesUtiles.Util.ConvertStringToStringNull(txt_cod_error_insert.Text);
				 c.mensajeusuario =ClasesUtiles.Util.ConvertStringToStringNull(txt_mensajeusuario_insert.Text);
				 c.mensajenativo =ClasesUtiles.Util.ConvertStringToStringNull(txt_mensajenativo_insert.Text);
				 c.origenerror =ClasesUtiles.Util.ConvertStringToStringNull(txt_origenerror_insert.Text);
				 c.tipoerror =ClasesUtiles.Util.ConvertStringToStringNull(txt_tipoerror_insert.Text);
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



