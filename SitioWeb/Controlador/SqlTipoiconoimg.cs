using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using SitioWeb.WS_Tipoiconoimg;
namespace SitioWeb.Controlador
{
    public class SqlTipoiconoimg
    {
        public static List<ClassTipoiconoimg> Select(string UidUserLogin,ClassTipoiconoimg VALUE, out string resultado)
        {
            List<ClassTipoiconoimg> ret = new List<ClassTipoiconoimg>();
            resultado = "";
            using (WS_TipoiconoimgSoapClient ws= new WS_TipoiconoimgSoapClient())
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

		    public static ClassTipoiconoimg SelectFirst(string UidUserLogin, string uidtipoiconoimg, out string resultado)
        {
            ClassTipoiconoimg ret = new ClassTipoiconoimg();
            resultado = "";
            using (WS_TipoiconoimgSoapClient ws= new WS_TipoiconoimgSoapClient())
            {
                try
                {
                    var valueRet = ws.SelectFirst(UidUserLogin,uidtipoiconoimg,ClasesUtiles.StatusExistencia.Activo, out  resultado);
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
            using (WS_TipoiconoimgSoapClient ws = new WS_TipoiconoimgSoapClient())
            {
                try
                {
                    var VALUE = new ClassTipoiconoimg();                    
                   
                    var valuesRet = ws.Select(UidUserLogin, Set_ClassSite_To_ClassWS(VALUE), ClasesUtiles.StatusExistencia.Activo, out resultado);
                    foreach (var item in valuesRet)
                    {
                       ret.Add(new ClasesUtiles.ComboClassValueText() {
                          value=item.uidtipoiconoimg,
                          text=item.tipoiconoimg
                        });
                    }
                }
                catch (Exception exc)
                {

                }
            }
            return ret;
        }


        public static void InsertInto(string UidUserLogin,ClassTipoiconoimg VALUE, out string resultado)
        {
            resultado = "";
            using (WS_TipoiconoimgSoapClient ws = new WS_TipoiconoimgSoapClient())
            {
                resultado= ws.InsertInto(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));            
            } 
        }
        public static void Update(string UidUserLogin,ClassTipoiconoimg VALUE, out string resultado)
        {
            resultado = "";
            using (WS_TipoiconoimgSoapClient ws = new WS_TipoiconoimgSoapClient())
            {
                resultado = ws.Update(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));
            }
        }
        public static void Delete(string UidUserLogin,ClassTipoiconoimg VALUE, out string resultado)
        {
            resultado = "";
            using (WS_TipoiconoimgSoapClient ws = new WS_TipoiconoimgSoapClient())
            {
                resultado = ws.Delete(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));
            }

        }

        public static ClassTipoiconoimg Set_ClassWS_To_ClassSite(WS_Tipoiconoimg.ClassTipoiconoimg value)
        {
            ClassTipoiconoimg ret = new ClassTipoiconoimg();

			
			 ret.uidtipoiconoimg = value.uidtipoiconoimg;
			 ret.tipoiconoimg = value.tipoiconoimg;
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
        public static WS_Tipoiconoimg.ClassTipoiconoimg Set_ClassSite_To_ClassWS(ClassTipoiconoimg value)
        {
            WS_Tipoiconoimg.ClassTipoiconoimg ret = new WS_Tipoiconoimg.ClassTipoiconoimg();

			
			 ret.uidtipoiconoimg = value.uidtipoiconoimg;
			 ret.tipoiconoimg = value.tipoiconoimg;
			           
           
            return ret;
        }
        /// <summary>
        /// Validar campos que deben ser obligados y retorna el nombre de los campos que no soportan nulo
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static List<string> ValidarCamposNulos(ClassTipoiconoimg value)
        {
            List<string> retornoCamposError = new List<string>();
            if (value.uidtipoiconoimg == null) { retornoCamposError.Add(nameof(value.uidtipoiconoimg)); }
            if (value.tipoiconoimg == null) { retornoCamposError.Add(nameof(value.tipoiconoimg)); }
            return retornoCamposError;
        }

    }
}