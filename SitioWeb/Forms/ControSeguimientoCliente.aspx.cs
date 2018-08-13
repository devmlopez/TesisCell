using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace SitioWeb.Forms
{
    public partial class ControSeguimientoCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            cb_Proceso.Visible = false;
            btnGrabarProceso.Visible = false;
            if (SitioWeb.ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidrol == "ED00BDDC-8CB4-41B8-AD16-15650A00D1FB")
            {
                cb_Proceso.Visible = true;
                btnGrabarProceso.Visible = true;
            }

                if (!IsPostBack)
            {
                CargaCombosFKInsert();
            }
            CArgarDatos();
        }
        public void CArgarDatos() { 
            string mensajeRet = "";

            string uiduser=ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario;
            var ListaProcesos = Controlador.SqlProceso.Select(uiduser, new Controlador.ClassProceso()
            {
                uidserviciotecnico = Request.QueryString["st"]
            }, out mensajeRet);

            Session["ListaComentariosMedia"] = null;

            var ListaServicioTecnico = Controlador.SqlServiciotecnico.SelectDataTable(uiduser, new Controlador.ClassServiciotecnico()
            {
               uidserviciotecnico= Request.QueryString["st"]
            }, out mensajeRet);
            //var Ciente = Controlador.SqlCliente.SelectFirst("", ServicioTecnico.uidcliente, out mensajeRet);
            //var UsuarioEmpleado = Controlador.SqlLoginuser.SelectFirst("", ServicioTecnico.uidempleado, out mensajeRet);

            if (ListaServicioTecnico.Rows.Count > 0)
            {

                var ServicioTecnico = (from row in ListaServicioTecnico.AsEnumerable()
                                       select new Controlador.ClassServiciotecnico
                                       {
                                           uidserviciotecnico = row.Field<string>("uidserviciotecnico"),
                                            uidempleado = row.Field<string>("uidempleado"),
                                            uidcliente = row.Field<string>("uidcliente"),
                                            problemasugerido = row.Field<string>("problemasugerido"),
                                            modelo = row.Field<string>("modelo"),
                                            marca = row.Field<string>("marca"),
                                           fechaingreso = row.Field<DateTime?>("fechaingreso"),
                                           fechasalida = row.Field<DateTime?>("fechasalida"),
                                           IMEI = row.Field<string>("IMEI"),
                                           codservicio = row.Field<int>("codservicio"),
                                           aux1 = row.Field<string>("aux1"),
                                           aux2 = row.Field<string>("aux2"),
                                           aux3 = row.Field<string>("aux3"),
                                           aux4 = row.Field<string>("aux4"),
                                           aux5 = row.Field<string>("aux5"),
                                           aux6 = row.Field<string>("aux6"),
                                           aux7 = row.Field<string>("aux7"),
                                           aux8 = row.Field<string>("aux8"),
                                           aux9 = row.Field<string>("aux9"),
                                           aux10 = row.Field<string>("aux10"),
                                       }).FirstOrDefault();
                txt_codservicio_select.Text = ServicioTecnico.codservicio + "";
                cb_uidcliente_select.Text = ServicioTecnico.aux1;
                cb_uidempleado_select.Text = ServicioTecnico.aux2;
                txt_marca_select.Text = ServicioTecnico.marca;
                txt_modelo_select.Text = ServicioTecnico.modelo;
                txt_problemasugerido_select.Text = ServicioTecnico.problemasugerido;
                txt_fechaingreso_select.Text = (ServicioTecnico.fechaingreso==null?"":ServicioTecnico.fechaingreso.Value.ToString("dd/MM/yyyy"));
                txt_FechaSalida_select.Text=(ServicioTecnico.fechasalida == null ? "" : ServicioTecnico.fechasalida.Value.ToString("dd/MM/yyyy"));
                txt_IMEI_select.Text= ServicioTecnico.IMEI;
                #region Cargamos proceso Actual

                var Proceso = CrearrocesoSInoExiste(ServicioTecnico.uidserviciotecnico);
                //    Controlador.SqlProceso.Select(uiduser, new Controlador.ClassProceso(){
                //    uidserviciotecnico = ServicioTecnico.uidserviciotecnico
                //}, out mensajeRet).FirstOrDefault();

                if (Proceso != null)
                {
                    var ProcesoTipoCOmentarioTable = Controlador.SqlProcesotipocomentario.SelectDataTable(uiduser,
                        new Controlador.ClassProcesotipocomentario()
                        {
                            uidproceso = Proceso.uidproceso
                        }, out mensajeRet);

                    var ProcesoTipoCOmentario = (from row in ProcesoTipoCOmentarioTable.AsEnumerable()
                                                 select new Controlador.ClassProcesotipocomentario
                                                 {
                                                     uidproceso = row.Field<string>("uidproceso"),
                                                     uidprocesotipocomentario = row.Field<string>("uidprocesotipocomentario"),
                                                     uidtipocomentario = row.Field<string>("uidtipocomentario"),
                                                 });

                    ProcesoTipoCOmentario = ProcesoTipoCOmentario.Where(x => !string.IsNullOrEmpty(x.uidtipocomentario));
                    txtValorComboProceso.Text = cb_Proceso.SelectedValue as string;
                    if (ProcesoTipoCOmentario.Count() > 0)
                    {
                        var _proceso = ProcesoTipoCOmentario.FirstOrDefault();
                        string uidproceso = _proceso.uidtipocomentario;
                        cb_Proceso.SelectedIndex = cb_Proceso.Items.IndexOf(cb_Proceso.Items.FindByValue(uidproceso));
                    }
                    else
                    {
                        cb_Proceso.SelectedIndex = -1;
                    }
                }
                txtComentario.Visible = true;
                btnEnviar.Visible = true;
                if ((cb_Proceso.SelectedValue as string) != "03bee36a-fef1-4c54-a066-632a23b7b5da" &&
                    SitioWeb.ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidrol != "ED00BDDC-8CB4-41B8-AD16-15650A00D1FB")
                {
                    txtComentario.Visible = false;
                    btnEnviar.Visible = false;
                }
                    #endregion
            }
            if (ListaProcesos.Count() > 0)
            {
                string uidproceso = ListaProcesos.FirstOrDefault().uidproceso;
               var ListaComentariosMedia = SitioWeb.Controlador.SqlMedia.SelectDataTable(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario,
                   new Controlador.ClassMedia()
                    {
                        uidproceso = uidproceso,
                         
                    }, out mensajeRet);
                    Session["ListaComentariosMedia"] = ListaComentariosMedia;               
            }
        }

        protected void btncargarImagen_Click(object sender, EventArgs e)
        {
           

        }

        private Controlador.ClassProceso CrearrocesoSInoExiste(string uidserviciotecnico)
        {
            Controlador.ClassProceso classroceso = null;
            string MensajeResultado = "";
            var BuscarProceso = Controlador.SqlProceso.Select(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario,
                    new Controlador.ClassProceso()
                    {
                        uidserviciotecnico = uidserviciotecnico
                    }, out MensajeResultado);
            if (BuscarProceso.Count() == 0)
            {
                #region insertar proceso
                Controlador.SqlProceso.InsertInto(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario,
                 new Controlador.ClassProceso()
                 {
                     uidproceso = Guid.NewGuid().ToString(),
                     uidserviciotecnico = uidserviciotecnico,

                 }, out MensajeResultado);

                if (MensajeResultado.Contains("OK"))
                {
                    BuscarProceso = Controlador.SqlProceso.Select(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario,
               new Controlador.ClassProceso()
               {
                   uidserviciotecnico = uidserviciotecnico
               }, out MensajeResultado);

                    classroceso = BuscarProceso.FirstOrDefault();
                }
                #endregion

            }else
            {
                classroceso = BuscarProceso.FirstOrDefault();
            }
            return classroceso;
        }
        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            string MensajeResultado = "";
            string uidserviciotecnico = Request.QueryString["st"];
            if (!string.IsNullOrEmpty(uidserviciotecnico))
            {
                CrearrocesoSInoExiste(uidserviciotecnico);

                var BuscarProceso = Controlador.SqlProceso.Select(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario,
                    new Controlador.ClassProceso()
                    {
                        uidserviciotecnico = uidserviciotecnico
                    }, out MensajeResultado);             
                
                    if (BuscarProceso.Count() > 0)
                {
                   

                    var Proceso = BuscarProceso.FirstOrDefault();
                    string resultArrayImagen = "";
                    if (FileUpload1.HasFile)
                    {
                        //si hay una archivo.
                        string nombreArchivo = FileUpload1.FileName;
                        string ruta = "~/Fotos/" + nombreArchivo;
                         resultArrayImagen =Convert.ToBase64String(FileUpload1.FileBytes);                                              
                    }


                    Controlador.SqlMedia.InsertInto(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario,
                         new Controlador.ClassMedia()
                         {
                             uidproceso = Proceso.uidproceso,
                             cometario = txtComentario.Text,
                             uidtipocomentario =(cb_Proceso.SelectedValue as string),
                             url = txtUrlVideo.Text.Replace("watch?v=", "embed/"),  
                             uidmedia = Guid.NewGuid().ToString(),
                              imagen= resultArrayImagen

                         }, out MensajeResultado);

                    Response.Redirect(Request.Url.OriginalString);
                }
            }
            
        }

        private void CargaCombosFKInsert()
        {
            string resultado = "";

            cb_Proceso.DataSource = ClasesUtiles.Util.AgregarItemInicialComboBoxClass(Controlador.SqlTipocomentario.SelectComboFK(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario, ClasesUtiles.StatusExistencia.Activo, out resultado));
            cb_Proceso.DataTextField = "text";
            cb_Proceso.DataValueField = "value";
            cb_Proceso.DataBind();
        }

        protected void cb_Proceso_SelectedIndexChanged(object sender, EventArgs e)
        {
            var combo = (DropDownList)sender;
            string mensajeRet = "";
            string uiduser = ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario;

            var Proceso = Controlador.SqlProceso.Select(uiduser, new Controlador.ClassProceso()
            {
                uidserviciotecnico = Request.QueryString["st"]
            }, out mensajeRet).FirstOrDefault();

            var ProcesoTipoCOmentario=Controlador.SqlProcesotipocomentario.Select(uiduser,
               new Controlador.ClassProcesotipocomentario()
               {
                   uidproceso = Proceso.uidproceso,
                   uidtipocomentario = (combo.SelectedValue as string)
               }, out mensajeRet);

            if (ProcesoTipoCOmentario.Count() == 0)
            {
               Controlador.SqlProcesotipocomentario.InsertInto(uiduser,
              new Controlador.ClassProcesotipocomentario()
              { uidprocesotipocomentario= Guid.NewGuid().ToString(),
                  uidproceso = Proceso.uidproceso,
                  uidtipocomentario = (combo.SelectedValue as string)
              }, out mensajeRet);
            }
            else
            {

                Controlador.SqlProcesotipocomentario.Update(uiduser,
               new Controlador.ClassProcesotipocomentario()
               {
                   uidprocesotipocomentario = ProcesoTipoCOmentario.FirstOrDefault().uidprocesotipocomentario,
                   uidproceso = ProcesoTipoCOmentario.FirstOrDefault().uidproceso,
                   uidtipocomentario = (combo.SelectedValue as string)
               }, out mensajeRet);

            }
        }

        protected void btnGrabarProceso_Click(object sender, EventArgs e)
        {

            //var combo =cb_Proceso;
            string mensajeRet = "";
            string uiduser = ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario;

            var Proceso = Controlador.SqlProceso.Select(uiduser, new Controlador.ClassProceso()
            {
                uidserviciotecnico = Request.QueryString["st"]
            }, out mensajeRet).FirstOrDefault();

            var ProcesoTipoCOmentario = Controlador.SqlProcesotipocomentario.Select(uiduser,
               new Controlador.ClassProcesotipocomentario()
               {
                   uidproceso = Proceso.uidproceso,
               }, out mensajeRet);

            if (ProcesoTipoCOmentario.Count() == 0)
            {
                Controlador.SqlProcesotipocomentario.InsertInto(uiduser,
               new Controlador.ClassProcesotipocomentario()
               {
                   uidprocesotipocomentario = Guid.NewGuid().ToString(),
                   uidproceso = Proceso.uidproceso,
                   uidtipocomentario = txtValorComboProceso.Text
               }, out mensajeRet);
            }
            else
            {

                Controlador.SqlProcesotipocomentario.Update(uiduser,
               new Controlador.ClassProcesotipocomentario()
               {
                   uidprocesotipocomentario = ProcesoTipoCOmentario.FirstOrDefault().uidprocesotipocomentario,
                   uidproceso = ProcesoTipoCOmentario.FirstOrDefault().uidproceso,
                   uidtipocomentario = txtValorComboProceso.Text
               }, out mensajeRet);

            }
            Response.Redirect(Request.Url.ToString());

        }
    }
}