﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<script type="text/javascript">
    $(document).ready(function () {
        $("#tabelaPermissoes tr:odd").addClass("odd");
        $("#tabelaPermissoes tr:even").addClass("even");
    });
</script>
<h2>Permissoes</h2>

<table id="tabelaPermissoes" class="decoratedTable">
    <tr>
        <th>ID</th>
        <th>Nome</th>
        <th>Excluir</th>
    </tr>

    <% foreach (ERP_Palmeiras_RH.Models.Permissao permissao in ViewBag.permissoes)
       { %>
        <tr>
            <td><%= permissao.Id%></td>
            <td><%= permissao.Nome%></td>
            <td><a href="<%= Url.Action("Excluir", "Permissoes", new {pid = permissao.Id}) %>" ><img alt="Excluir permissão" class="icon" src="<%= Url.Content("~/Content/images/deleteIcon.png") %>" /></a></td>
        </tr>
    <%  } %>

</table>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="SideMenu" runat="server">
    <% Html.RenderPartial("MenuFuncionarios"); %>
</asp:Content>
