<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inicio.aspx.cs" Inherits="prueba.inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 291px">
    
        HOLA MUNDO<br />
        <asp:Button ID="btnCargar" runat="server" OnClick="btnCargar_Click" Text="Boton" />
        <asp:GridView ID="gvDatos" runat="server">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
