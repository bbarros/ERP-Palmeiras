<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<% 
    IEnumerable<ERP_Palmeiras_LA.Models.EquipamentoClinica> equipamentos = (IEnumerable<ERP_Palmeiras_LA.Models.EquipamentoClinica>)ViewBag.equipamentos;  
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
                        <th>Equipamento</th>
                        <th>Status</th>
                        <th>Registrar Defeito</th>
                        <th>Excluir</th>
					</tr>
 
            <% foreach (ERP_Palmeiras_LA.Models.EquipamentoClinica e in equipamentos)
               {
                   String statusStr = "Funcionando";
                   if (e.Status.EnumValue == ERP_Palmeiras_LA.Models.StatusEquipamento.QUEBRADO)
                   {
                       statusStr = "Quebrado";
                   }
                   %>
					<tr>
                        <td><%= e.Id %></td>
						<td><%= statusStr %></td>
                        <td><%= e.Equipamento.Nome %></td>
                        <td><a href="<%= Url.Action("RegistrarDefeito", "EquipamentosClinica", new { id = e.Id }) %>"><img alt="Editar dados" class="icon" src="<%= Url.Content("~/Content/images/warningIcon.png") %>" /></a></td>
                        <td><a href="<%= Url.Action("Excluir", "EquipamentosClinica", new { id = e.Id }) %>"><img alt="Excluir" class="icon" src="<%= Url.Content("~/Content/images/deleteIcon.png") %>" /></a></td>
					</tr>
                <% } %>
				</table>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="SideMenu" runat="server">
    <% Html.RenderPartial("MenuLA"); %>
</asp:Content>
