using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using SitioWeb.WS_Paginagrupo;
namespace SitioWeb.Controlador
{
    public class SqlPaginagrupo
    {
        public static List<ClassPaginagrupo> Select(string UidUserLogin,ClassPaginagrupo VALUE, out string resultado)
        {
            List<ClassPaginagrupo> ret = new List<ClassPaginagrupo>();
            resultado = "";
            using (WS_PaginagrupoSoapClient ws= new WS_PaginagrupoSoapClient())
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

		    public static ClassPaginagrupo SelectFirst(string UidUserLogin, string uidpaginagrupo, out string resultado)
        {
            ClassPaginagrupo ret = new ClassPaginagrupo();
            resultado = "";
            using (WS_PaginagrupoSoapClient ws= new WS_PaginagrupoSoapClient())
            {
                try
                {
                    var valueRet = ws.SelectFirst(UidUserLogin,uidpaginagrupo,ClasesUtiles.StatusExistencia.Activo, out  resultado);
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
            using (WS_PaginagrupoSoapClient ws = new WS_PaginagrupoSoapClient())
            {
                try
                {
                    var VALUE = new ClassPaginagrupo();                    
                   
                    var valuesRet = ws.Select(UidUserLogin, Set_ClassSite_To_ClassWS(VALUE), ClasesUtiles.StatusExistencia.Activo, out resultado);
                    foreach (var item in valuesRet)
                    {
                       ret.Add(new ClasesUtiles.ComboClassValueText() {
                          value=item.uidpaginagrupo,
                          text=item.uidpagina
                        });
                    }
                }
                catch (Exception exc)
                {

                }
            }
            return ret;
        }


        public static void InsertInto(string UidUserLogin,ClassPaginagrupo VALUE, out string resultado)
        {
            resultado = "";
            using (WS_PaginagrupoSoapClient ws = new WS_PaginagrupoSoapClient())
            {
                resultado= ws.InsertInto(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));            
            } 
        }
        public static void Update(string UidUserLogin,ClassPaginagrupo VALUE, out string resultado)
        {
            resultado = "";
            using (WS_PaginagrupoSoapClient ws = new WS_PaginagrupoSoapClient())
            {
                resultado = ws.Update(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));
            }
        }
        public static void Delete(string UidUserLogin,ClassPaginagrupo VALUE, out string resultado)
        {
            resultado = "";
            using (WS_PaginagrupoSoapClient ws = new WS_PaginagrupoSoapClient())
            {
                resultado = ws.Delete(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));
            }

        }

        public static ClassPaginagrupo Set_ClassWS_To_ClassSite(WS_Paginagrupo.ClassPaginagrupo value)
        {
            ClassPaginagrupo ret = new ClassPaginagrupo();

			
			 ret.uidpaginagrupo = value.uidpaginagrupo;
			 ret.uidpagina = value.uidpagina;
			 ret.uidgrupo = value.uidgrupo;
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
        public static WS_Paginagrupo.ClassPaginagrupo Set_ClassSite_To_ClassWS(ClassPaginagrupo value)
        {
            WS_Paginagrupo.ClassPaginagrupo ret = new WS_Paginagrupo.ClassPaginagrupo();

			
			 ret.uidpaginagrupo = value.uidpaginagrupo;
			 ret.uidpagina = value.uidpagina;
			 ret.uidgrupo = value.uidgrupo;
			           
           
            return ret;
        }
        /// <summary>
        /// Validar campos que deben ser obligados y retorna el nombre de los campos que no soportan nulo
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static List<string> ValidarCamposNulos(ClassPaginagrupo value)
        {
            List<string> retornoCamposError = new List<string>();
            if (value.uidpaginagrupo == null) { retornoCamposError.Add(nameof(value.uidpaginagrupo)); }
            if (value.uidpagina == null) { retornoCamposError.Add(nameof(value.uidpagina)); }
            if (value.uidgrupo == null) { retornoCamposError.Add(nameof(value.uidgrupo)); }
            return retornoCamposError;
        }

    }
}