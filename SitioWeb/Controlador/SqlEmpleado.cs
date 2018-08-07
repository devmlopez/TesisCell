using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using SitioWeb.WS_Empleado; 

namespace SitioWeb.Controlador
{
    public class SqlEmpleado
    {
        public static List<ClassEmpleado> Select(string UidUserLogin,ClassEmpleado VALUE, out string resultado)
        {
            List<ClassEmpleado> ret = new List<ClassEmpleado>();
            resultado = "";
            using (WS_EmpleadoSoapClient ws= new WS_EmpleadoSoapClient())
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

		    public static ClassEmpleado SelectFirst(string UidUserLogin, string uidempleado, out string resultado)
        {
            ClassEmpleado ret = new ClassEmpleado();
            resultado = "";
            using (WS_EmpleadoSoapClient ws= new WS_EmpleadoSoapClient())
            {
                try
                {
                    var valueRet = ws.SelectFirst(UidUserLogin,uidempleado,ClasesUtiles.StatusExistencia.Activo, out  resultado);
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
            using (WS_EmpleadoSoapClient ws = new WS_EmpleadoSoapClient())
            {
                try
                {
                    var VALUE = new ClassEmpleado();                    
                   
                    var valuesRet = ws.Select(UidUserLogin, Set_ClassSite_To_ClassWS(VALUE), ClasesUtiles.StatusExistencia.Activo, out resultado);
                    foreach (var item in valuesRet)
                    {
                       ret.Add(new ClasesUtiles.ComboClassValueText() {
                          value=item.uidempleado,
                          text=item.apellidos
                        });
                    }
                }
                catch (Exception exc)
                {

                }
            }
            return ret;
        }


        public static void InsertInto(string UidUserLogin,ClassEmpleado VALUE, out string resultado)
        {
            resultado = "";
            using (WS_EmpleadoSoapClient ws = new WS_EmpleadoSoapClient())
            {
                resultado= ws.InsertInto(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));            
            } 
        }
        public static void Update(string UidUserLogin,ClassEmpleado VALUE, out string resultado)
        {
            resultado = "";
            using (WS_EmpleadoSoapClient ws = new WS_EmpleadoSoapClient())
            {
                resultado = ws.Update(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));
            }
        }
        public static void Delete(string UidUserLogin,ClassEmpleado VALUE, out string resultado)
        {
            resultado = "";
            using (WS_EmpleadoSoapClient ws = new WS_EmpleadoSoapClient())
            {
                resultado = ws.Delete(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));
            }

        }

        public static ClassEmpleado Set_ClassWS_To_ClassSite(SitioWeb.WS_Empleado.ClassEmpleado value)
        {
            ClassEmpleado ret = new ClassEmpleado();

			
			 ret.uidempleado = value.uidempleado;
			 ret.codido = value.codido;
			 ret.cedula = value.cedula;
			 ret.nombres = value.nombres;
			 ret.apellidos = value.apellidos;
			 ret.uidestadocivil = value.uidestadocivil;
			 ret.fechanacimiento = value.fechanacimiento;
			 ret.uidsexo = value.uidsexo;
			 ret.telefono = value.telefono;
			 ret.num_hijos = value.num_hijos;
			 ret.uidnivelestudio = value.uidnivelestudio;
			 ret.titulo_obtenido = value.titulo_obtenido;
			 ret.direccion_domicilio = value.direccion_domicilio;
			 ret.provincia = value.provincia;
			 ret.ciudad = value.ciudad;
			 ret.email = value.email;
			 ret.email_trabajo = value.email_trabajo;
			 ret.fecha_ingreso = value.fecha_ingreso;
			 ret.uidsuario = value.uidsuario;
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
        public static WS_Empleado.ClassEmpleado Set_ClassSite_To_ClassWS(ClassEmpleado value)
        {
            WS_Empleado.ClassEmpleado ret = new WS_Empleado.ClassEmpleado();

			
			 ret.uidempleado = value.uidempleado;
			 ret.codido = value.codido;
			 ret.cedula = value.cedula;
			 ret.nombres = value.nombres;
			 ret.apellidos = value.apellidos;
			 ret.uidestadocivil = value.uidestadocivil;
			 ret.fechanacimiento = value.fechanacimiento;
			 ret.uidsexo = value.uidsexo;
			 ret.telefono = value.telefono;
			 ret.num_hijos = value.num_hijos;
			 ret.uidnivelestudio = value.uidnivelestudio;
			 ret.titulo_obtenido = value.titulo_obtenido;
			 ret.direccion_domicilio = value.direccion_domicilio;
			 ret.provincia = value.provincia;
			 ret.ciudad = value.ciudad;
			 ret.email = value.email;
			 ret.email_trabajo = value.email_trabajo;
			 ret.fecha_ingreso = value.fecha_ingreso;
			 ret.uidsuario = value.uidsuario;
			           
           
            return ret;
        }

    }
}