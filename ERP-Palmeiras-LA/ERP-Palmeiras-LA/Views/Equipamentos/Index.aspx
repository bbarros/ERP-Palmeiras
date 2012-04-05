<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<% 
    IEnumerable<ERP_Palmeiras_LA.Models.Equipamento> equipamentos = (IEnumerable<ERP_Palmeiras_LA.Models.Equipamento>)ViewBag.equipamentos;  
 %>

<script type="text/javascript">
    $(document).ready(function () {
        $("#funcionariosTable tr:odd").addClass("odd");
        $("#funcionariosTable tr:even").addClass("even");
    });
</script>

<h2>Equipamentos</h2>
<table id="funcionariosTable" class="decoratedTable">
                    <tr>
						<th>Nome</th>
                        <th>Número de Série</th>
                        <th>Fabricante</th>
                        <th>Editar</th>
					</tr>
 
            <% foreach (ERP_Palmeiras_LA.Models.Equipamento eq in equipamentos)
               { %>
					<tr>
						<td><%= eq.Nome %></td>
                        <td><%= eq.NumeroSerie %></td>
                        <td><%= eq.Fabricante.Nome %></td>
                        <td><a href="<%= Url.Action("Editar", "Equipamentos", new { id = eq.Id }) %>"><img alt="Editar dados" class="icon" src="<%= Url.Content("~/Content/images/editIcon.png") %>" /></a></td>
					</tr>
                <% } %>
				</table>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="SideMenu" runat="server">
    <% Html.RenderPartial("MenuLA"); %>
</asp:Content>
