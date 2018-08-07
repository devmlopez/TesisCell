using MVC.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServicesApp.MVC.Vista
{
    /// <summary>
    /// Descripción breve de WS_Facturaventa
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WS_Facturaventa : System.Web.Services.WebService
    {

        [WebMethod]
        public List<ClassFacturaventa> Select(string UidUserLogin,ClassFacturaventa VALUE, out string resultado, string EstadoExistencia)
        {
            return SqlFacturaventa.Select(UidUserLogin,VALUE, out resultado, EstadoExistencia);
        }

		[WebMethod]
        public ClassFacturaventa SelectFirst(string UidUserLogin, string uidfacturaventa, out string resultado, string EstadoExistencia)
        {
            resultado = "";
            var VALUE = new ClassFacturaventa();
            VALUE.uidfacturaventa = uidfacturaventa;
            var ret = new ClassFacturaventa();
            try
            {
                var consulta = SqlFacturaventa.Select(UidUserLogin, VALUE, out resultado, EstadoExistencia);
                ret = consulta.FirstOrDefault();
            }catch(Exception exc)
            {
                resultado = exc.Message;
            }
            return ret;
            
        }
        [WebMethod]
        public void InsertInto(string UidUserLogin,ClassFacturaventa VALUE, out string resultado)
        {
            SqlFacturaventa.InsertInto(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Update(string UidUserLogin,ClassFacturaventa VALUE, out string resultado)
        {
            SqlFacturaventa.Update(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Delete(string UidUserLogin,ClassFacturaventa VALUE, out string resultado)
        {
            SqlFacturaventa.Delete(UidUserLogin,VALUE, out resultado);
        }
     
    }
}
