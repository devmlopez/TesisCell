using MVC.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServicesApp.MVC.Vista
{
    /// <summary>
    /// Descripción breve de WS_Facturareventareferencia
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WS_Facturareventareferencia : System.Web.Services.WebService
    {

        [WebMethod]
        public List<ClassFacturareventareferencia> Select(string UidUserLogin,ClassFacturareventareferencia VALUE, out string resultado, string EstadoExistencia)
        {
            return SqlFacturareventareferencia.Select(UidUserLogin,VALUE, out resultado, EstadoExistencia);
        }

		[WebMethod]
        public ClassFacturareventareferencia SelectFirst(string UidUserLogin, string uidreferencia, out string resultado, string EstadoExistencia)
        {
            resultado = "";
            var VALUE = new ClassFacturareventareferencia();
            VALUE.uidreferencia = uidreferencia;
            var ret = new ClassFacturareventareferencia();
            try
            {
                var consulta = SqlFacturareventareferencia.Select(UidUserLogin, VALUE, out resultado, EstadoExistencia);
                ret = consulta.FirstOrDefault();
            }catch(Exception exc)
            {
                resultado = exc.Message;
            }
            return ret;
            
        }
        [WebMethod]
        public void InsertInto(string UidUserLogin,ClassFacturareventareferencia VALUE, out string resultado)
        {
            SqlFacturareventareferencia.InsertInto(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Update(string UidUserLogin,ClassFacturareventareferencia VALUE, out string resultado)
        {
            SqlFacturareventareferencia.Update(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Delete(string UidUserLogin,ClassFacturareventareferencia VALUE, out string resultado)
        {
            SqlFacturareventareferencia.Delete(UidUserLogin,VALUE, out resultado);
        }
     
    }
}
