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
        <th>Excluir</th>
    </tr>

    <% foreach (ERP_Palmeiras_LA.Models.Material mat in ViewBag.materiais)
       { %>
        <tr>
            <td><%= mat.Codigo%></td>
            <td><%= mat.Nome%></td>
            <td>
                <select id="fabricantes" name="fabricantes" multiple="multiple">
                    <% foreach (ERP_Palmeiras_LA.Models.Fabricante fab in ViewBag.fabricantes) { %>
                        <option <%= (mat.Fabricante.Where<ERP_Palmeiras_LA.Models.Fabricante>(f => f.Id == fab.Id).Count<ERP_Palmeiras_LA.Models.Fabricante>() > 0)? "SELECTED" : "" %> value="<%= fab.Id %>">
                        <%= fab.Nome %></option>
                    <% } %>
                </select>
            </td>
            <td><a href="<%= Url.Action("Excluir", "Materiais", new {eid = mat.Id}) %>" ><img alt="Excluir material" class="icon" src="<%= Url.Content("~/Content/images/deleteIcon.png") %>" /></a></td>
        </tr>
    <%  } %>

</table>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="SideMenu" runat="server">
    <% Html.RenderPartial("MenuLA"); %>
</asp:Content>
