using MVC.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServicesApp.MVC.Vista
{
    /// <summary>
    /// Descripción breve de WS_Producto
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WS_Producto : System.Web.Services.WebService
    {

        [WebMethod]
        public List<ClassProducto> Select(string UidUserLogin,ClassProducto VALUE, out string resultado, string EstadoExistencia)
        {
            return SqlProducto.Select(UidUserLogin,VALUE, out resultado, EstadoExistencia);
        }

		[WebMethod]
        public ClassProducto SelectFirst(string UidUserLogin, string uidproducto, out string resultado, string EstadoExistencia)
        {
            resultado = "";
            var VALUE = new ClassProducto();
            VALUE.uidproducto = uidproducto;
            var ret = new ClassProducto();
            try
            {
                var consulta = SqlProducto.Select(UidUserLogin, VALUE, out resultado, EstadoExistencia);
                ret = consulta.FirstOrDefault();
            }catch(Exception exc)
            {
                resultado = exc.Message;
            }
            return ret;
            
        }
        [WebMethod]
        public void InsertInto(string UidUserLogin,ClassProducto VALUE, out string resultado)
        {
            SqlProducto.InsertInto(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Update(string UidUserLogin,ClassProducto VALUE, out string resultado)
        {
            SqlProducto.Update(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Delete(string UidUserLogin,ClassProducto VALUE, out string resultado)
        {
            SqlProducto.Delete(UidUserLogin,VALUE, out resultado);
        }
     
    }
}
