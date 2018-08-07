<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Pagina_CU_Delete.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Pagina.Pagina_CU_Delete" %>
<script type="text/javascript">

    function CargarModalDeletePagina(uid) {
        var control = document.getElementById('txt_buscarDeleteUIDPagina');
        control.value = uid;
        var btnBuscarDeleteRegistro = document.getElementById('btnDeletePaginaMostrarModal');        
        __doPostBack(btnBuscarDeleteRegistro.name, '');
    }
</script>



<div style="display: none;">
    <asp:TextBox ID="txt_buscarDeleteUIDPagina" runat="server" ClientIDMode="Static"></asp:TextBox>
    <asp:Button ID="btnDeletePaginaMostrarModal" runat="server" Text="MostrarModal" ClientIDMode="Static"
        OnClick="btnDeletePaginaMostrarModal_Click" />
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
   <asp:Label ID="lbl_uidpagina_delete" AssociatedControlID="txt_uidpagina_delete" runat="server" Text="uidpagina <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_uidpagina_delete" runat = "server" CssClass="form-control"  MaxLength="36"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_pagina_delete" AssociatedControlID="txt_pagina_delete" runat="server" Text="Página <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_pagina_delete" runat = "server" CssClass="form-control"  MaxLength="100"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_fullurl_delete" AssociatedControlID="txt_fullurl_delete" runat="server" Text="Full Url <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_fullurl_delete" runat = "server" CssClass="form-control"  MaxLength="100"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidtipoiconoimg_delete" AssociatedControlID="cb_uidtipoiconoimg_delete" runat="server" Text="Tipo Imagen <b style='color:red;'> *</b>"></asp:Label>
			  <asp:DropDownList  Enabled="false"  ID = "cb_uidtipoiconoimg_delete" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
 </div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_iconoimg_delete" AssociatedControlID="txt_iconoimg_delete" runat="server" Text="Icono"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_iconoimg_delete" runat = "server" CssClass="form-control"  MaxLength="500"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_orden_delete" AssociatedControlID="txt_orden_delete" runat="server" Text="Orden <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_orden_delete" runat = "server" CssClass="form-control" TextMode="Number" step="1"  min="0" max="9999999999"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidpaginapadre_delete" AssociatedControlID="cb_uidpaginapadre_delete" runat="server" Text="Pág. Padre"></asp:Label>
			  <asp:DropDownList  Enabled="false"  ID = "cb_uidpaginapadre_delete" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
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
