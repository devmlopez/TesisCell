<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Parametros_CU_Update.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Parametros.Parametros_CU_Update" %>

<script type="text/javascript">

    function CargarModalUpdateParametros(uid) {
        var control = document.getElementById('txt_buscarUpdateUIDParametros');
        control.value = uid;
        var btnBuscarUpdateRegistro = document.getElementById('btnUpdateParametrosMostrarModal');
        __doPostBack(btnBuscarUpdateRegistro.name, '');
    }
</script>
<div style="display: none;">
    <asp:TextBox ID="txt_buscarUpdateUIDParametros" runat="server" ClientIDMode="Static"></asp:TextBox>
    <asp:Button ID="btnUpdateParametrosMostrarModal" runat="server" Text="MostrarModal" ClientIDMode="Static"
        OnClick="btnUpdateParametrosMostrarModal_Click" />
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
   <asp:Label ID="lbl_uidparmetro_update" AssociatedControlID="txt_uidparmetro_update" runat="server" Text="uidparmetro <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_uidparmetro_update" runat = "server" CssClass="form-control"  MaxLength="36"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_moduloreferencia_update" AssociatedControlID="txt_moduloreferencia_update" runat="server" Text="Mod.Ref. <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_moduloreferencia_update" runat = "server" CssClass="form-control"  MaxLength="100"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_value_update" AssociatedControlID="txt_value_update" runat="server" Text="Value <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_value_update" runat = "server" CssClass="form-control"  MaxLength="100"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_textshort_update" AssociatedControlID="txt_textshort_update" runat="server" Text="Text-Short"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_textshort_update" runat = "server" CssClass="form-control"  MaxLength="100"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_textlong_update" AssociatedControlID="txt_textlong_update" runat="server" Text="Text-Long"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_textlong_update" runat = "server" CssClass="form-control"  MaxLength="4000"   Width="100 %"></asp:TextBox> 
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
