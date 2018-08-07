<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Errores_CU_Update.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Errores.Errores_CU_Update" %>

<script type="text/javascript">

    function CargarModalUpdateErrores(uid) {
        var control = document.getElementById('txt_buscarUpdateUIDErrores');
        control.value = uid;
        var btnBuscarUpdateRegistro = document.getElementById('btnUpdateErroresMostrarModal');
        __doPostBack(btnBuscarUpdateRegistro.name, '');
    }
</script>
<div style="display: none;">
    <asp:TextBox ID="txt_buscarUpdateUIDErrores" runat="server" ClientIDMode="Static"></asp:TextBox>
    <asp:Button ID="btnUpdateErroresMostrarModal" runat="server" Text="MostrarModal" ClientIDMode="Static"
        OnClick="btnUpdateErroresMostrarModal_Click" />
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
   <asp:Label ID="lbl_uid_error_update" AssociatedControlID="txt_uid_error_update" runat="server" Text="uid_Error <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_uid_error_update" runat = "server" CssClass="form-control"  MaxLength="36"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_cod_error_update" AssociatedControlID="txt_cod_error_update" runat="server" Text="Cod. Error <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_cod_error_update" runat = "server" CssClass="form-control"  MaxLength="20"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_mensajeusuario_update" AssociatedControlID="txt_mensajeusuario_update" runat="server" Text="Mens. Usuario <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_mensajeusuario_update" runat = "server" CssClass="form-control"  MaxLength="8000"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_mensajenativo_update" AssociatedControlID="txt_mensajenativo_update" runat="server" Text="Mens. Nativo <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_mensajenativo_update" runat = "server" CssClass="form-control"  MaxLength="8000"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_origenerror_update" AssociatedControlID="txt_origenerror_update" runat="server" Text="Origen del Error <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_origenerror_update" runat = "server" CssClass="form-control"  MaxLength="15"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_tipoerror_update" AssociatedControlID="txt_tipoerror_update" runat="server" Text="Tipo de Error <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_tipoerror_update" runat = "server" CssClass="form-control"  MaxLength="20"   Width="100 %"></asp:TextBox> 
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
