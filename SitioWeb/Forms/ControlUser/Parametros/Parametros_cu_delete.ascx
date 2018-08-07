<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Parametros_CU_Delete.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Parametros.Parametros_CU_Delete" %>
<script type="text/javascript">

    function CargarModalDeleteParametros(uid) {
        var control = document.getElementById('txt_buscarDeleteUIDParametros');
        control.value = uid;
        var btnBuscarDeleteRegistro = document.getElementById('btnDeleteParametrosMostrarModal');        
        __doPostBack(btnBuscarDeleteRegistro.name, '');
    }
</script>



<div style="display: none;">
    <asp:TextBox ID="txt_buscarDeleteUIDParametros" runat="server" ClientIDMode="Static"></asp:TextBox>
    <asp:Button ID="btnDeleteParametrosMostrarModal" runat="server" Text="MostrarModal" ClientIDMode="Static"
        OnClick="btnDeleteParametrosMostrarModal_Click" />
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
   <asp:Label ID="lbl_uidparmetro_delete" AssociatedControlID="txt_uidparmetro_delete" runat="server" Text="uidparmetro <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_uidparmetro_delete" runat = "server" CssClass="form-control"  MaxLength="36"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_moduloreferencia_delete" AssociatedControlID="txt_moduloreferencia_delete" runat="server" Text="Mod.Ref. <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_moduloreferencia_delete" runat = "server" CssClass="form-control"  MaxLength="100"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_value_delete" AssociatedControlID="txt_value_delete" runat="server" Text="Value <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_value_delete" runat = "server" CssClass="form-control"  MaxLength="100"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_textshort_delete" AssociatedControlID="txt_textshort_delete" runat="server" Text="Text-Short"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_textshort_delete" runat = "server" CssClass="form-control"  MaxLength="100"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_textlong_delete" AssociatedControlID="txt_textlong_delete" runat="server" Text="Text-Long"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_textlong_delete" runat = "server" CssClass="form-control"  MaxLength="4000"   Width="100 %"></asp:TextBox> 
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
