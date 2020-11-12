<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Planes.ascx.cs" Inherits="Academia.UI.Web.Planes1" %>
<asp:Label ID="Label1" runat="server" Text="Planes: "></asp:Label>
<asp:DropDownList ID="cmbPlanes" runat="server" AutoPostBack="True" DataValueField="Id" OnSelectedIndexChanged="cmbPlanes_SelectedIndexChanged" DataTextField="Descripcion" OnTextChanged="cmbPlanes_SelectedIndexChanged">
</asp:DropDownList>
<asp:Label ID="lblplan" runat="server" Text="Label"></asp:Label>

