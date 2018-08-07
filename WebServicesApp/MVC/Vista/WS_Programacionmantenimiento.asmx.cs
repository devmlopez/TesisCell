using MVC.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServicesApp.MVC.Vista
{
    /// <summary>
    /// Descripción breve de WS_Programacionmantenimiento
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WS_Programacionmantenimiento : System.Web.Services.WebService
    {

        [WebMethod]
        public List<ClassProgramacionmantenimiento> Select(string UidUserLogin,ClassProgramacionmantenimiento VALUE, out string resultado, string EstadoExistencia)
        {
            return SqlProgramacionmantenimiento.Select(UidUserLogin,VALUE, out resultado, EstadoExistencia);
        }

		[WebMethod]
        public ClassProgramacionmantenimiento SelectFirst(string UidUserLogin, string uidprogramacion, out string resultado, string EstadoExistencia)
        {
            resultado = "";
            var VALUE = new ClassProgramacionmantenimiento();
            VALUE.uidprogramacion = uidprogramacion;
            var ret = new ClassProgramacionmantenimiento();
            try
            {
                var consulta = SqlProgramacionmantenimiento.Select(UidUserLogin, VALUE, out resultado, EstadoExistencia);
                ret = consulta.FirstOrDefault();
            }catch(Exception exc)
            {
                resultado = exc.Message;
            }
            return ret;
            
        }
        [WebMethod]
        public void InsertInto(string UidUserLogin,ClassProgramacionmantenimiento VALUE, out string resultado)
        {
            SqlProgramacionmantenimiento.InsertInto(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Update(string UidUserLogin,ClassProgramacionmantenimiento VALUE, out string resultado)
        {
            SqlProgramacionmantenimiento.Update(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Delete(string UidUserLogin,ClassProgramacionmantenimiento VALUE, out string resultado)
        {
            SqlProgramacionmantenimiento.Delete(UidUserLogin,VALUE, out resultado);
        }
     
    }
}
