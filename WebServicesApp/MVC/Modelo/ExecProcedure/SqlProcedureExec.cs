using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
namespace MVC.Modelo.ExecProcedure
{
    public class SqlProcedureExec
    {
        public static DataTable ExecProcedure(string ProcedureName, List<ParametersProcedure> Parameters, out List<ParametersProcedure> ParametersOut)
        {
            DataTable table = new DataTable("TableResul");
            ParametersOut = new List<ParametersProcedure>();
            try
            {
                using (SqlConnection conn = new SqlConnection(ConexionClass.GetStringConexion()))
                {
                    using (SqlCommand cmd = new SqlCommand(ProcedureName, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        List<SqlParameter> ListaParametrosSqlIn = new List<SqlParameter>();
                        List<SqlParameter> ListaParametrosSqlOut = new List<SqlParameter>();

                        SqlParameter paramIn;
                        foreach (var item in Parameters)
                        {
                            paramIn = new SqlParameter();
                            paramIn.Direction = (item.Orientation.Equals(OrentationType.In) ? ParameterDirection.Input :
                                                 item.Orientation.Equals(OrentationType.Out) ? ParameterDirection.Output :
                                                 ParameterDirection.InputOutput);

                            paramIn.ParameterName = item.Parameter;

                            paramIn.Size = int.MaxValue;

                            var ddd = (DateTime.Now).GetType().ToString();

                            if (item.TypeDate.Equals(("".GetType().ToString())))
                            {
                                paramIn.DbType = DbType.String;
                            }
                            else
                                if (item.TypeDate.Equals(((Convert.ToDecimal(0)).GetType().ToString())))
                            {
                                paramIn.DbType = DbType.Decimal;
                            }
                            else
                               if (item.TypeDate.Equals(((DateTime.Now).GetType().ToString())))
                            {
                                paramIn.DbType = DbType.DateTime;
                            }
                            else
                               if (item.TypeDate.Equals((Convert.ToInt16(0).GetType().ToString())))
                            {
                                paramIn.DbType = DbType.Int16;
                            }
                            else
                            if (item.TypeDate.Equals((Convert.ToInt32(0).GetType().ToString())))
                            {
                                paramIn.DbType = DbType.Int32;
                            }
                            else
                            if (item.TypeDate.Equals((Convert.ToInt64(0).GetType().ToString())))
                            {
                                paramIn.DbType = DbType.Int64;
                            }
                            else
                             if (item.TypeDate.Equals(((TimeSpan.MinValue).GetType().ToString())))
                            {
                                paramIn.SqlDbType = SqlDbType.Time;
                            }
                            
                            if (item.Value == null)
                            {
                                paramIn.Value = DBNull.Value;
                            }
                            else
                            {
                                if (item.TypeDate.Equals((TimeSpan.MinValue).GetType().ToString()))
                                {
                                    paramIn.Value = TimeSpan.FromTicks(Convert.ToInt64(item.Value));
                                }
                                else
                                {
                                    paramIn.Value = item.Value;
                                }

                            }


                            ListaParametrosSqlIn.Add(paramIn);
                        }
                        cmd.Parameters.AddRange(ListaParametrosSqlIn.ToArray());
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        da.Dispose();

                        ParametersProcedure param;
                        foreach (SqlParameter item in cmd.Parameters)
                        {
                            if (item.Direction == ParameterDirection.InputOutput || item.Direction == ParameterDirection.Output)
                            {
                                var BuscaParametros = Parameters.Where(x => x.Parameter == item.ParameterName).FirstOrDefault();
                                param = new ParametersProcedure();
                                param.TypeDate = BuscaParametros.TypeDate;
                                param.Parameter = BuscaParametros.Parameter;
                                param.Value = (item.Value == null) ? DBNull.Value : item.Value;
                                ParametersOut.Add(param);
                            }
                        }

                        if (ds.Tables.Count > 0)
                        {
                            table = ds.Tables[0];
                        }
                    }

                }
            }
            catch (Exception exc)
            {
               
            }
            return table;
        }

    }
}