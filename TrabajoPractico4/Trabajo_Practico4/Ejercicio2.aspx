<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2.aspx.cs" Inherits="Trabajo_Practico4.Ejercicio2" %>

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
            width: 102px;
        }
        .auto-style3 {
            width: 139px;
        }
        .auto-style4 {
            width: 102px;
            height: 27px;
        }
        .auto-style5 {
            width: 139px;
            height: 27px;
        }
        .auto-style6 {
            height: 27px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblIdProducto" runat="server" Font-Bold="True" Text="Id Producto:"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:DropDownList ID="ddlIdProducto" runat="server" AutoPostBack="True" Height="18px" Width="114px">
                            <asp:ListItem Value="0">Igual a:</asp:ListItem>
                            <asp:ListItem Value="1">Mayor a</asp:ListItem>
                            <asp:ListItem Value="2">Menor a:</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:TextBox ID="tbxIdProducto" runat="server" Width="250px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblIdCategoria" runat="server" Font-Bold="True" Text="Id Categoria:"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:DropDownList ID="ddlIdCategoria" runat="server" AutoPostBack="True" Height="18px" Width="114px">
                            <asp:ListItem Value="0">Igual a:</asp:ListItem>
                            <asp:ListItem Value="1">Mayor a</asp:ListItem>
                            <asp:ListItem Value="2">Menor a:</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:TextBox ID="tbxIdCategoria" runat="server" Width="250px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4"></td>
                    <td class="auto-style5"></td>
                    <td class="auto-style6">
                        <asp:Button ID="btnFiltrar" runat="server" Height="21px" OnClick="btnFiltrar_Click" Text="Filtrar" Width="67px" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnQuitarFiltro" runat="server" Height="22px" OnClick="btnQuitarFiltro_Click" Text="Quitar filtro" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </div>
        <asp:GridView ID="grdProductos" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
