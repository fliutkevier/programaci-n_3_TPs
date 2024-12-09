<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_CrearUsuarios.aspx.cs" Inherits="TPINT_GRUPO_17_PR3.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

    <style type="text/css">
        body{
            background-image: url(Recursos/MedicosWallpaper.jpg);
            background-size: cover;
            width: 100%;
        }
        .auto-style1 {
            width: 100%;
        }
        .auto-style5 {
            width: 234px;
        }
        .auto-style6 {
            width: 144px;
        }
        .auto-style7 {
            width: 182px;
        }
        .auto-style8 {
            width: 182px;
            height: 23px;
        }
        .auto-style9 {
            width: 234px;
            height: 23px;
        }
        .auto-style10 {
            width: 144px;
            height: 23px;
        }
        .auto-style11 {
            height: 23px;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
        <p>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style7">
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
                    </td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <asp:Label ID="lblUsuario" runat="server" Text="Usuario: "></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:Button ID="btnBuscarUsuario" runat="server" Text="Buscar usuario por nombre" OnClick="btnBuscarUsuario_Click" />
                    </td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtBuscarUsuario" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:HyperLink ID="hlVolver" runat="server" NavigateUrl="~/Admin_Medicos.aspx">Volver</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:GridView ID="grdUsuarios" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" Width="205px">
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
                <tr>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7">Legajo</td>
                    <td class="auto-style5">Contraseña</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <asp:TextBox ID="txtLegajo" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvLegajo" runat="server" ControlToValidate="txtLegajo" ForeColor="Red">*</asp:RequiredFieldValidator>
                        <br />
                                          </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtContraUsuario" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                    <td class="auto-style6">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">Nombre usuario</td>
                    <td class="auto-style9">Repetir contraseña</td>
                    <td class="auto-style10"></td>
                    <td class="auto-style11"></td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <asp:TextBox ID="txtNombreUsuario" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvNombreUsuario" runat="server" ControlToValidate="txtNombreUsuario" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtConfirmarContra" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                    <td class="auto-style6">
                        <asp:Button ID="btnCrearUsuario" runat="server" Text="Crear usuario" ValidationGroup="1" OnClick="btnCrearUsuario_Click" />
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:CompareValidator ID="cvContra" runat="server" ControlToCompare="txtContraUsuario" ControlToValidate="txtConfirmarContra" ErrorMessage="Las contraseñas no coinciden" ForeColor="Red" ValidationGroup="1"></asp:CompareValidator>
                    </td>
                    <td class="auto-style6">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </p>
    </form>
</body>
</html>
