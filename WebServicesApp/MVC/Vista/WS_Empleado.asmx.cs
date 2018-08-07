using MVC.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServicesApp.MVC.Vista
{
    /// <summary>
    /// Descripción breve de WS_Empleado
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WS_Empleado : System.Web.Services.WebService
    {

        [WebMethod]
        public List<ClassEmpleado> Select(string UidUserLogin,ClassEmpleado VALUE, out string resultado, string EstadoExistencia)
        {
            return SqlEmpleado.Select(UidUserLogin,VALUE, out resultado, EstadoExistencia);
        }

		[WebMethod]
        public ClassEmpleado SelectFirst(string UidUserLogin, string uidempleado, out string resultado, string EstadoExistencia)
        {
            resultado = "";
            var VALUE = new ClassEmpleado();
            VALUE.uidempleado = uidempleado;
            var ret = new ClassEmpleado();
            try
            {
                var consulta = SqlEmpleado.Select(UidUserLogin, VALUE, out resultado, EstadoExistencia);
                ret = consulta.FirstOrDefault();
            }catch(Exception exc)
            {
                resultado = exc.Message;
            }
            return ret;
            
        }
        [WebMethod]
        public void InsertInto(string UidUserLogin,ClassEmpleado VALUE, out string resultado)
        {
            SqlEmpleado.InsertInto(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Update(string UidUserLogin,ClassEmpleado VALUE, out string resultado)
        {
            SqlEmpleado.Update(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Delete(string UidUserLogin,ClassEmpleado VALUE, out string resultado)
        {
            SqlEmpleado.Delete(UidUserLogin,VALUE, out resultado);
        }
     
    }
}
