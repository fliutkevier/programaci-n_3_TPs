<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EliminarSucursal.aspx.cs" Inherits="TP5_GRUPO_17.EliminarSucursal" %>

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
            width: 225px;
        }
        .auto-style3 {
            width: 225px;
            height: 31px;
        }
        .auto-style4 {
            height: 31px;
        }
        .auto-style9 {
            width: 182px;
        }
        .auto-style10 {
            width: 182px;
            height: 31px;
        }
        .auto-style11 {
            width: 193px;
        }
        .auto-style12 {
            width: 193px;
            height: 31px;
        }
        .auto-style13 {
            width: 225px;
            height: 30px;
        }
        .auto-style14 {
            width: 193px;
            height: 30px;
        }
        .auto-style15 {
            width: 182px;
            height: 30px;
        }
        .auto-style16 {
            height: 30px;
        }
        .auto-style17 {
            width: 225px;
            height: 23px;
        }
        .auto-style18 {
            width: 193px;
            height: 23px;
        }
        .auto-style19 {
            width: 182px;
            height: 23px;
        }
        .auto-style20 {
            height: 23px;
        }
        .auto-style21 {
            width: 225px;
            height: 18px;
        }
        .auto-style22 {
            width: 193px;
            height: 18px;
        }
        .auto-style23 {
            width: 182px;
            height: 18px;
        }
        .auto-style24 {
            height: 18px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
&nbsp;<table class="auto-style1">
            <tr>
                <td class="auto-style17">
                    <asp:HyperLink ID="hlAgregarSucursal" runat="server" NavigateUrl="~/AgregarSucursal.aspx">Agregar Sucursal</asp:HyperLink>
                </td>
                <td class="auto-style18">
                    <asp:HyperLink ID="hlListadoSucursales" runat="server" NavigateUrl="~/ListadoSucursales.aspx">Listado de Sucursales</asp:HyperLink>
                </td>
                <td class="auto-style19">
                    <asp:HyperLink ID="hlEliminarSucursal" runat="server" NavigateUrl="~/EliminarSucursal.aspx">Eliminar Sucursal</asp:HyperLink>
                </td>
                <td class="auto-style20">
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    &nbsp;</td>
                <td class="auto-style11">
                    &nbsp;</td>
                <td class="auto-style9">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="lblEliminar" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Eliminar Sucursal"></asp:Label>
                </td>
                <td class="auto-style12"></td>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td class="auto-style21"></td>
                <td class="auto-style22"></td>
                <td class="auto-style23"></td>
                <td class="auto-style24"></td>
            </tr>
            <tr>
                <td class="auto-style13">Ingresar ID sucursal:</td>
                <td class="auto-style14">
                    <asp:TextBox ID="txtIdSucursal" runat="server" Width="182px" TextMode="Number"></asp:TextBox>
                </td>
                <td class="auto-style15">
                    <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
                </td>
                <td class="auto-style16">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style9">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblMensaje" runat="server" ForeColor="Red"></asp:Label>
                </td>
                <td class="auto-style9">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
