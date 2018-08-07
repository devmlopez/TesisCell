using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Proveedor
{
    public partial class Proveedor_CU_MostrarUnico : System.Web.UI.UserControl
    {
	  public bool EsModal { get; set; } = false;

        protected void Page_Load(object sender, EventArgs e)
        {
		if (!IsPostBack)
            {
                LimpiarControlesSelect();
                CargaCombosFKSelect();
            }
        }
        protected void btnSelectProveedorMostrarModal_Click(object sender, EventArgs e)
        {
            CargarControlesSelect();
        }
        private void CargarControlesSelect()
        {
            var uidProveedor = txt_buscarSelectUIDProveedor.Text;

            string resultado = "";
            var retSelect = SitioWeb.Controlador.SqlProveedor.SelectFirst(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, uidProveedor, out resultado);
            LimpiarControlesSelect();
            SetControl_Class_Select(retSelect);
          if (EsModal == true)
            {
                ExecScriptModalSelect(true, "");
            }
        }

		        private void ExecScriptModalSelect(bool EsVisible, string mensajeRetorno)
        {
            string script = @"$('#Select-modal-default-Proveedor').modal('" + (EsVisible == true ? "show" : "hide") + "'); ";           
            ScriptManager.RegisterStartupScript(this, this.GetType(), Guid.NewGuid().ToString().Replace("-", ""), script, true);
        }

        private void SetControl_Class_Select(SitioWeb.Controlador.ClassProveedor c)
        {

           
			txt_uidproveedor_select.Text= c.uidproveedor;
			txt_id_proveedor_select.Text= ClasesUtiles.Util.ConvertIntToString(c.id_proveedor);
			cb_uidtipopersona_select.SelectedIndex = cb_uidtipopersona_select.Items.IndexOf(cb_uidtipopersona_select.Items.FindByValue(c.uidtipopersona));
			txt_identificacion_select.Text= c.identificacion;
			cb_uidtipoidentificacion_select.SelectedIndex = cb_uidtipoidentificacion_select.Items.IndexOf(cb_uidtipoidentificacion_select.Items.FindByValue(c.uidtipoidentificacion));
			txt_razonsocial_select.Text= c.razonsocial;
			txt_nombre_select.Text= c.nombre;
			txt_contacto_select.Text= c.contacto;
			txt_celular_select.Text= c.celular;
			txt_telefono_select.Text= c.telefono;
			txt_direccion_select.Text= c.direccion;
			txt_provincia_select.Text= c.provincia;
			txt_ciudad_select.Text= c.ciudad;
			txt_email_select.Text= c.email;
			txt_referencia_select.Text= c.referencia;
			txt_observaciones_select.Text= c.observaciones;
			txt_pagina_web_select.Text= c.pagina_web;

        }

        private void LimpiarControlesSelect()
        {
		     
			txt_uidproveedor_select.Text = Guid.NewGuid().ToString();
			txt_id_proveedor_select.Text = Guid.NewGuid().ToString();
			cb_uidtipopersona_select.SelectedIndex =-1;
			txt_identificacion_select.Text = "";
			cb_uidtipoidentificacion_select.SelectedIndex =-1;
			txt_razonsocial_select.Text = "";
			txt_nombre_select.Text = "";
			txt_contacto_select.Text = "";
			txt_celular_select.Text = "";
			txt_telefono_select.Text = "";
			txt_direccion_select.Text = "";
			txt_provincia_select.Text = "";
			txt_ciudad_select.Text = "";
			txt_email_select.Text = "";
			txt_referencia_select.Text = "";
			txt_observaciones_select.Text = "";
			txt_pagina_web_select.Text = "";
        }

		  private void CargaCombosFKSelect()
        {
            string resultado = "";
			
			  cb_uidtipopersona_select.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlTipopersona.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidtipopersona_select.DataTextField = "text"; 
			  cb_uidtipopersona_select.DataValueField = "value"; 
			  cb_uidtipopersona_select.DataBind(); 
			  cb_uidtipoidentificacion_select.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlTipoidentificacion.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidtipoidentificacion_select.DataTextField = "text"; 
			  cb_uidtipoidentificacion_select.DataValueField = "value"; 
			  cb_uidtipoidentificacion_select.DataBind(); 
        }

    }
}