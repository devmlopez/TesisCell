using MVC.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServicesApp.MVC.Vista
{
    /// <summary>
    /// Descripción breve de WS_Facturacompradetalle
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WS_Facturacompradetalle : System.Web.Services.WebService
    {

        [WebMethod]
        public List<ClassFacturacompradetalle> Select(string UidUserLogin,ClassFacturacompradetalle VALUE, out string resultado, string EstadoExistencia)
        {
            return SqlFacturacompradetalle.Select(UidUserLogin,VALUE, out resultado, EstadoExistencia);
        }

		[WebMethod]
        public ClassFacturacompradetalle SelectFirst(string UidUserLogin, string uidfactcompradetalle, out string resultado, string EstadoExistencia)
        {
            resultado = "";
            var VALUE = new ClassFacturacompradetalle();
            VALUE.uidfactcompradetalle = uidfactcompradetalle;
            var ret = new ClassFacturacompradetalle();
            try
            {
                var consulta = SqlFacturacompradetalle.Select(UidUserLogin, VALUE, out resultado, EstadoExistencia);
                ret = consulta.FirstOrDefault();
            }catch(Exception exc)
            {
                resultado = exc.Message;
            }
            return ret;
            
        }
        [WebMethod]
        public void InsertInto(string UidUserLogin,ClassFacturacompradetalle VALUE, out string resultado)
        {
            SqlFacturacompradetalle.InsertInto(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Update(string UidUserLogin,ClassFacturacompradetalle VALUE, out string resultado)
        {
            SqlFacturacompradetalle.Update(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Delete(string UidUserLogin,ClassFacturacompradetalle VALUE, out string resultado)
        {
            SqlFacturacompradetalle.Delete(UidUserLogin,VALUE, out resultado);
        }
     
    }
}
