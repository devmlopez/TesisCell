



<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Pagina_CU_Detalle.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Pagina.Pagina_CU_Detalle" %>


<script>
    function GetUIDValueGridViewPagina(obj,attrib) {
        var value = obj.getAttribute(attrib);
       // alert(value);
        return value;
    }
</script>
  <asp:LinkButton runat="server" ID="btnRefrescarGridview" CssClass="btn btn-primary btn-xs btn-flat boton-Refresh botonOpcionesControlUserClass" OnClick="btnRefrescarGridview_Click">
         <i class="fa fa-refresh"></i> Refrescar
                    </asp:LinkButton>
    <asp:GridView runat="server" ID="GridViewTable" CssClass="table table-hover table-bordered table-striped tableClassDefault" 
                        BorderWidth="0px"  AutoGenerateColumns="false"
           OnDataBound="GridViewTable_DataBound">
                        <Columns>
                            <asp:TemplateField ItemStyle-Width="240px">
                                
                                <ItemTemplate>
                                     <asp:LinkButton runat="server" ID="btnGridVer" class="btn  btn-link btn-xs btn-flat"   
                                       OnClientClick ="CargarModalSelectPagina(GetUIDValueGridViewPagina(this,'uidpagina'));return false;"  uidpagina='<%#Eval("uidpagina")%>'>
                                       <i class="fa fa-search"></i> Ver       
                                    </asp:LinkButton>
                                    <asp:LinkButton runat="server" ID="btnGridEditar" class="btn  btn-link btn-xs btn-flat"   
                                  OnClientClick ="CargarModalUpdatePagina(GetUIDValueGridViewPagina(this,'uidpagina'));return false;"  uidpagina='<%#Eval("uidpagina")%>'><i class="fa fa-edit"></i> Editar
                                    </asp:LinkButton> 
                                                                                    
                                    <asp:LinkButton runat="server" ID="btnGridEliminar" class="btn  btn-link btn-xs btn-flat"   
                                  OnClientClick ="CargarModalDeletePagina(GetUIDValueGridViewPagina(this,'uidpagina'));return false;"  uidpagina='<%#Eval("uidpagina")%>'><i class="fa fa-remove"></i> Eliminar
                                    </asp:LinkButton> 

                                </ItemTemplate>
                            </asp:TemplateField>
							  
					 <asp:BoundField  ReadOnly="True" HeaderText="uidpagina" DataField="uidpagina" SortExpression="uidpagina" Visible="False"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Página" DataField="pagina" SortExpression="pagina" Visible="True"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Full Url" DataField="fullurl" SortExpression="fullurl" Visible="True"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Tipo Imagen" DataField="aux1" SortExpression="aux1" Visible="True"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Icono" DataField="iconoimg" SortExpression="iconoimg" Visible="True"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Orden" DataField="orden" SortExpression="orden" Visible="True"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Pág. Padre" DataField="aux2" SortExpression="aux2" Visible="True"></asp:BoundField>
                            </Columns>
                    </asp:GridView>
        
