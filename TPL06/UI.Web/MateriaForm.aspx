<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MateriaForm.aspx.cs" Inherits="Academia.UI.Web.MateriaForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContent" runat="server">
    <table style="width: 100%;" __designer:mapid="150">
        <tr __designer:mapid="151">
            <td __designer:mapid="152">
                <asp:Label ID="nombreLabel" runat="server" Text="Descripccion"></asp:Label>
            </td>
            <td __designer:mapid="154">
                <asp:TextBox ID="descripcionTextBox" runat="server"></asp:TextBox>
            </td>
            <td __designer:mapid="156">NroPlan</td>
            <td __designer:mapid="158">
                <asp:TextBox ID="idPlanTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr __designer:mapid="15a">
            <td class="auto-style1" __designer:mapid="15b">
                <asp:Label ID="apellidoLabel" runat="server" Text="Hs Semanales"></asp:Label>
            </td>
            <td class="auto-style1" __designer:mapid="15d">
                <asp:TextBox ID="hsSemanalesTextBox" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style1" __designer:mapid="15f">
                <asp:Label ID="claveLabel" runat="server" Text="Hs Totales"></asp:Label>
            </td>
            <td class="auto-style1" __designer:mapid="161">
                <asp:TextBox ID="hsTotalesTextBox" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr __designer:mapid="163">
            <td __designer:mapid="164">&nbsp;</td>
            <td __designer:mapid="166">&nbsp;</td>
            <td __designer:mapid="168">&nbsp;</td>
            <td __designer:mapid="16a">&nbsp;</td>
        </tr>
        <tr __designer:mapid="16c">
            <td __designer:mapid="16d">&nbsp;</td>
            <td __designer:mapid="16f">&nbsp;</td>
            <td __designer:mapid="170">&nbsp;</td>
            <td __designer:mapid="171">&nbsp;</td>
        </tr>
    </table>
    <div style="margin-bottom: 15px;">
        <asp:LinkButton ID="editarLinkButton" runat="server" OnClick="AceptarLinkButton_Click" CssClass="btn">Aceptar</asp:LinkButton>
        <asp:LinkButton ID="EliminarLinkButton" runat="server" OnClick="CancelarLinkButton_Click" CssClass="btn">Cancelar</asp:LinkButton>

    </div>
</asp:Content>
