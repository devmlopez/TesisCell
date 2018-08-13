<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Parametros_CU_Insert.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Parametros.Parametros_CU_Insert" %>
<%@ Register Src="~/Forms/ControlUser/MsgControl.ascx" TagPrefix="uc1" TagName="MsgControl" %>
        
		
		     <%  bool? PuedeAgregar =SitioWeb.ClasesUtiles.SessionClass.GetLoginUser(Page).ClassRol.perisocrear.Value;
                if (PuedeAgregar == true)
                {  %>    
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
   <asp:Label ID="lbl_uidparmetro_insert" AssociatedControlID="txt_uidparmetro_insert" runat="server" Text="uidparmetro <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_uidparmetro_insert" runat = "server" CssClass="form-control"  MaxLength="36"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_moduloreferencia_insert" AssociatedControlID="txt_moduloreferencia_insert" runat="server" Text="Mod.Ref. <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_moduloreferencia_insert" runat = "server" CssClass="form-control"  MaxLength="100"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_value_insert" AssociatedControlID="txt_value_insert" runat="server" Text="Value <b style='color:red;'> *</b>"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_value_insert" runat = "server" CssClass="form-control"  MaxLength="100"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_textshort_insert" AssociatedControlID="txt_textshort_insert" runat="server" Text="Text-Short"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_textshort_insert" runat = "server" CssClass="form-control"  MaxLength="100"   Width="100 %"></asp:TextBox> 
</div>
			  <div class="col-xs-3 ">
   <asp:Label ID="lbl_textlong_insert" AssociatedControlID="txt_textlong_insert" runat="server" Text="Text-Long"></asp:Label>
			  <asp:TextBox  Enabled="true"  ID = "txt_textlong_insert" runat = "server" CssClass="form-control"  MaxLength="4000"   Width="100 %"></asp:TextBox> 
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
