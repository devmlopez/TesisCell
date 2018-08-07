using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using SitioWeb.WS_Tipopersona;
namespace SitioWeb.Controlador
{
    public class SqlTipopersona
    {
        public static List<ClassTipopersona> Select(string UidUserLogin,ClassTipopersona VALUE, out string resultado)
        {
            List<ClassTipopersona> ret = new List<ClassTipopersona>();
            resultado = "";
            using (WS_TipopersonaSoapClient ws= new WS_TipopersonaSoapClient())
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

		    public static ClassTipopersona SelectFirst(string UidUserLogin, string uidtipopersona, out string resultado)
        {
            ClassTipopersona ret = new ClassTipopersona();
            resultado = "";
            using (WS_TipopersonaSoapClient ws= new WS_TipopersonaSoapClient())
            {
                try
                {
                    var valueRet = ws.SelectFirst(UidUserLogin,uidtipopersona,ClasesUtiles.StatusExistencia.Activo, out  resultado);
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
            using (WS_TipopersonaSoapClient ws = new WS_TipopersonaSoapClient())
            {
                try
                {
                    var VALUE = new ClassTipopersona();                    
                   
                    var valuesRet = ws.Select(UidUserLogin, Set_ClassSite_To_ClassWS(VALUE), ClasesUtiles.StatusExistencia.Activo, out resultado);
                    foreach (var item in valuesRet)
                    {
                       ret.Add(new ClasesUtiles.ComboClassValueText() {
                          value=item.uidtipopersona,
                          text=item.tipopersona
                        });
                    }
                }
                catch (Exception exc)
                {

                }
            }
            return ret;
        }


        public static void InsertInto(string UidUserLogin,ClassTipopersona VALUE, out string resultado)
        {
            resultado = "";
            using (WS_TipopersonaSoapClient ws = new WS_TipopersonaSoapClient())
            {
                resultado= ws.InsertInto(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));            
            } 
        }
        public static void Update(string UidUserLogin,ClassTipopersona VALUE, out string resultado)
        {
            resultado = "";
            using (WS_TipopersonaSoapClient ws = new WS_TipopersonaSoapClient())
            {
                resultado = ws.Update(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));
            }
        }
        public static void Delete(string UidUserLogin,ClassTipopersona VALUE, out string resultado)
        {
            resultado = "";
            using (WS_TipopersonaSoapClient ws = new WS_TipopersonaSoapClient())
            {
                resultado = ws.Delete(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));
            }

        }

        public static ClassTipopersona Set_ClassWS_To_ClassSite(WS_Tipopersona.ClassTipopersona value)
        {
            ClassTipopersona ret = new ClassTipopersona();

			
			 ret.uidtipopersona = value.uidtipopersona;
			 ret.tipopersona = value.tipopersona;
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
        public static WS_Tipopersona.ClassTipopersona Set_ClassSite_To_ClassWS(ClassTipopersona value)
        {
            WS_Tipopersona.ClassTipopersona ret = new WS_Tipopersona.ClassTipopersona();

			
			 ret.uidtipopersona = value.uidtipopersona;
			 ret.tipopersona = value.tipopersona;
			           
           
            return ret;
        }

    }
}