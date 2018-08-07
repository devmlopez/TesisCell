using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
namespace SitioWeb.ClasesUtiles
{
    public class LoginUser
    {
        public bool EstaConectado { get; set; } = false;
        public string uidloginuser { get; set; }
        public string uidrol { get; set; }
        public Controlador.ClassLoginuser classLoginUser { get; set; } = new Controlador.ClassLoginuser() { uidsuario = "" };
        public List<Controlador.ClassGrupo> classGrupos { get; set; } = new List<Controlador.ClassGrupo>();
        public Controlador.ClassRol ClassRol { get; set; } = new Controlador.ClassRol();
        //public List<Controlador.ClassGrupousuario> classGrupoUsuarios { get; set; } = new List<Controlador.ClassGrupousuario>();
        public List<Controlador.ClassPagina> ClassPaginas { get; set; } = new List<Controlador.ClassPagina>();

        public List<UsuarioReferencia> UsuarioReferencia { get; set; } = new List<UsuarioReferencia>();

       // public Controlador.ClassRol classRol { get; set; } = new Controlador.ClassRol();


        public void ValidarUserLogin(Page page, string user, string password)
        {

            var cc = new SitioWeb.Controlador.ClassLoginuser() { usuario = user, contrasenia = password };
            string retorno = "";
            var values = Controlador.SqlLoginuser.Select("", cc, out retorno);
            if (values.Count() > 0)
            {
                var value = values.FirstOrDefault();
                var loginUser = new LoginUser();
                loginUser.classLoginUser = value;
                loginUser.classLoginUser.email = value.email;
                #region Rol
                loginUser.ClassRol = Controlador.SqlRol.SelectFirst(user, loginUser.classLoginUser.uidrol, out  retorno);
                #endregion
                #region GRupo
                var GrupoUsuarios = Controlador.SqlGrupousuario.Select(user, new Controlador.ClassGrupousuario() { uidusuario = value.uidsuario }, out retorno);

                foreach (var item in GrupoUsuarios)
                {
                    var grupo = Controlador.SqlGrupo.SelectFirst(user, item.uidgrupo , out retorno);
                    loginUser.classGrupos.Add(grupo);
                }
                #endregion
                #region Paginas

                foreach (var item in loginUser.classGrupos)
                {
                    var paginasGrupos = Controlador.SqlPaginagrupo.Select(user, new Controlador.ClassPaginagrupo() { uidgrupo = item.uidgrupo }, out retorno);
                    foreach (var pagina in paginasGrupos)
                    {
                        var ExistePagina= loginUser.ClassPaginas.Where(x=>x.uidpagina==pagina.uidpagina).Count()>0;
                        if (ExistePagina == false)
                        {
                            var pag = Controlador.SqlPagina.SelectFirst(user, pagina.uidpagina, out retorno);
                            loginUser.ClassPaginas.Add(pag);
                        }
                    }
                }
                #endregion

                #region UsuarioReferencia
                var _Usuario = Controlador.SqlLoginuser.Select(user,new Controlador.ClassLoginuser() { uidsuario=user }, out retorno);
                var _Cliente = Controlador.SqlCliente.Select(user, new Controlador.ClassCliente() { uidcliente = user }, out retorno);
                var _Proveedor = Controlador.SqlProveedor.Select(user, new Controlador. ClassProveedor() { uidproveedor = user }, out retorno);

                loginUser.UsuarioReferencia = new List<ClasesUtiles.UsuarioReferencia>();
                foreach (var item in _Usuario)
                {
                    loginUser.UsuarioReferencia.Add(new ClasesUtiles.UsuarioReferencia() { uidReferencia = item.uidsuario, NombreReferencia = item.nombre });
                }
                foreach (var item in _Cliente)
                {
                    loginUser.UsuarioReferencia.Add(new ClasesUtiles.UsuarioReferencia() { uidReferencia = item.uidcliente, NombreReferencia = item.nombre });
                }
                foreach (var item in _Proveedor)
                {
                    loginUser.UsuarioReferencia.Add(new ClasesUtiles.UsuarioReferencia() { uidReferencia = item.uidproveedor, NombreReferencia = item.nombre });
                }
                #endregion
                loginUser.EstaConectado = true;
                SessionClass.SetLoginUser(page, loginUser);               
            }
            else
            {               
            }

        }
    }

    public class UsuarioReferencia
    {
        public string uidReferencia { get; set; }
        public string NombreReferencia { get; set; }
    }
    public class SessionClass
    {
        public static LoginUser GetLoginUser(Page page)
        {
            LoginUser ret = null;
            try
            {
                ret = (LoginUser)page.Session["LoginUser"];
                if (ret == null)
                {
                    page.Response.Redirect("~/Login.aspx");
                }
            }
            catch (Exception exc)
            {
            }
            return ret;
        }
        public static void SetLoginUser(Page page, LoginUser loginUser)
        {
            try
            {
                page.Session["LoginUser"] = loginUser;
            }
            catch (Exception exc)
            {
            }
        }

    }
}