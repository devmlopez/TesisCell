using MVC.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServicesApp.MVC.Vista
{
    /// <summary>
    /// Descripción breve de WS_Pagina
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WS_Pagina : System.Web.Services.WebService
    {

        [WebMethod]
        public List<ClassPagina> Select(string UidUserLogin,ClassPagina VALUE, out string resultado, string EstadoExistencia)
        {
            return SqlPagina.Select(UidUserLogin,VALUE, out resultado, EstadoExistencia);
        }

		[WebMethod]
        public ClassPagina SelectFirst(string UidUserLogin, string uidpagina, out string resultado, string EstadoExistencia)
        {
            resultado = "";
            var VALUE = new ClassPagina();
            VALUE.uidpagina = uidpagina;
            var ret = new ClassPagina();
            try
            {
                var consulta = SqlPagina.Select(UidUserLogin, VALUE, out resultado, EstadoExistencia);
                ret = consulta.FirstOrDefault();
            }catch(Exception exc)
            {
                resultado = exc.Message;
            }
            return ret;
            
        }
        [WebMethod]
        public void InsertInto(string UidUserLogin,ClassPagina VALUE, out string resultado)
        {
            SqlPagina.InsertInto(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Update(string UidUserLogin,ClassPagina VALUE, out string resultado)
        {
            SqlPagina.Update(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Delete(string UidUserLogin,ClassPagina VALUE, out string resultado)
        {
            SqlPagina.Delete(UidUserLogin,VALUE, out resultado);
        }
     
    }
}
