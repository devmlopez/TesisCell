using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Media
{
    public partial class Media_CU_Delete : System.Web.UI.UserControl
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
            var objeto = new Controlador.ClassMedia()
            {
			  
                uidmedia =  txt_buscarDeleteUIDMedia.Text
            };
            SitioWeb.Controlador.SqlMedia.Delete(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, objeto, out resultado);

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
      

        protected void btnDeleteMediaMostrarModal_Click(object sender, EventArgs e)
        {
            CargarControlesDelete();
        }
        private void CargarControlesDelete()
        {
            var uid =txt_buscarDeleteUIDMedia.Text;

            string resultado = "";
            var retSelect = SitioWeb.Controlador.SqlMedia.SelectFirst(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, uid, out resultado);
            LimpiarControlesDelete();
            SetControl_Class_Delete(retSelect);
            ExecScriptModalDelete(true, "", false);
        }
        private void LimpiarControlesDelete()
        {
            
			txt_uidmedia_delete.Text = Guid.NewGuid().ToString();
			txt_codmedia_delete.Text = Guid.NewGuid().ToString();
			cb_uidproceso_delete.SelectedIndex =-1;
			cb_uidtipocomentario_delete.SelectedIndex =-1;
			txt_cometario_delete.Text = "";
			txt_imagen_delete.Text = "";
			txt_url_delete.Text = "";
            lblMensajeError_delete.Text = "";
        }    
    private void SetControl_Class_Delete(SitioWeb.Controlador.ClassMedia c)
    {
       
			txt_uidmedia_delete.Text= c.uidmedia;
			txt_codmedia_delete.Text= ClasesUtiles.Util.ConvertIntToString(c.codmedia);
			cb_uidproceso_delete.SelectedIndex = cb_uidproceso_delete.Items.IndexOf(cb_uidproceso_delete.Items.FindByValue(c.uidproceso));
			cb_uidtipocomentario_delete.SelectedIndex = cb_uidtipocomentario_delete.Items.IndexOf(cb_uidtipocomentario_delete.Items.FindByValue(c.uidtipocomentario));
			txt_cometario_delete.Text= c.cometario;
			txt_imagen_delete.Text= c.imagen;
			txt_url_delete.Text= c.url;
    }

	
	    private void CargaCombosFKDelete()
        {
            string resultado = "";
			
			  cb_uidproceso_delete.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlProceso.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidproceso_delete.DataTextField = "text"; 
			  cb_uidproceso_delete.DataValueField = "value"; 
			  cb_uidproceso_delete.DataBind(); 
			  cb_uidtipocomentario_delete.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlTipocomentario.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidtipocomentario_delete.DataTextField = "text"; 
			  cb_uidtipocomentario_delete.DataValueField = "value"; 
			  cb_uidtipocomentario_delete.DataBind(); 
        }

    }
}


