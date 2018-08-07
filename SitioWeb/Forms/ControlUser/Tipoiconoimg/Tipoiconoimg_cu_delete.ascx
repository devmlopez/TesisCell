<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Tipoiconoimg_CU_Delete.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Tipoiconoimg.Tipoiconoimg_CU_Delete" %>
<script type="text/javascript">

    function CargarModalDeleteTipoiconoimg(uid) {
        var control = document.getElementById('txt_buscarDeleteUIDTipoiconoimg');
        control.value = uid;
        var btnBuscarDeleteRegistro = document.getElementById('btnDeleteTipoiconoimgMostrarModal');        
        __doPostBack(btnBuscarDeleteRegistro.name, '');
    }
</script>



<div style="display: none;">
    <asp:TextBox ID="txt_buscarDeleteUIDTipoiconoimg" runat="server" ClientIDMode="Static"></asp:TextBox>
    <asp:Button ID="btnDeleteTipoiconoimgMostrarModal" runat="server" Text="MostrarModal" ClientIDMode="Static"
        OnClick="btnDeleteTipoiconoimgMostrarModal_Click" />
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
   <asp:Label ID="lbl_uidtipoiconoimg_delete" AssociatedControlID="txt_uidtipoiconoimg_delete" runat="server" Text="uidtipoiconoimg <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_uidtipoiconoimg_delete" runat = "server" CssClass="form-control"  MaxLength="36"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_tipoiconoimg_delete" AssociatedControlID="txt_tipoiconoimg_delete" runat="server" Text="Tipo Imagen <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_tipoiconoimg_delete" runat = "server" CssClass="form-control"  MaxLength="100"   Width="100 %"></asp:TextBox> 
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
