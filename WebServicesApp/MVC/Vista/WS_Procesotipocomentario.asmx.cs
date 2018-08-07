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
    /// Descripción breve de WS_Procesotipocomentario
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WS_Procesotipocomentario : System.Web.Services.WebService
    {

        [WebMethod]
        public List<ClassProcesotipocomentario> Select(string UidUserLogin,ClassProcesotipocomentario VALUE, out string resultado, string EstadoExistencia)
        {
            return SqlProcesotipocomentario.Select(UidUserLogin,VALUE, out resultado, EstadoExistencia);
        }	
        [WebMethod]
        public List<ClassProcesotipocomentario> SelectDynamic(string UidUserLogin,ClassProcesotipocomentario VALUE, out string resultado, string EstadoExistencia)
        {
            return SqlProcesotipocomentario.Select(UidUserLogin,VALUE, out resultado, EstadoExistencia);
        }

		[WebMethod]
        public DataTable SelectDataTable(string UidUserLogin,ClassProcesotipocomentario VALUE, out string resultado, string EstadoExistencia)
        {
            return SqlProcesotipocomentario.SelectDataTable(UidUserLogin,VALUE, out resultado, EstadoExistencia);
        }
		[WebMethod]
        public ClassProcesotipocomentario SelectFirst(string UidUserLogin, string uidprocesotipocomentario, out string resultado, string EstadoExistencia)
        {
            resultado = "";
            var VALUE = new ClassProcesotipocomentario();
            VALUE.uidprocesotipocomentario = uidprocesotipocomentario;
            var ret = new ClassProcesotipocomentario();
            try
            {
                var consulta = SqlProcesotipocomentario.Select(UidUserLogin, VALUE, out resultado, EstadoExistencia);
                ret = consulta.FirstOrDefault();
            }catch(Exception exc)
            {
                resultado = exc.Message;
            }
            return ret;
            
        }
        [WebMethod]
        public void InsertInto(string UidUserLogin,ClassProcesotipocomentario VALUE, out string resultado)
        {
            SqlProcesotipocomentario.InsertInto(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Update(string UidUserLogin,ClassProcesotipocomentario VALUE, out string resultado)
        {
            SqlProcesotipocomentario.Update(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Delete(string UidUserLogin,ClassProcesotipocomentario VALUE, out string resultado)
        {
            SqlProcesotipocomentario.Delete(UidUserLogin,VALUE, out resultado);
        }
     
    }
}
