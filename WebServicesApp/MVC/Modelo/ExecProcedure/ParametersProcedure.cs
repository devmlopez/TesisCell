using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Modelo.ExecProcedure
{
    public class ParametersProcedure
    {
        public string Parameter { get; set; } = "";
        public object Value { get; set; } = null;
        public string TypeDate { get; set; } = "System.String";
        public OrentationType Orientation { get; set; } = OrentationType.In;
        public ParametersProcedure()
        {

        }
        public ParametersProcedure(string Parameter, object Value, string TypeDate, OrentationType Orientation)
        {
            this.Parameter = Parameter; this.Value = Value; this.TypeDate = TypeDate; this.Orientation = Orientation;
        }
    }
    public enum OrentationType
    {
        In = 0,
        Out = 1,
        InOut = 2
    }

}