using MVC.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServicesApp.MVC.Vista
{
    /// <summary>
    /// Descripción breve de WS_Equipo
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WS_Equipo : System.Web.Services.WebService
    {

        [WebMethod]
        public List<ClassEquipo> Select(string UidUserLogin,ClassEquipo VALUE, out string resultado, string EstadoExistencia)
        {
            return SqlEquipo.Select(UidUserLogin,VALUE, out resultado, EstadoExistencia);
        }

		[WebMethod]
        public ClassEquipo SelectFirst(string UidUserLogin, string uidequipo, out string resultado, string EstadoExistencia)
        {
            resultado = "";
            var VALUE = new ClassEquipo();
            VALUE.uidequipo = uidequipo;
            var ret = new ClassEquipo();
            try
            {
                var consulta = SqlEquipo.Select(UidUserLogin, VALUE, out resultado, EstadoExistencia);
                ret = consulta.FirstOrDefault();
            }catch(Exception exc)
            {
                resultado = exc.Message;
            }
            return ret;
            
        }
        [WebMethod]
        public void InsertInto(string UidUserLogin,ClassEquipo VALUE, out string resultado)
        {
            SqlEquipo.InsertInto(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Update(string UidUserLogin,ClassEquipo VALUE, out string resultado)
        {
            SqlEquipo.Update(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Delete(string UidUserLogin,ClassEquipo VALUE, out string resultado)
        {
            SqlEquipo.Delete(UidUserLogin,VALUE, out resultado);
        }
     
    }
}
