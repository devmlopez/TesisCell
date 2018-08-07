<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Grupousuario_CU_Update.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Grupousuario.Grupousuario_CU_Update" %>

<script type="text/javascript">

    function CargarModalUpdateGrupousuario(uid) {
        var control = document.getElementById('txt_buscarUpdateUIDGrupousuario');
        control.value = uid;
        var btnBuscarUpdateRegistro = document.getElementById('btnUpdateGrupousuarioMostrarModal');
        __doPostBack(btnBuscarUpdateRegistro.name, '');
    }
</script>
<div style="display: none;">
    <asp:TextBox ID="txt_buscarUpdateUIDGrupousuario" runat="server" ClientIDMode="Static"></asp:TextBox>
    <asp:Button ID="btnUpdateGrupousuarioMostrarModal" runat="server" Text="MostrarModal" ClientIDMode="Static"
        OnClick="btnUpdateGrupousuarioMostrarModal_Click" />
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
   <asp:Label ID="lbl_uidgrupousuario_update" AssociatedControlID="txt_uidgrupousuario_update" runat="server" Text="uidgrupousuario <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_uidgrupousuario_update" runat = "server" CssClass="form-control"  MaxLength="36"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidgrupo_update" AssociatedControlID="cb_uidgrupo_update" runat="server" Text="Grupo <b style='color:red;'> *</b>"></asp:Label>
			  <asp:DropDownList  Enabled="true"  ID = "cb_uidgrupo_update" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
 </div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidusuario_update" AssociatedControlID="cb_uidusuario_update" runat="server" Text="Usuario <b style='color:red;'> *</b>"></asp:Label>
			  <asp:DropDownList  Enabled="true"  ID = "cb_uidusuario_update" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
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
