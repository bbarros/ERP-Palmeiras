<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<% 
    IEnumerable<ERP_Palmeiras_LA.Models.Fabricante> fabricantes = (IEnumerable<ERP_Palmeiras_LA.Models.Fabricante>)ViewBag.fabricantes;  
 %>

<script type="text/javascript">
    $(document).ready(function () {
        $("#funcionariosTable tr:odd").addClass("odd");
        $("#funcionariosTable tr:even").addClass("even");
    });
</script>

<h2>Fabricantes</h2>
<table id="funcionariosTable" class="decoratedTable">
                    <tr>
						<th>Nome</th>
                        <th>CNPJ</th>
                        <th>Editar</th>
					</tr>
 
            <% foreach (ERP_Palmeiras_LA.Models.Fabricante f in fabricantes)
               { %>
					<tr>
						<td><%= f.Nome %></td>
                        <td><%= f.CNPJ %></td>
                        <td><a href="<%= Url.Action("Editar", "Fabricantes", new { id = f.Id }) %>"><img alt="Editar dados" class="icon" src="<%= Url.Content("~/Content/images/editIcon.png") %>" /></a></td>
					</tr>
                <% } %>
				</table>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="SideMenu" runat="server">
    <% Html.RenderPartial("MenuLA"); %>
</asp:Content>
