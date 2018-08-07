



<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Paginagrupo_CU_Detalle.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Paginagrupo.Paginagrupo_CU_Detalle" %>


<script>
    function GetUIDValueGridViewPaginagrupo(obj,attrib) {
        var value = obj.getAttribute(attrib);
       // alert(value);
        return value;
    }
</script>
  <asp:LinkButton runat="server" ID="btnRefrescarGridview" CssClass="btn btn-primary btn-xs btn-flat boton-Refresh botonOpcionesControlUserClass" OnClick="btnRefrescarGridview_Click">
         <i class="fa fa-refresh"></i> Refrescar
                    </asp:LinkButton>
    <asp:GridView runat="server" ID="GridViewTable" CssClass="table table-hover table-bordered table-striped tableClassDefault" 
                        BorderWidth="0px"  AutoGenerateColumns="false">
                        <Columns>
                            <asp:TemplateField ItemStyle-Width="240px">
                                
                                <ItemTemplate>
                                  <a runat="server" class="btn  btn-link btn-xs btn-flat"   
                                  onclick ="CargarModalSelectPaginagrupo(GetUIDValueGridViewPaginagrupo(this,'uidpaginagrupo'));"  uidpaginagrupo='<%#Eval("uidpaginagrupo")%>'><i class="fa fa-search"></i> Ver</a>                                  
                                
                                    <a runat="server" class="btn  btn-link btn-xs btn-flat"   
                                  onclick ="CargarModalUpdatePaginagrupo(GetUIDValueGridViewPaginagrupo(this,'uidpaginagrupo'));"  uidpaginagrupo='<%#Eval("uidpaginagrupo")%>'><i class="fa fa-edit"></i> Editar</a>                                  
                                
                                        <a runat="server" class="btn  btn-link btn-xs btn-flat"   
                                  onclick ="CargarModalDeletePaginagrupo(GetUIDValueGridViewPaginagrupo(this,'uidpaginagrupo'));"  uidpaginagrupo='<%#Eval("uidpaginagrupo")%>'><i class="fa fa-remove"></i> Eliminar</a>                                                                      
                                </ItemTemplate>
                            </asp:TemplateField>
							  
					 <asp:BoundField  ReadOnly="True" HeaderText="uidpaginagrupo" DataField="uidpaginagrupo" SortExpression="uidpaginagrupo" Visible="False"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Página" DataField="uidpagina" SortExpression="uidpagina" Visible="True"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Grupo" DataField="uidgrupo" SortExpression="uidgrupo" Visible="True"></asp:BoundField>
                            </Columns>
                    </asp:GridView>
        
