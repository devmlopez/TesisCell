<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Empleado_CU_Insert.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Empleado.Empleado_CU_Insert" %>
<%@ Register Src="~/Forms/ControlUser/MsgControl.ascx" TagPrefix="uc1" TagName="MsgControl" %>
        
		<% if(SitioWeb.ClasesUtiles.SessionClass.GetLoginUser(Page).ClassRol.perisocrear==true){ 
            %>

		<a href="#" class="btn btn-default btn-xs btn-flat" data-toggle="modal" data-target="#Inser-modal-default">
            <i class="fa fa-file-o"></i>Agregar
        </a>
<% }%>
		<!-- Modal Insert -->
        <div class="modal fade" id="Inser-modal-default">
            <div class="modal-dialog modal-lg">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span></button>
                        <h4 class="modal-title">Agregar Registro</h4>
                    </div>
                    <div class="modal-body">
                        <div class="row">
                            
                            
			  <div class="col-xs-3 oculto">
   <asp:Label ID="lbl_uidempleado_insert" AssociatedControlID="txt_uidempleado_insert" runat="server" Text="UIDEMPLEADO <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_uidempleado_insert" runat = "server" CssClass="form-control"  MaxLength="36"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 oculto">
   <asp:Label ID="lbl_codido_insert" AssociatedControlID="txt_codido_insert" runat="server" Text="Cod. Empleado <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_codido_insert" runat = "server" CssClass="form-control" TextMode="Number" step="1"  min="0" max="9999999999"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_cedula_insert" AssociatedControlID="txt_cedula_insert" runat="server" Text="Cédula <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_cedula_insert" runat = "server" CssClass="form-control"  MaxLength="13"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_nombres_insert" AssociatedControlID="txt_nombres_insert" runat="server" Text="Nombres <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_nombres_insert" runat = "server" CssClass="form-control"  MaxLength="50"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_apellidos_insert" AssociatedControlID="txt_apellidos_insert" runat="server" Text="Apellidos <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_apellidos_insert" runat = "server" CssClass="form-control"  MaxLength="50"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidestadocivil_insert" AssociatedControlID="cb_uidestadocivil_insert" runat="server" Text="Est. Civil <b style='color:red;'> *</b>"></asp:Label>
			  <asp:DropDownList  Enabled="true"  ID = "cb_uidestadocivil_insert" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
 </div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_fechanacimiento_insert" AssociatedControlID="txt_fechanacimiento_insert" runat="server" Text="Fec. Nac."></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_fechanacimiento_insert" runat = "server" CssClass="form-control" TextMode="Date"  max="2100-01-01" min="2000-01-01"    Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidsexo_insert" AssociatedControlID="cb_uidsexo_insert" runat="server" Text="Sexo <b style='color:red;'> *</b>"></asp:Label>
			  <asp:DropDownList  Enabled="true"  ID = "cb_uidsexo_insert" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
 </div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_telefono_insert" AssociatedControlID="txt_telefono_insert" runat="server" Text="Teléfono"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_telefono_insert" runat = "server" CssClass="form-control"  MaxLength="30"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_num_hijos_insert" AssociatedControlID="txt_num_hijos_insert" runat="server" Text="Cant. Hijos <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_num_hijos_insert" runat = "server" CssClass="form-control" TextMode="Number" step="1"  min="0" max="9999999999"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidnivelestudio_insert" AssociatedControlID="cb_uidnivelestudio_insert" runat="server" Text="Nivel de Estudios <b style='color:red;'> *</b>"></asp:Label>
			  <asp:DropDownList  Enabled="true"  ID = "cb_uidnivelestudio_insert" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
 </div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_titulo_obtenido_insert" AssociatedControlID="txt_titulo_obtenido_insert" runat="server" Text="Título Obtenido"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_titulo_obtenido_insert" runat = "server" CssClass="form-control"  MaxLength="300"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_direccion_domicilio_insert" AssociatedControlID="txt_direccion_domicilio_insert" runat="server" Text="Dirección Domicilio"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_direccion_domicilio_insert" runat = "server" CssClass="form-control"  MaxLength="1000"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_provincia_insert" AssociatedControlID="txt_provincia_insert" runat="server" Text="Provincia"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_provincia_insert" runat = "server" CssClass="form-control"  MaxLength="100"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_ciudad_insert" AssociatedControlID="txt_ciudad_insert" runat="server" Text="Ciudad"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_ciudad_insert" runat = "server" CssClass="form-control"  MaxLength="100"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_email_insert" AssociatedControlID="txt_email_insert" runat="server" Text="E-mail <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_email_insert" runat = "server" CssClass="form-control"  MaxLength="100"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_email_trabajo_insert" AssociatedControlID="txt_email_trabajo_insert" runat="server" Text="Email Trab. <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_email_trabajo_insert" runat = "server" CssClass="form-control"  MaxLength="100"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_fecha_ingreso_insert" AssociatedControlID="txt_fecha_ingreso_insert" runat="server" Text="Fec. Ingreso <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_fecha_ingreso_insert" runat = "server" CssClass="form-control" TextMode="Date"  max="2100-01-01" min="2000-01-01"    Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidsuario_insert" AssociatedControlID="cb_uidsuario_insert" runat="server" Text="Usuario"></asp:Label>
			  <asp:DropDownList  Enabled="true"  ID = "cb_uidsuario_insert" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
 </div>

                        </div>
                        <div>
                            <asp:Label runat="server" ID="lblMensajeError_Insert" Visible="false"></asp:Label>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <asp:LinkButton runat="server" ID="btnGuardarNuevo" CssClass="btn btn-primary btn-ls btn-flat" OnClick="btnGuardarNuevo_Click">
                        <i class="fa fa-save"></i> Guardar
                        </asp:LinkButton>
                        <button type="button" class="btn btn-default btn-ls btn-flat" data-dismiss="modal">Cancelar</button>
                    </div>
                </div>
                <!-- /.modal-content -->
            </div>
            <!-- /.modal-dialog -->
        </div>
        <!-- /.modal -->
        <!-- Modal Insert fin -->
