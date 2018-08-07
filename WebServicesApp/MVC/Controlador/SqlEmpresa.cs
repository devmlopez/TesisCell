using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC.Modelo.ExecProcedure;
using System.Data;

namespace MVC.Controlador
{
    public static class SqlEmpresa
    {
        private static DataTable CRUD(string trx,string UidUserLogin, ClassEmpresa VALUE, out string resultado, string EstadoExistencia = "A")
        {
            resultado = "";
            #region Parametros Entrada y Salida
            var ParamOut = new List<ParametersProcedure>();
            var ParamIn = new List<ParametersProcedure>();
           
			
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uid_empresa), VALUE.uid_empresa, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.ruc), VALUE.ruc, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.nombre), VALUE.nombre, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.descripcion), VALUE.descripcion, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.direccion), VALUE.direccion, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.telefono), VALUE.telefono, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.representantelegal), VALUE.representantelegal, "".GetType().ToString(), OrentationType.In));

            ParamIn.Add(new ParametersProcedure(nameof(trx), trx, trx.GetType().ToString(), OrentationType.In));
		    ParamIn.Add(new ParametersProcedure(nameof(UidUserLogin), UidUserLogin, UidUserLogin.GetType().ToString(), OrentationType.In));          
            ParamIn.Add(new ParametersProcedure(nameof(EstadoExistencia), EstadoExistencia, EstadoExistencia.GetType().ToString(), OrentationType.In));
            ParamIn.Add(new ParametersProcedure(nameof(resultado), resultado, resultado.GetType().ToString(), OrentationType.Out));
            #endregion
            var table = SqlProcedureExec.ExecProcedure("[dbo].[sp_empresa]", ParamIn, out ParamOut);
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
        public static List<ClassEmpresa> Select(string UidUserLogin,ClassEmpresa VALUE, out string resultado, string EstadoExistencia)
        {
            resultado = "";          
            string trx = "011056";
           var table =  CRUD(trx, UidUserLogin,VALUE, out resultado);
            List<ClassEmpresa> retorno = new List<ClassEmpresa>();
           var retornoAux = (from x in table.AsEnumerable()
                       select new 
                       {
					   
			uid_empresa = x.Field<string>("uid_empresa"),
			ruc = x.Field<string>("ruc"),
			nombre = x.Field<string>("nombre"),
			descripcion = x.Field<string>("descripcion"),
			direccion = x.Field<string>("direccion"),
			telefono = x.Field<string>("telefono"),
			representantelegal = x.Field<string>("representantelegal"),
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

           ClassEmpresa cl;
            foreach (var x in retornoAux)
            {

                cl = new ClassEmpresa();

				 
			  cl.uid_empresa = x.uid_empresa;
			  cl.ruc = x.ruc;
			  cl.nombre = x.nombre;
			  cl.descripcion = x.descripcion;
			  cl.direccion = x.direccion;
			  cl.telefono = x.telefono;
			  cl.representantelegal = x.representantelegal;
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
        public static void InsertInto(string UidUserLogin,ClassEmpresa VALUE, out string resultado)
        {
            resultado = "";
            string trx = "011057";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
        public static void Update(string UidUserLogin,ClassEmpresa VALUE, out string resultado)
        {
            resultado = "";
            string trx = "011058";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
        public static void Delete(string UidUserLogin,ClassEmpresa VALUE, out string resultado)
        {
            resultado = "";
            string trx = "011059";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
    }
}