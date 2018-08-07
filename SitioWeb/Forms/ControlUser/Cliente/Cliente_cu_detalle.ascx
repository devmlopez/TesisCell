



<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Cliente_CU_Detalle.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Cliente.Cliente_CU_Detalle" %>


<script>
    function GetUIDValueGridViewCliente(obj,attrib) {
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
                                     <asp:LinkButton runat="server" ID="btnGridVer"  class="btn  btn-link btn-xs btn-flat"   
                                       OnClientClick="CargarModalSelectCliente(GetUIDValueGridViewCliente(this,'uidcliente')); return false;"  uidcliente='<%#Eval("uidcliente")%>'>
                                       <i class="fa fa-search"></i> Ver       
                                    </asp:LinkButton>
                                    <asp:LinkButton runat="server" ID="btnGridEditar" class="btn  btn-link btn-xs btn-flat"   
                                  OnClientClick="CargarModalUpdateCliente(GetUIDValueGridViewCliente(this,'uidcliente'));return false;"  uidcliente='<%#Eval("uidcliente")%>'><i class="fa fa-edit"></i> Editar
                                    </asp:LinkButton> 
                                                                                    
                                    <asp:LinkButton runat="server" ID="btnGridEliminar" class="btn  btn-link btn-xs btn-flat"   
                                  OnClientClick ="CargarModalDeleteCliente(GetUIDValueGridViewCliente(this,'uidcliente'));return false;"  uidcliente='<%#Eval("uidcliente")%>'><i class="fa fa-remove"></i> Eliminar
                                    </asp:LinkButton> 
                         </ItemTemplate>
                            </asp:TemplateField>
							  
					 <asp:BoundField  ReadOnly="True" HeaderText="uidcliente" DataField="uidcliente" SortExpression="uidcliente" Visible="False"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Cod. Cliente" DataField="id_cliente" SortExpression="id_cliente" Visible="True"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Tipo de Persona" DataField="aux1" SortExpression="aux1" Visible="True"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Identificacin" DataField="identificacion" SortExpression="identificacion" Visible="True"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Tipo Identificación" DataField="aux2" SortExpression="aux2" Visible="False"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Razón Social" DataField="razonsocial" SortExpression="razonsocial" Visible="True"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Nombre" DataField="nombre" SortExpression="nombre" Visible="True"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Contacto" DataField="contacto" SortExpression="contacto" Visible="True"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Celular" DataField="celular" SortExpression="celular" Visible="True"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Teléfono" DataField="telefono" SortExpression="telefono" Visible="False"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Dirección" DataField="direccion" SortExpression="direccion" Visible="False"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Provincia" DataField="provincia" SortExpression="provincia" Visible="False"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Ciudad" DataField="ciudad" SortExpression="ciudad" Visible="False"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Email" DataField="email" SortExpression="email" Visible="True"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Referencia" DataField="referencia" SortExpression="referencia" Visible="False"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Observaciones" DataField="observaciones" SortExpression="observaciones" Visible="False"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Cod. Usuario" DataField="aux3" SortExpression="aux3" Visible="True"></asp:BoundField>
                            </Columns>
                    </asp:GridView>
        
