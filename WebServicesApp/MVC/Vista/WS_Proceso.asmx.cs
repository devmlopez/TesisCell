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
    /// Descripción breve de WS_Proceso
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WS_Proceso : System.Web.Services.WebService
    {

        [WebMethod]
        public List<ClassProceso> Select(string UidUserLogin,ClassProceso VALUE, out string resultado, string EstadoExistencia)
        {
            return SqlProceso.Select(UidUserLogin,VALUE, out resultado, EstadoExistencia);
        }	
        [WebMethod]
        public List<ClassProceso> SelectDynamic(string UidUserLogin,ClassProceso VALUE, out string resultado, string EstadoExistencia)
        {
            return SqlProceso.Select(UidUserLogin,VALUE, out resultado, EstadoExistencia);
        }

		[WebMethod]
        public DataTable SelectDataTable(string UidUserLogin,ClassProceso VALUE, out string resultado, string EstadoExistencia)
        {
            return SqlProceso.SelectDataTable(UidUserLogin,VALUE, out resultado, EstadoExistencia);
        }
		[WebMethod]
        public ClassProceso SelectFirst(string UidUserLogin, string uidproceso, out string resultado, string EstadoExistencia)
        {
            resultado = "";
            var VALUE = new ClassProceso();
            VALUE.uidproceso = uidproceso;
            var ret = new ClassProceso();
            try
            {
                var consulta = SqlProceso.Select(UidUserLogin, VALUE, out resultado, EstadoExistencia);
                ret = consulta.FirstOrDefault();
            }catch(Exception exc)
            {
                resultado = exc.Message;
            }
            return ret;
            
        }
        [WebMethod]
        public void InsertInto(string UidUserLogin,ClassProceso VALUE, out string resultado)
        {
            SqlProceso.InsertInto(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Update(string UidUserLogin,ClassProceso VALUE, out string resultado)
        {
            SqlProceso.Update(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Delete(string UidUserLogin,ClassProceso VALUE, out string resultado)
        {
            SqlProceso.Delete(UidUserLogin,VALUE, out resultado);
        }
     
    }
}
