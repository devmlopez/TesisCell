using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace SitioWeb.ClasesUtiles
{
    public static class StatusExistencia
    {
        public static string Activo = "A";
        public static string Inactivo = "I";
        public static string Error = "E";
        public static string NULL = "N";
    }

    public class MenuClass
    {
        public Controlador.ClassPagina pagina { get; set; }
        public List<MenuClass> PAgHijo = new List<MenuClass>();
        public void AddHijo(List<Controlador.ClassPagina> Paginas)
        {
            // var pagHijas=
            //foreach(var pag in Paginas)
            // {
            //     this.pagina = pag;
            // }
        }
    }
   
    public static class Util
    {
        
        public static string GetMenuPorUsuario(string UidUserLogin)
        {
            string ret = "";
            string resultado = "";
            var paginas = Controlador.SqlPagina.Select(UidUserLogin, new Controlador.ClassPagina(), out resultado);
            MenuClass mc = new MenuClass();

            var listaPadre = paginas.Where(x => string.IsNullOrEmpty(x.uidpaginapadre)).OrderBy(x=>x.orden).ToList();
            foreach (var pagPadre in listaPadre)
            {
                mc.pagina = pagPadre;
               
            }
            return "";
        }
        

      public static List<ComboClassValueText> AgregarItemInicialComboBoxClass(List<ComboClassValueText> lista)
        {
            lista.Insert(0, new ComboClassValueText() { value = "", text = "--Seleccionar--" });
            return lista;
        }
        public static string GetSeparatorDecimal()
        {
            return System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator;
        }
        public static float? ConvertStringToFloat(string value)
        {
            float? ret = null;
            string SeparadorDecimal = GetSeparatorDecimal();
            if (!string.IsNullOrEmpty(value))
            {
                ret =Convert.ToSingle(value.Replace(",", SeparadorDecimal).Replace(".", SeparadorDecimal));
            }
            
            return ret;
        }
        public static string ConvertFloatToString(float? value)
        {
            string ret = "";
            string SeparadorDecimal = GetSeparatorDecimal();
            if (value!=null)
            {
                ret = Convert.ToString(value);
                ret=ret.Replace(",", SeparadorDecimal).Replace(".", SeparadorDecimal);
            }

            return ret;
        }
        public static decimal? ConvertStringToDecimal(string value)
        {
            decimal? ret = null;
            string SeparadorDecimal = GetSeparatorDecimal();
            if (!string.IsNullOrEmpty(value))
            {
                string valuenew = "";
                string permitido = "0123456789,.";
                foreach(var c in value)
                {
                    if (permitido.Contains(c)) {
                        valuenew +=c.ToString();
                            }
                }
                ret = Convert.ToDecimal(valuenew.Replace(",", SeparadorDecimal).Replace(".", SeparadorDecimal));
            }

            return ret;
        }
        public static string ConvertDecimalToString(decimal? value)
        {
            string ret = "";
            string SeparadorDecimal = GetSeparatorDecimal();
            if (value != null)
            {
                ret = Convert.ToString(value);
                ret = ret.Replace(",", SeparadorDecimal).Replace(".", SeparadorDecimal);
            }

            return ret;
        }

        public static int? ConvertStringToInt(string value)
        {
            int? ret = null;
            string SeparadorDecimal = GetSeparatorDecimal();
            if (!string.IsNullOrEmpty(value))
            {
                ret = Convert.ToInt32("0"+value);
            }

            return ret;
        }
        public static string ConvertIntToString(int? value)
        {
            string ret = "";
            if (value != null)
            {
                ret = Convert.ToString(value);
            }

            return ret;
        }
        public static string ConvertStringToStringNull(string value)
        {
            string ret = null;
            if (!String.IsNullOrEmpty(value))
            {
                ret = value;
            }
            return ret;
        }
        public static bool ConvertBoolNullToBool(bool? value)
        {
            bool ret = false;
            if (value!=null)
            {
                ret = value.Value;
            }
            return ret;
        }
        public static bool? ConvertStringToBool(string value)
        {
            bool? ret = null;
            if (!String.IsNullOrEmpty(value))
            {
                ret = (value.ToUpper().Trim().Equals("TRUE") || value.Trim().Equals("1")) ? true : false;
            }
            return ret;
        }
        public static DateTime? GetDateOfString(string fechaString)
        {
            DateTime? date = null;
            if (!string.IsNullOrEmpty(fechaString))
            {
                try
                {
                    var auxdate = fechaString.Trim().Replace("-", "/").Split('/');
                    int anio = Convert.ToInt32(auxdate[0]);
                    int mes = Convert.ToInt32(auxdate[1]);
                    int dia = Convert.ToInt32(auxdate[2]);
                    date = new DateTime(anio, mes, dia);
                }
                catch (Exception exc) { }
            }

            return date;
        }
        public static string GetDateOfString(DateTime? date)
        {
            string ret = "";
            if (date != null)
            {
                ret = date.Value.ToString("yyyy-MM-dd");
            }
            return ret;
        }

        public static string GetStringOfTime(TimeSpan? time)
        {
            string ret = "";
            if (time != null)
            {
                ret = (time.Value.Hours.ToString()).PadLeft(2, '0') + ":" + (time.Value.Minutes.ToString()).PadLeft(2, '0');
            }
            return ret;
        }

        public static TimeSpan? GetTimeOfString(string valueTime)
        {
            TimeSpan? time = null;
            string ret = "";
            if (!string.IsNullOrEmpty(valueTime))
            {
                time= new TimeSpan(Convert.ToInt32(valueTime.Split(':')[0]) ,Convert.ToInt32 (valueTime.Split(':')[1]),0);
            }
            return time;
        }

       }
    public class ComboClassValueText
    {
        public string value { get; set; } = "";
        public string text { get; set; } = "";

    }

}
