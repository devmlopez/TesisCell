using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using SitioWeb.WS_Loginuser;
namespace SitioWeb.Controlador
{
    public class SqlLoginuser
    {
        public static List<ClassLoginuser> Select(string UidUserLogin,ClassLoginuser VALUE, out string resultado)
        {
            List<ClassLoginuser> ret = new List<ClassLoginuser>();
            resultado = "";
            using (WS_LoginuserSoapClient ws= new WS_LoginuserSoapClient())
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

		    public static ClassLoginuser SelectFirst(string UidUserLogin, string uidsuario, out string resultado)
        {
            ClassLoginuser ret = new ClassLoginuser();
            resultado = "";
            using (WS_LoginuserSoapClient ws= new WS_LoginuserSoapClient())
            {
                try
                {
                    var valueRet = ws.SelectFirst(UidUserLogin,uidsuario,ClasesUtiles.StatusExistencia.Activo, out  resultado);
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
            using (WS_LoginuserSoapClient ws = new WS_LoginuserSoapClient())
            {
                try
                {
                    var VALUE = new ClassLoginuser();                    
                   
                    var valuesRet = ws.Select(UidUserLogin, Set_ClassSite_To_ClassWS(VALUE), ClasesUtiles.StatusExistencia.Activo, out resultado);
                    foreach (var item in valuesRet)
                    {
                       ret.Add(new ClasesUtiles.ComboClassValueText() {
                          value=item.uidsuario,
                          text=item.nombre
                        });
                    }
                }
                catch (Exception exc)
                {

                }
            }
            return ret;
        }


        public static void InsertInto(string UidUserLogin,ClassLoginuser VALUE, out string resultado)
        {
            resultado = "";
            using (WS_LoginuserSoapClient ws = new WS_LoginuserSoapClient())
            {
                resultado= ws.InsertInto(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));            
            } 
        }
        public static void Update(string UidUserLogin,ClassLoginuser VALUE, out string resultado)
        {
            resultado = "";
            using (WS_LoginuserSoapClient ws = new WS_LoginuserSoapClient())
            {
                resultado = ws.Update(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));
            }
        }
        public static void Delete(string UidUserLogin,ClassLoginuser VALUE, out string resultado)
        {
            resultado = "";
            using (WS_LoginuserSoapClient ws = new WS_LoginuserSoapClient())
            {
                resultado = ws.Delete(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));
            }

        }

        public static ClassLoginuser Set_ClassWS_To_ClassSite(WS_Loginuser.ClassLoginuser value)
        {
            ClassLoginuser ret = new ClassLoginuser();

			
			 ret.uidsuario = value.uidsuario;
			 ret.usuario = value.usuario;
			 ret.email = value.email;
			 ret.nombre = value.nombre;
			 ret.contrasenia = value.contrasenia;
			 ret.uidrol = value.uidrol;
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
        public static WS_Loginuser.ClassLoginuser Set_ClassSite_To_ClassWS(ClassLoginuser value)
        {
            WS_Loginuser.ClassLoginuser ret = new WS_Loginuser.ClassLoginuser();

			
			 ret.uidsuario = value.uidsuario;
			 ret.usuario = value.usuario;
			 ret.email = value.email;
			 ret.nombre = value.nombre;
			 ret.contrasenia = value.contrasenia;
			 ret.uidrol = value.uidrol;
			           
           
            return ret;
        }

    }
}