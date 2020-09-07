﻿<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/Site.Master" CodeBehind="Materias.aspx.cs" Inherits="Academia.UI.Web.Materias" %>

<asp:Content ID="Content2" ContentPlaceHolderID="PageContent" runat="server">
  <div>
            &nbsp;<asp:Panel ID="gridActionPanel" runat="server">
                <asp:LinkButton ID="editarLinkButton" runat="server">Editar</asp:LinkButton>
                <asp:LinkButton ID="EliminarLinkButton" runat="server">Eliminar</asp:LinkButton>
                <asp:LinkButton ID="NuevoLinkButton" runat="server">Nuevo</asp:LinkButton>
            </asp:Panel>
            <asp:Panel ID="gridPanel" runat="server">
                <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
                    SelectedRowStyle-BackColor="Black"
                    SelectedRowStyle-ForeColor="White"
                    DataKeyNames="Id">
                    <Columns>
                        <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" />
                        <asp:BoundField HeaderText="HsSemanales" DataField="HsSemanales" />
                        <asp:BoundField HeaderText="HsTotales" DataField="HsTotales" />
                        <asp:BoundField HeaderText="IdPlan" DataField="IdPlan" />
                        <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" />
                    </Columns>
                </asp:GridView>
            </asp:Panel>
        </div>
        <asp:Panel ID="formActionPanel" runat="server">
            <asp:LinkButton ID="AceptarLinkButton" runat="server">Aceptar</asp:LinkButton>
            <asp:LinkButton ID="CancelarLinkButton" runat="server">Cancelar</asp:LinkButton>
        </asp:Panel>
 </asp:Content>