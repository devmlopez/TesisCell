<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Rol_CU_Select.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Rol.Rol_CU_MostrarUnico" %>

<script type="text/javascript">

    function CargarModalSelectRol(uid) {
        var control = document.getElementById('txt_buscarSelectUIDRol');
        control.value = uid;
        var btnBuscarSelectRegistro = document.getElementById('btnSelectRolMostrarModal');        
        __doPostBack(btnBuscarSelectRegistro.name, '');
    }
</script>


<div style="display: none;">
    <asp:TextBox ID="txt_buscarSelectUIDRol" runat="server" ClientIDMode="Static"></asp:TextBox>
    <asp:Button ID="btnSelectRolMostrarModal" runat="server" Text="MostrarModal" ClientIDMode="Static"
        OnClick="btnSelectRolMostrarModal_Click" />
</div>


<%if(EsModal==true)
    {%>
	<!-- Modal Select -->
        <div class="modal fade" id="Select-modal-default-Rol">
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
   <asp:Label ID="lbl_uidrol_select" AssociatedControlID="txt_uidrol_select" runat="server" Text="uidrol <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_uidrol_select" runat = "server" CssClass="form-control"  MaxLength="36"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_rol_select" AssociatedControlID="txt_rol_select" runat="server" Text="Rol <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_rol_select" runat = "server" CssClass="form-control"  MaxLength="100"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 "> 
  <asp:Label ID="lbl_permisolectura_select" AssociatedControlID="checkb_permisolectura_select" runat="server" Text="Lectura <b style='color:red;'> *</b>"></asp:Label>
			  <asp:CheckBox  Enabled="false"  ID = "checkb_permisolectura_select" runat = "server" CssClass="form-control" ></asp:CheckBox> 
</div>
			  <div class="col-xs-3 "> 
  <asp:Label ID="lbl_permisoescritura_select" AssociatedControlID="checkb_permisoescritura_select" runat="server" Text="Escritura <b style='color:red;'> *</b>"></asp:Label>
			  <asp:CheckBox  Enabled="false"  ID = "checkb_permisoescritura_select" runat = "server" CssClass="form-control" ></asp:CheckBox> 
</div>
			  <div class="col-xs-3 "> 
  <asp:Label ID="lbl_permisoconsultar_select" AssociatedControlID="checkb_permisoconsultar_select" runat="server" Text="Consulta <b style='color:red;'> *</b>"></asp:Label>
			  <asp:CheckBox  Enabled="false"  ID = "checkb_permisoconsultar_select" runat = "server" CssClass="form-control" ></asp:CheckBox> 
</div>
			  <div class="col-xs-3 "> 
  <asp:Label ID="lbl_perisocrear_select" AssociatedControlID="checkb_perisocrear_select" runat="server" Text="Crear <b style='color:red;'> *</b>"></asp:Label>
			  <asp:CheckBox  Enabled="false"  ID = "checkb_perisocrear_select" runat = "server" CssClass="form-control" ></asp:CheckBox> 
</div>
			  <div class="col-xs-3 "> 
  <asp:Label ID="lbl_permisoeditar_select" AssociatedControlID="checkb_permisoeditar_select" runat="server" Text="Editar <b style='color:red;'> *</b>"></asp:Label>
			  <asp:CheckBox  Enabled="false"  ID = "checkb_permisoeditar_select" runat = "server" CssClass="form-control" ></asp:CheckBox> 
</div>
			  <div class="col-xs-3 "> 
  <asp:Label ID="lbl_permisoeliminar_select" AssociatedControlID="checkb_permisoeliminar_select" runat="server" Text="Eliminar <b style='color:red;'> *</b>"></asp:Label>
			  <asp:CheckBox  Enabled="false"  ID = "checkb_permisoeliminar_select" runat = "server" CssClass="form-control" ></asp:CheckBox> 
</div>
			  <div class="col-xs-3 "> 
  <asp:Label ID="lbl_permisototal_select" AssociatedControlID="checkb_permisototal_select" runat="server" Text="Total <b style='color:red;'> *</b>"></asp:Label>
			  <asp:CheckBox  Enabled="false"  ID = "checkb_permisototal_select" runat = "server" CssClass="form-control" ></asp:CheckBox> 
</div>
			  <div class="col-xs-3 "> 
  <asp:Label ID="lbl_permisonulo_select" AssociatedControlID="checkb_permisonulo_select" runat="server" Text="Nulo <b style='color:red;'> *</b>"></asp:Label>
			  <asp:CheckBox  Enabled="false"  ID = "checkb_permisonulo_select" runat = "server" CssClass="form-control" ></asp:CheckBox> 
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


