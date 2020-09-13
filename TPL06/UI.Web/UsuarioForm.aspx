<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UsuarioForm.aspx.cs" Inherits="Academia.UI.Web.UsuarioForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContent" runat="server">
    <table style="width:100%;" __designer:mapid="150">
        <tr __designer:mapid="151">
            <td __designer:mapid="152">
                <asp:Label ID="nombreLabel" runat="server" Text="Nombre"></asp:Label>
            </td>
            <td __designer:mapid="154">
                <asp:TextBox ID="nombreTextBox" runat="server"></asp:TextBox>
            </td>
            <td __designer:mapid="156">
                <asp:Label ID="nombreUsuarioLabel" runat="server" Text="Nombre de usuario"></asp:Label>
            </td>
            <td __designer:mapid="158">
                <asp:TextBox ID="nombreUsuarioTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr __designer:mapid="15a">
            <td class="auto-style1" __designer:mapid="15b">
                <asp:Label ID="apellidoLabel" runat="server" Text="Apellido"></asp:Label>
            </td>
            <td class="auto-style1" __designer:mapid="15d">
                <asp:TextBox ID="apellidoTextBox" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style1" __designer:mapid="15f">
                <asp:Label ID="claveLabel" runat="server" Text="Clave"></asp:Label>
            </td>
            <td class="auto-style1" __designer:mapid="161">
                <asp:TextBox ID="claveTextBox" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr __designer:mapid="163">
            <td __designer:mapid="164">
                <asp:Label ID="emailLabel" runat="server" Text="Email"></asp:Label>
            </td>
            <td __designer:mapid="166">
                <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox>
            </td>
            <td __designer:mapid="168">
                <asp:Label ID="repetirClaveLabel" runat="server" Text="Repetir clave"></asp:Label>
            </td>
            <td __designer:mapid="16a">
                <asp:TextBox ID="repetirClaveTextBox" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr __designer:mapid="16c">
            <td __designer:mapid="16d">
                <asp:CheckBox ID="habilitadoCheckBox" runat="server" Text="Habilitado" TextAlign="Left" />
            </td>
            <td __designer:mapid="16f">&nbsp;</td>
            <td __designer:mapid="170">&nbsp;</td>
            <td __designer:mapid="171">&nbsp;</td>
        </tr>
    </table>
    <asp:Panel ID="formActionPanel" runat="server">
        <asp:LinkButton ID="AceptarLinkButton" runat="server" OnClick="AceptarLinkButton_Click">Aceptar</asp:LinkButton>
        <asp:LinkButton ID="CancelarLinkButton" runat="server" OnClick="CancelarLinkButton_Click">Cancelar</asp:LinkButton>
    </asp:Panel>
</asp:Content>
