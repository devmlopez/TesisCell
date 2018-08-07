using MVC.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServicesApp.MVC.Vista
{
    /// <summary>
    /// Descripción breve de WS_Facturaventadetalle
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WS_Facturaventadetalle : System.Web.Services.WebService
    {

        [WebMethod]
        public List<ClassFacturaventadetalle> Select(string UidUserLogin,ClassFacturaventadetalle VALUE, out string resultado, string EstadoExistencia)
        {
            return SqlFacturaventadetalle.Select(UidUserLogin,VALUE, out resultado, EstadoExistencia);
        }

		[WebMethod]
        public ClassFacturaventadetalle SelectFirst(string UidUserLogin, string uidfactventadetalle, out string resultado, string EstadoExistencia)
        {
            resultado = "";
            var VALUE = new ClassFacturaventadetalle();
            VALUE.uidfactventadetalle = uidfactventadetalle;
            var ret = new ClassFacturaventadetalle();
            try
            {
                var consulta = SqlFacturaventadetalle.Select(UidUserLogin, VALUE, out resultado, EstadoExistencia);
                ret = consulta.FirstOrDefault();
            }catch(Exception exc)
            {
                resultado = exc.Message;
            }
            return ret;
            
        }
        [WebMethod]
        public void InsertInto(string UidUserLogin,ClassFacturaventadetalle VALUE, out string resultado)
        {
            SqlFacturaventadetalle.InsertInto(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Update(string UidUserLogin,ClassFacturaventadetalle VALUE, out string resultado)
        {
            SqlFacturaventadetalle.Update(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Delete(string UidUserLogin,ClassFacturaventadetalle VALUE, out string resultado)
        {
            SqlFacturaventadetalle.Delete(UidUserLogin,VALUE, out resultado);
        }
     
    }
}
