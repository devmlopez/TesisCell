using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using SitioWeb.WS_Pagina;
namespace SitioWeb.Controlador
{
    public class SqlPagina
    {
        public static List<ClassPagina> Select(string UidUserLogin,ClassPagina VALUE, out string resultado)
        {
            List<ClassPagina> ret = new List<ClassPagina>();
            resultado = "";
            using (WS_PaginaSoapClient ws= new WS_PaginaSoapClient())
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

		    public static ClassPagina SelectFirst(string UidUserLogin, string uidpagina, out string resultado)
        {
            ClassPagina ret = new ClassPagina();
            resultado = "";
            using (WS_PaginaSoapClient ws= new WS_PaginaSoapClient())
            {
                try
                {
                    var valueRet = ws.SelectFirst(UidUserLogin,uidpagina,ClasesUtiles.StatusExistencia.Activo, out  resultado);
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
            using (WS_PaginaSoapClient ws = new WS_PaginaSoapClient())
            {
                try
                {
                    var VALUE = new ClassPagina();                    
                   
                    var valuesRet = ws.Select(UidUserLogin, Set_ClassSite_To_ClassWS(VALUE), ClasesUtiles.StatusExistencia.Activo, out resultado);
                    foreach (var item in valuesRet)
                    {
                       ret.Add(new ClasesUtiles.ComboClassValueText() {
                          value=item.uidpagina,
                          text=item.pagina
                        });
                    }
                }
                catch (Exception exc)
                {

                }
            }
            return ret;
        }


        public static void InsertInto(string UidUserLogin,ClassPagina VALUE, out string resultado)
        {
            resultado = "";
            using (WS_PaginaSoapClient ws = new WS_PaginaSoapClient())
            {
                resultado= ws.InsertInto(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));            
            } 
        }
        public static void Update(string UidUserLogin,ClassPagina VALUE, out string resultado)
        {
            resultado = "";
            using (WS_PaginaSoapClient ws = new WS_PaginaSoapClient())
            {
                resultado = ws.Update(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));
            }
        }
        public static void Delete(string UidUserLogin,ClassPagina VALUE, out string resultado)
        {
            resultado = "";
            using (WS_PaginaSoapClient ws = new WS_PaginaSoapClient())
            {
                resultado = ws.Delete(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));
            }

        }

        public static ClassPagina Set_ClassWS_To_ClassSite(WS_Pagina.ClassPagina value)
        {
            ClassPagina ret = new ClassPagina();

			
			 ret.uidpagina = value.uidpagina;
			 ret.pagina = value.pagina;
			 ret.fullurl = value.fullurl;
			 ret.uidtipoiconoimg = value.uidtipoiconoimg;
			 ret.iconoimg = value.iconoimg;
			 ret.orden = value.orden;
			 ret.uidpaginapadre = value.uidpaginapadre;
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
        public static WS_Pagina.ClassPagina Set_ClassSite_To_ClassWS(ClassPagina value)
        {
            WS_Pagina.ClassPagina ret = new WS_Pagina.ClassPagina();

			
			 ret.uidpagina = value.uidpagina;
			 ret.pagina = value.pagina;
			 ret.fullurl = value.fullurl;
			 ret.uidtipoiconoimg = value.uidtipoiconoimg;
			 ret.iconoimg = value.iconoimg;
			 ret.orden = value.orden;
			 ret.uidpaginapadre = value.uidpaginapadre;
			           
           
            return ret;
        }
        /// <summary>
        /// Validar campos que deben ser obligados y retorna el nombre de los campos que no soportan nulo
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static List<string> ValidarCamposNulos(ClassPagina value)
        {
            List<string> retornoCamposError = new List<string>();
            if (value.uidpagina == null) { retornoCamposError.Add(nameof(value.uidpagina)); }
            if (value.pagina == null) { retornoCamposError.Add(nameof(value.pagina)); }
            if (value.fullurl == null) { retornoCamposError.Add(nameof(value.fullurl)); }
            if (value.uidtipoiconoimg == null) { retornoCamposError.Add(nameof(value.uidtipoiconoimg)); }
            if (value.orden == null) { retornoCamposError.Add(nameof(value.orden)); }
            return retornoCamposError;
        }

    }
}