<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<% 
    IEnumerable<ERP_Palmeiras_LA.Models.SolicitacaoCompraEquipamento> solicitacoes = (IEnumerable<ERP_Palmeiras_LA.Models.SolicitacaoCompraEquipamento>)ViewBag.solicitacoes;  
 %>

<script type="text/javascript">
    $(document).ready(function () {
        $("#funcionariosTable tr:odd").addClass("odd");
        $("#funcionariosTable tr:even").addClass("even");
    });
</script>

<h2>Solicitações de Compra</h2>
<table id="funcionariosTable" class="decoratedTable">
                    <tr>
						<th>ID</th>
                        <th>Equipamento</th>
                        <th>Preço</th>
                        <th>Status</th>
                        <th>Data Validade</th>
                        <th>Editar</th>
					</tr>
 
            <% foreach (ERP_Palmeiras_LA.Models.SolicitacaoCompraEquipamento s in solicitacoes)
               {
                   String statusStr = "Pendente";
                   if (s.Status ==  ERP_Palmeiras_LA.Models.StatusSolicitacaoCompra.APROVADO)
                   {
                       statusStr = "Aprovado";
                   }
                   if (s.Status == ERP_Palmeiras_LA.Models.StatusSolicitacaoCompra.REPROVADO)
                   {
                       statusStr = "Reprovado";
                   }
                   %>
					<tr>
                        <td><%= s.Id %></td>
						<td><%= s.Equipamento.Nome %></td>
                        <td><%= s.Preco %></td>
                        <td><%= statusStr%></td>
                        <td><%= new DateTime(s.DataValidade).ToString("dd/MM/yyyy") %></td>
                        <td><a href="<%= Url.Action("Editar", "SolicitacoesCompraEquipamentos", new { id = s.Id }) %>"><img alt="Editar dados" class="icon" src="<%= Url.Content("~/Content/images/editIcon.png") %>" /></a></td>
					</tr>
                <% } %>
				</table>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="SideMenu" runat="server">
    <% Html.RenderPartial("MenuLA"); %>
</asp:Content>
