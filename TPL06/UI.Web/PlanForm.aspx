<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PlanForm.aspx.cs" Inherits="Academia.UI.Web.PlanForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style type="text/css">
        .auto-style1 {
            width: 171px;
            height: 24px;
        }

        .auto-style3 {
            width: 42px;
        }

        .auto-style7 {
            width: 46px;
            height: 24px;
        }
         .auto-style8 {
             width: 72px;
         }
        </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="PageContent" runat="server">
    <table style="width: 100%;" class="tabla">
      
        <tr class="filas">
            <td class="auto-style3">
                <asp:Label ID="nombreLabel" runat="server" Text="Descripcion"></asp:Label>
            </td>
            <td class="auto-style8">
                <asp:TextBox ID="descripcionTextBox" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style7">
                <asp:Label ID="lblEspecialidad" runat="server" Text="Especialidad"></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:DropDownList ID="cmbEspecialidad" runat="server" AutoPostBack="True" DataTextField="Descripcion" DataValueField="Id" >
                </asp:DropDownList>
            </td>
        </tr>
     

    </table>
    <div style="margin-bottom: 15px;">
        <asp:LinkButton ID="editarLinkButton" runat="server" OnClick="AceptarLinkButton_Click" CssClass="btn">Aceptar</asp:LinkButton>
        <asp:LinkButton ID="CancelarLinkButton" runat="server" OnClick="CancelarLinkButton_Click" CssClass="btn">Cancelar</asp:LinkButton>

    </div>
</asp:Content>
