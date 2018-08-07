<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Parametros_CU_Select.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Parametros.Parametros_CU_MostrarUnico" %>

<script type="text/javascript">

    function CargarModalSelectParametros(uid) {
        var control = document.getElementById('txt_buscarSelectUIDParametros');
        control.value = uid;
        var btnBuscarSelectRegistro = document.getElementById('btnSelectParametrosMostrarModal');        
        __doPostBack(btnBuscarSelectRegistro.name, '');
    }
</script>


<div style="display: none;">
    <asp:TextBox ID="txt_buscarSelectUIDParametros" runat="server" ClientIDMode="Static"></asp:TextBox>
    <asp:Button ID="btnSelectParametrosMostrarModal" runat="server" Text="MostrarModal" ClientIDMode="Static"
        OnClick="btnSelectParametrosMostrarModal_Click" />
</div>


<%if(EsModal==true)
    {%>
	<!-- Modal Select -->
        <div class="modal fade" id="Select-modal-default-Parametros">
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
   <asp:Label ID="lbl_uidparmetro_select" AssociatedControlID="txt_uidparmetro_select" runat="server" Text="uidparmetro <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_uidparmetro_select" runat = "server" CssClass="form-control"  MaxLength="36"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_moduloreferencia_select" AssociatedControlID="txt_moduloreferencia_select" runat="server" Text="Mod.Ref. <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_moduloreferencia_select" runat = "server" CssClass="form-control"  MaxLength="100"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_value_select" AssociatedControlID="txt_value_select" runat="server" Text="Value <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_value_select" runat = "server" CssClass="form-control"  MaxLength="100"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_textshort_select" AssociatedControlID="txt_textshort_select" runat="server" Text="Text-Short"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_textshort_select" runat = "server" CssClass="form-control"  MaxLength="100"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_textlong_select" AssociatedControlID="txt_textlong_select" runat="server" Text="Text-Long"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_textlong_select" runat = "server" CssClass="form-control"  MaxLength="4000"   Width="100 %"></asp:TextBox> 
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


