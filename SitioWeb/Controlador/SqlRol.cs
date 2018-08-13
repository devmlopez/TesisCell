using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using SitioWeb.WS_Rol;
namespace SitioWeb.Controlador
{
    public class SqlRol
    {
        public static List<ClassRol> Select(string UidUserLogin,ClassRol VALUE, out string resultado)
        {
            List<ClassRol> ret = new List<ClassRol>();
            resultado = "";
            using (WS_RolSoapClient ws= new WS_RolSoapClient())
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

		    public static ClassRol SelectFirst(string UidUserLogin, string uidrol, out string resultado)
        {
            ClassRol ret = new ClassRol();
            resultado = "";
            using (WS_RolSoapClient ws= new WS_RolSoapClient())
            {
                try
                {
                    var valueRet = ws.SelectFirst(UidUserLogin,uidrol,ClasesUtiles.StatusExistencia.Activo, out  resultado);
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
            using (WS_RolSoapClient ws = new WS_RolSoapClient())
            {
                try
                {
                    var VALUE = new ClassRol();                    
                   
                    var valuesRet = ws.Select(UidUserLogin, Set_ClassSite_To_ClassWS(VALUE), ClasesUtiles.StatusExistencia.Activo, out resultado);
                    foreach (var item in valuesRet)
                    {
                       ret.Add(new ClasesUtiles.ComboClassValueText() {
                          value=item.uidrol,
                          text=item.rol
                        });
                    }
                }
                catch (Exception exc)
                {

                }
            }
            return ret;
        }


        public static void InsertInto(string UidUserLogin,ClassRol VALUE, out string resultado)
        {
            resultado = "";
            using (WS_RolSoapClient ws = new WS_RolSoapClient())
            {
                resultado= ws.InsertInto(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));            
            } 
        }
        public static void Update(string UidUserLogin,ClassRol VALUE, out string resultado)
        {
            resultado = "";
            using (WS_RolSoapClient ws = new WS_RolSoapClient())
            {
                resultado = ws.Update(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));
            }
        }
        public static void Delete(string UidUserLogin,ClassRol VALUE, out string resultado)
        {
            resultado = "";
            using (WS_RolSoapClient ws = new WS_RolSoapClient())
            {
                resultado = ws.Delete(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));
            }

        }

        public static ClassRol Set_ClassWS_To_ClassSite(WS_Rol.ClassRol value)
        {
            ClassRol ret = new ClassRol();

			
			 ret.uidrol = value.uidrol;
			 ret.rol = value.rol;
			 ret.permisolectura = value.permisolectura;
			 ret.permisoescritura = value.permisoescritura;
			 ret.permisoconsultar = value.permisoconsultar;
			 ret.perisocrear = value.perisocrear;
			 ret.permisoeditar = value.permisoeditar;
			 ret.permisoeliminar = value.permisoeliminar;
			 ret.permisototal = value.permisototal;
			 ret.permisonulo = value.permisonulo;
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
        public static WS_Rol.ClassRol Set_ClassSite_To_ClassWS(ClassRol value)
        {
            WS_Rol.ClassRol ret = new WS_Rol.ClassRol();

			
			 ret.uidrol = value.uidrol;
			 ret.rol = value.rol;
			 ret.permisolectura = value.permisolectura;
			 ret.permisoescritura = value.permisoescritura;
			 ret.permisoconsultar = value.permisoconsultar;
			 ret.perisocrear = value.perisocrear;
			 ret.permisoeditar = value.permisoeditar;
			 ret.permisoeliminar = value.permisoeliminar;
			 ret.permisototal = value.permisototal;
			 ret.permisonulo = value.permisonulo;
			           
           
            return ret;
        }
        /// <summary>
        /// Validar campos que deben ser obligados y retorna el nombre de los campos que no soportan nulo
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static List<string> ValidarCamposNulos(ClassRol value)
        {
            List<string> retornoCamposError = new List<string>();
            if (value.uidrol == null) { retornoCamposError.Add(nameof(value.uidrol)); }
            if (value.rol == null) { retornoCamposError.Add(nameof(value.rol)); }
            if (value.permisolectura == null) { retornoCamposError.Add(nameof(value.permisolectura)); }
            if (value.permisoescritura == null) { retornoCamposError.Add(nameof(value.permisoescritura)); }
            if (value.permisoconsultar == null) { retornoCamposError.Add(nameof(value.permisoconsultar)); }
            if (value.perisocrear == null) { retornoCamposError.Add(nameof(value.perisocrear)); }
            if (value.permisoeditar == null) { retornoCamposError.Add(nameof(value.permisoeditar)); }
            if (value.permisoeliminar == null) { retornoCamposError.Add(nameof(value.permisoeliminar)); }
            if (value.permisototal == null) { retornoCamposError.Add(nameof(value.permisototal)); }
            if (value.permisonulo == null) { retornoCamposError.Add(nameof(value.permisonulo)); }
            return retornoCamposError;
        }

    }
}