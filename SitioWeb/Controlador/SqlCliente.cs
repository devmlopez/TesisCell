using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using SitioWeb.WS_Cliente;
namespace SitioWeb.Controlador
{
    public class SqlCliente
    {
        public static List<ClassCliente> Select(string UidUserLogin,ClassCliente VALUE, out string resultado)
        {
            List<ClassCliente> ret = new List<ClassCliente>();
            resultado = "";
            using (WS_ClienteSoapClient ws= new WS_ClienteSoapClient())
            {
                try
                {
                    var valuesRet = ws.Select(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE),ClasesUtiles.StatusExistencia.Activo, out resultado);
                    foreach (var item in valuesRet)
                    {
                        ret.Add(Set_ClassWS_To_ClassSite(item));
                    }
                }
                catch (Exception exc)
                {

                }
            }
            return ret;
        }

	
		 public static DataTable SelectDataTable(string UidUserLogin,ClassCliente VALUE, out string resultado)
        {
           DataTable ret = new DataTable();
            resultado = "";
            using (WS_ClienteSoapClient ws= new WS_ClienteSoapClient())
            {
                try
                {
                    var valuesRet = ws.SelectDataTable(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE),ClasesUtiles.StatusExistencia.Activo, out resultado);                    
					ret=valuesRet;
                }
                catch (Exception exc)
                {

                }
            }
            return ret;
        }


		    public static ClassCliente SelectFirst(string UidUserLogin, string uidcliente, out string resultado)
        {
            ClassCliente ret = new ClassCliente();
            resultado = "";
            using (WS_ClienteSoapClient ws= new WS_ClienteSoapClient())
            {
                try
                {
                    var valueRet = ws.SelectFirst(UidUserLogin,uidcliente,ClasesUtiles.StatusExistencia.Activo, out  resultado);
                   ret=Set_ClassWS_To_ClassSite(valueRet);
                }
                catch (Exception exc)
                {

                }
            }
            return ret;
        }

		 public static List<ClasesUtiles.ComboClassValueText> SelectComboFK(string UidUserLogin,string EstadoExistencia, out string resultado)
        {
            resultado = "";
            List<ClasesUtiles.ComboClassValueText> ret = new List<ClasesUtiles.ComboClassValueText>();
            using (WS_ClienteSoapClient ws = new WS_ClienteSoapClient())
            {
                try
                {
                    var VALUE = new ClassCliente();                    
                   
                    var valuesRet = ws.Select(UidUserLogin, Set_ClassSite_To_ClassWS(VALUE), ClasesUtiles.StatusExistencia.Activo, out resultado);
                    foreach (var item in valuesRet)
                    {
                       ret.Add(new ClasesUtiles.ComboClassValueText() {
                          value=item.uidcliente,
                          text=item.razonsocial
                        });
                    }
                }
                catch (Exception exc)
                {

                }
            }
            return ret;
        }


        public static void InsertInto(string UidUserLogin,ClassCliente VALUE, out string resultado)
        {
            resultado = "";
            using (WS_ClienteSoapClient ws = new WS_ClienteSoapClient())
            {
                resultado= ws.InsertInto(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));            
            } 
        }
        public static void Update(string UidUserLogin,ClassCliente VALUE, out string resultado)
        {
            resultado = "";
            using (WS_ClienteSoapClient ws = new WS_ClienteSoapClient())
            {
                resultado = ws.Update(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));
            }
        }
        public static void Delete(string UidUserLogin,ClassCliente VALUE, out string resultado)
        {
            resultado = "";
            using (WS_ClienteSoapClient ws = new WS_ClienteSoapClient())
            {
                resultado = ws.Delete(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));
            }

        }

        public static ClassCliente Set_ClassWS_To_ClassSite(WS_Cliente.ClassCliente value)
        {
            ClassCliente ret = new ClassCliente();

			
			 ret.uidcliente = value.uidcliente;
			 ret.id_cliente = value.id_cliente;
			 ret.uidtipopersona = value.uidtipopersona;
			 ret.identificacion = value.identificacion;
			 ret.uidtipoidentificacion = value.uidtipoidentificacion;
			 ret.razonsocial = value.razonsocial;
			 ret.nombre = value.nombre;
			 ret.contacto = value.contacto;
			 ret.celular = value.celular;
			 ret.telefono = value.telefono;
			 ret.direccion = value.direccion;
			 ret.provincia = value.provincia;
			 ret.ciudad = value.ciudad;
			 ret.email = value.email;
			 ret.referencia = value.referencia;
			 ret.observaciones = value.observaciones;
			 ret.uisusuario = value.uisusuario;
			  
            return ret;
        }
        public static WS_Cliente.ClassCliente Set_ClassSite_To_ClassWS(ClassCliente value)
        {
            WS_Cliente.ClassCliente ret = new WS_Cliente.ClassCliente();

			
			 ret.uidcliente = value.uidcliente;
			 ret.id_cliente = value.id_cliente;
			 ret.uidtipopersona = value.uidtipopersona;
			 ret.identificacion = value.identificacion;
			 ret.uidtipoidentificacion = value.uidtipoidentificacion;
			 ret.razonsocial = value.razonsocial;
			 ret.nombre = value.nombre;
			 ret.contacto = value.contacto;
			 ret.celular = value.celular;
			 ret.telefono = value.telefono;
			 ret.direccion = value.direccion;
			 ret.provincia = value.provincia;
			 ret.ciudad = value.ciudad;
			 ret.email = value.email;
			 ret.referencia = value.referencia;
			 ret.observaciones = value.observaciones;
			 ret.uisusuario = value.uisusuario;
			           
           
            return ret;
        }

        /// <summary>
        /// Validar campos que deben ser obligados y retorna el nombre de los campos que no soportan nulo
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static List<string> ValidarCamposNulos(ClassCliente value)
        {
            List<string> retornoCamposError = new List<string>();
            if (value.uidcliente == null) { retornoCamposError.Add(nameof(value.uidcliente)); }
           // if (value.id_cliente == null) { retornoCamposError.Add(nameof(value.id_cliente)); }
            if (value.uidtipopersona == null) { retornoCamposError.Add(nameof(value.uidtipopersona)); }
            if (value.identificacion == null) { retornoCamposError.Add(nameof(value.identificacion)); }
            if (value.uidtipoidentificacion == null) { retornoCamposError.Add(nameof(value.uidtipoidentificacion)); }
            if (value.razonsocial == null) { retornoCamposError.Add(nameof(value.razonsocial)); }
            if (value.nombre == null) { retornoCamposError.Add(nameof(value.nombre)); }
            if (value.email == null) { retornoCamposError.Add(nameof(value.email)); }
            return retornoCamposError;
        }
    }
}