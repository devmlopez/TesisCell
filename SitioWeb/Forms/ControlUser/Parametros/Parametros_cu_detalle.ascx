



<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Parametros_CU_Detalle.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Parametros.Parametros_CU_Detalle" %>


<script>
    function GetUIDValueGridViewParametros(obj,attrib) {
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
                                       OnClientClick="CargarModalSelectParametros(GetUIDValueGridViewParametros(this,'uidparmetro'));return false;"  uidparmetro='<%#Eval("uidparmetro")%>'>
                                       <i class="fa fa-search"></i> Ver       
                                    </asp:LinkButton>
                                    <asp:LinkButton runat="server" ID="btnGridEditar" class="btn  btn-link btn-xs btn-flat"   
                                  OnClientClick ="CargarModalUpdateParametros(GetUIDValueGridViewParametros(this,'uidparmetro'));return false;"  uidparmetro='<%#Eval("uidparmetro")%>'><i class="fa fa-edit"></i> Editar
                                    </asp:LinkButton>                              
                                    <asp:LinkButton runat="server" ID="btnGridEliminar" class="btn  btn-link btn-xs btn-flat"   
                                  OnClientClick ="CargarModalDeleteParametros(GetUIDValueGridViewParametros(this,'uidparmetro'));return false;"  uidparmetro='<%#Eval("uidparmetro")%>'><i class="fa fa-remove"></i> Eliminar
                                    </asp:LinkButton> 
                               </ItemTemplate>
                            </asp:TemplateField>
							  
					 <asp:BoundField  ReadOnly="True" HeaderText="uidparmetro" DataField="uidparmetro" SortExpression="uidparmetro" Visible="False"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Mod.Ref." DataField="moduloreferencia" SortExpression="moduloreferencia" Visible="True"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Value" DataField="value" SortExpression="value" Visible="True"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Text-Short" DataField="textshort" SortExpression="textshort" Visible="True"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Text-Long" DataField="textlong" SortExpression="textlong" Visible="True"></asp:BoundField>
                            </Columns>
                    </asp:GridView>
        
