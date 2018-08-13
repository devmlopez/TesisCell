using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using SitioWeb.WS_Procesotipocomentario;
namespace SitioWeb.Controlador
{
    public class SqlProcesotipocomentario
    {
        public static List<ClassProcesotipocomentario> Select(string UidUserLogin,ClassProcesotipocomentario VALUE, out string resultado)
        {
            List<ClassProcesotipocomentario> ret = new List<ClassProcesotipocomentario>();
            resultado = "";
            using (WS_ProcesotipocomentarioSoapClient ws= new WS_ProcesotipocomentarioSoapClient())
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

	
		 public static DataTable SelectDataTable(string UidUserLogin,ClassProcesotipocomentario VALUE, out string resultado)
        {
           DataTable ret = new DataTable();
            resultado = "";
            using (WS_ProcesotipocomentarioSoapClient ws= new WS_ProcesotipocomentarioSoapClient())
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


		    public static ClassProcesotipocomentario SelectFirst(string UidUserLogin, string uidprocesotipocomentario, out string resultado)
        {
            ClassProcesotipocomentario ret = new ClassProcesotipocomentario();
            resultado = "";
            using (WS_ProcesotipocomentarioSoapClient ws= new WS_ProcesotipocomentarioSoapClient())
            {
                try
                {
                    var valueRet = ws.SelectFirst(UidUserLogin,uidprocesotipocomentario,ClasesUtiles.StatusExistencia.Activo, out  resultado);
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
            using (WS_ProcesotipocomentarioSoapClient ws = new WS_ProcesotipocomentarioSoapClient())
            {
                try
                {
                    var VALUE = new ClassProcesotipocomentario();                    
                   
                    var valuesRet = ws.Select(UidUserLogin, Set_ClassSite_To_ClassWS(VALUE), ClasesUtiles.StatusExistencia.Activo, out resultado);
                    foreach (var item in valuesRet)
                    {
                       ret.Add(new ClasesUtiles.ComboClassValueText() {
                          value=item.uidprocesotipocomentario,
                          text=item.uidtipocomentario
                        });
                    }
                }
                catch (Exception exc)
                {

                }
            }
            return ret;
        }


        public static void InsertInto(string UidUserLogin,ClassProcesotipocomentario VALUE, out string resultado)
        {
            resultado = "";
            using (WS_ProcesotipocomentarioSoapClient ws = new WS_ProcesotipocomentarioSoapClient())
            {
                resultado= ws.InsertInto(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));            
            } 
        }
        public static void Update(string UidUserLogin,ClassProcesotipocomentario VALUE, out string resultado)
        {
            resultado = "";
            using (WS_ProcesotipocomentarioSoapClient ws = new WS_ProcesotipocomentarioSoapClient())
            {
                resultado = ws.Update(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));
            }
        }
        public static void Delete(string UidUserLogin,ClassProcesotipocomentario VALUE, out string resultado)
        {
            resultado = "";
            using (WS_ProcesotipocomentarioSoapClient ws = new WS_ProcesotipocomentarioSoapClient())
            {
                resultado = ws.Delete(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));
            }

        }

        public static ClassProcesotipocomentario Set_ClassWS_To_ClassSite(WS_Procesotipocomentario.ClassProcesotipocomentario value)
        {
            ClassProcesotipocomentario ret = new ClassProcesotipocomentario();

			
			 ret.uidprocesotipocomentario = value.uidprocesotipocomentario;
			 ret.uidproceso = value.uidproceso;
			 ret.uidtipocomentario = value.uidtipocomentario;
			 //ret.aux1 = value.aux1;
    //        ret.aux2= value.aux2;
    //        ret.aux3 = value.aux3;
    //        ret.aux4 = value.aux4;
    //        ret.aux5 = value.aux5;
    //        ret.aux6 = value.aux6;
    //        ret.aux7 = value.aux7;
    //        ret.aux8 = value.aux8;
    //        ret.aux9 = value.aux9;
    //        ret.aux10 = value.aux10;

            return ret;
        }
        public static WS_Procesotipocomentario.ClassProcesotipocomentario Set_ClassSite_To_ClassWS(ClassProcesotipocomentario value)
        {
            WS_Procesotipocomentario.ClassProcesotipocomentario ret = new WS_Procesotipocomentario.ClassProcesotipocomentario();

			
			 ret.uidprocesotipocomentario = value.uidprocesotipocomentario;
			 ret.uidproceso = value.uidproceso;
			 ret.uidtipocomentario = value.uidtipocomentario;
			           
           
            return ret;
        }
        /// <summary>
        /// Validar campos que deben ser obligados y retorna el nombre de los campos que no soportan nulo
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static List<string> ValidarCamposNulos(ClassProcesotipocomentario value)
        {
            List<string> retornoCamposError = new List<string>();
            if (value.uidprocesotipocomentario == null) { retornoCamposError.Add(nameof(value.uidprocesotipocomentario)); }            
            if (value.uidproceso == null) { retornoCamposError.Add(nameof(value.uidproceso)); }
            if (value.uidtipocomentario == null) { retornoCamposError.Add(nameof(value.uidtipocomentario)); }
            return retornoCamposError;
        }

    }
}