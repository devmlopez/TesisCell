using MVC.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServicesApp.MVC.Vista
{
    /// <summary>
    /// Descripción breve de WS_Loginuser
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WS_Loginuser : System.Web.Services.WebService
    {

        [WebMethod]
        public List<ClassLoginuser> Select(string UidUserLogin,ClassLoginuser VALUE, out string resultado, string EstadoExistencia)
        {
            return SqlLoginuser.Select(UidUserLogin,VALUE, out resultado, EstadoExistencia);
        }

		[WebMethod]
        public ClassLoginuser SelectFirst(string UidUserLogin, string uidsuario, out string resultado, string EstadoExistencia)
        {
            resultado = "";
            var VALUE = new ClassLoginuser();
            VALUE.uidsuario = uidsuario;
            var ret = new ClassLoginuser();
            try
            {
                var consulta = SqlLoginuser.Select(UidUserLogin, VALUE, out resultado, EstadoExistencia);
                ret = consulta.FirstOrDefault();
            }catch(Exception exc)
            {
                resultado = exc.Message;
            }
            return ret;
            
        }
        [WebMethod]
        public void InsertInto(string UidUserLogin,ClassLoginuser VALUE, out string resultado)
        {
            SqlLoginuser.InsertInto(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Update(string UidUserLogin,ClassLoginuser VALUE, out string resultado)
        {
            SqlLoginuser.Update(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Delete(string UidUserLogin,ClassLoginuser VALUE, out string resultado)
        {
            SqlLoginuser.Delete(UidUserLogin,VALUE, out resultado);
        }
     
    }
}
