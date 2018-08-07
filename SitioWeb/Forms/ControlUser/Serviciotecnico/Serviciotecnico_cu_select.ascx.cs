using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Serviciotecnico
{
    public partial class Serviciotecnico_CU_MostrarUnico : System.Web.UI.UserControl
    {
	  public bool EsModal { get; set; } = false;

        protected void Page_Load(object sender, EventArgs e)
        {
		if (!IsPostBack)
            {
                LimpiarControlesSelect();
                CargaCombosFKSelect();

                var st = Request.QueryString["st"] as string;
                if (!string.IsNullOrEmpty(st))
                {
                    txt_buscarSelectUIDServiciotecnico.Text = st;
                    CargarControlesSelect();
                }               
            }
        }
        protected void btnSelectServiciotecnicoMostrarModal_Click(object sender, EventArgs e)
        {
            CargarControlesSelect();
        }
        private void CargarControlesSelect()
        {
            var uidServiciotecnico = txt_buscarSelectUIDServiciotecnico.Text;

            string resultado = "";
            var retSelect = SitioWeb.Controlador.SqlServiciotecnico.SelectFirst(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, uidServiciotecnico, out resultado);
            LimpiarControlesSelect();
            SetControl_Class_Select(retSelect);
          if (EsModal == true)
            {
                ExecScriptModalSelect(true, "");
            }
        }

		        private void ExecScriptModalSelect(bool EsVisible, string mensajeRetorno)
        {
            string script = @"$('#Select-modal-default-Serviciotecnico').modal('" + (EsVisible == true ? "show" : "hide") + "'); ";           
            ScriptManager.RegisterStartupScript(this, this.GetType(), Guid.NewGuid().ToString().Replace("-", ""), script, true);
        }

        private void SetControl_Class_Select(SitioWeb.Controlador.ClassServiciotecnico c)
        {


            
            txt_uidserviciotecnico_select.Text= c.uidserviciotecnico;
			txt_codservicio_select.Text= ClasesUtiles.Util.ConvertIntToString(c.codservicio);

            //cb_uidcliente_select.SelectedIndex = cb_uidcliente_select.Items.IndexOf(cb_uidcliente_select.Items.FindByValue(c.uidcliente));
            //cb_uidempleado_select.SelectedIndex = cb_uidempleado_select.Items.IndexOf(cb_uidempleado_select.Items.FindByValue(c.uidempleado));

            cb_uidcliente_select.Text =c.aux1;
            cb_uidempleado_select.Text =c.aux2;


            txt_fechaingreso_select.Text= ClasesUtiles.Util.GetDateOfString(c.fechaingreso);
			txt_marca_select.Text= c.marca;
			txt_modelo_select.Text= c.modelo;
			txt_problemasugerido_select.Text= c.problemasugerido;

        }

        private void LimpiarControlesSelect()
        {
		     
			txt_uidserviciotecnico_select.Text = Guid.NewGuid().ToString();
			txt_codservicio_select.Text = "";
			//cb_uidcliente_select.SelectedIndex =-1;
			//cb_uidempleado_select.SelectedIndex =-1;
			txt_fechaingreso_select.Text = "";
			txt_marca_select.Text = "";
			txt_modelo_select.Text = "";
			txt_problemasugerido_select.Text = "";
        }

		  private void CargaCombosFKSelect()
        {
            string resultado = "";
			
			  //cb_uidcliente_select.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlCliente.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  //cb_uidcliente_select.DataTextField = "text"; 
			  //cb_uidcliente_select.DataValueField = "value"; 
			  //cb_uidcliente_select.DataBind(); 
			  //cb_uidempleado_select.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlEmpleado.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  //cb_uidempleado_select.DataTextField = "text"; 
			  //cb_uidempleado_select.DataValueField = "value"; 
			  //cb_uidempleado_select.DataBind(); 
        }

    }
}