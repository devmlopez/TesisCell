



<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Empresa_CU_Detalle.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Empresa.Empresa_CU_Detalle" %>


<script>
    function GetUIDValueGridViewEmpresa(obj,attrib) {
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
                                  onclick ="CargarModalSelectEmpresa(GetUIDValueGridViewEmpresa(this,'uid_empresa'));"  uid_empresa='<%#Eval("uid_empresa")%>'><i class="fa fa-search"></i> Ver</a>                                  
                                
                                    <a runat="server" class="btn  btn-link btn-xs btn-flat"   
                                  onclick ="CargarModalUpdateEmpresa(GetUIDValueGridViewEmpresa(this,'uid_empresa'));"  uid_empresa='<%#Eval("uid_empresa")%>'><i class="fa fa-edit"></i> Editar</a>                                  
                                
                                        <a runat="server" class="btn  btn-link btn-xs btn-flat"   
                                  onclick ="CargarModalDeleteEmpresa(GetUIDValueGridViewEmpresa(this,'uid_empresa'));"  uid_empresa='<%#Eval("uid_empresa")%>'><i class="fa fa-remove"></i> Eliminar</a>                                                                      
                                </ItemTemplate>
                            </asp:TemplateField>
							  
					 <asp:BoundField  ReadOnly="True" HeaderText="uid_empresa" DataField="uid_empresa" SortExpression="uid_empresa" Visible="False"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Ruc" DataField="ruc" SortExpression="ruc" Visible="True"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Nombre" DataField="nombre" SortExpression="nombre" Visible="True"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Descripción" DataField="descripcion" SortExpression="descripcion" Visible="True"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Dirección" DataField="direccion" SortExpression="direccion" Visible="True"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Teléfono" DataField="telefono" SortExpression="telefono" Visible="True"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Representante Légal" DataField="representantelegal" SortExpression="representantelegal" Visible="True"></asp:BoundField>
                            </Columns>
                    </asp:GridView>
        
