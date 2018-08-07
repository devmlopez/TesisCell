<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Procesotipocomentario_CU_Delete.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Procesotipocomentario.Procesotipocomentario_CU_Delete" %>
<script type="text/javascript">

    function CargarModalDeleteProcesotipocomentario(uid) {
        var control = document.getElementById('txt_buscarDeleteUIDProcesotipocomentario');
        control.value = uid;
        var btnBuscarDeleteRegistro = document.getElementById('btnDeleteProcesotipocomentarioMostrarModal');        
        __doPostBack(btnBuscarDeleteRegistro.name, '');
    }
</script>



<div style="display: none;">
    <asp:TextBox ID="txt_buscarDeleteUIDProcesotipocomentario" runat="server" ClientIDMode="Static"></asp:TextBox>
    <asp:Button ID="btnDeleteProcesotipocomentarioMostrarModal" runat="server" Text="MostrarModal" ClientIDMode="Static"
        OnClick="btnDeleteProcesotipocomentarioMostrarModal_Click" />
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
   <asp:Label ID="lbl_uidprocesotipocomentario_delete" AssociatedControlID="txt_uidprocesotipocomentario_delete" runat="server" Text="uidprocesotipocomentario <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_uidprocesotipocomentario_delete" runat = "server" CssClass="form-control"  MaxLength="36"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidproceso_delete" AssociatedControlID="cb_uidproceso_delete" runat="server" Text="Cod. Proceso <b style='color:red;'> *</b>"></asp:Label>
			  <asp:DropDownList  Enabled="false"  ID = "cb_uidproceso_delete" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
 </div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidtipocomentario_delete" AssociatedControlID="cb_uidtipocomentario_delete" runat="server" Text="Cod. Tipo Proceso <b style='color:red;'> *</b>"></asp:Label>
			  <asp:DropDownList  Enabled="false"  ID = "cb_uidtipocomentario_delete" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
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
