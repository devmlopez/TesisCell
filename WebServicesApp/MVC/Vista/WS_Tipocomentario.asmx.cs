using MVC.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
namespace WebServicesApp.MVC.Vista
{
    /// <summary>
    /// Descripción breve de WS_Tipocomentario
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WS_Tipocomentario : System.Web.Services.WebService
    {

        [WebMethod]
        public List<ClassTipocomentario> Select(string UidUserLogin,ClassTipocomentario VALUE, out string resultado, string EstadoExistencia)
        {
            return SqlTipocomentario.Select(UidUserLogin,VALUE, out resultado, EstadoExistencia);
        }	
        [WebMethod]
        public List<ClassTipocomentario> SelectDynamic(string UidUserLogin,ClassTipocomentario VALUE, out string resultado, string EstadoExistencia)
        {
            return SqlTipocomentario.Select(UidUserLogin,VALUE, out resultado, EstadoExistencia);
        }

		[WebMethod]
        public DataTable SelectDataTable(string UidUserLogin,ClassTipocomentario VALUE, out string resultado, string EstadoExistencia)
        {
            return SqlTipocomentario.SelectDataTable(UidUserLogin,VALUE, out resultado, EstadoExistencia);
        }
		[WebMethod]
        public ClassTipocomentario SelectFirst(string UidUserLogin, string uidtipocomentario, out string resultado, string EstadoExistencia)
        {
            resultado = "";
            var VALUE = new ClassTipocomentario();
            VALUE.uidtipocomentario = uidtipocomentario;
            var ret = new ClassTipocomentario();
            try
            {
                var consulta = SqlTipocomentario.Select(UidUserLogin, VALUE, out resultado, EstadoExistencia);
                ret = consulta.FirstOrDefault();
            }catch(Exception exc)
            {
                resultado = exc.Message;
            }
            return ret;
            
        }
        [WebMethod]
        public void InsertInto(string UidUserLogin,ClassTipocomentario VALUE, out string resultado)
        {
            SqlTipocomentario.InsertInto(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Update(string UidUserLogin,ClassTipocomentario VALUE, out string resultado)
        {
            SqlTipocomentario.Update(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Delete(string UidUserLogin,ClassTipocomentario VALUE, out string resultado)
        {
            SqlTipocomentario.Delete(UidUserLogin,VALUE, out resultado);
        }
     
    }
}
