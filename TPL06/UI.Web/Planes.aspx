<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Planes.aspx.cs" Inherits="Academia.UI.Web.Planes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContent" runat="server">
         <div style="margin-bottom: 15px;">
            <asp:LinkButton ID="editarLinkButton" runat="server" OnClick="editarLinkButton_Click" CssClass="btn">Editar</asp:LinkButton>
            <asp:LinkButton ID="EliminarLinkButton" runat="server" OnClick="EliminarLinkButton_Click" CssClass="btn">Eliminar</asp:LinkButton>
            <asp:LinkButton ID="NuevoLinkButton" runat="server" OnClick="NuevoLinkButton_Click" CssClass="btn">Nuevo</asp:LinkButton>
        </div>
    <asp:GridView ID="dgvPlanes" runat="server" CssClass="tabla" AutoGenerateColumns="False" DataKeyNames="Id" OnSelectedIndexChanged="dgvPlanes_SelectedIndexChanged">
        <Columns>
            <asp:BoundField HeaderText="Plan" DataField="Descripcion" />
            <asp:BoundField HeaderText="Especialidad" DataField="Especialidad.Descripcion" />
            <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" />
        </Columns>
        <HeaderStyle CssClass="cabecera" />
        <RowStyle CssClass="filas" />
        <SelectedRowStyle CssClass="filaSeleccionada" />
    </asp:GridView>
</asp:Content>
