<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MenuRol.aspx.cs" Inherits="SitioWeb.Forms.MenuRol" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .nodechecked a{
          padding-left:10px!important;
        }          
    </style>
     <script src="https://code.jquery.com/jquery-1.10.2.js"></script>
  <script>
 
  $(function() {
    // BloquearCheck();
  });
 
  </script>
     <script type="text/javascript">

     function postBackByObject()
     {
         var o = window.event.srcElement;
         if (o.tagName == "INPUT" && o.type == "checkbox")
        {
           __doPostBack("","");
        }
    }
   </script>
    <script>
      
        function BloquearCheck() {
          //  var inputcheck = $('.nodechecked input').prop('disabled', true);
        };

     //  var btn= $('.nodechecked input').click();
        </script>
      <section class="content-wrapper">
    <!-- Main content -->
    <section class="content">
    <div class="row">

         <div class="box">
                <div class="box-header">
                    <h3 class="box-title">Asignación de Menus</h3>
                </div>
                <!-- /.box-header -->
                <div class="box-body">

        <div class="col-md-12">
        <div class="col-md-6">
             <div class="row">
                 <asp:Label ID="Label1" runat="server" Text="Rol:" AssociatedControlID="cbRol"></asp:Label>
                 <asp:DropDownList ID="cbRol" runat="server" OnSelectedIndexChanged="cbRol_SelectedIndexChanged"
                      AutoPostBack="true"  ></asp:DropDownList>
                 </div>
             <div class="row">
                 <h3>Asignar Menús</h3><br />
                 <asp:TreeView ID="tvMenuRol" runat="server" OnTreeNodeCheckChanged="tvMenuRol_TreeNodeCheckChanged"
                    OnSelectedNodeChanged="tvMenuRol_SelectedNodeChanged" OnTreeNodePopulate="tvMenuRol_TreeNodePopulate" >
                     <NodeStyle CssClass="nodechecked" />                     
                 </asp:TreeView>
                 </div>
        </div>
         <div class="col-md-6">
              <div class="row">
                 </div>
              <div class="row">
                 </div>
         </div>
    
        </div>
</div>
             </div>
        
    </div>
             </section>
    </section>
</asp:Content>
