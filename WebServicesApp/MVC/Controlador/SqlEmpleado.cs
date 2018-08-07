using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC.Modelo.ExecProcedure;
using System.Data;

namespace MVC.Controlador
{
    public static class SqlEmpleado
    {
        private static DataTable CRUD(string trx,string UidUserLogin, ClassEmpleado VALUE, out string resultado, string EstadoExistencia = "A")
        {
            resultado = "";
            #region Parametros Entrada y Salida
            var ParamOut = new List<ParametersProcedure>();
            var ParamIn = new List<ParametersProcedure>();
           
			
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uidempleado), VALUE.uidempleado, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.codido), VALUE.codido, Convert.ToInt32(0).GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.cedula), VALUE.cedula, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.nombres), VALUE.nombres, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.apellidos), VALUE.apellidos, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uidestadocivil), VALUE.uidestadocivil, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.fechanacimiento), VALUE.fechanacimiento, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uidsexo), VALUE.uidsexo, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.telefono), VALUE.telefono, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.num_hijos), VALUE.num_hijos, Convert.ToInt32(0).GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uidnivelestudio), VALUE.uidnivelestudio, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.titulo_obtenido), VALUE.titulo_obtenido, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.direccion_domicilio), VALUE.direccion_domicilio, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.provincia), VALUE.provincia, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.ciudad), VALUE.ciudad, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.email), VALUE.email, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.email_trabajo), VALUE.email_trabajo, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.fecha_ingreso), VALUE.fecha_ingreso, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uidsuario), VALUE.uidsuario, "".GetType().ToString(), OrentationType.In));

            ParamIn.Add(new ParametersProcedure(nameof(trx), trx, trx.GetType().ToString(), OrentationType.In));
		    ParamIn.Add(new ParametersProcedure(nameof(UidUserLogin), UidUserLogin, UidUserLogin.GetType().ToString(), OrentationType.In));          
            ParamIn.Add(new ParametersProcedure(nameof(EstadoExistencia), EstadoExistencia, EstadoExistencia.GetType().ToString(), OrentationType.In));
            ParamIn.Add(new ParametersProcedure(nameof(resultado), resultado, resultado.GetType().ToString(), OrentationType.Out));
            #endregion
            var table = SqlProcedureExec.ExecProcedure("[dbo].[sp_empleado]", ParamIn, out ParamOut);
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
        public static List<ClassEmpleado> Select(string UidUserLogin,ClassEmpleado VALUE, out string resultado, string EstadoExistencia)
        {
            resultado = "";          
            string trx = "011040";
           var table =  CRUD(trx, UidUserLogin,VALUE, out resultado);
            List<ClassEmpleado> retorno = new List<ClassEmpleado>();
           var retornoAux = (from x in table.AsEnumerable()
                       select new 
                       {
					   
			uidempleado = x.Field<string>("uidempleado"),
			codido = x.Field<int?>("codido"),
			cedula = x.Field<string>("cedula"),
			nombres = x.Field<string>("nombres"),
			apellidos = x.Field<string>("apellidos"),
			uidestadocivil = x.Field<string>("uidestadocivil"),
			fechanacimiento = x.Field<DateTime?>("fechanacimiento"),
			uidsexo = x.Field<string>("uidsexo"),
			telefono = x.Field<string>("telefono"),
			num_hijos = x.Field<int?>("num_hijos"),
			uidnivelestudio = x.Field<string>("uidnivelestudio"),
			titulo_obtenido = x.Field<string>("titulo_obtenido"),
			direccion_domicilio = x.Field<string>("direccion_domicilio"),
			provincia = x.Field<string>("provincia"),
			ciudad = x.Field<string>("ciudad"),
			email = x.Field<string>("email"),
			email_trabajo = x.Field<string>("email_trabajo"),
			fecha_ingreso = x.Field<DateTime?>("fecha_ingreso"),
			uidsuario = x.Field<string>("uidsuario"),
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

           ClassEmpleado cl;
            foreach (var x in retornoAux)
            {

                cl = new ClassEmpleado();

				 
			  cl.uidempleado = x.uidempleado;
			  cl.codido = x.codido;
			  cl.cedula = x.cedula;
			  cl.nombres = x.nombres;
			  cl.apellidos = x.apellidos;
			  cl.uidestadocivil = x.uidestadocivil;
			  cl.fechanacimiento = x.fechanacimiento;
			  cl.uidsexo = x.uidsexo;
			  cl.telefono = x.telefono;
			  cl.num_hijos = x.num_hijos;
			  cl.uidnivelestudio = x.uidnivelestudio;
			  cl.titulo_obtenido = x.titulo_obtenido;
			  cl.direccion_domicilio = x.direccion_domicilio;
			  cl.provincia = x.provincia;
			  cl.ciudad = x.ciudad;
			  cl.email = x.email;
			  cl.email_trabajo = x.email_trabajo;
			  cl.fecha_ingreso = x.fecha_ingreso;
			  cl.uidsuario = x.uidsuario;
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
        public static void InsertInto(string UidUserLogin,ClassEmpleado VALUE, out string resultado)
        {
            resultado = "";
            string trx = "011041";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
        public static void Update(string UidUserLogin,ClassEmpleado VALUE, out string resultado)
        {
            resultado = "";
            string trx = "011042";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
        public static void Delete(string UidUserLogin,ClassEmpleado VALUE, out string resultado)
        {
            resultado = "";
            string trx = "011043";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
    }
}