using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC.Modelo.ExecProcedure;
using System.Data;

namespace MVC.Controlador
{
    public static class SqlLoginuser
    {
        private static DataTable CRUD(string trx,string UidUserLogin, ClassLoginuser VALUE, out string resultado, string EstadoExistencia = "A")
        {
            resultado = "";
            #region Parametros Entrada y Salida
            var ParamOut = new List<ParametersProcedure>();
            var ParamIn = new List<ParametersProcedure>();
           
			
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uidsuario), VALUE.uidsuario, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.usuario), VALUE.usuario, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.email), VALUE.email, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.nombre), VALUE.nombre, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.contrasenia), VALUE.contrasenia, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uidrol), VALUE.uidrol, "".GetType().ToString(), OrentationType.In));

            ParamIn.Add(new ParametersProcedure(nameof(trx), trx, trx.GetType().ToString(), OrentationType.In));
		    ParamIn.Add(new ParametersProcedure(nameof(UidUserLogin), UidUserLogin, UidUserLogin.GetType().ToString(), OrentationType.In));          
            ParamIn.Add(new ParametersProcedure(nameof(EstadoExistencia), EstadoExistencia, EstadoExistencia.GetType().ToString(), OrentationType.In));
            ParamIn.Add(new ParametersProcedure(nameof(resultado), resultado, resultado.GetType().ToString(), OrentationType.Out));
            #endregion
            var table = SqlProcedureExec.ExecProcedure("[db_security].[sp_loginuser]", ParamIn, out ParamOut);
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
        public static List<ClassLoginuser> Select(string UidUserLogin,ClassLoginuser VALUE, out string resultado, string EstadoExistencia)
        {
            resultado = "";          
            string trx = "02200";
           var table =  CRUD(trx, UidUserLogin,VALUE, out resultado);
            List<ClassLoginuser> retorno = new List<ClassLoginuser>();
           var retornoAux = (from x in table.AsEnumerable()
                       select new 
                       {
					   
			uidsuario = x.Field<string>("uidsuario"),
			usuario = x.Field<string>("usuario"),
			email = x.Field<string>("email"),
			nombre = x.Field<string>("nombre"),
			contrasenia = x.Field<string>("contrasenia"),
			uidrol = x.Field<string>("uidrol"),
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

           ClassLoginuser cl;
            foreach (var x in retornoAux)
            {

                cl = new ClassLoginuser();

				 
			  cl.uidsuario = x.uidsuario;
			  cl.usuario = x.usuario;
			  cl.email = x.email;
			  cl.nombre = x.nombre;
			  cl.contrasenia = x.contrasenia;
			  cl.uidrol = x.uidrol;
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
        public static void InsertInto(string UidUserLogin,ClassLoginuser VALUE, out string resultado)
        {
            resultado = "";
            string trx = "02201";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
        public static void Update(string UidUserLogin,ClassLoginuser VALUE, out string resultado)
        {
            resultado = "";
            string trx = "02202";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
        public static void Delete(string UidUserLogin,ClassLoginuser VALUE, out string resultado)
        {
            resultado = "";
            string trx = "02203";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
    }
}