using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using SitioWeb.WS_Grupo;
namespace SitioWeb.Controlador
{
    public class SqlGrupo
    {
        public static List<ClassGrupo> Select(string UidUserLogin,ClassGrupo VALUE, out string resultado)
        {
            List<ClassGrupo> ret = new List<ClassGrupo>();
            resultado = "";
            using (WS_GrupoSoapClient ws= new WS_GrupoSoapClient())
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

		    public static ClassGrupo SelectFirst(string UidUserLogin, string uidgrupo, out string resultado)
        {
            ClassGrupo ret = new ClassGrupo();
            resultado = "";
            using (WS_GrupoSoapClient ws= new WS_GrupoSoapClient())
            {
                try
                {
                    var valueRet = ws.SelectFirst(UidUserLogin,uidgrupo,ClasesUtiles.StatusExistencia.Activo, out  resultado);
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
            using (WS_GrupoSoapClient ws = new WS_GrupoSoapClient())
            {
                try
                {
                    var VALUE = new ClassGrupo();                    
                   
                    var valuesRet = ws.Select(UidUserLogin, Set_ClassSite_To_ClassWS(VALUE), ClasesUtiles.StatusExistencia.Activo, out resultado);
                    foreach (var item in valuesRet)
                    {
                       ret.Add(new ClasesUtiles.ComboClassValueText() {
                          value=item.uidgrupo,
                          text=item.grupo
                        });
                    }
                }
                catch (Exception exc)
                {

                }
            }
            return ret;
        }


        public static void InsertInto(string UidUserLogin,ClassGrupo VALUE, out string resultado)
        {
            resultado = "";
            using (WS_GrupoSoapClient ws = new WS_GrupoSoapClient())
            {
                resultado= ws.InsertInto(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));            
            } 
        }
        public static void Update(string UidUserLogin,ClassGrupo VALUE, out string resultado)
        {
            resultado = "";
            using (WS_GrupoSoapClient ws = new WS_GrupoSoapClient())
            {
                resultado = ws.Update(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));
            }
        }
        public static void Delete(string UidUserLogin,ClassGrupo VALUE, out string resultado)
        {
            resultado = "";
            using (WS_GrupoSoapClient ws = new WS_GrupoSoapClient())
            {
                resultado = ws.Delete(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));
            }

        }

        public static ClassGrupo Set_ClassWS_To_ClassSite(WS_Grupo.ClassGrupo value)
        {
            ClassGrupo ret = new ClassGrupo();

			
			 ret.uidgrupo = value.uidgrupo;
			 ret.grupo = value.grupo;
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
        public static WS_Grupo.ClassGrupo Set_ClassSite_To_ClassWS(ClassGrupo value)
        {
            WS_Grupo.ClassGrupo ret = new WS_Grupo.ClassGrupo();

			
			 ret.uidgrupo = value.uidgrupo;
			 ret.grupo = value.grupo;
			           
           
            return ret;
        }

    }
}