<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<h2>Benefícios Cadastrados</h2>

<table id="tabelaEspecialidade" class="decoratedTable">
    <tr>
        <th>ID</th>
        <th>Nome</th>
        <th>Excluir</th>
    </tr>

    <% foreach (ERP_Palmeiras_RH.Models.Especialidade espec in ViewBag.especialidades)
       { %>
        <tr>
            <td><%= espec.Id%></td>
            <td><%= espec.Nome%></td>
            <td><a href="<%= Url.Action("Excluir", "Especialidades", new {eid = espec.Id}) %>" >excluir</a></td>
        </tr>
    <%  } %>

</table>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="SideMenu" runat="server">
    <% Html.RenderPartial("MenuFuncionarios"); %>
</asp:Content>
