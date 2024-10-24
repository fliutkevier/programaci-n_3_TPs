<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListadoSucursales.aspx.cs" Inherits="Vista.ListadoSucursales" %>

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
        .auto-style37 {
            width: 248px;
        }
        .auto-style38 {
            width: 384px;
            height: 23px;
        }
        .auto-style40 {
            width: 150px;
        }
        .auto-style43 {
            width: 150px;
            height: 38px;
        }
        .auto-style44 {
            width: 252px;
        }
        .auto-style46 {
            width: 174px;
            height: 38px;
        }
        .auto-style47 {
            width: 173px;
            height: 38px;
        }
        .auto-style48 {
            width: 184px;
        }
        .auto-style49 {
            width: 176px;
            height: 38px;
        }
        .auto-style50 {
            width: 184px;
            height: 38px;
        }
        .auto-style51 {
            width: 252px;
            height: 27px;
        }
        .auto-style52 {
            width: 248px;
            height: 27px;
        }
        .auto-style53 {
            width: 184px;
            height: 27px;
        }
        .auto-style54 {
            width: 150px;
            height: 27px;
        }
        .auto-style55 {
            width: 384px;
            height: 27px;
        }
        .auto-style56 {
            width: 175px;
            height: 27px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style44">
                    &nbsp;</td>
                <td class="auto-style37">
                    <asp:HyperLink ID="hlAgregarSucursal" runat="server" NavigateUrl="~/AgregarSucursal.aspx">Agregar Sucursal</asp:HyperLink>
                </td>
                <td class="auto-style48">
                    <asp:HyperLink ID="hlListadoSucursales" runat="server" NavigateUrl="~/ListadoSucursales.aspx">Listado de Sucursales</asp:HyperLink>
                </td>
                <td class="auto-style40">
                     &nbsp;</td>
                <td class="auto-style34">
                     <asp:HyperLink ID="hlEliminarSucursal" runat="server" NavigateUrl="~/EliminarSucursal.aspx">Eliminar Sucursal</asp:HyperLink>
                </td>
                <td class="auto-style38">
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
                <td class="auto-style50"></td>
                <td class="auto-style43"></td>
                <td class="auto-style11"></td>
                <td class="auto-style11" colspan="2"></td>
                <td class="auto-style10"></td>
                <td class="auto-style10"></td>
            </tr>
            <tr>
                <td class="auto-style47" colspan="2">
                </td>
                <td class="auto-style48"></td>
                <td class="auto-style40"></td>
                <td class="auto-style32">&nbsp;</td>
                <td class="auto-style46" colspan="2"></td>
                <td class="auto-style49"></td>
                <td class="auto-style49"></td>
            </tr>
            <tr>
                <td class="auto-style44">
                    <asp:Label ID="lblBusqueda" runat="server" Text="Búsqueda ingrese Id sucursal:"></asp:Label>
                </td>
                <td class="auto-style37">
                    <asp:TextBox ID="txtBusqueda" runat="server" Width="197px"></asp:TextBox>
                </td>
                <td class="auto-style48">
                    <asp:Button ID="btnFiltrar" runat="server" Text="Filtrar" Width="68px" OnClick="btnFiltrar_Click" />
                </td>
                <td class="auto-style40">
                    <asp:Button ID="btnMostrarTodos" runat="server" Text="Mostrar todos" OnClick="btnMostrarTodos_Click" />
                </td>
                <td class="auto-style32">
                    <br />
                </td>
                <td class="auto-style32" colspan="2">&nbsp;</td>
                <td class="auto-style31">&nbsp;</td>
                <td class="auto-style31">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style51"></td>
                <td class="auto-style52">
                    <asp:Label ID="lblMensaje" runat="server" ForeColor="Red"></asp:Label>
                    <br />
                    <br />
                </td>
                <td class="auto-style53">&nbsp;</td>
                <td class="auto-style54"></td>
                <td class="auto-style55"></td>
                <td class="auto-style55" colspan="2"></td>
                <td class="auto-style56"></td>
                <td class="auto-style56"></td>
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
        