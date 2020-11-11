<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cursos.aspx.cs" Inherits="Academia.UI.Web.Cursos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContent" runat="server">
    <div>
        <asp:LinkButton ID="btnEditar" runat="server" OnClick="btnEditar_Click" CssClass="btn">Editar</asp:LinkButton>
        <asp:LinkButton ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" CssClass="btn">Eliminar</asp:LinkButton>
        <asp:LinkButton ID="btnNuevo" runat="server" OnClick="btnNuevo_Click" CssClass="btn">Nuevo</asp:LinkButton>
    </div>
    <asp:GridView ID="dgvCursos" runat="server" DataKeyNames="Id" AutoGenerateColumns="false" CssClass="tabla">
        <Columns>
            <asp:BoundField HeaderText="ID" DataField="Id" />
            <asp:BoundField HeaderText="Materia" DataField="Materia" />
            <asp:BoundField HeaderText="Comisión" DataField="Comision" />
            <asp:BoundField HeaderText="Año" DataField="Año" />
            <asp:BoundField HeaderText="Cupo" DataField="Cupo" />
            <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" />
        </Columns>
        <HeaderStyle CssClass="cabecera" />
        <RowStyle CssClass="filas" />
        <SelectedRowStyle BackColor="Black" ForeColor="White" />
    </asp:GridView>
</asp:Content>
