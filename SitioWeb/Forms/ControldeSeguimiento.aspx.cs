using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms
{
    public partial class ControldeSeguimiento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Media_cu_detalleProcesoInicial.tipoComentario = new Controlador.ClassTipocomentario() { uidtipocomentario = "88cfd9fe-ee7b-4276-ae0c-09b65f27be69" };
                //Media_cu_detalleEnProceso.tipoComentario = new Controlador.ClassTipocomentario() { uidtipocomentario = "03bee36a-fef1-4c54-a066-632a23b7b5da" };
                //Media_cu_detalleProcesoFinal.tipoComentario = new Controlador.ClassTipocomentario() { uidtipocomentario = "d9438d73-ed10-4003-8fb3-cc9212ea8501" };

                string mensajeResult = "";
                string uidserviciotecnico = Request.QueryString["st"] as string;
                var ServicioTecnico = Controlador.SqlServiciotecnico.SelectFirst(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario,uidserviciotecnico, out mensajeResult);
                if (ServicioTecnico != null)
                {
                    var Proceso= Controlador.SqlProceso.Select(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario,
                        new Controlador.ClassProceso() { uidserviciotecnico= uidserviciotecnico },
                        out mensajeResult);
                    if (Proceso.Count() == 0)
                    {
                        Controlador.SqlProceso.InsertInto(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario,
                            new Controlador.ClassProceso()
                            {
                                 uidserviciotecnico=uidserviciotecnico,
                                 uidproceso=Guid.NewGuid().ToString(),                                 
                            },out mensajeResult);
                    }
                }
            }
        }
    }
}