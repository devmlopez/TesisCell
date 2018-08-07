using MVC.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServicesApp.MVC.Vista
{
    /// <summary>
    /// Descripción breve de WS_Estadocivil
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WS_Estadocivil : System.Web.Services.WebService
    {

        [WebMethod]
        public List<ClassEstadocivil> Select(string UidUserLogin,ClassEstadocivil VALUE, out string resultado, string EstadoExistencia)
        {
            return SqlEstadocivil.Select(UidUserLogin,VALUE, out resultado, EstadoExistencia);
        }

		[WebMethod]
        public ClassEstadocivil SelectFirst(string UidUserLogin, string uidestadocivil, out string resultado, string EstadoExistencia)
        {
            resultado = "";
            var VALUE = new ClassEstadocivil();
            VALUE.uidestadocivil = uidestadocivil;
            var ret = new ClassEstadocivil();
            try
            {
                var consulta = SqlEstadocivil.Select(UidUserLogin, VALUE, out resultado, EstadoExistencia);
                ret = consulta.FirstOrDefault();
            }catch(Exception exc)
            {
                resultado = exc.Message;
            }
            return ret;
            
        }
        [WebMethod]
        public void InsertInto(string UidUserLogin,ClassEstadocivil VALUE, out string resultado)
        {
            SqlEstadocivil.InsertInto(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Update(string UidUserLogin,ClassEstadocivil VALUE, out string resultado)
        {
            SqlEstadocivil.Update(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Delete(string UidUserLogin,ClassEstadocivil VALUE, out string resultado)
        {
            SqlEstadocivil.Delete(UidUserLogin,VALUE, out resultado);
        }
     
    }
}
