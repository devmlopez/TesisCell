<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Empleado_CU_Delete.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Empleado.Empleado_CU_Delete" %>
<script type="text/javascript">

    function CargarModalDeleteEmpleado(uid) {
        var control = document.getElementById('txt_buscarDeleteUIDEmpleado');
        control.value = uid;
        var btnBuscarDeleteRegistro = document.getElementById('btnDeleteEmpleadoMostrarModal');        
        __doPostBack(btnBuscarDeleteRegistro.name, '');
    }
</script>



<div style="display: none;">
    <asp:TextBox ID="txt_buscarDeleteUIDEmpleado" runat="server" ClientIDMode="Static"></asp:TextBox>
    <asp:Button ID="btnDeleteEmpleadoMostrarModal" runat="server" Text="MostrarModal" ClientIDMode="Static"
        OnClick="btnDeleteEmpleadoMostrarModal_Click" />
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
   <asp:Label ID="lbl_uidempleado_delete" AssociatedControlID="txt_uidempleado_delete" runat="server" Text="UIDEMPLEADO <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_uidempleado_delete" runat = "server" CssClass="form-control"  MaxLength="36"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 oculto">
   <asp:Label ID="lbl_codido_delete" AssociatedControlID="txt_codido_delete" runat="server" Text="Cod. Empleado <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_codido_delete" runat = "server" CssClass="form-control" TextMode="Number" step="1"  min="0" max="9999999999"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_cedula_delete" AssociatedControlID="txt_cedula_delete" runat="server" Text="Cédula <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_cedula_delete" runat = "server" CssClass="form-control"  MaxLength="13"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_nombres_delete" AssociatedControlID="txt_nombres_delete" runat="server" Text="Nombres <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_nombres_delete" runat = "server" CssClass="form-control"  MaxLength="50"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_apellidos_delete" AssociatedControlID="txt_apellidos_delete" runat="server" Text="Apellidos <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_apellidos_delete" runat = "server" CssClass="form-control"  MaxLength="50"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidestadocivil_delete" AssociatedControlID="cb_uidestadocivil_delete" runat="server" Text="Est. Civil <b style='color:red;'> *</b>"></asp:Label>
			  <asp:DropDownList  Enabled="false"  ID = "cb_uidestadocivil_delete" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
 </div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_fechanacimiento_delete" AssociatedControlID="txt_fechanacimiento_delete" runat="server" Text="Fec. Nac."></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_fechanacimiento_delete" runat = "server" CssClass="form-control" TextMode="Date"  max="2100-01-01" min="2000-01-01"    Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidsexo_delete" AssociatedControlID="cb_uidsexo_delete" runat="server" Text="Sexo <b style='color:red;'> *</b>"></asp:Label>
			  <asp:DropDownList  Enabled="false"  ID = "cb_uidsexo_delete" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
 </div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_telefono_delete" AssociatedControlID="txt_telefono_delete" runat="server" Text="Teléfono"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_telefono_delete" runat = "server" CssClass="form-control"  MaxLength="30"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_num_hijos_delete" AssociatedControlID="txt_num_hijos_delete" runat="server" Text="Cant. Hijos <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_num_hijos_delete" runat = "server" CssClass="form-control" TextMode="Number" step="1"  min="0" max="9999999999"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidnivelestudio_delete" AssociatedControlID="cb_uidnivelestudio_delete" runat="server" Text="Nivel de Estudios <b style='color:red;'> *</b>"></asp:Label>
			  <asp:DropDownList  Enabled="false"  ID = "cb_uidnivelestudio_delete" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
 </div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_titulo_obtenido_delete" AssociatedControlID="txt_titulo_obtenido_delete" runat="server" Text="Título Obtenido"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_titulo_obtenido_delete" runat = "server" CssClass="form-control"  MaxLength="300"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_direccion_domicilio_delete" AssociatedControlID="txt_direccion_domicilio_delete" runat="server" Text="Dirección Domicilio"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_direccion_domicilio_delete" runat = "server" CssClass="form-control"  MaxLength="1000"   Width="100 %"></asp:TextBox> 
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
   <asp:Label ID="lbl_email_delete" AssociatedControlID="txt_email_delete" runat="server" Text="E-mail <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_email_delete" runat = "server" CssClass="form-control"  MaxLength="100"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_email_trabajo_delete" AssociatedControlID="txt_email_trabajo_delete" runat="server" Text="Email Trab. <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_email_trabajo_delete" runat = "server" CssClass="form-control"  MaxLength="100"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_fecha_ingreso_delete" AssociatedControlID="txt_fecha_ingreso_delete" runat="server" Text="Fec. Ingreso <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_fecha_ingreso_delete" runat = "server" CssClass="form-control" TextMode="Date"  max="2100-01-01" min="2000-01-01"    Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidsuario_delete" AssociatedControlID="cb_uidsuario_delete" runat="server" Text="Usuario"></asp:Label>
			  <asp:DropDownList  Enabled="false"  ID = "cb_uidsuario_delete" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
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
