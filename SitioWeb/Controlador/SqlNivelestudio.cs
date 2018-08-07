using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using SitioWeb.WS_Nivelestudio;
namespace SitioWeb.Controlador
{
    public class SqlNivelestudio
    {
        public static List<ClassNivelestudio> Select(string UidUserLogin,ClassNivelestudio VALUE, out string resultado)
        {
            List<ClassNivelestudio> ret = new List<ClassNivelestudio>();
            resultado = "";
            using (WS_NivelestudioSoapClient ws= new WS_NivelestudioSoapClient())
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

		    public static ClassNivelestudio SelectFirst(string UidUserLogin, string uidnivelestudio, out string resultado)
        {
            ClassNivelestudio ret = new ClassNivelestudio();
            resultado = "";
            using (WS_NivelestudioSoapClient ws= new WS_NivelestudioSoapClient())
            {
                try
                {
                    var valueRet = ws.SelectFirst(UidUserLogin,uidnivelestudio,ClasesUtiles.StatusExistencia.Activo, out  resultado);
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
            using (WS_NivelestudioSoapClient ws = new WS_NivelestudioSoapClient())
            {
                try
                {
                    var VALUE = new ClassNivelestudio();                    
                   
                    var valuesRet = ws.Select(UidUserLogin, Set_ClassSite_To_ClassWS(VALUE), ClasesUtiles.StatusExistencia.Activo, out resultado);
                    foreach (var item in valuesRet)
                    {
                       ret.Add(new ClasesUtiles.ComboClassValueText() {
                          value=item.uidnivelestudio,
                          text=item.nivelestudio
                        });
                    }
                }
                catch (Exception exc)
                {

                }
            }
            return ret;
        }


        public static void InsertInto(string UidUserLogin,ClassNivelestudio VALUE, out string resultado)
        {
            resultado = "";
            using (WS_NivelestudioSoapClient ws = new WS_NivelestudioSoapClient())
            {
                resultado= ws.InsertInto(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));            
            } 
        }
        public static void Update(string UidUserLogin,ClassNivelestudio VALUE, out string resultado)
        {
            resultado = "";
            using (WS_NivelestudioSoapClient ws = new WS_NivelestudioSoapClient())
            {
                resultado = ws.Update(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));
            }
        }
        public static void Delete(string UidUserLogin,ClassNivelestudio VALUE, out string resultado)
        {
            resultado = "";
            using (WS_NivelestudioSoapClient ws = new WS_NivelestudioSoapClient())
            {
                resultado = ws.Delete(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));
            }

        }

        public static ClassNivelestudio Set_ClassWS_To_ClassSite(WS_Nivelestudio.ClassNivelestudio value)
        {
            ClassNivelestudio ret = new ClassNivelestudio();

			
			 ret.uidnivelestudio = value.uidnivelestudio;
			 ret.nivelestudio = value.nivelestudio;
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
        public static WS_Nivelestudio.ClassNivelestudio Set_ClassSite_To_ClassWS(ClassNivelestudio value)
        {
            WS_Nivelestudio.ClassNivelestudio ret = new WS_Nivelestudio.ClassNivelestudio();

			
			 ret.uidnivelestudio = value.uidnivelestudio;
			 ret.nivelestudio = value.nivelestudio;
			           
           
            return ret;
        }

    }
}