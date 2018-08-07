<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ControSeguimientoCliente.aspx.cs" Inherits="SitioWeb.Forms.ControSeguimientoCliente" %>

<%@ Import Namespace="System.Data" %>
<%@ Register Src="~/Forms/ControlUser/Serviciotecnico/Serviciotecnico_cu_select.ascx" TagPrefix="uc1" TagName="Serviciotecnico_cu_select" %>
<%@ Register Src="~/Forms/ControlUser/Media/Media_cu_detalle.ascx" TagPrefix="uc1" TagName="Media_cu_detalle" %>
<%@ Register Src="~/Forms/ControlUser/Media/Media_cu_delete.ascx" TagPrefix="uc1" TagName="Media_cu_delete" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="wrapper">

        <!-- Content Wrapper. Contains page content -->
        <div class="content-wrapper">
            <!-- Main content -->
            <section class="content">

                <!-- row -->
                <div class="row">

                    <!-- NUevo Mensaje -->

                    <div class="col-md-12">
                        <div class="box box-solid">
                            <div class="box-header with-border">
                                <i class="fa fa-user"></i>

                                <h3 class="box-title"><b><%=
                                                           "("+SitioWeb.ClasesUtiles.SessionClass.GetLoginUser(Page).ClassRol.rol
                                                                 +")"+  
                                                             SitioWeb.ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.nombre %></b></h3>
                            </div>
                            <!-- /.box-header -->
                            <div class="box-body">

                                <div class="row">
                                    <div class="col-xs-3 ">
                                        <b>Cod. Servicio:</b>
                                        <asp:Label Enabled="false" ID="txt_codservicio_select" runat="server" CssClass="" TextMode="Number" step="1" min="0" max="9999999999" Width="100 %"></asp:Label>
                                    </div>
                                    <div class="col-xs-3 ">
                                        <b>Cliente:</b>
                                        <asp:Label Enabled="false" ID="cb_uidcliente_select" runat="server" CssClass="" Width="100 %"></asp:Label>
                                    </div>
                                    <div class="col-xs-3 ">
                                        <b>Empleado:</b>
                                        <asp:Label Enabled="false" ID="cb_uidempleado_select" runat="server" CssClass="" Width="100 %"></asp:Label>
                                    </div>
                                    <div class="col-xs-3 ">
                                        <b>Fecha Ingreso:</b>
                                        <asp:Label Enabled="false" ID="txt_fechaingreso_select" runat="server" CssClass="" TextMode="Date" max="2100-01-01" min="2000-01-01" Width="100 %"></asp:Label>
                                    </div>
                                    <div class="col-xs-3 ">
                                        <b>Marca:</b>
                                        <asp:Label Enabled="false" ID="txt_marca_select" runat="server" CssClass="" MaxLength="100" Width="100 %"></asp:Label>
                                    </div>
                                    <div class="col-xs-3 ">
                                        <b>Modelo:</b>
                                        <asp:Label Enabled="false" ID="txt_modelo_select" runat="server" CssClass="" MaxLength="100" Width="100 %"></asp:Label>
                                    </div>
                                    <div class="col-xs-12 ">
                                        <b>Problema Sugerido:</b>
                                        <asp:Label Enabled="false" ID="txt_problemasugerido_select" runat="server" CssClass="" MaxLength="3000" Width="100 %"></asp:Label>
                                    </div>

                                </div>
                                <div class="row">
                                    <div class="col-md-12">
                                    <b>Proceso:</b>
                                    <asp:DropDownList runat="server" ID="cb_Proceso"></asp:DropDownList>
                                    <asp:TextBox runat="server" Visible="false"  ID="txtValorComboProceso"></asp:TextBox>
                                    <asp:LinkButton runat="server" ID="btnGrabarProceso" OnClick="btnGrabarProceso_Click" Text="Guardar Cambio" CssClass="btn btn-primary"></asp:LinkButton>
                                </div>
                                    </div>
                                <div class="input-group margin">
                                    <asp:TextBox runat="server" ID="txtComentario" CssClass="form-control" placeholder="Haz un comentario..."></asp:TextBox>
                                    <%--  <input type="text" class="form-control" placeholder="Haz un comentario..." />  --%>
                                     <%  if (SitioWeb.ClasesUtiles.SessionClass.GetLoginUser(Page).classLoginUser.uidrol == "ED00BDDC-8CB4-41B8-AD16-15650A00D1FB")
                                        { %>
                                    
                                     <span class="input-group-btn">
                                        <button type="button" class="btn btn bg-purple btn-flat" onclick="AbrirFileUpload()"><i class="fa fa-camera"></i></button>

                                        <%--<asp:LinkButton runat="server" ID="btncargarImagen" CssClass="btn btn bg-purple btn-flat"  OnClick="btncargarImagen_Click">
                                           <i class="fa fa-camera"></i>
                                       </asp:LinkButton> --%>
                                        <script>
                                            function AbrirFileUpload() {
                                                $('#ContentPlaceHolder1_FileUpload1').click(); 
                                            }
                                        </script>
                                        <div class="oculto">
                                            <asp:FileUpload runat="server" ID="FileUpload1" />
                                        </div>
                                    </span>                             
                                  
                                    <span class="input-group-btn">
                                        <%--  <button type="button" class="btn btn bg-maroon btn-flat"><i class="fa fa-video-camera"></i></button>--%>
                                        <a href="#" class="btn btn bg-maroon btn-flat"  onclick="ShowMessageVideo();">  <i class="fa fa-video-camera"></i></a>
                                       
                                         <asp:LinkButton runat="server" ID="btnCargarVideo" style="display:none" CssClass="btn btn bg-maroon btn-flat">
                                          <i class="fa fa-video-camera"></i>
                                        </asp:LinkButton>
                                    </span>
                                    <%     } %>
                                    <span class="input-group-btn">
                                        <asp:Button runat="server" ID="btnEnviar" CssClass="btn btn-info btn-flat" Text="Enviar" OnClick="btnEnviar_Click" />
                                    </span>
                                </div>
                                <div>
                                    <asp:TextBox runat="server" ID="txtUrlVideo" style="display:none" ClientIDMode="Static" CssClass="form-control" placeholder="Agrega la URL..."></asp:TextBox>
                                </div>
                            </div>
                            <!-- /.box-body -->
                        </div>
                        <!-- /.box -->
                    </div>

                    <div class="col-md-12">
                        <!-- NUevo Mensaje FIN-->

                        <!-- The time line -->
                        <ul class="timeline">

                            <% 
                                var Tabla = (DataTable)Session["ListaComentariosMedia"];
                                if (Tabla != null)
                                {
                                    var ListaComentariosMedia = (from dt in Tabla.AsEnumerable()
                                                                 select new
                                                                 {
                                                                     uidmedia = dt.Field<string>("uidmedia"),
                                                                     codmedia = dt.Field<int>("codmedia"),
                                                                     uidproceso = dt.Field<string>("uidproceso"),
                                                                     uidtipocomentario = dt.Field<string>("uidtipocomentario"),
                                                                     cometario = dt.Field<string>("cometario"),
                                                                     imagen = dt.Field<string>("imagen"),
                                                                     url = dt.Field<string>("url"),
                                                                     FechaCreacionDMY = dt.Field<string>("FechaCreacionDMY"),
                                                                     HoraCreacionHM = dt.Field<string>("HoraCreacionHM"),
                                                                     UsuarioCreador = dt.Field<string>("UsuarioCreador"),
                                                                     MinutosAntiguedad=dt.Field<int?>("MinutosAntiguedad")
                                                                 }).Distinct().ToList();



                                    var ListafechasDMY = ListaComentariosMedia.OrderByDescending(x => x.FechaCreacionDMY).Select(x => x.FechaCreacionDMY).Distinct();

                                    foreach (var fechasDMY in ListafechasDMY)
                                    {%>
                            <!-- timeline time label -->
                            <li class="time-label">
                                <span class="bg-green">
                                    <%=fechasDMY%>
                                    
                                </span>
                            </li>
                            <%    
                                var ListaCOmentariosPorHM = ListaComentariosMedia.Where(x => x.FechaCreacionDMY == fechasDMY).OrderByDescending(x => x.HoraCreacionHM).ToList();
                                foreach (var comentario in ListaCOmentariosPorHM)
                                {
                            %>
                            <!-- timeline item -->
                            <li>
                                <% if (!string.IsNullOrEmpty(comentario.imagen) && string.IsNullOrEmpty(comentario.url))
                                    {%>
                                <i class="fa fa-camera bg-purple"></i>
                                <%}
                                    else
if (string.IsNullOrEmpty(comentario.imagen) && !string.IsNullOrEmpty(comentario.url))
                                    { %>
                                <i class="fa fa-video-camera bg-maroon"></i>
                                <%}
                                else
                                {%>
                                <i class="fa fa-comments bg-blue"></i>
                                <% } %>
                                <div class="timeline-item">
                                    <span class="time"><i class="fa fa-clock-o"></i><%=comentario.HoraCreacionHM%>
                                        <% if (comentario.MinutosAntiguedad.Value <= 5)
                                            {%>
                                                 <a  class="btn  btn-link btn-xs btn-flat"
                                           onclick ="CargarModalDeleteMedia(GetUIDValueGridViewMedia(this,'uidmedia'));"
                                                      uidmedia='<%=comentario.uidmedia%>'>                                             
                                             <i class="fa fa-remove"></i> Eliminar</a>           
                                                                                                                      
                                   
                                   <% } %>
                                         </span>
                                    <h3 class="timeline-header"><b><%=comentario.UsuarioCreador/*Nombre Usuario*/%></b></h3>

                                    <div class="timeline-body">

                                        <% if (!string.IsNullOrEmpty(comentario.url) && string.IsNullOrEmpty(comentario.imagen))
                                            {%>
                                        <%=comentario.cometario%>
                                        <br />
                                        <br />
                                        <div class="embed-responsive embed-responsive-16by9">

                                            <iframe class="embed-responsive-item" src="<%=comentario.url%>"
                                                frameborder="0" allowfullscreen></iframe>
                                        </div>
                                        <%}
                                            else
if (!string.IsNullOrEmpty(comentario.imagen) && string.IsNullOrEmpty(comentario.url))
                                            { %>
                                        <%=comentario.cometario%>
                                        <br />
                                        <br />
                                        <img src="data:image/jpeg;base64,<%=comentario.imagen%>" alt="..." class="margin img-responsive">

                                        <%}
                                        else
                                        {%>
                                        <%=comentario.cometario%>
                                        <% } %>
                                    </div>
                                    <div class="timeline-footer">
                                    </div>
                                </div>
                            </li>
                            <!-- END timeline item -->
                            <%
                                }
                            %>
                            <%
                                }
                            }

                            %>
                            <!-- END timeline item -->
                            <li>
                                <i class="fa fa-clock-o bg-gray"></i>
                            </li>
                        </ul>
                    </div>
                    <!-- /.col -->
                </div>
                <!-- /.row -->


            </section>
            <!-- /.content -->
        </div>
        <!-- /.content-wrapper -->

    </div>
    <!-- ./wrapper -->




    <!-- modal cargar imagen -->
    <uc1:Media_cu_delete runat="server" ID="Media_cu_delete" />
    <!-- modal cargar imagen FIN -->

    <!-- modal cargar video -->
    <script>  
        function ShowMessageVideo() {
            $('#txtUrlVideo').show();
        }
    </script>
    <div class="modal fade" id="msg-modal-video" data-keyboard="false" data-backdrop="static">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h4 class="modal-title">
                        <span id="msg-title-default">Cargar Video</span>
                    </h4>
                </div>
                <div class="modal-body">
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default" data-dismiss="modal">Cerrar</button>

                </div>
            </div>
            <!-- /.modal-content -->
        </div>
        <!-- /.modal-dialog -->
    </div>
    <!-- /.modal -->

    <!-- modal cargar video FIN -->

</asp:Content>
