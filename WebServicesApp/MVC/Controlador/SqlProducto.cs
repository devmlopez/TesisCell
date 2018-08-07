using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC.Modelo.ExecProcedure;
using System.Data;

namespace MVC.Controlador
{
    public static class SqlProducto
    {
        private static DataTable CRUD(string trx,string UidUserLogin, ClassProducto VALUE, out string resultado, string EstadoExistencia = "A")
        {
            resultado = "";
            #region Parametros Entrada y Salida
            var ParamOut = new List<ParametersProcedure>();
            var ParamIn = new List<ParametersProcedure>();
           
			
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uidproducto), VALUE.uidproducto, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uidcategoriaproducto), VALUE.uidcategoriaproducto, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.codproducto), VALUE.codproducto, Convert.ToInt32(0).GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.nombre), VALUE.nombre, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.dimensiones), VALUE.dimensiones, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.cantidad), VALUE.cantidad, Convert.ToInt32(0).GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.precio1), VALUE.precio1, Convert.ToDecimal(0).GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.precio2), VALUE.precio2, Convert.ToDecimal(0).GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.precio3), VALUE.precio3, Convert.ToDecimal(0).GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.precio4), VALUE.precio4, Convert.ToDecimal(0).GetType().ToString(), OrentationType.In));

            ParamIn.Add(new ParametersProcedure(nameof(trx), trx, trx.GetType().ToString(), OrentationType.In));
		    ParamIn.Add(new ParametersProcedure(nameof(UidUserLogin), UidUserLogin, UidUserLogin.GetType().ToString(), OrentationType.In));          
            ParamIn.Add(new ParametersProcedure(nameof(EstadoExistencia), EstadoExistencia, EstadoExistencia.GetType().ToString(), OrentationType.In));
            ParamIn.Add(new ParametersProcedure(nameof(resultado), resultado, resultado.GetType().ToString(), OrentationType.Out));
            #endregion
            var table = SqlProcedureExec.ExecProcedure("[dbo].[sp_producto]", ParamIn, out ParamOut);
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
        public static List<ClassProducto> Select(string UidUserLogin,ClassProducto VALUE, out string resultado, string EstadoExistencia)
        {
            resultado = "";          
            string trx = "011060";
           var table =  CRUD(trx, UidUserLogin,VALUE, out resultado);
            List<ClassProducto> retorno = new List<ClassProducto>();
           var retornoAux = (from x in table.AsEnumerable()
                       select new 
                       {
					   
			uidproducto = x.Field<string>("uidproducto"),
			uidcategoriaproducto = x.Field<string>("uidcategoriaproducto"),
			codproducto = x.Field<int?>("codproducto"),
			nombre = x.Field<string>("nombre"),
			dimensiones = x.Field<string>("dimensiones"),
			cantidad = x.Field<int?>("cantidad"),
			precio1 = x.Field<decimal?>("precio1"),
			precio2 = x.Field<decimal?>("precio2"),
			precio3 = x.Field<decimal?>("precio3"),
			precio4 = x.Field<decimal?>("precio4"),
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

           ClassProducto cl;
            foreach (var x in retornoAux)
            {

                cl = new ClassProducto();

				 
			  cl.uidproducto = x.uidproducto;
			  cl.uidcategoriaproducto = x.uidcategoriaproducto;
			  cl.codproducto = x.codproducto;
			  cl.nombre = x.nombre;
			  cl.dimensiones = x.dimensiones;
			  cl.cantidad = x.cantidad;
			  cl.precio1 = x.precio1;
			  cl.precio2 = x.precio2;
			  cl.precio3 = x.precio3;
			  cl.precio4 = x.precio4;
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
        public static void InsertInto(string UidUserLogin,ClassProducto VALUE, out string resultado)
        {
            resultado = "";
            string trx = "011061";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
        public static void Update(string UidUserLogin,ClassProducto VALUE, out string resultado)
        {
            resultado = "";
            string trx = "011062";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
        public static void Delete(string UidUserLogin,ClassProducto VALUE, out string resultado)
        {
            resultado = "";
            string trx = "011063";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
    }
}