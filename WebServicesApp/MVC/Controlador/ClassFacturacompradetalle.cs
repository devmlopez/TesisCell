using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Controlador
{
    public class ClassFacturacompradetalle
    {        
		
			public string uidfactcompradetalle {get;set;}
			public string uidfacturacompra {get;set;}
			public int? secuencial {get;set;}
			public int? item {get;set;}
			public string uidproducto {get;set;}
			public int? cantidad {get;set;}
			public decimal? preciounitario {get;set;}
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