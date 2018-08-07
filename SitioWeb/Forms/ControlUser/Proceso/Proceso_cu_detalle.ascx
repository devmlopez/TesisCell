



<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Proceso_CU_Detalle.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Proceso.Proceso_CU_Detalle" %>


<script>
    function GetUIDValueGridViewProceso(obj,attrib) {
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
                                       OnClientClick="CargarModalSelectProceso(GetUIDValueGridViewProceso(this,'uidproceso'));return false;"  uidproceso='<%#Eval("uidproceso")%>'>
                                       <i class="fa fa-search"></i> Ver       
                                    </asp:LinkButton>
                                    <asp:LinkButton runat="server" ID="btnGridEditar" class="btn  btn-link btn-xs btn-flat"   
                                  OnClientClick ="CargarModalUpdateProceso(GetUIDValueGridViewProceso(this,'uidproceso'));return false;"  uidproceso='<%#Eval("uidproceso")%>'><i class="fa fa-edit"></i> Editar
                                    </asp:LinkButton> 
                                                                                    
                                    <asp:LinkButton runat="server" ID="btnGridEliminar" class="btn  btn-link btn-xs btn-flat"   
                                  OnClientClick ="CargarModalDeleteProceso(GetUIDValueGridViewProceso(this,'uidproceso'));return false;"  uidproceso='<%#Eval("uidproceso")%>'><i class="fa fa-remove"></i> Eliminar
                                    </asp:LinkButton> 
                             </ItemTemplate>
                            </asp:TemplateField>
							  
					 <asp:BoundField  ReadOnly="True" HeaderText="uidproceso" DataField="uidproceso" SortExpression="uidproceso" Visible="False"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="od. Proceso" DataField="codproceso" SortExpression="codproceso" Visible="True"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Cod. Servicio" DataField="uidserviciotecnico" SortExpression="uidserviciotecnico" Visible="True"></asp:BoundField>
                            </Columns>
                    </asp:GridView>
        
