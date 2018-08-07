<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Menu_CU_Insert.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Menu.Menu_CU_Insert" %>
<%@ Register Src="~/Forms/ControlUser/MsgControl.ascx" TagPrefix="uc1" TagName="MsgControl" %>
        
		
		<a href="#" class="btn btn-default btn-xs btn-flat botonOpcionesControlUserClass" data-toggle="modal" data-target="#Inser-modal-default">
            <i class="fa fa-file-o"></i>Agregar
        </a>
		<!-- Modal Insert -->
        <div class="modal fade" id="Inser-modal-default">
            <div class="modal-dialog modal-lg">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span></button>
                        <h4 class="modal-title">Agregar Registro</h4>
                    </div>
                    <div class="modal-body">
                        <div class="row">
                            
                            
			  <div class="col-xs-3 oculto">
   <asp:Label ID="lbl_uidmenu_insert" AssociatedControlID="txt_uidmenu_insert" runat="server" Text="uidmenu <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_uidmenu_insert" runat = "server" CssClass="form-control"  MaxLength="36"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidrol_insert" AssociatedControlID="cb_uidrol_insert" runat="server" Text="Rol <b style='color:red;'> *</b>"></asp:Label>
			  <asp:DropDownList  Enabled="true"  ID = "cb_uidrol_insert" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
 </div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidpagina_insert" AssociatedControlID="cb_uidpagina_insert" runat="server" Text="Página <b style='color:red;'> *</b>"></asp:Label>
			  <asp:DropDownList  Enabled="true"  ID = "cb_uidpagina_insert" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
 </div>
			  <div class="col-xs-3 "> 
  <asp:Label ID="lbl_esvisible_insert" AssociatedControlID="checkb_esvisible_insert" runat="server" Text="Visible <b style='color:red;'> *</b>"></asp:Label>
			  <asp:CheckBox  Enabled="true"  ID = "checkb_esvisible_insert" runat = "server" CssClass="form-control" ></asp:CheckBox> 
</div>
			  <div class="col-xs-3 "> 
  <asp:Label ID="lbl_semuestra_insert" AssociatedControlID="checkb_semuestra_insert" runat="server" Text="Mostrar <b style='color:red;'> *</b>"></asp:Label>
			  <asp:CheckBox  Enabled="true"  ID = "checkb_semuestra_insert" runat = "server" CssClass="form-control" ></asp:CheckBox> 
</div>

                        </div>
                        <div>
                            <asp:Label runat="server" ID="lblMensajeError_Insert" Visible="false"></asp:Label>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <asp:LinkButton runat="server" ID="btnGuardarNuevo" CssClass="btn btn-primary btn-ls btn-flat" OnClick="btnGuardarNuevo_Click">
                        <i class="fa fa-save"></i> Guardar
                        </asp:LinkButton>
                        <button type="button" class="btn btn-default btn-ls btn-flat" data-dismiss="modal">Cancelar</button>
                    </div>
                </div>
                <!-- /.modal-content -->
            </div>
            <!-- /.modal-dialog -->
        </div>
        <!-- /.modal -->
        <!-- Modal Insert fin -->
