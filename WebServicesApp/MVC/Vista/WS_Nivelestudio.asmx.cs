using MVC.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServicesApp.MVC.Vista
{
    /// <summary>
    /// Descripción breve de WS_Nivelestudio
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WS_Nivelestudio : System.Web.Services.WebService
    {

        [WebMethod]
        public List<ClassNivelestudio> Select(string UidUserLogin,ClassNivelestudio VALUE, out string resultado, string EstadoExistencia)
        {
            return SqlNivelestudio.Select(UidUserLogin,VALUE, out resultado, EstadoExistencia);
        }

		[WebMethod]
        public ClassNivelestudio SelectFirst(string UidUserLogin, string uidnivelestudio, out string resultado, string EstadoExistencia)
        {
            resultado = "";
            var VALUE = new ClassNivelestudio();
            VALUE.uidnivelestudio = uidnivelestudio;
            var ret = new ClassNivelestudio();
            try
            {
                var consulta = SqlNivelestudio.Select(UidUserLogin, VALUE, out resultado, EstadoExistencia);
                ret = consulta.FirstOrDefault();
            }catch(Exception exc)
            {
                resultado = exc.Message;
            }
            return ret;
            
        }
        [WebMethod]
        public void InsertInto(string UidUserLogin,ClassNivelestudio VALUE, out string resultado)
        {
            SqlNivelestudio.InsertInto(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Update(string UidUserLogin,ClassNivelestudio VALUE, out string resultado)
        {
            SqlNivelestudio.Update(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Delete(string UidUserLogin,ClassNivelestudio VALUE, out string resultado)
        {
            SqlNivelestudio.Delete(UidUserLogin,VALUE, out resultado);
        }
     
    }
}
