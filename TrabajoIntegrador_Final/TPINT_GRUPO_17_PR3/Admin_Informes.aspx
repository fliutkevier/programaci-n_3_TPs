<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_Informes.aspx.cs" Inherits="TPINT_GRUPO_17_PR3.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        body{
            background-image: url('Recursos/InformesWallpaper.png');
            background-repeat: no-repeat;
            background-size: cover;
        }
        .auto-style1 {
            width: 100%;
        }
        .auto-style5 {
            width: 373px;
        }
        .auto-style8 {
            width: 140px;
        }
        .auto-style10 {
            width: 276px;
        }
        .auto-style11 {
            width: 175px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style8">
                        <asp:Label ID="lblUsuario" runat="server" Text="Usuario:"></asp:Label>
                    </td>
                    <td class="auto-style10">
                        &nbsp;</td>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:HyperLink ID="hlVolver" runat="server" NavigateUrl="~/Admin_main.aspx">Volver</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style10">Desde:
                        <asp:TextBox ID="txtDesde" runat="server" TextMode="Date" Width="121px"></asp:TextBox>
                        <br />
                        <br />
                        Hasta:&nbsp;
                        <asp:TextBox ID="txtHasta" runat="server" TextMode="Date"></asp:TextBox>
                    </td>
                    <td class="auto-style11">
                        <asp:Button ID="btnGenerarInforme" runat="server" Height="55px" OnClick="btnGenerarInforme_Click" Text="Generar Informe" Width="115px" />
                    </td>
                    <td class="auto-style5">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style10">&nbsp;</td>
                    <td class="auto-style11">
                        &nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style10">&nbsp;</td>
                    <td class="auto-style11">
                        Total pacientes: <asp:Label ID="lblTotPac" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style5">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style10">Cantidad de presentes:&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="lblCantPresentes" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style11">
                        &nbsp;</td>
                    <td class="auto-style5">Cantidad de ausentes:&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="lblCantAus" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style10">Porcentaje de presentes:&nbsp;
                        <asp:Label ID="lblPorcPresentes" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style11">
                        &nbsp;</td>
                    <td class="auto-style5">Porcentaje de ausentes:&nbsp;&nbsp;
                        <asp:Label ID="lblPorcAus" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style10">
                        <asp:GridView ID="grdPresentes" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical">
                            <AlternatingRowStyle BackColor="Gainsboro" />
                            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                            <SortedAscendingCellStyle BackColor="#F1F1F1" />
                            <SortedAscendingHeaderStyle BackColor="#0000A9" />
                            <SortedDescendingCellStyle BackColor="#CAC9C9" />
                            <SortedDescendingHeaderStyle BackColor="#000065" />
                        </asp:GridView>
                    </td>
                    <td class="auto-style11">
                        &nbsp;</td>
                    <td class="auto-style5">
                        <asp:GridView ID="grdAusentes" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical">
                            <AlternatingRowStyle BackColor="#DCDCDC" />
                            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                            <SortedAscendingCellStyle BackColor="#F1F1F1" />
                            <SortedAscendingHeaderStyle BackColor="#0000A9" />
                            <SortedDescendingCellStyle BackColor="#CAC9C9" />
                            <SortedDescendingHeaderStyle BackColor="#000065" />
                        </asp:GridView>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
