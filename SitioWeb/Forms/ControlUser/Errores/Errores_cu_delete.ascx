<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Errores_CU_Delete.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Errores.Errores_CU_Delete" %>
<script type="text/javascript">

    function CargarModalDeleteErrores(uid) {
        var control = document.getElementById('txt_buscarDeleteUIDErrores');
        control.value = uid;
        var btnBuscarDeleteRegistro = document.getElementById('btnDeleteErroresMostrarModal');        
        __doPostBack(btnBuscarDeleteRegistro.name, '');
    }
</script>



<div style="display: none;">
    <asp:TextBox ID="txt_buscarDeleteUIDErrores" runat="server" ClientIDMode="Static"></asp:TextBox>
    <asp:Button ID="btnDeleteErroresMostrarModal" runat="server" Text="MostrarModal" ClientIDMode="Static"
        OnClick="btnDeleteErroresMostrarModal_Click" />
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
   <asp:Label ID="lbl_uid_error_delete" AssociatedControlID="txt_uid_error_delete" runat="server" Text="uid_Error <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_uid_error_delete" runat = "server" CssClass="form-control"  MaxLength="36"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_cod_error_delete" AssociatedControlID="txt_cod_error_delete" runat="server" Text="Cod. Error <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_cod_error_delete" runat = "server" CssClass="form-control"  MaxLength="20"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_mensajeusuario_delete" AssociatedControlID="txt_mensajeusuario_delete" runat="server" Text="Mens. Usuario <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_mensajeusuario_delete" runat = "server" CssClass="form-control"  MaxLength="8000"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_mensajenativo_delete" AssociatedControlID="txt_mensajenativo_delete" runat="server" Text="Mens. Nativo <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_mensajenativo_delete" runat = "server" CssClass="form-control"  MaxLength="8000"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_origenerror_delete" AssociatedControlID="txt_origenerror_delete" runat="server" Text="Origen del Error <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_origenerror_delete" runat = "server" CssClass="form-control"  MaxLength="15"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_tipoerror_delete" AssociatedControlID="txt_tipoerror_delete" runat="server" Text="Tipo de Error <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_tipoerror_delete" runat = "server" CssClass="form-control"  MaxLength="20"   Width="100 %"></asp:TextBox> 
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
