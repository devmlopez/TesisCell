using MVC.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServicesApp.MVC.Vista
{
    /// <summary>
    /// Descripción breve de WS_Equipoasesor
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WS_Equipoasesor : System.Web.Services.WebService
    {

        [WebMethod]
        public List<ClassEquipoasesor> Select(string UidUserLogin,ClassEquipoasesor VALUE, out string resultado, string EstadoExistencia)
        {
            return SqlEquipoasesor.Select(UidUserLogin,VALUE, out resultado, EstadoExistencia);
        }

		[WebMethod]
        public ClassEquipoasesor SelectFirst(string UidUserLogin, string uidequipoasesor, out string resultado, string EstadoExistencia)
        {
            resultado = "";
            var VALUE = new ClassEquipoasesor();
            VALUE.uidequipoasesor = uidequipoasesor;
            var ret = new ClassEquipoasesor();
            try
            {
                var consulta = SqlEquipoasesor.Select(UidUserLogin, VALUE, out resultado, EstadoExistencia);
                ret = consulta.FirstOrDefault();
            }catch(Exception exc)
            {
                resultado = exc.Message;
            }
            return ret;
            
        }
        [WebMethod]
        public void InsertInto(string UidUserLogin,ClassEquipoasesor VALUE, out string resultado)
        {
            SqlEquipoasesor.InsertInto(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Update(string UidUserLogin,ClassEquipoasesor VALUE, out string resultado)
        {
            SqlEquipoasesor.Update(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Delete(string UidUserLogin,ClassEquipoasesor VALUE, out string resultado)
        {
            SqlEquipoasesor.Delete(UidUserLogin,VALUE, out resultado);
        }
     
    }
}
