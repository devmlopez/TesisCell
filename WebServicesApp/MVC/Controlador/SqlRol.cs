using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC.Modelo.ExecProcedure;
using System.Data;

namespace MVC.Controlador
{
    public static class SqlRol
    {
        private static DataTable CRUD(string trx,string UidUserLogin, ClassRol VALUE, out string resultado, string EstadoExistencia = "A")
        {
            resultado = "";
            #region Parametros Entrada y Salida
            var ParamOut = new List<ParametersProcedure>();
            var ParamIn = new List<ParametersProcedure>();
           
			
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.uidrol), VALUE.uidrol, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.rol), VALUE.rol, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.permisolectura), VALUE.permisolectura, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.permisoescritura), VALUE.permisoescritura, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.permisoconsultar), VALUE.permisoconsultar, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.perisocrear), VALUE.perisocrear, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.permisoeditar), VALUE.permisoeditar, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.permisoeliminar), VALUE.permisoeliminar, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.permisototal), VALUE.permisototal, "".GetType().ToString(), OrentationType.In));
			ParamIn.Add(new ParametersProcedure(nameof(VALUE.permisonulo), VALUE.permisonulo, "".GetType().ToString(), OrentationType.In));

            ParamIn.Add(new ParametersProcedure(nameof(trx), trx, trx.GetType().ToString(), OrentationType.In));
		    ParamIn.Add(new ParametersProcedure(nameof(UidUserLogin), UidUserLogin, UidUserLogin.GetType().ToString(), OrentationType.In));          
            ParamIn.Add(new ParametersProcedure(nameof(EstadoExistencia), EstadoExistencia, EstadoExistencia.GetType().ToString(), OrentationType.In));
            ParamIn.Add(new ParametersProcedure(nameof(resultado), resultado, resultado.GetType().ToString(), OrentationType.Out));
            #endregion
            var table = SqlProcedureExec.ExecProcedure("[db_security].[sp_rol]", ParamIn, out ParamOut);
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
        public static List<ClassRol> Select(string UidUserLogin,ClassRol VALUE, out string resultado, string EstadoExistencia)
        {
            resultado = "";          
            string trx = "02300";
           var table =  CRUD(trx, UidUserLogin,VALUE, out resultado);
            List<ClassRol> retorno = new List<ClassRol>();
           var retornoAux = (from x in table.AsEnumerable()
                       select new 
                       {
					   
			uidrol = x.Field<string>("uidrol"),
			rol = x.Field<string>("rol"),
			permisolectura = x.Field<bool?>("permisolectura"),
			permisoescritura = x.Field<bool?>("permisoescritura"),
			permisoconsultar = x.Field<bool?>("permisoconsultar"),
			perisocrear = x.Field<bool?>("perisocrear"),
			permisoeditar = x.Field<bool?>("permisoeditar"),
			permisoeliminar = x.Field<bool?>("permisoeliminar"),
			permisototal = x.Field<bool?>("permisototal"),
			permisonulo = x.Field<bool?>("permisonulo"),
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

           ClassRol cl;
            foreach (var x in retornoAux)
            {

                cl = new ClassRol();

				 
			  cl.uidrol = x.uidrol;
			  cl.rol = x.rol;
			  cl.permisolectura = x.permisolectura;
			  cl.permisoescritura = x.permisoescritura;
			  cl.permisoconsultar = x.permisoconsultar;
			  cl.perisocrear = x.perisocrear;
			  cl.permisoeditar = x.permisoeditar;
			  cl.permisoeliminar = x.permisoeliminar;
			  cl.permisototal = x.permisototal;
			  cl.permisonulo = x.permisonulo;
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
        public static void InsertInto(string UidUserLogin,ClassRol VALUE, out string resultado)
        {
            resultado = "";
            string trx = "02301";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
        public static void Update(string UidUserLogin,ClassRol VALUE, out string resultado)
        {
            resultado = "";
            string trx = "02302";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
        public static void Delete(string UidUserLogin,ClassRol VALUE, out string resultado)
        {
            resultado = "";
            string trx = "02303";
            CRUD(trx,UidUserLogin, VALUE, out resultado);
        }
    }
}