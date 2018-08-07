using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using SitioWeb.WS_Sexo;
namespace SitioWeb.Controlador
{
    public class SqlSexo
    {
        public static List<ClassSexo> Select(string UidUserLogin,ClassSexo VALUE, out string resultado)
        {
            List<ClassSexo> ret = new List<ClassSexo>();
            resultado = "";
            using (WS_SexoSoapClient ws= new WS_SexoSoapClient())
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

		    public static ClassSexo SelectFirst(string UidUserLogin, string uidsexo, out string resultado)
        {
            ClassSexo ret = new ClassSexo();
            resultado = "";
            using (WS_SexoSoapClient ws= new WS_SexoSoapClient())
            {
                try
                {
                    var valueRet = ws.SelectFirst(UidUserLogin,uidsexo,ClasesUtiles.StatusExistencia.Activo, out  resultado);
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
            using (WS_SexoSoapClient ws = new WS_SexoSoapClient())
            {
                try
                {
                    var VALUE = new ClassSexo();                    
                   
                    var valuesRet = ws.Select(UidUserLogin, Set_ClassSite_To_ClassWS(VALUE), ClasesUtiles.StatusExistencia.Activo, out resultado);
                    foreach (var item in valuesRet)
                    {
                       ret.Add(new ClasesUtiles.ComboClassValueText() {
                          value=item.uidsexo,
                          text=item.sexo
                        });
                    }
                }
                catch (Exception exc)
                {

                }
            }
            return ret;
        }


        public static void InsertInto(string UidUserLogin,ClassSexo VALUE, out string resultado)
        {
            resultado = "";
            using (WS_SexoSoapClient ws = new WS_SexoSoapClient())
            {
                resultado= ws.InsertInto(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));            
            } 
        }
        public static void Update(string UidUserLogin,ClassSexo VALUE, out string resultado)
        {
            resultado = "";
            using (WS_SexoSoapClient ws = new WS_SexoSoapClient())
            {
                resultado = ws.Update(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));
            }
        }
        public static void Delete(string UidUserLogin,ClassSexo VALUE, out string resultado)
        {
            resultado = "";
            using (WS_SexoSoapClient ws = new WS_SexoSoapClient())
            {
                resultado = ws.Delete(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));
            }

        }

        public static ClassSexo Set_ClassWS_To_ClassSite(WS_Sexo.ClassSexo value)
        {
            ClassSexo ret = new ClassSexo();

			
			 ret.uidsexo = value.uidsexo;
			 ret.sexo = value.sexo;
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
        public static WS_Sexo.ClassSexo Set_ClassSite_To_ClassWS(ClassSexo value)
        {
            WS_Sexo.ClassSexo ret = new WS_Sexo.ClassSexo();

			
			 ret.uidsexo = value.uidsexo;
			 ret.sexo = value.sexo;
			           
           
            return ret;
        }

    }
}