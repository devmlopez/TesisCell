



<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Rol_CU_Detalle.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Rol.Rol_CU_Detalle" %>


<script>
    function GetUIDValueGridViewRol(obj,attrib) {
        var value = obj.getAttribute(attrib);
       // alert(value);
        return value;
    }
</script>
  <asp:LinkButton runat="server" ID="btnRefrescarGridview" CssClass="btn btn-primary btn-xs btn-flat boton-Refresh" OnClick="btnRefrescarGridview_Click">
         <i class="fa fa-refresh"></i> Refrescar
                    </asp:LinkButton>
    <asp:GridView runat="server" ID="GridViewTable" CssClass="table table-hover table-bordered table-striped tableClassDefault" 
                        BorderWidth="0px"  AutoGenerateColumns="false"
         OnDataBound="GridViewTable_DataBound">
                        <Columns>
                            <asp:TemplateField ItemStyle-Width="240px">
                                
                                <ItemTemplate>
                                    <asp:LinkButton runat="server" ID="btnGridVer" class="btn  btn-link btn-xs btn-flat"   
                                       OnClientClick="CargarModalSelectRol(GetUIDValueGridViewRol(this,'uidrol'));return false;"  uidrol='<%#Eval("uidrol")%>'>
                                       <i class="fa fa-search"></i> Ver       
                                    </asp:LinkButton>
                                    <asp:LinkButton runat="server" ID="btnGridEditar" class="btn  btn-link btn-xs btn-flat"   
                                  OnClientClick ="CargarModalUpdateRol(GetUIDValueGridViewRol(this,'uidrol'));return false;"  uidrol='<%#Eval("uidrol")%>'><i class="fa fa-edit"></i> Editar
                                    </asp:LinkButton> 
                                                                                    
                                    <asp:LinkButton runat="server" ID="btnGridEliminar" class="btn  btn-link btn-xs btn-flat"   
                                  OnClientClick ="CargarModalDeleteRol(GetUIDValueGridViewRol(this,'uidrol'));return false;"  uidrol='<%#Eval("uidrol")%>'><i class="fa fa-remove"></i> Eliminar
                                    </asp:LinkButton>                                     
                                </ItemTemplate>
                            </asp:TemplateField>
							  
					 <asp:BoundField  ReadOnly="True" HeaderText="uidrol" DataField="uidrol" SortExpression="uidrol" Visible="False"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Rol" DataField="rol" SortExpression="rol" Visible="True"></asp:BoundField>
					 <asp:CheckBoxField  ReadOnly="True" HeaderText="Lectura" DataField="permisolectura" SortExpression="permisolectura" Visible="True"></asp:CheckBoxField>
					 <asp:CheckBoxField  ReadOnly="True" HeaderText="Escritura" DataField="permisoescritura" SortExpression="permisoescritura" Visible="True"></asp:CheckBoxField>
					 <asp:CheckBoxField  ReadOnly="True" HeaderText="Consulta" DataField="permisoconsultar" SortExpression="permisoconsultar" Visible="True"></asp:CheckBoxField>
					 <asp:CheckBoxField  ReadOnly="True" HeaderText="Crear" DataField="perisocrear" SortExpression="perisocrear" Visible="True"></asp:CheckBoxField>
					 <asp:CheckBoxField  ReadOnly="True" HeaderText="Editar" DataField="permisoeditar" SortExpression="permisoeditar" Visible="True"></asp:CheckBoxField>
					 <asp:CheckBoxField  ReadOnly="True" HeaderText="Eliminar" DataField="permisoeliminar" SortExpression="permisoeliminar" Visible="True"></asp:CheckBoxField>
					 <asp:CheckBoxField  ReadOnly="True" HeaderText="Total" DataField="permisototal" SortExpression="permisototal" Visible="True"></asp:CheckBoxField>
					 <asp:CheckBoxField  ReadOnly="True" HeaderText="Nulo" DataField="permisonulo" SortExpression="permisonulo" Visible="True"></asp:CheckBoxField>
                            </Columns>
                    </asp:GridView>
        
