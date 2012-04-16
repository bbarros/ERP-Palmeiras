<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<% 
    IEnumerable<ERP_Palmeiras_LA.Models.SolicitacaoManutencao> solicitacoes = (IEnumerable<ERP_Palmeiras_LA.Models.SolicitacaoManutencao>)ViewBag.solicitacoes;  
    
 %>

<script type="text/javascript">
    $(document).ready(function () {
        $("#solicitacoesTable tr:odd").addClass("odd");
        $("#solicitacoesTable tr:even").addClass("even");
    });
</script>

<table id="solicitacoesTable" class="decoratedTable">
                    <tr>
						<th>ID</th>
                        <th>Equipamento</th>
                        <th>Motivo</th>
                        <th>Status</th>
                        <th>Data Prevista</th>
                        <th>Refazer Pedido</th>
                        <th>Editar</th>
					</tr>
 
            <% foreach (ERP_Palmeiras_LA.Models.SolicitacaoManutencao eq in solicitacoes)
               { %>
					<tr>
						<td><%= eq.Id%></td>
                        <td><%= eq.EquipamentoClinica.Equipamento.Nome %></td>
                        <td><%= eq.Motivo %></td>
                        <td><%= eq.Status.EnumValue %></td>
                        <% String data = new DateTime(eq.DataPrevista).ToString("dd/MM/yyyy"); %>
                        <td><%= data %></td>
                        <td><a href="<%= Url.Action("RefazerPedido", "Equipamentos", new { id = eq.Id }) %>"><img alt="Editar dados" class="icon" src="<%= Url.Content("~/Content/images/warningIcon.png") %>" /></a></td>
                        <td><a href="<%= Url.Action("EditarManutencao", "Equipamentos", new { id = eq.Id }) %>"><img alt="Editar dados" class="icon" src="<%= Url.Content("~/Content/images/editIcon.png") %>" /></a></td>
					</tr>
                <% } %>
				</table>


</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="SideMenu" runat="server">
  <% Html.RenderPartial("MenuLA"); %>
</asp:Content>
