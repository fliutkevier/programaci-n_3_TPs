<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio3b.aspx.cs" Inherits="Trabajo_Practico4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 238px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblListado" runat="server" Font-Bold="True" Text="Listado de libros:"></asp:Label>
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
            <asp:GridView ID="grdLibros" runat="server">
            </asp:GridView>
                </td>
                <td>
            <asp:Label ID="lblError" runat="server" Font-Bold="True"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
            <asp:LinkButton ID="btnConsultarOtroTema" runat="server" OnClick="btnConsultarOtroTema_Click">Consultar otro tema</asp:LinkButton>
                </td>
                <td>
                    <asp:LinkButton ID="lnkSiguienteLibro" runat="server" OnClick="lnkSiguienteLibro_Click">Consultar siguiente libro</asp:LinkButton>
                </td>
            </tr>
        </table>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
