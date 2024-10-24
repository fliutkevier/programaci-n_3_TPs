<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="WebApplication1.Ejercicio1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 101%;
            height: 311px;
        }
        .auto-style2 {
            height: 29px;
        }
        .auto-style3 {
            height: 29px;
            width: 160px;
        }
        .auto-style4 {
            width: 160px;
        }
        .auto-style7 {
            height: 29px;
            width: 190px;
        }
        .auto-style9 {
            width: 190px;
        }
        .auto-style10 {
            height: 23px;
        }
        .auto-style11 {
            width: 160px;
            height: 23px;
        }
        .auto-style12 {
            width: 190px;
            height: 23px;
        }
        .auto-style13 {
            height: 26px;
        }
        .auto-style14 {
            width: 160px;
            height: 26px;
        }
        .auto-style15 {
            width: 190px;
            height: 26px;
        }
        .auto-style16 {
            height: 420px;
        }
        .auto-style23 {
            height: 30px;
        }
        .auto-style24 {
            width: 160px;
            height: 30px;
        }
        .auto-style25 {
            width: 190px;
            height: 30px;
        }
        .auto-style26 {
            height: 13px;
        }
        .auto-style27 {
            width: 160px;
            height: 13px;
        }
        .auto-style28 {
            width: 190px;
            height: 13px;
        }
        .auto-style29 {
            height: 11px;
        }
        .auto-style30 {
            width: 160px;
            height: 11px;
        }
        .auto-style31 {
            width: 190px;
            height: 11px;
        }
        .auto-style32 {
            height: 32px;
        }
        .auto-style33 {
            height: 32px;
            width: 160px;
        }
        .auto-style34 {
            height: 32px;
            width: 190px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style16">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2"></td>
                <td class="auto-style3"></td>
                <td class="auto-style7">
                    <asp:Label ID="lblLocalidades" runat="server" Font-Bold="True" Text="Localidades"></asp:Label>
                </td>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td class="auto-style13"></td>
                <td class="auto-style14">
                    <asp:Label ID="lblNombreLocalidad" runat="server" Text="Nombre de Localidad:" Font-Bold="True"></asp:Label>
                </td>
                <td class="auto-style15">
                    <asp:TextBox ID="txtLocalidad" runat="server" Width="150px" OnTextChanged="txtLocalidad_TextChanged" ValidationGroup="Grupo1"></asp:TextBox>
                </td>
                <td class="auto-style13">
                    <asp:RequiredFieldValidator ID="rfvLocalidad" runat="server" ControlToValidate="txtLocalidad" ValidationGroup="Grupo1">Ingrese localidad</asp:RequiredFieldValidator>
                    <br />
                    <asp:CustomValidator ID="cvLocalidad" runat="server" ControlToValidate="txtLocalidad" OnServerValidate="cvLocalidad_ServerValidate" ValidationGroup="Grupo1">Localidad ya existente</asp:CustomValidator>
                </td>
                <td class="auto-style13"></td>
                <td class="auto-style13"></td>
                <td class="auto-style13"></td>
                <td class="auto-style13"></td>
                <td class="auto-style13"></td>
                <td class="auto-style13"></td>
            </tr>
            <tr>
                <td class="auto-style23"></td>
                <td class="auto-style24"></td>
                <td class="auto-style25">
                    <asp:Button ID="btnGuardarLocalidad" runat="server" OnClick="btnGuardarLocalidad_Click" Text="Guardar Localidad" Width="137px" ValidationGroup="Grupo1" />
                </td>
                <td class="auto-style23"></td>
                <td class="auto-style23"></td>
                <td class="auto-style23"></td>
                <td class="auto-style23"></td>
                <td class="auto-style23"></td>
                <td class="auto-style23"></td>
                <td class="auto-style23"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style9">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style10"></td>
                <td class="auto-style11"></td>
                <td class="auto-style12"></td>
                <td class="auto-style10"></td>
                <td class="auto-style10"></td>
                <td class="auto-style10"></td>
                <td class="auto-style10"></td>
                <td class="auto-style10"></td>
                <td class="auto-style10"></td>
                <td class="auto-style10"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style9">
                    <asp:Label ID="lblUsuarios" runat="server" Text="Usuarios" Font-Bold="True"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style10"></td>
                <td class="auto-style11"></td>
                <td class="auto-style12"></td>
                <td class="auto-style10"></td>
                <td class="auto-style10"></td>
                <td class="auto-style10"></td>
                <td class="auto-style10"></td>
                <td class="auto-style10"></td>
                <td class="auto-style10"></td>
                <td class="auto-style10"></td>
            </tr>
            <tr>
                <td class="auto-style13"></td>
                <td class="auto-style14">
                    <asp:Label ID="lblNombreUsuario" runat="server" Text="Nombre usuario:" Font-Bold="True"></asp:Label>
                </td>
                <td class="auto-style15">
                    <asp:TextBox ID="txtUsuario" runat="server" Width="150px" ValidationGroup="Grupo2"></asp:TextBox>
                </td>
                <td class="auto-style13">
                    <asp:RequiredFieldValidator ID="rfvUsuario" runat="server" ControlToValidate="txtUsuario" ErrorMessage="RequiredFieldValidator" ValidationGroup="Grupo2">Ingrese un usuario</asp:RequiredFieldValidator>
                </td>
                <td class="auto-style13"></td>
                <td class="auto-style13"></td>
                <td class="auto-style13"></td>
                <td class="auto-style13"></td>
                <td class="auto-style13"></td>
                <td class="auto-style13"></td>
            </tr>
            <tr>
                <td class="auto-style13"></td>
                <td class="auto-style14">
                    <asp:Label ID="lblContrasenia" runat="server" Text="Contraseña:" Font-Bold="True"></asp:Label>
                </td>
                <td class="auto-style15">
                    <asp:TextBox ID="txtContrasenia" runat="server" TextMode="Password" Width="150px" OnTextChanged="txtContrasenia_TextChanged" ValidationGroup="Grupo2"></asp:TextBox>
                </td>
                <td class="auto-style13">
                    <asp:RequiredFieldValidator ID="rfvContrasenia" runat="server" ControlToValidate="txtContrasenia" ValidationGroup="Grupo2">Ingrese una contraseña</asp:RequiredFieldValidator>
                </td>
                <td class="auto-style13"></td>
                <td class="auto-style13"></td>
                <td class="auto-style13"></td>
                <td class="auto-style13"></td>
                <td class="auto-style13"></td>
                <td class="auto-style13"></td>
            </tr>
            <tr>
                <td class="auto-style10"></td>
                <td class="auto-style11">
                    <asp:Label ID="lblRepetirContraseña" runat="server" Font-Bold="True" Text="Repetir Contraseña:"></asp:Label>
                </td>
                <td class="auto-style12">
                    <asp:TextBox ID="txtRepetirContrasenia" runat="server" OnTextChanged="txtRepetirContrañseña_TextChanged" TextMode="Password" Width="150px" ValidationGroup="Grupo2"></asp:TextBox>
                </td>
                <td class="auto-style10">
                    <asp:CompareValidator ID="cvContrasenia" runat="server" ControlToCompare="txtContrasenia" ControlToValidate="txtRepetirContrasenia" ValidationGroup="Grupo2">La contraseña es distinta </asp:CompareValidator>
                </td>
                <td class="auto-style10"></td>
                <td class="auto-style10"></td>
                <td class="auto-style10"></td>
                <td class="auto-style10"></td>
                <td class="auto-style10"></td>
                <td class="auto-style10"></td>
            </tr>
            <tr>
                <td class="auto-style26"></td>
                <td class="auto-style27">
                    <asp:Label ID="lblCorreoElectronico" runat="server" Font-Bold="True" Text="Correo Electronico:"></asp:Label>
                </td>
                <td class="auto-style28">
                    <asp:TextBox ID="txtEmail" runat="server" OnTextChanged="txtRepetirContrañseña_TextChanged" TextMode="Email" Width="150px" ValidationGroup="Grupo2"></asp:TextBox>
                </td>
                <td class="auto-style26">
                    <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmail" ValidationGroup="Grupo2">Ingrese un correo electrónico</asp:RequiredFieldValidator>
                    <br />
                    <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="Grupo2">Email no valido</asp:RegularExpressionValidator>
                </td>
                <td class="auto-style26"></td>
                <td class="auto-style26"></td>
                <td class="auto-style26"></td>
                <td class="auto-style26"></td>
                <td class="auto-style26"></td>
                <td class="auto-style26"></td>
            </tr>
            <tr>
                <td class="auto-style29"></td>
                <td class="auto-style30">
                    <asp:Label ID="lblCP" runat="server" Text="CP:" Font-Bold="True"></asp:Label>
                </td>
                <td class="auto-style31">
                    <asp:TextBox ID="txtCP" runat="server" MaxLength="4" ValidationGroup="Grupo2" Width="150px"></asp:TextBox>
                </td>
                <td class="auto-style29">
                    <asp:RequiredFieldValidator ID="rfvCP" runat="server" ControlToValidate="txtCP" ValidationGroup="Grupo2">Ingrese un código postal</asp:RequiredFieldValidator>
                    <br />
                    <asp:RegularExpressionValidator ID="revCP" runat="server" ControlToValidate="txtCP" ValidationExpression="^\d{4}$" ValidationGroup="Grupo2">Código postal inválido</asp:RegularExpressionValidator>
                </td>
                <td class="auto-style29"></td>
                <td class="auto-style29"></td>
                <td class="auto-style29"></td>
                <td class="auto-style29"></td>
                <td class="auto-style29"></td>
                <td class="auto-style29"></td>
            </tr>
            <tr>
                <td class="auto-style32"></td>
                <td class="auto-style33">
                    <asp:Label ID="lblLocalidadesDDL" runat="server" Text="Localidades:" Font-Bold="True"></asp:Label>
                </td>
                <td class="auto-style34">
                    <asp:DropDownList ID="ddlLocalidades" runat="server" Height="20px" Width="150px" ValidationGroup="Grupo2">
                        <asp:ListItem Value="0">Seleccione una localidad</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style32">
                    <asp:RequiredFieldValidator ID="rfvLocalidades" runat="server" ControlToValidate="ddlLocalidades" InitialValue="0" ValidationGroup="Grupo2">Ingrese una localidad</asp:RequiredFieldValidator>
                </td>
                <td class="auto-style32"></td>
                <td class="auto-style32"></td>
                <td class="auto-style32"></td>
                <td class="auto-style32"></td>
                <td class="auto-style32"></td>
                <td class="auto-style32"></td>
            </tr>
            <tr>
                <td class="auto-style10"></td>
                <td class="auto-style11">
                    &nbsp;</td>
                <td class="auto-style12">
                    &nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style10"></td>
                <td class="auto-style10"></td>
                <td class="auto-style10"></td>
                <td class="auto-style10"></td>
                <td class="auto-style10"></td>
                <td class="auto-style10"></td>
            </tr>
            <tr>
                <td class="auto-style13"></td>
                <td class="auto-style14">&nbsp;</td>
                <td class="auto-style15">
                    <asp:Button ID="btnGuardarUsuario" runat="server" OnClick="btnGuardarUsuario_Click" Text="Guardar Usuario" ValidationGroup="Grupo2" />
                </td>
                <td class="auto-style13">
                    <asp:Label ID="lblBienvenida" runat="server" Font-Bold="True"></asp:Label>
                </td>
                <td class="auto-style13"></td>
                <td class="auto-style13"></td>
                <td class="auto-style13"></td>
                <td class="auto-style13"></td>
                <td class="auto-style13"></td>
                <td class="auto-style13"></td>
            </tr>
            <tr>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
                <td class="auto-style15">
                    &nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style14">
                    <asp:Button ID="btnInicio" runat="server" Text="Ir a Inicio .aspx" OnClick="btnInicio_Click" />
                </td>
                <td class="auto-style15">
                    &nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
