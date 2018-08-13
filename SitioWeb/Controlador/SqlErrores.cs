using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using SitioWeb.WS_Errores;
namespace SitioWeb.Controlador
{
    public class SqlErrores
    {
        public static List<ClassErrores> Select(string UidUserLogin,ClassErrores VALUE, out string resultado)
        {
            List<ClassErrores> ret = new List<ClassErrores>();
            resultado = "";
            using (WS_ErroresSoapClient ws= new WS_ErroresSoapClient())
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

		    public static ClassErrores SelectFirst(string UidUserLogin, string uid_error, out string resultado)
        {
            ClassErrores ret = new ClassErrores();
            resultado = "";
            using (WS_ErroresSoapClient ws= new WS_ErroresSoapClient())
            {
                try
                {
                    var valueRet = ws.SelectFirst(UidUserLogin,uid_error,ClasesUtiles.StatusExistencia.Activo, out  resultado);
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
            using (WS_ErroresSoapClient ws = new WS_ErroresSoapClient())
            {
                try
                {
                    var VALUE = new ClassErrores();                    
                   
                    var valuesRet = ws.Select(UidUserLogin, Set_ClassSite_To_ClassWS(VALUE), ClasesUtiles.StatusExistencia.Activo, out resultado);
                    foreach (var item in valuesRet)
                    {
                       ret.Add(new ClasesUtiles.ComboClassValueText() {
                          value=item.uid_error,
                          text=item.cod_error
                        });
                    }
                }
                catch (Exception exc)
                {

                }
            }
            return ret;
        }


        public static void InsertInto(string UidUserLogin,ClassErrores VALUE, out string resultado)
        {
            resultado = "";
            using (WS_ErroresSoapClient ws = new WS_ErroresSoapClient())
            {
                resultado= ws.InsertInto(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));            
            } 
        }
        public static void Update(string UidUserLogin,ClassErrores VALUE, out string resultado)
        {
            resultado = "";
            using (WS_ErroresSoapClient ws = new WS_ErroresSoapClient())
            {
                resultado = ws.Update(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));
            }
        }
        public static void Delete(string UidUserLogin,ClassErrores VALUE, out string resultado)
        {
            resultado = "";
            using (WS_ErroresSoapClient ws = new WS_ErroresSoapClient())
            {
                resultado = ws.Delete(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));
            }

        }

        public static ClassErrores Set_ClassWS_To_ClassSite(WS_Errores.ClassErrores value)
        {
            ClassErrores ret = new ClassErrores();

			
			 ret.uid_error = value.uid_error;
			 ret.cod_error = value.cod_error;
			 ret.mensajeusuario = value.mensajeusuario;
			 ret.mensajenativo = value.mensajenativo;
			 ret.origenerror = value.origenerror;
			 ret.tipoerror = value.tipoerror;
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
        public static WS_Errores.ClassErrores Set_ClassSite_To_ClassWS(ClassErrores value)
        {
            WS_Errores.ClassErrores ret = new WS_Errores.ClassErrores();

			
			 ret.uid_error = value.uid_error;
			 ret.cod_error = value.cod_error;
			 ret.mensajeusuario = value.mensajeusuario;
			 ret.mensajenativo = value.mensajenativo;
			 ret.origenerror = value.origenerror;
			 ret.tipoerror = value.tipoerror;
			           
           
            return ret;
        }

        /// <summary>
        /// Validar campos que deben ser obligados y retorna el nombre de los campos que no soportan nulo
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static List<string> ValidarCamposNulos(ClassErrores value)
        {
            List<string> retornoCamposError = new List<string>();
            if (value.uid_error == null) { retornoCamposError.Add(nameof(value.uid_error)); }
           // if (value.cod_error == null) { retornoCamposError.Add(nameof(value.cod_error)); }
            if (value.mensajeusuario == null) { retornoCamposError.Add(nameof(value.mensajeusuario)); }
            if (value.mensajenativo == null) { retornoCamposError.Add(nameof(value.mensajenativo)); }
            if (value.origenerror == null) { retornoCamposError.Add(nameof(value.origenerror)); }
            if (value.tipoerror == null) { retornoCamposError.Add(nameof(value.tipoerror)); }

            return retornoCamposError;
        }

    }
}