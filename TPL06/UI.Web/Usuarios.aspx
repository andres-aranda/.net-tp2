<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="Academia.UI.Web.Usuarios" %>

<asp:Content ID="Content2" ContentPlaceHolderID="PageContent" runat="server">
    <div>
        <div style="margin-bottom: 15px;">
            <asp:LinkButton ID="editarLinkButton" runat="server" OnClick="editarLinkButton_Click" CssClass="btn">Editar</asp:LinkButton>
            <asp:LinkButton ID="EliminarLinkButton" runat="server" OnClick="EliminarLinkButton_Click" CssClass="btn">Eliminar</asp:LinkButton>
            <asp:LinkButton ID="NuevoLinkButton" runat="server" OnClick="NuevoLinkButton_Click" CssClass="btn">Nuevo</asp:LinkButton>
        </div>
        <asp:Panel ID="gridPanel" runat="server">
            <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
             
                DataKeyNames="ID" CssClass="tabla">
                <Columns>
                    <asp:BoundField HeaderText="Nombre" DataField="Persona.Nombre" />
                    <asp:BoundField HeaderText="Apellido" DataField="Persona.Apellido" />
                    <asp:BoundField HeaderText="Mail" DataField="Persona.Email" />
                    <asp:BoundField HeaderText="Usuario" DataField="NombreUsuario" />
                    <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" />
                </Columns>
                <HeaderStyle CssClass="cabecera" />
                <RowStyle CssClass="filas" />
                <SelectedRowStyle CssClass="filaSeleccionada" />
            </asp:GridView>
        </asp:Panel>
    </div>
    <asp:Panel ID="formActionPanel" runat="server">
    </asp:Panel>
</asp:Content>
