<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="Academia.UI.Web.Usuarios" %>

<asp:Content ID="Content2" ContentPlaceHolderID="PageContent" runat="server">
    <div>
        &nbsp;<asp:Panel ID="gridActionPanel" runat="server">
            
                       <asp:Button class="btn btn-primary float-right" ID="btnEditar" runat="server" Text="Editar" OnClick="editarLinkButton_Click" />
                       <asp:Button class="btn btn-primary float-right" ID="btnEliminar" runat="server" Text="Borrar" OnClick="EliminarLinkButton_Click" />
                       <asp:Button class="btn btn-primary float-right" ID="btnNuevo" runat="server" Text="Nuevo" OnClick="NuevoLinkButton_Click" />
            <asp:LinkButton ID="editarLinkButton" runat="server" OnClick="editarLinkButton_Click" BackColor="#99CCFF" BorderColor="Black">Editar</asp:LinkButton>
            <asp:LinkButton ID="EliminarLinkButton" runat="server" OnClick="EliminarLinkButton_Click" BackColor="#99CCFF" BorderColor="Black">Eliminar</asp:LinkButton>
            <asp:LinkButton ID="NuevoLinkButton" runat="server" OnClick="NuevoLinkButton_Click" BackColor="#99CCFF" BorderColor="Black">Nuevo</asp:LinkButton>
        </asp:Panel>
        <asp:Panel ID="gridPanel" runat="server">
            <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
                SelectedRowStyle-BackColor="Black"
                SelectedRowStyle-ForeColor="White"
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
            </asp:GridView>
        </asp:Panel>
    </div>
    <asp:Panel ID="formActionPanel" runat="server">
    </asp:Panel>
</asp:Content>
