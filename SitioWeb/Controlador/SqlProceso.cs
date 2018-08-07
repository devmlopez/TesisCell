using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using SitioWeb.WS_Proceso;
namespace SitioWeb.Controlador
{
    public class SqlProceso
    {
        public static List<ClassProceso> Select(string UidUserLogin,ClassProceso VALUE, out string resultado)
        {
            List<ClassProceso> ret = new List<ClassProceso>();
            resultado = "";
            using (WS_ProcesoSoapClient ws= new WS_ProcesoSoapClient())
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

	
		 public static DataTable SelectDataTable(string UidUserLogin,ClassProceso VALUE, out string resultado)
        {
           DataTable ret = new DataTable();
            resultado = "";
            using (WS_ProcesoSoapClient ws= new WS_ProcesoSoapClient())
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


		    public static ClassProceso SelectFirst(string UidUserLogin, string uidproceso, out string resultado)
        {
            ClassProceso ret = new ClassProceso();
            resultado = "";
            using (WS_ProcesoSoapClient ws= new WS_ProcesoSoapClient())
            {
                try
                {
                    var valueRet = ws.SelectFirst(UidUserLogin,uidproceso,ClasesUtiles.StatusExistencia.Activo, out  resultado);
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
            using (WS_ProcesoSoapClient ws = new WS_ProcesoSoapClient())
            {
                try
                {
                    var VALUE = new ClassProceso();                    
                   
                    var valuesRet = ws.Select(UidUserLogin, Set_ClassSite_To_ClassWS(VALUE), ClasesUtiles.StatusExistencia.Activo, out resultado);
                    foreach (var item in valuesRet)
                    {
                       ret.Add(new ClasesUtiles.ComboClassValueText() {
                          value=item.uidproceso,
                          text=item.codproceso.ToString()
                    });
                    }
                }
                catch (Exception exc)
                {

                }
            }
            return ret;
        }


        public static void InsertInto(string UidUserLogin,ClassProceso VALUE, out string resultado)
        {
            resultado = "";
            using (WS_ProcesoSoapClient ws = new WS_ProcesoSoapClient())
            {
                resultado= ws.InsertInto(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));            
            } 
        }
        public static void Update(string UidUserLogin,ClassProceso VALUE, out string resultado)
        {
            resultado = "";
            using (WS_ProcesoSoapClient ws = new WS_ProcesoSoapClient())
            {
                resultado = ws.Update(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));
            }
        }
        public static void Delete(string UidUserLogin,ClassProceso VALUE, out string resultado)
        {
            resultado = "";
            using (WS_ProcesoSoapClient ws = new WS_ProcesoSoapClient())
            {
                resultado = ws.Delete(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));
            }

        }

        public static ClassProceso Set_ClassWS_To_ClassSite(WS_Proceso.ClassProceso value)
        {
            ClassProceso ret = new ClassProceso();

			
			 ret.uidproceso = value.uidproceso;
			 ret.codproceso = value.codproceso;
			 ret.uidserviciotecnico = value.uidserviciotecnico;
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
        public static WS_Proceso.ClassProceso Set_ClassSite_To_ClassWS(ClassProceso value)
        {
            WS_Proceso.ClassProceso ret = new WS_Proceso.ClassProceso();

			
			 ret.uidproceso = value.uidproceso;
			 ret.codproceso = value.codproceso;
			 ret.uidserviciotecnico = value.uidserviciotecnico;
			           
           
            return ret;
        }

    }
}