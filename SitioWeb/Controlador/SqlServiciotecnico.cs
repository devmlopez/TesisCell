using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using SitioWeb.WS_Serviciotecnico;
namespace SitioWeb.Controlador
{
    public class SqlServiciotecnico
    {
        public static List<ClassServiciotecnico> Select(string UidUserLogin,ClassServiciotecnico VALUE, out string resultado)
        {
            List<ClassServiciotecnico> ret = new List<ClassServiciotecnico>();
            resultado = "";
            using (WS_ServiciotecnicoSoapClient ws= new WS_ServiciotecnicoSoapClient())
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

	
		 public static DataTable SelectDataTable(string UidUserLogin,ClassServiciotecnico VALUE, out string resultado)
        {
           DataTable ret = new DataTable();
            resultado = "";
            using (WS_ServiciotecnicoSoapClient ws= new WS_ServiciotecnicoSoapClient())
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


		    public static ClassServiciotecnico SelectFirst(string UidUserLogin, string uidserviciotecnico, out string resultado)
        {
            ClassServiciotecnico ret = new ClassServiciotecnico();
            resultado = "";
            using (WS_ServiciotecnicoSoapClient ws= new WS_ServiciotecnicoSoapClient())
            {
                try
                {
                    var valueRetDT = ws.SelectDataTable(UidUserLogin,
                        new WS_Serviciotecnico.ClassServiciotecnico
                        {
                            uidserviciotecnico = uidserviciotecnico
                        }
                        , ClasesUtiles.StatusExistencia.Activo, out  resultado);              

                    var valueRet = (from row in valueRetDT.AsEnumerable()
                                     select new Controlador.ClassServiciotecnico
                                     {
                                         uidserviciotecnico = row.Field<string>("uidserviciotecnico"),
                                         codservicio = row.Field<int?>("codservicio"),
                                         uidcliente = row.Field<string>("uidcliente"),
                                         uidempleado = row.Field<string>("uidempleado"),
                                         fechaingreso = row.Field<DateTime?>("fechaingreso"),
                                         marca = row.Field<string>("marca"),
                                         modelo = row.Field<string>("modelo"),
                                         problemasugerido = row.Field<string>("problemasugerido"),
                                         aux1 = row.Field<string>("aux1"),
                                         aux2 = row.Field<string>("aux2"),
                                         aux3 = row.Field<string>("aux3"),
                                         aux4 = row.Field<string>("aux4"),
                                         aux5 = row.Field<string>("aux5"),
                                         aux6 = row.Field<string>("aux6"),
                                         aux7 = row.Field<string>("aux7"),
                                         aux8 = row.Field<string>("aux8"),
                                         aux9 = row.Field<string>("aux9"),
                                         aux10 = row.Field<string>("aux10"),
                                     }).FirstOrDefault();

                    //ret =Set_ClassWS_To_ClassSite(valueRet);
                    ret = valueRet;

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
            using (WS_ServiciotecnicoSoapClient ws = new WS_ServiciotecnicoSoapClient())
            {
                try
                {
                    var VALUE = new ClassServiciotecnico();                    
                   
                    var valuesRet = ws.Select(UidUserLogin, Set_ClassSite_To_ClassWS(VALUE), ClasesUtiles.StatusExistencia.Activo, out resultado);
                    foreach (var item in valuesRet)
                    {
                        ret.Add(new ClasesUtiles.ComboClassValueText() {
                            value = item.uidserviciotecnico,
                            text = item.codservicio.ToString()
                        });
                    }
                }
                catch (Exception exc)
                {

                }
            }
            return ret;
        }


        public static void InsertInto(string UidUserLogin,ClassServiciotecnico VALUE, out string resultado)
        {
            resultado = "";
            using (WS_ServiciotecnicoSoapClient ws = new WS_ServiciotecnicoSoapClient())
            {
                resultado= ws.InsertInto(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));            
            } 
        }
        public static void Update(string UidUserLogin,ClassServiciotecnico VALUE, out string resultado)
        {
            resultado = "";
            using (WS_ServiciotecnicoSoapClient ws = new WS_ServiciotecnicoSoapClient())
            {
                resultado = ws.Update(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));
            }
        }
        public static void Delete(string UidUserLogin,ClassServiciotecnico VALUE, out string resultado)
        {
            resultado = "";
            using (WS_ServiciotecnicoSoapClient ws = new WS_ServiciotecnicoSoapClient())
            {
                resultado = ws.Delete(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));
            }

        }

        public static ClassServiciotecnico Set_ClassWS_To_ClassSite(WS_Serviciotecnico.ClassServiciotecnico value)
        {
            ClassServiciotecnico ret = new ClassServiciotecnico();

			
			 ret.uidserviciotecnico = value.uidserviciotecnico;
			 ret.codservicio = value.codservicio;
			 ret.uidcliente = value.uidcliente;
			 ret.uidempleado = value.uidempleado;
			 ret.fechaingreso = value.fechaingreso;
			 ret.marca = value.marca;
			 ret.modelo = value.modelo;
			 ret.problemasugerido = value.problemasugerido;
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
        public static WS_Serviciotecnico.ClassServiciotecnico Set_ClassSite_To_ClassWS(ClassServiciotecnico value)
        {
            WS_Serviciotecnico.ClassServiciotecnico ret = new WS_Serviciotecnico.ClassServiciotecnico();

			
			 ret.uidserviciotecnico = value.uidserviciotecnico;
			 ret.codservicio = value.codservicio;
			 ret.uidcliente = value.uidcliente;
			 ret.uidempleado = value.uidempleado;
			 ret.fechaingreso = value.fechaingreso;
			 ret.marca = value.marca;
			 ret.modelo = value.modelo;
			 ret.problemasugerido = value.problemasugerido;
			           
           
            return ret;
        }

    }
}