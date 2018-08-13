using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Cliente
{
    public partial class Cliente_CU_Insert : System.Web.UI.UserControl
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
		
			txt_uidcliente_insert.Text = Guid.NewGuid().ToString();
			txt_id_cliente_insert.Text = Guid.NewGuid().ToString();
			cb_uidtipopersona_insert.SelectedIndex =-1;
			txt_identificacion_insert.Text = "";
			cb_uidtipoidentificacion_insert.SelectedIndex =-1;
			txt_razonsocial_insert.Text = "";
			txt_nombre_insert.Text = "";
			txt_contacto_insert.Text = "";
			txt_celular_insert.Text = "";
			txt_telefono_insert.Text = "";
			txt_direccion_insert.Text = "";
			txt_provincia_insert.Text = "";
			txt_ciudad_insert.Text = "";
			txt_email_insert.Text = "";
			txt_referencia_insert.Text = "";
			txt_observaciones_insert.Text = "";
			cb_uisusuario_insert.SelectedIndex =-1;
          
            lblMensajeError_Insert.Text = "";
        }
     

        private void GuardarNuevo()
        {
            string resultado = "";
            var objeto = GetClass_Control_New();

            if (Controlador.SqlCliente.ValidarCamposNulos(objeto).Count() == 0)
            {
                SitioWeb.Controlador.SqlCliente.InsertInto(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, objeto, out resultado);
            }else
            {
                resultado = "ERROR||Existen campos obligatorios que llenar";
            }
                lblMensajeError_Insert.Text = resultado;
              //  resultado = resultado.Replace("ERROR|", "OK|");
          
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
        

		  private SitioWeb.Controlador.ClassCliente GetClass_Control_New()
        {
            var c=new SitioWeb.Controlador.ClassCliente();

			
				 c.uidcliente =ClasesUtiles.Util.ConvertStringToStringNull(txt_uidcliente_insert.Text);
				c.id_cliente= ClasesUtiles.Util.ConvertStringToInt(txt_id_cliente_insert.Text);
				 c.uidtipopersona =ClasesUtiles.Util.ConvertStringToStringNull(cb_uidtipopersona_insert.SelectedValue as string);
				 c.identificacion =ClasesUtiles.Util.ConvertStringToStringNull(txt_identificacion_insert.Text);
				 c.uidtipoidentificacion =ClasesUtiles.Util.ConvertStringToStringNull(cb_uidtipoidentificacion_insert.SelectedValue as string);
				 c.razonsocial =ClasesUtiles.Util.ConvertStringToStringNull(txt_razonsocial_insert.Text);
				 c.nombre =ClasesUtiles.Util.ConvertStringToStringNull(txt_nombre_insert.Text);
				 c.contacto =ClasesUtiles.Util.ConvertStringToStringNull(txt_contacto_insert.Text);
				 c.celular =ClasesUtiles.Util.ConvertStringToStringNull(txt_celular_insert.Text);
				 c.telefono =ClasesUtiles.Util.ConvertStringToStringNull(txt_telefono_insert.Text);
				 c.direccion =ClasesUtiles.Util.ConvertStringToStringNull(txt_direccion_insert.Text);
				 c.provincia =ClasesUtiles.Util.ConvertStringToStringNull(txt_provincia_insert.Text);
				 c.ciudad =ClasesUtiles.Util.ConvertStringToStringNull(txt_ciudad_insert.Text);
				 c.email =ClasesUtiles.Util.ConvertStringToStringNull(txt_email_insert.Text);
				 c.referencia =ClasesUtiles.Util.ConvertStringToStringNull(txt_referencia_insert.Text);
				 c.observaciones =ClasesUtiles.Util.ConvertStringToStringNull(txt_observaciones_insert.Text);
				 c.uisusuario =ClasesUtiles.Util.ConvertStringToStringNull(cb_uisusuario_insert.SelectedValue as string);
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
			
			  cb_uidtipopersona_insert.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlTipopersona.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidtipopersona_insert.DataTextField = "text"; 
			  cb_uidtipopersona_insert.DataValueField = "value"; 
			  cb_uidtipopersona_insert.DataBind(); 
			  cb_uidtipoidentificacion_insert.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlTipoidentificacion.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidtipoidentificacion_insert.DataTextField = "text"; 
			  cb_uidtipoidentificacion_insert.DataValueField = "value"; 
			  cb_uidtipoidentificacion_insert.DataBind(); 
			  cb_uisusuario_insert.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlLoginuser.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uisusuario_insert.DataTextField = "text"; 
			  cb_uisusuario_insert.DataValueField = "value"; 
			  cb_uisusuario_insert.DataBind(); 
        }
    }
}



