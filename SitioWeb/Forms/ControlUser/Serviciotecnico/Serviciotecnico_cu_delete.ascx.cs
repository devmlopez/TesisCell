using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Serviciotecnico
{
    public partial class Serviciotecnico_CU_Delete : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
		 if (!IsPostBack)
            {
                LimpiarControlesDelete();
                CargaCombosFKDelete();
            }
        }      
        private void ExecScriptModalDelete(bool EsVisible, string mensajeRetorno, bool EsPorGuardar)
        {
            string typeMsg = (mensajeRetorno + "|").Split('|')[0];
            string CodigoErrorMsg = ((mensajeRetorno + "|").Split('|').Count() >= 2 ? (mensajeRetorno + "|").Split('|')[1] : "");
            string mesajeMsg = ((mensajeRetorno + "|").Split('|').Count() >= 3 ? (mensajeRetorno + "|").Split('|')[2] : "");
            string script = @"$('#Delete-modal-default').modal('" + (EsVisible == true ? "show" : "hide") + "'); ";
            if (EsPorGuardar)
            {
                script += " ShowMessage('','" + CodigoErrorMsg + "', '" + mesajeMsg + "', '" + typeMsg + "')";
            }
            ScriptManager.RegisterStartupScript(this, this.GetType(), Guid.NewGuid().ToString().Replace("-", ""), script, true);
        }
        private void GuardarElimina()
        {
            string resultado = "";
            var objeto = new Controlador.ClassServiciotecnico()
            {
			  
                uidserviciotecnico =  txt_buscarDeleteUIDServiciotecnico.Text
            };
            SitioWeb.Controlador.SqlServiciotecnico.Delete(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, objeto, out resultado);

            if ((resultado + "|").Split('|')[0].Equals("OK"))
            {
                ExecScriptModalDelete(false, resultado, true);
                // CargarGridView();
            }
            else
            {
                ExecScriptModalDelete(true, resultado, true);
            }
        }

        protected void btnGuardarEliminar_Click(object sender, EventArgs e)
        {
            GuardarElimina();
        }
      

        protected void btnDeleteServiciotecnicoMostrarModal_Click(object sender, EventArgs e)
        {
            CargarControlesDelete();
        }
        private void CargarControlesDelete()
        {
            var uid =txt_buscarDeleteUIDServiciotecnico.Text;

            string resultado = "";
            var retSelect = SitioWeb.Controlador.SqlServiciotecnico.SelectFirst(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, uid, out resultado);
            LimpiarControlesDelete();
            SetControl_Class_Delete(retSelect);
            ExecScriptModalDelete(true, "", false);
        }
        private void LimpiarControlesDelete()
        {
            
			txt_uidserviciotecnico_delete.Text = Guid.NewGuid().ToString();
			txt_codservicio_delete.Text = "";
			cb_uidcliente_delete.SelectedIndex =-1;
			cb_uidempleado_delete.SelectedIndex =-1;
            txt_fechaingreso_delete.Text = "";
            txt_fechasalida_delete.Text = "";
            txt_IMEI_delete.Text = "";
            txt_marca_delete.Text = "";
			txt_modelo_delete.Text = "";
			txt_problemasugerido_delete.Text = "";
            lblMensajeError_delete.Text = "";
        }    
    private void SetControl_Class_Delete(SitioWeb.Controlador.ClassServiciotecnico c)
    {
       
			txt_uidserviciotecnico_delete.Text= c.uidserviciotecnico;
			txt_codservicio_delete.Text= ClasesUtiles.Util.ConvertIntToString(c.codservicio);
			cb_uidcliente_delete.SelectedIndex = cb_uidcliente_delete.Items.IndexOf(cb_uidcliente_delete.Items.FindByValue(c.uidcliente));
			cb_uidempleado_delete.SelectedIndex = cb_uidempleado_delete.Items.IndexOf(cb_uidempleado_delete.Items.FindByValue(c.uidempleado));
            txt_fechaingreso_delete.Text = ClasesUtiles.Util.GetDateOfString(c.fechaingreso);
            txt_fechasalida_delete.Text = ClasesUtiles.Util.GetDateOfString(c.fechasalida);
            txt_IMEI_delete.Text = ClasesUtiles.Util.ConvertStringToStringNull(c.IMEI);            
            txt_marca_delete.Text= c.marca;
			txt_modelo_delete.Text= c.modelo;
			txt_problemasugerido_delete.Text= c.problemasugerido;
    }

	
	    private void CargaCombosFKDelete()
        {
            string resultado = "";
			
			  cb_uidcliente_delete.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlCliente.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidcliente_delete.DataTextField = "text"; 
			  cb_uidcliente_delete.DataValueField = "value"; 
			  cb_uidcliente_delete.DataBind(); 
			  cb_uidempleado_delete.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlEmpleado.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidempleado_delete.DataTextField = "text"; 
			  cb_uidempleado_delete.DataValueField = "value"; 
			  cb_uidempleado_delete.DataBind(); 
        }

    }
}


