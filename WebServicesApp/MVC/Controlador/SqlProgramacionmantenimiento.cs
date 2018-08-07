using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC.Modelo.ExecProcedure;
using System.Data;

namespace MVC.Controlador
{
    public static class SqlProgramacionmantenimiento
    {
        private static DataTable CRUD(string trx,string UidUserLogin, ClassProgramacionmantenimiento VALUE, out string resultado, string EstadoExistencia = "A")
        {
            resultado = "";
            #region Parametros Entrada y Salida
            var ParamOut = new List<ParametersProcedure>();
            var ParamIn = new List<ParametersProcedure>();
           
			
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uidprogramacion), VALUE.uidprogramacion, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uidcliente), VALUE.uidcliente, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.fecha), VALUE.fecha, "".GetType().ToString(), OrentationType.In));

            ParamIn.Add(new ParametersProcedure(nameof(trx), trx, trx.GetType().ToString(), OrentationType.In));
		    ParamIn.Add(new ParametersProcedure(nameof(UidUserLogin), UidUserLogin, UidUserLogin.GetType().ToString(), OrentationType.In));          
            ParamIn.Add(new ParametersProcedure(nameof(EstadoExistencia), EstadoExistencia, EstadoExistencia.GetType().ToString(), OrentationType.In));
            ParamIn.Add(new ParametersProcedure(nameof(resultado), resultado, resultado.GetType().ToString(), OrentationType.Out));
            #endregion
            var table = SqlProcedureExec.ExecProcedure("[dbo].[sp_programacionmantenimiento]", ParamIn, out ParamOut);
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
        public static List<ClassProgramacionmantenimiento> Select(string UidUserLogin,ClassProgramacionmantenimiento VALUE, out string resultado, string EstadoExistencia)
        {
            resultado = "";          
            string trx = "011124";
           var table =  CRUD(trx, UidUserLogin,VALUE, out resultado);
            List<ClassProgramacionmantenimiento> retorno = new List<ClassProgramacionmantenimiento>();
           var retornoAux = (from x in table.AsEnumerable()
                       select new 
                       {
					   
			uidprogramacion = x.Field<string>("uidprogramacion"),
			uidcliente = x.Field<string>("uidcliente"),
			fecha = x.Field<DateTime?>("fecha"),
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

           ClassProgramacionmantenimiento cl;
            foreach (var x in retornoAux)
            {

                cl = new ClassProgramacionmantenimiento();

				 
			  cl.uidprogramacion = x.uidprogramacion;
			  cl.uidcliente = x.uidcliente;
			  cl.fecha = x.fecha;
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
        public static void InsertInto(string UidUserLogin,ClassProgramacionmantenimiento VALUE, out string resultado)
        {
            resultado = "";
            string trx = "011125";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
        public static void Update(string UidUserLogin,ClassProgramacionmantenimiento VALUE, out string resultado)
        {
            resultado = "";
            string trx = "011126";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
        public static void Delete(string UidUserLogin,ClassProgramacionmantenimiento VALUE, out string resultado)
        {
            resultado = "";
            string trx = "011127";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
    }
}