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
    /// Descripción breve de WS_Menu
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WS_Menu : System.Web.Services.WebService
    {

        [WebMethod]
        public List<ClassMenu> Select(string UidUserLogin,ClassMenu VALUE, out string resultado, string EstadoExistencia)
        {
            return SqlMenu.Select(UidUserLogin,VALUE, out resultado, EstadoExistencia);
        }	
        [WebMethod]
        public List<ClassMenu> SelectDynamic(string UidUserLogin,ClassMenu VALUE, out string resultado, string EstadoExistencia)
        {
            return SqlMenu.Select(UidUserLogin,VALUE, out resultado, EstadoExistencia);
        }

		[WebMethod]
        public DataTable SelectDataTable(string UidUserLogin,ClassMenu VALUE, out string resultado, string EstadoExistencia)
        {
            return SqlMenu.SelectDataTable(UidUserLogin,VALUE, out resultado, EstadoExistencia);
        }
		[WebMethod]
        public ClassMenu SelectFirst(string UidUserLogin, string uidmenu, out string resultado, string EstadoExistencia)
        {
            resultado = "";
            var VALUE = new ClassMenu();
            VALUE.uidmenu = uidmenu;
            var ret = new ClassMenu();
            try
            {
                var consulta = SqlMenu.Select(UidUserLogin, VALUE, out resultado, EstadoExistencia);
                ret = consulta.FirstOrDefault();
            }catch(Exception exc)
            {
                resultado = exc.Message;
            }
            return ret;
            
        }
        [WebMethod]
        public void InsertInto(string UidUserLogin,ClassMenu VALUE, out string resultado)
        {
            SqlMenu.InsertInto(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Update(string UidUserLogin,ClassMenu VALUE, out string resultado)
        {
            SqlMenu.Update(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Delete(string UidUserLogin,ClassMenu VALUE, out string resultado)
        {
            SqlMenu.Delete(UidUserLogin,VALUE, out resultado);
        }
     
    }
}
