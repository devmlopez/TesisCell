<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Serviciotecnico_CU_Update.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Serviciotecnico.Serviciotecnico_CU_Update" %>

<script type="text/javascript">

    function CargarModalUpdateServiciotecnico(uid) {
        var control = document.getElementById('txt_buscarUpdateUIDServiciotecnico');
        control.value = uid;
        var btnBuscarUpdateRegistro = document.getElementById('btnUpdateServiciotecnicoMostrarModal');
        __doPostBack(btnBuscarUpdateRegistro.name, '');
    }
</script>
<div style="display: none;">
    <asp:TextBox ID="txt_buscarUpdateUIDServiciotecnico" runat="server" ClientIDMode="Static"></asp:TextBox>
    <asp:Button ID="btnUpdateServiciotecnicoMostrarModal" runat="server" Text="MostrarModal" ClientIDMode="Static"
        OnClick="btnUpdateServiciotecnicoMostrarModal_Click" />
</div>
<!-- Modal update-->
<div class="modal fade" id="Update-modal-default">
    <div class="modal-dialog modal-lg">
        <div class="modal-content">
            <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                    <span aria-hidden="true">&times;</span></button>
                <h4 class="modal-title">Actualizar Registro</h4>

            </div>
            <div class="modal-body">
                <div class="row">
                    
			  <div class="col-xs-3 oculto">
   <asp:Label ID="lbl_uidserviciotecnico_update" AssociatedControlID="txt_uidserviciotecnico_update" runat="server" Text="uidserviciotecnico <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_uidserviciotecnico_update" runat = "server" CssClass="form-control"  MaxLength="36"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 oculto">
   <asp:Label ID="lbl_codservicio_update" AssociatedControlID="txt_codservicio_update" runat="server" Text="Cod. Servicio <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_codservicio_update" runat = "server" CssClass="form-control" TextMode="Number" step="1"  min="0" max="9999999999"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidcliente_update" AssociatedControlID="cb_uidcliente_update" runat="server" Text="Cliente <b style='color:red;'> *</b>"></asp:Label>
			  <asp:DropDownList  Enabled="true"  ID = "cb_uidcliente_update" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
 </div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidempleado_update" AssociatedControlID="cb_uidempleado_update" runat="server" Text="Empleado <b style='color:red;'> *</b>"></asp:Label>
			  <asp:DropDownList  Enabled="true"  ID = "cb_uidempleado_update" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
 </div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_fechaingreso_update" AssociatedControlID="txt_fechaingreso_update" runat="server" Text="Fecha Ingreso <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_fechaingreso_update" runat = "server" CssClass="form-control" TextMode="Date"  max="2100-01-01" min="2000-01-01"    Width="100%"></asp:TextBox> 
</div>
                    	  <div class="col-xs-3 ">
   <asp:Label ID="Label1" AssociatedControlID="txt_fechasalida_update" runat="server" Text="Fecha Salida"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_fechasalida_update" runat = "server" CssClass="form-control" TextMode="Date"  max="2100-01-01" min="2000-01-01"    Width="100%"></asp:TextBox> 
</div>
                    	  <div class="col-xs-3 ">
   <asp:Label ID="Label2" AssociatedControlID="txt_IMEI_update" runat="server" Text="IMEI <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_IMEI_update" runat = "server" CssClass="form-control" TextMode="Number" max="999999999999999" min="0" step="1"  Width="100%"></asp:TextBox> 
</div>

			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_marca_update" AssociatedControlID="txt_marca_update" runat="server" Text="Marca <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_marca_update" runat = "server" CssClass="form-control"  MaxLength="100"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_modelo_update" AssociatedControlID="txt_modelo_update" runat="server" Text="Modelo <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_modelo_update" runat = "server" CssClass="form-control"  MaxLength="100"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_problemasugerido_update" AssociatedControlID="txt_problemasugerido_update" runat="server" Text="Problema Sugerido <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_problemasugerido_update" runat = "server" CssClass="form-control"  MaxLength="3000"   Width="100 %"></asp:TextBox> 
</div>

				    </div>
                <div>
                    <asp:Label runat="server" ID="lblMensajeError_update" Visible="false"></asp:Label>
                </div>
            </div>
            <div class="modal-footer">
                <asp:LinkButton runat="server" ID="btnGuardarEditar" CssClass="btn btn-primary btn-ls btn-flat" OnClick="btnGuardarEditar_Click">
         <i class="fa fa-save"></i> Guardar Cambios
                </asp:LinkButton>
                <button type="button" class="btn btn-default btn-ls btn-flat" data-dismiss="modal">Cancelar</button>
            </div>

        </div>
        <!-- /.modal-content -->
    </div>
    <!-- /.modal-dialog -->
</div>
<!-- /.modal -->
<!-- Modal update fin -->
