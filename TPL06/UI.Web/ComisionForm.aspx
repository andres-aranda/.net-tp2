<%@  Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ComisionForm.aspx.cs" Inherits="Academia.UI.Web.ComisionForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContent" runat="server">
    <table style="width:100%;">
        <tr>
            <td >
                Descripción</td>
            <td >
                <asp:TextBox ID="descComtxt" runat="server"></asp:TextBox>
            </td>
            <td >
                Año Especialidad</td>
            <td >
                <asp:TextBox ID="añoEspeTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr >
            <td class="auto-style1" >
                IdPlan</td>
            <td class="auto-style1" >
                <asp:TextBox ID="idPlanTextBox" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style1" >
                &nbsp;</td>
            <td class="auto-style1" >
                &nbsp;</td>
        </tr>
        </table>

      <div style="margin-bottom: 15px;">
<asp:LinkButton ID="editarLinkButton" runat="server" OnClick="AceptarLinkButton_Click" ForeColor="Black" style="
    border-radius: 20px;
    font-size: 1.25rem !important;
    background: #36304a !important;
    color: white !important;
    margin: 5px  !important;
    padding: .3rem .5rem .3rem .5rem !important;">
            Aceptar
        </asp:LinkButton>
        <asp:LinkButton ID="EliminarLinkButton" runat="server" OnClick="CancelarLinkButton_Click" style="
border-radius: 10px;
font-size: 1.25rem !important;
background: #36304a !important;
color: white !important;
margin: 5px  !important;
padding: .3rem .5rem .3rem .5rem !important;">
            Cancelar</asp:LinkButton>

        </div>
</asp:Content>
