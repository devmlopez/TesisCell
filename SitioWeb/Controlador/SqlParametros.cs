using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using SitioWeb.WS_Parametros;
namespace SitioWeb.Controlador
{
    public class SqlParametros
    {
        public static List<ClassParametros> Select(string UidUserLogin,ClassParametros VALUE, out string resultado)
        {
            List<ClassParametros> ret = new List<ClassParametros>();
            resultado = "";
            using (WS_ParametrosSoapClient ws= new WS_ParametrosSoapClient())
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

		    public static ClassParametros SelectFirst(string UidUserLogin, string uidparmetro, out string resultado)
        {
            ClassParametros ret = new ClassParametros();
            resultado = "";
            using (WS_ParametrosSoapClient ws= new WS_ParametrosSoapClient())
            {
                try
                {
                    var valueRet = ws.SelectFirst(UidUserLogin,uidparmetro,ClasesUtiles.StatusExistencia.Activo, out  resultado);
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
            using (WS_ParametrosSoapClient ws = new WS_ParametrosSoapClient())
            {
                try
                {
                    var VALUE = new ClassParametros();                    
                   
                    var valuesRet = ws.Select(UidUserLogin, Set_ClassSite_To_ClassWS(VALUE), ClasesUtiles.StatusExistencia.Activo, out resultado);
                    foreach (var item in valuesRet)
                    {
                       ret.Add(new ClasesUtiles.ComboClassValueText() {
                          value=item.uidparmetro,
                          text=item.textshort
                        });
                    }
                }
                catch (Exception exc)
                {

                }
            }
            return ret;
        }


        public static void InsertInto(string UidUserLogin,ClassParametros VALUE, out string resultado)
        {
            resultado = "";
            using (WS_ParametrosSoapClient ws = new WS_ParametrosSoapClient())
            {
                resultado= ws.InsertInto(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));            
            } 
        }
        public static void Update(string UidUserLogin,ClassParametros VALUE, out string resultado)
        {
            resultado = "";
            using (WS_ParametrosSoapClient ws = new WS_ParametrosSoapClient())
            {
                resultado = ws.Update(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));
            }
        }
        public static void Delete(string UidUserLogin,ClassParametros VALUE, out string resultado)
        {
            resultado = "";
            using (WS_ParametrosSoapClient ws = new WS_ParametrosSoapClient())
            {
                resultado = ws.Delete(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));
            }

        }

        public static ClassParametros Set_ClassWS_To_ClassSite(WS_Parametros.ClassParametros value)
        {
            ClassParametros ret = new ClassParametros();

			
			 ret.uidparmetro = value.uidparmetro;
			 ret.moduloreferencia = value.moduloreferencia;
			 ret.value = value.value;
			 ret.textshort = value.textshort;
			 ret.textlong = value.textlong;
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
        public static WS_Parametros.ClassParametros Set_ClassSite_To_ClassWS(ClassParametros value)
        {
            WS_Parametros.ClassParametros ret = new WS_Parametros.ClassParametros();

			
			 ret.uidparmetro = value.uidparmetro;
			 ret.moduloreferencia = value.moduloreferencia;
			 ret.value = value.value;
			 ret.textshort = value.textshort;
			 ret.textlong = value.textlong;
			           
           
            return ret;
        }

    }
}