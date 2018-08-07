using MVC.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServicesApp.MVC.Vista
{
    /// <summary>
    /// Descripción breve de WS_Grupousuario
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WS_Grupousuario : System.Web.Services.WebService
    {

        [WebMethod]
        public List<ClassGrupousuario> Select(string UidUserLogin,ClassGrupousuario VALUE, out string resultado, string EstadoExistencia)
        {
            return SqlGrupousuario.Select(UidUserLogin,VALUE, out resultado, EstadoExistencia);
        }

		[WebMethod]
        public ClassGrupousuario SelectFirst(string UidUserLogin, string uidgrupousuario, out string resultado, string EstadoExistencia)
        {
            resultado = "";
            var VALUE = new ClassGrupousuario();
            VALUE.uidgrupousuario = uidgrupousuario;
            var ret = new ClassGrupousuario();
            try
            {
                var consulta = SqlGrupousuario.Select(UidUserLogin, VALUE, out resultado, EstadoExistencia);
                ret = consulta.FirstOrDefault();
            }catch(Exception exc)
            {
                resultado = exc.Message;
            }
            return ret;
            
        }
        [WebMethod]
        public void InsertInto(string UidUserLogin,ClassGrupousuario VALUE, out string resultado)
        {
            SqlGrupousuario.InsertInto(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Update(string UidUserLogin,ClassGrupousuario VALUE, out string resultado)
        {
            SqlGrupousuario.Update(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Delete(string UidUserLogin,ClassGrupousuario VALUE, out string resultado)
        {
            SqlGrupousuario.Delete(UidUserLogin,VALUE, out resultado);
        }
     
    }
}
