using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Menu
{
    public partial class Menu_CU_Insert : System.Web.UI.UserControl
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
		
			txt_uidmenu_insert.Text = Guid.NewGuid().ToString();
			cb_uidrol_insert.SelectedIndex =-1;
			cb_uidpagina_insert.SelectedIndex =-1;
			checkb_esvisible_insert.Checked =false ;
			checkb_semuestra_insert.Checked =false ;
          
            lblMensajeError_Insert.Text = "";
        }
     

        private void GuardarNuevo()
        {
            string resultado = "";
            var objeto = GetClass_Control_New();
            SitioWeb.Controlador.SqlMenu.InsertInto(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, objeto, out resultado);
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


		  private SitioWeb.Controlador.ClassMenu GetClass_Control_New()
        {
            var c=new SitioWeb.Controlador.ClassMenu();

			
				 c.uidmenu =ClasesUtiles.Util.ConvertStringToStringNull(txt_uidmenu_insert.Text);
				 c.uidrol =ClasesUtiles.Util.ConvertStringToStringNull(cb_uidrol_insert.SelectedValue as string);
				 c.uidpagina =ClasesUtiles.Util.ConvertStringToStringNull(cb_uidpagina_insert.SelectedValue as string);
				 c.esvisible =checkb_esvisible_insert.Checked;
				 c.semuestra =checkb_semuestra_insert.Checked;
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
			  cb_uidpagina_insert.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlPagina.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidpagina_insert.DataTextField = "text"; 
			  cb_uidpagina_insert.DataValueField = "value"; 
			  cb_uidpagina_insert.DataBind(); 
        }
    }
}



