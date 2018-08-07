



<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Media_CU_Detalle.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Media.Media_CU_Detalle" %>
<%@ Register Src="~/Forms/ControlUser/Media/Media_cu_insert.ascx" TagPrefix="uc1" TagName="Media_cu_insert" %>



<script>
    function GetUIDValueGridViewMedia(obj,attrib) {
        var value = obj.getAttribute(attrib);
       // alert(value);
        return value;
    }
</script>
  <asp:LinkButton runat="server" ID="btnRefrescarGridview" CssClass="btn btn-primary btn-xs btn-flat boton-Refresh" OnClick="btnRefrescarGridview_Click">
         <i class="fa fa-refresh"></i> Refrescar
                    </asp:LinkButton>
<uc1:Media_cu_insert runat="server" ID="Media_cu_insert" />
    <asp:GridView runat="server" ID="GridViewTable" CssClass="table table-hover table-bordered table-striped tableClassDefault" 
                        BorderWidth="0px"  AutoGenerateColumns="false"   ShowHeader="false"
        OnDataBound="GridViewTable_DataBound">
                        <Columns>
                            <asp:TemplateField ItemStyle-Width="240px">
                                
                                <ItemTemplate>

                                     <asp:LinkButton runat="server" ID="btnGridVer" class="btn  btn-link btn-xs btn-flat"   
                                       OnClientClick="CargarModalSelectMedia(GetUIDValueGridViewMedia(this,'uidmedia'));return false;"  uidmedia='<%#Eval("uidmedia")%>'>
                                       <i class="fa fa-search"></i> Ver       
                                    </asp:LinkButton>
                                  <%--  <asp:LinkButton runat="server" ID="btnGridEditar" class="btn  btn-link btn-xs btn-flat"   
                                  OnClientClick ="CargarModalUpdateMedia(GetUIDValueGridViewMedia(this,'uidmedia'));return false;"  uidmedia='<%#Eval("uidmedia")%>'><i class="fa fa-edit"></i> Editar
                                    </asp:LinkButton> 
                                                                                    
                                    <asp:LinkButton runat="server" ID="btnGridEliminar" class="btn  btn-link btn-xs btn-flat"   
                                  OnClientClick ="CargarModalDeleteMedia(GetUIDValueGridViewMedia(this,'uidmedia'));return false;"  uidmedia='<%#Eval("uidmedia")%>'><i class="fa fa-remove"></i> Eliminar
                                    </asp:LinkButton> --%>


                                 </ItemTemplate>
                            </asp:TemplateField>
							  
					 <asp:BoundField  ReadOnly="True" HeaderText="uidmedia" DataField="uidmedia" SortExpression="uidmedia" Visible="False"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Cod. Media" DataField="codmedia" SortExpression="codmedia" Visible="False"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Cod. Proceso" DataField="uidproceso" SortExpression="uidproceso" Visible="False"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Tipo Comentario" DataField="uidtipocomentario" SortExpression="uidtipocomentario" Visible="False"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Comentario" DataField="cometario" SortExpression="cometario" Visible="True"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Imagen" DataField="imagen" SortExpression="imagen" Visible="True"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Url" DataField="url" SortExpression="url" Visible="True"></asp:BoundField>
                            </Columns>
                    </asp:GridView>
        
