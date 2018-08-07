



<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Loginuser_CU_Detalle.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Loginuser.Loginuser_CU_Detalle" %>


<script>
    function GetUIDValueGridViewLoginuser(obj,attrib) {
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
                                       OnClientClick="CargarModalSelectLoginuser(GetUIDValueGridViewLoginuser(this,'uidsuario'));return false;"  uidsuario='<%#Eval("uidsuario")%>'>
                                       <i class="fa fa-search"></i> Ver       
                                    </asp:LinkButton>
                                    <asp:LinkButton runat="server" ID="btnGridEditar" class="btn  btn-link btn-xs btn-flat"   
                                  OnClientClick ="CargarModalUpdateLoginuser(GetUIDValueGridViewLoginuser(this,'uidsuario'));return false;"  uidsuario='<%#Eval("uidsuario")%>'><i class="fa fa-edit"></i> Editar
                                    </asp:LinkButton> 
                                                                                    
                                    <asp:LinkButton runat="server" ID="btnGridEliminar" class="btn  btn-link btn-xs btn-flat"   
                                  OnClientClick ="CargarModalDeleteLoginuser(GetUIDValueGridViewLoginuser(this,'uidsuario'));return false;"  uidsuario='<%#Eval("uidsuario")%>'><i class="fa fa-remove"></i> Eliminar
                                    </asp:LinkButton> 

 </ItemTemplate>
                            </asp:TemplateField>
							  
					 <asp:BoundField  ReadOnly="True" HeaderText="uidsuario" DataField="uidsuario" SortExpression="uidsuario" Visible="False"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Usuario" DataField="usuario" SortExpression="usuario" Visible="True"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="E-mail" DataField="email" SortExpression="email" Visible="True"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Nombre" DataField="nombre" SortExpression="nombre" Visible="True"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Contraseña" DataField="contrasenia" SortExpression="contrasenia" Visible="True"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Rol" DataField="uidrol" SortExpression="uidrol" Visible="True"></asp:BoundField>
                            </Columns>
                    </asp:GridView>
        
