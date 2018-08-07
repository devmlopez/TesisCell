



<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Empleado_CU_Detalle.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Empleado.Empleado_CU_Detalle" %>


<script>
    function GetUIDValueGridViewEmpleado(obj,attrib) {
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
                                       OnClientClick ="CargarModalSelectEmpleado(GetUIDValueGridViewEmpleado(this,'uidempleado')); return false;"  uidempleado='<%#Eval("uidempleado")%>'>
                                       <i class="fa fa-search"></i> Ver       
                                    </asp:LinkButton>
                                    <asp:LinkButton runat="server" ID="btnGridEditar" class="btn  btn-link btn-xs btn-flat"   
                                  OnClientClick ="CargarModalUpdateEmpleado(GetUIDValueGridViewEmpleado(this,'uidempleado'));return false;"  uidempleado='<%#Eval("uidempleado")%>'><i class="fa fa-edit"></i> Editar
                                    </asp:LinkButton> 
                                                                                    
                                    <asp:LinkButton runat="server" ID="btnGridEliminar" class="btn  btn-link btn-xs btn-flat"   
                                  OnClientClick ="CargarModalDeleteEmpleado(GetUIDValueGridViewEmpleado(this,'uidempleado'));return false;"  uidempleado='<%#Eval("uidempleado")%>'><i class="fa fa-remove"></i> Eliminar
                                    </asp:LinkButton> 
                          </ItemTemplate>
                            </asp:TemplateField>
							  
					 <asp:BoundField  ReadOnly="True" HeaderText="UIDEMPLEADO" DataField="uidempleado" SortExpression="uidempleado" Visible="False"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Cod. Empleado" DataField="codido" SortExpression="codido" Visible="True"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Cédula" DataField="cedula" SortExpression="cedula" Visible="True"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Nombres" DataField="nombres" SortExpression="nombres" Visible="True"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Apellidos" DataField="apellidos" SortExpression="apellidos" Visible="True"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Est. Civil" DataField="aux1" SortExpression="aux1" Visible="False"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Fec. Nac." DataField="fechanacimiento" SortExpression="fechanacimiento" Visible="True"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Sexo" DataField="aux4" SortExpression="aux4" Visible="True"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Teléfono" DataField="telefono" SortExpression="telefono" Visible="False"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Cant. Hijos" DataField="num_hijos" SortExpression="num_hijos" Visible="False"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Nivel de Estudios" DataField="aux2" SortExpression="aux2" Visible="False"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Título Obtenido" DataField="titulo_obtenido" SortExpression="titulo_obtenido" Visible="False"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Dirección Domicilio" DataField="direccion_domicilio" SortExpression="direccion_domicilio" Visible="False"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Provincia" DataField="provincia" SortExpression="provincia" Visible="False"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Ciudad" DataField="ciudad" SortExpression="ciudad" Visible="False"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="E-mail" DataField="email" SortExpression="email" Visible="True"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Email Trab." DataField="email_trabajo" SortExpression="email_trabajo" Visible="True"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Fec. Ingreso" DataField="fecha_ingreso" SortExpression="fecha_ingreso" Visible="False"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Usuario" DataField="aux3" SortExpression="aux3" Visible="True"></asp:BoundField>
                            </Columns>
                    </asp:GridView>
        
