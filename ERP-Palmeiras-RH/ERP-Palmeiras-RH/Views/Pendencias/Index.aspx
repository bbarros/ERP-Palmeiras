<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<script type="text/javascript">
    $(document).ready(function () {
        $("#tabelaBeneficios tr:odd").addClass("odd");
        $("#tabelaBeneficios tr:even").addClass("even");
    });
</script>
<h2>Cadastros Pendentes</h2>

<table id="tabelaBeneficios" class="decoratedTable">
    <tr>
        <th>Funcionário</th>
        <th>Login</th>
        <th>Excluir</th>
    </tr>

    <% foreach (ERP_Palmeiras_RH.Models.Pendencia pendencia in ViewBag.pendencias)
       { %>
        <tr>
            <td><a href="<%= Url.Action("Editar", "Funcionarios", new { id = pendencia.Funcionario.Id }) %>"><%= pendencia.Funcionario.Id%></a></td>
            <td><%= pendencia.Funcionario.Credencial.Usuario%></td>
            <td><a href="<%= Url.Action("Excluir", "Pendencias", new {pid = pendencia.Id}) %>" ><img alt="Excluir Pendência" class="icon" src="<%= Url.Content("~/Content/images/deleteIcon.png") %>" /></a></td>
        </tr>
    <%  } %>

</table>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="SideMenu" runat="server">
    <% Html.RenderPartial("MenuFuncionarios"); %>
</asp:Content>
