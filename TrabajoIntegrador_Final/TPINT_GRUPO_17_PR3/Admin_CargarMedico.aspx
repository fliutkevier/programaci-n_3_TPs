<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_CargarMedico.aspx.cs" Inherits="TPINT_GRUPO_17_PR3.Admin_CargarMedico" %>

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
        .auto-style2 {
            width: 87px;
        }
        .auto-style4 {
            width: 95px;
        }
        .auto-style8 {
            width: 87px;
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
            height: 9px;
        }
        .auto-style12 {
            width: 95px;
            height: 9px;
        }
        .auto-style13 {
            height: 33px;
        }
        .auto-style14 {
            width: 95px;
            height: 33px;
        }
        .auto-style15 {
            width: 50px;
        }
        .auto-style16 {
            height: 26px;
            width: 50px;
        }
        .auto-style17 {
            height: 9px;
            width: 50px;
        }
        .auto-style18 {
            height: 33px;
            width: 50px;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblUsuario" runat="server" Text="Usuario: "></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style15">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>
                        <asp:HyperLink ID="hlVolver" runat="server" NavigateUrl="~/Admin_Medicos.aspx">Volver</asp:HyperLink>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style15">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Label ID="lblCorreoElectronico" runat="server" Text="Correo electronico:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtCorreoElectronico" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="rfvCorreoElectronico" runat="server" ControlToValidate="txtCorreoElectronico" ForeColor="Red" Font-Size="Large">*</asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style15">&nbsp;</td>
                    <td>
                        <asp:Label ID="lblEspecialidad" runat="server" Text="Especialidad:"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlEspecialidad" runat="server">
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="rfvEspecialidad" runat="server" ControlToValidate="ddlEspecialidad" ForeColor="Red" InitialValue="0">Seleccione la especialidad</asp:RequiredFieldValidator>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Label ID="lblTelefono" runat="server" Text="Telefono:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
                        <br />
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="rfvTelefono" runat="server" ControlToValidate="txtTelefono" ForeColor="Red" Font-Size="Large">*</asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style15">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:RegularExpressionValidator ID="revTelefono" runat="server" ControlToValidate="txtTelefono" Font-Size="Small" ForeColor="Red" ValidationExpression="^\d+$">Solo debe ingresar numeros</asp:RegularExpressionValidator>
                    </td>
                    <td>
                        &nbsp;</td>
                    <td class="auto-style15">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblDni" runat="server" Text="DNI:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtDni" runat="server" MaxLength="8"></asp:TextBox>
                        <br />
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="rfvDni" runat="server" ControlToValidate="txtDni" ForeColor="Red" Font-Size="Large">*</asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style4">
                        &nbsp;</td>
                    <td>
                        <asp:Label ID="lblValidacionDNI" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style15">&nbsp;</td>
                    <td>
                        <asp:Label ID="lblDiasYHorarios" runat="server" Text="Dias y horarios de atención:"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        &nbsp;</td>
                    <td>
                        <asp:RegularExpressionValidator ID="revDni" runat="server" Font-Size="Small" ForeColor="Red" ControlToValidate="txtDni" ValidationExpression="^\d+$">Solo debe ingresar numeros</asp:RegularExpressionValidator>
                    </td>
                    <td>
                        &nbsp;</td>
                    <td class="auto-style4">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style15">&nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">
                        <asp:Label ID="lblLegajo" runat="server" Text="Legajo:"></asp:Label>
                    </td>
                    <td class="auto-style9">
                        <asp:TextBox ID="txtLegajo" runat="server"></asp:TextBox>
                        <br />
                    </td>
                    <td class="auto-style9">
                        <asp:RequiredFieldValidator ID="rfvLegajo" runat="server" ControlToValidate="txtLegajo" ForeColor="Red" Font-Size="Large">*</asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style10">
                        &nbsp;</td>
                    <td class="auto-style9">
                        <asp:Label ID="lblValidacionLegajo" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                    <td class="auto-style9"></td>
                    <td class="auto-style9"><asp:Label ID="lblNacionalidad" runat="server" Text="Nacionalidad:"></asp:Label>
                    </td>
                    <td class="auto-style9">
                        <asp:DropDownList ID="ddlNacionalidad" runat="server">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style9">
                        <asp:RequiredFieldValidator ID="rfvNacionalidad" runat="server" ControlToValidate="ddlNacionalidad" ForeColor="Red" InitialValue="0">Seleccione la nacionalidad</asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style16">&nbsp;</td>
                    <td class="auto-style9">
                        <asp:CheckBoxList ID="cblDias" runat="server" AutoPostBack="True" RepeatColumns="2" Width="170px">
                            <asp:ListItem Value="L">Lunes</asp:ListItem>
                            <asp:ListItem Value="M">Martes</asp:ListItem>
                            <asp:ListItem Value="X">Miércoles</asp:ListItem>
                            <asp:ListItem Value="J">Jueves</asp:ListItem>
                            <asp:ListItem Value="V">Viernes</asp:ListItem>
                            <asp:ListItem Value="S">Sábado</asp:ListItem>
                            <asp:ListItem Value="D">Domingo</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                    <td class="auto-style9">
                        <asp:DropDownList ID="ddlHorarios" runat="server">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style9">
                        <asp:RequiredFieldValidator ID="rfvHorario" runat="server" ControlToValidate="ddlHorarios" Font-Size="Large" ForeColor="Red" InitialValue="0">*</asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style9">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblNombre" runat="server" Text="Nombre:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ControlToValidate="txtNombre" ForeColor="Red" Font-Size="Large">*</asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style4">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style15">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">
                        <asp:Label ID="lblApellido" runat="server" Text=" Apellido:"></asp:Label>
                    </td>
                    <td class="auto-style9">
                        <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style9">
                        <asp:RequiredFieldValidator ID="rfvApellido" runat="server" ControlToValidate="txtApellido" ForeColor="Red" Font-Size="Large">*</asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style10">
                    </td>
                    <td class="auto-style9">
                    </td>
                    <td class="auto-style9"></td>
                    <td class="auto-style9">
                    </td>
                    <td class="auto-style9">
                        &nbsp;</td>
                    <td class="auto-style9">
                        &nbsp;</td>
                    <td class="auto-style16">
                        &nbsp;</td>
                    <td class="auto-style9">
                        &nbsp;</td>
                    <td class="auto-style9">
                        &nbsp;</td>
                    <td class="auto-style9">
                        &nbsp;</td>
                    <td class="auto-style9">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Label ID="lblProvincia" runat="server" Text="Provincia:"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlProvincia" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlProvincia_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="rfvProvincia" runat="server" ControlToValidate="ddlProvincia" ForeColor="Red" InitialValue="0">Seleccione una provincia</asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style15">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblSexo" runat="server" Text="Sexo:"></asp:Label>
                    </td>
                    <td>
                        <asp:RadioButtonList ID="rbtnSexo" runat="server">
                            <asp:ListItem Value="M">Masculino</asp:ListItem>
                            <asp:ListItem Value="F">Femenino</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="rfvSexo" runat="server" ControlToValidate="rbtnSexo" Font-Size="Large" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style4">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Label ID="lblLocalidad" runat="server" Text="Localidad:"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlLocalidad" runat="server">
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="rfvLocalidad" runat="server" ControlToValidate="ddlLocalidad" ForeColor="Red" InitialValue="0">Seleccione una localidad</asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style15">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2" rowspan="2">
                        <asp:Label ID="lblFechaNacimiento" runat="server" Text="Fecha de nacimiento:"></asp:Label>
                        <asp:TextBox ID="txtFechaNacimiento" runat="server" TextMode="Date"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvFechaNacimiento" runat="server" ControlToValidate="txtFechaNacimiento" ForeColor="Red" Font-Size="Large">*</asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style12">
                        &nbsp;</td>
                    <td class="auto-style11">
                        &nbsp;</td>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style11">
                        <asp:Label ID="lblDireccion" runat="server" Text="Direccion:"></asp:Label>
                    </td>
                    <td class="auto-style11">
                        <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style11">
                        <asp:RequiredFieldValidator ID="rfvDireccion" runat="server" ControlToValidate="txtDireccion" ForeColor="Red" Font-Size="Large">*</asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style17">
                        &nbsp;</td>
                    <td class="auto-style11">
                        &nbsp;</td>
                    <td class="auto-style11">
                        &nbsp;</td>
                    <td class="auto-style11">
                        &nbsp;</td>
                    <td class="auto-style11">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style11"></td>
                    <td class="auto-style12">
                        &nbsp;</td>
                    <td class="auto-style11">
                        &nbsp;</td>
                    <td class="auto-style11"></td>
                    <td class="auto-style11">
                        &nbsp;</td>
                    <td class="auto-style11">
                        &nbsp;</td>
                    <td class="auto-style11">
                        &nbsp;</td>
                    <td class="auto-style17">
                        &nbsp;</td>
                    <td class="auto-style11">
                        &nbsp;</td>
                    <td class="auto-style11">
                        &nbsp;</td>
                    <td class="auto-style11">
                        &nbsp;</td>
                    <td class="auto-style11">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2" rowspan="2">
                        &nbsp;</td>
                    <td class="auto-style13"></td>
                    <td class="auto-style14">
                        &nbsp;</td>
                    <td class="auto-style13">
                        &nbsp;</td>
                    <td class="auto-style13"></td>
                    <td class="auto-style13">
                        &nbsp;</td>
                    <td class="auto-style13">
                        &nbsp;</td>
                    <td class="auto-style13">
                        &nbsp;</td>
                    <td class="auto-style18">
                        &nbsp;</td>
                    <td class="auto-style13">
                        &nbsp;</td>
                    <td class="auto-style13">
                        &nbsp;</td>
                    <td class="auto-style13">
                        <asp:Button ID="btnAceptar" runat="server" OnClick="Button1_Click" Text="Agregar médico" Width="150px" />
                    </td>
                    <td class="auto-style13">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style13">&nbsp;</td>
                    <td class="auto-style14">
                        &nbsp;</td>
                    <td class="auto-style13">
                        &nbsp;</td>
                    <td class="auto-style13">&nbsp;</td>
                    <td class="auto-style13" colspan="4">
                        <asp:ValidationSummary ID="vsErrores" runat="server" ForeColor="Red" HeaderText="COMPLETE LOS CAMPOS QUE FALTAN" />
                    </td>
                    <td class="auto-style13">
                        &nbsp;</td>
                    <td class="auto-style13">
                        &nbsp;</td>
                    <td class="auto-style13">
                        <asp:Label ID="lblMensaje" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style13">
                        &nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
    
</body>
</html>
