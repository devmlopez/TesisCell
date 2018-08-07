using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC.Modelo.ExecProcedure;
using System.Data;

namespace MVC.Controlador
{
    public static class SqlProveedor
    {
        private static DataTable CRUD(string trx,string UidUserLogin, ClassProveedor VALUE, out string resultado, string EstadoExistencia = "A")
        {
            resultado = "";
            #region Parametros Entrada y Salida
            var ParamOut = new List<ParametersProcedure>();
            var ParamIn = new List<ParametersProcedure>();
           
			
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uidproveedor), VALUE.uidproveedor, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.id_proveedor), VALUE.id_proveedor, Convert.ToInt32(0).GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uidtipopersona), VALUE.uidtipopersona, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.identificacion), VALUE.identificacion, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uidtipoidentificacion), VALUE.uidtipoidentificacion, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.razonsocial), VALUE.razonsocial, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.nombre), VALUE.nombre, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.contacto), VALUE.contacto, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.celular), VALUE.celular, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.telefono), VALUE.telefono, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.direccion), VALUE.direccion, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.provincia), VALUE.provincia, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.ciudad), VALUE.ciudad, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.email), VALUE.email, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.referencia), VALUE.referencia, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.observaciones), VALUE.observaciones, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.pagina_web), VALUE.pagina_web, "".GetType().ToString(), OrentationType.In));

            ParamIn.Add(new ParametersProcedure(nameof(trx), trx, trx.GetType().ToString(), OrentationType.In));
		    ParamIn.Add(new ParametersProcedure(nameof(UidUserLogin), UidUserLogin, UidUserLogin.GetType().ToString(), OrentationType.In));          
            ParamIn.Add(new ParametersProcedure(nameof(EstadoExistencia), EstadoExistencia, EstadoExistencia.GetType().ToString(), OrentationType.In));
            ParamIn.Add(new ParametersProcedure(nameof(resultado), resultado, resultado.GetType().ToString(), OrentationType.Out));
            #endregion
            var table = SqlProcedureExec.ExecProcedure("[dbo].[sp_proveedor]", ParamIn, out ParamOut);
            var param_resultado = ParamOut.Where(x => x.Parameter == "resultado").FirstOrDefault();
            if (param_resultado != null)
            {
                if (param_resultado.TypeDate.Equals("".GetType().ToString()))
                {
                    resultado = Convert.ToString(param_resultado.Value);
                }
            }
            else
            {
                resultado = "";
            }
            return table;
        }
        public static List<ClassProveedor> Select(string UidUserLogin,ClassProveedor VALUE, out string resultado, string EstadoExistencia)
        {
            resultado = "";          
            string trx = "011036";
           var table =  CRUD(trx, UidUserLogin,VALUE, out resultado);
            List<ClassProveedor> retorno = new List<ClassProveedor>();
           var retornoAux = (from x in table.AsEnumerable()
                       select new 
                       {
					   
			uidproveedor = x.Field<string>("uidproveedor"),
			id_proveedor = x.Field<int?>("id_proveedor"),
			uidtipopersona = x.Field<string>("uidtipopersona"),
			identificacion = x.Field<string>("identificacion"),
			uidtipoidentificacion = x.Field<string>("uidtipoidentificacion"),
			razonsocial = x.Field<string>("razonsocial"),
			nombre = x.Field<string>("nombre"),
			contacto = x.Field<string>("contacto"),
			celular = x.Field<string>("celular"),
			telefono = x.Field<string>("telefono"),
			direccion = x.Field<string>("direccion"),
			provincia = x.Field<string>("provincia"),
			ciudad = x.Field<string>("ciudad"),
			email = x.Field<string>("email"),
			referencia = x.Field<string>("referencia"),
			observaciones = x.Field<string>("observaciones"),
			pagina_web = x.Field<string>("pagina_web"),
					       aux1 = x.Field<string>("aux1"),
                           aux2 = x.Field<string>("aux2"),
                           aux3 = x.Field<string>("aux3"),
                           aux4 = x.Field<string>("aux4"),
                           aux5 = x.Field<string>("aux5"),
                           aux6 = x.Field<string>("aux6"),
                           aux7 = x.Field<string>("aux7"), 
                           aux8 = x.Field<string>("aux8"),
                           aux9 = x.Field<string>("aux9"),
                           aux10 = x.Field<string>("aux10"),                        
                       }).ToList();

           ClassProveedor cl;
            foreach (var x in retornoAux)
            {

                cl = new ClassProveedor();

				 
			  cl.uidproveedor = x.uidproveedor;
			  cl.id_proveedor = x.id_proveedor;
			  cl.uidtipopersona = x.uidtipopersona;
			  cl.identificacion = x.identificacion;
			  cl.uidtipoidentificacion = x.uidtipoidentificacion;
			  cl.razonsocial = x.razonsocial;
			  cl.nombre = x.nombre;
			  cl.contacto = x.contacto;
			  cl.celular = x.celular;
			  cl.telefono = x.telefono;
			  cl.direccion = x.direccion;
			  cl.provincia = x.provincia;
			  cl.ciudad = x.ciudad;
			  cl.email = x.email;
			  cl.referencia = x.referencia;
			  cl.observaciones = x.observaciones;
			  cl.pagina_web = x.pagina_web;
				cl.aux1 = x.aux1;
                cl.aux2 = x.aux2;
                cl.aux3 = x.aux3;
                cl.aux4 = x.aux4;
                cl.aux5 = x.aux5;
                cl.aux6 = x.aux6;
                cl.aux7 = x.aux7;
                cl.aux8 = x.aux8;
                cl.aux9 = x.aux9;
                cl.aux10 = x.aux10;             
                retorno.Add(cl);
            }
            
            return retorno;
        }
        public static void InsertInto(string UidUserLogin,ClassProveedor VALUE, out string resultado)
        {
            resultado = "";
            string trx = "011037";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
        public static void Update(string UidUserLogin,ClassProveedor VALUE, out string resultado)
        {
            resultado = "";
            string trx = "011038";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
        public static void Delete(string UidUserLogin,ClassProveedor VALUE, out string resultado)
        {
            resultado = "";
            string trx = "011039";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
    }
}