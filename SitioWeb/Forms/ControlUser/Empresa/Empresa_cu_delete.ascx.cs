using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Empresa
{
    public partial class Empresa_CU_Delete : System.Web.UI.UserControl
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
            var objeto = new Controlador.ClassEmpresa()
            {
			  
                uid_empresa =  txt_buscarDeleteUIDEmpresa.Text
            };
            SitioWeb.Controlador.SqlEmpresa.Delete(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, objeto, out resultado);

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
      

        protected void btnDeleteEmpresaMostrarModal_Click(object sender, EventArgs e)
        {
            CargarControlesDelete();
        }
        private void CargarControlesDelete()
        {
            var uid =txt_buscarDeleteUIDEmpresa.Text;

            string resultado = "";
            var retSelect = SitioWeb.Controlador.SqlEmpresa.SelectFirst(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, uid, out resultado);
            LimpiarControlesDelete();
            SetControl_Class_Delete(retSelect);
            ExecScriptModalDelete(true, "", false);
        }
        private void LimpiarControlesDelete()
        {
            
			txt_uid_empresa_delete.Text = Guid.NewGuid().ToString();
			txt_ruc_delete.Text = "";
			txt_nombre_delete.Text = "";
			txt_descripcion_delete.Text = "";
			txt_direccion_delete.Text = "";
			txt_telefono_delete.Text = "";
			txt_representantelegal_delete.Text = "";
            lblMensajeError_delete.Text = "";
        }    
    private void SetControl_Class_Delete(SitioWeb.Controlador.ClassEmpresa c)
    {
       
			txt_uid_empresa_delete.Text= c.uid_empresa;
			txt_ruc_delete.Text= c.ruc;
			txt_nombre_delete.Text= c.nombre;
			txt_descripcion_delete.Text= c.descripcion;
			txt_direccion_delete.Text= c.direccion;
			txt_telefono_delete.Text= c.telefono;
			txt_representantelegal_delete.Text= c.representantelegal;
    }

	
	    private void CargaCombosFKDelete()
        {
            string resultado = "";
			
        }

    }
}


