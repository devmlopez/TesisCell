using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Controlador
{
    public class ClassFacturaventa
    {        
		
			public string uidfacturaventa {get;set;}
			public string establecimiento {get;set;}
			public string puntoemision {get;set;}
			public string secuencial {get;set;}
			public string uidusuario {get;set;}
			public string uidcliente {get;set;}
			public DateTime? fechafactura {get;set;}
			public decimal? subtotal {get;set;}
			public decimal? iva_porc {get;set;}
			public decimal? iva_valor {get;set;}
			public decimal? descuentos {get;set;}
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