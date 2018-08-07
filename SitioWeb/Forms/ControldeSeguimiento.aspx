<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ControldeSeguimiento.aspx.cs" Inherits="SitioWeb.Forms.ControldeSeguimiento" %>

<%@ Register Src="~/Forms/ControlUser/MsgControl.ascx" TagPrefix="uc1" TagName="MsgControl" %>
<%@ Register Src="~/Forms/ControlUser/Serviciotecnico/Serviciotecnico_cu_select.ascx" TagPrefix="uc1" TagName="Serviciotecnico_cu_select" %>
<%@ Register Src="~/Forms/ControlUser/Proceso/Proceso_cu_detalle.ascx" TagPrefix="uc1" TagName="Proceso_cu_detalle" %>
<%@ Register Src="~/Forms/ControlUser/Media/Media_cu_detalle.ascx" TagPrefix="uc1" TagName="Media_cu_detalle" %>
<%@ Register Src="~/Forms/ControlUser/Media/Media_cu_select.ascx" TagPrefix="uc1" TagName="Media_cu_select" %>






<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content-wrapper">
        <!-- Main content -->
        <section class="content">
            <div class="row">
                <div class="col-xs-12">
                    <div class="box">
                        <div class="box-header">
                            <h3 class="box-title">Control de Seguimiento</h3>
                        </div>
                        <!-- /.box-header -->
                        <div class="box-body">
                            <div class="row">
                                <!--  SERVICIO TECNICO -->
                                <div class="col-xs-12">
                                    <uc1:Serviciotecnico_cu_select runat="server" EsModal="False" ID="Serviciotecnico_cu_select" />
                                </div>
                                <!-- PROCESO INICIAL -->
                                <div class="col-xs-12">
                                    <h4 class="box-title">Proceso Inicial</h4>
                                </div>
                                <div class="col-xs-12">
                                    <uc1:Media_cu_detalle runat="server" uidtipoComentario="88cfd9fe-ee7b-4276-ae0c-09b65f27be69" ID="Media_cu_detalleProcesoInicial" />
                                </div>
                                <!-- PROCESO EN CURSO -->
                                <div class="col-xs-12">
                                    <h4 class="box-title">En proceso</h4>
                                </div>
                                <div class="col-xs-12">
                                    <uc1:Media_cu_detalle runat="server"  uidtipoComentario="03bee36a-fef1-4c54-a066-632a23b7b5da" ID="Media_cu_detalleEnProceso" />

                                </div>

                                <!-- PROCESO FINAL -->
                                <div class="col-xs-12">
                                    <h4 class="box-title">Proceso Final</h4>
                                </div>
                                <div class="col-xs-12">
                                    <uc1:Media_cu_detalle runat="server"  uidtipoComentario="d9438d73-ed10-4003-8fb3-cc9212ea8501" ID="Media_cu_detalleProcesoFinal" />
                                </div>

                            </div>

                        </div>
                        <!-- /.box-body -->
                    </div>
                    <!-- /.box -->
                </div>
                <!-- /.col -->
        </section>
    </div>

    <uc1:Media_cu_select runat="server" EsModal="true" ID="Media_cu_select" />

    <script type="text/javascript">
        function beforeAsyncPostBack() {
            var curtime = new Date();
            // waitingDialog.show('Procesando', { dialogSize: 'sm', progressType: 'primary' }); setTimeout(function () { waitingDialog.hide(); }, 2000);
            waitingDialog.show('Procesando...', { dialogSize: 'sm', progressType: 'primary' });

        }

        function afterAsyncPostBack() {
            setTimeout(function () { waitingDialog.hide(); }, 1000);
        }

        Sys.Application.add_init(appl_init);

        function appl_init() {
            var pgRegMgr = Sys.WebForms.PageRequestManager.getInstance();
            pgRegMgr.add_beginRequest(BeginHandler);
            pgRegMgr.add_endRequest(EndHandler);
        }

        function BeginHandler() {
            beforeAsyncPostBack();
        }

        function EndHandler() {
            afterAsyncPostBack();
        }


    </script>
    <uc1:MsgControl runat="server" ID="MsgControl" />

</asp:Content>
