<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ComisionForm.aspx.cs" Inherits="Academia.UI.Web.ComisionForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContent" runat="server">
    <table style="width:100%;" __designer:mapid="150">
        <tr __designer:mapid="151">
            <td __designer:mapid="152">
                Descripción</td>
            <td __designer:mapid="154">
                <asp:TextBox ID="descComtxt" runat="server"></asp:TextBox>
            </td>
            <td __designer:mapid="156">
                Año Especialidad</td>
            <td __designer:mapid="158">
                <asp:TextBox ID="añoEspeTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr __designer:mapid="15a">
            <td class="auto-style1" __designer:mapid="15b">
                IdPlan</td>
            <td class="auto-style1" __designer:mapid="15d">
                <asp:TextBox ID="idPlanTextBox" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style1" __designer:mapid="15f">
                &nbsp;</td>
            <td class="auto-style1" __designer:mapid="161">
                &nbsp;</td>
        </tr>
        </table>
    <asp:Panel ID="formActionPanel" runat="server">
        <asp:LinkButton ID="AceptarLinkButton" runat="server" OnClick="AceptarLinkButton_Click">Aceptar</asp:LinkButton>
        <asp:LinkButton ID="CancelarLinkButton" runat="server" OnClick="CancelarLinkButton_Click">Cancelar</asp:LinkButton>
    </asp:Panel>
</asp:Content>
