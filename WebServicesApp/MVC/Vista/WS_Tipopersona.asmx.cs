using MVC.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServicesApp.MVC.Vista
{
    /// <summary>
    /// Descripción breve de WS_Tipopersona
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WS_Tipopersona : System.Web.Services.WebService
    {

        [WebMethod]
        public List<ClassTipopersona> Select(string UidUserLogin,ClassTipopersona VALUE, out string resultado, string EstadoExistencia)
        {
            return SqlTipopersona.Select(UidUserLogin,VALUE, out resultado, EstadoExistencia);
        }

		[WebMethod]
        public ClassTipopersona SelectFirst(string UidUserLogin, string uidtipopersona, out string resultado, string EstadoExistencia)
        {
            resultado = "";
            var VALUE = new ClassTipopersona();
            VALUE.uidtipopersona = uidtipopersona;
            var ret = new ClassTipopersona();
            try
            {
                var consulta = SqlTipopersona.Select(UidUserLogin, VALUE, out resultado, EstadoExistencia);
                ret = consulta.FirstOrDefault();
            }catch(Exception exc)
            {
                resultado = exc.Message;
            }
            return ret;
            
        }
        [WebMethod]
        public void InsertInto(string UidUserLogin,ClassTipopersona VALUE, out string resultado)
        {
            SqlTipopersona.InsertInto(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Update(string UidUserLogin,ClassTipopersona VALUE, out string resultado)
        {
            SqlTipopersona.Update(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Delete(string UidUserLogin,ClassTipopersona VALUE, out string resultado)
        {
            SqlTipopersona.Delete(UidUserLogin,VALUE, out resultado);
        }
     
    }
}
