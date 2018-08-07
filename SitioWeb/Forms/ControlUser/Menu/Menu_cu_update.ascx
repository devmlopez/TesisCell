<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Menu_CU_Update.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Menu.Menu_CU_Update" %>

<script type="text/javascript">

    function CargarModalUpdateMenu(uid) {
        var control = document.getElementById('txt_buscarUpdateUIDMenu');
        control.value = uid;
        var btnBuscarUpdateRegistro = document.getElementById('btnUpdateMenuMostrarModal');
        __doPostBack(btnBuscarUpdateRegistro.name, '');
    }
</script>
<div style="display: none;">
    <asp:TextBox ID="txt_buscarUpdateUIDMenu" runat="server" ClientIDMode="Static"></asp:TextBox>
    <asp:Button ID="btnUpdateMenuMostrarModal" runat="server" Text="MostrarModal" ClientIDMode="Static"
        OnClick="btnUpdateMenuMostrarModal_Click" />
</div>
<!-- Modal update-->
<div class="modal fade" id="Update-modal-default">
    <div class="modal-dialog modal-lg">
        <div class="modal-content">
            <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                    <span aria-hidden="true">&times;</span></button>
                <h4 class="modal-title">Actualizar Registro</h4>

            </div>
            <div class="modal-body">
                <div class="row">
                    
			  <div class="col-xs-3 oculto">
   <asp:Label ID="lbl_uidmenu_update" AssociatedControlID="txt_uidmenu_update" runat="server" Text="uidmenu <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_uidmenu_update" runat = "server" CssClass="form-control"  MaxLength="36"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidrol_update" AssociatedControlID="cb_uidrol_update" runat="server" Text="Rol <b style='color:red;'> *</b>"></asp:Label>
			  <asp:DropDownList  Enabled="true"  ID = "cb_uidrol_update" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
 </div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidpagina_update" AssociatedControlID="cb_uidpagina_update" runat="server" Text="Página <b style='color:red;'> *</b>"></asp:Label>
			  <asp:DropDownList  Enabled="true"  ID = "cb_uidpagina_update" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
 </div>
			  <div class="col-xs-3 "> 
  <asp:Label ID="lbl_esvisible_update" AssociatedControlID="checkb_esvisible_update" runat="server" Text="Visible <b style='color:red;'> *</b>"></asp:Label>
			  <asp:CheckBox  Enabled="true"  ID = "checkb_esvisible_update" runat = "server" CssClass="form-control" ></asp:CheckBox> 
</div>
			  <div class="col-xs-3 "> 
  <asp:Label ID="lbl_semuestra_update" AssociatedControlID="checkb_semuestra_update" runat="server" Text="Mostrar <b style='color:red;'> *</b>"></asp:Label>
			  <asp:CheckBox  Enabled="true"  ID = "checkb_semuestra_update" runat = "server" CssClass="form-control" ></asp:CheckBox> 
</div>

				    </div>
                <div>
                    <asp:Label runat="server" ID="lblMensajeError_update" Visible="false"></asp:Label>
                </div>
            </div>
            <div class="modal-footer">
                <asp:LinkButton runat="server" ID="btnGuardarEditar" CssClass="btn btn-primary btn-ls btn-flat" OnClick="btnGuardarEditar_Click">
         <i class="fa fa-save"></i> Guardar Cambios
                </asp:LinkButton>
                <button type="button" class="btn btn-default btn-ls btn-flat" data-dismiss="modal">Cancelar</button>
            </div>

        </div>
        <!-- /.modal-content -->
    </div>
    <!-- /.modal-dialog -->
</div>
<!-- /.modal -->
<!-- Modal update fin -->
