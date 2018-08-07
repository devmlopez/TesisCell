using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Loginuser
{
    public partial class Loginuser_CU_Insert : System.Web.UI.UserControl
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
		
			txt_uidsuario_insert.Text = Guid.NewGuid().ToString();
			txt_usuario_insert.Text = "";
			txt_email_insert.Text = "";
			txt_nombre_insert.Text = "";
			txt_contrasenia_insert.Text = "";
			cb_uidrol_insert.SelectedIndex =-1;
          
            lblMensajeError_Insert.Text = "";
        }
     

        private void GuardarNuevo()
        {
            string resultado = "";
            var objeto = GetClass_Control_New();
            SitioWeb.Controlador.SqlLoginuser.InsertInto(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, objeto, out resultado);
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


		  private SitioWeb.Controlador.ClassLoginuser GetClass_Control_New()
        {
            var c=new SitioWeb.Controlador.ClassLoginuser();

			
				 c.uidsuario =ClasesUtiles.Util.ConvertStringToStringNull(txt_uidsuario_insert.Text);
				 c.usuario =ClasesUtiles.Util.ConvertStringToStringNull(txt_usuario_insert.Text);
				 c.email =ClasesUtiles.Util.ConvertStringToStringNull(txt_email_insert.Text);
				 c.nombre =ClasesUtiles.Util.ConvertStringToStringNull(txt_nombre_insert.Text);
				 c.contrasenia =ClasesUtiles.Util.ConvertStringToStringNull(txt_contrasenia_insert.Text);
				 c.uidrol =ClasesUtiles.Util.ConvertStringToStringNull(cb_uidrol_insert.SelectedValue as string);
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
			
			  cb_uidrol_insert.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlRol.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidrol_insert.DataTextField = "text"; 
			  cb_uidrol_insert.DataValueField = "value"; 
			  cb_uidrol_insert.DataBind(); 
        }
    }
}



