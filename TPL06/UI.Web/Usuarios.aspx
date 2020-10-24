<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="Academia.UI.Web.Usuarios" %>

<asp:Content ID="Content2" ContentPlaceHolderID="PageContent" runat="server">
    <div>
        &nbsp;<asp:Panel ID="gridActionPanel" runat="server">
            <asp:LinkButton ID="editarLinkButton" runat="server" OnClick="editarLinkButton_Click" BackColor="#99CCFF" BorderColor="Black">Editar</asp:LinkButton>
            <asp:LinkButton ID="EliminarLinkButton" runat="server" OnClick="EliminarLinkButton_Click" BackColor="#99CCFF" BorderColor="Black">Eliminar</asp:LinkButton>
            <asp:LinkButton ID="NuevoLinkButton" runat="server" OnClick="NuevoLinkButton_Click" BackColor="#99CCFF" BorderColor="Black">Nuevo</asp:LinkButton>
        </asp:Panel>
        <asp:Panel ID="gridPanel" runat="server">
            <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
                SelectedRowStyle-BackColor="Black"
                SelectedRowStyle-ForeColor="White"
                DataKeyNames="ID" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
                <Columns>
                    <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                    <asp:BoundField HeaderText="Apellido" DataField="Apellido" />
                    <asp:BoundField HeaderText="Mail" DataField="EMail" />
                    <asp:BoundField HeaderText="Usuario" DataField="NombreUsuario" />
                    <asp:BoundField HeaderText="Habilitado" DataField="Habilitado" />
                    <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" />
                </Columns>
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                <RowStyle BackColor="White" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#808080" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>
        </asp:Panel>
    </div>
    <asp:Panel ID="formActionPanel" runat="server">
    </asp:Panel>
</asp:Content>
