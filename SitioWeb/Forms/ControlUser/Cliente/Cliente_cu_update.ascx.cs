using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Cliente
{
    public partial class Cliente_CU_Update : System.Web.UI.UserControl
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
           
			txt_uidcliente_update.Text = Guid.NewGuid().ToString();
			txt_id_cliente_update.Text = Guid.NewGuid().ToString();
			cb_uidtipopersona_update.SelectedIndex =-1;
			txt_identificacion_update.Text = "";
			cb_uidtipoidentificacion_update.SelectedIndex =-1;
			txt_razonsocial_update.Text = "";
			txt_nombre_update.Text = "";
			txt_contacto_update.Text = "";
			txt_celular_update.Text = "";
			txt_telefono_update.Text = "";
			txt_direccion_update.Text = "";
			txt_provincia_update.Text = "";
			txt_ciudad_update.Text = "";
			txt_email_update.Text = "";
			txt_referencia_update.Text = "";
			txt_observaciones_update.Text = "";
			cb_uisusuario_update.SelectedIndex =-1;
            lblMensajeError_update.Text = "";
        }
        private void GuardarEditar()
        {
            string resultado = "";
            var objeto = GetClass_Control_Edit();

            if (Controlador.SqlCliente.ValidarCamposNulos(objeto).Count() == 0)
            {
                SitioWeb.Controlador.SqlCliente.Update(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, objeto, out resultado);
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
        private SitioWeb.Controlador.ClassCliente GetClass_Control_Edit()
        {
            var c = new SitioWeb.Controlador.ClassCliente();
             
				 c.uidcliente= ClasesUtiles.Util.ConvertStringToStringNull(txt_uidcliente_update.Text);
				 c.id_cliente= ClasesUtiles.Util.ConvertStringToInt(txt_id_cliente_update.Text);
				 c.uidtipopersona= ClasesUtiles.Util.ConvertStringToStringNull(cb_uidtipopersona_update.SelectedValue as string);
				 c.identificacion= ClasesUtiles.Util.ConvertStringToStringNull(txt_identificacion_update.Text);
				 c.uidtipoidentificacion= ClasesUtiles.Util.ConvertStringToStringNull(cb_uidtipoidentificacion_update.SelectedValue as string);
				 c.razonsocial= ClasesUtiles.Util.ConvertStringToStringNull(txt_razonsocial_update.Text);
				 c.nombre= ClasesUtiles.Util.ConvertStringToStringNull(txt_nombre_update.Text);
				 c.contacto= ClasesUtiles.Util.ConvertStringToStringNull(txt_contacto_update.Text);
				 c.celular= ClasesUtiles.Util.ConvertStringToStringNull(txt_celular_update.Text);
				 c.telefono= ClasesUtiles.Util.ConvertStringToStringNull(txt_telefono_update.Text);
				 c.direccion= ClasesUtiles.Util.ConvertStringToStringNull(txt_direccion_update.Text);
				 c.provincia= ClasesUtiles.Util.ConvertStringToStringNull(txt_provincia_update.Text);
				 c.ciudad= ClasesUtiles.Util.ConvertStringToStringNull(txt_ciudad_update.Text);
				 c.email= ClasesUtiles.Util.ConvertStringToStringNull(txt_email_update.Text);
				 c.referencia= ClasesUtiles.Util.ConvertStringToStringNull(txt_referencia_update.Text);
				 c.observaciones= ClasesUtiles.Util.ConvertStringToStringNull(txt_observaciones_update.Text);
				 c.uisusuario= ClasesUtiles.Util.ConvertStringToStringNull(cb_uisusuario_update.SelectedValue as string);
            return c;
        }
        private void SetControl_Class_Edit(SitioWeb.Controlador.ClassCliente c)
        {

           
			txt_uidcliente_update.Text= c.uidcliente;
			txt_id_cliente_update.Text= ClasesUtiles.Util.ConvertIntToString(c.id_cliente);
			cb_uidtipopersona_update.SelectedIndex = cb_uidtipopersona_update.Items.IndexOf(cb_uidtipopersona_update.Items.FindByValue(c.uidtipopersona));
			txt_identificacion_update.Text= c.identificacion;
			cb_uidtipoidentificacion_update.SelectedIndex = cb_uidtipoidentificacion_update.Items.IndexOf(cb_uidtipoidentificacion_update.Items.FindByValue(c.uidtipoidentificacion));
			txt_razonsocial_update.Text= c.razonsocial;
			txt_nombre_update.Text= c.nombre;
			txt_contacto_update.Text= c.contacto;
			txt_celular_update.Text= c.celular;
			txt_telefono_update.Text= c.telefono;
			txt_direccion_update.Text= c.direccion;
			txt_provincia_update.Text= c.provincia;
			txt_ciudad_update.Text= c.ciudad;
			txt_email_update.Text= c.email;
			txt_referencia_update.Text= c.referencia;
			txt_observaciones_update.Text= c.observaciones;
			cb_uisusuario_update.SelectedIndex = cb_uisusuario_update.Items.IndexOf(cb_uisusuario_update.Items.FindByValue(c.uisusuario));

        }
        protected void btnGuardarEditar_Click(object sender, EventArgs e)
        {
            GuardarEditar();
        }

        protected void btnUpdateClienteMostrarModal_Click(object sender, EventArgs e)
        {
            CargarControlesEditar();
        }
        private void CargarControlesEditar()
        {
            var uidCliente = txt_buscarUpdateUIDCliente.Text;

            string resultado = "";
            var retSelect = SitioWeb.Controlador.SqlCliente.SelectFirst(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, uidCliente, out resultado);
            LimpiarControlesEditar();
            SetControl_Class_Edit(retSelect);
            ExecScriptModalUpdate(true, "", false);
        }
		  private void CargaCombosFKUpdate()
        {
            string resultado = "";
			
			  cb_uidtipopersona_update.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlTipopersona.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidtipopersona_update.DataTextField = "text"; 
			  cb_uidtipopersona_update.DataValueField = "value"; 
			  cb_uidtipopersona_update.DataBind(); 
			  cb_uidtipoidentificacion_update.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlTipoidentificacion.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidtipoidentificacion_update.DataTextField = "text"; 
			  cb_uidtipoidentificacion_update.DataValueField = "value"; 
			  cb_uidtipoidentificacion_update.DataBind(); 
			  cb_uisusuario_update.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlLoginuser.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uisusuario_update.DataTextField = "text"; 
			  cb_uisusuario_update.DataValueField = "value"; 
			  cb_uisusuario_update.DataBind(); 
        }


    }
}