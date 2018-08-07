<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Empresa_CU_Update.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Empresa.Empresa_CU_Update" %>

<script type="text/javascript">

    function CargarModalUpdateEmpresa(uid) {
        var control = document.getElementById('txt_buscarUpdateUIDEmpresa');
        control.value = uid;
        var btnBuscarUpdateRegistro = document.getElementById('btnUpdateEmpresaMostrarModal');
        __doPostBack(btnBuscarUpdateRegistro.name, '');
    }
</script>
<div style="display: none;">
    <asp:TextBox ID="txt_buscarUpdateUIDEmpresa" runat="server" ClientIDMode="Static"></asp:TextBox>
    <asp:Button ID="btnUpdateEmpresaMostrarModal" runat="server" Text="MostrarModal" ClientIDMode="Static"
        OnClick="btnUpdateEmpresaMostrarModal_Click" />
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
   <asp:Label ID="lbl_uid_empresa_update" AssociatedControlID="txt_uid_empresa_update" runat="server" Text="uid_empresa <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_uid_empresa_update" runat = "server" CssClass="form-control"  MaxLength="36"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_ruc_update" AssociatedControlID="txt_ruc_update" runat="server" Text="Ruc <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_ruc_update" runat = "server" CssClass="form-control"  MaxLength="13"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_nombre_update" AssociatedControlID="txt_nombre_update" runat="server" Text="Nombre <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_nombre_update" runat = "server" CssClass="form-control"  MaxLength="50"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_descripcion_update" AssociatedControlID="txt_descripcion_update" runat="server" Text="Descripción <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_descripcion_update" runat = "server" CssClass="form-control"  MaxLength="500"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_direccion_update" AssociatedControlID="txt_direccion_update" runat="server" Text="Dirección <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_direccion_update" runat = "server" CssClass="form-control"  MaxLength="500"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_telefono_update" AssociatedControlID="txt_telefono_update" runat="server" Text="Teléfono <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_telefono_update" runat = "server" CssClass="form-control"  MaxLength="30"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_representantelegal_update" AssociatedControlID="txt_representantelegal_update" runat="server" Text="Representante Légal <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_representantelegal_update" runat = "server" CssClass="form-control"  MaxLength="50"   Width="100 %"></asp:TextBox> 
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
