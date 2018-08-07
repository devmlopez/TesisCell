<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Menu_CU_Select.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Menu.Menu_CU_MostrarUnico" %>

<script type="text/javascript">

    function CargarModalSelectMenu(uid) {
        var control = document.getElementById('txt_buscarSelectUIDMenu');
        control.value = uid;
        var btnBuscarSelectRegistro = document.getElementById('btnSelectMenuMostrarModal');        
        __doPostBack(btnBuscarSelectRegistro.name, '');
    }
</script>


<div style="display: none;">
    <asp:TextBox ID="txt_buscarSelectUIDMenu" runat="server" ClientIDMode="Static"></asp:TextBox>
    <asp:Button ID="btnSelectMenuMostrarModal" runat="server" Text="MostrarModal" ClientIDMode="Static"
        OnClick="btnSelectMenuMostrarModal_Click" />
</div>


<%if(EsModal==true)
    {%>
	<!-- Modal Select -->
        <div class="modal fade" id="Select-modal-default-Menu">
            <div class="modal-dialog modal-lg">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span></button>
                        <h4 class="modal-title">Consultar Registro</h4>
                    </div>
                    <div class="modal-body">
                        <%} %>


     <div class="row">
                          
			  <div class="col-xs-3 oculto">
   <asp:Label ID="lbl_uidmenu_select" AssociatedControlID="txt_uidmenu_select" runat="server" Text="uidmenu <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_uidmenu_select" runat = "server" CssClass="form-control"  MaxLength="36"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidrol_select" AssociatedControlID="cb_uidrol_select" runat="server" Text="Rol <b style='color:red;'> *</b>"></asp:Label>
			  <asp:DropDownList  Enabled="false"  ID = "cb_uidrol_select" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
 </div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidpagina_select" AssociatedControlID="cb_uidpagina_select" runat="server" Text="Página <b style='color:red;'> *</b>"></asp:Label>
			  <asp:DropDownList  Enabled="false"  ID = "cb_uidpagina_select" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
 </div>
			  <div class="col-xs-3 "> 
  <asp:Label ID="lbl_esvisible_select" AssociatedControlID="checkb_esvisible_select" runat="server" Text="Visible <b style='color:red;'> *</b>"></asp:Label>
			  <asp:CheckBox  Enabled="false"  ID = "checkb_esvisible_select" runat = "server" CssClass="form-control" ></asp:CheckBox> 
</div>
			  <div class="col-xs-3 "> 
  <asp:Label ID="lbl_semuestra_select" AssociatedControlID="checkb_semuestra_select" runat="server" Text="Mostrar <b style='color:red;'> *</b>"></asp:Label>
			  <asp:CheckBox  Enabled="false"  ID = "checkb_semuestra_select" runat = "server" CssClass="form-control" ></asp:CheckBox> 
</div>

                        </div>
                   
				          <%if(EsModal==true)
    {%>
                          </div>
                    <div class="modal-footer">
                       
                        <button type="button" class="btn btn-default btn-ls btn-flat" data-dismiss="modal">Cerrar</button>
                    </div>
                </div>
                <!-- /.modal-content -->
            </div>
            <!-- /.modal-dialog -->
        </div>
        <!-- /.modal -->
        <!-- Modal Insert fin -->
   <%} %>


