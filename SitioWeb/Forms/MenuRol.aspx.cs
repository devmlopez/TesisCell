using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms
{
    public partial class MenuRol : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarCombo();
            }
            tvMenuRol.Attributes.Add("onclick", "postBackByObject()");
        }
        private void CargarCombo()
        {
            string mensajeError = "";
            var Roles = Controlador.SqlRol.Select(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario,
                          new Controlador.ClassRol(), out mensajeError);
            Roles = Roles.OrderBy(x => x.rol).ToList();
            cbRol.DataSource = Roles;
            cbRol.DataValueField = "uidrol";
            cbRol.DataTextField = "rol";
            cbRol.DataBind();
        }
        protected void cbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarTreeViewAsignarMenus();
        }
        private void CargarTreeViewAsignarMenus()
        {
            tvMenuRol.Nodes.Clear();
            tvMenuRol.ExpandAll();
            string mensajeError = "";
            var Paginas = Controlador.SqlPagina.Select(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario,
                          new Controlador.ClassPagina(), out mensajeError);
            var NivelBase = Paginas.Where(x => string.IsNullOrEmpty(x.uidpaginapadre)).FirstOrDefault();
            Paginas = Paginas.OrderBy(x => x.orden).ToList();
            tvMenuRol.ShowCheckBoxes = TreeNodeTypes.All;

            #region Buscar Menus asignados
            var MenusPorRol = Controlador.SqlMenu.Select(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario,
                  new Controlador.ClassMenu() { uidrol=cbRol.SelectedValue as  string }, out mensajeError);
            #endregion

            //Nivel 1
            foreach (var item in Paginas)
            {
                if (item.uidpaginapadre == NivelBase.uidpagina)
                {
                    var node = new TreeNode(item.pagina, item.uidpagina);                   
                    if (MenusPorRol.Where(x => x.uidpagina == item.uidpagina && x.esvisible == true).Count() > 0)
                    {
                        node.Checked = true;
                    }
                 
                    tvMenuRol.Nodes.Add(node);
                }
            }
            //Nivel 2
            foreach (TreeNode tn1 in tvMenuRol.Nodes)
            {
                foreach (var pag in Paginas)
                {
                    if (tn1.Value == pag.uidpaginapadre)
                    {
                        var node = new TreeNode(pag.pagina, pag.uidpagina);
                        if (MenusPorRol.Where(x => x.uidpagina == pag.uidpagina && x.esvisible == true).Count() > 0)
                        {
                            node.Checked = true;
                        }
                        tn1.ChildNodes.Add(node);
                    }
                }
            }
            //Nivel 3
            foreach (TreeNode tn1 in tvMenuRol.Nodes)
            {
                foreach (TreeNode tn2 in tn1.ChildNodes)
                {
                    foreach (var pag in Paginas)
                    {
                        if (tn2.Value == pag.uidpaginapadre)
                        {
                            var node = new TreeNode(pag.pagina, pag.uidpagina);
                            if (MenusPorRol.Where(x => x.uidpagina == pag.uidpagina && x.esvisible == true).Count() > 0)
                            {
                                node.Checked = true;
                            }
                            tn2.ChildNodes.Add(node);
                            // tn2.ChildNodes.Add(new TreeNode(pag.pagina, pag.uidpagina));
                        }
                    }
                }
            }
            //Nivel 4
            foreach (TreeNode tn1 in tvMenuRol.Nodes)
            {
                foreach (TreeNode tn2 in tn1.ChildNodes)
                {
                    foreach (TreeNode tn3 in tn1.ChildNodes)
                    {
                        foreach (var pag in Paginas)
                        {
                            if (tn3.Value == pag.uidpaginapadre)
                            {
                                var node = new TreeNode(pag.pagina, pag.uidpagina);
                                if (MenusPorRol.Where(x => x.uidpagina == pag.uidpagina && x.esvisible == true).Count() > 0)
                                {
                                    node.Checked = true;
                                }
                                tn3.ChildNodes.Add(node);
                               // tn3.ChildNodes.Add(new TreeNode(pag.pagina, pag.uidpagina));
                            }
                        }
                    }
                }
            }
            //Nivel 5
            foreach (TreeNode tn1 in tvMenuRol.Nodes)
            {
                foreach (TreeNode tn2 in tn1.ChildNodes)
                {
                    foreach (TreeNode tn3 in tn1.ChildNodes)
                    {
                        foreach (TreeNode tn4 in tn1.ChildNodes)
                        {
                            foreach (var pag in Paginas)
                            {
                                if (tn4.Value == pag.uidpaginapadre)
                                {
                                    var node = new TreeNode(pag.pagina, pag.uidpagina);
                                    if (MenusPorRol.Where(x => x.uidpagina == pag.uidpagina && x.esvisible == true).Count() > 0)
                                    {
                                        node.Checked = true;
                                    }
                                    tn4.ChildNodes.Add(node);
                                   // tn4.ChildNodes.Add(new TreeNode(pag.pagina, pag.uidpagina));
                                }
                            }
                        }

                    }

                }
            }

            tvMenuRol.DataBind();
        }

        public void GuardarCambiosAsignarMenus()
        {
            List<string> ListaUIDSeleccionados = new List<string>();           

            string mensajeError = "";
                       
        
            //#region Listando Los UID
            //foreach (TreeNode tn1 in tvMenuRol.Nodes)
            //{
            //    ListaUIDSeleccionados.Add(tn1.Value);
            //    foreach (TreeNode tn2 in tn1.ChildNodes)
            //    {
            //        ListaUIDSeleccionados.Add(tn2.Value);
            //        foreach (TreeNode tn3 in tn1.ChildNodes)
            //        {
            //            ListaUIDSeleccionados.Add(tn3.Value);
            //            foreach (TreeNode tn4 in tn1.ChildNodes)
            //            {
            //                foreach (TreeNode tn5 in tn1.ChildNodes)
            //                {
            //                    ListaUIDSeleccionados.Add(tn5.Value);
            //                }
            //            }
            //        }

            //    }
            //}
            //#endregion

        }

        protected void tvMenuRol_TreeNodeCheckChanged(object sender, TreeNodeEventArgs e)
        {
           string _uidpagina= e.Node.Value;
            string udrol = cbRol.SelectedValue as string;
            CambiarChecked((TreeView)sender, e.Node.Checked, _uidpagina, udrol);
        }

        protected void tvMenuRol_SelectedNodeChanged(object sender, EventArgs e)
        {
            var obj = (TreeView)sender;
            obj.SelectedNode.Checked = !obj.SelectedNode.Checked;
            CambiarChecked(obj, obj.SelectedNode.Checked, obj.SelectedNode.Value, cbRol.SelectedValue as string);
        }
        private void CambiarChecked(TreeView obj,bool Checked,string _uidpagina, string udrol)
        {
            bool EstaSeleccionado = Checked;
            #region Buscar Menus asignados
            string mensajeError = "";
            var MenusPorRol = Controlador.SqlMenu.Select(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario,
                  new Controlador.ClassMenu()
                  {
                      uidpagina = _uidpagina,
                      uidrol = cbRol.SelectedValue as string
                  },
                  out mensajeError);

            if (MenusPorRol.Count() > 0)
            {
                var menuEditar = MenusPorRol[0];
                menuEditar.esvisible = EstaSeleccionado;
                Controlador.SqlMenu.Update(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario,
                    menuEditar
                    , out mensajeError);
            }
            else
            {
                Controlador.SqlMenu.InsertInto(ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidsuario,
                    new Controlador.ClassMenu()
                    {
                        uidmenu = Guid.NewGuid().ToString(),
                        uidpagina = _uidpagina,
                        uidrol = cbRol.SelectedValue as string,
                        esvisible = EstaSeleccionado,
                        semuestra = false
                    }
                    , out mensajeError);
            }
            #endregion
        }

        protected void tvMenuRol_TreeNodePopulate(object sender, TreeNodeEventArgs e)
        {

        }
    }
}