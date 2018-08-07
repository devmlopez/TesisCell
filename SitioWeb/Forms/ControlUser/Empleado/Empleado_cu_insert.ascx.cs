using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Empleado
{
    public partial class Empleado_CU_Insert : System.Web.UI.UserControl
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
		
			txt_uidempleado_insert.Text = Guid.NewGuid().ToString();
			txt_codido_insert.Text = Guid.NewGuid().ToString();
			txt_cedula_insert.Text = "";
			txt_nombres_insert.Text = "";
			txt_apellidos_insert.Text = "";
			cb_uidestadocivil_insert.SelectedIndex =-1;
			txt_fechanacimiento_insert.Text = "";
			cb_uidsexo_insert.SelectedIndex =-1;
			txt_telefono_insert.Text = "";
			txt_num_hijos_insert.Text = "";
			cb_uidnivelestudio_insert.SelectedIndex =-1;
			txt_titulo_obtenido_insert.Text = "";
			txt_direccion_domicilio_insert.Text = "";
			txt_provincia_insert.Text = "";
			txt_ciudad_insert.Text = "";
			txt_email_insert.Text = "";
			txt_email_trabajo_insert.Text = "";
			txt_fecha_ingreso_insert.Text = "";
			cb_uidsuario_insert.SelectedIndex =-1;
          
            lblMensajeError_Insert.Text = "";
        }
     

        private void GuardarNuevo()
        {
            string resultado = "";
            var objeto = GetClass_Control_New();
            SitioWeb.Controlador.SqlEmpleado.InsertInto(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, objeto, out resultado);
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


		  private SitioWeb.Controlador.ClassEmpleado GetClass_Control_New()
        {
            var c=new SitioWeb.Controlador.ClassEmpleado();

			
				 c.uidempleado =ClasesUtiles.Util.ConvertStringToStringNull(txt_uidempleado_insert.Text);
				c.codido= ClasesUtiles.Util.ConvertStringToInt(txt_codido_insert.Text);
				 c.cedula =ClasesUtiles.Util.ConvertStringToStringNull(txt_cedula_insert.Text);
				 c.nombres =ClasesUtiles.Util.ConvertStringToStringNull(txt_nombres_insert.Text);
				 c.apellidos =ClasesUtiles.Util.ConvertStringToStringNull(txt_apellidos_insert.Text);
				 c.uidestadocivil =ClasesUtiles.Util.ConvertStringToStringNull(cb_uidestadocivil_insert.SelectedValue as string);
				 c.fechanacimiento =ClasesUtiles.Util.GetDateOfString(txt_fechanacimiento_insert.Text);
				 c.uidsexo =ClasesUtiles.Util.ConvertStringToStringNull(cb_uidsexo_insert.SelectedValue as string);
				 c.telefono =ClasesUtiles.Util.ConvertStringToStringNull(txt_telefono_insert.Text);
				c.num_hijos= ClasesUtiles.Util.ConvertStringToInt(txt_num_hijos_insert.Text);
				 c.uidnivelestudio =ClasesUtiles.Util.ConvertStringToStringNull(cb_uidnivelestudio_insert.SelectedValue as string);
				 c.titulo_obtenido =ClasesUtiles.Util.ConvertStringToStringNull(txt_titulo_obtenido_insert.Text);
				 c.direccion_domicilio =ClasesUtiles.Util.ConvertStringToStringNull(txt_direccion_domicilio_insert.Text);
				 c.provincia =ClasesUtiles.Util.ConvertStringToStringNull(txt_provincia_insert.Text);
				 c.ciudad =ClasesUtiles.Util.ConvertStringToStringNull(txt_ciudad_insert.Text);
				 c.email =ClasesUtiles.Util.ConvertStringToStringNull(txt_email_insert.Text);
				 c.email_trabajo =ClasesUtiles.Util.ConvertStringToStringNull(txt_email_trabajo_insert.Text);
				 c.fecha_ingreso =ClasesUtiles.Util.GetDateOfString(txt_fecha_ingreso_insert.Text);
				 c.uidsuario =ClasesUtiles.Util.ConvertStringToStringNull(cb_uidsuario_insert.SelectedValue as string);
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
			
			  cb_uidestadocivil_insert.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlEstadocivil.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidestadocivil_insert.DataTextField = "text"; 
			  cb_uidestadocivil_insert.DataValueField = "value"; 
			  cb_uidestadocivil_insert.DataBind(); 
			  cb_uidsexo_insert.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlSexo.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidsexo_insert.DataTextField = "text"; 
			  cb_uidsexo_insert.DataValueField = "value"; 
			  cb_uidsexo_insert.DataBind(); 
			  cb_uidnivelestudio_insert.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlNivelestudio.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidnivelestudio_insert.DataTextField = "text"; 
			  cb_uidnivelestudio_insert.DataValueField = "value"; 
			  cb_uidnivelestudio_insert.DataBind(); 
			  cb_uidsuario_insert.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlLoginuser.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidsuario_insert.DataTextField = "text"; 
			  cb_uidsuario_insert.DataValueField = "value"; 
			  cb_uidsuario_insert.DataBind(); 
        }
    }
}



