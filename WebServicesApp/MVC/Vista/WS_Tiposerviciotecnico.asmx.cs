using MVC.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServicesApp.MVC.Vista
{
    /// <summary>
    /// Descripción breve de WS_Tiposerviciotecnico
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WS_Tiposerviciotecnico : System.Web.Services.WebService
    {

        [WebMethod]
        public List<ClassTiposerviciotecnico> Select(string UidUserLogin,ClassTiposerviciotecnico VALUE, out string resultado, string EstadoExistencia)
        {
            return SqlTiposerviciotecnico.Select(UidUserLogin,VALUE, out resultado, EstadoExistencia);
        }

		[WebMethod]
        public ClassTiposerviciotecnico SelectFirst(string UidUserLogin, string uidtiposervicio, out string resultado, string EstadoExistencia)
        {
            resultado = "";
            var VALUE = new ClassTiposerviciotecnico();
            VALUE.uidtiposervicio = uidtiposervicio;
            var ret = new ClassTiposerviciotecnico();
            try
            {
                var consulta = SqlTiposerviciotecnico.Select(UidUserLogin, VALUE, out resultado, EstadoExistencia);
                ret = consulta.FirstOrDefault();
            }catch(Exception exc)
            {
                resultado = exc.Message;
            }
            return ret;
            
        }
        [WebMethod]
        public void InsertInto(string UidUserLogin,ClassTiposerviciotecnico VALUE, out string resultado)
        {
            SqlTiposerviciotecnico.InsertInto(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Update(string UidUserLogin,ClassTiposerviciotecnico VALUE, out string resultado)
        {
            SqlTiposerviciotecnico.Update(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Delete(string UidUserLogin,ClassTiposerviciotecnico VALUE, out string resultado)
        {
            SqlTiposerviciotecnico.Delete(UidUserLogin,VALUE, out resultado);
        }
     
    }
}
