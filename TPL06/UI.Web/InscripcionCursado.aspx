<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InscripcionCursado.aspx.cs" Inherits="Academia.UI.Web.InscripcionCursado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContent" runat="server">
    <div id="seleccionMateria">
 <p>
        Seleccione Materia:&nbsp;
        <asp:DropDownList ID="cmbMateria" runat="server" DataTextField="Descripcion" DataValueField="Id">
        </asp:DropDownList>
        <asp:Button ID="Button1" runat="server" OnClick="cmbMateria_SelectedIndexChanged" Text="Refresh" />
    </p>
    </div>
    <div id="seleccionMateria">
 <p>
        Seleccione Comision:&nbsp;
        <asp:DropDownList ID="cmbComision" runat="server" DataTextField="Descripcion" DataValueField="Id">
        </asp:DropDownList>
    </p>
    </div>
    <asp:DetailsView ID="detallesInscripcion" runat="server" Height="50px" Width="125px" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None">
        <EditRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
        <Fields>
            <asp:BoundField DataField="nombreMateria" HeaderText="Materia:" ReadOnly="True" SortExpression="nombreMateria" />
            <asp:BoundField DataField="nombreComison" HeaderText="Comision:" ReadOnly="True" SortExpression="nombreComison" />
            <asp:BoundField DataField="turnoComision" HeaderText="Turno:" ReadOnly="True" SortExpression="turnoComision" />
        </Fields>
        <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
        <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
        <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
    </asp:DetailsView>
    <asp:Button ID="inscripcion" runat="server" Text="Solicitar inscripcion" />
</asp:Content>
