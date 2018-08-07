using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC.Modelo.ExecProcedure;
using System.Data;

namespace MVC.Controlador
{
    public static class SqlInformetecnico
    {
        private static DataTable CRUD(string trx,string UidUserLogin, ClassInformetecnico VALUE, out string resultado, string EstadoExistencia = "A")
        {
            resultado = "";
            #region Parametros Entrada y Salida
            var ParamOut = new List<ParametersProcedure>();
            var ParamIn = new List<ParametersProcedure>();
           
			
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uidinformetecnico), VALUE.uidinformetecnico, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uidot), VALUE.uidot, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uidserviciotecnico), VALUE.uidserviciotecnico, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uidcliente), VALUE.uidcliente, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uidequipo), VALUE.uidequipo, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.direccion), VALUE.direccion, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.email), VALUE.email, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.telefono), VALUE.telefono, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.fecha), VALUE.fecha, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.horallegada), VALUE.horallegada, TimeSpan.MinValue.GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.horadesalida), VALUE.horadesalida, TimeSpan.MinValue.GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.numvisitas), VALUE.numvisitas, Convert.ToInt32(0).GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.tipoaa), VALUE.tipoaa, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.tipodetrabajo), VALUE.tipodetrabajo, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.otros), VALUE.otros, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.area), VALUE.area, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.marca), VALUE.marca, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.modelo), VALUE.modelo, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.serieequipo), VALUE.serieequipo, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.capacidad), VALUE.capacidad, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.modoevaporador), VALUE.modoevaporador, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.serieevaporador), VALUE.serieevaporador, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.opciones), VALUE.opciones, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.modocondensador), VALUE.modocondensador, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.seriecondensador), VALUE.seriecondensador, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.observacionestecnico), VALUE.observacionestecnico, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.estatus), VALUE.estatus, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.repuestos), VALUE.repuestos, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.herramientas), VALUE.herramientas, "".GetType().ToString(), OrentationType.In));

            ParamIn.Add(new ParametersProcedure(nameof(trx), trx, trx.GetType().ToString(), OrentationType.In));
		    ParamIn.Add(new ParametersProcedure(nameof(UidUserLogin), UidUserLogin, UidUserLogin.GetType().ToString(), OrentationType.In));          
            ParamIn.Add(new ParametersProcedure(nameof(EstadoExistencia), EstadoExistencia, EstadoExistencia.GetType().ToString(), OrentationType.In));
            ParamIn.Add(new ParametersProcedure(nameof(resultado), resultado, resultado.GetType().ToString(), OrentationType.Out));
            #endregion
            var table = SqlProcedureExec.ExecProcedure("[dbo].[sp_informetecnico]", ParamIn, out ParamOut);
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
        public static List<ClassInformetecnico> Select(string UidUserLogin,ClassInformetecnico VALUE, out string resultado, string EstadoExistencia)
        {
            resultado = "";          
            string trx = "011088";
           var table =  CRUD(trx, UidUserLogin,VALUE, out resultado);
            List<ClassInformetecnico> retorno = new List<ClassInformetecnico>();
           var retornoAux = (from x in table.AsEnumerable()
                       select new 
                       {
					   
			uidinformetecnico = x.Field<string>("uidinformetecnico"),
			uidot = x.Field<string>("uidot"),
			uidserviciotecnico = x.Field<string>("uidserviciotecnico"),
			uidcliente = x.Field<string>("uidcliente"),
			uidequipo = x.Field<string>("uidequipo"),
			direccion = x.Field<string>("direccion"),
			email = x.Field<string>("email"),
			telefono = x.Field<string>("telefono"),
			fecha = x.Field<DateTime?>("fecha"),
			horallegada = x.Field<TimeSpan?>("horallegada"),
			horadesalida = x.Field<TimeSpan?>("horadesalida"),
			numvisitas = x.Field<int?>("numvisitas"),
			tipoaa = x.Field<string>("tipoaa"),
			tipodetrabajo = x.Field<string>("tipodetrabajo"),
			otros = x.Field<string>("otros"),
			area = x.Field<string>("area"),
			marca = x.Field<string>("marca"),
			modelo = x.Field<string>("modelo"),
			serieequipo = x.Field<string>("serieequipo"),
			capacidad = x.Field<string>("capacidad"),
			modoevaporador = x.Field<string>("modoevaporador"),
			serieevaporador = x.Field<string>("serieevaporador"),
			opciones = x.Field<string>("opciones"),
			modocondensador = x.Field<string>("modocondensador"),
			seriecondensador = x.Field<string>("seriecondensador"),
			observacionestecnico = x.Field<string>("observacionestecnico"),
			estatus = x.Field<string>("estatus"),
			repuestos = x.Field<string>("repuestos"),
			herramientas = x.Field<string>("herramientas"),
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

           ClassInformetecnico cl;
            foreach (var x in retornoAux)
            {

                cl = new ClassInformetecnico();

				 
			  cl.uidinformetecnico = x.uidinformetecnico;
			  cl.uidot = x.uidot;
			  cl.uidserviciotecnico = x.uidserviciotecnico;
			  cl.uidcliente = x.uidcliente;
			  cl.uidequipo = x.uidequipo;
			  cl.direccion = x.direccion;
			  cl.email = x.email;
			  cl.telefono = x.telefono;
			  cl.fecha = x.fecha;
			  if (x.horallegada  != null) {cl.horallegada = x.horallegada.Value.Ticks;}
			  if (x.horadesalida  != null) {cl.horadesalida = x.horadesalida.Value.Ticks;}
			  cl.numvisitas = x.numvisitas;
			  cl.tipoaa = x.tipoaa;
			  cl.tipodetrabajo = x.tipodetrabajo;
			  cl.otros = x.otros;
			  cl.area = x.area;
			  cl.marca = x.marca;
			  cl.modelo = x.modelo;
			  cl.serieequipo = x.serieequipo;
			  cl.capacidad = x.capacidad;
			  cl.modoevaporador = x.modoevaporador;
			  cl.serieevaporador = x.serieevaporador;
			  cl.opciones = x.opciones;
			  cl.modocondensador = x.modocondensador;
			  cl.seriecondensador = x.seriecondensador;
			  cl.observacionestecnico = x.observacionestecnico;
			  cl.estatus = x.estatus;
			  cl.repuestos = x.repuestos;
			  cl.herramientas = x.herramientas;
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
        public static void InsertInto(string UidUserLogin,ClassInformetecnico VALUE, out string resultado)
        {
            resultado = "";
            string trx = "011089";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
        public static void Update(string UidUserLogin,ClassInformetecnico VALUE, out string resultado)
        {
            resultado = "";
            string trx = "011090";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
        public static void Delete(string UidUserLogin,ClassInformetecnico VALUE, out string resultado)
        {
            resultado = "";
            string trx = "011091";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
    }
}