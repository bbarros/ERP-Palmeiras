<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<% 
    IEnumerable<ERP_Palmeiras_LA.Models.CompraMaterial> compras = (IEnumerable<ERP_Palmeiras_LA.Models.CompraMaterial>)ViewBag.compras;  
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
                        <th>Data Prevista</th>
                        <th>Data Entrega</th>
                        <th>Material</th>
                        <th>Quantidade</th>
                        <th>Status</th>
                        <th>Registrar Entrega</th>
                        <th>Editar</th>
					</tr>
 
            <% foreach (ERP_Palmeiras_LA.Models.CompraMaterial c in compras)
               {
                   String statusStr = "Compra Solicitada";
                   if (c.Status.EnumValue == ERP_Palmeiras_LA.Models.StatusCompra.ENTREGUE)
                   {
                       statusStr = "Entregue";
                   }
                   %>
					<tr>
                        <td><%= c.Id %></td>
						<td><%= new DateTime(c.DataPrevista).ToString("dd/MM/yyyy") %></td>
                        <td><%= (c.DataEntrega != null && c.DataEntrega != 0)? new DateTime((long)c.DataEntrega).ToString("dd/MM/yyyy") : "" %></td>
                        <td><%= c.SolicitacaoCompraMaterial.Material.Nome %></td>
                        <td><%= c.SolicitacaoCompraMaterial.Quantidade %></td>
                        <td><%= statusStr %></td>
                        <td><a href="<%= Url.Action("RegistrarEntrega", "CompraMateriais", new { id = c.Id }) %>"><img alt="Editar dados" class="icon" src="<%= Url.Content("~/Content/images/approveIcon.png") %>" /></a></td>
                        <td><a href="<%= Url.Action("Editar", "CompraMateriais", new { id = c.Id }) %>"><img alt="Editar dados" class="icon" src="<%= Url.Content("~/Content/images/editIcon.png") %>" /></a></td>
					</tr>
                <% } %>
				</table>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="SideMenu" runat="server">
    <% Html.RenderPartial("MenuLA"); %>
</asp:Content>
