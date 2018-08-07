using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Serviciotecnico
{
    public partial class Serviciotecnico_CU_Update : System.Web.UI.UserControl
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
           
			txt_uidserviciotecnico_update.Text = Guid.NewGuid().ToString();
			txt_codservicio_update.Text = "";
			cb_uidcliente_update.SelectedIndex =-1;
			cb_uidempleado_update.SelectedIndex =-1;
			txt_fechaingreso_update.Text = "";
			txt_marca_update.Text = "";
			txt_modelo_update.Text = "";
			txt_problemasugerido_update.Text = "";
            lblMensajeError_update.Text = "";
        }
        private void GuardarEditar()
        {
            string resultado = "";
            var objeto = GetClass_Control_Edit();
            SitioWeb.Controlador.SqlServiciotecnico.Update(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, objeto, out resultado);
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
        private SitioWeb.Controlador.ClassServiciotecnico GetClass_Control_Edit()
        {
            var c = new SitioWeb.Controlador.ClassServiciotecnico();
             
				 c.uidserviciotecnico= ClasesUtiles.Util.ConvertStringToStringNull(txt_uidserviciotecnico_update.Text);
				 c.codservicio= ClasesUtiles.Util.ConvertStringToInt(txt_codservicio_update.Text);
				 c.uidcliente= ClasesUtiles.Util.ConvertStringToStringNull(cb_uidcliente_update.SelectedValue as string);
				 c.uidempleado= ClasesUtiles.Util.ConvertStringToStringNull(cb_uidempleado_update.SelectedValue as string);
				 c.fechaingreso= ClasesUtiles.Util.GetDateOfString(txt_fechaingreso_update.Text);
				 c.marca= ClasesUtiles.Util.ConvertStringToStringNull(txt_marca_update.Text);
				 c.modelo= ClasesUtiles.Util.ConvertStringToStringNull(txt_modelo_update.Text);
				 c.problemasugerido= ClasesUtiles.Util.ConvertStringToStringNull(txt_problemasugerido_update.Text);
            return c;
        }
        private void SetControl_Class_Edit(SitioWeb.Controlador.ClassServiciotecnico c)
        {

           
			txt_uidserviciotecnico_update.Text= c.uidserviciotecnico;
			txt_codservicio_update.Text= ClasesUtiles.Util.ConvertIntToString(c.codservicio);
			cb_uidcliente_update.SelectedIndex = cb_uidcliente_update.Items.IndexOf(cb_uidcliente_update.Items.FindByValue(c.uidcliente));
			cb_uidempleado_update.SelectedIndex = cb_uidempleado_update.Items.IndexOf(cb_uidempleado_update.Items.FindByValue(c.uidempleado));
			txt_fechaingreso_update.Text= ClasesUtiles.Util.GetDateOfString(c.fechaingreso);
			txt_marca_update.Text= c.marca;
			txt_modelo_update.Text= c.modelo;
			txt_problemasugerido_update.Text= c.problemasugerido;

        }
        protected void btnGuardarEditar_Click(object sender, EventArgs e)
        {
            GuardarEditar();
        }

        protected void btnUpdateServiciotecnicoMostrarModal_Click(object sender, EventArgs e)
        {
            CargarControlesEditar();
        }
        private void CargarControlesEditar()
        {
            var uidServiciotecnico = txt_buscarUpdateUIDServiciotecnico.Text;

            string resultado = "";
            var retSelect = SitioWeb.Controlador.SqlServiciotecnico.SelectFirst(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, uidServiciotecnico, out resultado);
            LimpiarControlesEditar();
            SetControl_Class_Edit(retSelect);
            ExecScriptModalUpdate(true, "", false);
        }
		  private void CargaCombosFKUpdate()
        {
            string resultado = "";
			
			  cb_uidcliente_update.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlCliente.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidcliente_update.DataTextField = "text"; 
			  cb_uidcliente_update.DataValueField = "value"; 
			  cb_uidcliente_update.DataBind(); 
			  cb_uidempleado_update.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlEmpleado.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidempleado_update.DataTextField = "text"; 
			  cb_uidempleado_update.DataValueField = "value"; 
			  cb_uidempleado_update.DataBind(); 
        }


    }
}