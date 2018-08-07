using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser.Media
{
    public partial class Media_CU_Insert : System.Web.UI.UserControl
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
		
			txt_uidmedia_insert.Text = Guid.NewGuid().ToString();
			txt_codmedia_insert.Text = Guid.NewGuid().ToString();
			cb_uidproceso_insert.SelectedIndex =-1;
			cb_uidtipocomentario_insert.SelectedIndex =-1;
			txt_cometario_insert.Text = "";
			txt_imagen_insert.Text = "";
			txt_url_insert.Text = "";
          
            lblMensajeError_Insert.Text = "";
        }
     

        private void GuardarNuevo()
        {
            string resultado = "";
            var objeto = GetClass_Control_New();
            SitioWeb.Controlador.SqlMedia.InsertInto(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, objeto, out resultado);
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


		  private SitioWeb.Controlador.ClassMedia GetClass_Control_New()
        {
            var c=new SitioWeb.Controlador.ClassMedia();

            string mensajeResult = "";
            string uidserviciotecnico = Request.QueryString["st"] as string;
            Controlador.ClassProceso _proceso = new Controlador.ClassProceso();
            if (!string.IsNullOrEmpty(uidserviciotecnico))
            {
                var ServicioTecnico = Controlador.SqlServiciotecnico.SelectFirst(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, uidserviciotecnico, out mensajeResult);
                if (ServicioTecnico != null)
                {
                    var Proceso = Controlador.SqlProceso.Select(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario,
                    new Controlador.ClassProceso() { uidserviciotecnico = uidserviciotecnico },
                    out mensajeResult);
                    if (Proceso.Count() > 0)
                    {
                        _proceso = Proceso.FirstOrDefault();
                        //var index = cb_uidproceso_insert.Items.FindByValue(Proceso.FirstOrDefault().uidproceso);
                        //cb_uidproceso_insert.Items.IndexOf(index);
                    }
                }
            }


            c.uidmedia =ClasesUtiles.Util.ConvertStringToStringNull(txt_uidmedia_insert.Text);
				c.codmedia= ClasesUtiles.Util.ConvertStringToInt(txt_codmedia_insert.Text);
            //	 c.uidproceso =ClasesUtiles.Util.ConvertStringToStringNull(cb_uidproceso_insert.SelectedValue as string);
            c.uidproceso = _proceso.uidproceso;
                 c.uidtipocomentario =ClasesUtiles.Util.ConvertStringToStringNull(cb_uidtipocomentario_insert.SelectedValue as string);
				 c.cometario =ClasesUtiles.Util.ConvertStringToStringNull(txt_cometario_insert.Text);
				 c.imagen =ClasesUtiles.Util.ConvertStringToStringNull(txt_imagen_insert.Text);
				 c.url =ClasesUtiles.Util.ConvertStringToStringNull(txt_url_insert.Text);
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
			
			  cb_uidproceso_insert.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlProceso.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidproceso_insert.DataTextField = "text"; 
			  cb_uidproceso_insert.DataValueField = "value"; 
			  cb_uidproceso_insert.DataBind(); 
			  cb_uidtipocomentario_insert.DataSource =ClasesUtiles.Util.AgregarItemInicialComboBoxClass( Controlador.SqlTipocomentario.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
			  cb_uidtipocomentario_insert.DataTextField = "text"; 
			  cb_uidtipocomentario_insert.DataValueField = "value"; 
			  cb_uidtipocomentario_insert.DataBind(); 
        }
    }
}



