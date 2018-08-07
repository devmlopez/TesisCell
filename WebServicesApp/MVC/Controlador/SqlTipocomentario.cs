using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC.Modelo.ExecProcedure;
using System.Data;

namespace MVC.Controlador
{
    public static class SqlTipocomentario
    {
        private static DataTable CRUD(string trx,string UidUserLogin, ClassTipocomentario VALUE, out string resultado, string EstadoExistencia = "A")
        {
            resultado = "";
            #region Parametros Entrada y Salida
            var ParamOut = new List<ParametersProcedure>();
            var ParamIn = new List<ParametersProcedure>();
           
			
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uidtipocomentario), VALUE.uidtipocomentario, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.tipocomentario), VALUE.tipocomentario, "".GetType().ToString(), OrentationType.In));

            ParamIn.Add(new ParametersProcedure(nameof(trx), trx, trx.GetType().ToString(), OrentationType.In));
		    ParamIn.Add(new ParametersProcedure(nameof(UidUserLogin), UidUserLogin, UidUserLogin.GetType().ToString(), OrentationType.In));          
            ParamIn.Add(new ParametersProcedure(nameof(EstadoExistencia), EstadoExistencia, EstadoExistencia.GetType().ToString(), OrentationType.In));
            ParamIn.Add(new ParametersProcedure(nameof(resultado), resultado, resultado.GetType().ToString(), OrentationType.Out));
            #endregion
            var table = SqlProcedureExec.ExecProcedure("[dbo].[sp_tipocomentario]", ParamIn, out ParamOut);
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
        public static List<ClassTipocomentario> Select(string UidUserLogin,ClassTipocomentario VALUE, out string resultado, string EstadoExistencia)
        {
            resultado = "";          
            string trx = "012000";
           var table =  CRUD(trx, UidUserLogin,VALUE, out resultado);
            List<ClassTipocomentario> retorno = new List<ClassTipocomentario>();
			if(table.Rows.Count>0){
				   var retornoAux = (from x in table.AsEnumerable()
							   select new 
							   {
							   
			uidtipocomentario = x.Field<string>("uidtipocomentario"),
			tipocomentario = x.Field<string>("tipocomentario"),                 
							   }).ToList();
				   ClassTipocomentario cl;
					foreach (var x in retornoAux)
					{
						cl = new ClassTipocomentario();
						
			  cl.uidtipocomentario = x.uidtipocomentario;
			  cl.tipocomentario = x.tipocomentario;
						retorno.Add(cl);
					}            
			}
            return retorno;
        }

        public static DataTable SelectDataTable(string UidUserLogin, ClassTipocomentario VALUE, out string resultado, string EstadoExistencia)
        {
            resultado = "";
            string trx = "012000";
            var table = CRUD(trx, UidUserLogin, VALUE, out resultado);
            return table;
        }

        public static void InsertInto(string UidUserLogin,ClassTipocomentario VALUE, out string resultado)
        {
            resultado = "";
            string trx = "012001";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
        public static void Update(string UidUserLogin,ClassTipocomentario VALUE, out string resultado)
        {
            resultado = "";
            string trx = "012002";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
        public static void Delete(string UidUserLogin,ClassTipocomentario VALUE, out string resultado)
        {
            resultado = "";
            string trx = "012003";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
		public static DataTable SelectDynamic(string UidUserLogin,ClassTipocomentario VALUE, out string resultado, string EstadoExistencia)
        {
           resultado = "";          
           string trx = "#trxMas5";
		   DataTable table= new DataTable("ClassTipocomentario");
		   table=CRUD(trx, UidUserLogin,VALUE, out resultado);
           return table;
        }
    }
}