<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MateriaForm.aspx.cs" Inherits="Academia.UI.Web.MateriaForm" %>

<%@ Register Src="~/Planes.ascx" TagPrefix="uc1" TagName="Planes" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 171px;
            height: 24px;
        }

        .auto-style2 {
            width: 122px;
        }

        .auto-style3 {
            width: 190px;
        }

        .auto-style6 {
            width: 122px;
            height: 4px;
        }

        .auto-style7 {
            width: 86px;
            height: 24px;
        }
        .auto-style8 {
            width: 190px;
            height: 4px;
        }
    .auto-style9 {
        height: 4px;
    }
        .auto-style10 {
            margin-bottom: 0px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContent" runat="server">
    <table style="width: 100%;" class="tabla">
        <tr class="filas">
           
            <td colspan="5">
                <uc1:Planes runat="server" ID="PlanesID" />

           </td>
        
        </tr>
        <tr class="filas">
            <td class="auto-style3">
                <asp:Label ID="nombreLabel" runat="server" Text="Descripccion"></asp:Label>
            </td>
            <td class="auto-style2">
                <asp:TextBox ID="descripcionTextBox" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style7">
                <asp:Label ID="claveLabel" runat="server" Text="Hs Totales"></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="hsTotalesTextBox" runat="server" ></asp:TextBox>
            </td>
        </tr>
        <tr class="filas">
            <td class="auto-style8">
                <asp:Label ID="apellidoLabel" runat="server" Text="Hs Semanales"></asp:Label>
            </td>
            <td class="auto-style6">
                <asp:TextBox ID="hsSemanalesTextBox" runat="server" ></asp:TextBox>
            </td>
            <td class="auto-style9"></td>
        </tr>

    </table>
    <div style="margin-bottom: 15px;">
        <asp:LinkButton ID="editarLinkButton" runat="server" OnClick="AceptarLinkButton_Click" CssClass="btn">Aceptar</asp:LinkButton>
        <asp:LinkButton ID="EliminarLinkButton" runat="server" OnClick="CancelarLinkButton_Click" CssClass="btn">Cancelar</asp:LinkButton>

    </div>
</asp:Content>
