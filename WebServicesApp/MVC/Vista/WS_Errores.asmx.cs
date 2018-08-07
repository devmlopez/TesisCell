using MVC.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServicesApp.MVC.Vista
{
    /// <summary>
    /// Descripción breve de WS_Errores
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WS_Errores : System.Web.Services.WebService
    {

        [WebMethod]
        public List<ClassErrores> Select(string UidUserLogin,ClassErrores VALUE, out string resultado, string EstadoExistencia)
        {
            return SqlErrores.Select(UidUserLogin,VALUE, out resultado, EstadoExistencia);
        }

		[WebMethod]
        public ClassErrores SelectFirst(string UidUserLogin, string uid_error, out string resultado, string EstadoExistencia)
        {
            resultado = "";
            var VALUE = new ClassErrores();
            VALUE.uid_error = uid_error;
            var ret = new ClassErrores();
            try
            {
                var consulta = SqlErrores.Select(UidUserLogin, VALUE, out resultado, EstadoExistencia);
                ret = consulta.FirstOrDefault();
            }catch(Exception exc)
            {
                resultado = exc.Message;
            }
            return ret;
            
        }
        [WebMethod]
        public void InsertInto(string UidUserLogin,ClassErrores VALUE, out string resultado)
        {
            SqlErrores.InsertInto(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Update(string UidUserLogin,ClassErrores VALUE, out string resultado)
        {
            SqlErrores.Update(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Delete(string UidUserLogin,ClassErrores VALUE, out string resultado)
        {
            SqlErrores.Delete(UidUserLogin,VALUE, out resultado);
        }
     
    }
}
