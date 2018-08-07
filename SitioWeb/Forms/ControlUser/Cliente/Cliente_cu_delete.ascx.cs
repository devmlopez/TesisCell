using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Cliente
{
    public partial class Cliente_CU_Delete : System.Web.UI.UserControl
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
            var objeto = new Controlador.ClassCliente()
            {
			  
                uidcliente =  txt_buscarDeleteUIDCliente.Text
            };
            SitioWeb.Controlador.SqlCliente.Delete(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, objeto, out resultado);

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
      

        protected void btnDeleteClienteMostrarModal_Click(object sender, EventArgs e)
        {
            CargarControlesDelete();
        }
        private void CargarControlesDelete()
        {
            var uid =txt_buscarDeleteUIDCliente.Text;

            string resultado = "";
            var retSelect = SitioWeb.Controlador.SqlCliente.SelectFirst(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, uid, out resultado);
            LimpiarControlesDelete();
            SetControl_Class_Delete(retSelect);
            ExecScriptModalDelete(true, "", false);
        }
        private void LimpiarControlesDelete()
        {
            
			txt_uidcliente_delete.Text = Guid.NewGuid().ToString();
			txt_id_cliente_delete.Text = Guid.NewGuid().ToString();
			cb_uidtipopersona_delete.SelectedIndex =-1;
			txt_identificacion_delete.Text = "";
			cb_uidtipoidentificacion_delete.SelectedIndex =-1;
			txt_razonsocial_delete.Text = "";
			txt_nombre_delete.Text = "";
			txt_contacto_delete.Text = "";
			txt_celular_delete.Text = "";
			txt_telefono_delete.Text = "";
			txt_direccion_delete.Text = "";
			txt_provincia_delete.Text = "";
			txt_ciudad_delete.Text = "";
			txt_email_delete.Text = "";
			txt_referencia_delete.Text = "";
			txt_observaciones_delete.Text = "";
			cb_uisusuario_delete.SelectedIndex =-1;
            lblMensajeError_delete.Text = "";
        }    
    private void SetControl_Class_Delete(SitioWeb.Controlador.ClassCliente c)
    {
       
			txt_uidcliente_delete.Text= c.uidcliente;
			txt_id_cliente_delete.Text= ClasesUtiles.Util.ConvertIntToString(c.id_cliente);
			cb_uidtipopersona_delete.SelectedIndex = cb_uidtipopersona_delete.Items.IndexOf(cb_uidtipopersona_delete.Items.FindByValue(c.uidtipopersona));
			txt_identificacion_delete.Text= c.identificacion;
			cb_uidtipoidentificacion_delete.SelectedIndex = cb_uidtipoidentificacion_delete.Items.IndexOf(cb_uidtipoidentificacion_delete.Items.FindByValue(c.uidtipoidentificacion));
			txt_razonsocial_delete.Text= c.razonsocial;
			txt_nombre_delete.Text= c.nombre;
			txt_contacto_delete.Text= c.contacto;
			txt_celular_delete.Text= c.celular;
			txt_telefono_delete.Text= c.telefono;
			txt_direccion_delete.Text= c.direccion;
			txt_provincia_delete.Text= c.provincia;
			txt_ciudad_delete.Text= c.ciudad;
			txt_email_delete.Text= c.email;
			txt_referencia_delete.Text= c.referencia;
			txt_observaciones_delete.Text= c.observaciones;
			cb_uisusuario_delete.SelectedIndex = cb_uisusuario_delete.Items.IndexOf(cb_uisusuario_delete.Items.FindByValue(c.uisusuario));
    }

	
	    private void CargaCombosFKDelete()
        {
            string resultado = "";
			
			  cb_uidtipopersona_delete.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlTipopersona.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidtipopersona_delete.DataTextField = "text"; 
			  cb_uidtipopersona_delete.DataValueField = "value"; 
			  cb_uidtipopersona_delete.DataBind(); 
			  cb_uidtipoidentificacion_delete.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlTipoidentificacion.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidtipoidentificacion_delete.DataTextField = "text"; 
			  cb_uidtipoidentificacion_delete.DataValueField = "value"; 
			  cb_uidtipoidentificacion_delete.DataBind(); 
			  cb_uisusuario_delete.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlLoginuser.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uisusuario_delete.DataTextField = "text"; 
			  cb_uisusuario_delete.DataValueField = "value"; 
			  cb_uisusuario_delete.DataBind(); 
        }

    }
}


