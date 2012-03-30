    <%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<h2>Pagamentos a Realizar:</h2>

<table id="pagamentoTable" class="decoratedTable">
    <tr>
        <th>Nome</th>
        <th>Cargo</th>
        <th>Salário</th>
        <th>Mês/Ano</th>
        <th>Status</th>
        <th>Pagar</th>
    </tr>
</table>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="SideMenu" runat="server">
    <% Html.RenderPartial("MenuFuncionarios"); %> 
</asp:Content>

