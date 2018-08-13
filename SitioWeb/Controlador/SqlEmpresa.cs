using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using SitioWeb.WS_Empresa;
namespace SitioWeb.Controlador
{
    public class SqlEmpresa
    {
        public static List<ClassEmpresa> Select(string UidUserLogin,ClassEmpresa VALUE, out string resultado)
        {
            List<ClassEmpresa> ret = new List<ClassEmpresa>();
            resultado = "";
            using (WS_EmpresaSoapClient ws= new WS_EmpresaSoapClient())
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

		    public static ClassEmpresa SelectFirst(string UidUserLogin, string uid_empresa, out string resultado)
        {
            ClassEmpresa ret = new ClassEmpresa();
            resultado = "";
            using (WS_EmpresaSoapClient ws= new WS_EmpresaSoapClient())
            {
                try
                {
                    var valueRet = ws.SelectFirst(UidUserLogin,uid_empresa,ClasesUtiles.StatusExistencia.Activo, out  resultado);
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
            using (WS_EmpresaSoapClient ws = new WS_EmpresaSoapClient())
            {
                try
                {
                    var VALUE = new ClassEmpresa();                    
                   
                    var valuesRet = ws.Select(UidUserLogin, Set_ClassSite_To_ClassWS(VALUE), ClasesUtiles.StatusExistencia.Activo, out resultado);
                    foreach (var item in valuesRet)
                    {
                       ret.Add(new ClasesUtiles.ComboClassValueText() {
                          value=item.uid_empresa,
                          text=item.ruc
                        });
                    }
                }
                catch (Exception exc)
                {

                }
            }
            return ret;
        }


        public static void InsertInto(string UidUserLogin,ClassEmpresa VALUE, out string resultado)
        {
            resultado = "";
            using (WS_EmpresaSoapClient ws = new WS_EmpresaSoapClient())
            {
                resultado= ws.InsertInto(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));            
            } 
        }
        public static void Update(string UidUserLogin,ClassEmpresa VALUE, out string resultado)
        {
            resultado = "";
            using (WS_EmpresaSoapClient ws = new WS_EmpresaSoapClient())
            {
                resultado = ws.Update(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));
            }
        }
        public static void Delete(string UidUserLogin,ClassEmpresa VALUE, out string resultado)
        {
            resultado = "";
            using (WS_EmpresaSoapClient ws = new WS_EmpresaSoapClient())
            {
                resultado = ws.Delete(UidUserLogin,Set_ClassSite_To_ClassWS(VALUE));
            }

        }

        public static ClassEmpresa Set_ClassWS_To_ClassSite(WS_Empresa.ClassEmpresa value)
        {
            ClassEmpresa ret = new ClassEmpresa();

			
			 ret.uid_empresa = value.uid_empresa;
			 ret.ruc = value.ruc;
			 ret.nombre = value.nombre;
			 ret.descripcion = value.descripcion;
			 ret.direccion = value.direccion;
			 ret.telefono = value.telefono;
			 ret.representantelegal = value.representantelegal;
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
        public static WS_Empresa.ClassEmpresa Set_ClassSite_To_ClassWS(ClassEmpresa value)
        {
            WS_Empresa.ClassEmpresa ret = new WS_Empresa.ClassEmpresa();

			
			 ret.uid_empresa = value.uid_empresa;
			 ret.ruc = value.ruc;
			 ret.nombre = value.nombre;
			 ret.descripcion = value.descripcion;
			 ret.direccion = value.direccion;
			 ret.telefono = value.telefono;
			 ret.representantelegal = value.representantelegal;
			           
           
            return ret;
        }

        /// <summary>
        /// Validar campos que deben ser obligados y retorna el nombre de los campos que no soportan nulo
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static List<string> ValidarCamposNulos(ClassEmpresa value)
        {
            List<string> retornoCamposError = new List<string>();
            if (value.uid_empresa == null) { retornoCamposError.Add(nameof(value.uid_empresa)); }
            if (value.ruc == null) { retornoCamposError.Add(nameof(value.ruc)); }
            if (value.nombre == null) { retornoCamposError.Add(nameof(value.nombre)); }
            if (value.descripcion == null) { retornoCamposError.Add(nameof(value.descripcion)); }
            if (value.direccion == null) { retornoCamposError.Add(nameof(value.direccion)); }
            if (value.telefono == null) { retornoCamposError.Add(nameof(value.telefono)); }
            if (value.representantelegal == null) { retornoCamposError.Add(nameof(value.representantelegal)); }
            return retornoCamposError;
        }

    }
}