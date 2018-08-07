using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using SitioWeb.WS_Tipocomentario;
namespace SitioWeb.Controlador
{
    public class SqlTipocomentario
    {
        public static List<ClassTipocomentario> Select(string UidUserLogin,ClassTipocomentario VALUE, out string resultado)
        {
            List<ClassTipocomentario> ret = new List<ClassTipocomentario>();
            resultado = "";
            using (WS_TipocomentarioSoapClient ws= new WS_TipocomentarioSoapClient())
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

	
		 public static DataTable SelectDataTable(string UidUserLogin,ClassTipocomentario VALUE, out string resultado)
        {
           DataTable ret = new DataTable();
            resultado = "";
            using (WS_TipocomentarioSoapClient ws= new WS_TipocomentarioSoapClient())
            {
                try
                {
                    var valuesRet = ws.SelectDataTable(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE),ClasesUtiles.StatusExistencia.Activo, out resultado);                    
					ret=valuesRet;
                }
                catch (Exception exc)
                {

                }
            }
            return ret;
        }


		    public static ClassTipocomentario SelectFirst(string UidUserLogin, string uidtipocomentario, out string resultado)
        {
            ClassTipocomentario ret = new ClassTipocomentario();
            resultado = "";
            using (WS_TipocomentarioSoapClient ws= new WS_TipocomentarioSoapClient())
            {
                try
                {
                    var valueRet = ws.SelectFirst(UidUserLogin,uidtipocomentario,ClasesUtiles.StatusExistencia.Activo, out  resultado);
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
            using (WS_TipocomentarioSoapClient ws = new WS_TipocomentarioSoapClient())
            {
                try
                {
                    var VALUE = new ClassTipocomentario();                    
                   
                    var valuesRet = ws.Select(UidUserLogin, Set_ClassSite_To_ClassWS(VALUE), ClasesUtiles.StatusExistencia.Activo, out resultado);
                    foreach (var item in valuesRet)
                    {
                       ret.Add(new ClasesUtiles.ComboClassValueText() {
                          value=item.uidtipocomentario,
                          text=item.tipocomentario
                        });
                    }
                }
                catch (Exception exc)
                {

                }
            }
            return ret;
        }


        public static void InsertInto(string UidUserLogin,ClassTipocomentario VALUE, out string resultado)
        {
            resultado = "";
            using (WS_TipocomentarioSoapClient ws = new WS_TipocomentarioSoapClient())
            {
                resultado= ws.InsertInto(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));            
            } 
        }
        public static void Update(string UidUserLogin,ClassTipocomentario VALUE, out string resultado)
        {
            resultado = "";
            using (WS_TipocomentarioSoapClient ws = new WS_TipocomentarioSoapClient())
            {
                resultado = ws.Update(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));
            }
        }
        public static void Delete(string UidUserLogin,ClassTipocomentario VALUE, out string resultado)
        {
            resultado = "";
            using (WS_TipocomentarioSoapClient ws = new WS_TipocomentarioSoapClient())
            {
                resultado = ws.Delete(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));
            }

        }

        public static ClassTipocomentario Set_ClassWS_To_ClassSite(WS_Tipocomentario.ClassTipocomentario value)
        {
            ClassTipocomentario ret = new ClassTipocomentario();

			
			 ret.uidtipocomentario = value.uidtipocomentario;
			 ret.tipocomentario = value.tipocomentario;
			 //ret.aux1 = value.aux1;
    //        ret.aux2= value.aux2;
    //        ret.aux3 = value.aux3;
    //        ret.aux4 = value.aux4;
    //        ret.aux5 = value.aux5;
    //        ret.aux6 = value.aux6;
    //        ret.aux7 = value.aux7;
    //        ret.aux8 = value.aux8;
    //        ret.aux9 = value.aux9;
    //        ret.aux10 = value.aux10;

            return ret;
        }
        public static WS_Tipocomentario.ClassTipocomentario Set_ClassSite_To_ClassWS(ClassTipocomentario value)
        {
            WS_Tipocomentario.ClassTipocomentario ret = new WS_Tipocomentario.ClassTipocomentario();

			
			 ret.uidtipocomentario = value.uidtipocomentario;
			 ret.tipocomentario = value.tipocomentario;
			           
           
            return ret;
        }

    }
}