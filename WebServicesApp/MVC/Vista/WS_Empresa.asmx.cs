using MVC.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServicesApp.MVC.Vista
{
    /// <summary>
    /// Descripción breve de WS_Empresa
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WS_Empresa : System.Web.Services.WebService
    {

        [WebMethod]
        public List<ClassEmpresa> Select(string UidUserLogin,ClassEmpresa VALUE, out string resultado, string EstadoExistencia)
        {
            return SqlEmpresa.Select(UidUserLogin,VALUE, out resultado, EstadoExistencia);
        }

		[WebMethod]
        public ClassEmpresa SelectFirst(string UidUserLogin, string uid_empresa, out string resultado, string EstadoExistencia)
        {
            resultado = "";
            var VALUE = new ClassEmpresa();
            VALUE.uid_empresa = uid_empresa;
            var ret = new ClassEmpresa();
            try
            {
                var consulta = SqlEmpresa.Select(UidUserLogin, VALUE, out resultado, EstadoExistencia);
                ret = consulta.FirstOrDefault();
            }catch(Exception exc)
            {
                resultado = exc.Message;
            }
            return ret;
            
        }
        [WebMethod]
        public void InsertInto(string UidUserLogin,ClassEmpresa VALUE, out string resultado)
        {
            SqlEmpresa.InsertInto(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Update(string UidUserLogin,ClassEmpresa VALUE, out string resultado)
        {
            SqlEmpresa.Update(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Delete(string UidUserLogin,ClassEmpresa VALUE, out string resultado)
        {
            SqlEmpresa.Delete(UidUserLogin,VALUE, out resultado);
        }
     
    }
}
