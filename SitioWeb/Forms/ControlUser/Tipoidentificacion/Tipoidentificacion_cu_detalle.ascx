



<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Tipoidentificacion_CU_Detalle.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Tipoidentificacion.Tipoidentificacion_CU_Detalle" %>


<script>
    function GetUIDValueGridViewTipoidentificacion(obj,attrib) {
        var value = obj.getAttribute(attrib);
       // alert(value);
        return value;
    }
</script>
  <asp:LinkButton runat="server" ID="btnRefrescarGridview" CssClass="btn btn-primary btn-xs btn-flat boton-Refresh" OnClick="btnRefrescarGridview_Click">
         <i class="fa fa-refresh"></i> Refrescar
                    </asp:LinkButton>
    <asp:GridView runat="server" ID="GridViewTable" CssClass="table table-hover table-bordered table-striped tableClassDefault" 
                        BorderWidth="0px"  AutoGenerateColumns="false">
                        <Columns>
                            <asp:TemplateField ItemStyle-Width="240px">
                                
                                <ItemTemplate>
                                  <a runat="server" class="btn  btn-link btn-xs btn-flat"   
                                  onclick ="CargarModalSelectTipoidentificacion(GetUIDValueGridViewTipoidentificacion(this,'uidtipoidentificacion'));"  uidtipoidentificacion='<%#Eval("uidtipoidentificacion")%>'><i class="fa fa-search"></i> Ver</a>                                  
                                
                                    <a runat="server" class="btn  btn-link btn-xs btn-flat"   
                                  onclick ="CargarModalUpdateTipoidentificacion(GetUIDValueGridViewTipoidentificacion(this,'uidtipoidentificacion'));"  uidtipoidentificacion='<%#Eval("uidtipoidentificacion")%>'><i class="fa fa-edit"></i> Editar</a>                                  
                                
                                        <a runat="server" class="btn  btn-link btn-xs btn-flat"   
                                  onclick ="CargarModalDeleteTipoidentificacion(GetUIDValueGridViewTipoidentificacion(this,'uidtipoidentificacion'));"  uidtipoidentificacion='<%#Eval("uidtipoidentificacion")%>'><i class="fa fa-remove"></i> Eliminar</a>                                                                      
                                </ItemTemplate>
                            </asp:TemplateField>
							  
					 <asp:BoundField  ReadOnly="True" HeaderText="uidtipoidentificacion" DataField="uidtipoidentificacion" SortExpression="uidtipoidentificacion" Visible="False"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Tipo Identificación" DataField="tipoidentificacion" SortExpression="tipoidentificacion" Visible="True"></asp:BoundField>
                            </Columns>
                    </asp:GridView>
        
