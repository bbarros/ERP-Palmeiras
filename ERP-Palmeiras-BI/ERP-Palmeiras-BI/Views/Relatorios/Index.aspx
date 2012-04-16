<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<% 
    IEnumerable<ERP_Palmeiras_BI.Models.Relatorio> relatorios = (IEnumerable<ERP_Palmeiras_BI.Models.Relatorio>)ViewBag.relatorios;  
 %>

<script type="text/javascript">
    $(document).ready(function () {
        $("#funcionariosTable tr:odd").addClass("odd");
        $("#funcionariosTable tr:even").addClass("even");
    });
</script>

<h2>Usuários</h2>
<table id="funcionariosTable" class="decoratedTable">
                    <tr>
						<th>ID</th>
                        <th>Título</th>
                        <th>Data de Modificação</th>
                        <th>Último Autor</th>
                        <th>Visualizar</th>
                        <th>Editar</th>
					</tr>
 
            <% foreach (ERP_Palmeiras_BI.Models.Relatorio r in relatorios)
               { %>
					<tr>
						<td><%= r.Id %></td>
                        <td><%= r.Titulo %></td>
                        <td><%= new DateTime(r.DataModificacao).ToString("dd/MM/yyyy") %></td>
                        <td><%= r.Usuario.Login %></td>
                        <td><a href="<%= Url.Action("Visualizar", "Relatorios", new { id = r.Id }) %>"><img alt="Editar dados" class="icon" src="<%= Url.Content("~/Content/images/previewIcon.png") %>" /></a></td>
                        <td><a href="<%= Url.Action("Editar", "Relatorios", new { id = r.Id }) %>"><img alt="Editar dados" class="icon" src="<%= Url.Content("~/Content/images/editIcon.png") %>" /></a></td>
					</tr>
                <% } %>
				</table>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="SideMenu" runat="server">
    <% Html.RenderPartial("MenuBI"); %>
</asp:Content>
