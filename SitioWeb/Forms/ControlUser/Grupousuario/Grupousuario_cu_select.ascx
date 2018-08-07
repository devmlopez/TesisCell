<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Grupousuario_CU_Select.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Grupousuario.Grupousuario_CU_MostrarUnico" %>

<script type="text/javascript">

    function CargarModalSelectGrupousuario(uid) {
        var control = document.getElementById('txt_buscarSelectUIDGrupousuario');
        control.value = uid;
        var btnBuscarSelectRegistro = document.getElementById('btnSelectGrupousuarioMostrarModal');        
        __doPostBack(btnBuscarSelectRegistro.name, '');
    }
</script>


<div style="display: none;">
    <asp:TextBox ID="txt_buscarSelectUIDGrupousuario" runat="server" ClientIDMode="Static"></asp:TextBox>
    <asp:Button ID="btnSelectGrupousuarioMostrarModal" runat="server" Text="MostrarModal" ClientIDMode="Static"
        OnClick="btnSelectGrupousuarioMostrarModal_Click" />
</div>


<%if(EsModal==true)
    {%>
	<!-- Modal Select -->
        <div class="modal fade" id="Select-modal-default-Grupousuario">
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
   <asp:Label ID="lbl_uidgrupousuario_select" AssociatedControlID="txt_uidgrupousuario_select" runat="server" Text="uidgrupousuario <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_uidgrupousuario_select" runat = "server" CssClass="form-control"  MaxLength="36"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidgrupo_select" AssociatedControlID="cb_uidgrupo_select" runat="server" Text="Grupo <b style='color:red;'> *</b>"></asp:Label>
			  <asp:DropDownList  Enabled="false"  ID = "cb_uidgrupo_select" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
 </div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidusuario_select" AssociatedControlID="cb_uidusuario_select" runat="server" Text="Usuario <b style='color:red;'> *</b>"></asp:Label>
			  <asp:DropDownList  Enabled="false"  ID = "cb_uidusuario_select" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
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


