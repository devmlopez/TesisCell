using MVC.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServicesApp.MVC.Vista
{
    /// <summary>
    /// Descripción breve de WS_Estadoprocesos
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WS_Estadoprocesos : System.Web.Services.WebService
    {

        [WebMethod]
        public List<ClassEstadoprocesos> Select(string UidUserLogin,ClassEstadoprocesos VALUE, out string resultado, string EstadoExistencia)
        {
            return SqlEstadoprocesos.Select(UidUserLogin,VALUE, out resultado, EstadoExistencia);
        }

		[WebMethod]
        public ClassEstadoprocesos SelectFirst(string UidUserLogin, string uidestado, out string resultado, string EstadoExistencia)
        {
            resultado = "";
            var VALUE = new ClassEstadoprocesos();
            VALUE.uidestado = uidestado;
            var ret = new ClassEstadoprocesos();
            try
            {
                var consulta = SqlEstadoprocesos.Select(UidUserLogin, VALUE, out resultado, EstadoExistencia);
                ret = consulta.FirstOrDefault();
            }catch(Exception exc)
            {
                resultado = exc.Message;
            }
            return ret;
            
        }
        [WebMethod]
        public void InsertInto(string UidUserLogin,ClassEstadoprocesos VALUE, out string resultado)
        {
            SqlEstadoprocesos.InsertInto(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Update(string UidUserLogin,ClassEstadoprocesos VALUE, out string resultado)
        {
            SqlEstadoprocesos.Update(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Delete(string UidUserLogin,ClassEstadoprocesos VALUE, out string resultado)
        {
            SqlEstadoprocesos.Delete(UidUserLogin,VALUE, out resultado);
        }
     
    }
}
