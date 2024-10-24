<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SeleccionarSucursales.aspx.cs" Inherits="TP7_GRUPO_17.SeleccionarSucursales" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style4 {
            width: 220px;
            height: 57px;
        }
        .auto-style7 {
            width: 220px;
            height: 51px;
        }
        .auto-style11 {
            width: 14px;
            height: 51px;
        }
        .auto-style12 {
            width: 14px;
            height: 57px;
        }
        .auto-style13 {
            width: 220px;
        }
        .auto-style14 {
            width: 242px;
        }
        .auto-style15 {
            width: 242px;
            height: 51px;
        }
        .auto-style16 {
            width: 242px;
            height: 57px;
        }
        .auto-style17 {
            width: 14px;
        }
        .auto-style19 {
            width: 240px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
               <td class="auto-style17">&nbsp;</td>
                 <td class="auto-style14">
                <asp:HyperLink ID="hlSeleccionar" runat="server" NavigateUrl="~/SeleccionarSucursales.aspx">Listado de Sucursales</asp:HyperLink>
                </td>
            <td class="auto-style13">
                <asp:HyperLink ID="hlListado" runat="server" NavigateUrl="~/ListadoSucursalesSeleccionadas.aspx">Mostrar Sucursales Seleccionadas</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style15">
                    <asp:Label ID="lblListado" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Listado de sucursales"></asp:Label>
                </td>
                <td class="auto-style7">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">&nbsp;</td>
                <td class="auto-style16">
                    <asp:Label ID="lblBusqueda" runat="server" Text="Búsqueda por nombre de sucursal:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtBusqueda" runat="server" Width="261px"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style17">
                    <asp:Button ID="btnBuenosAires" runat="server" Text="Buenos Aires" OnClick="FiltrarPorProvincia" CommandArgument="1" Width="147px" />
                    <br />
                    <br />
                    <asp:Button ID="btnEntreRios" runat="server" Text="Entre Ríos" OnClick="FiltrarPorProvincia" CommandArgument="2" Width="147px" />
                    <br />
                    <br />
                    <asp:Button ID="btnSantaFe" runat="server" Text="Santa Fe" OnClick="FiltrarPorProvincia" CommandArgument="3" Width="147px" />
                    <br />
                    <br />
                    <asp:Button ID="btnLaPampa" runat="server" Text="La Pampa" OnClick="FiltrarPorProvincia" CommandArgument="4" Width="147px" />
                    <br />
                    <br />
                    <asp:Button ID="btnCordoba" runat="server" Text="Córdoba" OnClick="FiltrarPorProvincia" CommandArgument="5" Width="147px" />
                    <br />
                    <br />
                    <asp:Button ID="btnMisiones" runat="server" Text="Misiones" OnClick="FiltrarPorProvincia" CommandArgument="6" Width="147px" />
                    <br />
                    <br />
                    <asp:Button ID="btnChaco" runat="server" Text="Chaco" OnClick="FiltrarPorProvincia" CommandArgument="7" Width="147px" />
                </td>
                
                <td colspan="2">
                    <asp:ListView ID="lvSucursales" runat="server" DataSourceID="sdsSucursales" GroupItemCount="3">
                        <%--<AlternatingItemTemplate>
                            <td runat="server" style="background-color: #FAFAD2;color: #284775;">NombreSucursal:
                                <asp:Label ID="NombreSucursalLabel" runat="server" Text='<%# Eval("NombreSucursal") %>' />
                                <br />
                                DescripcionSucursal:
                                <asp:Label ID="DescripcionSucursalLabel" runat="server" Text='<%# Eval("DescripcionSucursal") %>' />
                                <br />URL_Imagen_Sucursal:
                                <asp:Label ID="URL_Imagen_SucursalLabel" runat="server" Text='<%# Eval("URL_Imagen_Sucursal") %>' />
                                <br />
                                </td>
                        </AlternatingItemTemplate>--%>
                        <%--<AlternatingItemTemplate>
                            <td runat="server" style="">NombreSucursal:
                                <asp:Label ID="NombreSucursalLabel" runat="server" Text='<%# Eval("NombreSucursal") %>' />
                                <br />
                                DescripcionSucursal:
                                <asp:Label ID="DescripcionSucursalLabel" runat="server" Text='<%# Eval("DescripcionSucursal") %>' />
                                <br />
                                URL_Imagen_Sucursal:
                                <asp:Label ID="URL_Imagen_SucursalLabel" runat="server" Text='<%# Eval("URL_Imagen_Sucursal") %>' />
                                <br />
                            </td>
                        </AlternatingItemTemplate>--%>
                        <EditItemTemplate>
                            <td runat="server" style="">NombreSucursal:
                                <asp:TextBox ID="NombreSucursalTextBox" runat="server" Text='<%# Bind("NombreSucursal") %>' />
                                <br />DescripcionSucursal:
                                <asp:TextBox ID="DescripcionSucursalTextBox" runat="server" Text='<%# Bind("DescripcionSucursal") %>' />
                                <br />URL_Imagen_Sucursal:
                                <asp:TextBox ID="URL_Imagen_SucursalTextBox" runat="server" Text='<%# Bind("URL_Imagen_Sucursal") %>' />
                                <br />
                                <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Actualizar" />
                                <br />
                                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancelar" />
                                <br /></td>
                        </EditItemTemplate>
                        <EmptyDataTemplate>
                            <table runat="server" style="">
                                <tr>
                                    <td>No se han devuelto datos.</td>
                                </tr>
                            </table>
                        </EmptyDataTemplate>
                        <EmptyItemTemplate>
<td runat="server" />
                        </EmptyItemTemplate>
                        <GroupTemplate>
                            <tr id="itemPlaceholderContainer" runat="server">
                                <td id="itemPlaceholder" runat="server"></td>
                            </tr>
                        </GroupTemplate>
                        <InsertItemTemplate>
                            <td runat="server" style="">NombreSucursal:
                                <asp:TextBox ID="NombreSucursalTextBox" runat="server" Text='<%# Bind("NombreSucursal") %>' />
                                <br />DescripcionSucursal:
                                <asp:TextBox ID="DescripcionSucursalTextBox" runat="server" Text='<%# Bind("DescripcionSucursal") %>' />
                                <br />URL_Imagen_Sucursal:
                                <asp:TextBox ID="URL_Imagen_SucursalTextBox" runat="server" Text='<%# Bind("URL_Imagen_Sucursal") %>' />
                                <br />
                                <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insertar" />
                                <br />
                                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Borrar" />
                                <br /></td>
                        </InsertItemTemplate>
                        <ItemTemplate>
                            <td runat="server" style="">
                                <asp:Label ID="NombreSucursalLabel" runat="server" Text='<%# Eval("NombreSucursal") %>' />
                                <br />
                                <asp:ImageButton ID="imgBtnSucursal" runat="server" EnableTheming="True" Height="150px" ImageUrl='<%# Eval("URL_Imagen_Sucursal") %>' Width="200px" />
                                <br />
                                <asp:Label ID="DescripcionSucursalLabel" runat="server" Text='<%# Eval("DescripcionSucursal") %>' />
                                <br />
                                <asp:Label ID="IdSucursalLabel" runat="server" Visible="False" Text='<%# Eval("Id_Sucursal") %>'></asp:Label>
                                <br />
                                <asp:Button ID="btnSeleccionar" runat="server" Text="Seleccionar" CommandArgument='<%# Container.DisplayIndex %>' CommandName="eventoSeleccionar" OnCommand="btnSeleccionar_Command" />
                                <br />
                                </td>
                        </ItemTemplate>
                        <LayoutTemplate>
                            <table runat="server">
                                <tr runat="server">
                                    <td runat="server" class="auto-style19">
                                        <table id="groupPlaceholderContainer" runat="server" border="0" style="">
                                            <tr id="groupPlaceholder" runat="server">
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr runat="server">
                                    <td runat="server" class="auto-style19">
                                        <asp:DataPager ID="DataPager1" runat="server" PageSize="6">
                                            <Fields>
                                                <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowLastPageButton="True" />
                                            </Fields>
                                        </asp:DataPager>
                                    </td>
                                </tr>
                            </table>
                        </LayoutTemplate>
                        <SelectedItemTemplate>
                            <td runat="server" style="">NombreSucursal:
                                <asp:Label ID="NombreSucursalLabel" runat="server" Text='<%# Eval("NombreSucursal") %>' />
                                <br />DescripcionSucursal:
                                <asp:Label ID="DescripcionSucursalLabel" runat="server" Text='<%# Eval("DescripcionSucursal") %>' />
                                <br />URL_Imagen_Sucursal:
                                <asp:Label ID="URL_Imagen_SucursalLabel" runat="server" Text='<%# Eval("URL_Imagen_Sucursal") %>' />
                                <br /></td>
                        </SelectedItemTemplate>
                    </asp:ListView>
                    <asp:SqlDataSource ID="sdsSucursales" runat="server" ConnectionString="<%$ ConnectionStrings:BDSucursalesConnectionString2 %>" SelectCommand="SELECT [NombreSucursal], [DescripcionSucursal], [URL_Imagen_Sucursal], [Id_Sucursal] FROM [Sucursal]"></asp:SqlDataSource>
                </td>
            </tr>
            </table>
    </form>
</body>
</html>
