using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Controlador
{
    public class ClassProducto
    {        
		
			public string uidproducto {get;set;}
			public string uidcategoriaproducto {get;set;}
			public int? codproducto {get;set;}
			public string nombre {get;set;}
			public string dimensiones {get;set;}
			public int? cantidad {get;set;}
			public decimal? precio1 {get;set;}
			public decimal? precio2 {get;set;}
			public decimal? precio3 {get;set;}
			public decimal? precio4 {get;set;}   
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