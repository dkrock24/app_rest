<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Personal.aspx.cs" Inherits="CRUD_Gridview.Formulario" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script type="text/javascript">
        function ValidNum(e) {
            var tecla = document.all ? tecla = e.keyCode : tecla = e.which;
            return ((tecla > 47 && tecla < 58) || tecla == 46);
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center">
                <tr>
                    <td style="background-image: url('Imagenes/1.png')">
                        <h2 style="text-align: center">
                            <asp:Label ID="Label1" runat="server" Text="Mantenimiento de Personal" Style="color: #000066; font-weight: 700"></asp:Label>
                        </h2>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="GridPersonal" runat="server"
                            AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                            GridLines="None" AllowPaging="True" OnPageIndexChanging="GridPersonal_PageIndexChanging"
                            OnRowCancelingEdit="GridPersonal_RowCancelingEdit" OnRowDeleting="GridPersonal_RowDeleting"
                            OnRowEditing="GridPersonal_RowEditing" OnRowUpdating="GridPersonal_RowUpdating"
                            PageSize="5" DataKeyNames="Cod">
                            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                            <Columns>
                                <asp:TemplateField HeaderText="Codigo">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txtCod" runat="server" BorderStyle="None" ReadOnly="True" Text='<%# Bind("Cod") %>'
                                            MaxLength="4" Width="50px"></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("Cod") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Apellidos">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txtApe" runat="server" Text='<%# Bind("Ape") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("Ape") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Nombres">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txtNom" runat="server" Text='<%# Bind("Nom") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("Nom") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Dirección">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txtDir" runat="server" Text='<%# Bind("Dir") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label4" runat="server" Text='<%# Bind("Dir") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Teléfono">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txtTel" runat="server" Text='<%# Bind("Tel") %>' MaxLength="8" Width="75px"></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label5" runat="server" Text='<%# Bind("Tel") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="DUI">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txtDui" runat="server" Text='<%# Bind("Dui") %>' MaxLength="9" Width="75px"></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label6" runat="server" Text='<%# Bind("Dui") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Sexo">
                                    <EditItemTemplate>
                                        <asp:DropDownList ID="cboSex" runat="server">
                                            <asp:ListItem>Masculino</asp:ListItem>
                                            <asp:ListItem>Femenino</asp:ListItem>
                                        </asp:DropDownList>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label7" runat="server" Text='<%# Bind("Sex") %>'></asp:Label>
                                    </ItemTemplate>                             
                                    
                                                                  

                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="Departamento">
                                    <EditItemTemplate>
                                         <asp:DropDownList ID="txtDepto" name="txtDepto" runat="server" Width="100px" ToolTip="Selecione Departamento" DataSourceID="SqlDataSource1" DataTextField="nombre_depto" DataValueField="codigo_depto">
                                            <asp:ListItem>nada</asp:ListItem>                                            
                                        </asp:DropDownList>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label18" runat="server" Text='<%# Bind("nombre_depto") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:CommandField ButtonType="Button" ShowEditButton="True" />
                                <asp:CommandField ButtonType="Button" ShowDeleteButton="True" />
                            </Columns>
                            <EditRowStyle BackColor="#999999" />
                            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#E9E7E2" />
                            <SortedAscendingHeaderStyle BackColor="#506C8C" />
                            <SortedDescendingCellStyle BackColor="#FFFDF8" />
                            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td style="background-image: url('Imagenes/1.png')">
                        <asp:Button ID="btnNuevoRegistro" runat="server" Text="Agregar Nuevo Registro" OnClick="btnNuevoRegistro_Click" ToolTip="Agregar Nuevo Personal" />
                        <asp:Button ID="btnNueboDepartamento" runat="server" Text="Agregar Nuevo Departamento" OnClick="btnNuevoDepartamento_Click" ToolTip="Agregar Nuevo Departamento" />
                        
                        
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Panel ID="PanelFormulario" runat="server" Visible="False" BackImageUrl="~/Imagenes/2.jpg">
                            <table>
                                <tr>
                                    <td style="background-image: url('Imagenes/1.png')">Codigo</td>
                                    <td style="background-image: url('Imagenes/1.png')">
                                        <asp:TextBox ID="txtCodigo" runat="server" Width="80px" ToolTip="Ingrese Código" MaxLength="4"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="background-image: url('Imagenes/1.png')">Apellidos</td>
                                    <td style="background-image: url('Imagenes/1.png')">
                                        <asp:TextBox ID="txtApellidos" runat="server" Width="200px" ToolTip="Ingrese Apellidos"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="background-image: url('Imagenes/1.png')">Nombres</td>
                                    <td style="background-image: url('Imagenes/1.png')">
                                        <asp:TextBox ID="txtNombres" runat="server" Width="200px" ToolTip="Ingrese Nombres"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="background-image: url('Imagenes/1.png')">Telefono</td>
                                    <td style="background-image: url('Imagenes/1.png')">
                                        <asp:TextBox ID="txtTelefono" runat="server" MaxLength="8" Width="100px" ToolTip="Ingrese Teléfono"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="background-image: url('Imagenes/1.png')">Direccion</td>
                                    <td style="background-image: url('Imagenes/1.png')">
                                        <asp:TextBox ID="txtDireccion" runat="server" Width="200px" ToolTip="Ingrese Dirección"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="background-image: url('Imagenes/1.png')">Dui</td>
                                    <td style="background-image: url('Imagenes/1.png')">
                                        <asp:TextBox ID="txtDui" runat="server" MaxLength="9" Width="100px" ToolTip="Ingrese D.N.I."></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="background-image: url('Imagenes/1.png')">Sexo</td>
                                    <td style="background-image: url('Imagenes/1.png')">
                                        <asp:DropDownList ID="cbSexo" runat="server" Width="100px" ToolTip="Selecione Sexo">
                                            <asp:ListItem>Masculino</asp:ListItem>
                                            <asp:ListItem>Femenino</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                 <tr>
                                    <td style="background-image: url('Imagenes/1.png')">Departamento</td>
                                    <td style="background-image: url('Imagenes/1.png')">
                                        <asp:DropDownList ID="txtDepto" name="txtDepto" runat="server" Width="100px" ToolTip="Selecione Departamento" DataSourceID="SqlDataSource1" DataTextField="nombre_depto" DataValueField="codigo_depto">
                                            <asp:ListItem>nada</asp:ListItem>                                            
                                        </asp:DropDownList>
                                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PracticaConnectionString %>" SelectCommand="SELECT [nombre_depto], [codigo_depto] FROM [departamentos]"></asp:SqlDataSource>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="background-image: url('Imagenes/1.png')">
                                        <asp:Button ID="btnGrabar" runat="server" Text="Grabar" OnClick="btnGrabar_Click" Style="width: 57px" ToolTip="Grabar Personal" />
                                    </td>
                                    <td style="background-image: url('Imagenes/1.png')">
                                        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" Style="width: 77px" ToolTip="Cancelar" />
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>

                        <asp:Panel ID="PanelFormulario2" runat="server" Visible="false" BackImageUrl="~/Imagenes/2.jpg">
                            <div>
                                <asp:Label ID="Label8" runat="server" Text="Departamento"></asp:Label>
                                <asp:TextBox ID="txtDepartamento" name="departamento" runat="server"></asp:TextBox>
                                <asp:Label ID="Label2" runat="server" Text="Descripcion"></asp:Label>
                                <asp:TextBox ID="txtDescripcion" name="descripcion" runat="server"></asp:TextBox>   
                                 
                                <asp:Button ID="departament" runat="server" Text="Registrar" OnClick="departament_Click" />
                                 
                             </div>
                        </asp:Panel>
                    </td>
                </tr>
                <tr>
                    <td style="background-image: url('Imagenes/1.png')">
                        <asp:TextBox ID="txtMensaje" runat="server" Enabled="False" Width="100%"></asp:TextBox>
                        <br />


                     
                        <br />

                             
                    </td>
                </tr>
            </table>
        </div>
    </form>


    


</body>
</html>
