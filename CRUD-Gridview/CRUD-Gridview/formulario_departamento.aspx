<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="formulario_departamento.aspx.cs" Inherits="CRUD_Gridview.formulario_departamento" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Departamneot"></asp:Label>
        <asp:TextBox ID="departamento" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="Descripcion"></asp:Label>
        <asp:TextBox ID="Descripcion" runat="server"></asp:TextBox>
    
    </div>
    </form>
</body>
</html>
