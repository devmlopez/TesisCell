using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC.Modelo.ExecProcedure;
using System.Data;

namespace MVC.Controlador
{
    public static class SqlGrupousuario
    {
        private static DataTable CRUD(string trx,string UidUserLogin, ClassGrupousuario VALUE, out string resultado, string EstadoExistencia = "A")
        {
            resultado = "";
            #region Parametros Entrada y Salida
            var ParamOut = new List<ParametersProcedure>();
            var ParamIn = new List<ParametersProcedure>();
           
			
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uidgrupousuario), VALUE.uidgrupousuario, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uidgrupo), VALUE.uidgrupo, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uidusuario), VALUE.uidusuario, "".GetType().ToString(), OrentationType.In));

            ParamIn.Add(new ParametersProcedure(nameof(trx), trx, trx.GetType().ToString(), OrentationType.In));
		    ParamIn.Add(new ParametersProcedure(nameof(UidUserLogin), UidUserLogin, UidUserLogin.GetType().ToString(), OrentationType.In));          
            ParamIn.Add(new ParametersProcedure(nameof(EstadoExistencia), EstadoExistencia, EstadoExistencia.GetType().ToString(), OrentationType.In));
            ParamIn.Add(new ParametersProcedure(nameof(resultado), resultado, resultado.GetType().ToString(), OrentationType.Out));
            #endregion
            var table = SqlProcedureExec.ExecProcedure("[db_security].[sp_grupousuario]", ParamIn, out ParamOut);
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
        public static List<ClassGrupousuario> Select(string UidUserLogin,ClassGrupousuario VALUE, out string resultado, string EstadoExistencia)
        {
            resultado = "";          
            string trx = "02404";
           var table =  CRUD(trx, UidUserLogin,VALUE, out resultado);
            List<ClassGrupousuario> retorno = new List<ClassGrupousuario>();
           var retornoAux = (from x in table.AsEnumerable()
                       select new 
                       {
					   
			uidgrupousuario = x.Field<string>("uidgrupousuario"),
			uidgrupo = x.Field<string>("uidgrupo"),
			uidusuario = x.Field<string>("uidusuario"),
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

           ClassGrupousuario cl;
            foreach (var x in retornoAux)
            {

                cl = new ClassGrupousuario();

				 
			  cl.uidgrupousuario = x.uidgrupousuario;
			  cl.uidgrupo = x.uidgrupo;
			  cl.uidusuario = x.uidusuario;
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
        public static void InsertInto(string UidUserLogin,ClassGrupousuario VALUE, out string resultado)
        {
            resultado = "";
            string trx = "02405";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
        public static void Update(string UidUserLogin,ClassGrupousuario VALUE, out string resultado)
        {
            resultado = "";
            string trx = "02406";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
        public static void Delete(string UidUserLogin,ClassGrupousuario VALUE, out string resultado)
        {
            resultado = "";
            string trx = "02407";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
    }
}