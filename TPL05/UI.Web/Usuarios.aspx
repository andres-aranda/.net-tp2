<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="Academia.UI.Web.Usuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Usuarios</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="formPanel" runat="server">
                <asp:Label ID="nombreLabel" runat="server" Text="Nombre"></asp:Label>
                <asp:TextBox ID="nombreTextBox" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="apellidoLabel" runat="server" Text="Apellido"></asp:Label>
                <asp:TextBox ID="apellidoTextBox" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="emailLabel" runat="server" Text="Email"></asp:Label>
                <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox>
                <br />
                <asp:CheckBox ID="habilitadoCheckBox" runat="server" OnCheckedChanged="habilitadoCheckBox_CheckedChanged" Text="Habilitado" TextAlign="Left" />
                <br />
                <asp:Label ID="nombreUsuarioLabel" runat="server" Text="Nombre de usuario"></asp:Label>
                <asp:TextBox ID="nombreUsuarioTextBox" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="claveLabel" runat="server" Text="Clave"></asp:Label>
                <asp:TextBox ID="claveTextBox" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="repetirClaveLabel" runat="server" Text="Repetir clave"></asp:Label>
                <asp:TextBox ID="repetirClaveTextBox" runat="server"></asp:TextBox>
            </asp:Panel>
            &nbsp;<asp:Panel ID="gridActionPanel" runat="server">
                <asp:LinkButton ID="editarLinkButton" runat="server">Editar</asp:LinkButton>
                <asp:LinkButton ID="EliminarLinkButton" runat="server">Eliminar</asp:LinkButton>
                <asp:LinkButton ID="NuevoLinkButton" runat="server">Nuevo</asp:LinkButton>
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
            <asp:LinkButton ID="AceptarLinkButton" runat="server">Aceptar</asp:LinkButton>
            <asp:LinkButton ID="CancelarLinkButton" runat="server">Cancelar</asp:LinkButton>
        </asp:Panel>
    </form>
</body>
</html>
