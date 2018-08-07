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
    /// Descripción breve de WS_Cliente
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WS_Cliente : System.Web.Services.WebService
    {

        [WebMethod]
        public List<ClassCliente> Select(string UidUserLogin,ClassCliente VALUE, out string resultado, string EstadoExistencia)
        {
            return SqlCliente.Select(UidUserLogin,VALUE, out resultado, EstadoExistencia);
        }	
        [WebMethod]
        public List<ClassCliente> SelectDynamic(string UidUserLogin,ClassCliente VALUE, out string resultado, string EstadoExistencia)
        {
            return SqlCliente.Select(UidUserLogin,VALUE, out resultado, EstadoExistencia);
        }

		[WebMethod]
        public DataTable SelectDataTable(string UidUserLogin,ClassCliente VALUE, out string resultado, string EstadoExistencia)
        {
            return SqlCliente.SelectDataTable(UidUserLogin,VALUE, out resultado, EstadoExistencia);
        }
		[WebMethod]
        public ClassCliente SelectFirst(string UidUserLogin, string uidcliente, out string resultado, string EstadoExistencia)
        {
            resultado = "";
            var VALUE = new ClassCliente();
            VALUE.uidcliente = uidcliente;
            var ret = new ClassCliente();
            try
            {
                var consulta = SqlCliente.Select(UidUserLogin, VALUE, out resultado, EstadoExistencia);
                ret = consulta.FirstOrDefault();
            }catch(Exception exc)
            {
                resultado = exc.Message;
            }
            return ret;
            
        }
        [WebMethod]
        public void InsertInto(string UidUserLogin,ClassCliente VALUE, out string resultado)
        {
            SqlCliente.InsertInto(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Update(string UidUserLogin,ClassCliente VALUE, out string resultado)
        {
            SqlCliente.Update(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Delete(string UidUserLogin,ClassCliente VALUE, out string resultado)
        {
            SqlCliente.Delete(UidUserLogin,VALUE, out resultado);
        }
     
    }
}
