<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TPINT_GRUPO_17_PR3.frmLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        body{
            background-image: url('Recursos/LoginWallpaper.png');
        }
        .auto-style1 {
            margin-left: 5em;
            margin-top: 20em;
            color: white;
            width: 30%;
        }
        .auto-style2 {
            height: 520px;
        }
    </style>
</head>
<body style="height: 600px">
    <form id="form1" runat="server" class="auto-style2">
        <table class="auto-style1">
            <tr>
                <td>Ingrese su Nombre de Usuario</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvUsuario" runat="server" ControlToValidate="txtUsuario" ErrorMessage="Ingrese un usuario" ForeColor="Red" ValidationGroup="1"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Ingrese su Contraseña</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txtContrasenia" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvContra" runat="server" ControlToValidate="txtContrasenia" ErrorMessage="Ingrese una contraseña" ForeColor="Red" ValidationGroup="1"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" Width="191px" OnClick="btnIngresar_Click" ValidationGroup="1" />
                    <br />
                    <asp:Label ID="lblNoUsuario" runat="server" ForeColor="Red" Text="El usuario ingresado no existe" Visible="False"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
