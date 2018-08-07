<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Empresa_CU_Insert.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Empresa.Empresa_CU_Insert" %>
<%@ Register Src="~/Forms/ControlUser/MsgControl.ascx" TagPrefix="uc1" TagName="MsgControl" %>
        
		
		<a href="#" class="btn btn-default btn-xs btn-flat" data-toggle="modal" data-target="#Inser-modal-default">
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
   <asp:Label ID="lbl_uid_empresa_insert" AssociatedControlID="txt_uid_empresa_insert" runat="server" Text="uid_empresa <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_uid_empresa_insert" runat = "server" CssClass="form-control"  MaxLength="36"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_ruc_insert" AssociatedControlID="txt_ruc_insert" runat="server" Text="Ruc <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_ruc_insert" runat = "server" CssClass="form-control"  MaxLength="13"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_nombre_insert" AssociatedControlID="txt_nombre_insert" runat="server" Text="Nombre <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_nombre_insert" runat = "server" CssClass="form-control"  MaxLength="50"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_descripcion_insert" AssociatedControlID="txt_descripcion_insert" runat="server" Text="Descripción <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_descripcion_insert" runat = "server" CssClass="form-control"  MaxLength="500"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_direccion_insert" AssociatedControlID="txt_direccion_insert" runat="server" Text="Dirección <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_direccion_insert" runat = "server" CssClass="form-control"  MaxLength="500"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_telefono_insert" AssociatedControlID="txt_telefono_insert" runat="server" Text="Teléfono <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_telefono_insert" runat = "server" CssClass="form-control"  MaxLength="30"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_representantelegal_insert" AssociatedControlID="txt_representantelegal_insert" runat="server" Text="Representante Légal <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_representantelegal_insert" runat = "server" CssClass="form-control"  MaxLength="50"   Width="100 %"></asp:TextBox> 
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
