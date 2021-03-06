﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<% 
    IEnumerable<ERP_Palmeiras_LA.Models.SolicitacaoCompraMaterial> solicitacoes = (IEnumerable<ERP_Palmeiras_LA.Models.SolicitacaoCompraMaterial>)ViewBag.solicitacoes;  
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
                        <th>Material</th>
                        <th>Preço Unitário</th>
                        <th>Quantidade</th>
                        <th>Status</th>
                        <th>Data Validade</th>
                        <th>Aprovar</th>
                        <th>Editar</th>
                        <th>Rejeitar</th>
					</tr>
 
            <% foreach (ERP_Palmeiras_LA.Models.SolicitacaoCompraMaterial s in solicitacoes)
               {
                   String statusStr = "Pendente";
                   if (s.Status.EnumValue == ERP_Palmeiras_LA.Models.StatusSolicitacaoCompra.APROVADO)
                   {
                       statusStr = "Aprovado";
                   }
                   if (s.Status.EnumValue == ERP_Palmeiras_LA.Models.StatusSolicitacaoCompra.REPROVADO)
                   {
                       statusStr = "Reprovado";
                   }
                   %>
					<tr>
                        <td><%= s.Id %></td>
						<td><%= s.Material.Nome %></td>
                        <td><%= s.PrecoUnitario %></td>
                        <td><%= s.Quantidade %></td>
                        <td><%= statusStr%></td>
                        <td><%= new DateTime(s.DataValidade).ToString("dd/MM/yyyy") %></td>
                        <td><a href="<%= Url.Action("Aprovar", "SolicitacoesCompraMateriais", new { id = s.Id }) %>"><img alt="Editar dados" class="icon" src="<%= Url.Content("~/Content/images/approveIcon.png") %>" /></a></td>
                        <td><a href="<%= Url.Action("Editar", "SolicitacoesCompraMateriais", new { id = s.Id }) %>"><img alt="Editar dados" class="icon" src="<%= Url.Content("~/Content/images/editIcon.png") %>" /></a></td>
                        <td><a href="<%= Url.Action("Rejeitar", "SolicitacoesCompraMateriais", new { id = s.Id }) %>" ><img alt="Excluir dados" class="icon" src="<%= Url.Content("~/Content/images/deleteIcon.png") %>" /></a></td>
					</tr>
                <% } %>
				</table>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="SideMenu" runat="server">
    <% Html.RenderPartial("MenuLA"); %>
</asp:Content>
