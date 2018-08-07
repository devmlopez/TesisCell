using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC.Modelo.ExecProcedure;
using System.Data;

namespace MVC.Controlador
{
    public static class SqlProceso
    {
        private static DataTable CRUD(string trx,string UidUserLogin, ClassProceso VALUE, out string resultado, string EstadoExistencia = "A")
        {
            resultado = "";
            #region Parametros Entrada y Salida
            var ParamOut = new List<ParametersProcedure>();
            var ParamIn = new List<ParametersProcedure>();
           
			
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uidproceso), VALUE.uidproceso, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.codproceso), VALUE.codproceso, Convert.ToInt32(0).GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uidserviciotecnico), VALUE.uidserviciotecnico, "".GetType().ToString(), OrentationType.In));

            ParamIn.Add(new ParametersProcedure(nameof(trx), trx, trx.GetType().ToString(), OrentationType.In));
		    ParamIn.Add(new ParametersProcedure(nameof(UidUserLogin), UidUserLogin, UidUserLogin.GetType().ToString(), OrentationType.In));          
            ParamIn.Add(new ParametersProcedure(nameof(EstadoExistencia), EstadoExistencia, EstadoExistencia.GetType().ToString(), OrentationType.In));
            ParamIn.Add(new ParametersProcedure(nameof(resultado), resultado, resultado.GetType().ToString(), OrentationType.Out));
            #endregion
            var table = SqlProcedureExec.ExecProcedure("[dbo].[sp_proceso]", ParamIn, out ParamOut);
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
        public static List<ClassProceso> Select(string UidUserLogin,ClassProceso VALUE, out string resultado, string EstadoExistencia)
        {
            resultado = "";          
            string trx = "012200";
           var table =  CRUD(trx, UidUserLogin,VALUE, out resultado);
            List<ClassProceso> retorno = new List<ClassProceso>();
			if(table.Rows.Count>0){
				   var retornoAux = (from x in table.AsEnumerable()
							   select new 
							   {
							   
			uidproceso = x.Field<string>("uidproceso"),
			codproceso = x.Field<int?>("codproceso"),
			uidserviciotecnico = x.Field<string>("uidserviciotecnico"),                 
							   }).ToList();
				   ClassProceso cl;
					foreach (var x in retornoAux)
					{
						cl = new ClassProceso();
						
			  cl.uidproceso = x.uidproceso;
			  cl.codproceso = x.codproceso;
			  cl.uidserviciotecnico = x.uidserviciotecnico;
						retorno.Add(cl);
					}            
			}
            return retorno;
        }

        public static DataTable SelectDataTable(string UidUserLogin, ClassProceso VALUE, out string resultado, string EstadoExistencia)
        {
            resultado = "";
            string trx = "012200";
            var table = CRUD(trx, UidUserLogin, VALUE, out resultado);
            return table;
        }

        public static void InsertInto(string UidUserLogin,ClassProceso VALUE, out string resultado)
        {
            resultado = "";
            string trx = "012201";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
        public static void Update(string UidUserLogin,ClassProceso VALUE, out string resultado)
        {
            resultado = "";
            string trx = "012202";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
        public static void Delete(string UidUserLogin,ClassProceso VALUE, out string resultado)
        {
            resultado = "";
            string trx = "012203";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
		public static DataTable SelectDynamic(string UidUserLogin,ClassProceso VALUE, out string resultado, string EstadoExistencia)
        {
           resultado = "";          
           string trx = "#trxMas5";
		   DataTable table= new DataTable("ClassProceso");
		   table=CRUD(trx, UidUserLogin,VALUE, out resultado);
           return table;
        }
    }
}