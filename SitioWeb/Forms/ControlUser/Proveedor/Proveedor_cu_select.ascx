<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Proveedor_CU_Select.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Proveedor.Proveedor_CU_MostrarUnico" %>

<script type="text/javascript">

    function CargarModalSelectProveedor(uid) {
        var control = document.getElementById('txt_buscarSelectUIDProveedor');
        control.value = uid;
        var btnBuscarSelectRegistro = document.getElementById('btnSelectProveedorMostrarModal');        
        __doPostBack(btnBuscarSelectRegistro.name, '');
    }
</script>


<div style="display: none;">
    <asp:TextBox ID="txt_buscarSelectUIDProveedor" runat="server" ClientIDMode="Static"></asp:TextBox>
    <asp:Button ID="btnSelectProveedorMostrarModal" runat="server" Text="MostrarModal" ClientIDMode="Static"
        OnClick="btnSelectProveedorMostrarModal_Click" />
</div>


<%if(EsModal==true)
    {%>
	<!-- Modal Select -->
        <div class="modal fade" id="Select-modal-default-Proveedor">
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
   <asp:Label ID="lbl_uidproveedor_select" AssociatedControlID="txt_uidproveedor_select" runat="server" Text="UIDPROVEEDOR <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_uidproveedor_select" runat = "server" CssClass="form-control"  MaxLength="36"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 oculto">
   <asp:Label ID="lbl_id_proveedor_select" AssociatedControlID="txt_id_proveedor_select" runat="server" Text="Cod. Proveedor <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_id_proveedor_select" runat = "server" CssClass="form-control" TextMode="Number" step="1"  min="0" max="9999999999"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidtipopersona_select" AssociatedControlID="cb_uidtipopersona_select" runat="server" Text="Tipo de Persona <b style='color:red;'> *</b>"></asp:Label>
			  <asp:DropDownList  Enabled="false"  ID = "cb_uidtipopersona_select" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
 </div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_identificacion_select" AssociatedControlID="txt_identificacion_select" runat="server" Text="Identificacion <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_identificacion_select" runat = "server" CssClass="form-control"  MaxLength="20"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidtipoidentificacion_select" AssociatedControlID="cb_uidtipoidentificacion_select" runat="server" Text="Tipo Identificación <b style='color:red;'> *</b>"></asp:Label>
			  <asp:DropDownList  Enabled="false"  ID = "cb_uidtipoidentificacion_select" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
 </div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_razonsocial_select" AssociatedControlID="txt_razonsocial_select" runat="server" Text="Razón Social <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_razonsocial_select" runat = "server" CssClass="form-control"  MaxLength="200"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_nombre_select" AssociatedControlID="txt_nombre_select" runat="server" Text="Nombre <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_nombre_select" runat = "server" CssClass="form-control"  MaxLength="50"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_contacto_select" AssociatedControlID="txt_contacto_select" runat="server" Text="Conacto"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_contacto_select" runat = "server" CssClass="form-control"  MaxLength="50"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_celular_select" AssociatedControlID="txt_celular_select" runat="server" Text="Celular"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_celular_select" runat = "server" CssClass="form-control"  MaxLength="10"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_telefono_select" AssociatedControlID="txt_telefono_select" runat="server" Text="Teléfono"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_telefono_select" runat = "server" CssClass="form-control"  MaxLength="20"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_direccion_select" AssociatedControlID="txt_direccion_select" runat="server" Text="Dirección"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_direccion_select" runat = "server" CssClass="form-control"  MaxLength="200"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_provincia_select" AssociatedControlID="txt_provincia_select" runat="server" Text="Provincia"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_provincia_select" runat = "server" CssClass="form-control"  MaxLength="100"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_ciudad_select" AssociatedControlID="txt_ciudad_select" runat="server" Text="Ciudad"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_ciudad_select" runat = "server" CssClass="form-control"  MaxLength="100"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_email_select" AssociatedControlID="txt_email_select" runat="server" Text="E-mail <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_email_select" runat = "server" CssClass="form-control"  MaxLength="100"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_referencia_select" AssociatedControlID="txt_referencia_select" runat="server" Text="Referencia"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_referencia_select" runat = "server" CssClass="form-control"  MaxLength="1000"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_observaciones_select" AssociatedControlID="txt_observaciones_select" runat="server" Text="Observaciones"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_observaciones_select" runat = "server" CssClass="form-control"  MaxLength="2000"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_pagina_web_select" AssociatedControlID="txt_pagina_web_select" runat="server" Text="Pag. Web <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_pagina_web_select" runat = "server" CssClass="form-control"  MaxLength="1000"   Width="100 %"></asp:TextBox> 
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


