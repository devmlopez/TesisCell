using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Rol
{
    public partial class Rol_CU_Insert : System.Web.UI.UserControl
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
		
			txt_uidrol_insert.Text = Guid.NewGuid().ToString();
			txt_rol_insert.Text = "";
			checkb_permisolectura_insert.Checked =false ;
			checkb_permisoescritura_insert.Checked =false ;
			checkb_permisoconsultar_insert.Checked =false ;
			checkb_perisocrear_insert.Checked =false ;
			checkb_permisoeditar_insert.Checked =false ;
			checkb_permisoeliminar_insert.Checked =false ;
			checkb_permisototal_insert.Checked =false ;
			checkb_permisonulo_insert.Checked =false ;
          
            lblMensajeError_Insert.Text = "";
        }
     

        private void GuardarNuevo()
        {
            string resultado = "";
            var objeto = GetClass_Control_New();
            if (Controlador.SqlRol.ValidarCamposNulos(objeto).Count() == 0)
            {
                SitioWeb.Controlador.SqlRol.InsertInto(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, objeto, out resultado);
            }
            else
            {
                resultado = "ERROR||Existen campos obligatorios que llenar";
            }

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


		  private SitioWeb.Controlador.ClassRol GetClass_Control_New()
        {
            var c=new SitioWeb.Controlador.ClassRol();

			
				 c.uidrol =ClasesUtiles.Util.ConvertStringToStringNull(txt_uidrol_insert.Text);
				 c.rol =ClasesUtiles.Util.ConvertStringToStringNull(txt_rol_insert.Text);
				 c.permisolectura =checkb_permisolectura_insert.Checked;
				 c.permisoescritura =checkb_permisoescritura_insert.Checked;
				 c.permisoconsultar =checkb_permisoconsultar_insert.Checked;
				 c.perisocrear =checkb_perisocrear_insert.Checked;
				 c.permisoeditar =checkb_permisoeditar_insert.Checked;
				 c.permisoeliminar =checkb_permisoeliminar_insert.Checked;
				 c.permisototal =checkb_permisototal_insert.Checked;
				 c.permisonulo =checkb_permisonulo_insert.Checked;
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
			
        }
    }
}



