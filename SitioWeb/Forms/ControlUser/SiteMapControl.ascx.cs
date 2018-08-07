using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.Forms.ControlUser
{
    public partial class SiteMapControl : System.Web.UI.UserControl
    {
        public string Sitemap { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Request.QueryString["sitemap"] as string))
            {
               
                Sitemap = Request.QueryString["sitemap"] as string;
            }
        }
    }
}
