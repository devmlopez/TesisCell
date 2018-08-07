using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC.Modelo.ExecProcedure;
using System.Data;

namespace MVC.Controlador
{
    public static class SqlFacturaventa
    {
        private static DataTable CRUD(string trx,string UidUserLogin, ClassFacturaventa VALUE, out string resultado, string EstadoExistencia = "A")
        {
            resultado = "";
            #region Parametros Entrada y Salida
            var ParamOut = new List<ParametersProcedure>();
            var ParamIn = new List<ParametersProcedure>();
           
			
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uidfacturaventa), VALUE.uidfacturaventa, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.establecimiento), VALUE.establecimiento, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.puntoemision), VALUE.puntoemision, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.secuencial), VALUE.secuencial, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uidusuario), VALUE.uidusuario, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uidcliente), VALUE.uidcliente, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.fechafactura), VALUE.fechafactura, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.subtotal), VALUE.subtotal, Convert.ToDecimal(0).GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.iva_porc), VALUE.iva_porc, Convert.ToDecimal(0).GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.iva_valor), VALUE.iva_valor, Convert.ToDecimal(0).GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.descuentos), VALUE.descuentos, Convert.ToDecimal(0).GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.total), VALUE.total, Convert.ToDecimal(0).GetType().ToString(), OrentationType.In));

            ParamIn.Add(new ParametersProcedure(nameof(trx), trx, trx.GetType().ToString(), OrentationType.In));
		    ParamIn.Add(new ParametersProcedure(nameof(UidUserLogin), UidUserLogin, UidUserLogin.GetType().ToString(), OrentationType.In));          
            ParamIn.Add(new ParametersProcedure(nameof(EstadoExistencia), EstadoExistencia, EstadoExistencia.GetType().ToString(), OrentationType.In));
            ParamIn.Add(new ParametersProcedure(nameof(resultado), resultado, resultado.GetType().ToString(), OrentationType.Out));
            #endregion
            var table = SqlProcedureExec.ExecProcedure("[dbo].[sp_facturaventa]", ParamIn, out ParamOut);
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
        public static List<ClassFacturaventa> Select(string UidUserLogin,ClassFacturaventa VALUE, out string resultado, string EstadoExistencia)
        {
            resultado = "";          
            string trx = "01520";
           var table =  CRUD(trx, UidUserLogin,VALUE, out resultado);
            List<ClassFacturaventa> retorno = new List<ClassFacturaventa>();
           var retornoAux = (from x in table.AsEnumerable()
                       select new 
                       {
					   
			uidfacturaventa = x.Field<string>("uidfacturaventa"),
			establecimiento = x.Field<string>("establecimiento"),
			puntoemision = x.Field<string>("puntoemision"),
			secuencial = x.Field<string>("secuencial"),
			uidusuario = x.Field<string>("uidusuario"),
			uidcliente = x.Field<string>("uidcliente"),
			fechafactura = x.Field<DateTime?>("fechafactura"),
			subtotal = x.Field<decimal?>("subtotal"),
			iva_porc = x.Field<decimal?>("iva_porc"),
			iva_valor = x.Field<decimal?>("iva_valor"),
			descuentos = x.Field<decimal?>("descuentos"),
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

           ClassFacturaventa cl;
            foreach (var x in retornoAux)
            {

                cl = new ClassFacturaventa();

				 
			  cl.uidfacturaventa = x.uidfacturaventa;
			  cl.establecimiento = x.establecimiento;
			  cl.puntoemision = x.puntoemision;
			  cl.secuencial = x.secuencial;
			  cl.uidusuario = x.uidusuario;
			  cl.uidcliente = x.uidcliente;
			  cl.fechafactura = x.fechafactura;
			  cl.subtotal = x.subtotal;
			  cl.iva_porc = x.iva_porc;
			  cl.iva_valor = x.iva_valor;
			  cl.descuentos = x.descuentos;
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
        public static void InsertInto(string UidUserLogin,ClassFacturaventa VALUE, out string resultado)
        {
            resultado = "";
            string trx = "01521";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
        public static void Update(string UidUserLogin,ClassFacturaventa VALUE, out string resultado)
        {
            resultado = "";
            string trx = "01522";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
        public static void Delete(string UidUserLogin,ClassFacturaventa VALUE, out string resultado)
        {
            resultado = "";
            string trx = "01523";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
    }
}