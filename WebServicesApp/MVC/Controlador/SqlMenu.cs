using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC.Modelo.ExecProcedure;
using System.Data;

namespace MVC.Controlador
{
    public static class SqlMenu
    {
        private static DataTable CRUD(string trx,string UidUserLogin, ClassMenu VALUE, out string resultado, string EstadoExistencia = "A")
        {
            resultado = "";
            #region Parametros Entrada y Salida
            var ParamOut = new List<ParametersProcedure>();
            var ParamIn = new List<ParametersProcedure>();
           
			
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uidmenu), VALUE.uidmenu, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uidrol), VALUE.uidrol, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uidpagina), VALUE.uidpagina, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.esvisible), VALUE.esvisible, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.semuestra), VALUE.semuestra, "".GetType().ToString(), OrentationType.In));

            ParamIn.Add(new ParametersProcedure(nameof(trx), trx, trx.GetType().ToString(), OrentationType.In));
		    ParamIn.Add(new ParametersProcedure(nameof(UidUserLogin), UidUserLogin, UidUserLogin.GetType().ToString(), OrentationType.In));          
            ParamIn.Add(new ParametersProcedure(nameof(EstadoExistencia), EstadoExistencia, EstadoExistencia.GetType().ToString(), OrentationType.In));
            ParamIn.Add(new ParametersProcedure(nameof(resultado), resultado, resultado.GetType().ToString(), OrentationType.Out));
            #endregion
            var table = SqlProcedureExec.ExecProcedure("[db_security].[sp_menu]", ParamIn, out ParamOut);
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
        public static List<ClassMenu> Select(string UidUserLogin,ClassMenu VALUE, out string resultado, string EstadoExistencia)
        {
            resultado = "";          
            string trx = "012100";
           var table =  CRUD(trx, UidUserLogin,VALUE, out resultado);
            List<ClassMenu> retorno = new List<ClassMenu>();
			if(table.Rows.Count>0){
				   var retornoAux = (from x in table.AsEnumerable()
							   select new 
							   {
							   
			uidmenu = x.Field<string>("uidmenu"),
			uidrol = x.Field<string>("uidrol"),
			uidpagina = x.Field<string>("uidpagina"),
			esvisible = x.Field<bool?>("esvisible"),
			semuestra = x.Field<bool?>("semuestra"),                 
							   }).ToList();
				   ClassMenu cl;
					foreach (var x in retornoAux)
					{
						cl = new ClassMenu();
						
			  cl.uidmenu = x.uidmenu;
			  cl.uidrol = x.uidrol;
			  cl.uidpagina = x.uidpagina;
			  cl.esvisible = x.esvisible;
			  cl.semuestra = x.semuestra;
						retorno.Add(cl);
					}            
			}
            return retorno;
        }


        
        public static DataTable SelectDataTable(string UidUserLogin, ClassMenu VALUE, out string resultado, string EstadoExistencia)
        {
            resultado = "";
            string trx = "012100";
            var table = CRUD(trx, UidUserLogin, VALUE, out resultado);
            return table;
        }



        public static void InsertInto(string UidUserLogin,ClassMenu VALUE, out string resultado)
        {
            resultado = "";
            string trx = "012101";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
        public static void Update(string UidUserLogin,ClassMenu VALUE, out string resultado)
        {
            resultado = "";
            string trx = "012102";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
        public static void Delete(string UidUserLogin,ClassMenu VALUE, out string resultado)
        {
            resultado = "";
            string trx = "012103";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
		public static DataTable SelectDynamic(string UidUserLogin,ClassMenu VALUE, out string resultado, string EstadoExistencia)
        {
           resultado = "";          
           string trx = "#trxMas5";
		   DataTable table= new DataTable("ClassMenu");
		   table=CRUD(trx, UidUserLogin,VALUE, out resultado);
           return table;
        }
    }
}