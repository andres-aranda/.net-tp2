<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="IngresoLegajoAlumno.aspx.cs" Inherits="Academia.UI.Web.IngresoLegajoAlumno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContent" runat="server">
    <table>
        <tr class="filas">
            <td><asp:Label runat="server" Text="Legajo"></asp:Label></td>
            <td><asp:TextBox runat="server" ID="txtLegajo"></asp:TextBox></td>
            <td><asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" style="height: 26px" /></td>
        </tr>
    </table>
</asp:Content>
