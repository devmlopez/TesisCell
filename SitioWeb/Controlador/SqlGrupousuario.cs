using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using SitioWeb.WS_Grupousuario;
namespace SitioWeb.Controlador
{
    public class SqlGrupousuario
    {
        public static List<ClassGrupousuario> Select(string UidUserLogin,ClassGrupousuario VALUE, out string resultado)
        {
            List<ClassGrupousuario> ret = new List<ClassGrupousuario>();
            resultado = "";
            using (WS_GrupousuarioSoapClient ws= new WS_GrupousuarioSoapClient())
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

		    public static ClassGrupousuario SelectFirst(string UidUserLogin, string uidgrupousuario, out string resultado)
        {
            ClassGrupousuario ret = new ClassGrupousuario();
            resultado = "";
            using (WS_GrupousuarioSoapClient ws= new WS_GrupousuarioSoapClient())
            {
                try
                {
                    var valueRet = ws.SelectFirst(UidUserLogin,uidgrupousuario,ClasesUtiles.StatusExistencia.Activo, out  resultado);
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
            using (WS_GrupousuarioSoapClient ws = new WS_GrupousuarioSoapClient())
            {
                try
                {
                    var VALUE = new ClassGrupousuario();                    
                   
                    var valuesRet = ws.Select(UidUserLogin, Set_ClassSite_To_ClassWS(VALUE), ClasesUtiles.StatusExistencia.Activo, out resultado);
                    foreach (var item in valuesRet)
                    {
                       ret.Add(new ClasesUtiles.ComboClassValueText() {
                          value=item.uidgrupousuario,
                          text=item.uidgrupo
                        });
                    }
                }
                catch (Exception exc)
                {

                }
            }
            return ret;
        }


        public static void InsertInto(string UidUserLogin,ClassGrupousuario VALUE, out string resultado)
        {
            resultado = "";
            using (WS_GrupousuarioSoapClient ws = new WS_GrupousuarioSoapClient())
            {
                resultado= ws.InsertInto(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));            
            } 
        }
        public static void Update(string UidUserLogin,ClassGrupousuario VALUE, out string resultado)
        {
            resultado = "";
            using (WS_GrupousuarioSoapClient ws = new WS_GrupousuarioSoapClient())
            {
                resultado = ws.Update(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));
            }
        }
        public static void Delete(string UidUserLogin,ClassGrupousuario VALUE, out string resultado)
        {
            resultado = "";
            using (WS_GrupousuarioSoapClient ws = new WS_GrupousuarioSoapClient())
            {
                resultado = ws.Delete(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));
            }

        }

        public static ClassGrupousuario Set_ClassWS_To_ClassSite(WS_Grupousuario.ClassGrupousuario value)
        {
            ClassGrupousuario ret = new ClassGrupousuario();

			
			 ret.uidgrupousuario = value.uidgrupousuario;
			 ret.uidgrupo = value.uidgrupo;
			 ret.uidusuario = value.uidusuario;
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
        public static WS_Grupousuario.ClassGrupousuario Set_ClassSite_To_ClassWS(ClassGrupousuario value)
        {
            WS_Grupousuario.ClassGrupousuario ret = new WS_Grupousuario.ClassGrupousuario();

			
			 ret.uidgrupousuario = value.uidgrupousuario;
			 ret.uidgrupo = value.uidgrupo;
			 ret.uidusuario = value.uidusuario;
			           
           
            return ret;
        }

    }
}