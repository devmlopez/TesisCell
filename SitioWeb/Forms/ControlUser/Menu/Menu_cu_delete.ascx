<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Menu_CU_Delete.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Menu.Menu_CU_Delete" %>
<script type="text/javascript">

    function CargarModalDeleteMenu(uid) {
        var control = document.getElementById('txt_buscarDeleteUIDMenu');
        control.value = uid;
        var btnBuscarDeleteRegistro = document.getElementById('btnDeleteMenuMostrarModal');        
        __doPostBack(btnBuscarDeleteRegistro.name, '');
    }
</script>



<div style="display: none;">
    <asp:TextBox ID="txt_buscarDeleteUIDMenu" runat="server" ClientIDMode="Static"></asp:TextBox>
    <asp:Button ID="btnDeleteMenuMostrarModal" runat="server" Text="MostrarModal" ClientIDMode="Static"
        OnClick="btnDeleteMenuMostrarModal_Click" />
</div>

  <!-- Modal Delete-->
    <div class="modal fade" id="Delete-modal-default">
        <div class="modal-dialog modal-lg">
            <div class="modal-content">
               
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">&times;</span></button>
                            <h4 class="modal-title">Eliminar Registro</h4>
                        </div>
                        <div class="modal-body">
                            <div>
                                  <div class="row">

								  
			  <div class="col-xs-3 oculto">
   <asp:Label ID="lbl_uidmenu_delete" AssociatedControlID="txt_uidmenu_delete" runat="server" Text="uidmenu <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_uidmenu_delete" runat = "server" CssClass="form-control"  MaxLength="36"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidrol_delete" AssociatedControlID="cb_uidrol_delete" runat="server" Text="Rol <b style='color:red;'> *</b>"></asp:Label>
			  <asp:DropDownList  Enabled="false"  ID = "cb_uidrol_delete" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
 </div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidpagina_delete" AssociatedControlID="cb_uidpagina_delete" runat="server" Text="Página <b style='color:red;'> *</b>"></asp:Label>
			  <asp:DropDownList  Enabled="false"  ID = "cb_uidpagina_delete" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
 </div>
			  <div class="col-xs-3 "> 
  <asp:Label ID="lbl_esvisible_delete" AssociatedControlID="checkb_esvisible_delete" runat="server" Text="Visible <b style='color:red;'> *</b>"></asp:Label>
			  <asp:CheckBox  Enabled="false"  ID = "checkb_esvisible_delete" runat = "server" CssClass="form-control" ></asp:CheckBox> 
</div>
			  <div class="col-xs-3 "> 
  <asp:Label ID="lbl_semuestra_delete" AssociatedControlID="checkb_semuestra_delete" runat="server" Text="Mostrar <b style='color:red;'> *</b>"></asp:Label>
			  <asp:CheckBox  Enabled="false"  ID = "checkb_semuestra_delete" runat = "server" CssClass="form-control" ></asp:CheckBox> 
</div>
                </div>
                               <div>
                    <asp:Label runat="server" ID="lblMensajeError_delete" Visible="false"></asp:Label>
                </div>
                                  <br /><h4>
                                Esta seguro que desea eliminar este registro?</h4>
                                <br />
                              
                            </div>
                        </div>
                        <div class="modal-footer">
                            <asp:LinkButton runat="server" ID="btnGuardarEliminar" CssClass="btn btn-primary btn-ls btn-flat" OnClick="btnGuardarEliminar_Click">
         <i class="fa fa-save"></i> Eliminar
                            </asp:LinkButton>
                            <button type="button" class="btn btn-default btn-ls btn-flat" data-dismiss="modal">Cancelar</button>

                        </div>
                    
            </div>
            <!-- /.modal-content -->
        </div>
        <!-- /.modal-dialog -->
    </div>
    <!-- /.modal -->
    <!-- Modal Delete fin -->	
