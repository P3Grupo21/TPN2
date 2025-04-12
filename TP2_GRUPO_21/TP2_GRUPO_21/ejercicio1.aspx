<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ejercicio1.aspx.cs" Inherits="TP2_GRUPO_21.ejercicio1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Button ID="btnGenerarTabla" runat="server" OnClick="btnGenerarTabla_Click" Text="Generar Tabla" />
        </p>
        <asp:Literal ID="litTabla" runat="server"></asp:Literal>
    </form>
</body>
</html>