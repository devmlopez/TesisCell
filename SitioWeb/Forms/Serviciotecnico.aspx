



<%@ Page Title="" Language="C#" EnableEventValidation="false" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Serviciotecnico.aspx.cs" Inherits="SitioWeb.Forms.Serviciotecnico" %>

<%@ Register Src="~/Forms/ControlUser/Serviciotecnico/Serviciotecnico_CU_Detalle.ascx" TagPrefix="uc1" TagName="Serviciotecnico_CU_Detalle" %>
<%@ Register Src="~/Forms/ControlUser/Serviciotecnico/Serviciotecnico_CU_Insert.ascx" TagPrefix="uc1" TagName="Serviciotecnico_CU_Insert" %>
<%@ Register Src="~/Forms/ControlUser/MsgControl.ascx" TagPrefix="uc1" TagName="MsgControl" %>
<%@ Register Src="~/Forms/ControlUser/Serviciotecnico/Serviciotecnico_CU_Update.ascx" TagPrefix="uc1" TagName="Serviciotecnico_CU_Update" %>
<%@ Register Src="~/Forms/ControlUser/Serviciotecnico/Serviciotecnico_CU_Delete.ascx" TagPrefix="uc1" TagName="Serviciotecnico_CU_Delete" %>
<%@ Register Src="~/Forms/ControlUser/Serviciotecnico/Serviciotecnico_CU_Select.ascx" TagPrefix="uc1" TagName="Serviciotecnico_CU_Select" %>


<%@ Register Src="~/Forms/ControlUser/OptionControl.ascx" TagPrefix="uc1" TagName="OptionControl" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	    <div class="content-wrapper">
             <uc1:OptionControl runat="server" id="OptionControl" />
    <!-- Main content -->
    <section class="content"> 
	<div class="row">
        <div class="col-xs-12">

            <div class="box">
                <div class="box-header">
                    <h3 class="box-title">Serviciotecnico</h3>
                </div>
                <!-- /.box-header -->
                <div class="box-body">

                    <uc1:Serviciotecnico_CU_Insert runat="server" id="Serviciotecnico_CU_Insert" />
                    <uc1:Serviciotecnico_CU_Update runat="server" id="Serviciotecnico_CU_Update" />
                    <uc1:Serviciotecnico_CU_Delete runat="server" id="Serviciotecnico_CU_Delete" />


                    <!-- TABLA CONTENDO -->
					 <div style="margin-bottom:5px;"></div>
                    <uc1:Serviciotecnico_CU_Detalle runat="server" id="Serviciotecnico_CU_Detalle" />
                    <!-- TABLA CONTENDO FIN -->
                    <uc1:Serviciotecnico_CU_Select EsModal="True" runat="server" id="Serviciotecnico_CU_Select" />
                </div>
                <!-- /.box-body -->
            </div>
            <!-- /.box -->
        </div>
        <!-- /.col -->
    </div>
    </section>
  </div>  

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
