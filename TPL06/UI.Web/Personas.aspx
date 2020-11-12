<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Personas.aspx.cs" Inherits="Academia.UI.Web.Personas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContent" runat="server">
    <div class="contenedorImprimir">
              <input id="btnPrint" class="btn" type="button" value="Imprimir" onclick="doPrint()" />
           </div>
    <div>
        <asp:LinkButton ID="btnEditar" runat="server" OnClick="btnEditar_Click" CssClass="btn">Editar</asp:LinkButton>
        <asp:LinkButton ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" CssClass="btn">Eliminar</asp:LinkButton>
        <asp:LinkButton ID="btnNuevo" runat="server" OnClick="btnNuevo_Click" CssClass="btn">Nuevo</asp:LinkButton>
    </div>
   
    <!--startprint-->
           <h1>Personas registradas</h1>
    <asp:Panel ID="gridPanel" runat="server">
        <asp:GridView ID="dgvPersonas" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" CssClass="tabla">
            <Columns>
                <asp:BoundField HeaderText="ID" DataField="Id" />
                <asp:BoundField HeaderText="Legajo" DataField="Legajo" />
                <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                <asp:BoundField HeaderText="Apellido" DataField="Apellido" />
                <asp:BoundField HeaderText="Dirección" DataField="Direccion" />
                <asp:BoundField HeaderText="Correo electrónico" DataField="Email" />
                <asp:BoundField HeaderText="Fecha de nacimiento" DataField="FechaDeNacimiento" DataFormatString="{0:d}" />
                <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" />
            </Columns>
            <HeaderStyle CssClass="cabecera" />
            <RowStyle CssClass="filas" />
            <SelectedRowStyle BackColor="Black" ForeColor="White" />
        </asp:GridView>
    </asp:Panel>
    
                  <!--endprint-->
</asp:Content>
