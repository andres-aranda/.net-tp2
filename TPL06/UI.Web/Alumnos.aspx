<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Alumnos.aspx.cs" Inherits="Academia.UI.Web.Alumnos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="misAlumnosDocentePage" ContentPlaceHolderID="PageContent" runat="server">

    <div>
        <asp:Panel ID="ZonaEdicion" runat="server">

            <asp:TextBox ID="txtNota" runat="server"></asp:TextBox>
            <asp:LinkButton ID="btnGuardar" runat="server" CssClass="btn" OnClick="btnGuardar_Click">Guardar</asp:LinkButton>

        </asp:Panel>

        <asp:GridView ID="inscripcionesDocente" runat="server" AutoGenerateColumns="False" CssClass="tabla" DataKeyNames="Id" OnSelectedIndexChanged="inscripcionesDocente_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" />
                <asp:BoundField DataField="Curso.Materia.Descripcion" HeaderText="Materia" ReadOnly="True" />
                <asp:BoundField DataField="Curso.Comision.DescripcionComision" HeaderText="Comisión" ReadOnly="True" />
                <asp:BoundField DataField="Persona.Nombre" HeaderText="Nombre" ReadOnly="True" />
                <asp:BoundField DataField="Persona.Apellido" HeaderText="Apellido" ReadOnly="True" />
                <asp:BoundField DataField="Persona.Legajo" HeaderText="Legajo" ReadOnly="True" />
                <asp:BoundField DataField="Nota" HeaderText="Nota" />
                <asp:BoundField DataField="Curso.AñoCalendario" HeaderText="Año" />
                <asp:CommandField SelectText="Calificar" ShowSelectButton="True" />

            </Columns>
            <HeaderStyle CssClass="cabecera" />
            <RowStyle CssClass="filas" />
        </asp:GridView>
    </div>

</asp:Content>
