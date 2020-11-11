<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MiInformacion.aspx.cs" Inherits="Academia.UI.Web.MiInformacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContent" runat="server">
    <div>
        <table style="width: 100%;" class="tabla">
            <tr class="filas">
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Nombre de usuario"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtNombreUsua" runat="server" Enabled="False"></asp:TextBox>
                </td>
            </tr>
            <tr class="filas">
                <td class="auto-style1">
                    <asp:Label ID="Label3" runat="server" Text="Apellido"></asp:Label>
                </td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtApellido" runat="server" Height="25px"></asp:TextBox>
                </td>
                <td class="auto-style1">
                    <asp:Label ID="Label4" runat="server" Text="Clave"></asp:Label>
                </td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtClave" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr class="filas">
                <td>
                    <asp:Label ID="emailLabel0" runat="server" Text="Email"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server" Height="25px"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="repetirClaveLabel0" runat="server" Text="Repetir clave"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="repetirClave" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr class="filas">
                <td>Telefono</td>
                <td>
                    <asp:TextBox ID="txtTelefono" runat="server" Height="25px"></asp:TextBox>
                </td>
                <td>Direccion</td>
                <td>
                    <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr class="filas">
                <td>Fecha de nacimiento</td>
                <td>
                    <asp:TextBox ID="txtFechaNac" runat="server" Height="25px" Enabled="False"></asp:TextBox>
                </td>

            </tr>
            <tr class="filas">
                <td>Legajo</td>
                <td>
                    <asp:TextBox ID="txtLegajo" runat="server" Enabled="False" Height="25px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <div style="margin: 15px;">
            <asp:LinkButton ID="NuevoLinkButton" runat="server" CssClass="btn">Nuevo</asp:LinkButton>

        </div>
    </div>



</asp:Content>
