using MVC.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServicesApp.MVC.Vista
{
    /// <summary>
    /// Descripción breve de WS_Grupo
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WS_Grupo : System.Web.Services.WebService
    {

        [WebMethod]
        public List<ClassGrupo> Select(string UidUserLogin,ClassGrupo VALUE, out string resultado, string EstadoExistencia)
        {
            return SqlGrupo.Select(UidUserLogin,VALUE, out resultado, EstadoExistencia);
        }

		[WebMethod]
        public ClassGrupo SelectFirst(string UidUserLogin, string uidgrupo, out string resultado, string EstadoExistencia)
        {
            resultado = "";
            var VALUE = new ClassGrupo();
            VALUE.uidgrupo = uidgrupo;
            var ret = new ClassGrupo();
            try
            {
                var consulta = SqlGrupo.Select(UidUserLogin, VALUE, out resultado, EstadoExistencia);
                ret = consulta.FirstOrDefault();
            }catch(Exception exc)
            {
                resultado = exc.Message;
            }
            return ret;
            
        }
        [WebMethod]
        public void InsertInto(string UidUserLogin,ClassGrupo VALUE, out string resultado)
        {
            SqlGrupo.InsertInto(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Update(string UidUserLogin,ClassGrupo VALUE, out string resultado)
        {
            SqlGrupo.Update(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Delete(string UidUserLogin,ClassGrupo VALUE, out string resultado)
        {
            SqlGrupo.Delete(UidUserLogin,VALUE, out resultado);
        }
     
    }
}
