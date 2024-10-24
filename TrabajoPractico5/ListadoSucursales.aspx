<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListadoSucursales.aspx.cs" Inherits="TP5_GRUPO_17.ListadoSucursales" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 1399px;
        }
        .auto-style7 {
            height: 38px;
        }
        .auto-style10 {
            width: 175px;
            height: 38px;
        }
        .auto-style11 {
            width: 384px;
            height: 38px;
        }
        .auto-style31 {
            width: 175px;
        }
        .auto-style32 {
            width: 384px;
        }
        .auto-style34 {
            width: 175px;
            height: 23px;
        }
        .auto-style35 {
            height: 23px;
        }
        .auto-style36 {
            width: 218px;
            height: 23px;
        }
        .auto-style37 {
            width: 218px;
        }
        .auto-style38 {
            width: 202px;
            height: 23px;
        }
        .auto-style39 {
            width: 202px;
        }
        .auto-style40 {
            width: 182px;
            height: 23px;
        }
        .auto-style41 {
            width: 182px;
            height: 38px;
        }
        .auto-style42 {
            width: 182px;
        }
        .auto-style46 {
            width: 384px;
            height: 6px;
        }
        .auto-style47 {
            height: 6px;
        }
        .auto-style48 {
            width: 182px;
            height: 6px;
        }
        .auto-style49 {
            width: 175px;
            height: 6px;
        }
        .auto-style50 {
            width: 101px;
            height: 23px;
        }
        .auto-style51 {
            width: 101px;
            height: 38px;
        }
        .auto-style52 {
            width: 101px;
            height: 6px;
        }
        .auto-style53 {
            width: 101px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style36">
                    <asp:HyperLink ID="hlAgregarSucursal" runat="server" NavigateUrl="~/AgregarSucursal.aspx">Agregar Sucursal</asp:HyperLink>
                </td>
                <td class="auto-style38">
                    <asp:HyperLink ID="hlListadoSucursales" runat="server" NavigateUrl="~/ListadoSucursales.aspx">Listado de Sucursales</asp:HyperLink>
                </td>
                <td class="auto-style40">
                    <asp:HyperLink ID="hlEliminarSucursal" runat="server" NavigateUrl="~/EliminarSucursal.aspx">Eliminar Sucursal</asp:HyperLink>
                </td>
                <td class="auto-style50">
                    &nbsp;</td>
                <td class="auto-style34">
                    &nbsp;</td>
                <td class="auto-style34">
                </td>
                <td colspan="2" class="auto-style35">
                </td>
                <td class="auto-style34">
                    </td>
            </tr>
            <tr>
                <td class="auto-style7" colspan="2">
                    <asp:Label ID="lblListadoSucursales" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Listado de sucursales"></asp:Label>
                </td>
                <td class="auto-style41"></td>
                <td class="auto-style51"></td>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style11" colspan="2"></td>
                <td class="auto-style10"></td>
                <td class="auto-style10"></td>
            </tr>
            <tr>
                <td class="auto-style47" colspan="2">
                </td>
                <td class="auto-style48"></td>
                <td class="auto-style52"></td>
                <td class="auto-style46">&nbsp;</td>
                <td class="auto-style46" colspan="2"></td>
                <td class="auto-style49"></td>
                <td class="auto-style49"></td>
            </tr>
            <tr>
                <td class="auto-style37">
                    <asp:Label ID="lblBusqueda" runat="server" Text="Búsqueda           ingrese Id sucursal:"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:TextBox ID="txtBusquedaSucursal" runat="server" Width="242px" AutoPostBack="True" TextMode="Number"></asp:TextBox>
                </td>
                <td class="auto-style53">
                    <asp:Button ID="btnFiltrar" runat="server" Text="Filtrar" Width="61px" OnClick="btnFiltrar_Click" />
                </td>
                <td class="auto-style32">
                    <asp:Button ID="btnMostrarTodos" runat="server" OnClick="btnMostrarTodos_Click" Text="Mostrar todos" />
                </td>
                <td class="auto-style32" colspan="2">&nbsp;</td>
                <td class="auto-style31">&nbsp;</td>
                <td class="auto-style31">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style37">&nbsp;</td>
                <td class="auto-style39">&nbsp;</td>
                <td class="auto-style42">&nbsp;</td>
                <td class="auto-style53">&nbsp;</td>
                <td class="auto-style32">&nbsp;</td>
                <td class="auto-style32" colspan="2">&nbsp;</td>
                <td class="auto-style31">&nbsp;</td>
                <td class="auto-style31">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="5">
                    <asp:GridView ID="grdSucursales" runat="server">
                    </asp:GridView>
                </td>
                <td class="auto-style32" colspan="2">&nbsp;</td>
                <td class="auto-style31">&nbsp;</td>
                <td class="auto-style31">&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
