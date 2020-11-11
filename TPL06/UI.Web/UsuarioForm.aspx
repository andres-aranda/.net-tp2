<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UsuarioForm.aspx.cs" Inherits="Academia.UI.Web.UsuarioForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContent" runat="server">
    <table style="width:100%;">
        <tr>
            <td>
                <asp:Label ID="nombreLabel" runat="server" Text="Nombre"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="nombreTextBox" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;<asp:Label ID="nombreUsuarioLabel" runat="server" Text="Nombre de usuario"></asp:Label>
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
                <asp:TextBox ID="claveTextBox" runat="server" TextMode="Password"></asp:TextBox>
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
                <asp:TextBox ID="repetirClaveTextBox" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:CheckBox ID="habilitadoCheckBox" runat="server" Text="Habilitado" TextAlign="Left" BorderColor="Black" ForeColor="Black" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    

<asp:Panel ID="formActionPanel" runat="server">
        <asp:LinkButton ID="AceptarLinkButton" runat="server" OnClick="AceptarLinkButton_Click" CssClass="btn">Aceptar</asp:LinkButton>
        <asp:LinkButton ID="CancelarLinkButton" runat="server" OnClick="CancelarLinkButton_Click" CssClass="btn">Cancelar</asp:LinkButton>
    </asp:Panel>
</asp:Content>
