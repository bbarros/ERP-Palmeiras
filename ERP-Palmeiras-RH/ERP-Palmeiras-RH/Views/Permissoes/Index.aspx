<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<h2>Permissoes</h2>

<table id="tabelaPermissoes">
    <tr>
        <th>ID</th>
        <th>Nome</th>
    </tr>

    <% foreach (ERP_Palmeiras_RH.Models.Permissao permissao in ViewBag.permissoes)
       { %>
        <tr>
            <td><%= permissao.Id%></td>
            <td><%= permissao.Nome%></td>
            <td><a href="<%= Url.Action("ExcluirPermissao", "Funcionarios", new {pid = permissao.Id}) %>" >excluir</a></td>
        </tr>
    <%  } %>

</table>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="SideMenu" runat="server">
    <% Html.RenderPartial("MenuFuncionarios"); %>
</asp:Content>
