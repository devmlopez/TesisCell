<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Media_CU_Select.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Media.Media_CU_MostrarUnico" %>

<script type="text/javascript">

    function CargarModalSelectMedia(uid) {
        var control = document.getElementById('txt_buscarSelectUIDMedia');
        control.value = uid;
        var btnBuscarSelectRegistro = document.getElementById('btnSelectMediaMostrarModal');        
        __doPostBack(btnBuscarSelectRegistro.name, '');
    }
</script>


<div style="display: none;">
    <asp:TextBox ID="txt_buscarSelectUIDMedia" runat="server" ClientIDMode="Static"></asp:TextBox>
    <asp:Button ID="btnSelectMediaMostrarModal" runat="server" Text="MostrarModal" ClientIDMode="Static"
        OnClick="btnSelectMediaMostrarModal_Click" />
</div>


<%if(EsModal==true)
    {%>
	<!-- Modal Select -->
        <div class="modal fade" id="Select-modal-default-Media">
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
   <asp:Label ID="lbl_uidmedia_select" AssociatedControlID="txt_uidmedia_select" runat="server" Text="uidmedia <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_uidmedia_select" runat = "server" CssClass="form-control"  MaxLength="36"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 oculto">
   <asp:Label ID="lbl_codmedia_select" AssociatedControlID="txt_codmedia_select" runat="server" Text="Cod. Media <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_codmedia_select" runat = "server" CssClass="form-control" TextMode="Number" step="1"  min="0" max="9999999999"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidproceso_select" AssociatedControlID="cb_uidproceso_select" runat="server" Text="Cod. Proceso <b style='color:red;'> *</b>"></asp:Label>
			  <asp:DropDownList  Enabled="false"  ID = "cb_uidproceso_select" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
 </div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidtipocomentario_select" AssociatedControlID="cb_uidtipocomentario_select" runat="server" Text="Tipo Comentario <b style='color:red;'> *</b>"></asp:Label>
			  <asp:DropDownList  Enabled="false"  ID = "cb_uidtipocomentario_select" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
 </div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_cometario_select" AssociatedControlID="txt_cometario_select" runat="server" Text="Comentario <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_cometario_select" runat = "server" CssClass="form-control"  MaxLength="500"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_imagen_select" AssociatedControlID="txt_imagen_select" runat="server" Text="Imagen"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_imagen_select" runat = "server" CssClass="form-control"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_url_select" AssociatedControlID="txt_url_select" runat="server" Text="Url"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_url_select" runat = "server" CssClass="form-control"  MaxLength="500"   Width="100 %"></asp:TextBox> 
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


