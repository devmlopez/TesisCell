<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Cliente_CU_Delete.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Cliente.Cliente_CU_Delete" %>
<script type="text/javascript">

    function CargarModalDeleteCliente(uid) {
        var control = document.getElementById('txt_buscarDeleteUIDCliente');
        control.value = uid;
        var btnBuscarDeleteRegistro = document.getElementById('btnDeleteClienteMostrarModal');        
        __doPostBack(btnBuscarDeleteRegistro.name, '');
    }
</script>



<div style="display: none;">
    <asp:TextBox ID="txt_buscarDeleteUIDCliente" runat="server" ClientIDMode="Static"></asp:TextBox>
    <asp:Button ID="btnDeleteClienteMostrarModal" runat="server" Text="MostrarModal" ClientIDMode="Static"
        OnClick="btnDeleteClienteMostrarModal_Click" />
</div>

  <!-- Modal Delete-->
    <div class="modal fade" id="Delete-modal-default">
        <div class="modal-dialog modal-lg">
            <div class="modal-content">
               
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">&times;</span></button>
                            <h4 class="modal-title">Eliminar Registro</h4>
                        </div>
                        <div class="modal-body">
                            <div>
                                  <div class="row">

								  
			  <div class="col-xs-3 oculto">
   <asp:Label ID="lbl_uidcliente_delete" AssociatedControlID="txt_uidcliente_delete" runat="server" Text="uidcliente <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_uidcliente_delete" runat = "server" CssClass="form-control"  MaxLength="36"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 oculto">
   <asp:Label ID="lbl_id_cliente_delete" AssociatedControlID="txt_id_cliente_delete" runat="server" Text="Cod. Cliente <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_id_cliente_delete" runat = "server" CssClass="form-control" TextMode="Number" step="1"  min="0" max="9999999999"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidtipopersona_delete" AssociatedControlID="cb_uidtipopersona_delete" runat="server" Text="Tipo de Persona <b style='color:red;'> *</b>"></asp:Label>
			  <asp:DropDownList  Enabled="false"  ID = "cb_uidtipopersona_delete" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
 </div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_identificacion_delete" AssociatedControlID="txt_identificacion_delete" runat="server" Text="Identificacin <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_identificacion_delete" runat = "server" CssClass="form-control"  MaxLength="20"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidtipoidentificacion_delete" AssociatedControlID="cb_uidtipoidentificacion_delete" runat="server" Text="Tipo Identificación <b style='color:red;'> *</b>"></asp:Label>
			  <asp:DropDownList  Enabled="false"  ID = "cb_uidtipoidentificacion_delete" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
 </div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_razonsocial_delete" AssociatedControlID="txt_razonsocial_delete" runat="server" Text="Razón Social"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_razonsocial_delete" runat = "server" CssClass="form-control"  MaxLength="200"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_nombre_delete" AssociatedControlID="txt_nombre_delete" runat="server" Text="Nombre <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_nombre_delete" runat = "server" CssClass="form-control"  MaxLength="50"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_contacto_delete" AssociatedControlID="txt_contacto_delete" runat="server" Text="Contacto <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_contacto_delete" runat = "server" CssClass="form-control"  MaxLength="50"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_celular_delete" AssociatedControlID="txt_celular_delete" runat="server" Text="Celular"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_celular_delete" runat = "server" CssClass="form-control"  MaxLength="10"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_telefono_delete" AssociatedControlID="txt_telefono_delete" runat="server" Text="Teléfono <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_telefono_delete" runat = "server" CssClass="form-control"  MaxLength="20"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_direccion_delete" AssociatedControlID="txt_direccion_delete" runat="server" Text="Dirección"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_direccion_delete" runat = "server" CssClass="form-control"  MaxLength="200"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_provincia_delete" AssociatedControlID="txt_provincia_delete" runat="server" Text="Provincia"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_provincia_delete" runat = "server" CssClass="form-control"  MaxLength="100"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_ciudad_delete" AssociatedControlID="txt_ciudad_delete" runat="server" Text="Ciudad"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_ciudad_delete" runat = "server" CssClass="form-control"  MaxLength="100"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_email_delete" AssociatedControlID="txt_email_delete" runat="server" Text="Email <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_email_delete" runat = "server" CssClass="form-control"  MaxLength="100"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_referencia_delete" AssociatedControlID="txt_referencia_delete" runat="server" Text="Referencia"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_referencia_delete" runat = "server" CssClass="form-control"  MaxLength="1000"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_observaciones_delete" AssociatedControlID="txt_observaciones_delete" runat="server" Text="Observaciones"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_observaciones_delete" runat = "server" CssClass="form-control"  MaxLength="2000"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uisusuario_delete" AssociatedControlID="cb_uisusuario_delete" runat="server" Text="Cod. Usuario <b style='color:red;'> *</b>"></asp:Label>
			  <asp:DropDownList  Enabled="false"  ID = "cb_uisusuario_delete" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
 </div>
                </div>
                               <div>
                    <asp:Label runat="server" ID="lblMensajeError_delete" Visible="false"></asp:Label>
                </div>
                                  <br /><h4>
                                Esta seguro que desea eliminar este registro?</h4>
                                <br />
                              
                            </div>
                        </div>
                        <div class="modal-footer">
                            <asp:LinkButton runat="server" ID="btnGuardarEliminar" CssClass="btn btn-primary btn-ls btn-flat" OnClick="btnGuardarEliminar_Click">
         <i class="fa fa-save"></i> Eliminar
                            </asp:LinkButton>
                            <button type="button" class="btn btn-default btn-ls btn-flat" data-dismiss="modal">Cancelar</button>

                        </div>
                    
            </div>
            <!-- /.modal-content -->
        </div>
        <!-- /.modal-dialog -->
    </div>
    <!-- /.modal -->
    <!-- Modal Delete fin -->	
