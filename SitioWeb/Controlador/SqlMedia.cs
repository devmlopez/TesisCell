using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using SitioWeb.WS_Media;
namespace SitioWeb.Controlador
{
    public class SqlMedia
    {
        public static List<ClassMedia> Select(string UidUserLogin,ClassMedia VALUE, out string resultado)
        {
            List<ClassMedia> ret = new List<ClassMedia>();
            resultado = "";
            using (WS_MediaSoapClient ws= new WS_MediaSoapClient())
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

	
		 public static DataTable SelectDataTable(string UidUserLogin,ClassMedia VALUE, out string resultado)
        {
           DataTable ret = new DataTable();
            resultado = "";
            using (WS_MediaSoapClient ws= new WS_MediaSoapClient())
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


		    public static ClassMedia SelectFirst(string UidUserLogin, string uidmedia, out string resultado)
        {
            ClassMedia ret = new ClassMedia();
            resultado = "";
            using (WS_MediaSoapClient ws= new WS_MediaSoapClient())
            {
                try
                {
                    var valueRet = ws.SelectFirst(UidUserLogin,uidmedia,ClasesUtiles.StatusExistencia.Activo, out  resultado);
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
            using (WS_MediaSoapClient ws = new WS_MediaSoapClient())
            {
                try
                {
                    var VALUE = new ClassMedia();                    
                   
                    var valuesRet = ws.Select(UidUserLogin, Set_ClassSite_To_ClassWS(VALUE), ClasesUtiles.StatusExistencia.Activo, out resultado);
                    foreach (var item in valuesRet)
                    {
                        ret.Add(new ClasesUtiles.ComboClassValueText() {
                            value = item.uidmedia,
                            text = item.codmedia.ToString()
                        });
                    }
                }
                catch (Exception exc)
                {

                }
            }
            return ret;
        }


        public static void InsertInto(string UidUserLogin,ClassMedia VALUE, out string resultado)
        {
            resultado = "";
            using (WS_MediaSoapClient ws = new WS_MediaSoapClient())
            {
                resultado= ws.InsertInto(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));            
            } 
        }
        public static void Update(string UidUserLogin,ClassMedia VALUE, out string resultado)
        {
            resultado = "";
            using (WS_MediaSoapClient ws = new WS_MediaSoapClient())
            {
                resultado = ws.Update(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));
            }
        }
        public static void Delete(string UidUserLogin,ClassMedia VALUE, out string resultado)
        {
            resultado = "";
            using (WS_MediaSoapClient ws = new WS_MediaSoapClient())
            {
                resultado = ws.Delete(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));
            }

        }

        public static ClassMedia Set_ClassWS_To_ClassSite(WS_Media.ClassMedia value)
        {
            ClassMedia ret = new ClassMedia();

			
			 ret.uidmedia = value.uidmedia;
			 ret.codmedia = value.codmedia;
			 ret.uidproceso = value.uidproceso;
			 ret.uidtipocomentario = value.uidtipocomentario;
			 ret.cometario = value.cometario;
			 ret.imagen = value.imagen;
			 ret.url = value.url;
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
        public static WS_Media.ClassMedia Set_ClassSite_To_ClassWS(ClassMedia value)
        {
            WS_Media.ClassMedia ret = new WS_Media.ClassMedia();

			
			 ret.uidmedia = value.uidmedia;
			 ret.codmedia = value.codmedia;
			 ret.uidproceso = value.uidproceso;
			 ret.uidtipocomentario = value.uidtipocomentario;
			 ret.cometario = value.cometario;
			 ret.imagen = value.imagen;
			 ret.url = value.url;
			           
           
            return ret;
        }

    }
}