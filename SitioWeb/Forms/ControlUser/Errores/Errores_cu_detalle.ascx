



<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Errores_CU_Detalle.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Errores.Errores_CU_Detalle" %>


<script>
    function GetUIDValueGridViewErrores(obj,attrib) {
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
                                  onclick ="CargarModalSelectErrores(GetUIDValueGridViewErrores(this,'uid_error'));"  uid_error='<%#Eval("uid_error")%>'><i class="fa fa-search"></i> Ver</a>                                  
                                
                                    <a runat="server" class="btn  btn-link btn-xs btn-flat"   
                                  onclick ="CargarModalUpdateErrores(GetUIDValueGridViewErrores(this,'uid_error'));"  uid_error='<%#Eval("uid_error")%>'><i class="fa fa-edit"></i> Editar</a>                                  
                                
                                        <a runat="server" class="btn  btn-link btn-xs btn-flat"   
                                  onclick ="CargarModalDeleteErrores(GetUIDValueGridViewErrores(this,'uid_error'));"  uid_error='<%#Eval("uid_error")%>'><i class="fa fa-remove"></i> Eliminar</a>                                                                      
                                </ItemTemplate>
                            </asp:TemplateField>
							  
					 <asp:BoundField  ReadOnly="True" HeaderText="uid_Error" DataField="uid_error" SortExpression="uid_error" Visible="False"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Cod. Error" DataField="cod_error" SortExpression="cod_error" Visible="True"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Mens. Usuario" DataField="mensajeusuario" SortExpression="mensajeusuario" Visible="True"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Mens. Nativo" DataField="mensajenativo" SortExpression="mensajenativo" Visible="True"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Origen del Error" DataField="origenerror" SortExpression="origenerror" Visible="True"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Tipo de Error" DataField="tipoerror" SortExpression="tipoerror" Visible="True"></asp:BoundField>
                            </Columns>
                    </asp:GridView>
        
