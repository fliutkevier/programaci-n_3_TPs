<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Ejercicio.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            width: 56px;
        }
        .auto-style4 {
            margin-bottom: 1px;
        }
        .auto-style5 {
            height: 31px;
        }
        .auto-style6 {
            width: 56px;
            height: 31px;
        }
        .auto-style7 {
            height: 23px;
        }
        .auto-style8 {
            width: 56px;
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>&nbsp;</td>
                    <td colspan="2">
                        <asp:Label ID="lblTP" runat="server" Text="Trabajo práctico N°2"></asp:Label>
                    </td>
                    <td class="auto-style3">&nbsp;</td>
                    <td colspan="2">
                        <asp:Label ID="lblUnidad" runat="server" Text="Aplicaciones web"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style5"></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style3">
                        <asp:Button ID="btnEjercicio1" runat="server" OnClick="btnEjercicio1_Click" Text="Ejercicio 1" />
                    </td>
                    <td class="auto-style3">
                        <asp:Button ID="btnEjercicio2" runat="server" OnClick="btnEjercicio2_Click" Text="Ejercicio 2" />
                    </td>
                    <td class="auto-style3">
                        <asp:Button ID="btnEjercicio3" runat="server" OnClick="btnEjercicio3_Click" Text="Ejercicio 3" />
                    </td>
                    <td class="auto-style3">
                        <asp:Button ID="btnEjercicio4" runat="server" OnClick="btnEjercicio4_Click" Text="Ejercicio 4" />
                    </td>
                    <td class="auto-style3">
                        <asp:Button ID="btnEjercicio5" runat="server" CssClass="auto-style4" OnClick="btnEjercicio5_Click" Text="Ejercicio 5" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7"></td>
                    <td class="auto-style8"></td>
                    <td class="auto-style8"></td>
                    <td class="auto-style8"></td>
                    <td class="auto-style8"></td>
                    <td class="auto-style8"></td>
                    <td class="auto-style7"></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td colspan="2">
                        <asp:Label ID="lblSeleccion" runat="server" Text="Seleccione un ejercicio"></asp:Label>
                    </td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
