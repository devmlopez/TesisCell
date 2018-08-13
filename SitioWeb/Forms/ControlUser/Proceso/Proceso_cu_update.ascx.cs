using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Proceso
{
    public partial class Proceso_CU_Update : System.Web.UI.UserControl
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
           
			txt_uidproceso_update.Text = Guid.NewGuid().ToString();
			txt_codproceso_update.Text = "";
			cb_uidserviciotecnico_update.SelectedIndex =-1;
            lblMensajeError_update.Text = "";
        }
        private void GuardarEditar()
        {
            string resultado = "";
            var objeto = GetClass_Control_Edit();
            if (Controlador.SqlProceso.ValidarCamposNulos(objeto).Count() == 0)
            {
                SitioWeb.Controlador.SqlProceso.Update(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, objeto, out resultado);
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
        private SitioWeb.Controlador.ClassProceso GetClass_Control_Edit()
        {
            var c = new SitioWeb.Controlador.ClassProceso();
             
				 c.uidproceso= ClasesUtiles.Util.ConvertStringToStringNull(txt_uidproceso_update.Text);
				 c.codproceso= ClasesUtiles.Util.ConvertStringToInt(txt_codproceso_update.Text);
				 c.uidserviciotecnico= ClasesUtiles.Util.ConvertStringToStringNull(cb_uidserviciotecnico_update.SelectedValue as string);
            return c;
        }
        private void SetControl_Class_Edit(SitioWeb.Controlador.ClassProceso c)
        {

           
			txt_uidproceso_update.Text= c.uidproceso;
			txt_codproceso_update.Text= ClasesUtiles.Util.ConvertIntToString(c.codproceso);
			cb_uidserviciotecnico_update.SelectedIndex = cb_uidserviciotecnico_update.Items.IndexOf(cb_uidserviciotecnico_update.Items.FindByValue(c.uidserviciotecnico));

        }
        protected void btnGuardarEditar_Click(object sender, EventArgs e)
        {
            GuardarEditar();
        }

        protected void btnUpdateProcesoMostrarModal_Click(object sender, EventArgs e)
        {
            CargarControlesEditar();
        }
        private void CargarControlesEditar()
        {
            var uidProceso = txt_buscarUpdateUIDProceso.Text;

            string resultado = "";
            var retSelect = SitioWeb.Controlador.SqlProceso.SelectFirst(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, uidProceso, out resultado);
            LimpiarControlesEditar();
            SetControl_Class_Edit(retSelect);
            ExecScriptModalUpdate(true, "", false);
        }
		  private void CargaCombosFKUpdate()
        {
            string resultado = "";
			
			  cb_uidserviciotecnico_update.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlServiciotecnico.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidserviciotecnico_update.DataTextField = "text"; 
			  cb_uidserviciotecnico_update.DataValueField = "value"; 
			  cb_uidserviciotecnico_update.DataBind(); 
        }


    }
}