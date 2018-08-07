using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            ClasesUtiles.LoginUser lu = new ClasesUtiles.LoginUser();
            string user = txtUsuario.Text;
            string password = txtPassword.Text;
            lu.ValidarUserLogin(Page,user,password);

            var EstaConectado = ClasesUtiles.SessionClass.GetLoginUser(Page).EstaConectado;
            if (EstaConectado == true)
            {
                Page.Response.Redirect("~/forms/DashBoard.aspx");
            }
           
        }
    }
}