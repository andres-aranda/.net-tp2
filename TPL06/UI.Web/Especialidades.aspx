<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Especialidades.aspx.cs" Inherits="Academia.UI.Web.Especialidades" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContent" runat="server">
    <div>
        <asp:LinkButton ID="btnNuevo" runat="server" OnClick="btnNuevo_Click" CssClass="btn">Nuevo</asp:LinkButton>
        <asp:LinkButton ID="btnEditar" runat="server" OnClick="btnEditar_Click" CssClass="btn">Editar</asp:LinkButton>
        <asp:LinkButton ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" CssClass="btn">Eliminar</asp:LinkButton>
    </div>
    <asp:GridView ID="dgvEspecialidades" runat="server" DataKeyNames="Id" AutoGenerateColumns="False" CssClass="tabla">
        <Columns>
            <asp:BoundField HeaderText="ID" DataField="Id" />
            <asp:BoundField HeaderText="Especialidad" DataField="Descripcion" />
            <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" >
            <ControlStyle Width="125px" />
            <FooterStyle Width="125px" />
            <HeaderStyle Width="125px" />
            <ItemStyle Width="125px" />
            </asp:CommandField>
        </Columns>
        <HeaderStyle CssClass="cabecera" />
        <RowStyle CssClass="filas" />
        <SelectedRowStyle BackColor="Black" ForeColor="White" />
    </asp:GridView>
</asp:Content>
