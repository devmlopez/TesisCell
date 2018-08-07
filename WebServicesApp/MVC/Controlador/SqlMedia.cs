using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC.Modelo.ExecProcedure;
using System.Data;

namespace MVC.Controlador
{
    public static class SqlMedia
    {
        private static DataTable CRUD(string trx,string UidUserLogin, ClassMedia VALUE, out string resultado, string EstadoExistencia = "A")
        {
            resultado = "";
            #region Parametros Entrada y Salida
            var ParamOut = new List<ParametersProcedure>();
            var ParamIn = new List<ParametersProcedure>();
           
			
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uidmedia), VALUE.uidmedia, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.codmedia), VALUE.codmedia, Convert.ToInt32(0).GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uidproceso), VALUE.uidproceso, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uidtipocomentario), VALUE.uidtipocomentario, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.cometario), VALUE.cometario, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.imagen), VALUE.imagen, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.url), VALUE.url, "".GetType().ToString(), OrentationType.In));

            ParamIn.Add(new ParametersProcedure(nameof(trx), trx, trx.GetType().ToString(), OrentationType.In));
		    ParamIn.Add(new ParametersProcedure(nameof(UidUserLogin), UidUserLogin, UidUserLogin.GetType().ToString(), OrentationType.In));          
            ParamIn.Add(new ParametersProcedure(nameof(EstadoExistencia), EstadoExistencia, EstadoExistencia.GetType().ToString(), OrentationType.In));
            ParamIn.Add(new ParametersProcedure(nameof(resultado), resultado, resultado.GetType().ToString(), OrentationType.Out));
            #endregion
            var table = SqlProcedureExec.ExecProcedure("[dbo].[sp_media]", ParamIn, out ParamOut);
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
        public static List<ClassMedia> Select(string UidUserLogin,ClassMedia VALUE, out string resultado, string EstadoExistencia)
        {
            resultado = "";          
            string trx = "012100";
           var table =  CRUD(trx, UidUserLogin,VALUE, out resultado);
            List<ClassMedia> retorno = new List<ClassMedia>();
			if(table.Rows.Count>0){
				   var retornoAux = (from x in table.AsEnumerable()
							   select new 
							   {
							   
			uidmedia = x.Field<string>("uidmedia"),
			codmedia = x.Field<int?>("codmedia"),
			uidproceso = x.Field<string>("uidproceso"),
			uidtipocomentario = x.Field<string>("uidtipocomentario"),
			cometario = x.Field<string>("cometario"),
			imagen = x.Field<string>("imagen"),
			url = x.Field<string>("url"),                 
							   }).ToList();
				   ClassMedia cl;
					foreach (var x in retornoAux)
					{
						cl = new ClassMedia();
						
			  cl.uidmedia = x.uidmedia;
			  cl.codmedia = x.codmedia;
			  cl.uidproceso = x.uidproceso;
			  cl.uidtipocomentario = x.uidtipocomentario;
			  cl.cometario = x.cometario;
			  cl.imagen = x.imagen;
			  cl.url = x.url;
						retorno.Add(cl);
					}            
			}
            return retorno;
        }


        
        public static DataTable SelectDataTable(string UidUserLogin, ClassMedia VALUE, out string resultado, string EstadoExistencia)
        {
            resultado = "";
            string trx = "012100";
            var table = CRUD(trx, UidUserLogin, VALUE, out resultado);
            return table;
        }
        public static void InsertInto(string UidUserLogin,ClassMedia VALUE, out string resultado)
        {
            resultado = "";
            string trx = "012101";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
        public static void Update(string UidUserLogin,ClassMedia VALUE, out string resultado)
        {
            resultado = "";
            string trx = "012102";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
        public static void Delete(string UidUserLogin,ClassMedia VALUE, out string resultado)
        {
            resultado = "";
            string trx = "012103";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
		public static DataTable SelectDynamic(string UidUserLogin,ClassMedia VALUE, out string resultado, string EstadoExistencia)
        {
           resultado = "";          
           string trx = "#trxMas5";
		   DataTable table= new DataTable("ClassMedia");
		   table=CRUD(trx, UidUserLogin,VALUE, out resultado);
           return table;
        }
    }
}