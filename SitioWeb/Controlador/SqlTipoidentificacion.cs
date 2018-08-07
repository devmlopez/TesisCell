using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using SitioWeb.WS_Tipoidentificacion;
namespace SitioWeb.Controlador
{
    public class SqlTipoidentificacion
    {
        public static List<ClassTipoidentificacion> Select(string UidUserLogin,ClassTipoidentificacion VALUE, out string resultado)
        {
            List<ClassTipoidentificacion> ret = new List<ClassTipoidentificacion>();
            resultado = "";
            using (WS_TipoidentificacionSoapClient ws= new WS_TipoidentificacionSoapClient())
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

		    public static ClassTipoidentificacion SelectFirst(string UidUserLogin, string uidtipoidentificacion, out string resultado)
        {
            ClassTipoidentificacion ret = new ClassTipoidentificacion();
            resultado = "";
            using (WS_TipoidentificacionSoapClient ws= new WS_TipoidentificacionSoapClient())
            {
                try
                {
                    var valueRet = ws.SelectFirst(UidUserLogin,uidtipoidentificacion,ClasesUtiles.StatusExistencia.Activo, out  resultado);
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
            using (WS_TipoidentificacionSoapClient ws = new WS_TipoidentificacionSoapClient())
            {
                try
                {
                    var VALUE = new ClassTipoidentificacion();                    
                   
                    var valuesRet = ws.Select(UidUserLogin, Set_ClassSite_To_ClassWS(VALUE), ClasesUtiles.StatusExistencia.Activo, out resultado);
                    foreach (var item in valuesRet)
                    {
                       ret.Add(new ClasesUtiles.ComboClassValueText() {
                          value=item.uidtipoidentificacion,
                          text=item.tipoidentificacion
                        });
                    }
                }
                catch (Exception exc)
                {

                }
            }
            return ret;
        }


        public static void InsertInto(string UidUserLogin,ClassTipoidentificacion VALUE, out string resultado)
        {
            resultado = "";
            using (WS_TipoidentificacionSoapClient ws = new WS_TipoidentificacionSoapClient())
            {
                resultado= ws.InsertInto(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));            
            } 
        }
        public static void Update(string UidUserLogin,ClassTipoidentificacion VALUE, out string resultado)
        {
            resultado = "";
            using (WS_TipoidentificacionSoapClient ws = new WS_TipoidentificacionSoapClient())
            {
                resultado = ws.Update(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));
            }
        }
        public static void Delete(string UidUserLogin,ClassTipoidentificacion VALUE, out string resultado)
        {
            resultado = "";
            using (WS_TipoidentificacionSoapClient ws = new WS_TipoidentificacionSoapClient())
            {
                resultado = ws.Delete(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));
            }

        }

        public static ClassTipoidentificacion Set_ClassWS_To_ClassSite(WS_Tipoidentificacion.ClassTipoidentificacion value)
        {
            ClassTipoidentificacion ret = new ClassTipoidentificacion();

			
			 ret.uidtipoidentificacion = value.uidtipoidentificacion;
			 ret.tipoidentificacion = value.tipoidentificacion;
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
        public static WS_Tipoidentificacion.ClassTipoidentificacion Set_ClassSite_To_ClassWS(ClassTipoidentificacion value)
        {
            WS_Tipoidentificacion.ClassTipoidentificacion ret = new WS_Tipoidentificacion.ClassTipoidentificacion();

			
			 ret.uidtipoidentificacion = value.uidtipoidentificacion;
			 ret.tipoidentificacion = value.tipoidentificacion;
			           
           
            return ret;
        }

    }
}