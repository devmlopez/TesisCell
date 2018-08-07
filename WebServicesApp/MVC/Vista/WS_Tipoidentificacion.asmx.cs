using MVC.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServicesApp.MVC.Vista
{
    /// <summary>
    /// Descripción breve de WS_Tipoidentificacion
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WS_Tipoidentificacion : System.Web.Services.WebService
    {

        [WebMethod]
        public List<ClassTipoidentificacion> Select(string UidUserLogin,ClassTipoidentificacion VALUE, out string resultado, string EstadoExistencia)
        {
            return SqlTipoidentificacion.Select(UidUserLogin,VALUE, out resultado, EstadoExistencia);
        }

		[WebMethod]
        public ClassTipoidentificacion SelectFirst(string UidUserLogin, string uidtipoidentificacion, out string resultado, string EstadoExistencia)
        {
            resultado = "";
            var VALUE = new ClassTipoidentificacion();
            VALUE.uidtipoidentificacion = uidtipoidentificacion;
            var ret = new ClassTipoidentificacion();
            try
            {
                var consulta = SqlTipoidentificacion.Select(UidUserLogin, VALUE, out resultado, EstadoExistencia);
                ret = consulta.FirstOrDefault();
            }catch(Exception exc)
            {
                resultado = exc.Message;
            }
            return ret;
            
        }
        [WebMethod]
        public void InsertInto(string UidUserLogin,ClassTipoidentificacion VALUE, out string resultado)
        {
            SqlTipoidentificacion.InsertInto(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Update(string UidUserLogin,ClassTipoidentificacion VALUE, out string resultado)
        {
            SqlTipoidentificacion.Update(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Delete(string UidUserLogin,ClassTipoidentificacion VALUE, out string resultado)
        {
            SqlTipoidentificacion.Delete(UidUserLogin,VALUE, out resultado);
        }
     
    }
}
