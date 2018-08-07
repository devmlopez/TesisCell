using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC.Modelo.ExecProcedure;
using System.Data;

namespace MVC.Controlador
{
    public static class SqlServiciotecnico
    {
        private static DataTable CRUD(string trx,string UidUserLogin, ClassServiciotecnico VALUE, out string resultado, string EstadoExistencia = "A")
        {
            resultado = "";
            #region Parametros Entrada y Salida
            var ParamOut = new List<ParametersProcedure>();
            var ParamIn = new List<ParametersProcedure>();
           
			
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uidserviciotecnico), VALUE.uidserviciotecnico, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.codservicio), VALUE.codservicio, Convert.ToInt32(0).GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uidcliente), VALUE.uidcliente, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uidempleado), VALUE.uidempleado, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.fechaingreso), VALUE.fechaingreso, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.marca), VALUE.marca, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.modelo), VALUE.modelo, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.problemasugerido), VALUE.problemasugerido, "".GetType().ToString(), OrentationType.In));

            ParamIn.Add(new ParametersProcedure(nameof(trx), trx, trx.GetType().ToString(), OrentationType.In));
		    ParamIn.Add(new ParametersProcedure(nameof(UidUserLogin), UidUserLogin, UidUserLogin.GetType().ToString(), OrentationType.In));          
            ParamIn.Add(new ParametersProcedure(nameof(EstadoExistencia), EstadoExistencia, EstadoExistencia.GetType().ToString(), OrentationType.In));
            ParamIn.Add(new ParametersProcedure(nameof(resultado), resultado, resultado.GetType().ToString(), OrentationType.Out));
            #endregion
            var table = SqlProcedureExec.ExecProcedure("[dbo].[sp_serviciotecnico]", ParamIn, out ParamOut);
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

        public static List<ClassServiciotecnico> Select(string UidUserLogin, ClassServiciotecnico VALUE, out string resultado, string EstadoExistencia)
        {
            resultado = "";
            string trx = "012300";
            var table = CRUD(trx, UidUserLogin, VALUE, out resultado);
            List<ClassServiciotecnico> retorno = new List<ClassServiciotecnico>();
            if (table.Rows.Count > 0)
            {
                var retornoAux = (from x in table.AsEnumerable()
                                  select new
                                  {

                                      uidserviciotecnico = x.Field<string>("uidserviciotecnico"),
                                      codservicio = x.Field<int?>("codservicio"),
                                      uidcliente = x.Field<string>("uidcliente"),
                                      uidempleado = x.Field<string>("uidempleado"),
                                      fechaingreso = x.Field<DateTime?>("fechaingreso"),
                                      marca = x.Field<string>("marca"),
                                      modelo = x.Field<string>("modelo"),
                                      problemasugerido = x.Field<string>("problemasugerido"),
                                  }).ToList();
                ClassServiciotecnico cl;
                foreach (var x in retornoAux)
                {
                    cl = new ClassServiciotecnico();

                    cl.uidserviciotecnico = x.uidserviciotecnico;
                    cl.codservicio = x.codservicio;
                    cl.uidcliente = x.uidcliente;
                    cl.uidempleado = x.uidempleado;
                    cl.fechaingreso = x.fechaingreso;
                    cl.marca = x.marca;
                    cl.modelo = x.modelo;
                    cl.problemasugerido = x.problemasugerido;
                    retorno.Add(cl);
                }
            }
            return retorno;
        }
        public static DataTable SelectDataTable(string UidUserLogin,ClassServiciotecnico VALUE, out string resultado, string EstadoExistencia)
        {
            resultado = "";          
            string trx = "012300";
           var table =  CRUD(trx, UidUserLogin,VALUE, out resultado);            		
            return table;
        }


        public static void InsertInto(string UidUserLogin,ClassServiciotecnico VALUE, out string resultado)
        {
            resultado = "";
            string trx = "012301";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
        public static void Update(string UidUserLogin,ClassServiciotecnico VALUE, out string resultado)
        {
            resultado = "";
            string trx = "012302";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
        public static void Delete(string UidUserLogin,ClassServiciotecnico VALUE, out string resultado)
        {
            resultado = "";
            string trx = "012303";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
		public static DataTable SelectDynamic(string UidUserLogin,ClassServiciotecnico VALUE, out string resultado, string EstadoExistencia)
        {
           resultado = "";          
           string trx = "#trxMas5";
		   DataTable table= new DataTable("ClassServiciotecnico");
		   table=CRUD(trx, UidUserLogin,VALUE, out resultado);
           return table;
        }
    }
}