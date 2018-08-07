<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Loginuser_CU_Select.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Loginuser.Loginuser_CU_MostrarUnico" %>

<script type="text/javascript">

    function CargarModalSelectLoginuser(uid) {
        var control = document.getElementById('txt_buscarSelectUIDLoginuser');
        control.value = uid;
        var btnBuscarSelectRegistro = document.getElementById('btnSelectLoginuserMostrarModal');        
        __doPostBack(btnBuscarSelectRegistro.name, '');
    }
</script>


<div style="display: none;">
    <asp:TextBox ID="txt_buscarSelectUIDLoginuser" runat="server" ClientIDMode="Static"></asp:TextBox>
    <asp:Button ID="btnSelectLoginuserMostrarModal" runat="server" Text="MostrarModal" ClientIDMode="Static"
        OnClick="btnSelectLoginuserMostrarModal_Click" />
</div>


<%if(EsModal==true)
    {%>
	<!-- Modal Select -->
        <div class="modal fade" id="Select-modal-default-Loginuser">
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
   <asp:Label ID="lbl_uidsuario_select" AssociatedControlID="txt_uidsuario_select" runat="server" Text="uidsuario <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_uidsuario_select" runat = "server" CssClass="form-control"  MaxLength="36"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_usuario_select" AssociatedControlID="txt_usuario_select" runat="server" Text="Usuario <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_usuario_select" runat = "server" CssClass="form-control"  MaxLength="40"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_email_select" AssociatedControlID="txt_email_select" runat="server" Text="E-mail <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_email_select" runat = "server" CssClass="form-control"  MaxLength="50"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_nombre_select" AssociatedControlID="txt_nombre_select" runat="server" Text="Nombre <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_nombre_select" runat = "server" CssClass="form-control"  MaxLength="100"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_contrasenia_select" AssociatedControlID="txt_contrasenia_select" runat="server" Text="Contraseña <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_contrasenia_select" runat = "server" CssClass="form-control"  MaxLength="20"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidrol_select" AssociatedControlID="cb_uidrol_select" runat="server" Text="Rol <b style='color:red;'> *</b>"></asp:Label>
			  <asp:DropDownList  Enabled="false"  ID = "cb_uidrol_select" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
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


