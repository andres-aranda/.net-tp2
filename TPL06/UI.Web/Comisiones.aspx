<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Comisiones.aspx.cs" Inherits="Academia.UI.Web.Comisiones" %>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContent" runat="server">
    <div>
        &nbsp;<asp:Panel ID="gridActionPanel" runat="server">
            
                       <asp:Button class="btn btn-primary float-right" ID="btnEditar" runat="server" Text="Editar" OnClick="editarLinkButton_Click" />
                       <asp:Button class="btn btn-primary float-right" ID="btnEliminar" runat="server" Text="Borrar" OnClick="EliminarLinkButton_Click" />
                       <asp:Button class="btn btn-primary float-right" ID="btnNuevo" runat="server" Text="Nuevo" OnClick="NuevoLinkButton_Click" />
        </asp:Panel>
        <asp:Panel ID="gridPanel" runat="server">
            <asp:GridView ID="gridViewComisiones" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
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