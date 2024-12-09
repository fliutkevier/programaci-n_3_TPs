<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Medico_main.aspx.cs" Inherits="TPINT_GRUPO_17_PR3.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
         body{
             background-image: url('Recursos/MedicoWallpaper.jpg');
             background-repeat: no-repeat;
             background-size: cover;
         }
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 195px;
        }
        .auto-style3 {
            width: 92%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Usuario:
                        <asp:Label ID="lblUsuario" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:Button ID="btnBuscarPaciente" runat="server" Text="Buscar paciente por DNI:" OnClick="btnBuscarPaciente_Click" />
                        <asp:TextBox ID="txtBuscarPaciente" runat="server" Width="162px"></asp:TextBox>
                        <asp:Button ID="btnLimpiarFiltros" runat="server" OnClick="btnLimpiarFiltros_Click" Text="Limpiar filtros" BackColor="#000084" ForeColor="White" />
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:HyperLink ID="hlSalir" runat="server" NavigateUrl="~/Login.aspx">Salir</asp:HyperLink>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblMensaje" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:GridView ID="grdPacientes" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" AllowPaging="True" AutoGenerateColumns="False" AutoGenerateEditButton="True" OnPageIndexChanging="grdPacientes_PageIndexChanging" OnRowCancelingEdit="grdPacientes_RowCancelingEdit" OnRowEditing="grdPacientes_RowEditing" OnRowUpdating="grdPacientes_RowUpdating">
                            <AlternatingRowStyle BackColor="#DCDCDC" />
                            <Columns>
                                <asp:TemplateField HeaderText="ID">
                                    <EditItemTemplate>
                                        <asp:Label ID="lbl_eit_Id" runat="server" Text='<%# Bind("Id") %>'></asp:Label>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_Id" runat="server" Text='<%# Eval("Id") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Legajo Medico">
                                    <EditItemTemplate>
                                        <asp:Label ID="lbl_eit_Legajo" runat="server" Text='<%# Bind("Legajo") %>'></asp:Label>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_Legajo" runat="server" Text='<%# Eval("Legajo") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Dni paciente">
                                    <EditItemTemplate>
                                        <asp:Label ID="lbl_eit_DniPaciente" runat="server" Text='<%# Bind("DniPaciente") %>'></asp:Label>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_Dni" runat="server" Text='<%# Eval("DniPaciente") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Dia y horario">
                                    <EditItemTemplate>
                                        <asp:Label ID="lbl_eit_DiaHorario" runat="server" Text='<%# Bind("DiaHorario") %>'></asp:Label>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_DiaHorario" runat="server" Text='<%# Eval("DiaHorario") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Observacion">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txt_eit_Observacion" runat="server" Text='<%# Bind("Observacion") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_Observacion" runat="server" Text='<%# Eval("Observacion") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Presente">
                                    <EditItemTemplate>
                                        <asp:CheckBox ID="cb_eit_Estado" runat="server" Checked='<%# Eval("Presente") %>' Enabled="False" />
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:CheckBox ID="cb_it_Estado" runat="server" Checked='<%# Eval("Presente") %>' Enabled="False" />
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
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
