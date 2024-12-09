<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_Medicos.aspx.cs" Inherits="TPINT_GRUPO_17_PR3.SeccionMedicos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        body{
            background-image: url(Recursos/MedicosWallpaper.jpg);
        }
        .auto-style1 {
            width: 100%;
            margin-right: 39px;
        }
        .auto-style2 {
            width: 549px;
        }
        .auto-style3 {
            width: 105px;
        }
        .auto-style4 {
            width: 105px;
            height: 23px;
        }
        .auto-style5 {
            width: 549px;
            height: 23px;
        }
        .auto-style7 {
            width: 123px;
        }
        .auto-style8 {
            width: 123px;
            height: 23px;
        }
        .auto-style9 {
            width: 105px;
            height: 26px;
        }
        .auto-style10 {
            width: 123px;
            height: 26px;
        }
        .auto-style17 {
            width: 92px;
        }
        .auto-style18 {
            width: 92px;
            height: 23px;
        }
        .auto-style19 {
            width: 92px;
            height: 26px;
        }
        .auto-style20 {
            width: 128px;
        }
        .auto-style21 {
            width: 128px;
            height: 23px;
        }
        .auto-style22 {
            width: 128px;
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">
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
                    <td class="auto-style7">
                        &nbsp;</td>
                    <td class="auto-style2"></td>
                    <td class="auto-style17">
                        &nbsp;</td>
                    <td class="auto-style20">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="lblUsuario" runat="server">Usuario: </asp:Label>
                    </td>
                    <td class="auto-style8">
                        &nbsp;</td>
                    <td class="auto-style5"></td>
                    <td class="auto-style18">
                        &nbsp;</td>
                    <td class="auto-style21">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">
                        </td>
                    <td class="auto-style10">
                        </td>
                    <td class="auto-style1">
                        <asp:Button ID="btnBuscarMedico" runat="server" OnClick="btnBuscarMedico_Click" Text="Buscar medico por legajo:" Width="170px" />
                        <asp:TextBox ID="txtBusqueda" runat="server" Width="207px"></asp:TextBox>
                        <asp:DropDownList ID="ddlFiltroProvincia" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlFiltroProvincia_SelectedIndexChanged">
                        </asp:DropDownList>
                        <asp:DropDownList ID="ddlFiltroLocalidad" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlFiltroLocalidad_SelectedIndexChanged">
                        </asp:DropDownList>
                        <asp:DropDownList ID="ddlFiltroNacionalidad" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlFiltroNacionalidad_SelectedIndexChanged">
                        </asp:DropDownList>
                        <asp:Button ID="btnLimpiarFiltros" runat="server" OnClick="btnLimpiarFiltros_Click" Text="Limpiar filtros" BackColor="#000084" ForeColor="White" />
                    </td>
                    <td class="auto-style19">
                        <asp:HyperLink ID="hlkSalir" runat="server" NavigateUrl="~/Login.aspx">Salir</asp:HyperLink>
                    </td>
                    <td class="auto-style22">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4"></td>
                    <td class="auto-style8"></td>
                    <td class="auto-style5">&nbsp;&nbsp;&nbsp;<asp:Label ID="lblEliminarRegistro" runat="server"></asp:Label>
                        <asp:Label ID="lblCargarRegistro" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style18">
                        <asp:HyperLink ID="hlVolver" runat="server" NavigateUrl="~/Admin_main.aspx">Volver</asp:HyperLink>
                    </td>
                    <td class="auto-style21"></td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="btnCargarMedico" runat="server" Text="Cargar medico" OnClick="btnCargarMedico_Click" />
                        <br />
                        <br />
                        <br />
                        <asp:Button ID="btnCrearModificar" runat="server" Text="Crear / modificar usuario" OnClick="btnCrearModificar_Click" />
                    </td>
                    <td class="auto-style7">
                        &nbsp;</td>
                    <td class="auto-style2">
                        <asp:GridView ID="grdMedicos" runat="server" AllowPaging="True" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" AutoGenerateColumns="False" Height="163px" Width="362px" AutoGenerateDeleteButton="True" AutoGenerateEditButton="True" OnRowDeleting="grdMedicos_RowDeleting" OnRowUpdating="grdMedicos_RowUpdating" OnRowCancelingEdit="grdMedicos_RowCancelingEdit" OnRowDataBound="grdMedicos_RowDataBound" OnRowEditing="grdMedicos_RowEditing" OnPageIndexChanging="grdMedicos_PageIndexChanging">
                            <AlternatingRowStyle BackColor="#DCDCDC" />
                            <Columns>
                                <asp:TemplateField HeaderText="Legajo">
                                    <EditItemTemplate>
                                        <asp:Label ID="lbl_eit_Legajo" runat="server" Text='<%# Eval("Legajo") %>'></asp:Label>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_Legajo" runat="server" Text='<%# Eval("Legajo") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Dni">
                                    <EditItemTemplate>
                                        <asp:Label ID="lbl_eit_Dni" runat="server" Text='<%# Eval("Dni") %>'></asp:Label>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_Dni" runat="server" Text='<%# Eval("Dni") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Nombre">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txt_eit_Nombre" runat="server" Text='<%# Bind("Nombre") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_Nombre" runat="server" Text='<%# Eval("Nombre") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Apellido">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txt_eit_Apellido" runat="server" Text='<%# Bind("Apellido") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_Apellido" runat="server" Text='<%# Eval("Apellido") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Sexo">
                                    <EditItemTemplate>
                                        <asp:RadioButtonList ID="rbtn_eit_Sexo" runat="server" SelectedValue='<%# Bind("Sexo") %>'>
                                            <asp:ListItem Value="M">Masculino</asp:ListItem>
                                            <asp:ListItem Value="F">Femenino</asp:ListItem>
                                        </asp:RadioButtonList>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_Sexo" runat="server" Text='<%# Eval("Sexo") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Fecha de nacimiento">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txt_eit_Nacimiento" runat="server" Text='<%# Bind("Nacimiento") %>' TextMode="Date"></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_Nacimiento" runat="server" Text='<%# Eval("Nacimiento") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Correo electrónico">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txt_eit_Correo" runat="server" Text='<%# Bind("CorreoElectronico") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_Correo" runat="server" Text='<%# Eval("CorreoElectronico") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Teléfono">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txt_eit_Telefono" runat="server" Text='<%# Bind("Telefono") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_Telefono" runat="server" Text='<%# Eval("Telefono") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Dirección">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txt_eit_Direccion" runat="server" Text='<%# Bind("Direccion") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_Direccion" runat="server" Text='<%# Eval("Direccion") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Provincia">
                                    <EditItemTemplate>
                                        <asp:DropDownList ID="ddl_eit_Provincia" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_eit_Provincia_SelectedIndexChanged">
                                        </asp:DropDownList>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_Provincia" runat="server" Text='<%# Eval("Provincia.Nombre") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Localidad">
                                    <EditItemTemplate>
                                        <asp:DropDownList ID="ddl_eit_Localidad" runat="server">
                                        </asp:DropDownList>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_Localidad" runat="server" Text='<%# Eval("Localidad.Nombre") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Especialidad">
                                    <EditItemTemplate>
                                        <asp:DropDownList ID="ddl_eit_Especialidad" runat="server">
                                        </asp:DropDownList>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_Especialidad" runat="server" Text='<%# Eval("Especialidad.Descripcion") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Nacionalidad">
                                    <EditItemTemplate>
                                        <asp:DropDownList ID="ddl_eit_Nacionalidad" runat="server">
                                        </asp:DropDownList>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_Nacionalidad" runat="server" Text='<%# Eval("Nacionalidad.Nombre") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Estado">
                                    <EditItemTemplate>
                                        <asp:CheckBox ID="cb_eit_Estado" runat="server" Checked='<%# Eval("Estado") %>' Enabled="False" />
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:CheckBox ID="cb_it_Estado" runat="server" Checked='<%# Eval("Estado") %>' Enabled="False" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
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
                    <td class="auto-style17">&nbsp;</td>
                    <td class="auto-style20">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style17">&nbsp;</td>
                    <td class="auto-style20">&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
