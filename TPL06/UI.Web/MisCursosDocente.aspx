<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MisCursosDocente.aspx.cs" Inherits="Academia.UI.Web.MisCursosDocente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-top: 15px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:GridView ID="inscripcionesDocente" runat="server" AutoGenerateColumns="False" CssClass="auto-style1">
        <Columns>
            <asp:BoundField DataField="Curso.Materia.Descripcion" HeaderText="Materia" ReadOnly="True" />
            <asp:BoundField DataField="Curso.Comision.DescripcionComision" HeaderText="Comisión" ReadOnly="True" />
            <asp:BoundField DataField="Curso.Persona.Nombre" HeaderText="Nombre" ReadOnly="True" />
            <asp:BoundField DataField="Curso.Persona.Apellido" HeaderText="Apellido" ReadOnly="True" />
            <asp:BoundField DataField="Curso.Persona.Legajo" HeaderText="Legajo" ReadOnly="True" />
            <asp:BoundField DataField="Nota" HeaderText="Nota" ReadOnly="True" />
            <asp:BoundField DataField="Curso.AñoCalendario" HeaderText="Año" />
        </Columns>
    </asp:GridView>
        </div>
    </form>
</body>
</html>
