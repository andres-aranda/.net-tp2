<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Alumnos.aspx.cs" Inherits="Academia.UI.Web.Alumnos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="misAlumnosDocentePage" ContentPlaceHolderID="PageContent" runat="server">

    <div>
        <div>
            <asp:LinkButton ID="lbtEditar" runat="server" OnClick="editarLinkButton_Click" ForeColor="Black" CssClass="btn">Editar</asp:LinkButton>
            <asp:LinkButton ID="lbtEliminar" runat="server" OnClick="EliminarLinkButton_Click" CssClass="btn">Eliminar</asp:LinkButton>
            <asp:LinkButton ID="lbtNuevo" runat="server" OnClick="NuevoLinkButton_Click" CssClass="btn">Nuevo</asp:LinkButton>
        </div>
        <asp:GridView ID="inscripcionesDocente" runat="server" AutoGenerateColumns="False" CssClass="tabla">
            <Columns>
                <asp:BoundField DataField="Curso.Materia.Descripcion" HeaderText="Materia" ReadOnly="True" />
                <asp:BoundField DataField="Curso.Comision.DescripcionComision" HeaderText="Comisión" ReadOnly="True" />
                <asp:BoundField DataField="Persona.Nombre" HeaderText="Nombre" ReadOnly="True" />
                <asp:BoundField DataField="Persona.Apellido" HeaderText="Apellido" ReadOnly="True" />
                <asp:BoundField DataField="Persona.Legajo" HeaderText="Legajo" ReadOnly="True" />
                <asp:BoundField DataField="Nota" HeaderText="Nota" />
                <asp:BoundField DataField="Curso.AñoCalendario" HeaderText="Año" />
            </Columns>
            <HeaderStyle CssClass="cabecera" />
            <RowStyle CssClass="filas" />
        </asp:GridView>
    </div>

</asp:Content>
