using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Sexo
{
    public partial class Sexo_CU_Update : System.Web.UI.UserControl
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
           
			txt_uidsexo_update.Text = Guid.NewGuid().ToString();
			txt_sexo_update.Text = "";
            lblMensajeError_update.Text = "";
        }
        private void GuardarEditar()
        {
            string resultado = "";
            var objeto = GetClass_Control_Edit();
            SitioWeb.Controlador.SqlSexo.Update(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, objeto, out resultado);
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
        private SitioWeb.Controlador.ClassSexo GetClass_Control_Edit()
        {
            var c = new SitioWeb.Controlador.ClassSexo();
             
				 c.uidsexo= ClasesUtiles.Util.ConvertStringToStringNull(txt_uidsexo_update.Text);
				 c.sexo= ClasesUtiles.Util.ConvertStringToStringNull(txt_sexo_update.Text);
            return c;
        }
        private void SetControl_Class_Edit(SitioWeb.Controlador.ClassSexo c)
        {

           
			txt_uidsexo_update.Text= c.uidsexo;
			txt_sexo_update.Text= c.sexo;

        }
        protected void btnGuardarEditar_Click(object sender, EventArgs e)
        {
            GuardarEditar();
        }

        protected void btnUpdateSexoMostrarModal_Click(object sender, EventArgs e)
        {
            CargarControlesEditar();
        }
        private void CargarControlesEditar()
        {
            var uidSexo = txt_buscarUpdateUIDSexo.Text;

            string resultado = "";
            var retSelect = SitioWeb.Controlador.SqlSexo.SelectFirst(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, uidSexo, out resultado);
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