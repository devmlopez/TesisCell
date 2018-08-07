using MVC.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServicesApp.MVC.Vista
{
    /// <summary>
    /// Descripción breve de WS_Tipoiconoimg
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WS_Tipoiconoimg : System.Web.Services.WebService
    {

        [WebMethod]
        public List<ClassTipoiconoimg> Select(string UidUserLogin,ClassTipoiconoimg VALUE, out string resultado, string EstadoExistencia)
        {
            return SqlTipoiconoimg.Select(UidUserLogin,VALUE, out resultado, EstadoExistencia);
        }

		[WebMethod]
        public ClassTipoiconoimg SelectFirst(string UidUserLogin, string uidtipoiconoimg, out string resultado, string EstadoExistencia)
        {
            resultado = "";
            var VALUE = new ClassTipoiconoimg();
            VALUE.uidtipoiconoimg = uidtipoiconoimg;
            var ret = new ClassTipoiconoimg();
            try
            {
                var consulta = SqlTipoiconoimg.Select(UidUserLogin, VALUE, out resultado, EstadoExistencia);
                ret = consulta.FirstOrDefault();
            }catch(Exception exc)
            {
                resultado = exc.Message;
            }
            return ret;
            
        }
        [WebMethod]
        public void InsertInto(string UidUserLogin,ClassTipoiconoimg VALUE, out string resultado)
        {
            SqlTipoiconoimg.InsertInto(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Update(string UidUserLogin,ClassTipoiconoimg VALUE, out string resultado)
        {
            SqlTipoiconoimg.Update(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Delete(string UidUserLogin,ClassTipoiconoimg VALUE, out string resultado)
        {
            SqlTipoiconoimg.Delete(UidUserLogin,VALUE, out resultado);
        }
     
    }
}
