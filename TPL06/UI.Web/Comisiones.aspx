<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Comisiones.aspx.cs" Inherits="Academia.UI.Web.Comisiones" %>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContent" runat="server">
    <div>
             <div style="margin-bottom: 15px;">
<asp:LinkButton ID="editarLinkButton" runat="server" OnClick="editarLinkButton_Click" ForeColor="Black" style="
    border-radius: 20px;
    font-size: 1.25rem !important;
    background: #36304a !important;
    color: white !important;
    margin: 5px  !important;
    padding: .3rem .5rem .3rem .5rem !important;">
            Editar
        </asp:LinkButton>
        <asp:LinkButton ID="EliminarLinkButton" runat="server" OnClick="EliminarLinkButton_Click" style="
border-radius: 10px;
font-size: 1.25rem !important;
background: #36304a !important;
color: white !important;
margin: 5px  !important;
padding: .3rem .5rem .3rem .5rem !important;">
            Eliminar</asp:LinkButton>
        <asp:LinkButton ID="NuevoLinkButton" runat="server" OnClick="NuevoLinkButton_Click" style="
border-radius: 20px;
font-size: 1.25rem !important;
background: #36304a !important;
color: white !important;
margin: 5px  !important;
padding: .3rem .5rem .3rem .5rem !important;">
            Nuevo</asp:LinkButton>

        </div>
        <asp:Panel ID="gridPanel" runat="server">
            <asp:GridView ID="gridViewComisiones" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
                SelectedRowStyle-BackColor="Black"
                SelectedRowStyle-ForeColor="White"
                DataKeyNames="ID" CssClass="tabla">
                <Columns>
                    <asp:BoundField HeaderText="Descripcion" DataField="DescripcionComision" />
                    <asp:BoundField HeaderText="Año especialidad" DataField="AñoEspecialidad" />
                    <asp:BoundField HeaderText="ID del plan" DataField="IdPlan" />
                    <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True"  />
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