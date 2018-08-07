using MVC.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServicesApp.MVC.Vista
{
    /// <summary>
    /// Descripción breve de WS_Equipoherramienta
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WS_Equipoherramienta : System.Web.Services.WebService
    {

        [WebMethod]
        public List<ClassEquipoherramienta> Select(string UidUserLogin,ClassEquipoherramienta VALUE, out string resultado, string EstadoExistencia)
        {
            return SqlEquipoherramienta.Select(UidUserLogin,VALUE, out resultado, EstadoExistencia);
        }

		[WebMethod]
        public ClassEquipoherramienta SelectFirst(string UidUserLogin, string uidequipoherramienta, out string resultado, string EstadoExistencia)
        {
            resultado = "";
            var VALUE = new ClassEquipoherramienta();
            VALUE.uidequipoherramienta = uidequipoherramienta;
            var ret = new ClassEquipoherramienta();
            try
            {
                var consulta = SqlEquipoherramienta.Select(UidUserLogin, VALUE, out resultado, EstadoExistencia);
                ret = consulta.FirstOrDefault();
            }catch(Exception exc)
            {
                resultado = exc.Message;
            }
            return ret;
            
        }
        [WebMethod]
        public void InsertInto(string UidUserLogin,ClassEquipoherramienta VALUE, out string resultado)
        {
            SqlEquipoherramienta.InsertInto(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Update(string UidUserLogin,ClassEquipoherramienta VALUE, out string resultado)
        {
            SqlEquipoherramienta.Update(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Delete(string UidUserLogin,ClassEquipoherramienta VALUE, out string resultado)
        {
            SqlEquipoherramienta.Delete(UidUserLogin,VALUE, out resultado);
        }
     
    }
}
