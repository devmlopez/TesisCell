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
    /// Descripción breve de WS_Serviciotecnico
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WS_Serviciotecnico : System.Web.Services.WebService
    {

        [WebMethod]
        public List<ClassServiciotecnico> Select(string UidUserLogin,ClassServiciotecnico VALUE, out string resultado, string EstadoExistencia)
        {
            return SqlServiciotecnico.Select(UidUserLogin,VALUE, out resultado, EstadoExistencia);
        }	
        [WebMethod]
        public List<ClassServiciotecnico> SelectDynamic(string UidUserLogin,ClassServiciotecnico VALUE, out string resultado, string EstadoExistencia)
        {
            return SqlServiciotecnico.Select(UidUserLogin,VALUE, out resultado, EstadoExistencia);
        }

		[WebMethod]
        public DataTable SelectDataTable(string UidUserLogin,ClassServiciotecnico VALUE, out string resultado, string EstadoExistencia)
        {
            return SqlServiciotecnico.SelectDataTable(UidUserLogin,VALUE, out resultado, EstadoExistencia);
        }
		[WebMethod]
        public ClassServiciotecnico SelectFirst(string UidUserLogin, string uidserviciotecnico, out string resultado, string EstadoExistencia)
        {
            resultado = "";
            var VALUE = new ClassServiciotecnico();
            VALUE.uidserviciotecnico = uidserviciotecnico;
            var ret = new ClassServiciotecnico();
            try
            {
                var consulta = SqlServiciotecnico.Select(UidUserLogin, VALUE, out resultado, EstadoExistencia);
                ret = consulta.FirstOrDefault();
            }catch(Exception exc)
            {
                resultado = exc.Message;
            }
            return ret;
            
        }
        [WebMethod]
        public void InsertInto(string UidUserLogin,ClassServiciotecnico VALUE, out string resultado)
        {
            SqlServiciotecnico.InsertInto(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Update(string UidUserLogin,ClassServiciotecnico VALUE, out string resultado)
        {
            SqlServiciotecnico.Update(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Delete(string UidUserLogin,ClassServiciotecnico VALUE, out string resultado)
        {
            SqlServiciotecnico.Delete(UidUserLogin,VALUE, out resultado);
        }
     
    }
}
