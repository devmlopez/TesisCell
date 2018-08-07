using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Proceso
{
    public partial class Proceso_CU_MostrarUnico : System.Web.UI.UserControl
    {
	  public bool EsModal { get; set; } = false;

        protected void Page_Load(object sender, EventArgs e)
        {
		if (!IsPostBack)
            {
                LimpiarControlesSelect();
                CargaCombosFKSelect();
            }
        }
        protected void btnSelectProcesoMostrarModal_Click(object sender, EventArgs e)
        {
            CargarControlesSelect();
        }
        private void CargarControlesSelect()
        {
            var uidProceso = txt_buscarSelectUIDProceso.Text;

            string resultado = "";
            var retSelect = SitioWeb.Controlador.SqlProceso.SelectFirst(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, uidProceso, out resultado);
            LimpiarControlesSelect();
            SetControl_Class_Select(retSelect);
          if (EsModal == true)
            {
                ExecScriptModalSelect(true, "");
            }
        }

		        private void ExecScriptModalSelect(bool EsVisible, string mensajeRetorno)
        {
            string script = @"$('#Select-modal-default-Proceso').modal('" + (EsVisible == true ? "show" : "hide") + "'); ";           
            ScriptManager.RegisterStartupScript(this, this.GetType(), Guid.NewGuid().ToString().Replace("-", ""), script, true);
        }

        private void SetControl_Class_Select(SitioWeb.Controlador.ClassProceso c)
        {

           
			txt_uidproceso_select.Text= c.uidproceso;
			txt_codproceso_select.Text= ClasesUtiles.Util.ConvertIntToString(c.codproceso);
			cb_uidserviciotecnico_select.SelectedIndex = cb_uidserviciotecnico_select.Items.IndexOf(cb_uidserviciotecnico_select.Items.FindByValue(c.uidserviciotecnico));

        }

        private void LimpiarControlesSelect()
        {
		     
			txt_uidproceso_select.Text = Guid.NewGuid().ToString();
			txt_codproceso_select.Text = "";
			cb_uidserviciotecnico_select.SelectedIndex =-1;
        }

		  private void CargaCombosFKSelect()
        {
            string resultado = "";
			
			  cb_uidserviciotecnico_select.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlServiciotecnico.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidserviciotecnico_select.DataTextField = "text"; 
			  cb_uidserviciotecnico_select.DataValueField = "value"; 
			  cb_uidserviciotecnico_select.DataBind(); 
        }

    }
}