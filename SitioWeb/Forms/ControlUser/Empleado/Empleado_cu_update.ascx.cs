using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Empleado
{
    public partial class Empleado_CU_Update : System.Web.UI.UserControl
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
           
			txt_uidempleado_update.Text = Guid.NewGuid().ToString();
			txt_codido_update.Text = Guid.NewGuid().ToString();
			txt_cedula_update.Text = "";
			txt_nombres_update.Text = "";
			txt_apellidos_update.Text = "";
			cb_uidestadocivil_update.SelectedIndex =-1;
			txt_fechanacimiento_update.Text = "";
			cb_uidsexo_update.SelectedIndex =-1;
			txt_telefono_update.Text = "";
			txt_num_hijos_update.Text = "";
			cb_uidnivelestudio_update.SelectedIndex =-1;
			txt_titulo_obtenido_update.Text = "";
			txt_direccion_domicilio_update.Text = "";
			txt_provincia_update.Text = "";
			txt_ciudad_update.Text = "";
			txt_email_update.Text = "";
			txt_email_trabajo_update.Text = "";
			txt_fecha_ingreso_update.Text = "";
			cb_uidsuario_update.SelectedIndex =-1;
            lblMensajeError_update.Text = "";
        }
        private void GuardarEditar()
        {
            string resultado = "";
            var objeto = GetClass_Control_Edit();
            SitioWeb.Controlador.SqlEmpleado.Update(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, objeto, out resultado);
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
        private SitioWeb.Controlador.ClassEmpleado GetClass_Control_Edit()
        {
            var c = new SitioWeb.Controlador.ClassEmpleado();
             
				 c.uidempleado= ClasesUtiles.Util.ConvertStringToStringNull(txt_uidempleado_update.Text);
				 c.codido= ClasesUtiles.Util.ConvertStringToInt(txt_codido_update.Text);
				 c.cedula= ClasesUtiles.Util.ConvertStringToStringNull(txt_cedula_update.Text);
				 c.nombres= ClasesUtiles.Util.ConvertStringToStringNull(txt_nombres_update.Text);
				 c.apellidos= ClasesUtiles.Util.ConvertStringToStringNull(txt_apellidos_update.Text);
				 c.uidestadocivil= ClasesUtiles.Util.ConvertStringToStringNull(cb_uidestadocivil_update.SelectedValue as string);
				 c.fechanacimiento= ClasesUtiles.Util.GetDateOfString(txt_fechanacimiento_update.Text);
				 c.uidsexo= ClasesUtiles.Util.ConvertStringToStringNull(cb_uidsexo_update.SelectedValue as string);
				 c.telefono= ClasesUtiles.Util.ConvertStringToStringNull(txt_telefono_update.Text);
				 c.num_hijos= ClasesUtiles.Util.ConvertStringToInt(txt_num_hijos_update.Text);
				 c.uidnivelestudio= ClasesUtiles.Util.ConvertStringToStringNull(cb_uidnivelestudio_update.SelectedValue as string);
				 c.titulo_obtenido= ClasesUtiles.Util.ConvertStringToStringNull(txt_titulo_obtenido_update.Text);
				 c.direccion_domicilio= ClasesUtiles.Util.ConvertStringToStringNull(txt_direccion_domicilio_update.Text);
				 c.provincia= ClasesUtiles.Util.ConvertStringToStringNull(txt_provincia_update.Text);
				 c.ciudad= ClasesUtiles.Util.ConvertStringToStringNull(txt_ciudad_update.Text);
				 c.email= ClasesUtiles.Util.ConvertStringToStringNull(txt_email_update.Text);
				 c.email_trabajo= ClasesUtiles.Util.ConvertStringToStringNull(txt_email_trabajo_update.Text);
				 c.fecha_ingreso= ClasesUtiles.Util.GetDateOfString(txt_fecha_ingreso_update.Text);
				 c.uidsuario= ClasesUtiles.Util.ConvertStringToStringNull(cb_uidsuario_update.SelectedValue as string);
            return c;
        }
        private void SetControl_Class_Edit(SitioWeb.Controlador.ClassEmpleado c)
        {

           
			txt_uidempleado_update.Text= c.uidempleado;
			txt_codido_update.Text= ClasesUtiles.Util.ConvertIntToString(c.codido);
			txt_cedula_update.Text= c.cedula;
			txt_nombres_update.Text= c.nombres;
			txt_apellidos_update.Text= c.apellidos;
			cb_uidestadocivil_update.SelectedIndex = cb_uidestadocivil_update.Items.IndexOf(cb_uidestadocivil_update.Items.FindByValue(c.uidestadocivil));
			txt_fechanacimiento_update.Text= ClasesUtiles.Util.GetDateOfString(c.fechanacimiento);
			cb_uidsexo_update.SelectedIndex = cb_uidsexo_update.Items.IndexOf(cb_uidsexo_update.Items.FindByValue(c.uidsexo));
			txt_telefono_update.Text= c.telefono;
			txt_num_hijos_update.Text= ClasesUtiles.Util.ConvertIntToString(c.num_hijos);
			cb_uidnivelestudio_update.SelectedIndex = cb_uidnivelestudio_update.Items.IndexOf(cb_uidnivelestudio_update.Items.FindByValue(c.uidnivelestudio));
			txt_titulo_obtenido_update.Text= c.titulo_obtenido;
			txt_direccion_domicilio_update.Text= c.direccion_domicilio;
			txt_provincia_update.Text= c.provincia;
			txt_ciudad_update.Text= c.ciudad;
			txt_email_update.Text= c.email;
			txt_email_trabajo_update.Text= c.email_trabajo;
			txt_fecha_ingreso_update.Text= ClasesUtiles.Util.GetDateOfString(c.fecha_ingreso);
			cb_uidsuario_update.SelectedIndex = cb_uidsuario_update.Items.IndexOf(cb_uidsuario_update.Items.FindByValue(c.uidsuario));

        }
        protected void btnGuardarEditar_Click(object sender, EventArgs e)
        {
            GuardarEditar();
        }

        protected void btnUpdateEmpleadoMostrarModal_Click(object sender, EventArgs e)
        {
            CargarControlesEditar();
        }
        private void CargarControlesEditar()
        {
            var uidEmpleado = txt_buscarUpdateUIDEmpleado.Text;

            string resultado = "";
            var retSelect = SitioWeb.Controlador.SqlEmpleado.SelectFirst(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, uidEmpleado, out resultado);
            LimpiarControlesEditar();
            SetControl_Class_Edit(retSelect);
            ExecScriptModalUpdate(true, "", false);
        }
		  private void CargaCombosFKUpdate()
        {
            string resultado = "";
			
			  cb_uidestadocivil_update.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlEstadocivil.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidestadocivil_update.DataTextField = "text"; 
			  cb_uidestadocivil_update.DataValueField = "value"; 
			  cb_uidestadocivil_update.DataBind(); 
			  cb_uidsexo_update.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlSexo.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidsexo_update.DataTextField = "text"; 
			  cb_uidsexo_update.DataValueField = "value"; 
			  cb_uidsexo_update.DataBind(); 
			  cb_uidnivelestudio_update.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlNivelestudio.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidnivelestudio_update.DataTextField = "text"; 
			  cb_uidnivelestudio_update.DataValueField = "value"; 
			  cb_uidnivelestudio_update.DataBind(); 
			  cb_uidsuario_update.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlLoginuser.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidsuario_update.DataTextField = "text"; 
			  cb_uidsuario_update.DataValueField = "value"; 
			  cb_uidsuario_update.DataBind(); 
        }


    }
}