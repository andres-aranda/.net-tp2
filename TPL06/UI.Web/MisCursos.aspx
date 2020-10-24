<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MisCursos.aspx.cs" Inherits="Academia.UI.Web.MisCursos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="misCursosPage" ContentPlaceHolderID="PageContent" runat="server">
    <asp:GridView ID="inscripcionesAlu" runat="server">
    </asp:GridView>
</asp:Content>
