<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Rol_CU_Insert.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Rol.Rol_CU_Insert" %>
<%@ Register Src="~/Forms/ControlUser/MsgControl.ascx" TagPrefix="uc1" TagName="MsgControl" %>
        
		
		  <% if(SitioWeb.ClasesUtiles.SessionClass.GetLoginUser(Page).ClassRol.perisocrear==true){
          %> 
		<a href="#" class="btn btn-default btn-xs btn-flat" data-toggle="modal" data-target="#Inser-modal-default">
            <i class="fa fa-file-o"></i>Agregar
        </a>

           <%  } %>
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
   <asp:Label ID="lbl_uidrol_insert" AssociatedControlID="txt_uidrol_insert" runat="server" Text="uidrol <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_uidrol_insert" runat = "server" CssClass="form-control"  MaxLength="36"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_rol_insert" AssociatedControlID="txt_rol_insert" runat="server" Text="Rol <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_rol_insert" runat = "server" CssClass="form-control"  MaxLength="100"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 "> 
  <asp:Label ID="lbl_permisolectura_insert" AssociatedControlID="checkb_permisolectura_insert" runat="server" Text="Lectura <b style='color:red;'> *</b>"></asp:Label>
			  <asp:CheckBox  Enabled="true"  ID = "checkb_permisolectura_insert" runat = "server" CssClass="form-control" ></asp:CheckBox> 
</div>
			  <div class="col-xs-3 "> 
  <asp:Label ID="lbl_permisoescritura_insert" AssociatedControlID="checkb_permisoescritura_insert" runat="server" Text="Escritura <b style='color:red;'> *</b>"></asp:Label>
			  <asp:CheckBox  Enabled="true"  ID = "checkb_permisoescritura_insert" runat = "server" CssClass="form-control" ></asp:CheckBox> 
</div>
			  <div class="col-xs-3 "> 
  <asp:Label ID="lbl_permisoconsultar_insert" AssociatedControlID="checkb_permisoconsultar_insert" runat="server" Text="Consulta <b style='color:red;'> *</b>"></asp:Label>
			  <asp:CheckBox  Enabled="true"  ID = "checkb_permisoconsultar_insert" runat = "server" CssClass="form-control" ></asp:CheckBox> 
</div>
			  <div class="col-xs-3 "> 
  <asp:Label ID="lbl_perisocrear_insert" AssociatedControlID="checkb_perisocrear_insert" runat="server" Text="Crear <b style='color:red;'> *</b>"></asp:Label>
			  <asp:CheckBox  Enabled="true"  ID = "checkb_perisocrear_insert" runat = "server" CssClass="form-control" ></asp:CheckBox> 
</div>
			  <div class="col-xs-3 "> 
  <asp:Label ID="lbl_permisoeditar_insert" AssociatedControlID="checkb_permisoeditar_insert" runat="server" Text="Editar <b style='color:red;'> *</b>"></asp:Label>
			  <asp:CheckBox  Enabled="true"  ID = "checkb_permisoeditar_insert" runat = "server" CssClass="form-control" ></asp:CheckBox> 
</div>
			  <div class="col-xs-3 "> 
  <asp:Label ID="lbl_permisoeliminar_insert" AssociatedControlID="checkb_permisoeliminar_insert" runat="server" Text="Eliminar <b style='color:red;'> *</b>"></asp:Label>
			  <asp:CheckBox  Enabled="true"  ID = "checkb_permisoeliminar_insert" runat = "server" CssClass="form-control" ></asp:CheckBox> 
</div>
			  <div class="col-xs-3 "> 
  <asp:Label ID="lbl_permisototal_insert" AssociatedControlID="checkb_permisototal_insert" runat="server" Text="Total <b style='color:red;'> *</b>"></asp:Label>
			  <asp:CheckBox  Enabled="true"  ID = "checkb_permisototal_insert" runat = "server" CssClass="form-control" ></asp:CheckBox> 
</div>
			  <div class="col-xs-3 "> 
  <asp:Label ID="lbl_permisonulo_insert" AssociatedControlID="checkb_permisonulo_insert" runat="server" Text="Nulo <b style='color:red;'> *</b>"></asp:Label>
			  <asp:CheckBox  Enabled="true"  ID = "checkb_permisonulo_insert" runat = "server" CssClass="form-control" ></asp:CheckBox> 
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
