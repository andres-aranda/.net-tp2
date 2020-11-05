<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MisCursos.aspx.cs" Inherits="Academia.UI.Web.MisCursos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="misCursosPage" ContentPlaceHolderID="PageContent" runat="server">
    <asp:GridView ID="inscripcionesAlu" runat="server" AutoGenerateColumns="False" CssClass="tabla">
        <Columns>
            <asp:BoundField DataField="Curso.Materia.Descripcion" HeaderText="Materia">
                <ItemStyle Width="100px" />
            </asp:BoundField>
            <asp:BoundField DataField="Curso.Comision.DescripcionComision" HeaderText="Comisión">
                <ItemStyle Width="100px" />
            </asp:BoundField>
            <asp:BoundField DataField="Nota" HeaderText="Nota">
                <ItemStyle Width="50px" Wrap="True" />
            </asp:BoundField>
            <asp:BoundField DataField="Curso.AñoCalendario" HeaderText="Año">
                <ItemStyle Width="50px" />
            </asp:BoundField>
        </Columns>
        <HeaderStyle CssClass="cabecera" />
        <RowStyle CssClass="filas" Width="100px" />
    </asp:GridView>
</asp:Content>
