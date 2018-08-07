<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Procesotipocomentario_CU_Update.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Procesotipocomentario.Procesotipocomentario_CU_Update" %>

<script type="text/javascript">

    function CargarModalUpdateProcesotipocomentario(uid) {
        var control = document.getElementById('txt_buscarUpdateUIDProcesotipocomentario');
        control.value = uid;
        var btnBuscarUpdateRegistro = document.getElementById('btnUpdateProcesotipocomentarioMostrarModal');
        __doPostBack(btnBuscarUpdateRegistro.name, '');
    }
</script>
<div style="display: none;">
    <asp:TextBox ID="txt_buscarUpdateUIDProcesotipocomentario" runat="server" ClientIDMode="Static"></asp:TextBox>
    <asp:Button ID="btnUpdateProcesotipocomentarioMostrarModal" runat="server" Text="MostrarModal" ClientIDMode="Static"
        OnClick="btnUpdateProcesotipocomentarioMostrarModal_Click" />
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
   <asp:Label ID="lbl_uidprocesotipocomentario_update" AssociatedControlID="txt_uidprocesotipocomentario_update" runat="server" Text="uidprocesotipocomentario <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_uidprocesotipocomentario_update" runat = "server" CssClass="form-control"  MaxLength="36"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidproceso_update" AssociatedControlID="cb_uidproceso_update" runat="server" Text="Cod. Proceso <b style='color:red;'> *</b>"></asp:Label>
			  <asp:DropDownList  Enabled="true"  ID = "cb_uidproceso_update" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
 </div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidtipocomentario_update" AssociatedControlID="cb_uidtipocomentario_update" runat="server" Text="Cod. Tipo Proceso <b style='color:red;'> *</b>"></asp:Label>
			  <asp:DropDownList  Enabled="true"  ID = "cb_uidtipocomentario_update" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
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
