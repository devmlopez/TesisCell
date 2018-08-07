<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Pagina_CU_Update.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Pagina.Pagina_CU_Update" %>

<script type="text/javascript">

    function CargarModalUpdatePagina(uid) {
        var control = document.getElementById('txt_buscarUpdateUIDPagina');
        control.value = uid;
        var btnBuscarUpdateRegistro = document.getElementById('btnUpdatePaginaMostrarModal');
        __doPostBack(btnBuscarUpdateRegistro.name, '');
    }
</script>
<div style="display: none;">
    <asp:TextBox ID="txt_buscarUpdateUIDPagina" runat="server" ClientIDMode="Static"></asp:TextBox>
    <asp:Button ID="btnUpdatePaginaMostrarModal" runat="server" Text="MostrarModal" ClientIDMode="Static"
        OnClick="btnUpdatePaginaMostrarModal_Click" />
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
   <asp:Label ID="lbl_uidpagina_update" AssociatedControlID="txt_uidpagina_update" runat="server" Text="uidpagina <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_uidpagina_update" runat = "server" CssClass="form-control"  MaxLength="36"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_pagina_update" AssociatedControlID="txt_pagina_update" runat="server" Text="Página <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_pagina_update" runat = "server" CssClass="form-control"  MaxLength="100"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_fullurl_update" AssociatedControlID="txt_fullurl_update" runat="server" Text="Full Url <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_fullurl_update" runat = "server" CssClass="form-control"  MaxLength="100"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidtipoiconoimg_update" AssociatedControlID="cb_uidtipoiconoimg_update" runat="server" Text="Tipo Imagen <b style='color:red;'> *</b>"></asp:Label>
			  <asp:DropDownList  Enabled="true"  ID = "cb_uidtipoiconoimg_update" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
 </div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_iconoimg_update" AssociatedControlID="txt_iconoimg_update" runat="server" Text="Icono"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_iconoimg_update" runat = "server" CssClass="form-control"  MaxLength="500"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_orden_update" AssociatedControlID="txt_orden_update" runat="server" Text="Orden <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_orden_update" runat = "server" CssClass="form-control" TextMode="Number" step="1"  min="0" max="9999999999"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidpaginapadre_update" AssociatedControlID="cb_uidpaginapadre_update" runat="server" Text="Pág. Padre"></asp:Label>
			  <asp:DropDownList  Enabled="true"  ID = "cb_uidpaginapadre_update" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
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
