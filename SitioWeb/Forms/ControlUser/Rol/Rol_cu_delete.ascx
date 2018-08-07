<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Rol_CU_Delete.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Rol.Rol_CU_Delete" %>
<script type="text/javascript">

    function CargarModalDeleteRol(uid) {
        var control = document.getElementById('txt_buscarDeleteUIDRol');
        control.value = uid;
        var btnBuscarDeleteRegistro = document.getElementById('btnDeleteRolMostrarModal');        
        __doPostBack(btnBuscarDeleteRegistro.name, '');
    }
</script>



<div style="display: none;">
    <asp:TextBox ID="txt_buscarDeleteUIDRol" runat="server" ClientIDMode="Static"></asp:TextBox>
    <asp:Button ID="btnDeleteRolMostrarModal" runat="server" Text="MostrarModal" ClientIDMode="Static"
        OnClick="btnDeleteRolMostrarModal_Click" />
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
   <asp:Label ID="lbl_uidrol_delete" AssociatedControlID="txt_uidrol_delete" runat="server" Text="uidrol <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_uidrol_delete" runat = "server" CssClass="form-control"  MaxLength="36"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_rol_delete" AssociatedControlID="txt_rol_delete" runat="server" Text="Rol <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_rol_delete" runat = "server" CssClass="form-control"  MaxLength="100"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 "> 
  <asp:Label ID="lbl_permisolectura_delete" AssociatedControlID="checkb_permisolectura_delete" runat="server" Text="Lectura <b style='color:red;'> *</b>"></asp:Label>
			  <asp:CheckBox  Enabled="false"  ID = "checkb_permisolectura_delete" runat = "server" CssClass="form-control" ></asp:CheckBox> 
</div>
			  <div class="col-xs-3 "> 
  <asp:Label ID="lbl_permisoescritura_delete" AssociatedControlID="checkb_permisoescritura_delete" runat="server" Text="Escritura <b style='color:red;'> *</b>"></asp:Label>
			  <asp:CheckBox  Enabled="false"  ID = "checkb_permisoescritura_delete" runat = "server" CssClass="form-control" ></asp:CheckBox> 
</div>
			  <div class="col-xs-3 "> 
  <asp:Label ID="lbl_permisoconsultar_delete" AssociatedControlID="checkb_permisoconsultar_delete" runat="server" Text="Consulta <b style='color:red;'> *</b>"></asp:Label>
			  <asp:CheckBox  Enabled="false"  ID = "checkb_permisoconsultar_delete" runat = "server" CssClass="form-control" ></asp:CheckBox> 
</div>
			  <div class="col-xs-3 "> 
  <asp:Label ID="lbl_perisocrear_delete" AssociatedControlID="checkb_perisocrear_delete" runat="server" Text="Crear <b style='color:red;'> *</b>"></asp:Label>
			  <asp:CheckBox  Enabled="false"  ID = "checkb_perisocrear_delete" runat = "server" CssClass="form-control" ></asp:CheckBox> 
</div>
			  <div class="col-xs-3 "> 
  <asp:Label ID="lbl_permisoeditar_delete" AssociatedControlID="checkb_permisoeditar_delete" runat="server" Text="Editar <b style='color:red;'> *</b>"></asp:Label>
			  <asp:CheckBox  Enabled="false"  ID = "checkb_permisoeditar_delete" runat = "server" CssClass="form-control" ></asp:CheckBox> 
</div>
			  <div class="col-xs-3 "> 
  <asp:Label ID="lbl_permisoeliminar_delete" AssociatedControlID="checkb_permisoeliminar_delete" runat="server" Text="Eliminar <b style='color:red;'> *</b>"></asp:Label>
			  <asp:CheckBox  Enabled="false"  ID = "checkb_permisoeliminar_delete" runat = "server" CssClass="form-control" ></asp:CheckBox> 
</div>
			  <div class="col-xs-3 "> 
  <asp:Label ID="lbl_permisototal_delete" AssociatedControlID="checkb_permisototal_delete" runat="server" Text="Total <b style='color:red;'> *</b>"></asp:Label>
			  <asp:CheckBox  Enabled="false"  ID = "checkb_permisototal_delete" runat = "server" CssClass="form-control" ></asp:CheckBox> 
</div>
			  <div class="col-xs-3 "> 
  <asp:Label ID="lbl_permisonulo_delete" AssociatedControlID="checkb_permisonulo_delete" runat="server" Text="Nulo <b style='color:red;'> *</b>"></asp:Label>
			  <asp:CheckBox  Enabled="false"  ID = "checkb_permisonulo_delete" runat = "server" CssClass="form-control" ></asp:CheckBox> 
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
