using MVC.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServicesApp.MVC.Vista
{
    /// <summary>
    /// Descripción breve de WS_Sexo
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WS_Sexo : System.Web.Services.WebService
    {

        [WebMethod]
        public List<ClassSexo> Select(string UidUserLogin,ClassSexo VALUE, out string resultado, string EstadoExistencia)
        {
            return SqlSexo.Select(UidUserLogin,VALUE, out resultado, EstadoExistencia);
        }

		[WebMethod]
        public ClassSexo SelectFirst(string UidUserLogin, string uidsexo, out string resultado, string EstadoExistencia)
        {
            resultado = "";
            var VALUE = new ClassSexo();
            VALUE.uidsexo = uidsexo;
            var ret = new ClassSexo();
            try
            {
                var consulta = SqlSexo.Select(UidUserLogin, VALUE, out resultado, EstadoExistencia);
                ret = consulta.FirstOrDefault();
            }catch(Exception exc)
            {
                resultado = exc.Message;
            }
            return ret;
            
        }
        [WebMethod]
        public void InsertInto(string UidUserLogin,ClassSexo VALUE, out string resultado)
        {
            SqlSexo.InsertInto(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Update(string UidUserLogin,ClassSexo VALUE, out string resultado)
        {
            SqlSexo.Update(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Delete(string UidUserLogin,ClassSexo VALUE, out string resultado)
        {
            SqlSexo.Delete(UidUserLogin,VALUE, out resultado);
        }
     
    }
}
