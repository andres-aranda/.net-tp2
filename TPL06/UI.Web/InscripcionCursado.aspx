<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InscripcionCursado.aspx.cs" Inherits="Academia.UI.Web.InscripcionCursado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContent" runat="server">
    <div id="seleccionMateria">
        <p>
            Seleccione Materia:&nbsp;
        <asp:DropDownList ID="cmbMateria" runat="server" DataTextField="Descripcion" DataValueField="Id" AutoPostBack="True" OnSelectedIndexChanged="cmbMateria_SelectedIndexChanged">
        </asp:DropDownList>
            <asp:Button ID="Button1" runat="server" OnClick="cmbMateria_SelectedIndexChanged" Text="Refresh" />
        </p>
    </div>
    <div id="seleccionComision">
        <p>
            Seleccione Comision:&nbsp;
        <asp:DropDownList ID="cmbComision" runat="server" DataTextField="DescripcionComision" DataValueField="Id" OnSelectedIndexChanged="cmbComision_SelectedIndexChanged">
        </asp:DropDownList>
        </p>
    </div>
    <asp:DetailsView ID="detallesInscripcion" runat="server" Height="39px" Width="125px" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None" Visible="False">
        <EditRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
        <Fields>
            <asp:BoundField DataField="inscripcion.nombreMateria" HeaderText="Materia:" ReadOnly="True" SortExpression="nombreMateria" />
            <asp:BoundField DataField="inscripcion.nombreComison" HeaderText="Comision:" ReadOnly="True" SortExpression="nombreComison" />
            <asp:BoundField DataField="inscripcion.añoCurso" HeaderText="Año:" ReadOnly="True" SortExpression="turnoComision" />
        </Fields>
        <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
        <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
        <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
    </asp:DetailsView>
    <asp:Button ID="solicInscripcion" runat="server" Text="Solicitar inscripcion" OnClick="inscripcion_Click" />
    <div id="tablaResumen" runat="server">
        <p>✔ ¡Inscripción solicitada!</p>
        <table>
            <tr>
                <td><b>Comisión</b></td>
                <td class="auto-style1">
                    <asp:Label ID="ComisionLabel" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td><b>Materia</b></td>
                <td class="auto-style1">
                    <asp:Label ID="MateriaLabel" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td><b>Año</b></td>
                <td class="auto-style1">
                    <asp:Label ID="AñoLabel" runat="server" Text="Label"></asp:Label></td>
            </tr>
        </table>
    </div>
</asp:Content>
