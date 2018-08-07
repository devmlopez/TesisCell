using MVC.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServicesApp.MVC.Vista
{
    /// <summary>
    /// Descripción breve de WS_Informetecnico
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WS_Informetecnico : System.Web.Services.WebService
    {

        [WebMethod]
        public List<ClassInformetecnico> Select(string UidUserLogin,ClassInformetecnico VALUE, out string resultado, string EstadoExistencia)
        {
            return SqlInformetecnico.Select(UidUserLogin,VALUE, out resultado, EstadoExistencia);
        }

		[WebMethod]
        public ClassInformetecnico SelectFirst(string UidUserLogin, string uidinformetecnico, out string resultado, string EstadoExistencia)
        {
            resultado = "";
            var VALUE = new ClassInformetecnico();
            VALUE.uidinformetecnico = uidinformetecnico;
            var ret = new ClassInformetecnico();
            try
            {
                var consulta = SqlInformetecnico.Select(UidUserLogin, VALUE, out resultado, EstadoExistencia);
                ret = consulta.FirstOrDefault();
            }catch(Exception exc)
            {
                resultado = exc.Message;
            }
            return ret;
            
        }
        [WebMethod]
        public void InsertInto(string UidUserLogin,ClassInformetecnico VALUE, out string resultado)
        {
            SqlInformetecnico.InsertInto(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Update(string UidUserLogin,ClassInformetecnico VALUE, out string resultado)
        {
            SqlInformetecnico.Update(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Delete(string UidUserLogin,ClassInformetecnico VALUE, out string resultado)
        {
            SqlInformetecnico.Delete(UidUserLogin,VALUE, out resultado);
        }
     
    }
}
