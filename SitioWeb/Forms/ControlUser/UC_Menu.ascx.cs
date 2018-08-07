using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser
{
    public partial class UC_Menu : System.Web.UI.UserControl
    {
        public string MenusGenerado { get; set; } = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string mensajeError = "";
                var Paginas = Controlador.SqlPagina.Select(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario,
                         new Controlador.ClassPagina(), out mensajeError);
                Session["MenusPaginas"] = Paginas;
                string _uidrol = ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidrol;
                var MenusPorRol = Controlador.SqlMenu.Select(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario,              
                new Controlador.ClassMenu()
                {
                    uidrol = _uidrol
                ,
                    esvisible = true
                }, out mensajeError);

                MenusPorRol = MenusPorRol.Where(x => x.esvisible == true).ToList();
                Session["MenusPorRol"] = MenusPorRol;
            }
            GenerarMenu();
        }

        public void GenerarMenu()
        {
            MenusGenerado = "";

           var Paginas =(List<Controlador.ClassPagina>)Session["MenusPaginas"];
            Paginas = (Paginas!=null ? Paginas : new List<Controlador.ClassPagina>());
            var NivelBase = Paginas.Where(x => string.IsNullOrEmpty(x.uidpaginapadre)).FirstOrDefault();           

            var MenusPorRol = (List<Controlador.ClassMenu>)Session["MenusPorRol"];
            var ListaUidMenuVisible = new List<string>();
            ListaUidMenuVisible =(MenusPorRol!=null? MenusPorRol.Select(x=>x.uidpagina).ToList():new List<string>());

            Paginas = Paginas.Where(x => ListaUidMenuVisible.Contains(x.uidpagina)).OrderBy(x => x.orden).ToList();
            var ListaMenuGrupoInicial = Paginas.Where(x => x.uidpaginapadre == NivelBase.uidpagina).ToList();
            foreach (var nivel1 in ListaMenuGrupoInicial)
            {
                MenusGenerado += @"<li class='treeview'>
                        <a href = '#' > 
                             <i class='" + nivel1.iconoimg + @"'></i><span>" + nivel1.pagina + @"</span>
                            <span class='pull-right-container'><i class='fa fa-angle-left pull-right'></i>
                            </span>
                        </a>
                        <ul class='treeview-menu'>";
               foreach (var nivel2 in Paginas.Where(x => x.uidpaginapadre == nivel1.uidpagina))
                {
                    var ListaHijosNivel2 = Paginas.Where(x => x.uidpaginapadre == nivel2.uidpagina);
                    bool Nivel2TieneHijos = ListaHijosNivel2.Count() > 0;
                    if (Nivel2TieneHijos == false)
                    {
                        MenusGenerado += @"<li class='active'><a href = '"+nivel2.fullurl+ @"' ><i class='" + nivel2.iconoimg + @"'></i>" + nivel2.pagina + @"</a></li>";
                    }
                    else
                    {
                        MenusGenerado += @"<li class='treeview'>
                        <a href = '#' > 
                             <i class='" + nivel2.iconoimg + @"'></i><span>" + nivel2.pagina + @"</span>
                            <span class='pull-right-container'><i class='fa fa-angle-left pull-right'></i>
                            </span>
                        </a>
                        <ul class='treeview-menu'>";
                        MenusGenerado += @" </ul>
                    </li>";
                    }
                }
                MenusGenerado += @" </ul>
                    </li>";
            }
        }
    }
}