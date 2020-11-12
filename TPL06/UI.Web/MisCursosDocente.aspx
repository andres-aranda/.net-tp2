<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MisCursosDocente.aspx.cs" Inherits="Academia.UI.Web.MisCursosDocente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContent" runat="server">
           <div class="contenedorImprimir">
               <input id="btnPrint" class="btn" type="button" value="Imprimir" onclick="doPrint()" />
           </div>

    <!--startprint-->
           <h1>Cursos</h1>
    <asp:GridView ID="cursosDocenteGV" runat="server" AutoGenerateColumns="False" CssClass="tabla" >
        <Columns>
            <asp:BoundField DataField="Materia.Descripcion" HeaderText="Materia" />
            <asp:BoundField DataField="Comision.DescripcionComision" HeaderText="Comisión" />
            <asp:BoundField DataField="AñoCalendario" HeaderText="Año Calendario" />
        </Columns>
        <HeaderStyle CssClass="cabecera" />
        <RowStyle CssClass="filas" />
    </asp:GridView>
     <!--endprint-->
</asp:Content>
