<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<% 
    IEnumerable<ERP_Palmeiras_LA.Models.MaterialClinica> materiais = (IEnumerable<ERP_Palmeiras_LA.Models.MaterialClinica>)ViewBag.materiais;  
 %>

<script type="text/javascript">
    $(document).ready(function () {
        $("#funcionariosTable tr:odd").addClass("odd");
        $("#funcionariosTable tr:even").addClass("even");
    });
</script>

<h2>Compras em Andamento</h2>
<table id="funcionariosTable" class="decoratedTable">
                    <tr>
						<th>ID</th>
                        <th>Material</th>
                        <th>Excluir</th>
					</tr>
 
            <% foreach (ERP_Palmeiras_LA.Models.MaterialClinica e in materiais)
               {
                   %>
					<tr>
                        <td><%= e.Id %></td>
                        <td><%= e.Material.Nome %></td>
                        <td><a href="<%= Url.Action("Excluir", "MateriaisClinica", new { id = e.Id }) %>"><img alt="Excluir" class="icon" src="<%= Url.Content("~/Content/images/deleteIcon.png") %>" /></a></td>
					</tr>
                <% } %>
				</table>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="SideMenu" runat="server">
    <% Html.RenderPartial("MenuLA"); %>
</asp:Content>
