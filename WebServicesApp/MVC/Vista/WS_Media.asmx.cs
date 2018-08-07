using MVC.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
namespace WebServicesApp.MVC.Vista
{
    /// <summary>
    /// Descripción breve de WS_Media
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WS_Media : System.Web.Services.WebService
    {

        [WebMethod]
        public List<ClassMedia> Select(string UidUserLogin,ClassMedia VALUE, out string resultado, string EstadoExistencia)
        {
            return SqlMedia.Select(UidUserLogin,VALUE, out resultado, EstadoExistencia);
        }	
        [WebMethod]
        public List<ClassMedia> SelectDynamic(string UidUserLogin,ClassMedia VALUE, out string resultado, string EstadoExistencia)
        {
            return SqlMedia.Select(UidUserLogin,VALUE, out resultado, EstadoExistencia);
        }

		[WebMethod]
        public DataTable SelectDataTable(string UidUserLogin,ClassMedia VALUE, out string resultado, string EstadoExistencia)
        {
            return SqlMedia.SelectDataTable(UidUserLogin,VALUE, out resultado, EstadoExistencia);
        }
		[WebMethod]
        public ClassMedia SelectFirst(string UidUserLogin, string uidmedia, out string resultado, string EstadoExistencia)
        {
            resultado = "";
            var VALUE = new ClassMedia();
            VALUE.uidmedia = uidmedia;
            var ret = new ClassMedia();
            try
            {
                var consulta = SqlMedia.Select(UidUserLogin, VALUE, out resultado, EstadoExistencia);
                ret = consulta.FirstOrDefault();
            }catch(Exception exc)
            {
                resultado = exc.Message;
            }
            return ret;
            
        }
        [WebMethod]
        public void InsertInto(string UidUserLogin,ClassMedia VALUE, out string resultado)
        {
            SqlMedia.InsertInto(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Update(string UidUserLogin,ClassMedia VALUE, out string resultado)
        {
            SqlMedia.Update(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Delete(string UidUserLogin,ClassMedia VALUE, out string resultado)
        {
            SqlMedia.Delete(UidUserLogin,VALUE, out resultado);
        }
     
    }
}
