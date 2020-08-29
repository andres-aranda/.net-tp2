<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="Academia.UI.Web.Usuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Usuarios</title>
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="formPanel" runat="server" Height="114px" Visible="False">
                <table style="width:100%;">
                    <tr>
                        <td>
                            <asp:Label ID="nombreLabel" runat="server" Text="Nombre"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="nombreTextBox" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:Label ID="nombreUsuarioLabel" runat="server" Text="Nombre de usuario"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="nombreUsuarioTextBox" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">
                            <asp:Label ID="apellidoLabel" runat="server" Text="Apellido"></asp:Label>
                        </td>
                        <td class="auto-style1">
                            <asp:TextBox ID="apellidoTextBox" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style1">
                            <asp:Label ID="claveLabel" runat="server" Text="Clave"></asp:Label>
                        </td>
                        <td class="auto-style1">
                            <asp:TextBox ID="claveTextBox" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="emailLabel" runat="server" Text="Email"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:Label ID="repetirClaveLabel" runat="server" Text="Repetir clave"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="repetirClaveTextBox" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:CheckBox ID="habilitadoCheckBox" runat="server" Text="Habilitado" TextAlign="Left" />
                        </td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
            </asp:Panel>
            &nbsp;<asp:Panel ID="gridActionPanel" runat="server">
                <asp:LinkButton ID="editarLinkButton" runat="server" OnClick="editarLinkButton_Click">Editar</asp:LinkButton>
                <asp:LinkButton ID="EliminarLinkButton" runat="server" OnClick="EliminarLinkButton_Click">Eliminar</asp:LinkButton>
                <asp:LinkButton ID="NuevoLinkButton" runat="server" OnClick="NuevoLinkButton_Click">Nuevo</asp:LinkButton>
            </asp:Panel>
            <asp:Panel ID="gridPanel" runat="server">
                <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
                    SelectedRowStyle-BackColor="Black"
                    SelectedRowStyle-ForeColor="White"
                    DataKeyNames="ID">
                    <Columns>
                        <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                        <asp:BoundField HeaderText="Apellido" DataField="Apellido" />
                        <asp:BoundField HeaderText="Mail" DataField="EMail" />
                        <asp:BoundField HeaderText="Usuario" DataField="NombreUsuario" />
                        <asp:BoundField HeaderText="Habilitado" DataField="Habilitado" />
                        <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" />
                    </Columns>
                </asp:GridView>
            </asp:Panel>
        </div>
        <asp:Panel ID="formActionPanel" runat="server">
            <asp:LinkButton ID="AceptarLinkButton" runat="server" OnClick="AceptarLinkButton_Click">Aceptar</asp:LinkButton>
            <asp:LinkButton ID="CancelarLinkButton" runat="server" OnClick="CancelarLinkButton_Click">Cancelar</asp:LinkButton>
        </asp:Panel>
    </form>
</body>
</html>
