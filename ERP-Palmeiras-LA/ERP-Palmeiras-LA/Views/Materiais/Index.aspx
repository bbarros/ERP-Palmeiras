<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<script type="text/javascript">
    $(document).ready(function () {
        $("#tabelaMateriais tr:odd").addClass("odd");
        $("#tabelaMateriais tr:even").addClass("even");
    });
</script>

<h2>Materiais Cadastrados</h2>

<table id="tabelaMateriais" class="decoratedTable">
    <tr>
        <th>Codigo</th>
        <th>Nome</th>
        <th>Fabricante</th>
        <th>Descrição</th>
        <th>Editar</th>
    </tr>

    <% foreach (ERP_Palmeiras_LA.Models.Material mat in ViewBag.materiais)
       { %>
        <tr>
            <td><%= mat.Codigo%></td>
            <td><%= mat.Nome%></td>
            <td><%= mat.Fabricante.Nome %></td>
            <td><%= mat.Descricao %></td>
            <td><a href="<%= Url.Action("Editar", "Materiais", new {materialID = mat.Id}) %>" ><img alt="Editar material" class="icon" src="<%= Url.Content("~/Content/images/editIcon.png") %>" /></a>
        </tr>
    <%  } %>

</table>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="SideMenu" runat="server">
    <% Html.RenderPartial("MenuLA"); %>
</asp:Content>
