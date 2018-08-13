using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Controlador
{
    public class ClassServiciotecnico
    {        
		
			public string uidserviciotecnico {get;set;}
			public int? codservicio {get;set;}
			public string uidcliente {get;set;}
			public string uidempleado {get;set; }
        public DateTime? fechaingreso { get; set; }
        public DateTime? fechasalida { get; set; }
        public string IMEI { get; set; }
        public string marca {get;set;}
			public string modelo {get;set;}
			public string problemasugerido {get;set;}
    }
}