



<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Grupousuario_CU_Detalle.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Grupousuario.Grupousuario_CU_Detalle" %>


<script>
    function GetUIDValueGridViewGrupousuario(obj,attrib) {
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
                                  onclick ="CargarModalSelectGrupousuario(GetUIDValueGridViewGrupousuario(this,'uidgrupousuario'));"  uidgrupousuario='<%#Eval("uidgrupousuario")%>'><i class="fa fa-search"></i> Ver</a>                                  
                                
                                    <a runat="server" class="btn  btn-link btn-xs btn-flat"   
                                  onclick ="CargarModalUpdateGrupousuario(GetUIDValueGridViewGrupousuario(this,'uidgrupousuario'));"  uidgrupousuario='<%#Eval("uidgrupousuario")%>'><i class="fa fa-edit"></i> Editar</a>                                  
                                
                                        <a runat="server" class="btn  btn-link btn-xs btn-flat"   
                                  onclick ="CargarModalDeleteGrupousuario(GetUIDValueGridViewGrupousuario(this,'uidgrupousuario'));"  uidgrupousuario='<%#Eval("uidgrupousuario")%>'><i class="fa fa-remove"></i> Eliminar</a>                                                                      
                                </ItemTemplate>
                            </asp:TemplateField>
							  
					 <asp:BoundField  ReadOnly="True" HeaderText="uidgrupousuario" DataField="uidgrupousuario" SortExpression="uidgrupousuario" Visible="False"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Grupo" DataField="uidgrupo" SortExpression="uidgrupo" Visible="True"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Usuario" DataField="uidusuario" SortExpression="uidusuario" Visible="True"></asp:BoundField>
                            </Columns>
                    </asp:GridView>
        
