<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Sexo_CU_Select.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Sexo.Sexo_CU_MostrarUnico" %>

<script type="text/javascript">

    function CargarModalSelectSexo(uid) {
        var control = document.getElementById('txt_buscarSelectUIDSexo');
        control.value = uid;
        var btnBuscarSelectRegistro = document.getElementById('btnSelectSexoMostrarModal');        
        __doPostBack(btnBuscarSelectRegistro.name, '');
    }
</script>


<div style="display: none;">
    <asp:TextBox ID="txt_buscarSelectUIDSexo" runat="server" ClientIDMode="Static"></asp:TextBox>
    <asp:Button ID="btnSelectSexoMostrarModal" runat="server" Text="MostrarModal" ClientIDMode="Static"
        OnClick="btnSelectSexoMostrarModal_Click" />
</div>


<%if(EsModal==true)
    {%>
	<!-- Modal Select -->
        <div class="modal fade" id="Select-modal-default-Sexo">
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
   <asp:Label ID="lbl_uidsexo_select" AssociatedControlID="txt_uidsexo_select" runat="server" Text="uidsexo <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_uidsexo_select" runat = "server" CssClass="form-control"  MaxLength="36"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_sexo_select" AssociatedControlID="txt_sexo_select" runat="server" Text="Sexo <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_sexo_select" runat = "server" CssClass="form-control"  MaxLength="20"   Width="100 %"></asp:TextBox> 
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


