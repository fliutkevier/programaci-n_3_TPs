<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_CargarPaciente.aspx.cs" Inherits="TPINT_GRUPO_17_PR3.Admin_CargarPaciente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        body{
            background-image: url('Recursos/AdminWallpaper.jpeg');
        }
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 87px;
        }
        .auto-style4 {
            width: 95px;
        }
        .auto-style5 {
            width: 148px;
        }
        .auto-style6 {
            width: 153px;
        }
        .auto-style7 {
            width: 87px;
            height: 26px;
        }
        .auto-style8 {
            width: 148px;
            height: 26px;
        }
        .auto-style9 {
            height: 26px;
        }
        .auto-style10 {
            width: 95px;
            height: 26px;
        }
        .auto-style11 {
            width: 153px;
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblUsuario" runat="server" Text="Usuario: " ForeColor="White"></asp:Label>
                    </td>
                    <td class="auto-style5">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>
                        <asp:HyperLink ID="hlkVolver" runat="server" NavigateUrl="~/Admin_Pacientes.aspx">Volver</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblNombre" runat="server" Text="Nombre:" ForeColor="White"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ControlToValidate="txtNombre" Font-Size="Large" ForeColor="#FF3300">*</asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style4">
                        <asp:Label ID="lblCorreoElectronico" runat="server" Text="Correo electronico:" ForeColor="White"></asp:Label>
                    </td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtCorreoElectronico" runat="server" TextMode="Email"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="rfvCorreo" runat="server" ControlToValidate="txtCorreoElectronico" Font-Size="Large" ForeColor="#FF3300">*</asp:RequiredFieldValidator>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblApellido" runat="server" Text=" Apellido:" ForeColor="White"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="rfvApellido" runat="server" ControlToValidate="txtApellido" Font-Size="Large" ForeColor="#FF3300">*</asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style4">
                        <asp:Label ID="lblTelefono" runat="server" Text="Telefono:" ForeColor="White"></asp:Label>
                    </td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="rfvTelefono" runat="server" ControlToValidate="txtTelefono" Font-Size="Large" ForeColor="#FF3300">*</asp:RequiredFieldValidator>
                    </td>
                    <td>
                        <asp:RegularExpressionValidator ID="revTelefono" runat="server" ControlToValidate="txtTelefono" ForeColor="#FF3300" ValidationExpression="^\d+$">Solo debe ingresar numeros</asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <asp:Label ID="lblDni" runat="server" Text="DNI:" ForeColor="White"></asp:Label>
&nbsp;</td>
                    <td class="auto-style8">
                        <asp:TextBox ID="txtDni" runat="server" MaxLength="8"></asp:TextBox>
                    </td>
                    <td class="auto-style9">
                        <asp:RequiredFieldValidator ID="rfvDni" runat="server" ControlToValidate="txtDni" Font-Size="Large" ForeColor="#FF3300">*</asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style10">
                        <asp:Label ID="lblNacionalidad" runat="server" Text="Nacionalidad:" ForeColor="White"></asp:Label>
                    </td>
                    <td class="auto-style11">
                        <asp:DropDownList ID="ddlNacionalidad" runat="server">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style9"></td>
                    <td class="auto-style9">
                        <asp:RequiredFieldValidator ID="rfvNacionalidad" runat="server" ControlToValidate="ddlNacionalidad" ForeColor="#FF3300" InitialValue="0">Selecciona la nacionalidad</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblValidacionDNI" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:RegularExpressionValidator ID="revDni" runat="server" ControlToValidate="txtDni" Font-Size="Small" ForeColor="#FF3300" ValidationExpression="^\d+$">Solo debe ingresar numeros</asp:RegularExpressionValidator>
                    </td>
                    <td>&nbsp;</td>
                    <td class="auto-style4">
                        &nbsp;</td>
                    <td class="auto-style6">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblSexo" runat="server" Text="Sexo:" ForeColor="White"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:RadioButtonList ID="rbtnSexo" runat="server" ForeColor="White">
                            <asp:ListItem Value="M">Masculino</asp:ListItem>
                            <asp:ListItem Value="F">Femenino</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="rfvSexo" runat="server" ControlToValidate="rbtnSexo" Font-Size="Large" ForeColor="#FF3300">*</asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style4">
                        <asp:Label ID="lblProvincia" runat="server" Text="Provincia:" ForeColor="White"></asp:Label>
                    </td>
                    <td class="auto-style6">
                        <asp:DropDownList ID="ddlProvincia" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlProvincia_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
                    <td>
                        <asp:RequiredFieldValidator ID="rfvProvincia" runat="server" ControlToValidate="ddlProvincia" ForeColor="#FF3300" InitialValue="0">Seleccione una provincia</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblFechaNacimiento" runat="server" Text="Fecha de nacimiento:" ForeColor="White"></asp:Label>
                        <br />
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtFechaNacimiento" runat="server" TextMode="Date"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvFechaNacimiento" runat="server" ControlToValidate="txtFechaNacimiento" Font-Size="Large" ForeColor="#FF3300">*</asp:RequiredFieldValidator>
                    </td>
                    <td>&nbsp;</td>
                    <td class="auto-style4">
                        <asp:Label ID="lblLocalidad" runat="server" Text="Localidad:" ForeColor="White"></asp:Label>
                    </td>
                    <td class="auto-style6">
                        <asp:DropDownList ID="ddlLocalidad" runat="server">
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
                    <td>
                        <asp:RequiredFieldValidator ID="rfvLocalidad" runat="server" ControlToValidate="ddlLocalidad" ForeColor="#FF3300" InitialValue="0">Seleccione una localidad</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style4">
                        <asp:Label ID="lblDireccion" runat="server" Text="Direccion:" ForeColor="White"></asp:Label></td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="rfvDireccion" runat="server" ControlToValidate="txtDireccion" Font-Size="Large" ForeColor="#FF3300">*</asp:RequiredFieldValidator>
                    </td>
                    <td>
                        <asp:Button ID="btnAceptar" runat="server" OnClick="Button1_Click" Text="Aceptar" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style4">
                        &nbsp;</td>
                    <td class="auto-style6">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td colspan="3">
                        <asp:ValidationSummary ID="vsErrores" runat="server" ForeColor="#FF3300" HeaderText="COMPLETE LOS CAMPOS QUE FALTAN" />
                    </td>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Label ID="lblMensaje" runat="server" ForeColor="White"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
