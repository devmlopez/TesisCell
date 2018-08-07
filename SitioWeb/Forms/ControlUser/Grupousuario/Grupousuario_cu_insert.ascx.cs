using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Grupousuario
{
    public partial class Grupousuario_CU_Insert : System.Web.UI.UserControl
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
		
			txt_uidgrupousuario_insert.Text = Guid.NewGuid().ToString();
			cb_uidgrupo_insert.SelectedIndex =-1;
			cb_uidusuario_insert.SelectedIndex =-1;
          
            lblMensajeError_Insert.Text = "";
        }
     

        private void GuardarNuevo()
        {
            string resultado = "";
            var objeto = GetClass_Control_New();
            SitioWeb.Controlador.SqlGrupousuario.InsertInto(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, objeto, out resultado);
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


		  private SitioWeb.Controlador.ClassGrupousuario GetClass_Control_New()
        {
            var c=new SitioWeb.Controlador.ClassGrupousuario();

			
				 c.uidgrupousuario =ClasesUtiles.Util.ConvertStringToStringNull(txt_uidgrupousuario_insert.Text);
				 c.uidgrupo =ClasesUtiles.Util.ConvertStringToStringNull(cb_uidgrupo_insert.SelectedValue as string);
				 c.uidusuario =ClasesUtiles.Util.ConvertStringToStringNull(cb_uidusuario_insert.SelectedValue as string);
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
			
			  cb_uidgrupo_insert.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlGrupo.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidgrupo_insert.DataTextField = "text"; 
			  cb_uidgrupo_insert.DataValueField = "value"; 
			  cb_uidgrupo_insert.DataBind(); 
			  cb_uidusuario_insert.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlLoginuser.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidusuario_insert.DataTextField = "text"; 
			  cb_uidusuario_insert.DataValueField = "value"; 
			  cb_uidusuario_insert.DataBind(); 
        }
    }
}



