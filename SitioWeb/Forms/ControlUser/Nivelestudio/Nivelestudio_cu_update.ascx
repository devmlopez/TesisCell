<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Nivelestudio_CU_Update.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Nivelestudio.Nivelestudio_CU_Update" %>

<script type="text/javascript">

    function CargarModalUpdateNivelestudio(uid) {
        var control = document.getElementById('txt_buscarUpdateUIDNivelestudio');
        control.value = uid;
        var btnBuscarUpdateRegistro = document.getElementById('btnUpdateNivelestudioMostrarModal');
        __doPostBack(btnBuscarUpdateRegistro.name, '');
    }
</script>
<div style="display: none;">
    <asp:TextBox ID="txt_buscarUpdateUIDNivelestudio" runat="server" ClientIDMode="Static"></asp:TextBox>
    <asp:Button ID="btnUpdateNivelestudioMostrarModal" runat="server" Text="MostrarModal" ClientIDMode="Static"
        OnClick="btnUpdateNivelestudioMostrarModal_Click" />
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
   <asp:Label ID="lbl_uidnivelestudio_update" AssociatedControlID="txt_uidnivelestudio_update" runat="server" Text="uidnivelestudio <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_uidnivelestudio_update" runat = "server" CssClass="form-control"  MaxLength="36"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_nivelestudio_update" AssociatedControlID="txt_nivelestudio_update" runat="server" Text="Nivel de Estudios <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_nivelestudio_update" runat = "server" CssClass="form-control"  MaxLength="300"   Width="100 %"></asp:TextBox> 
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
