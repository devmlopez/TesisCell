<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Errores_CU_Select.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Errores.Errores_CU_MostrarUnico" %>

<script type="text/javascript">

    function CargarModalSelectErrores(uid) {
        var control = document.getElementById('txt_buscarSelectUIDErrores');
        control.value = uid;
        var btnBuscarSelectRegistro = document.getElementById('btnSelectErroresMostrarModal');        
        __doPostBack(btnBuscarSelectRegistro.name, '');
    }
</script>


<div style="display: none;">
    <asp:TextBox ID="txt_buscarSelectUIDErrores" runat="server" ClientIDMode="Static"></asp:TextBox>
    <asp:Button ID="btnSelectErroresMostrarModal" runat="server" Text="MostrarModal" ClientIDMode="Static"
        OnClick="btnSelectErroresMostrarModal_Click" />
</div>


<%if(EsModal==true)
    {%>
	<!-- Modal Select -->
        <div class="modal fade" id="Select-modal-default-Errores">
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
   <asp:Label ID="lbl_uid_error_select" AssociatedControlID="txt_uid_error_select" runat="server" Text="uid_Error <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_uid_error_select" runat = "server" CssClass="form-control"  MaxLength="36"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_cod_error_select" AssociatedControlID="txt_cod_error_select" runat="server" Text="Cod. Error <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_cod_error_select" runat = "server" CssClass="form-control"  MaxLength="20"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_mensajeusuario_select" AssociatedControlID="txt_mensajeusuario_select" runat="server" Text="Mens. Usuario <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_mensajeusuario_select" runat = "server" CssClass="form-control"  MaxLength="8000"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_mensajenativo_select" AssociatedControlID="txt_mensajenativo_select" runat="server" Text="Mens. Nativo <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_mensajenativo_select" runat = "server" CssClass="form-control"  MaxLength="8000"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_origenerror_select" AssociatedControlID="txt_origenerror_select" runat="server" Text="Origen del Error <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_origenerror_select" runat = "server" CssClass="form-control"  MaxLength="15"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_tipoerror_select" AssociatedControlID="txt_tipoerror_select" runat="server" Text="Tipo de Error <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_tipoerror_select" runat = "server" CssClass="form-control"  MaxLength="20"   Width="100 %"></asp:TextBox> 
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


