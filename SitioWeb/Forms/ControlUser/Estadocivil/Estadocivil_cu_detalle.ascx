



<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Estadocivil_CU_Detalle.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.Estadocivil.Estadocivil_CU_Detalle" %>


<script>
    function GetUIDValueGridViewEstadocivil(obj,attrib) {
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
                                  onclick ="CargarModalSelectEstadocivil(GetUIDValueGridViewEstadocivil(this,'uidestadocivil'));"  uidestadocivil='<%#Eval("uidestadocivil")%>'><i class="fa fa-search"></i> Ver</a>                                  
                                
                                    <a runat="server" class="btn  btn-link btn-xs btn-flat"   
                                  onclick ="CargarModalUpdateEstadocivil(GetUIDValueGridViewEstadocivil(this,'uidestadocivil'));"  uidestadocivil='<%#Eval("uidestadocivil")%>'><i class="fa fa-edit"></i> Editar</a>                                  
                                
                                        <a runat="server" class="btn  btn-link btn-xs btn-flat"   
                                  onclick ="CargarModalDeleteEstadocivil(GetUIDValueGridViewEstadocivil(this,'uidestadocivil'));"  uidestadocivil='<%#Eval("uidestadocivil")%>'><i class="fa fa-remove"></i> Eliminar</a>                                                                      
                                </ItemTemplate>
                            </asp:TemplateField>
							  
					 <asp:BoundField  ReadOnly="True" HeaderText="uidestadocivil" DataField="uidestadocivil" SortExpression="uidestadocivil" Visible="False"></asp:BoundField>
					 <asp:BoundField  ReadOnly="True" HeaderText="Est. Civil" DataField="estadocivil" SortExpression="estadocivil" Visible="True"></asp:BoundField>
                            </Columns>
                    </asp:GridView>
        
