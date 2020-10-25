<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MisCursosDocente.aspx.cs" Inherits="Academia.UI.Web.MisCursosDocente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="misCursosDocentePage" ContentPlaceHolderID="PageContent" runat="server">
   
        <div>
             <asp:GridView ID="inscripcionesDocente" runat="server" AutoGenerateColumns="False" CssClass="tabla">
        <Columns>
            <asp:BoundField DataField="Curso.Materia.Descripcion" HeaderText="Materia" ReadOnly="True" />
            <asp:BoundField DataField="Curso.Comision.DescripcionComision" HeaderText="Comisión" ReadOnly="True" />
            <asp:BoundField DataField="Persona.Nombre" HeaderText="Nombre" ReadOnly="True" />
            <asp:BoundField DataField="Persona.Apellido" HeaderText="Apellido" ReadOnly="True" />
            <asp:BoundField DataField="Persona.Legajo" HeaderText="Legajo" ReadOnly="True" />
            <asp:BoundField DataField="Nota" HeaderText="Nota" ReadOnly="True" />
            <asp:BoundField DataField="Curso.AñoCalendario" HeaderText="Año" />
        </Columns>
                 <HeaderStyle CssClass="cabecera" />
                 <RowStyle CssClass="filas" />
    </asp:GridView>
        </div>
 
    </asp:Content>
