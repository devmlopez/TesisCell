using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Empleado
{
    public partial class Empleado_CU_Delete : System.Web.UI.UserControl
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
            var objeto = new Controlador.ClassEmpleado()
            {
			  
                uidempleado =  txt_buscarDeleteUIDEmpleado.Text
            };
            SitioWeb.Controlador.SqlEmpleado.Delete(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, objeto, out resultado);

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
      

        protected void btnDeleteEmpleadoMostrarModal_Click(object sender, EventArgs e)
        {
            CargarControlesDelete();
        }
        private void CargarControlesDelete()
        {
            var uid =txt_buscarDeleteUIDEmpleado.Text;

            string resultado = "";
            var retSelect = SitioWeb.Controlador.SqlEmpleado.SelectFirst(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, uid, out resultado);
            LimpiarControlesDelete();
            SetControl_Class_Delete(retSelect);
            ExecScriptModalDelete(true, "", false);
        }
        private void LimpiarControlesDelete()
        {
            
			txt_uidempleado_delete.Text = Guid.NewGuid().ToString();
			txt_codido_delete.Text = Guid.NewGuid().ToString();
			txt_cedula_delete.Text = "";
			txt_nombres_delete.Text = "";
			txt_apellidos_delete.Text = "";
			cb_uidestadocivil_delete.SelectedIndex =-1;
			txt_fechanacimiento_delete.Text = "";
			cb_uidsexo_delete.SelectedIndex =-1;
			txt_telefono_delete.Text = "";
			txt_num_hijos_delete.Text = "";
			cb_uidnivelestudio_delete.SelectedIndex =-1;
			txt_titulo_obtenido_delete.Text = "";
			txt_direccion_domicilio_delete.Text = "";
			txt_provincia_delete.Text = "";
			txt_ciudad_delete.Text = "";
			txt_email_delete.Text = "";
			txt_email_trabajo_delete.Text = "";
			txt_fecha_ingreso_delete.Text = "";
			cb_uidsuario_delete.SelectedIndex =-1;
            lblMensajeError_delete.Text = "";
        }    
    private void SetControl_Class_Delete(SitioWeb.Controlador.ClassEmpleado c)
    {
       
			txt_uidempleado_delete.Text= c.uidempleado;
			txt_codido_delete.Text= ClasesUtiles.Util.ConvertIntToString(c.codido);
			txt_cedula_delete.Text= c.cedula;
			txt_nombres_delete.Text= c.nombres;
			txt_apellidos_delete.Text= c.apellidos;
			cb_uidestadocivil_delete.SelectedIndex = cb_uidestadocivil_delete.Items.IndexOf(cb_uidestadocivil_delete.Items.FindByValue(c.uidestadocivil));
			txt_fechanacimiento_delete.Text= ClasesUtiles.Util.GetDateOfString(c.fechanacimiento);
			cb_uidsexo_delete.SelectedIndex = cb_uidsexo_delete.Items.IndexOf(cb_uidsexo_delete.Items.FindByValue(c.uidsexo));
			txt_telefono_delete.Text= c.telefono;
			txt_num_hijos_delete.Text= ClasesUtiles.Util.ConvertIntToString(c.num_hijos);
			cb_uidnivelestudio_delete.SelectedIndex = cb_uidnivelestudio_delete.Items.IndexOf(cb_uidnivelestudio_delete.Items.FindByValue(c.uidnivelestudio));
			txt_titulo_obtenido_delete.Text= c.titulo_obtenido;
			txt_direccion_domicilio_delete.Text= c.direccion_domicilio;
			txt_provincia_delete.Text= c.provincia;
			txt_ciudad_delete.Text= c.ciudad;
			txt_email_delete.Text= c.email;
			txt_email_trabajo_delete.Text= c.email_trabajo;
			txt_fecha_ingreso_delete.Text= ClasesUtiles.Util.GetDateOfString(c.fecha_ingreso);
			cb_uidsuario_delete.SelectedIndex = cb_uidsuario_delete.Items.IndexOf(cb_uidsuario_delete.Items.FindByValue(c.uidsuario));
    }

	
	    private void CargaCombosFKDelete()
        {
            string resultado = "";
			
			  cb_uidestadocivil_delete.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlEstadocivil.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidestadocivil_delete.DataTextField = "text"; 
			  cb_uidestadocivil_delete.DataValueField = "value"; 
			  cb_uidestadocivil_delete.DataBind(); 
			  cb_uidsexo_delete.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlSexo.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidsexo_delete.DataTextField = "text"; 
			  cb_uidsexo_delete.DataValueField = "value"; 
			  cb_uidsexo_delete.DataBind(); 
			  cb_uidnivelestudio_delete.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlNivelestudio.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidnivelestudio_delete.DataTextField = "text"; 
			  cb_uidnivelestudio_delete.DataValueField = "value"; 
			  cb_uidnivelestudio_delete.DataBind(); 
			  cb_uidsuario_delete.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlLoginuser.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidsuario_delete.DataTextField = "text"; 
			  cb_uidsuario_delete.DataValueField = "value"; 
			  cb_uidsuario_delete.DataBind(); 
        }

    }
}


