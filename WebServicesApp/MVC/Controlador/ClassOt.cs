using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Controlador
{
    public class ClassOt
    {        
		
			public string uidot {get;set;}
			public string uidvendedor {get;set;}
			public int? cod_ot {get;set;}
			public string uidcliente {get;set;}
			public DateTime? fechaapertura {get;set;}
			public DateTime? fechacierre {get;set;}
			public string uidestado {get;set;}
			public decimal? subtotal {get;set;}
			public decimal? descuentos {get;set;}
			public decimal? impuestos {get;set;}
			public decimal? iva {get;set;}
			public decimal? total {get;set;}   
		public string aux1 { get; set; }
        public string aux2 { get; set; }
        public string aux3 { get; set; }
        public string aux4 { get; set; }
        public string aux5 { get; set; }
        public string aux6 { get; set; }
        public string aux7 { get; set; } 
        public string aux8 { get; set; }
        public string aux9 { get; set; }
        public string aux10 { get; set; }
    }
}