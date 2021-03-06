



<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Grupo_CU_Detalle.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Grupo.Grupo_CU_Detalle" %>


<script>
    function GetUIDValueGridViewGrupo(obj,attrib) {
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
                                  onclick ="CargarModalSelectGrupo(GetUIDValueGridViewGrupo(this,'uidgrupo'));"  uidgrupo='<%#Eval("uidgrupo")%>'><i class="fa fa-search"></i> Ver</a>                                  
                                
                                    <a runat="server" class="btn  btn-link btn-xs btn-flat"   
                                  onclick ="CargarModalUpdateGrupo(GetUIDValueGridViewGrupo(this,'uidgrupo'));"  uidgrupo='<%#Eval("uidgrupo")%>'><i class="fa fa-edit"></i> Editar</a>                                  
                                
                                        <a runat="server" class="btn  btn-link btn-xs btn-flat"   
                                  onclick ="CargarModalDeleteGrupo(GetUIDValueGridViewGrupo(this,'uidgrupo'));"  uidgrupo='<%#Eval("uidgrupo")%>'><i class="fa fa-remove"></i> Eliminar</a>                                                                      
                                </ItemTemplate>
                            </asp:TemplateField>
							  
					 <asp:BoundField  ReadOnly="True" HeaderText="uidgrupo" DataField="uidgrupo" SortExpression="uidgrupo" Visible="False"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Grupo" DataField="grupo" SortExpression="grupo" Visible="True"></asp:BoundField>
                            </Columns>
                    </asp:GridView>
        
