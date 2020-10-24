<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MisCursos.aspx.cs" Inherits="Academia.UI.Web.MisCursos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="misCursosPage" ContentPlaceHolderID="PageContent" runat="server">
    <asp:GridView ID="inscripcionesAlu" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="Curso.Materia.Descripcion" HeaderText="Materia" />
            <asp:BoundField DataField="Curso.Comision.DescripcionComision" HeaderText="Comisión" />
            <asp:BoundField DataField="Nota" HeaderText="Nota" />
            <asp:BoundField DataField="Curso.AñoCalendario" HeaderText="Año" />
        </Columns>
    </asp:GridView>
</asp:Content>
