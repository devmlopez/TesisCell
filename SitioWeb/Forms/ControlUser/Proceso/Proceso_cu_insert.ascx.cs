using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Proceso
{
    public partial class Proceso_CU_Insert : System.Web.UI.UserControl
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
		
			txt_uidproceso_insert.Text = Guid.NewGuid().ToString();
			txt_codproceso_insert.Text = "";
			cb_uidserviciotecnico_insert.SelectedIndex =-1;
          
            lblMensajeError_Insert.Text = "";
        }
     

        private void GuardarNuevo()
        {
            string resultado = "";
            var objeto = GetClass_Control_New();
            if (Controlador.SqlProceso.ValidarCamposNulos(objeto).Count() == 0)
            {
                SitioWeb.Controlador.SqlProceso.InsertInto(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, objeto, out resultado);
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


		  private SitioWeb.Controlador.ClassProceso GetClass_Control_New()
        {
            var c=new SitioWeb.Controlador.ClassProceso();

			
				 c.uidproceso =ClasesUtiles.Util.ConvertStringToStringNull(txt_uidproceso_insert.Text);
				c.codproceso= ClasesUtiles.Util.ConvertStringToInt(txt_codproceso_insert.Text);
				 c.uidserviciotecnico =ClasesUtiles.Util.ConvertStringToStringNull(cb_uidserviciotecnico_insert.SelectedValue as string);
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
			
			  cb_uidserviciotecnico_insert.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlServiciotecnico.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidserviciotecnico_insert.DataTextField = "text"; 
			  cb_uidserviciotecnico_insert.DataValueField = "value"; 
			  cb_uidserviciotecnico_insert.DataBind(); 
        }
    }
}



