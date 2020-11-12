<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ComisionForm.aspx.cs" Inherits="Academia.UI.Web.ComisionForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style9 {
            width: 178px;
        }

        .auto-style10 {
            font-size: 15px;
            color: #808080;
            line-height: 1.2;
            font-weight: unset;
            height: 50px;
            width: 122px;
        }

        .auto-style11 {
            width: 122px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContent" runat="server">
    <table style="width: 100%;" class="tabla">
        <tr>
            <td class="auto-style10">Descripción</td>
            <td class="auto-style9">
                <asp:TextBox ID="descComtxt" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style10">Año Especialidad</td>
            <td>
                <asp:TextBox ID="añoEspeTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr class="filas">
            <td class="auto-style11">NroPlan</td>
            <td class="auto-style9">
                <asp:DropDownList ID="cboIdPlan" runat="server" DataTextField="Descripcion" DataValueField="Id" OnSelectedIndexChanged="cboIdPlan_SelectedIndexChanged" OnTextChanged="cboIdPlan_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
            </td>
            <td colspan="2">
                <asp:Label ID="lblEspecialidad" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
    </table>

    <div style="margin-bottom: 15px;">
        <asp:LinkButton ID="editarLinkButton" runat="server" OnClick="AceptarLinkButton_Click" CssClass="btn">Aceptar</asp:LinkButton>
        <asp:LinkButton ID="EliminarLinkButton" runat="server" OnClick="CancelarLinkButton_Click" CssClass="btn">Cancelar</asp:LinkButton>
    </div>
</asp:Content>
