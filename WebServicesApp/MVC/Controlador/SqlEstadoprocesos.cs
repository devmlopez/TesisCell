using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC.Modelo.ExecProcedure;
using System.Data;

namespace MVC.Controlador
{
    public static class SqlEstadoprocesos
    {
        private static DataTable CRUD(string trx,string UidUserLogin, ClassEstadoprocesos VALUE, out string resultado, string EstadoExistencia = "A")
        {
            resultado = "";
            #region Parametros Entrada y Salida
            var ParamOut = new List<ParametersProcedure>();
            var ParamIn = new List<ParametersProcedure>();
           
			
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uidestado), VALUE.uidestado, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.modulo), VALUE.modulo, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.clave), VALUE.clave, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.valor), VALUE.valor, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.orden), VALUE.orden, Convert.ToInt32(0).GetType().ToString(), OrentationType.In));

            ParamIn.Add(new ParametersProcedure(nameof(trx), trx, trx.GetType().ToString(), OrentationType.In));
		    ParamIn.Add(new ParametersProcedure(nameof(UidUserLogin), UidUserLogin, UidUserLogin.GetType().ToString(), OrentationType.In));          
            ParamIn.Add(new ParametersProcedure(nameof(EstadoExistencia), EstadoExistencia, EstadoExistencia.GetType().ToString(), OrentationType.In));
            ParamIn.Add(new ParametersProcedure(nameof(resultado), resultado, resultado.GetType().ToString(), OrentationType.Out));
            #endregion
            var table = SqlProcedureExec.ExecProcedure("[dbo].[sp_estadoprocesos]", ParamIn, out ParamOut);
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
        public static List<ClassEstadoprocesos> Select(string UidUserLogin,ClassEstadoprocesos VALUE, out string resultado, string EstadoExistencia)
        {
            resultado = "";          
            string trx = "011100";
           var table =  CRUD(trx, UidUserLogin,VALUE, out resultado);
            List<ClassEstadoprocesos> retorno = new List<ClassEstadoprocesos>();
           var retornoAux = (from x in table.AsEnumerable()
                       select new 
                       {
					   
			uidestado = x.Field<string>("uidestado"),
			modulo = x.Field<string>("modulo"),
			clave = x.Field<string>("clave"),
			valor = x.Field<string>("valor"),
			orden = x.Field<int?>("orden"),
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

           ClassEstadoprocesos cl;
            foreach (var x in retornoAux)
            {

                cl = new ClassEstadoprocesos();

				 
			  cl.uidestado = x.uidestado;
			  cl.modulo = x.modulo;
			  cl.clave = x.clave;
			  cl.valor = x.valor;
			  cl.orden = x.orden;
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
        public static void InsertInto(string UidUserLogin,ClassEstadoprocesos VALUE, out string resultado)
        {
            resultado = "";
            string trx = "011101";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
        public static void Update(string UidUserLogin,ClassEstadoprocesos VALUE, out string resultado)
        {
            resultado = "";
            string trx = "011102";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
        public static void Delete(string UidUserLogin,ClassEstadoprocesos VALUE, out string resultado)
        {
            resultado = "";
            string trx = "011103";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
    }
}