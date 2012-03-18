<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<script type="text/javascript">
    $(document).ready(function () {
        $("#tabelaBeneficios tr:odd").addClass("odd");
        $("#tabelaBeneficios tr:even").addClass("even");
    });
</script>
<h2>Beneficios</h2>

<table id="tabelaBeneficios" class="decoratedTable">
    <tr>
        <th>ID</th>
        <th>Nome</th>
        <th>Valor</th>
        <th>Excluir</th>
    </tr>

    <% foreach (ERP_Palmeiras_RH.Models.Beneficio beneficio in ViewBag.beneficios)
       { %>
        <tr>
            <td><%= beneficio.Id%></td>
            <td><%= beneficio.Nome%></td>
            <td><%= beneficio.Valor %></td>
            <td><a href="<%= Url.Action("ExcluirBeneficio", "Beneficios", new {bid = beneficio.Id}) %>" ><img alt="Excluir benefício" class="icon" src="<%= Url.Content("~/Content/images/deleteIcon.png") %>" /></a></td>
        </tr>
    <%  } %>

</table>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="SideMenu" runat="server">
    <% Html.RenderPartial("MenuFuncionarios"); %>
</asp:Content>
