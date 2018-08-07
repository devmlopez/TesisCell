using MVC.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServicesApp.MVC.Vista
{
    /// <summary>
    /// Descripción breve de WS_Paginagrupo
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WS_Paginagrupo : System.Web.Services.WebService
    {

        [WebMethod]
        public List<ClassPaginagrupo> Select(string UidUserLogin,ClassPaginagrupo VALUE, out string resultado, string EstadoExistencia)
        {
            return SqlPaginagrupo.Select(UidUserLogin,VALUE, out resultado, EstadoExistencia);
        }

		[WebMethod]
        public ClassPaginagrupo SelectFirst(string UidUserLogin, string uidpaginagrupo, out string resultado, string EstadoExistencia)
        {
            resultado = "";
            var VALUE = new ClassPaginagrupo();
            VALUE.uidpaginagrupo = uidpaginagrupo;
            var ret = new ClassPaginagrupo();
            try
            {
                var consulta = SqlPaginagrupo.Select(UidUserLogin, VALUE, out resultado, EstadoExistencia);
                ret = consulta.FirstOrDefault();
            }catch(Exception exc)
            {
                resultado = exc.Message;
            }
            return ret;
            
        }
        [WebMethod]
        public void InsertInto(string UidUserLogin,ClassPaginagrupo VALUE, out string resultado)
        {
            SqlPaginagrupo.InsertInto(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Update(string UidUserLogin,ClassPaginagrupo VALUE, out string resultado)
        {
            SqlPaginagrupo.Update(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Delete(string UidUserLogin,ClassPaginagrupo VALUE, out string resultado)
        {
            SqlPaginagrupo.Delete(UidUserLogin,VALUE, out resultado);
        }
     
    }
}
