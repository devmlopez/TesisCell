using MVC.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServicesApp.MVC.Vista
{
    /// <summary>
    /// Descripción breve de WS_Ot
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WS_Ot : System.Web.Services.WebService
    {

        [WebMethod]
        public List<ClassOt> Select(string UidUserLogin,ClassOt VALUE, out string resultado, string EstadoExistencia)
        {
            return SqlOt.Select(UidUserLogin,VALUE, out resultado, EstadoExistencia);
        }

		[WebMethod]
        public ClassOt SelectFirst(string UidUserLogin, string uidot, out string resultado, string EstadoExistencia)
        {
            resultado = "";
            var VALUE = new ClassOt();
            VALUE.uidot = uidot;
            var ret = new ClassOt();
            try
            {
                var consulta = SqlOt.Select(UidUserLogin, VALUE, out resultado, EstadoExistencia);
                ret = consulta.FirstOrDefault();
            }catch(Exception exc)
            {
                resultado = exc.Message;
            }
            return ret;
            
        }
        [WebMethod]
        public void InsertInto(string UidUserLogin,ClassOt VALUE, out string resultado)
        {
            SqlOt.InsertInto(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Update(string UidUserLogin,ClassOt VALUE, out string resultado)
        {
            SqlOt.Update(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Delete(string UidUserLogin,ClassOt VALUE, out string resultado)
        {
            SqlOt.Delete(UidUserLogin,VALUE, out resultado);
        }
     
    }
}
