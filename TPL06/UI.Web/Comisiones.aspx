<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Comisiones.aspx.cs" Inherits="Academia.UI.Web.Comisiones" %>

<asp:Content ID="Content2" ContentPlaceHolderID="PageContent" runat="server">
    <div>
        <div>
            <asp:LinkButton ID="lbtEditar" runat="server" OnClick="editarLinkButton_Click" ForeColor="Black" CssClass="btn">Editar</asp:LinkButton>
            <asp:LinkButton ID="lbtEliminar" runat="server" OnClick="EliminarLinkButton_Click" CssClass="btn">Eliminar</asp:LinkButton>
            <asp:LinkButton ID="lbtNuevo" runat="server" OnClick="NuevoLinkButton_Click" CssClass="btn">Nuevo</asp:LinkButton>
        </div>
        <asp:Panel ID="gridPanel" runat="server">
            <asp:GridView ID="dgvComisiones" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
                SelectedRowStyle-BackColor="Black"
                SelectedRowStyle-ForeColor="White"
                DataKeyNames="ID" CssClass="tabla">
                <Columns>
                    <asp:BoundField HeaderText="Descripcion" DataField="DescripcionComision" />
                    <asp:BoundField HeaderText="Año especialidad" DataField="AñoEspecialidad" />
                    <asp:BoundField HeaderText="ID del plan" DataField="IdPlan" />
                    <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" />
                </Columns>
                <EditRowStyle CssClass="filas" />
                <HeaderStyle CssClass="cabecera" />
                <RowStyle CssClass="filas" />
            </asp:GridView>
        </asp:Panel>
    </div>
    <asp:Panel ID="formActionPanel" runat="server">
    </asp:Panel>
</asp:Content>
