using MVC.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServicesApp.MVC.Vista
{
    /// <summary>
    /// Descripción breve de WS_Categoriaproducto
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WS_Categoriaproducto : System.Web.Services.WebService
    {

        [WebMethod]
        public List<ClassCategoriaproducto> Select(string UidUserLogin,ClassCategoriaproducto VALUE, out string resultado, string EstadoExistencia)
        {
            return SqlCategoriaproducto.Select(UidUserLogin,VALUE, out resultado, EstadoExistencia);
        }

		[WebMethod]
        public ClassCategoriaproducto SelectFirst(string UidUserLogin, string uidcategoriaproducto, out string resultado, string EstadoExistencia)
        {
            resultado = "";
            var VALUE = new ClassCategoriaproducto();
            VALUE.uidcategoriaproducto = uidcategoriaproducto;
            var ret = new ClassCategoriaproducto();
            try
            {
                var consulta = SqlCategoriaproducto.Select(UidUserLogin, VALUE, out resultado, EstadoExistencia);
                ret = consulta.FirstOrDefault();
            }catch(Exception exc)
            {
                resultado = exc.Message;
            }
            return ret;
            
        }
        [WebMethod]
        public void InsertInto(string UidUserLogin,ClassCategoriaproducto VALUE, out string resultado)
        {
            SqlCategoriaproducto.InsertInto(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Update(string UidUserLogin,ClassCategoriaproducto VALUE, out string resultado)
        {
            SqlCategoriaproducto.Update(UidUserLogin,VALUE, out resultado);
        }
        [WebMethod]
        public void Delete(string UidUserLogin,ClassCategoriaproducto VALUE, out string resultado)
        {
            SqlCategoriaproducto.Delete(UidUserLogin,VALUE, out resultado);
        }
     
    }
}
