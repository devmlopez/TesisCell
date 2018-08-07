using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
namespace MVC.Modelo
{
    public class ConexionClass
    {
        public static string GetStringConexion()
        {

            string stringConnection = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
                  
            return stringConnection;
        }
    }
}