<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Nivelestudio_CU_Select.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Nivelestudio.Nivelestudio_CU_MostrarUnico" %>

<script type="text/javascript">

    function CargarModalSelectNivelestudio(uid) {
        var control = document.getElementById('txt_buscarSelectUIDNivelestudio');
        control.value = uid;
        var btnBuscarSelectRegistro = document.getElementById('btnSelectNivelestudioMostrarModal');        
        __doPostBack(btnBuscarSelectRegistro.name, '');
    }
</script>


<div style="display: none;">
    <asp:TextBox ID="txt_buscarSelectUIDNivelestudio" runat="server" ClientIDMode="Static"></asp:TextBox>
    <asp:Button ID="btnSelectNivelestudioMostrarModal" runat="server" Text="MostrarModal" ClientIDMode="Static"
        OnClick="btnSelectNivelestudioMostrarModal_Click" />
</div>


<%if(EsModal==true)
    {%>
	<!-- Modal Select -->
        <div class="modal fade" id="Select-modal-default-Nivelestudio">
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
   <asp:Label ID="lbl_uidnivelestudio_select" AssociatedControlID="txt_uidnivelestudio_select" runat="server" Text="uidnivelestudio <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_uidnivelestudio_select" runat = "server" CssClass="form-control"  MaxLength="36"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_nivelestudio_select" AssociatedControlID="txt_nivelestudio_select" runat="server" Text="Nivel de Estudios <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_nivelestudio_select" runat = "server" CssClass="form-control"  MaxLength="300"   Width="100 %"></asp:TextBox> 
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


