using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC.Modelo.ExecProcedure;
using System.Data;

namespace MVC.Controlador
{
    public static class SqlEquipo
    {
        private static DataTable CRUD(string trx,string UidUserLogin, ClassEquipo VALUE, out string resultado, string EstadoExistencia = "A")
        {
            resultado = "";
            #region Parametros Entrada y Salida
            var ParamOut = new List<ParametersProcedure>();
            var ParamIn = new List<ParametersProcedure>();
           
			
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uidequipo), VALUE.uidequipo, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uidserviciotecnico), VALUE.uidserviciotecnico, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uidot), VALUE.uidot, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uidencargado), VALUE.uidencargado, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.secuenciaequipo), VALUE.secuenciaequipo, Convert.ToInt32(0).GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.marca), VALUE.marca, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.codreferencia), VALUE.codreferencia, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.precio), VALUE.precio, Convert.ToDecimal(0).GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uidestado), VALUE.uidestado, "".GetType().ToString(), OrentationType.In));

            ParamIn.Add(new ParametersProcedure(nameof(trx), trx, trx.GetType().ToString(), OrentationType.In));
		    ParamIn.Add(new ParametersProcedure(nameof(UidUserLogin), UidUserLogin, UidUserLogin.GetType().ToString(), OrentationType.In));          
            ParamIn.Add(new ParametersProcedure(nameof(EstadoExistencia), EstadoExistencia, EstadoExistencia.GetType().ToString(), OrentationType.In));
            ParamIn.Add(new ParametersProcedure(nameof(resultado), resultado, resultado.GetType().ToString(), OrentationType.Out));
            #endregion
            var table = SqlProcedureExec.ExecProcedure("[dbo].[sp_equipo]", ParamIn, out ParamOut);
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
        public static List<ClassEquipo> Select(string UidUserLogin,ClassEquipo VALUE, out string resultado, string EstadoExistencia)
        {
            resultado = "";          
            string trx = "01610";
           var table =  CRUD(trx, UidUserLogin,VALUE, out resultado);
            List<ClassEquipo> retorno = new List<ClassEquipo>();
           var retornoAux = (from x in table.AsEnumerable()
                       select new 
                       {
					   
			uidequipo = x.Field<string>("uidequipo"),
			uidserviciotecnico = x.Field<string>("uidserviciotecnico"),
			uidot = x.Field<string>("uidot"),
			uidencargado = x.Field<string>("uidencargado"),
			secuenciaequipo = x.Field<int?>("secuenciaequipo"),
			marca = x.Field<string>("marca"),
			codreferencia = x.Field<string>("codreferencia"),
			precio = x.Field<decimal?>("precio"),
			uidestado = x.Field<string>("uidestado"),
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

           ClassEquipo cl;
            foreach (var x in retornoAux)
            {

                cl = new ClassEquipo();

				 
			  cl.uidequipo = x.uidequipo;
			  cl.uidserviciotecnico = x.uidserviciotecnico;
			  cl.uidot = x.uidot;
			  cl.uidencargado = x.uidencargado;
			  cl.secuenciaequipo = x.secuenciaequipo;
			  cl.marca = x.marca;
			  cl.codreferencia = x.codreferencia;
			  cl.precio = x.precio;
			  cl.uidestado = x.uidestado;
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
        public static void InsertInto(string UidUserLogin,ClassEquipo VALUE, out string resultado)
        {
            resultado = "";
            string trx = "01611";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
        public static void Update(string UidUserLogin,ClassEquipo VALUE, out string resultado)
        {
            resultado = "";
            string trx = "01612";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
        public static void Delete(string UidUserLogin,ClassEquipo VALUE, out string resultado)
        {
            resultado = "";
            string trx = "01613";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
    }
}