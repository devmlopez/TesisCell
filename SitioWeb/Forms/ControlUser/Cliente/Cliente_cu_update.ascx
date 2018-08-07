<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Cliente_CU_Update.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Cliente.Cliente_CU_Update" %>

<script type="text/javascript">

    function CargarModalUpdateCliente(uid) {
        var control = document.getElementById('txt_buscarUpdateUIDCliente');
        control.value = uid;
        var btnBuscarUpdateRegistro = document.getElementById('btnUpdateClienteMostrarModal');
        __doPostBack(btnBuscarUpdateRegistro.name, '');
    }
</script>
<div style="display: none;">
    <asp:TextBox ID="txt_buscarUpdateUIDCliente" runat="server" ClientIDMode="Static"></asp:TextBox>
    <asp:Button ID="btnUpdateClienteMostrarModal" runat="server" Text="MostrarModal" ClientIDMode="Static"
        OnClick="btnUpdateClienteMostrarModal_Click" />
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
   <asp:Label ID="lbl_uidcliente_update" AssociatedControlID="txt_uidcliente_update" runat="server" Text="uidcliente <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_uidcliente_update" runat = "server" CssClass="form-control"  MaxLength="36"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 oculto">
   <asp:Label ID="lbl_id_cliente_update" AssociatedControlID="txt_id_cliente_update" runat="server" Text="Cod. Cliente <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_id_cliente_update" runat = "server" CssClass="form-control" TextMode="Number" step="1"  min="0" max="9999999999"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidtipopersona_update" AssociatedControlID="cb_uidtipopersona_update" runat="server" Text="Tipo de Persona <b style='color:red;'> *</b>"></asp:Label>
			  <asp:DropDownList  Enabled="true"  ID = "cb_uidtipopersona_update" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
 </div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_identificacion_update" AssociatedControlID="txt_identificacion_update" runat="server" Text="Identificacin <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_identificacion_update" runat = "server" CssClass="form-control"  MaxLength="20"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidtipoidentificacion_update" AssociatedControlID="cb_uidtipoidentificacion_update" runat="server" Text="Tipo Identificación <b style='color:red;'> *</b>"></asp:Label>
			  <asp:DropDownList  Enabled="true"  ID = "cb_uidtipoidentificacion_update" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
 </div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_razonsocial_update" AssociatedControlID="txt_razonsocial_update" runat="server" Text="Razón Social"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_razonsocial_update" runat = "server" CssClass="form-control"  MaxLength="200"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_nombre_update" AssociatedControlID="txt_nombre_update" runat="server" Text="Nombre <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_nombre_update" runat = "server" CssClass="form-control"  MaxLength="50"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_contacto_update" AssociatedControlID="txt_contacto_update" runat="server" Text="Contacto <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_contacto_update" runat = "server" CssClass="form-control"  MaxLength="50"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_celular_update" AssociatedControlID="txt_celular_update" runat="server" Text="Celular"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_celular_update" runat = "server" CssClass="form-control"  MaxLength="10"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_telefono_update" AssociatedControlID="txt_telefono_update" runat="server" Text="Teléfono <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_telefono_update" runat = "server" CssClass="form-control"  MaxLength="20"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_direccion_update" AssociatedControlID="txt_direccion_update" runat="server" Text="Dirección"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_direccion_update" runat = "server" CssClass="form-control"  MaxLength="200"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_provincia_update" AssociatedControlID="txt_provincia_update" runat="server" Text="Provincia"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_provincia_update" runat = "server" CssClass="form-control"  MaxLength="100"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_ciudad_update" AssociatedControlID="txt_ciudad_update" runat="server" Text="Ciudad"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_ciudad_update" runat = "server" CssClass="form-control"  MaxLength="100"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_email_update" AssociatedControlID="txt_email_update" runat="server" Text="Email <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_email_update" runat = "server" CssClass="form-control"  MaxLength="100"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_referencia_update" AssociatedControlID="txt_referencia_update" runat="server" Text="Referencia"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_referencia_update" runat = "server" CssClass="form-control"  MaxLength="1000"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_observaciones_update" AssociatedControlID="txt_observaciones_update" runat="server" Text="Observaciones"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_observaciones_update" runat = "server" CssClass="form-control"  MaxLength="2000"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uisusuario_update" AssociatedControlID="cb_uisusuario_update" runat="server" Text="Cod. Usuario <b style='color:red;'> *</b>"></asp:Label>
			  <asp:DropDownList  Enabled="true"  ID = "cb_uisusuario_update" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
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
