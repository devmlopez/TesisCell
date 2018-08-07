using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC.Modelo.ExecProcedure;
using System.Data;

namespace MVC.Controlador
{
    public static class SqlProcesotipocomentario
    {
        private static DataTable CRUD(string trx,string UidUserLogin, ClassProcesotipocomentario VALUE, out string resultado, string EstadoExistencia = "A")
        {
            resultado = "";
            #region Parametros Entrada y Salida
            var ParamOut = new List<ParametersProcedure>();
            var ParamIn = new List<ParametersProcedure>();
           
			
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uidprocesotipocomentario), VALUE.uidprocesotipocomentario, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uidproceso), VALUE.uidproceso, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uidtipocomentario), VALUE.uidtipocomentario, "".GetType().ToString(), OrentationType.In));

            ParamIn.Add(new ParametersProcedure(nameof(trx), trx, trx.GetType().ToString(), OrentationType.In));
		    ParamIn.Add(new ParametersProcedure(nameof(UidUserLogin), UidUserLogin, UidUserLogin.GetType().ToString(), OrentationType.In));          
            ParamIn.Add(new ParametersProcedure(nameof(EstadoExistencia), EstadoExistencia, EstadoExistencia.GetType().ToString(), OrentationType.In));
            ParamIn.Add(new ParametersProcedure(nameof(resultado), resultado, resultado.GetType().ToString(), OrentationType.Out));
            #endregion
            var table = SqlProcedureExec.ExecProcedure("[dbo].[sp_procesotipocomentario]", ParamIn, out ParamOut);
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
        public static List<ClassProcesotipocomentario> Select(string UidUserLogin,ClassProcesotipocomentario VALUE, out string resultado, string EstadoExistencia)
        {
            resultado = "";          
            string trx = "0117000";
           var table =  CRUD(trx, UidUserLogin,VALUE, out resultado);
            List<ClassProcesotipocomentario> retorno = new List<ClassProcesotipocomentario>();
			if(table.Rows.Count>0){
				   var retornoAux = (from x in table.AsEnumerable()
							   select new 
							   {
							   
			uidprocesotipocomentario = x.Field<string>("uidprocesotipocomentario"),
			uidproceso = x.Field<string>("uidproceso"),
			uidtipocomentario = x.Field<string>("uidtipocomentario"),                 
							   }).ToList();
				   ClassProcesotipocomentario cl;
					foreach (var x in retornoAux)
					{
						cl = new ClassProcesotipocomentario();
						
			  cl.uidprocesotipocomentario = x.uidprocesotipocomentario;
			  cl.uidproceso = x.uidproceso;
			  cl.uidtipocomentario = x.uidtipocomentario;
						retorno.Add(cl);
					}            
			}
            return retorno;
        }		
        public static void InsertInto(string UidUserLogin,ClassProcesotipocomentario VALUE, out string resultado)
        {
            resultado = "";
            string trx = "0117001";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
        public static void Update(string UidUserLogin,ClassProcesotipocomentario VALUE, out string resultado)
        {
            resultado = "";
            string trx = "0117002";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
        public static void Delete(string UidUserLogin,ClassProcesotipocomentario VALUE, out string resultado)
        {
            resultado = "";
            string trx = "0117003";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
		public static DataTable SelectDataTable(string UidUserLogin,ClassProcesotipocomentario VALUE, out string resultado, string EstadoExistencia)
        {
           resultado = "";          
           string trx = "0117004";
		   DataTable table= new DataTable("ClassProcesotipocomentario");
		   table=CRUD(trx, UidUserLogin,VALUE, out resultado);
           return table;
        }
    }
}