<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Pagina_CU_Insert.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Pagina.Pagina_CU_Insert" %>
<%@ Register Src="~/Forms/ControlUser/MsgControl.ascx" TagPrefix="uc1" TagName="MsgControl" %>
        
		
		<a href="#" class="btn btn-default btn-xs btn-flat botonOpcionesControlUserClass" data-toggle="modal" data-target="#Inser-modal-default">
            <i class="fa fa-file-o"></i>Agregar
        </a>
		<!-- Modal Insert -->
        <div class="modal fade" id="Inser-modal-default">
            <div class="modal-dialog modal-lg">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span></button>
                        <h4 class="modal-title">Agregar Registro</h4>
                    </div>
                    <div class="modal-body">
                        <div class="row">
                            
                            
			  <div class="col-xs-3 oculto">
   <asp:Label ID="lbl_uidpagina_insert" AssociatedControlID="txt_uidpagina_insert" runat="server" Text="uidpagina <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_uidpagina_insert" runat = "server" CssClass="form-control"  MaxLength="36"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_pagina_insert" AssociatedControlID="txt_pagina_insert" runat="server" Text="Página <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_pagina_insert" runat = "server" CssClass="form-control"  MaxLength="100"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_fullurl_insert" AssociatedControlID="txt_fullurl_insert" runat="server" Text="Full Url <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_fullurl_insert" runat = "server" CssClass="form-control"  MaxLength="100"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidtipoiconoimg_insert" AssociatedControlID="cb_uidtipoiconoimg_insert" runat="server" Text="Tipo Imagen <b style='color:red;'> *</b>"></asp:Label>
			  <asp:DropDownList  Enabled="true"  ID = "cb_uidtipoiconoimg_insert" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
 </div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_iconoimg_insert" AssociatedControlID="txt_iconoimg_insert" runat="server" Text="Icono"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_iconoimg_insert" runat = "server" CssClass="form-control"  MaxLength="500"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_orden_insert" AssociatedControlID="txt_orden_insert" runat="server" Text="Orden <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_orden_insert" runat = "server" CssClass="form-control" TextMode="Number" step="1"  min="0" max="9999999999"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidpaginapadre_insert" AssociatedControlID="cb_uidpaginapadre_insert" runat="server" Text="Pág. Padre"></asp:Label>
			  <asp:DropDownList  Enabled="true"  ID = "cb_uidpaginapadre_insert" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
 </div>

                        </div>
                        <div>
                            <asp:Label runat="server" ID="lblMensajeError_Insert" Visible="false"></asp:Label>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <asp:LinkButton runat="server" ID="btnGuardarNuevo" CssClass="btn btn-primary btn-ls btn-flat" OnClick="btnGuardarNuevo_Click">
                        <i class="fa fa-save"></i> Guardar
                        </asp:LinkButton>
                        <button type="button" class="btn btn-default btn-ls btn-flat" data-dismiss="modal">Cancelar</button>
                    </div>
                </div>
                <!-- /.modal-content -->
            </div>
            <!-- /.modal-dialog -->
        </div>
        <!-- /.modal -->
        <!-- Modal Insert fin -->
