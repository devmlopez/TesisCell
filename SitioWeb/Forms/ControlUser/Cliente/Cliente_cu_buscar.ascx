<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Cliente_cu_buscar.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Cliente.Cliente_cu_buscar" %>
<%@ Register Src="~/Forms/ControlUser/MsgControl.ascx" TagPrefix="uc1" TagName="MsgControl" %>
<%@ Register Src="~/Forms/ControlUser/Cliente/Cliente_cu_select.ascx" TagPrefix="uc1" TagName="Cliente_cu_select" %>


<a href="#" class="btn btn-link" data-toggle="modal" data-target="#Search-modal-default"><i class="fa fa-search"></i>Buscar</a>

<!-- Modal Search -->
<div class="modal fade" id="Search-modal-default">
    <div class="modal-dialog modal-lg">
        <div class="modal-content">
            <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                    <span aria-hidden="true">&times;</span></button>
                <h4 class="modal-title">Buscar Registro</h4>
            </div>
            <div class="modal-body">
                <div class="row">
                    <asp:UpdatePanel runat="server" UpdateMode="Always">
                        <ContentTemplate>
                            <uc1:Cliente_cu_select runat="server" EsModal="false" ID="Cliente_cu_select" />
                        </ContentTemplate>
                    </asp:UpdatePanel>
                  
                </div>
                <div>
                    <asp:Label runat="server" ID="lblMensajeError_Buscar" Visible="false"></asp:Label>
                </div>
            </div>
            <div class="modal-footer">
                <a href="#" class="btn btn-primary btn-ls btn-flat">Aceptar</a>

                <button type="button" class="btn btn-default btn-ls btn-flat" data-dismiss="modal">Cancelar</button>
            </div>
        </div>
        <!-- /.modal-content -->
    </div>
    <!-- /.modal-dialog -->
</div>
<!-- /.modal -->
<!-- Modal Insert fin -->

