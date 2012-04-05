<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<% 
    IEnumerable<ERP_Palmeiras_LA.Models.Usuario> usuarios = (IEnumerable<ERP_Palmeiras_LA.Models.Usuario>)ViewBag.usuarios;  
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
						<th>Login</th>
                        <th>Editar</th>
					</tr>
 
            <% foreach (ERP_Palmeiras_LA.Models.Usuario u in usuarios)
               { %>
					<tr>
						<td><%= u.Login %></td>
                        <td><a href="<%= Url.Action("Editar", "Usuarios", new { id = u.Id }) %>"><img alt="Editar dados" class="icon" src="<%= Url.Content("~/Content/images/editIcon.png") %>" /></a></td>
					</tr>
                <% } %>
				</table>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="SideMenu" runat="server">
    <% Html.RenderPartial("MenuLA"); %>
</asp:Content>
