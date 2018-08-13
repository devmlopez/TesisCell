using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Serviciotecnico
{
    public partial class Serviciotecnico_CU_Insert : System.Web.UI.UserControl
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
		
			txt_uidserviciotecnico_insert.Text = Guid.NewGuid().ToString();
			txt_codservicio_insert.Text = "";
			cb_uidcliente_insert.SelectedIndex =-1;
			cb_uidempleado_insert.SelectedIndex =-1;
			txt_fechaingreso_insert.Text = "";
            txt_fechasalida_insert.Text = "";
            txt_IMEI_insert.Text = "0";
            txt_marca_insert.Text = "";
			txt_modelo_insert.Text = "";
			txt_problemasugerido_insert.Text = "";
          
            lblMensajeError_Insert.Text = "";
        }
     

        private void GuardarNuevo()
        {
            string resultado = "";
            var objeto = GetClass_Control_New();
            if (Controlador.SqlServiciotecnico.ValidarCamposNulos(objeto).Count() == 0)
            {
                SitioWeb.Controlador.SqlServiciotecnico.InsertInto(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, objeto, out resultado);
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


		  private SitioWeb.Controlador.ClassServiciotecnico GetClass_Control_New()
        {
            var c=new SitioWeb.Controlador.ClassServiciotecnico();

			
				 c.uidserviciotecnico =ClasesUtiles.Util.ConvertStringToStringNull(txt_uidserviciotecnico_insert.Text);
				c.codservicio= ClasesUtiles.Util.ConvertStringToInt(txt_codservicio_insert.Text);
				 c.uidcliente =ClasesUtiles.Util.ConvertStringToStringNull(cb_uidcliente_insert.SelectedValue as string);
				 c.uidempleado =ClasesUtiles.Util.ConvertStringToStringNull(cb_uidempleado_insert.SelectedValue as string);
				 c.fechaingreso =ClasesUtiles.Util.GetDateOfString(txt_fechaingreso_insert.Text);
            c.fechasalida = ClasesUtiles.Util.GetDateOfString(txt_fechasalida_insert.Text);
            c.IMEI = ClasesUtiles.Util.ConvertStringToStringNull(txt_IMEI_insert.Text);
            c.marca =ClasesUtiles.Util.ConvertStringToStringNull(txt_marca_insert.Text);
				 c.modelo =ClasesUtiles.Util.ConvertStringToStringNull(txt_modelo_insert.Text);
				 c.problemasugerido =ClasesUtiles.Util.ConvertStringToStringNull(txt_problemasugerido_insert.Text);
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
			
			  cb_uidcliente_insert.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlCliente.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidcliente_insert.DataTextField = "text"; 
			  cb_uidcliente_insert.DataValueField = "value"; 
			  cb_uidcliente_insert.DataBind(); 
			  cb_uidempleado_insert.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlEmpleado.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidempleado_insert.DataTextField = "text"; 
			  cb_uidempleado_insert.DataValueField = "value"; 
			  cb_uidempleado_insert.DataBind(); 
        }
    }
}



