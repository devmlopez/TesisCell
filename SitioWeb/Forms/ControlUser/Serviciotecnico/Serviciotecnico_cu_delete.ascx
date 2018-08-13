<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Serviciotecnico_CU_Delete.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Serviciotecnico.Serviciotecnico_CU_Delete" %>
<script type="text/javascript">

    function CargarModalDeleteServiciotecnico(uid) {
        var control = document.getElementById('txt_buscarDeleteUIDServiciotecnico');
        control.value = uid;
        var btnBuscarDeleteRegistro = document.getElementById('btnDeleteServiciotecnicoMostrarModal');        
        __doPostBack(btnBuscarDeleteRegistro.name, '');
    }
</script>



<div style="display: none;">
    <asp:TextBox ID="txt_buscarDeleteUIDServiciotecnico" runat="server" ClientIDMode="Static"></asp:TextBox>
    <asp:Button ID="btnDeleteServiciotecnicoMostrarModal" runat="server" Text="MostrarModal" ClientIDMode="Static"
        OnClick="btnDeleteServiciotecnicoMostrarModal_Click" />
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
   <asp:Label ID="lbl_uidserviciotecnico_delete" AssociatedControlID="txt_uidserviciotecnico_delete" runat="server" Text="uidserviciotecnico <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_uidserviciotecnico_delete" runat = "server" CssClass="form-control"  MaxLength="36"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 oculto">
   <asp:Label ID="lbl_codservicio_delete" AssociatedControlID="txt_codservicio_delete" runat="server" Text="Cod. Servicio <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_codservicio_delete" runat = "server" CssClass="form-control" TextMode="Number" step="1"  min="0" max="9999999999"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidcliente_delete" AssociatedControlID="cb_uidcliente_delete" runat="server" Text="Cliente <b style='color:red;'> *</b>"></asp:Label>
			  <asp:DropDownList  Enabled="false"  ID = "cb_uidcliente_delete" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
 </div>
			  <div class="col-xs-3 ">  
 <asp:Label ID="lbl_uidempleado_delete" AssociatedControlID="cb_uidempleado_delete" runat="server" Text="Empleado <b style='color:red;'> *</b>"></asp:Label>
			  <asp:DropDownList  Enabled="false"  ID = "cb_uidempleado_delete" runat = "server" CssClass="form-control"   Width="100 %"></asp:DropDownList>
 </div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_fechaingreso_delete" AssociatedControlID="txt_fechaingreso_delete" runat="server" Text="Fecha Ingreso <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_fechaingreso_delete" runat = "server" CssClass="form-control" TextMode="Date"  max="2100-01-01" min="2000-01-01"    Width="100 %"></asp:TextBox> 
</div>

                                      	  <div class="col-xs-3 ">
   <asp:Label ID="Label1" AssociatedControlID="txt_fechasalida_delete" runat="server" Text="Fecha Salida"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_fechasalida_delete" runat = "server" CssClass="form-control" TextMode="Date"  max="2100-01-01" min="2000-01-01"    Width="100%"></asp:TextBox> 
</div>
                    	  <div class="col-xs-3 ">
   <asp:Label ID="Label2" AssociatedControlID="txt_IMEI_delete" runat="server" Text="IMEI <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_IMEI_delete" runat = "server" CssClass="form-control" TextMode="Number"  MaxLength="15"  Width="100%"></asp:TextBox> 
</div>


			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_marca_delete" AssociatedControlID="txt_marca_delete" runat="server" Text="Marca <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_marca_delete" runat = "server" CssClass="form-control"  MaxLength="100"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_modelo_delete" AssociatedControlID="txt_modelo_delete" runat="server" Text="Modelo <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_modelo_delete" runat = "server" CssClass="form-control"  MaxLength="100"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_problemasugerido_delete" AssociatedControlID="txt_problemasugerido_delete" runat="server" Text="Problema Sugerido <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="false"  ID = "txt_problemasugerido_delete" runat = "server" CssClass="form-control"  MaxLength="3000"   Width="100 %"></asp:TextBox> 
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
