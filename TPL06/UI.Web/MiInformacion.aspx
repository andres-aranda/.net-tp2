<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MiInformacion.aspx.cs" Inherits="Academia.UI.Web.MiInformacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContent" runat="server">
    <div>
        <table style="width:100%;" __designer:mapid="150" class="tabla">
        <tr __designer:mapid="151" class="filas">
            <td __designer:mapid="152">
                <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
            </td>
            <td __designer:mapid="154">
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            </td>
            <td __designer:mapid="156">
                <asp:Label ID="Label2" runat="server" Text="Nombre de usuario"></asp:Label>
            </td>
            <td __designer:mapid="158">
                <asp:TextBox ID="txtNombreUsua" runat="server" Enabled="False"></asp:TextBox>
            </td>
        </tr>
        <tr __designer:mapid="15a" class="filas">
            <td class="auto-style1" __designer:mapid="15b">
                <asp:Label ID="Label3" runat="server" Text="Apellido"></asp:Label>
            </td>
            <td class="auto-style1" __designer:mapid="15d">
                <asp:TextBox ID="txtApellido" runat="server" Height="25px"></asp:TextBox>
            </td>
            <td class="auto-style1" __designer:mapid="15f">
                <asp:Label ID="Label4" runat="server" Text="Clave"></asp:Label>
            </td>
            <td class="auto-style1" __designer:mapid="161">
                <asp:TextBox ID="txtClave" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr class="filas">
            <td __designer:mapid="164">
                <asp:Label ID="emailLabel0" runat="server" Text="Email"></asp:Label>
            </td>
            <td __designer:mapid="166">
                <asp:TextBox ID="txtEmail" runat="server" Height="25px"></asp:TextBox>
            </td>
            <td __designer:mapid="168">
                <asp:Label ID="repetirClaveLabel0" runat="server" Text="Repetir clave"></asp:Label>
            </td>
            <td __designer:mapid="16a">
                <asp:TextBox ID="repetirClave" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr class="filas">
            <td __designer:mapid="164">
                Telefono</td>
            <td __designer:mapid="166">
                <asp:TextBox ID="txtTelefono" runat="server" Height="25px"></asp:TextBox>
            </td>
            <td __designer:mapid="168">
                Direccion</td>
            <td __designer:mapid="16a">
                <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr class="filas">
            <td __designer:mapid="164">
                Fecha de nacimiento</td>
            <td __designer:mapid="166">
                <asp:TextBox ID="txtFechaNac" runat="server" Height="25px"></asp:TextBox>
            </td>
            <td __designer:mapid="168">
                Plan</td>
            <td __designer:mapid="16a">
                <asp:TextBox ID="txtPlan" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr __designer:mapid="163" class="filas">
            <td __designer:mapid="164">
                Legajo</td>
            <td __designer:mapid="166">
                <asp:TextBox ID="txtLegajo" runat="server" Enabled="False" Height="25px"></asp:TextBox>
            </td>
            <td __designer:mapid="168">
                &nbsp;</td>
            <td __designer:mapid="16a">
                &nbsp;</td>
        </tr>
        </table>
<%--    <asp:Panel ID="Panel1" runat="server">
    </asp:Panel>--%>
    </div>
    

    
</asp:Content>
