using MVC.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServicesApp.MVC.Vista
{
    /// <summary>
    /// Descripción breve de WS_Rol
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WS_Rol : System.Web.Services.WebService
    {

        [WebMethod]
        public List<ClassRol> Select(string UidUserLogin,ClassRol VALUE, out string resultado, string EstadoExistencia)
        {
            return SqlRol.Select(UidUserLogin,VALUE, out resultado, EstadoExistencia);
        }

		[WebMethod]
        public ClassRol SelectFirst(string UidUserLogin, string uidrol, out string resultado, string EstadoExistencia)
        {
            resultado = "";
            var VALUE = new ClassRol();
            VALUE.uidrol = uidrol;
            var ret = new ClassRol();
            try
            {
                var consulta = SqlRol.Select(UidUserLogin, VALUE, out resultado, EstadoExistencia);
                ret = consulta.FirstOrDefault();
            }catch(Exception exc)
            {
                resultado = exc.Message;
            }
            return ret;
            
        }
        [WebMethod]
        public void InsertInto(string UidUserLogin,ClassRol VALUE, out string resultado)
        {
            SqlRol.InsertInto(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Update(string UidUserLogin,ClassRol VALUE, out string resultado)
        {
            SqlRol.Update(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Delete(string UidUserLogin,ClassRol VALUE, out string resultado)
        {
            SqlRol.Delete(UidUserLogin,VALUE, out resultado);
        }
     
    }
}
