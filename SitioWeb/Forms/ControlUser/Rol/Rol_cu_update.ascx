<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Rol_CU_Update.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Rol.Rol_CU_Update" %>

<script type="text/javascript">

    function CargarModalUpdateRol(uid) {
        var control = document.getElementById('txt_buscarUpdateUIDRol');
        control.value = uid;
        var btnBuscarUpdateRegistro = document.getElementById('btnUpdateRolMostrarModal');
        __doPostBack(btnBuscarUpdateRegistro.name, '');
    }
</script>
<div style="display: none;">
    <asp:TextBox ID="txt_buscarUpdateUIDRol" runat="server" ClientIDMode="Static"></asp:TextBox>
    <asp:Button ID="btnUpdateRolMostrarModal" runat="server" Text="MostrarModal" ClientIDMode="Static"
        OnClick="btnUpdateRolMostrarModal_Click" />
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
   <asp:Label ID="lbl_uidrol_update" AssociatedControlID="txt_uidrol_update" runat="server" Text="uidrol <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_uidrol_update" runat = "server" CssClass="form-control"  MaxLength="36"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_rol_update" AssociatedControlID="txt_rol_update" runat="server" Text="Rol <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_rol_update" runat = "server" CssClass="form-control"  MaxLength="100"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 "> 
  <asp:Label ID="lbl_permisolectura_update" AssociatedControlID="checkb_permisolectura_update" runat="server" Text="Lectura <b style='color:red;'> *</b>"></asp:Label>
			  <asp:CheckBox  Enabled="true"  ID = "checkb_permisolectura_update" runat = "server" CssClass="form-control" ></asp:CheckBox> 
</div>
			  <div class="col-xs-3 "> 
  <asp:Label ID="lbl_permisoescritura_update" AssociatedControlID="checkb_permisoescritura_update" runat="server" Text="Escritura <b style='color:red;'> *</b>"></asp:Label>
			  <asp:CheckBox  Enabled="true"  ID = "checkb_permisoescritura_update" runat = "server" CssClass="form-control" ></asp:CheckBox> 
</div>
			  <div class="col-xs-3 "> 
  <asp:Label ID="lbl_permisoconsultar_update" AssociatedControlID="checkb_permisoconsultar_update" runat="server" Text="Consulta <b style='color:red;'> *</b>"></asp:Label>
			  <asp:CheckBox  Enabled="true"  ID = "checkb_permisoconsultar_update" runat = "server" CssClass="form-control" ></asp:CheckBox> 
</div>
			  <div class="col-xs-3 "> 
  <asp:Label ID="lbl_perisocrear_update" AssociatedControlID="checkb_perisocrear_update" runat="server" Text="Crear <b style='color:red;'> *</b>"></asp:Label>
			  <asp:CheckBox  Enabled="true"  ID = "checkb_perisocrear_update" runat = "server" CssClass="form-control" ></asp:CheckBox> 
</div>
			  <div class="col-xs-3 "> 
  <asp:Label ID="lbl_permisoeditar_update" AssociatedControlID="checkb_permisoeditar_update" runat="server" Text="Editar <b style='color:red;'> *</b>"></asp:Label>
			  <asp:CheckBox  Enabled="true"  ID = "checkb_permisoeditar_update" runat = "server" CssClass="form-control" ></asp:CheckBox> 
</div>
			  <div class="col-xs-3 "> 
  <asp:Label ID="lbl_permisoeliminar_update" AssociatedControlID="checkb_permisoeliminar_update" runat="server" Text="Eliminar <b style='color:red;'> *</b>"></asp:Label>
			  <asp:CheckBox  Enabled="true"  ID = "checkb_permisoeliminar_update" runat = "server" CssClass="form-control" ></asp:CheckBox> 
</div>
			  <div class="col-xs-3 "> 
  <asp:Label ID="lbl_permisototal_update" AssociatedControlID="checkb_permisototal_update" runat="server" Text="Total <b style='color:red;'> *</b>"></asp:Label>
			  <asp:CheckBox  Enabled="true"  ID = "checkb_permisototal_update" runat = "server" CssClass="form-control" ></asp:CheckBox> 
</div>
			  <div class="col-xs-3 "> 
  <asp:Label ID="lbl_permisonulo_update" AssociatedControlID="checkb_permisonulo_update" runat="server" Text="Nulo <b style='color:red;'> *</b>"></asp:Label>
			  <asp:CheckBox  Enabled="true"  ID = "checkb_permisonulo_update" runat = "server" CssClass="form-control" ></asp:CheckBox> 
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
