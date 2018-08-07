using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using SitioWeb.WS_Estadocivil;
namespace SitioWeb.Controlador
{
    public class SqlEstadocivil
    {
        public static List<ClassEstadocivil> Select(string UidUserLogin,ClassEstadocivil VALUE, out string resultado)
        {
            List<ClassEstadocivil> ret = new List<ClassEstadocivil>();
            resultado = "";
            using (WS_EstadocivilSoapClient ws= new WS_EstadocivilSoapClient())
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

		    public static ClassEstadocivil SelectFirst(string UidUserLogin, string uidestadocivil, out string resultado)
        {
            ClassEstadocivil ret = new ClassEstadocivil();
            resultado = "";
            using (WS_EstadocivilSoapClient ws= new WS_EstadocivilSoapClient())
            {
                try
                {
                    var valueRet = ws.SelectFirst(UidUserLogin,uidestadocivil,ClasesUtiles.StatusExistencia.Activo, out  resultado);
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
            using (WS_EstadocivilSoapClient ws = new WS_EstadocivilSoapClient())
            {
                try
                {
                    var VALUE = new ClassEstadocivil();                    
                   
                    var valuesRet = ws.Select(UidUserLogin, Set_ClassSite_To_ClassWS(VALUE), ClasesUtiles.StatusExistencia.Activo, out resultado);
                    foreach (var item in valuesRet)
                    {
                       ret.Add(new ClasesUtiles.ComboClassValueText() {
                          value=item.uidestadocivil,
                          text=item.estadocivil
                        });
                    }
                }
                catch (Exception exc)
                {

                }
            }
            return ret;
        }


        public static void InsertInto(string UidUserLogin,ClassEstadocivil VALUE, out string resultado)
        {
            resultado = "";
            using (WS_EstadocivilSoapClient ws = new WS_EstadocivilSoapClient())
            {
                resultado= ws.InsertInto(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));            
            } 
        }
        public static void Update(string UidUserLogin,ClassEstadocivil VALUE, out string resultado)
        {
            resultado = "";
            using (WS_EstadocivilSoapClient ws = new WS_EstadocivilSoapClient())
            {
                resultado = ws.Update(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));
            }
        }
        public static void Delete(string UidUserLogin,ClassEstadocivil VALUE, out string resultado)
        {
            resultado = "";
            using (WS_EstadocivilSoapClient ws = new WS_EstadocivilSoapClient())
            {
                resultado = ws.Delete(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));
            }

        }

        public static ClassEstadocivil Set_ClassWS_To_ClassSite(WS_Estadocivil.ClassEstadocivil value)
        {
            ClassEstadocivil ret = new ClassEstadocivil();

			
			 ret.uidestadocivil = value.uidestadocivil;
			 ret.estadocivil = value.estadocivil;
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
        public static WS_Estadocivil.ClassEstadocivil Set_ClassSite_To_ClassWS(ClassEstadocivil value)
        {
            WS_Estadocivil.ClassEstadocivil ret = new WS_Estadocivil.ClassEstadocivil();

			
			 ret.uidestadocivil = value.uidestadocivil;
			 ret.estadocivil = value.estadocivil;
			           
           
            return ret;
        }

    }
}