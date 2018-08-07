using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Empleado
{
    public partial class Empleado_CU_MostrarUnico : System.Web.UI.UserControl
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
        protected void btnSelectEmpleadoMostrarModal_Click(object sender, EventArgs e)
        {
            CargarControlesSelect();
        }
        private void CargarControlesSelect()
        {
            var uidEmpleado = txt_buscarSelectUIDEmpleado.Text;

            string resultado = "";
            var retSelect = SitioWeb.Controlador.SqlEmpleado.SelectFirst(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, uidEmpleado, out resultado);
            LimpiarControlesSelect();
            SetControl_Class_Select(retSelect);
          if (EsModal == true)
            {
                ExecScriptModalSelect(true, "");
            }
        }

		        private void ExecScriptModalSelect(bool EsVisible, string mensajeRetorno)
        {
            string script = @"$('#Select-modal-default-Empleado').modal('" + (EsVisible == true ? "show" : "hide") + "'); ";           
            ScriptManager.RegisterStartupScript(this, this.GetType(), Guid.NewGuid().ToString().Replace("-", ""), script, true);
        }

        private void SetControl_Class_Select(SitioWeb.Controlador.ClassEmpleado c)
        {

           
			txt_uidempleado_select.Text= c.uidempleado;
			txt_codido_select.Text= ClasesUtiles.Util.ConvertIntToString(c.codido);
			txt_cedula_select.Text= c.cedula;
			txt_nombres_select.Text= c.nombres;
			txt_apellidos_select.Text= c.apellidos;
			cb_uidestadocivil_select.SelectedIndex = cb_uidestadocivil_select.Items.IndexOf(cb_uidestadocivil_select.Items.FindByValue(c.uidestadocivil));
			txt_fechanacimiento_select.Text= ClasesUtiles.Util.GetDateOfString(c.fechanacimiento);
			cb_uidsexo_select.SelectedIndex = cb_uidsexo_select.Items.IndexOf(cb_uidsexo_select.Items.FindByValue(c.uidsexo));
			txt_telefono_select.Text= c.telefono;
			txt_num_hijos_select.Text= ClasesUtiles.Util.ConvertIntToString(c.num_hijos);
			cb_uidnivelestudio_select.SelectedIndex = cb_uidnivelestudio_select.Items.IndexOf(cb_uidnivelestudio_select.Items.FindByValue(c.uidnivelestudio));
			txt_titulo_obtenido_select.Text= c.titulo_obtenido;
			txt_direccion_domicilio_select.Text= c.direccion_domicilio;
			txt_provincia_select.Text= c.provincia;
			txt_ciudad_select.Text= c.ciudad;
			txt_email_select.Text= c.email;
			txt_email_trabajo_select.Text= c.email_trabajo;
			txt_fecha_ingreso_select.Text= ClasesUtiles.Util.GetDateOfString(c.fecha_ingreso);
			cb_uidsuario_select.SelectedIndex = cb_uidsuario_select.Items.IndexOf(cb_uidsuario_select.Items.FindByValue(c.uidsuario));

        }

        private void LimpiarControlesSelect()
        {
		     
			txt_uidempleado_select.Text = Guid.NewGuid().ToString();
			txt_codido_select.Text = Guid.NewGuid().ToString();
			txt_cedula_select.Text = "";
			txt_nombres_select.Text = "";
			txt_apellidos_select.Text = "";
			cb_uidestadocivil_select.SelectedIndex =-1;
			txt_fechanacimiento_select.Text = "";
			cb_uidsexo_select.SelectedIndex =-1;
			txt_telefono_select.Text = "";
			txt_num_hijos_select.Text = "";
			cb_uidnivelestudio_select.SelectedIndex =-1;
			txt_titulo_obtenido_select.Text = "";
			txt_direccion_domicilio_select.Text = "";
			txt_provincia_select.Text = "";
			txt_ciudad_select.Text = "";
			txt_email_select.Text = "";
			txt_email_trabajo_select.Text = "";
			txt_fecha_ingreso_select.Text = "";
			cb_uidsuario_select.SelectedIndex =-1;
        }

		  private void CargaCombosFKSelect()
        {
            string resultado = "";
			
			  cb_uidestadocivil_select.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlEstadocivil.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidestadocivil_select.DataTextField = "text"; 
			  cb_uidestadocivil_select.DataValueField = "value"; 
			  cb_uidestadocivil_select.DataBind(); 
			  cb_uidsexo_select.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlSexo.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidsexo_select.DataTextField = "text"; 
			  cb_uidsexo_select.DataValueField = "value"; 
			  cb_uidsexo_select.DataBind(); 
			  cb_uidnivelestudio_select.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlNivelestudio.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidnivelestudio_select.DataTextField = "text"; 
			  cb_uidnivelestudio_select.DataValueField = "value"; 
			  cb_uidnivelestudio_select.DataBind(); 
			  cb_uidsuario_select.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlLoginuser.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidsuario_select.DataTextField = "text"; 
			  cb_uidsuario_select.DataValueField = "value"; 
			  cb_uidsuario_select.DataBind(); 
        }

    }
}