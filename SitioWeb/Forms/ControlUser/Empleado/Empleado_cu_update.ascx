<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Empleado_CU_Update.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Empleado.Empleado_CU_Update" %>

<script type="text/javascript">

    function CargarModalUpdateEmpleado(uid) {
        var control = document.getElementById('txt_buscarUpdateUIDEmpleado');
        control.value = uid;
        var btnBuscarUpdateRegistro = document.getElementById('btnUpdateEmpleadoMostrarModal');
        __doPostBack(btnBuscarUpdateRegistro.name, '');
    }
</script>
<div style="display: none;">
    <asp:TextBox ID="txt_buscarUpdateUIDEmpleado" runat="server" ClientIDMode="Static"></asp:TextBox>
    <asp:Button ID="btnUpdateEmpleadoMostrarModal" runat="server" Text="MostrarModal" ClientIDMode="Static"
        OnClick="btnUpdateEmpleadoMostrarModal_Click" />
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
   <asp:Label ID="lbl_uidempleado_update" AssociatedControlID="txt_uidempleado_update" runat="server" Text="UIDEMPLEADO <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_uidempleado_update" runat = "server" CssClass="form-control"  MaxLength="36"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 oculto">
   <asp:Label ID="lbl_codido_update" AssociatedControlID="txt_codido_update" runat="server" Text="Cod. Empleado <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_codido_update" runat = "server" CssClass="form-control" TextMode="Number" step="1"  min="0" max="9999999999"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_cedula_update" AssociatedControlID="txt_cedula_update" runat="server" Text="Cédula <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_cedula_update" runat = "server" CssClass="form-control"  MaxLength="13"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_nombres_update" AssociatedControlID="txt_nombres_update" runat="server" Text="Nombres <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_nombres_update" runat = "server" CssClass="form-control"  MaxLength="50"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_apellidos_update" AssociatedControlID="txt_apellidos_update" runat="server" Text="Apellidos <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_apellidos_update" runat = "server" CssClass="form-control"  MaxLength="50"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidestadocivil_update" AssociatedControlID="cb_uidestadocivil_update" runat="server" Text="Est. Civil <b style='color:red;'> *</b>"></asp:Label>
			  <asp:DropDownList  Enabled="true"  ID = "cb_uidestadocivil_update" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
 </div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_fechanacimiento_update" AssociatedControlID="txt_fechanacimiento_update" runat="server" Text="Fec. Nac."></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_fechanacimiento_update" runat = "server" CssClass="form-control" TextMode="Date"  max="2100-01-01" min="2000-01-01"    Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidsexo_update" AssociatedControlID="cb_uidsexo_update" runat="server" Text="Sexo <b style='color:red;'> *</b>"></asp:Label>
			  <asp:DropDownList  Enabled="true"  ID = "cb_uidsexo_update" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
 </div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_telefono_update" AssociatedControlID="txt_telefono_update" runat="server" Text="Teléfono"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_telefono_update" runat = "server" CssClass="form-control"  MaxLength="30"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_num_hijos_update" AssociatedControlID="txt_num_hijos_update" runat="server" Text="Cant. Hijos <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_num_hijos_update" runat = "server" CssClass="form-control" TextMode="Number" step="1"  min="0" max="9999999999"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidnivelestudio_update" AssociatedControlID="cb_uidnivelestudio_update" runat="server" Text="Nivel de Estudios <b style='color:red;'> *</b>"></asp:Label>
			  <asp:DropDownList  Enabled="true"  ID = "cb_uidnivelestudio_update" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
 </div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_titulo_obtenido_update" AssociatedControlID="txt_titulo_obtenido_update" runat="server" Text="Título Obtenido"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_titulo_obtenido_update" runat = "server" CssClass="form-control"  MaxLength="300"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_direccion_domicilio_update" AssociatedControlID="txt_direccion_domicilio_update" runat="server" Text="Dirección Domicilio"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_direccion_domicilio_update" runat = "server" CssClass="form-control"  MaxLength="1000"   Width="100 %"></asp:TextBox> 
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
   <asp:Label ID="lbl_email_update" AssociatedControlID="txt_email_update" runat="server" Text="E-mail <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_email_update" runat = "server" CssClass="form-control"  MaxLength="100"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_email_trabajo_update" AssociatedControlID="txt_email_trabajo_update" runat="server" Text="Email Trab. <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_email_trabajo_update" runat = "server" CssClass="form-control"  MaxLength="100"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_fecha_ingreso_update" AssociatedControlID="txt_fecha_ingreso_update" runat="server" Text="Fec. Ingreso <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_fecha_ingreso_update" runat = "server" CssClass="form-control" TextMode="Date"  max="2100-01-01" min="2000-01-01"    Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidsuario_update" AssociatedControlID="cb_uidsuario_update" runat="server" Text="Usuario"></asp:Label>
			  <asp:DropDownList  Enabled="true"  ID = "cb_uidsuario_update" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
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
