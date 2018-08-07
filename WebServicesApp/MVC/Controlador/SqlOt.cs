using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC.Modelo.ExecProcedure;
using System.Data;

namespace MVC.Controlador
{
    public static class SqlOt
    {
        private static DataTable CRUD(string trx,string UidUserLogin, ClassOt VALUE, out string resultado, string EstadoExistencia = "A")
        {
            resultado = "";
            #region Parametros Entrada y Salida
            var ParamOut = new List<ParametersProcedure>();
            var ParamIn = new List<ParametersProcedure>();
           
			
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uidot), VALUE.uidot, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uidvendedor), VALUE.uidvendedor, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.cod_ot), VALUE.cod_ot, Convert.ToInt32(0).GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uidcliente), VALUE.uidcliente, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.fechaapertura), VALUE.fechaapertura, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.fechacierre), VALUE.fechacierre, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uidestado), VALUE.uidestado, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.subtotal), VALUE.subtotal, Convert.ToDecimal(0).GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.descuentos), VALUE.descuentos, Convert.ToDecimal(0).GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.impuestos), VALUE.impuestos, Convert.ToDecimal(0).GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.iva), VALUE.iva, Convert.ToDecimal(0).GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.total), VALUE.total, Convert.ToDecimal(0).GetType().ToString(), OrentationType.In));

            ParamIn.Add(new ParametersProcedure(nameof(trx), trx, trx.GetType().ToString(), OrentationType.In));
		    ParamIn.Add(new ParametersProcedure(nameof(UidUserLogin), UidUserLogin, UidUserLogin.GetType().ToString(), OrentationType.In));          
            ParamIn.Add(new ParametersProcedure(nameof(EstadoExistencia), EstadoExistencia, EstadoExistencia.GetType().ToString(), OrentationType.In));
            ParamIn.Add(new ParametersProcedure(nameof(resultado), resultado, resultado.GetType().ToString(), OrentationType.Out));
            #endregion
            var table = SqlProcedureExec.ExecProcedure("[dbo].[sp_ot]", ParamIn, out ParamOut);
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
        public static List<ClassOt> Select(string UidUserLogin,ClassOt VALUE, out string resultado, string EstadoExistencia)
        {
            resultado = "";          
            string trx = "01570";
           var table =  CRUD(trx, UidUserLogin,VALUE, out resultado);
            List<ClassOt> retorno = new List<ClassOt>();
           var retornoAux = (from x in table.AsEnumerable()
                       select new 
                       {
					   
			uidot = x.Field<string>("uidot"),
			uidvendedor = x.Field<string>("uidvendedor"),
			cod_ot = x.Field<int?>("cod_ot"),
			uidcliente = x.Field<string>("uidcliente"),
			fechaapertura = x.Field<DateTime?>("fechaapertura"),
			fechacierre = x.Field<DateTime?>("fechacierre"),
			uidestado = x.Field<string>("uidestado"),
			subtotal = x.Field<decimal?>("subtotal"),
			descuentos = x.Field<decimal?>("descuentos"),
			impuestos = x.Field<decimal?>("impuestos"),
			iva = x.Field<decimal?>("iva"),
			total = x.Field<decimal?>("total"),
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

           ClassOt cl;
            foreach (var x in retornoAux)
            {

                cl = new ClassOt();

				 
			  cl.uidot = x.uidot;
			  cl.uidvendedor = x.uidvendedor;
			  cl.cod_ot = x.cod_ot;
			  cl.uidcliente = x.uidcliente;
			  cl.fechaapertura = x.fechaapertura;
			  cl.fechacierre = x.fechacierre;
			  cl.uidestado = x.uidestado;
			  cl.subtotal = x.subtotal;
			  cl.descuentos = x.descuentos;
			  cl.impuestos = x.impuestos;
			  cl.iva = x.iva;
			  cl.total = x.total;
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
        public static void InsertInto(string UidUserLogin,ClassOt VALUE, out string resultado)
        {
            resultado = "";
            string trx = "01571";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
        public static void Update(string UidUserLogin,ClassOt VALUE, out string resultado)
        {
            resultado = "";
            string trx = "01572";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
        public static void Delete(string UidUserLogin,ClassOt VALUE, out string resultado)
        {
            resultado = "";
            string trx = "01573";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
    }
}