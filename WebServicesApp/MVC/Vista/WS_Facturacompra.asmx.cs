using MVC.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServicesApp.MVC.Vista
{
    /// <summary>
    /// Descripción breve de WS_Facturacompra
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WS_Facturacompra : System.Web.Services.WebService
    {

        [WebMethod]
        public List<ClassFacturacompra> Select(string UidUserLogin,ClassFacturacompra VALUE, out string resultado, string EstadoExistencia)
        {
            return SqlFacturacompra.Select(UidUserLogin,VALUE, out resultado, EstadoExistencia);
        }

		[WebMethod]
        public ClassFacturacompra SelectFirst(string UidUserLogin, string uidfacturacompra, out string resultado, string EstadoExistencia)
        {
            resultado = "";
            var VALUE = new ClassFacturacompra();
            VALUE.uidfacturacompra = uidfacturacompra;
            var ret = new ClassFacturacompra();
            try
            {
                var consulta = SqlFacturacompra.Select(UidUserLogin, VALUE, out resultado, EstadoExistencia);
                ret = consulta.FirstOrDefault();
            }catch(Exception exc)
            {
                resultado = exc.Message;
            }
            return ret;
            
        }
        [WebMethod]
        public void InsertInto(string UidUserLogin,ClassFacturacompra VALUE, out string resultado)
        {
            SqlFacturacompra.InsertInto(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Update(string UidUserLogin,ClassFacturacompra VALUE, out string resultado)
        {
            SqlFacturacompra.Update(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Delete(string UidUserLogin,ClassFacturacompra VALUE, out string resultado)
        {
            SqlFacturacompra.Delete(UidUserLogin,VALUE, out resultado);
        }
     
    }
}
