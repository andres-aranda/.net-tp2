<%@  Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ComisionForm.aspx.cs" Inherits="Academia.UI.Web.ComisionForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContent" runat="server">
    <table style="width:100%;">
        <tr>
            <td >
                Descripción</td>
            <td >
                <asp:TextBox ID="descComtxt" runat="server"></asp:TextBox>
            </td>
            <td >
                Año Especialidad</td>
            <td >
                <asp:TextBox ID="añoEspeTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr >
            <td class="auto-style1" >
                IdPlan</td>
            <td class="auto-style1" >
                <asp:TextBox ID="idPlanTextBox" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style1" >
                &nbsp;</td>
            <td class="auto-style1" >
                &nbsp;</td>
        </tr>
        </table>
    <asp:Panel ID="formActionPanel" runat="server">
        <asp:LinkButton ID="AceptarLinkButton" runat="server" OnClick="AceptarLinkButton_Click">Aceptar</asp:LinkButton>
        <asp:LinkButton ID="CancelarLinkButton" runat="server" OnClick="CancelarLinkButton_Click">Cancelar</asp:LinkButton>
        <br />
<asp:Button class="btn btn-primary float-right" ID="btnAceptar" runat="server" Text="Aceptar" OnClick="AceptarLinkButton_Click" />
<asp:Button class="btn btn-primary float-right" ID="btnCancelar" runat="server" Text="Cancelar" OnClick="CancelarLinkButton_Click" />
    </asp:Panel>
</asp:Content>
