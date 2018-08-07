using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC.Modelo.ExecProcedure;
using System.Data;

namespace MVC.Controlador
{
    public static class SqlFacturaventadetalle
    {
        private static DataTable CRUD(string trx,string UidUserLogin, ClassFacturaventadetalle VALUE, out string resultado, string EstadoExistencia = "A")
        {
            resultado = "";
            #region Parametros Entrada y Salida
            var ParamOut = new List<ParametersProcedure>();
            var ParamIn = new List<ParametersProcedure>();
           
			
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uidfactventadetalle), VALUE.uidfactventadetalle, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uidfacturaventa), VALUE.uidfacturaventa, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.secuencial), VALUE.secuencial, Convert.ToInt32(0).GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.item), VALUE.item, Convert.ToInt32(0).GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uidproducto), VALUE.uidproducto, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.cantidad), VALUE.cantidad, Convert.ToInt32(0).GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.preciounitario), VALUE.preciounitario, Convert.ToDecimal(0).GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.total), VALUE.total, Convert.ToDecimal(0).GetType().ToString(), OrentationType.In));

            ParamIn.Add(new ParametersProcedure(nameof(trx), trx, trx.GetType().ToString(), OrentationType.In));
		    ParamIn.Add(new ParametersProcedure(nameof(UidUserLogin), UidUserLogin, UidUserLogin.GetType().ToString(), OrentationType.In));          
            ParamIn.Add(new ParametersProcedure(nameof(EstadoExistencia), EstadoExistencia, EstadoExistencia.GetType().ToString(), OrentationType.In));
            ParamIn.Add(new ParametersProcedure(nameof(resultado), resultado, resultado.GetType().ToString(), OrentationType.Out));
            #endregion
            var table = SqlProcedureExec.ExecProcedure("[dbo].[sp_facturaventadetalle]", ParamIn, out ParamOut);
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
        public static List<ClassFacturaventadetalle> Select(string UidUserLogin,ClassFacturaventadetalle VALUE, out string resultado, string EstadoExistencia)
        {
            resultado = "";          
            string trx = "01530";
           var table =  CRUD(trx, UidUserLogin,VALUE, out resultado);
            List<ClassFacturaventadetalle> retorno = new List<ClassFacturaventadetalle>();
           var retornoAux = (from x in table.AsEnumerable()
                       select new 
                       {
					   
			uidfactventadetalle = x.Field<string>("uidfactventadetalle"),
			uidfacturaventa = x.Field<string>("uidfacturaventa"),
			secuencial = x.Field<int?>("secuencial"),
			item = x.Field<int?>("item"),
			uidproducto = x.Field<string>("uidproducto"),
			cantidad = x.Field<int?>("cantidad"),
			preciounitario = x.Field<decimal?>("preciounitario"),
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

           ClassFacturaventadetalle cl;
            foreach (var x in retornoAux)
            {

                cl = new ClassFacturaventadetalle();

				 
			  cl.uidfactventadetalle = x.uidfactventadetalle;
			  cl.uidfacturaventa = x.uidfacturaventa;
			  cl.secuencial = x.secuencial;
			  cl.item = x.item;
			  cl.uidproducto = x.uidproducto;
			  cl.cantidad = x.cantidad;
			  cl.preciounitario = x.preciounitario;
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
        public static void InsertInto(string UidUserLogin,ClassFacturaventadetalle VALUE, out string resultado)
        {
            resultado = "";
            string trx = "01531";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
        public static void Update(string UidUserLogin,ClassFacturaventadetalle VALUE, out string resultado)
        {
            resultado = "";
            string trx = "01532";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
        public static void Delete(string UidUserLogin,ClassFacturaventadetalle VALUE, out string resultado)
        {
            resultado = "";
            string trx = "01533";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
    }
}