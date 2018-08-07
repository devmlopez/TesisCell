using MVC.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServicesApp.MVC.Vista
{
    /// <summary>
    /// Descripción breve de WS_Parametros
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WS_Parametros : System.Web.Services.WebService
    {

        [WebMethod]
        public List<ClassParametros> Select(string UidUserLogin,ClassParametros VALUE, out string resultado, string EstadoExistencia)
        {
            return SqlParametros.Select(UidUserLogin,VALUE, out resultado, EstadoExistencia);
        }

		[WebMethod]
        public ClassParametros SelectFirst(string UidUserLogin, string uidparmetro, out string resultado, string EstadoExistencia)
        {
            resultado = "";
            var VALUE = new ClassParametros();
            VALUE.uidparmetro = uidparmetro;
            var ret = new ClassParametros();
            try
            {
                var consulta = SqlParametros.Select(UidUserLogin, VALUE, out resultado, EstadoExistencia);
                ret = consulta.FirstOrDefault();
            }catch(Exception exc)
            {
                resultado = exc.Message;
            }
            return ret;
            
        }
        [WebMethod]
        public void InsertInto(string UidUserLogin,ClassParametros VALUE, out string resultado)
        {
            SqlParametros.InsertInto(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Update(string UidUserLogin,ClassParametros VALUE, out string resultado)
        {
            SqlParametros.Update(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Delete(string UidUserLogin,ClassParametros VALUE, out string resultado)
        {
            SqlParametros.Delete(UidUserLogin,VALUE, out resultado);
        }
     
    }
}
