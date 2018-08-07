using MVC.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServicesApp.MVC.Vista
{
    /// <summary>
    /// Descripción breve de WS_Proveedor
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WS_Proveedor : System.Web.Services.WebService
    {

        [WebMethod]
        public List<ClassProveedor> Select(string UidUserLogin,ClassProveedor VALUE, out string resultado, string EstadoExistencia)
        {
            return SqlProveedor.Select(UidUserLogin,VALUE, out resultado, EstadoExistencia);
        }

		[WebMethod]
        public ClassProveedor SelectFirst(string UidUserLogin, string uidproveedor, out string resultado, string EstadoExistencia)
        {
            resultado = "";
            var VALUE = new ClassProveedor();
            VALUE.uidproveedor = uidproveedor;
            var ret = new ClassProveedor();
            try
            {
                var consulta = SqlProveedor.Select(UidUserLogin, VALUE, out resultado, EstadoExistencia);
                ret = consulta.FirstOrDefault();
            }catch(Exception exc)
            {
                resultado = exc.Message;
            }
            return ret;
            
        }
        [WebMethod]
        public void InsertInto(string UidUserLogin,ClassProveedor VALUE, out string resultado)
        {
            SqlProveedor.InsertInto(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Update(string UidUserLogin,ClassProveedor VALUE, out string resultado)
        {
            SqlProveedor.Update(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Delete(string UidUserLogin,ClassProveedor VALUE, out string resultado)
        {
            SqlProveedor.Delete(UidUserLogin,VALUE, out resultado);
        }
     
    }
}
