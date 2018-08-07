using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb
{
    public partial class Site : System.Web.UI.MasterPage
    {
        public bool? EstamosEnFolderForm { get; set; } = false;
       
        protected void Page_Load(object sender, EventArgs e)
        {
            EstamosEnFolderForm = Request.Url.ToString().ToUpper().Contains("/FORMS/");

        }
        public Controlador.ClassLoginuser GetUserData()
        {
          return  ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser;
        }

        protected void btnSignOut_Click(object sender, EventArgs e)
        {
            ClasesUtiles.SessionClass.SetLoginUser(Page,null);
        }
    }
}