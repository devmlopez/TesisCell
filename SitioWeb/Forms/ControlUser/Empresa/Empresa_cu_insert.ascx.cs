using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Empresa
{
    public partial class Empresa_CU_Insert : System.Web.UI.UserControl
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
		
			txt_uid_empresa_insert.Text = Guid.NewGuid().ToString();
			txt_ruc_insert.Text = "";
			txt_nombre_insert.Text = "";
			txt_descripcion_insert.Text = "";
			txt_direccion_insert.Text = "";
			txt_telefono_insert.Text = "";
			txt_representantelegal_insert.Text = "";
          
            lblMensajeError_Insert.Text = "";
        }
     

        private void GuardarNuevo()
        {
            string resultado = "";
            var objeto = GetClass_Control_New();
             if (Controlador.SqlEmpresa.ValidarCamposNulos(objeto).Count() == 0)
            {
                SitioWeb.Controlador.SqlEmpresa.InsertInto(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, objeto, out resultado);
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


		  private SitioWeb.Controlador.ClassEmpresa GetClass_Control_New()
        {
            var c=new SitioWeb.Controlador.ClassEmpresa();

			
				 c.uid_empresa =ClasesUtiles.Util.ConvertStringToStringNull(txt_uid_empresa_insert.Text);
				 c.ruc =ClasesUtiles.Util.ConvertStringToStringNull(txt_ruc_insert.Text);
				 c.nombre =ClasesUtiles.Util.ConvertStringToStringNull(txt_nombre_insert.Text);
				 c.descripcion =ClasesUtiles.Util.ConvertStringToStringNull(txt_descripcion_insert.Text);
				 c.direccion =ClasesUtiles.Util.ConvertStringToStringNull(txt_direccion_insert.Text);
				 c.telefono =ClasesUtiles.Util.ConvertStringToStringNull(txt_telefono_insert.Text);
				 c.representantelegal =ClasesUtiles.Util.ConvertStringToStringNull(txt_representantelegal_insert.Text);
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



