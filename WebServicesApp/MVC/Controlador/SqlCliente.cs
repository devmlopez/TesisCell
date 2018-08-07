using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC.Modelo.ExecProcedure;
using System.Data;

namespace MVC.Controlador
{
    public static class SqlCliente
    {
        private static DataTable CRUD(string trx,string UidUserLogin, ClassCliente VALUE, out string resultado, string EstadoExistencia = "A")
        {
            resultado = "";
            #region Parametros Entrada y Salida
            var ParamOut = new List<ParametersProcedure>();
            var ParamIn = new List<ParametersProcedure>();
           
			
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uidcliente), VALUE.uidcliente, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.id_cliente), VALUE.id_cliente, Convert.ToInt32(0).GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uidtipopersona), VALUE.uidtipopersona, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.identificacion), VALUE.identificacion, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uidtipoidentificacion), VALUE.uidtipoidentificacion, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.razonsocial), VALUE.razonsocial, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.nombre), VALUE.nombre, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.contacto), VALUE.contacto, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.celular), VALUE.celular, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.telefono), VALUE.telefono, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.direccion), VALUE.direccion, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.provincia), VALUE.provincia, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.ciudad), VALUE.ciudad, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.email), VALUE.email, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.referencia), VALUE.referencia, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.observaciones), VALUE.observaciones, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uisusuario), VALUE.uisusuario, "".GetType().ToString(), OrentationType.In));

            ParamIn.Add(new ParametersProcedure(nameof(trx), trx, trx.GetType().ToString(), OrentationType.In));
		    ParamIn.Add(new ParametersProcedure(nameof(UidUserLogin), UidUserLogin, UidUserLogin.GetType().ToString(), OrentationType.In));          
            ParamIn.Add(new ParametersProcedure(nameof(EstadoExistencia), EstadoExistencia, EstadoExistencia.GetType().ToString(), OrentationType.In));
            ParamIn.Add(new ParametersProcedure(nameof(resultado), resultado, resultado.GetType().ToString(), OrentationType.Out));
            #endregion
            var table = SqlProcedureExec.ExecProcedure("[dbo].[sp_cliente]", ParamIn, out ParamOut);
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
        public static List<ClassCliente> Select(string UidUserLogin,ClassCliente VALUE, out string resultado, string EstadoExistencia)
        {
            resultado = "";          
            string trx = "0116000";
           var table =  CRUD(trx, UidUserLogin,VALUE, out resultado);
            List<ClassCliente> retorno = new List<ClassCliente>();
			if(table.Rows.Count>0){
				   var retornoAux = (from x in table.AsEnumerable()
							   select new 
							   {
							   
			uidcliente = x.Field<string>("uidcliente"),
			id_cliente = x.Field<int?>("id_cliente"),
			uidtipopersona = x.Field<string>("uidtipopersona"),
			identificacion = x.Field<string>("identificacion"),
			uidtipoidentificacion = x.Field<string>("uidtipoidentificacion"),
			razonsocial = x.Field<string>("razonsocial"),
			nombre = x.Field<string>("nombre"),
			contacto = x.Field<string>("contacto"),
			celular = x.Field<string>("celular"),
			telefono = x.Field<string>("telefono"),
			direccion = x.Field<string>("direccion"),
			provincia = x.Field<string>("provincia"),
			ciudad = x.Field<string>("ciudad"),
			email = x.Field<string>("email"),
			referencia = x.Field<string>("referencia"),
			observaciones = x.Field<string>("observaciones"),
			uisusuario = x.Field<string>("uisusuario"),                 
							   }).ToList();
				   ClassCliente cl;
					foreach (var x in retornoAux)
					{
						cl = new ClassCliente();
						
			  cl.uidcliente = x.uidcliente;
			  cl.id_cliente = x.id_cliente;
			  cl.uidtipopersona = x.uidtipopersona;
			  cl.identificacion = x.identificacion;
			  cl.uidtipoidentificacion = x.uidtipoidentificacion;
			  cl.razonsocial = x.razonsocial;
			  cl.nombre = x.nombre;
			  cl.contacto = x.contacto;
			  cl.celular = x.celular;
			  cl.telefono = x.telefono;
			  cl.direccion = x.direccion;
			  cl.provincia = x.provincia;
			  cl.ciudad = x.ciudad;
			  cl.email = x.email;
			  cl.referencia = x.referencia;
			  cl.observaciones = x.observaciones;
			  cl.uisusuario = x.uisusuario;
						retorno.Add(cl);
					}            
			}
            return retorno;
        }		
        public static void InsertInto(string UidUserLogin,ClassCliente VALUE, out string resultado)
        {
            resultado = "";
            string trx = "0116001";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
        public static void Update(string UidUserLogin,ClassCliente VALUE, out string resultado)
        {
            resultado = "";
            string trx = "0116002";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
        public static void Delete(string UidUserLogin,ClassCliente VALUE, out string resultado)
        {
            resultado = "";
            string trx = "0116003";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
		public static DataTable SelectDataTable(string UidUserLogin,ClassCliente VALUE, out string resultado, string EstadoExistencia)
        {
           resultado = "";          
           string trx = "0116004";
		   DataTable table= new DataTable("ClassCliente");
		   table=CRUD(trx, UidUserLogin,VALUE, out resultado);
           return table;
        }
    }
}