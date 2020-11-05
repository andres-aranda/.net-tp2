<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/Site.Master" CodeBehind="Materias.aspx.cs" Inherits="Academia.UI.Web.Materias" %>

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
                <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
                    SelectedRowStyle-BackColor="Black"
                    SelectedRowStyle-ForeColor="White"
                    DataKeyNames="Id" CssClass="tabla">
                    <Columns>
                        <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" />
                        <asp:BoundField HeaderText="HsSemanales" DataField="HsSemanales" />
                        <asp:BoundField HeaderText="HsTotales" DataField="HsTotales" />
                        <asp:BoundField HeaderText="IdPlan" DataField="IdPlan" />
                        <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" />
                    </Columns>
                    <HeaderStyle CssClass="cabecera" />
                    <RowStyle CssClass="filas" />
                    <SelectedRowStyle BackColor="Black" ForeColor="White" />
                </asp:GridView>
            </asp:Panel>
        </div>
        <asp:Panel ID="formActionPanel" runat="server">
        </asp:Panel>
 </asp:Content>