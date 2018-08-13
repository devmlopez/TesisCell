using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using SitioWeb.WS_Menu;
namespace SitioWeb.Controlador
{
    public class SqlMenu
    {
        public static List<ClassMenu> Select(string UidUserLogin,ClassMenu VALUE, out string resultado)
        {
            List<ClassMenu> ret = new List<ClassMenu>();
            resultado = "";
            using (WS_MenuSoapClient ws= new WS_MenuSoapClient())
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

	
		 public static DataTable SelectDataTable(string UidUserLogin,ClassMenu VALUE, out string resultado)
        {
           DataTable ret = new DataTable();
            resultado = "";
            using (WS_MenuSoapClient ws= new WS_MenuSoapClient())
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


		    public static ClassMenu SelectFirst(string UidUserLogin, string uidmenu, out string resultado)
        {
            ClassMenu ret = new ClassMenu();
            resultado = "";
            using (WS_MenuSoapClient ws= new WS_MenuSoapClient())
            {
                try
                {
                    var valueRet = ws.SelectFirst(UidUserLogin,uidmenu,ClasesUtiles.StatusExistencia.Activo, out  resultado);
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
            using (WS_MenuSoapClient ws = new WS_MenuSoapClient())
            {
                try
                {
                    var VALUE = new ClassMenu();                    
                   
                    var valuesRet = ws.Select(UidUserLogin, Set_ClassSite_To_ClassWS(VALUE), ClasesUtiles.StatusExistencia.Activo, out resultado);
                    foreach (var item in valuesRet)
                    {
                       ret.Add(new ClasesUtiles.ComboClassValueText() {
                          value=item.uidmenu,
                          text=item.uidrol
                        });
                    }
                }
                catch (Exception exc)
                {

                }
            }
            return ret;
        }


        public static void InsertInto(string UidUserLogin,ClassMenu VALUE, out string resultado)
        {
            resultado = "";
            using (WS_MenuSoapClient ws = new WS_MenuSoapClient())
            {
                resultado= ws.InsertInto(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));            
            } 
        }
        public static void Update(string UidUserLogin,ClassMenu VALUE, out string resultado)
        {
            resultado = "";
            using (WS_MenuSoapClient ws = new WS_MenuSoapClient())
            {
                resultado = ws.Update(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));
            }
        }
        public static void Delete(string UidUserLogin,ClassMenu VALUE, out string resultado)
        {
            resultado = "";
            using (WS_MenuSoapClient ws = new WS_MenuSoapClient())
            {
                resultado = ws.Delete(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));
            }

        }

        public static ClassMenu Set_ClassWS_To_ClassSite(WS_Menu.ClassMenu value)
        {
            ClassMenu ret = new ClassMenu();

			
			 ret.uidmenu = value.uidmenu;
			 ret.uidrol = value.uidrol;
			 ret.uidpagina = value.uidpagina;
			 ret.esvisible = value.esvisible;
			 ret.semuestra = value.semuestra;
            return ret;
        }
        public static WS_Menu.ClassMenu Set_ClassSite_To_ClassWS(ClassMenu value)
        {
            WS_Menu.ClassMenu ret = new WS_Menu.ClassMenu();

			
			 ret.uidmenu = value.uidmenu;
			 ret.uidrol = value.uidrol;
			 ret.uidpagina = value.uidpagina;
			 ret.esvisible = value.esvisible;
			 ret.semuestra = value.semuestra;
			           
           
            return ret;
        }
        /// <summary>
        /// Validar campos que deben ser obligados y retorna el nombre de los campos que no soportan nulo
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static List<string> ValidarCamposNulos(ClassMenu value)
        {
            List<string> retornoCamposError = new List<string>();
            if (value.uidmenu == null) { retornoCamposError.Add(nameof(value.uidmenu)); }
            if (value.uidrol == null) { retornoCamposError.Add(nameof(value.uidrol)); }
            if (value.uidpagina == null) { retornoCamposError.Add(nameof(value.uidpagina)); }
            if (value.esvisible == null) { retornoCamposError.Add(nameof(value.esvisible)); }
            if (value.semuestra == null) { retornoCamposError.Add(nameof(value.semuestra)); }
            return retornoCamposError;
        }

    }
}