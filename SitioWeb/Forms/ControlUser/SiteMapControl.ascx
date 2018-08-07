<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SiteMapControl.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.SiteMapControl" %>


 <% if (!string.IsNullOrEmpty(Sitemap)) { %>
<div class="container">
 
      <%
          // se espera el siguiente formato sitemap=Nombre1#url1|Nombre2#url2|...
           Sitemap = Sitemap.Replace(">question>", "?");
          Sitemap = Sitemap.Replace(">separator>", "#");
          Sitemap = Sitemap.Replace(">equals>", "=");
          Sitemap = Sitemap.Replace(">and>", "&");
          var ListaSiteMap = (Sitemap.Split('|'));
          foreach (var sitio in ListaSiteMap)
          {
              var campos = (sitio + "###").Split('#');
              string Nombre = campos[0];
              string Url = campos[1];
          %>
    
           <a href="<%=Url %>" class="btn btn-link" style="padding-top:20px;"><%=Nombre %></a>/        <% } %>
  
</div>
   <% } %>

<!-- /container -->