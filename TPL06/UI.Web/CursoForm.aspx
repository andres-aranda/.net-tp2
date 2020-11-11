<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CursoForm.aspx.cs" Inherits="Academia.UI.Web.CursoForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContent" runat="server">
    <table>
        <tr>
            <td><asp:Label ID="lblPlan" runat="server" Text="Plan"></asp:Label></td>
            <td><asp:DropDownList ID="ddlPlanes" runat="server" AutoPostBack="True" DataTextField="Descripcion" DataValueField="Id" OnSelectedIndexChanged="ddlPlanes_SelectedIndexChanged"></asp:DropDownList></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblMateria" runat="server" Text="Materia"></asp:Label></td>
            <td><asp:DropDownList ID="ddlMaterias" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlMaterias_SelectedIndexChanged" DataTextField="Descripcion" DataValueField="Id"></asp:DropDownList></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblComision" runat="server" Text="Comisión"></asp:Label></td>
            <td><asp:DropDownList ID="ddlComisiones" runat="server" DataTextField="DescripcionComision" DataValueField="Id"></asp:DropDownList></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblAño" runat="server" Text="Año"></asp:Label></td>
            <td><asp:TextBox ID="txtAño" runat="server" type="number"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblCupo" runat="server" Text="Cupo"></asp:Label></td>
            <td><asp:TextBox ID="txtCupo" runat="server" type="number"></asp:TextBox></td>
        </tr>
        <tr>
            <td></td>
            <td><asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" /></td>
        </tr>
    </table>
</asp:Content>
