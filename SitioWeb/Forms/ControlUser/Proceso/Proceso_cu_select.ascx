<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Proceso_CU_Select.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Proceso.Proceso_CU_MostrarUnico" %>

<script type="text/javascript">

    function CargarModalSelectProceso(uid) {
        var control = document.getElementById('txt_buscarSelectUIDProceso');
        control.value = uid;
        var btnBuscarSelectRegistro = document.getElementById('btnSelectProcesoMostrarModal');        
        __doPostBack(btnBuscarSelectRegistro.name, '');
    }
</script>


<div style="display: none;">
    <asp:TextBox ID="txt_buscarSelectUIDProceso" runat="server" ClientIDMode="Static"></asp:TextBox>
    <asp:Button ID="btnSelectProcesoMostrarModal" runat="server" Text="MostrarModal" ClientIDMode="Static"
        OnClick="btnSelectProcesoMostrarModal_Click" />
</div>


<%if(EsModal==true)
    {%>
	<!-- Modal Select -->
        <div class="modal fade" id="Select-modal-default-Proceso">
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
   <asp:Label ID="lbl_uidproceso_select" AssociatedControlID="txt_uidproceso_select" runat="server" Text="uidproceso <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_uidproceso_select" runat = "server" CssClass="form-control"  MaxLength="36"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_codproceso_select" AssociatedControlID="txt_codproceso_select" runat="server" Text="od. Proceso <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_codproceso_select" runat = "server" CssClass="form-control" TextMode="Number" step="1"  min="0" max="9999999999"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidserviciotecnico_select" AssociatedControlID="cb_uidserviciotecnico_select" runat="server" Text="Cod. Servicio <b style='color:red;'> *</b>"></asp:Label>
			  <asp:DropDownList  Enabled="false"  ID = "cb_uidserviciotecnico_select" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
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


