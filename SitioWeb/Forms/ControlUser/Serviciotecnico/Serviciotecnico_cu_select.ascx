<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Serviciotecnico_CU_Select.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Serviciotecnico.Serviciotecnico_CU_MostrarUnico" %>

<script type="text/javascript">

    function CargarModalSelectServiciotecnico(uid) {
        var control = document.getElementById('txt_buscarSelectUIDServiciotecnico');
        control.value = uid;
        var btnBuscarSelectRegistro = document.getElementById('btnSelectServiciotecnicoMostrarModal');        
        __doPostBack(btnBuscarSelectRegistro.name, '');
    }
</script>


<div style="display: none;">
    <asp:TextBox ID="txt_buscarSelectUIDServiciotecnico" runat="server" ClientIDMode="Static"></asp:TextBox>
    <asp:Button ID="btnSelectServiciotecnicoMostrarModal" runat="server" Text="MostrarModal" ClientIDMode="Static"
        OnClick="btnSelectServiciotecnicoMostrarModal_Click" />
</div>


<%if(EsModal==true)
    {%>
	<!-- Modal Select -->
        <div class="modal fade" id="Select-modal-default-Serviciotecnico">
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
   <asp:Label ID="lbl_uidserviciotecnico_select" AssociatedControlID="txt_uidserviciotecnico_select" runat="server" Text="uidserviciotecnico <b style='color:red;'> *</b>"></asp:Label>
			  <asp:Label  Enabled="false"  ID = "txt_uidserviciotecnico_select" runat = "server" CssClass="form-control"  MaxLength="36"   Width="100 %"></asp:Label> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_codservicio_select" AssociatedControlID="txt_codservicio_select" runat="server" Text="Cod. Servicio <b style='color:red;'> *</b>"></asp:Label>
			  <asp:Label  Enabled="false"  ID = "txt_codservicio_select" runat = "server" CssClass="form-control" TextMode="Number" step="1"  min="0" max="9999999999"   Width="100 %"></asp:Label> 
</div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidcliente_select" AssociatedControlID="cb_uidcliente_select" runat="server" Text="Cliente <b style='color:red;'> *</b>"></asp:Label>
			  <asp:Label  Enabled="false"  ID = "cb_uidcliente_select" runat = "server" CssClass="form-control"   Width="100 %"></asp:Label>
 </div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidempleado_select" AssociatedControlID="cb_uidempleado_select" runat="server" Text="Empleado <b style='color:red;'> *</b>"></asp:Label>
			  <asp:Label  Enabled="false"  ID = "cb_uidempleado_select" runat = "server" CssClass="form-control"   Width="100 %"></asp:Label>
 </div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_fechaingreso_select" AssociatedControlID="txt_fechaingreso_select" runat="server" Text="Fecha Ingreso <b style='color:red;'> *</b>"></asp:Label>
			  <asp:Label  Enabled="false"  ID = "txt_fechaingreso_select" runat = "server" CssClass="form-control" TextMode="Date"  max="2100-01-01" min="2000-01-01"    Width="100 %"></asp:Label> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_marca_select" AssociatedControlID="txt_marca_select" runat="server" Text="Marca <b style='color:red;'> *</b>"></asp:Label>
			  <asp:Label  Enabled="false"  ID = "txt_marca_select" runat = "server" CssClass="form-control"  MaxLength="100"   Width="100 %"></asp:Label> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_modelo_select" AssociatedControlID="txt_modelo_select" runat="server" Text="Modelo <b style='color:red;'> *</b>"></asp:Label>
			  <asp:Label  Enabled="false"  ID = "txt_modelo_select" runat = "server" CssClass="form-control"  MaxLength="100"   Width="100 %"></asp:Label> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_problemasugerido_select" AssociatedControlID="txt_problemasugerido_select" runat="server" Text="Problema Sugerido <b style='color:red;'> *</b>"></asp:Label>
			  <asp:Label  Enabled="false"  ID = "txt_problemasugerido_select" runat = "server" CssClass="form-control"  MaxLength="3000"   Width="100 %"></asp:Label> 
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


