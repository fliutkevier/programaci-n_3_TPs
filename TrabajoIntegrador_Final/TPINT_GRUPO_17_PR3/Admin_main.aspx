<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_main.aspx.cs" Inherits="TPINT_GRUPO_17_PR3.Admin_main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        body{
            background-image: url('Recursos/AdminWallpaper.jpeg');
        }
        .auto-style1 {
            width: 100%;
            text-align: center;
            margin-top: 17em;
        }
        .auto-style2 {
            width: 365px;
        }
        .auto-style3 {
            width: 453px;
        }
        .auto-style5 {
            height: 65px;
        }
        .auto-style7 {
            width: 365px;
            height: 65px;
        }
        .auto-style8 {
            width: 453px;
            height: 65px;
        }
        .auto-style9 {
            height: 72px;
        }
        .auto-style11 {
            width: 365px;
            height: 72px;
        }
        .auto-style12 {
            width: 453px;
            height: 72px;
        }
        .auto-style13 {
            height: 54px;
        }
        .auto-style15 {
            width: 365px;
            height: 54px;
        }
        .auto-style16 {
            width: 453px;
            height: 54px;
        }
        .auto-style17 {
            width: 454px;
        }
        .auto-style18 {
            width: 454px;
            height: 54px;
        }
        .auto-style19 {
            width: 454px;
            height: 65px;
        }
        .auto-style20 {
            width: 454px;
            height: 72px;
        }
    </style>
</head>
<body style="height: 600px">
    <form id="form1" runat="server">
        <div>
        </div>
        <table class="auto-style1">
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style13"></td>
                <td class="auto-style18"></td>
                <td class="auto-style15">
                    <asp:Label ID="lblBienvenida" runat="server" Text="Bienvenido, " Font-Bold="True" Font-Size="XX-Large" ForeColor="White"></asp:Label>
                </td>
                <td class="auto-style16"></td>
                <td class="auto-style13"></td>
            </tr>
            <tr>
                <td class="auto-style5"></td>
                <td class="auto-style19">
                    <asp:Button ID="btnPacientes" runat="server" Text="Pacientes" Font-Size="Large" OnClick="btnPacientes_Click" />
                </td>
                <td class="auto-style7"></td>
                <td class="auto-style8">
                    <asp:Button ID="btnMedicos" runat="server" Text="Medicos" Font-Size="Large" OnClick="btnMedicos_Click" />
                </td>
                <td class="auto-style5"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5"></td>
                <td class="auto-style19">
                    <asp:Button ID="btnTurnos" runat="server" Text="Turnos" Font-Size="Large" OnClick="btnTurnos_Click" />
                </td>
                <td class="auto-style7"></td>
                <td class="auto-style8">
                    <asp:Button ID="btnInforme" runat="server" Text="Generar Informe" Font-Size="Large" OnClick="btnInforme_Click" />
                </td>
                <td class="auto-style5"></td>
            </tr>
            <tr>
                <td class="auto-style9"></td>
                <td class="auto-style20"></td>
                <td class="auto-style11">
                    <asp:Button ID="btnCerrarSesion" runat="server" Text="Cerrar Sesion" Font-Size="Large" OnClick="btnCerrarSesion_Click" />
                </td>
                <td class="auto-style12"></td>
                <td class="auto-style9"></td>
            </tr>
        </table>
    </form>
</body>
</html>
