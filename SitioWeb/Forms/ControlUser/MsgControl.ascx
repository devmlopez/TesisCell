<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MsgControl.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.MsgControl" %>

<!-- MODAL MESSAGE-->
<script>
    function ShowMessage(Title, codeError, Message, type) {

        $('#msg-modal-default').modal('show');
        $('#msg-title-default').text('Mensaje del Sistema');
        $('#msg-message-default').text(Message);
        $('#msg-code-error-default').text(codeError);

        var btnok = $('#msg-code-typeResultOK');
        var btnERROR = $('#msg-code-typeResultERROR');
        var btnADVERTENCIA = $('#msg-code-typeResultADVERTENCIA');
        var btnDefault = $('#msg-code-typeResultDefault');

       
         btnok.addClass("oculto");
         btnERROR.addClass("oculto");
         btnADVERTENCIA.addClass("oculto");
         btnDefault.addClass("oculto");

        if (type == 'default') {
            btnDefault.removeClass("oculto");

        } else if (type == 'ADVERTENCIA') {
            btnADVERTENCIA.removeClass("oculto");

            //$('#msg-modal-warning').modal('show');
            //$('#msg-title-warning').text('Advertencia');

        } else if (type == 'OK') {
            btnok.removeClass("oculto");
           // botonRefreshGridView.forEach(ForEachRefresh);    
            //$('#msg-modal-success').modal('show');
            //$('#msg-title-success').text('Registro Procesado con éxito');
            //$('#msg-message-success').text(Message);
            //$('#msg-code-error-success').text(codeError);


        } else if (type == 'ERROR') {
            btnERROR.removeClass("oculto");
            //$('#msg-modal-danger').modal('show');
            //$('#msg-title-danger').text('Error');
            //$('#msg-message-danger').text(Message);
            //$('#msg-code-error-danger').text(codeError);
        }
    }

    function fc_msg_code_typeResultOK(){
        var botonRefreshGridView = $('.boton-Refresh');
        for (i = 0; i < botonRefreshGridView.length; i++) {
            btngridviewRF = botonRefreshGridView[i];
            btngridviewRF.click();
        }
    }
</script>

<div class="modal fade" id="msg-modal-default"  data-keyboard="false" data-backdrop="static">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <%-- <button type="button" class="close" data-dismiss="modal" aria-label="Close">--%>

                <h4 class="modal-title">
                    <span id="msg-title-default"></span>
                </h4>
            </div>
            <div class="modal-body">
                <p><span id="msg-code-error-default"></span></p>
                <p><span id="msg-message-default"></span></p>
            </div>
            <div class="modal-footer">
                <div id="msg-code-typeResultOK">
                    <button type="button" class="btn btn-default" data-dismiss="modal"  onclick="fc_msg_code_typeResultOK();">Cerrar</button>
                </div>
                <div id="msg-code-typeResultERROR">
                    <button type="button" class="btn btn-default" data-dismiss="modal">Cerrar</button>
                </div>
                <div id="msg-code-typeResultADVERTENCIA">
                    <button type="button" class="btn btn-default" data-dismiss="modal">Cerrar</button>
                </div>
                <div id="msg-code-typeResultDefault">
                    <button type="button" class="btn btn-default" data-dismiss="modal">Cerrar</button>
                </div>
            </div>
        </div>
        <!-- /.modal-content -->
    </div>
    <!-- /.modal-dialog -->
</div>
<!-- /.modal -->

<div class="modal modal-info fade" id="msg-modal-info">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                    <span aria-hidden="true">&times;</span></button>
                <h4 class="modal-title">Info Modal</h4>
            </div>
            <div class="modal-body">
                <p>One fine body&hellip;</p>
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-outline pull-left" data-dismiss="modal">Close</button>
                <button type="button" class="btn btn-outline">Save changes</button>
            </div>
        </div>
        <!-- /.modal-content -->
    </div>
    <!-- /.modal-dialog -->
</div>
<!-- /.modal -->

<div class="modal modal-warning fade" id="msg-modal-warning">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                    <span aria-hidden="true">&times;</span></button>
                <h4 class="modal-title">Warning Modal</h4>
            </div>
            <div class="modal-body">
                <p>One fine body&hellip;</p>
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-outline pull-left" data-dismiss="modal">Close</button>
                <button type="button" class="btn btn-outline">Save changes</button>
            </div>
        </div>
        <!-- /.modal-content -->
    </div>
    <!-- /.modal-dialog -->
</div>
<!-- /.modal -->

<div class="modal modal-success fade" id="msg-modal-success">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                    <span aria-hidden="true">&times;</span></button>
                <h4 class="modal-title">
                    <span id="msg-title-success"></span>
                </h4>
            </div>
            <div class="modal-body">
                <p><span id="msg-code-error-success"></span></p>
                <p><span id="msg-message-success"></span></p>
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-outline" data-dismiss="modal">Cerrar</button>
            </div>
        </div>
        <!-- /.modal-content -->
    </div>
    <!-- /.modal-dialog -->
</div>
<!-- /.modal -->

<div class="modal modal-danger fade" id="msg-modal-danger">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                    <span aria-hidden="true">&times;</span></button>
                <h4 class="modal-title">
                    <span id="msg-title-danger"></span>
                </h4>
            </div>
            <div class="modal-body">
                <p><span id="msg-code-error-danger"></span></p>
                <p><span id="msg-message-danger"></span></p>
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-outline" data-dismiss="modal">Cerrar</button>

            </div>
        </div>
        <!-- /.modal-content -->
    </div>
    <!-- /.modal-dialog -->
</div>
<!-- /.modal -->
<!-- MODAL MESSAGE-->
