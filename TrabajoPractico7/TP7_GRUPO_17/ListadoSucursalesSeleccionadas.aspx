<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListadoSucursalesSeleccionadas.aspx.cs" Inherits="TP7_GRUPO_17.ListadoSucursalesSeleccionadas" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 90%;
            height: 155px;
        }
        .auto-style2 {
            height: 260px;
        }
        .auto-style3 {
            height: 50px;
        }
        .auto-style4 {
            height: 50px;
            width: 475px;
        }
        .auto-style5 {
            width: 475px;
            height: 130px;
        }
        .auto-style6 {
            height: 130px;
        }
    </style>
</head>
<body style="height: 260px">
    <form id="form1" runat="server">
        <div class="auto-style2">
            <table align="center" class="auto-style1">
                <tr>
                    <td class="auto-style4">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/SeleccionarSucursales.aspx">Listado de sucursales</asp:HyperLink>
                    </td>
                    <td class="auto-style3">
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/ListadoSucursalesSeleccionadas.aspx">Mostrar sucursales seleccionadas</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Mostrar sucursales seleccionadas"></asp:Label>
                    </td>
                    <td class="auto-style3"></td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:GridView ID="grdSucursales" runat="server">
                        </asp:GridView>
                    </td>
                    <td class="auto-style6"></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
