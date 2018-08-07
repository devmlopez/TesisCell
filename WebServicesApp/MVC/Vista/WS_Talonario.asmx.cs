using MVC.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServicesApp.MVC.Vista
{
    /// <summary>
    /// Descripción breve de WS_Talonario
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WS_Talonario : System.Web.Services.WebService
    {

        [WebMethod]
        public List<ClassTalonario> Select(string UidUserLogin,ClassTalonario VALUE, out string resultado, string EstadoExistencia)
        {
            return SqlTalonario.Select(UidUserLogin,VALUE, out resultado, EstadoExistencia);
        }

		[WebMethod]
        public ClassTalonario SelectFirst(string UidUserLogin, string uidtalonario, out string resultado, string EstadoExistencia)
        {
            resultado = "";
            var VALUE = new ClassTalonario();
            VALUE.uidtalonario = uidtalonario;
            var ret = new ClassTalonario();
            try
            {
                var consulta = SqlTalonario.Select(UidUserLogin, VALUE, out resultado, EstadoExistencia);
                ret = consulta.FirstOrDefault();
            }catch(Exception exc)
            {
                resultado = exc.Message;
            }
            return ret;
            
        }
        [WebMethod]
        public void InsertInto(string UidUserLogin,ClassTalonario VALUE, out string resultado)
        {
            SqlTalonario.InsertInto(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Update(string UidUserLogin,ClassTalonario VALUE, out string resultado)
        {
            SqlTalonario.Update(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Delete(string UidUserLogin,ClassTalonario VALUE, out string resultado)
        {
            SqlTalonario.Delete(UidUserLogin,VALUE, out resultado);
        }
     
    }
}
