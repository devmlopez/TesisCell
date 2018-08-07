<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Pagina_CU_Select.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Pagina.Pagina_CU_MostrarUnico" %>

<script type="text/javascript">

    function CargarModalSelectPagina(uid) {
        var control = document.getElementById('txt_buscarSelectUIDPagina');
        control.value = uid;
        var btnBuscarSelectRegistro = document.getElementById('btnSelectPaginaMostrarModal');        
        __doPostBack(btnBuscarSelectRegistro.name, '');
    }
</script>


<div style="display: none;">
    <asp:TextBox ID="txt_buscarSelectUIDPagina" runat="server" ClientIDMode="Static"></asp:TextBox>
    <asp:Button ID="btnSelectPaginaMostrarModal" runat="server" Text="MostrarModal" ClientIDMode="Static"
        OnClick="btnSelectPaginaMostrarModal_Click" />
</div>


<%if(EsModal==true)
    {%>
	<!-- Modal Select -->
        <div class="modal fade" id="Select-modal-default-Pagina">
            <div class="modal-dialog modal-lg">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span></button>
                        <h4 class="modal-title">Consultar Registro</h4>
                    </div>
                    <div class="modal-body">
                        <%} %>


     <div class="row">
                          
			  <div class="col-xs-3 oculto">
   <asp:Label ID="lbl_uidpagina_select" AssociatedControlID="txt_uidpagina_select" runat="server" Text="uidpagina <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_uidpagina_select" runat = "server" CssClass="form-control"  MaxLength="36"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_pagina_select" AssociatedControlID="txt_pagina_select" runat="server" Text="Página <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_pagina_select" runat = "server" CssClass="form-control"  MaxLength="100"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_fullurl_select" AssociatedControlID="txt_fullurl_select" runat="server" Text="Full Url <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_fullurl_select" runat = "server" CssClass="form-control"  MaxLength="100"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidtipoiconoimg_select" AssociatedControlID="cb_uidtipoiconoimg_select" runat="server" Text="Tipo Imagen <b style='color:red;'> *</b>"></asp:Label>
			  <asp:DropDownList  Enabled="false"  ID = "cb_uidtipoiconoimg_select" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
 </div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_iconoimg_select" AssociatedControlID="txt_iconoimg_select" runat="server" Text="Icono"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_iconoimg_select" runat = "server" CssClass="form-control"  MaxLength="500"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_orden_select" AssociatedControlID="txt_orden_select" runat="server" Text="Orden <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_orden_select" runat = "server" CssClass="form-control" TextMode="Number" step="1"  min="0" max="9999999999"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidpaginapadre_select" AssociatedControlID="cb_uidpaginapadre_select" runat="server" Text="Pág. Padre"></asp:Label>
			  <asp:DropDownList  Enabled="false"  ID = "cb_uidpaginapadre_select" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
 </div>

                        </div>
                   
				          <%if(EsModal==true)
    {%>
                          </div>
                    <div class="modal-footer">
                       
                        <button type="button" class="btn btn-default btn-ls btn-flat" data-dismiss="modal">Cerrar</button>
                    </div>
                </div>
                <!-- /.modal-content -->
            </div>
            <!-- /.modal-dialog -->
        </div>
        <!-- /.modal -->
        <!-- Modal Insert fin -->
   <%} %>


