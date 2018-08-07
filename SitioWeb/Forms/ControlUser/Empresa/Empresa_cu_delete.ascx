<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Empresa_CU_Delete.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Empresa.Empresa_CU_Delete" %>
<script type="text/javascript">

    function CargarModalDeleteEmpresa(uid) {
        var control = document.getElementById('txt_buscarDeleteUIDEmpresa');
        control.value = uid;
        var btnBuscarDeleteRegistro = document.getElementById('btnDeleteEmpresaMostrarModal');        
        __doPostBack(btnBuscarDeleteRegistro.name, '');
    }
</script>



<div style="display: none;">
    <asp:TextBox ID="txt_buscarDeleteUIDEmpresa" runat="server" ClientIDMode="Static"></asp:TextBox>
    <asp:Button ID="btnDeleteEmpresaMostrarModal" runat="server" Text="MostrarModal" ClientIDMode="Static"
        OnClick="btnDeleteEmpresaMostrarModal_Click" />
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
   <asp:Label ID="lbl_uid_empresa_delete" AssociatedControlID="txt_uid_empresa_delete" runat="server" Text="uid_empresa <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_uid_empresa_delete" runat = "server" CssClass="form-control"  MaxLength="36"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_ruc_delete" AssociatedControlID="txt_ruc_delete" runat="server" Text="Ruc <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_ruc_delete" runat = "server" CssClass="form-control"  MaxLength="13"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_nombre_delete" AssociatedControlID="txt_nombre_delete" runat="server" Text="Nombre <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_nombre_delete" runat = "server" CssClass="form-control"  MaxLength="50"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_descripcion_delete" AssociatedControlID="txt_descripcion_delete" runat="server" Text="Descripción <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_descripcion_delete" runat = "server" CssClass="form-control"  MaxLength="500"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_direccion_delete" AssociatedControlID="txt_direccion_delete" runat="server" Text="Dirección <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_direccion_delete" runat = "server" CssClass="form-control"  MaxLength="500"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_telefono_delete" AssociatedControlID="txt_telefono_delete" runat="server" Text="Teléfono <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_telefono_delete" runat = "server" CssClass="form-control"  MaxLength="30"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_representantelegal_delete" AssociatedControlID="txt_representantelegal_delete" runat="server" Text="Representante Légal <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_representantelegal_delete" runat = "server" CssClass="form-control"  MaxLength="50"   Width="100 %"></asp:TextBox> 
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
