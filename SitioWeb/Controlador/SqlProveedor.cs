using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using SitioWeb.WS_Proveedor;
namespace SitioWeb.Controlador
{
    public class SqlProveedor
    {
        public static List<ClassProveedor> Select(string UidUserLogin,ClassProveedor VALUE, out string resultado)
        {
            List<ClassProveedor> ret = new List<ClassProveedor>();
            resultado = "";
            using (WS_ProveedorSoapClient ws= new WS_ProveedorSoapClient())
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

		    public static ClassProveedor SelectFirst(string UidUserLogin, string uidproveedor, out string resultado)
        {
            ClassProveedor ret = new ClassProveedor();
            resultado = "";
            using (WS_ProveedorSoapClient ws= new WS_ProveedorSoapClient())
            {
                try
                {
                    var valueRet = ws.SelectFirst(UidUserLogin,uidproveedor,ClasesUtiles.StatusExistencia.Activo, out  resultado);
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
            using (WS_ProveedorSoapClient ws = new WS_ProveedorSoapClient())
            {
                try
                {
                    var VALUE = new ClassProveedor();                    
                   
                    var valuesRet = ws.Select(UidUserLogin, Set_ClassSite_To_ClassWS(VALUE), ClasesUtiles.StatusExistencia.Activo, out resultado);
                    foreach (var item in valuesRet)
                    {
                       ret.Add(new ClasesUtiles.ComboClassValueText() {
                          value=item.uidproveedor,
                          text=item.nombre
                        });
                    }
                }
                catch (Exception exc)
                {

                }
            }
            return ret;
        }


        public static void InsertInto(string UidUserLogin,ClassProveedor VALUE, out string resultado)
        {
            resultado = "";
            using (WS_ProveedorSoapClient ws = new WS_ProveedorSoapClient())
            {
                resultado= ws.InsertInto(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));            
            } 
        }
        public static void Update(string UidUserLogin,ClassProveedor VALUE, out string resultado)
        {
            resultado = "";
            using (WS_ProveedorSoapClient ws = new WS_ProveedorSoapClient())
            {
                resultado = ws.Update(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));
            }
        }
        public static void Delete(string UidUserLogin,ClassProveedor VALUE, out string resultado)
        {
            resultado = "";
            using (WS_ProveedorSoapClient ws = new WS_ProveedorSoapClient())
            {
                resultado = ws.Delete(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));
            }

        }

        public static ClassProveedor Set_ClassWS_To_ClassSite(WS_Proveedor.ClassProveedor value)
        {
            ClassProveedor ret = new ClassProveedor();

			
			 ret.uidproveedor = value.uidproveedor;
			 ret.id_proveedor = value.id_proveedor;
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
			 ret.pagina_web = value.pagina_web;
			 ret.aux1 = value.aux1;
            ret.aux2= value.aux2;
            ret.aux3 = value.aux3;
            ret.aux4 = value.aux4;
            ret.aux5 = value.aux5;
            ret.aux6 = value.aux6;
            ret.aux7 = value.aux7;
            ret.aux8 = value.aux8;
            ret.aux9 = value.aux9;
            ret.aux10 = value.aux10;

            return ret;
        }
        public static WS_Proveedor.ClassProveedor Set_ClassSite_To_ClassWS(ClassProveedor value)
        {
            WS_Proveedor.ClassProveedor ret = new WS_Proveedor.ClassProveedor();

			
			 ret.uidproveedor = value.uidproveedor;
			 ret.id_proveedor = value.id_proveedor;
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
			 ret.pagina_web = value.pagina_web;
			           
           
            return ret;
        }
        /// <summary>
        /// Validar campos que deben ser obligados y retorna el nombre de los campos que no soportan nulo
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static List<string> ValidarCamposNulos(ClassProveedor value)
        {
            List<string> retornoCamposError = new List<string>();
            if (value.uidproveedor == null) { retornoCamposError.Add(nameof(value.uidproveedor)); }
            // if (value.id_proveedor == null) { retornoCamposError.Add(nameof(value.id_proveedor)); }
            if (value.uidtipopersona == null) { retornoCamposError.Add(nameof(value.uidtipopersona)); }
            if (value.identificacion == null) { retornoCamposError.Add(nameof(value.identificacion)); }
            if (value.uidtipoidentificacion == null) { retornoCamposError.Add(nameof(value.uidtipoidentificacion)); }
            if (value.razonsocial == null) { retornoCamposError.Add(nameof(value.razonsocial)); }
            if (value.nombre == null) { retornoCamposError.Add(nameof(value.nombre)); }
            if (value.email == null) { retornoCamposError.Add(nameof(value.email)); }
            if (value.pagina_web == null) { retornoCamposError.Add(nameof(value.pagina_web)); }            
            return retornoCamposError;
        }

    }
}