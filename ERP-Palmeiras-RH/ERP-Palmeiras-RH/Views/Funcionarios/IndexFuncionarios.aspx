<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<% 
    IEnumerable<ERP_Palmeiras_RH.Models.Funcionario> listaFuncionarios = (IEnumerable<ERP_Palmeiras_RH.Models.Funcionario>) ViewData.Model;  
 %>

<script type="text/javascript">
    $(document).ready(function () {
        $("#funcionariosTable tr:odd").addClass("odd");
        $("#funcionariosTable tr:even").addClass("even");
    });
</script>

<table id="funcionariosTable">
                    <tr>
						<th>Nome</th>
                        <th>Sobrenome</th>
						<th>Cargo</th>
                        <th>CRM</th>
						<th>Ramal</th>
						<th>E-mail</th>
						<th>Telefone</th>
                        <th>Endereço</th>
                        <th>Editar</th>
					</tr>
 
            <% foreach (ERP_Palmeiras_RH.Models.Funcionario f in listaFuncionarios)
               { %>
					<tr>
						<td><%= f.DadosPessoais.Nome %></td>
                        <td><%= f.DadosPessoais.Sobrenome %></td>
						<td><%= f.Cargo %></td>
                        <td><%  String CRM = "";
                                if (f is ERP_Palmeiras_RH.Models.Medico)
                                {
                                    ERP_Palmeiras_RH.Models.Medico m = (ERP_Palmeiras_RH.Models.Medico) f;
                                    CRM = m.CRM;
                                }
                                %>
                                
                                <%= CRM %>
                        </td>
						<td><%= f.Ramal %></td>
						<td><%= f.DadosPessoais.Email %></td>
						<td><%= f.DadosPessoais.Telefones.First<ERP_Palmeiras_RH.Models.Telefone>() %></td>
                        <td><%= f.DadosPessoais.Endereco %></td>
                        <td><a href="<%= Url.Action("Editar", "Funcionarios", f.Id) %>"><img alt="Editar dados" class="editIcon" src="../../Content/images/editIcon.png" /></a></td>
					</tr>
                <% } %>
				</table>

</asp:Content>
