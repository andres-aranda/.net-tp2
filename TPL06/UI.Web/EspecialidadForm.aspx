<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EspecialidadForm.aspx.cs" Inherits="Academia.UI.Web.EspecialidadForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContent" runat="server">
    <table class="tabla">
        <tr class="filas">
            <td>
                <asp:Label ID="lblDescripcion" runat="server" Text="Especialidad"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtEspecialidad" runat="server"></asp:TextBox></td>
        </tr>
    </table>
    <div>
        <asp:LinkButton ID="btnGuardar" runat="server" CssClass="btn" OnClick="btnGuardar_Click">Guardar</asp:LinkButton>
    </div>
</asp:Content>
