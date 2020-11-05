<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Comisiones.aspx.cs" Inherits="Academia.UI.Web.Comisiones" %>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContent" runat="server">
    <div>
        &nbsp;<asp:Panel ID="gridActionPanel" runat="server">
            <asp:LinkButton ID="editarLinkButton" runat="server" OnClick="editarLinkButton_Click">Editar</asp:LinkButton>
            <asp:LinkButton ID="EliminarLinkButton" runat="server" OnClick="EliminarLinkButton_Click">Eliminar</asp:LinkButton>
            <asp:LinkButton ID="NuevoLinkButton" runat="server" OnClick="NuevoLinkButton_Click">Nuevo</asp:LinkButton>
        </asp:Panel>
        <asp:Panel ID="gridPanel" runat="server">
            <asp:GridView ID="gridViewComisiones" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
                SelectedRowStyle-BackColor="Black"
                SelectedRowStyle-ForeColor="White"
                DataKeyNames="ID">
                <Columns>
                    <asp:BoundField HeaderText="Descripcion" DataField="DescripcionComision" />
                    <asp:BoundField HeaderText="Año especialidad" DataField="AñoEspecialidad" />
                    <asp:BoundField HeaderText="ID del plan" DataField="IdPlan" />
                    <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
        </asp:Panel>
    </div>
    <asp:Panel ID="formActionPanel" runat="server">
    </asp:Panel>
</asp:Content>