



<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Menu_CU_Detalle.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Menu.Menu_CU_Detalle" %>


<script>
    function GetUIDValueGridViewMenu(obj,attrib) {
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
                                       OnClientClick ="CargarModalSelectMenu(GetUIDValueGridViewMenu(this,'uidmenu'));"  uidmenu='<%#Eval("uidmenu")%>'>
                                       <i class="fa fa-search"></i> Ver       
                                    </asp:LinkButton>
                                    <asp:LinkButton runat="server" ID="btnGridEditar" class="btn  btn-link btn-xs btn-flat"   
                                  OnClientClick="CargarModalUpdateMenu(GetUIDValueGridViewMenu(this,'uidmenu'));"  uidmenu='<%#Eval("uidmenu")%>'><i class="fa fa-edit"></i> Editar
                                    </asp:LinkButton> 
                                                                                    
                                    <asp:LinkButton runat="server" ID="btnGridEliminar" class="btn  btn-link btn-xs btn-flat"   
                                  OnClientClick ="CargarModalDeleteMenu(GetUIDValueGridViewMenu(this,'uidmenu'));"  uidmenu='<%#Eval("uidmenu")%>'><i class="fa fa-remove"></i> Eliminar
                                    </asp:LinkButton> 
                                     </ItemTemplate>
                            </asp:TemplateField>
							  
					 <asp:BoundField  ReadOnly="True" HeaderText="uidmenu" DataField="uidmenu" SortExpression="uidmenu" Visible="False"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Rol" DataField="uidrol" SortExpression="uidrol" Visible="True"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Página" DataField="uidpagina" SortExpression="uidpagina" Visible="True"></asp:BoundField>
					 <asp:CheckBoxField  ReadOnly="True" HeaderText="Visible" DataField="esvisible" SortExpression="esvisible" Visible="True"></asp:CheckBoxField>
					 <asp:CheckBoxField  ReadOnly="True" HeaderText="Mostrar" DataField="semuestra" SortExpression="semuestra" Visible="True"></asp:CheckBoxField>
                            </Columns>
                    </asp:GridView>
        
