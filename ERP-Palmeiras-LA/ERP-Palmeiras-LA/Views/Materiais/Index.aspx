<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<%
    IEnumerable<ERP_Palmeiras_LA.Models.Fabricante> fabricantes = (IEnumerable<ERP_Palmeiras_LA.Models.Fabricante>)ViewBag[;
    IEnumerable<ERP_Palmeiras_LA.Models.Beneficio> beneficios = (IEnumerable<ERP_Palmeiras_RH.Models.Beneficio>)ViewData["Beneficios"];
    IEnumerable<ERP_Palmeiras_RH.Models.Especialidade> especialidades = (IEnumerable<ERP_Palmeiras_RH.Models.Especialidade>)ViewData["Especialidades"];
    IEnumerable<ERP_Palmeiras_RH.Models.Permissao> permissoes = (IEnumerable<ERP_Palmeiras_RH.Models.Permissao>)ViewData["Permissoes"];
    int id = (int)ViewData["Id"];
    ERP_Palmeiras_RH.Models.Funcionario func = (ERP_Palmeiras_RH.Models.Funcionario)ViewData.Model;
%>

<script type="text/javascript">
    $(document).ready(function () {
        $("#tabelamatialidades tr:odd").addClass("odd");
        $("#tabelamatialidades tr:even").addClass("even");
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
                    <% foreach (ERP_Palmeiras_LA.Models.Fabricante fab in ViewBag.materiais)
                        { %>
                    <option <%= (m.Fabricantes.Where<ERP_Palmeiras_LA.Models.Fabricante>(ben => ben.Id == f.Id).Count<ERP_Palmeiras_RH.Models.Beneficio>() > 0)? "SELECTED" : "" %> value="<%= b.Id %>">
                        <%= b.Nome %></option>
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
