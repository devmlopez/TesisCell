



<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Serviciotecnico_CU_Detalle.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Serviciotecnico.Serviciotecnico_CU_Detalle" %>


<script>
    function GetUIDValueGridViewServiciotecnico(obj,attrib) {
        var value = obj.getAttribute(attrib);
       // alert(value);
        return value;
    }
</script>
  <asp:LinkButton runat="server" ID="btnRefrescarGridview" CssClass="btn btn-primary btn-xs btn-flat boton-Refresh" OnClick="btnRefrescarGridview_Click">
         <i class="fa fa-refresh"></i> Refrescar
                    </asp:LinkButton>
    <asp:GridView runat="server" ID="GridViewTable" CssClass="table table-hover table-bordered table-striped tableClassDefault" 
                        BorderWidth="0px"  AutoGenerateColumns="false" OnDataBound="GridViewTable_DataBound">
                        <Columns>
                            <asp:TemplateField ItemStyle-Width="240px">
                                
                                <ItemTemplate>
                                    <asp:LinkButton runat="server" ID="btnGridVer" class="btn  btn-link btn-xs btn-flat"   
                                       OnClientClick="CargarModalSelectServiciotecnico(GetUIDValueGridViewServiciotecnico(this,'uidserviciotecnico'));return false;" 
                                         uidserviciotecnico='<%#Eval("uidserviciotecnico")%>'>
                                       <i class="fa fa-search"></i> Ver       
                                    </asp:LinkButton>
                                    <asp:LinkButton runat="server" ID="btnGridEditar" class="btn  btn-link btn-xs btn-flat"   
                                  OnClientClick ="CargarModalUpdateServiciotecnico(GetUIDValueGridViewServiciotecnico(this,'uidserviciotecnico'));return false;" 
                                         uidserviciotecnico='<%#Eval("uidserviciotecnico")%>'><i class="fa fa-edit"></i> Editar
                                    </asp:LinkButton> 
                                                                                    
                                    <asp:LinkButton runat="server" ID="btnGridEliminar" class="btn  btn-link btn-xs btn-flat"   
                                  OnClientClick ="CargarModalDeleteServiciotecnico(GetUIDValueGridViewServiciotecnico(this,'uidserviciotecnico'));return false;" 
                                         uidserviciotecnico='<%#Eval("uidserviciotecnico")%>'><i class="fa fa-remove"></i> Eliminar
                                    </asp:LinkButton> 
                                                                              
                                </ItemTemplate>
                            </asp:TemplateField>
							  
					 <asp:BoundField  ReadOnly="True" HeaderText="uidserviciotecnico" DataField="uidserviciotecnico" SortExpression="uidserviciotecnico" Visible="False"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Cod. Servicio" DataField="codservicio" SortExpression="codservicio" Visible="false"></asp:BoundField>
					  <asp:TemplateField ItemStyle-Width="240px" HeaderText="Cod. Servicio">                                
                                <ItemTemplate>                                 
                                  <a runat="server" class="btn  btn-link btn-xs btn-flat" href='<%#Eval("aux3")%>' ><%#Eval("aux5")%> </a>                                                                      
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField  ReadOnly="True" HeaderText="Cliente" DataField="aux1" SortExpression="aux1" Visible="True"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Empleado" DataField="aux2" SortExpression="aux2" Visible="True"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Fecha Ingreso" DataField="fechaingreso" SortExpression="fechaingreso" Visible="True"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Fecha Salida" DataField="fechasalida" SortExpression="fechasalida" Visible="True"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="IMEI" DataField="IMEI" SortExpression="IMEI" Visible="True"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Marca" DataField="marca" SortExpression="marca" Visible="True"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Modelo" DataField="modelo" SortExpression="modelo" Visible="True"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Problema Sugerido" DataField="problemasugerido" SortExpression="problemasugerido" Visible="True"></asp:BoundField>
                            </Columns>
                    </asp:GridView>
        
