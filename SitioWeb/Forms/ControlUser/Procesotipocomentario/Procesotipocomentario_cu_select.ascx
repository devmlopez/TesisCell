<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Procesotipocomentario_CU_Select.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Procesotipocomentario.Procesotipocomentario_CU_MostrarUnico" %>

<script type="text/javascript">

    function CargarModalSelectProcesotipocomentario(uid) {
        var control = document.getElementById('txt_buscarSelectUIDProcesotipocomentario');
        control.value = uid;
        var btnBuscarSelectRegistro = document.getElementById('btnSelectProcesotipocomentarioMostrarModal');        
        __doPostBack(btnBuscarSelectRegistro.name, '');
    }
</script>


<div style="display: none;">
    <asp:TextBox ID="txt_buscarSelectUIDProcesotipocomentario" runat="server" ClientIDMode="Static"></asp:TextBox>
    <asp:Button ID="btnSelectProcesotipocomentarioMostrarModal" runat="server" Text="MostrarModal" ClientIDMode="Static"
        OnClick="btnSelectProcesotipocomentarioMostrarModal_Click" />
</div>


<%if(EsModal==true)
    {%>
	<!-- Modal Select -->
        <div class="modal fade" id="Select-modal-default-Procesotipocomentario">
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
   <asp:Label ID="lbl_uidprocesotipocomentario_select" AssociatedControlID="txt_uidprocesotipocomentario_select" runat="server" Text="uidprocesotipocomentario <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_uidprocesotipocomentario_select" runat = "server" CssClass="form-control"  MaxLength="36"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidproceso_select" AssociatedControlID="cb_uidproceso_select" runat="server" Text="Cod. Proceso <b style='color:red;'> *</b>"></asp:Label>
			  <asp:DropDownList  Enabled="false"  ID = "cb_uidproceso_select" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
 </div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidtipocomentario_select" AssociatedControlID="cb_uidtipocomentario_select" runat="server" Text="Cod. Tipo Proceso <b style='color:red;'> *</b>"></asp:Label>
			  <asp:DropDownList  Enabled="false"  ID = "cb_uidtipocomentario_select" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
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


