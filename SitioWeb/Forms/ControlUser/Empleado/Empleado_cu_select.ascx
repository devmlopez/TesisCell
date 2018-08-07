<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Empleado_CU_Select.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Empleado.Empleado_CU_MostrarUnico" %>

<script type="text/javascript">

    function CargarModalSelectEmpleado(uid) {
        var control = document.getElementById('txt_buscarSelectUIDEmpleado');
        control.value = uid;
        var btnBuscarSelectRegistro = document.getElementById('btnSelectEmpleadoMostrarModal');        
        __doPostBack(btnBuscarSelectRegistro.name, '');
    }
</script>


<div style="display: none;">
    <asp:TextBox ID="txt_buscarSelectUIDEmpleado" runat="server" ClientIDMode="Static"></asp:TextBox>
    <asp:Button ID="btnSelectEmpleadoMostrarModal" runat="server" Text="MostrarModal" ClientIDMode="Static"
        OnClick="btnSelectEmpleadoMostrarModal_Click" />
</div>


<%if(EsModal==true)
    {%>
	<!-- Modal Select -->
        <div class="modal fade" id="Select-modal-default-Empleado">
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
   <asp:Label ID="lbl_uidempleado_select" AssociatedControlID="txt_uidempleado_select" runat="server" Text="UIDEMPLEADO <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_uidempleado_select" runat = "server" CssClass="form-control"  MaxLength="36"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 oculto">
   <asp:Label ID="lbl_codido_select" AssociatedControlID="txt_codido_select" runat="server" Text="Cod. Empleado <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_codido_select" runat = "server" CssClass="form-control" TextMode="Number" step="1"  min="0" max="9999999999"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_cedula_select" AssociatedControlID="txt_cedula_select" runat="server" Text="Cédula <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_cedula_select" runat = "server" CssClass="form-control"  MaxLength="13"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_nombres_select" AssociatedControlID="txt_nombres_select" runat="server" Text="Nombres <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_nombres_select" runat = "server" CssClass="form-control"  MaxLength="50"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_apellidos_select" AssociatedControlID="txt_apellidos_select" runat="server" Text="Apellidos <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_apellidos_select" runat = "server" CssClass="form-control"  MaxLength="50"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidestadocivil_select" AssociatedControlID="cb_uidestadocivil_select" runat="server" Text="Est. Civil <b style='color:red;'> *</b>"></asp:Label>
			  <asp:DropDownList  Enabled="false"  ID = "cb_uidestadocivil_select" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
 </div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_fechanacimiento_select" AssociatedControlID="txt_fechanacimiento_select" runat="server" Text="Fec. Nac."></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_fechanacimiento_select" runat = "server" CssClass="form-control" TextMode="Date"  max="2100-01-01" min="2000-01-01"    Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidsexo_select" AssociatedControlID="cb_uidsexo_select" runat="server" Text="Sexo <b style='color:red;'> *</b>"></asp:Label>
			  <asp:DropDownList  Enabled="false"  ID = "cb_uidsexo_select" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
 </div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_telefono_select" AssociatedControlID="txt_telefono_select" runat="server" Text="Teléfono"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_telefono_select" runat = "server" CssClass="form-control"  MaxLength="30"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_num_hijos_select" AssociatedControlID="txt_num_hijos_select" runat="server" Text="Cant. Hijos <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_num_hijos_select" runat = "server" CssClass="form-control" TextMode="Number" step="1"  min="0" max="9999999999"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidnivelestudio_select" AssociatedControlID="cb_uidnivelestudio_select" runat="server" Text="Nivel de Estudios <b style='color:red;'> *</b>"></asp:Label>
			  <asp:DropDownList  Enabled="false"  ID = "cb_uidnivelestudio_select" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
 </div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_titulo_obtenido_select" AssociatedControlID="txt_titulo_obtenido_select" runat="server" Text="Título Obtenido"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_titulo_obtenido_select" runat = "server" CssClass="form-control"  MaxLength="300"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_direccion_domicilio_select" AssociatedControlID="txt_direccion_domicilio_select" runat="server" Text="Dirección Domicilio"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_direccion_domicilio_select" runat = "server" CssClass="form-control"  MaxLength="1000"   Width="100 %"></asp:TextBox> 
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
   <asp:Label ID="lbl_email_trabajo_select" AssociatedControlID="txt_email_trabajo_select" runat="server" Text="Email Trab. <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_email_trabajo_select" runat = "server" CssClass="form-control"  MaxLength="100"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_fecha_ingreso_select" AssociatedControlID="txt_fecha_ingreso_select" runat="server" Text="Fec. Ingreso <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_fecha_ingreso_select" runat = "server" CssClass="form-control" TextMode="Date"  max="2100-01-01" min="2000-01-01"    Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidsuario_select" AssociatedControlID="cb_uidsuario_select" runat="server" Text="Usuario"></asp:Label>
			  <asp:DropDownList  Enabled="false"  ID = "cb_uidsuario_select" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
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


