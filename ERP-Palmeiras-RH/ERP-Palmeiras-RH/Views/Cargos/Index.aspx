<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<script type="text/javascript">
    $(document).ready(function () {
        $("#tabelaCargos tr:odd").addClass("odd");
        $("#tabelaCargos tr:even").addClass("even");
    });
</script>
<h2>Cargos</h2>

<table id="tabelaCargos" class="decoratedTable">
    <tr>
        <th>ID</th>
        <th>Nome</th>
        <th>Salário Base</th>
        <th>Excluir</th>
    </tr>

    <% foreach (ERP_Palmeiras_RH.Models.Cargo Cargo in ViewBag.Cargos)
       { %>
        <tr>
            <td><%= Cargo.Id%></td>
            <td><%= Cargo.Nome%></td>
            <td><%= Cargo.SalarioBase %></td>
            <td><a href="<%= Url.Action("ExcluirCargo", "Cargos", new {cid = Cargo.Id}) %>" ><img alt="Excluir cargo" class="icon" src="<%= Url.Content("~/Content/images/deleteIcon.png") %>" /></a></td>
        </tr>
    <%  } %>

</table>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="SideMenu" runat="server">
    <% Html.RenderPartial("MenuFuncionarios"); %>
</asp:Content>
