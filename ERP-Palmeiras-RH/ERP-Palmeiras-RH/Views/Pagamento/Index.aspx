    <%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<h2>Pagamentos a Realizar:</h2>

<table id="pagamentoTable" class="decoratedTable">
    <tr>
        <th>Nome</th>
        <th>Cargo</th>
        <th>Salário</th>
        <th>Mês/Ano</th>
        <th>Status</th>
        <th>Solicitar</th>
        <th>Holerite</th>
    </tr>

    <% foreach (ERP_Palmeiras_RH.Models.Pagamento pagamento in ViewBag.pagamentos)
       { %>
       <% DateTime dataOrdem = new DateTime(pagamento.DataOrdem); %>
        <tr>
            <td><%= pagamento.Funcionario.DadosPessoais.Nome %></td>
            <td><%= pagamento.Cargo %></td>
            <td><%= pagamento.Salario %></td>
            <td><%= dataOrdem.Month.ToString() +"/"+ dataOrdem.Year.ToString() %></td>
            <td>
            <% if (pagamento.Status == ERP_Palmeiras_RH.Models.Facade.RecursosHumanos.PAGAMENTO_OK)
               { %>
                <img alt="confirmado" src="<%= Url.Content("~/Content/images/status_ok.png") %>" title="Efetuado" />
            <% }
               else if (pagamento.Status == ERP_Palmeiras_RH.Models.Facade.RecursosHumanos.PAGAMENTO_PENDENTE)
               {%>
                <img alt="pendente" src="<%= Url.Content("~/Content/images/status_forbidden.png") %>" title="Pendente" />
            <% }
               else if (pagamento.Status == ERP_Palmeiras_RH.Models.Facade.RecursosHumanos.PAGAMENTO_EM_AVALIACAO)
               {%>
                <img alt="em análise" src="<%= Url.Content("~/Content/images/status_help.png") %>" title="Em Análise" />
            <% } %>
            </td>
            <td>
            <% if (pagamento.Status == ERP_Palmeiras_RH.Models.Facade.RecursosHumanos.PAGAMENTO_PENDENTE)
               { %>
                <a href="javascript: confirmarPagamento(<%= pagamento.Id %>)" ><img alt="Pagar" src="<%= Url.Content("~/Content/images/pay_check.png") %>" title="Pagar" /></a>
            <% } %>
            </td>
            <td>
            <% if (pagamento.Status == ERP_Palmeiras_RH.Models.Facade.RecursosHumanos.PAGAMENTO_OK)
               { %>
                <a href="javascript:holerite(<%= pagamento.Id %>)"><img src="<%: Url.Content("~/Content/images/print_ico.gif") %>" alt="imprimir" /></a>
            <% } %>
            </td>
        </tr>
    <%  } %>

</table>

<script type="text/javascript">
    function confirmarPagamento(pagId) {
        $.ajax({
            type: "POST",
            url: 'Pagamento/Confirmar',
            data: { pag: pagId },
            success: function (data) {
                $.colorbox({
                    html: data,
                    onComplete: function () {
                        /*                        
                        $("#salario").maskMoney({ symbol: 'R$ ', showSymbol: true, thousands: '.', decimal: ',', symbolStay: true });
                        $("#salario").mask();
                        $("#acrescimo").maskMoney({ symbol: 'R$ ', showSymbol: true, thousands: '.', decimal: ',', symbolStay: true });
                        $("#acrescimo").mask();
                        $("#desconto").maskMoney({ symbol: 'R$ ', showSymbol: true, thousands: '.', decimal: ',', symbolStay: true });
                        $("#desconto").mask();
                        $("#imposto").maskMoney({ symbol: 'R$ ', showSymbol: true, thousands: '.', decimal: ',', symbolStay: true });
                        $("#imposto").mask();
                        $("#total").maskMoney({ symbol: 'R$ ', showSymbol: true, thousands: '.', decimal: ',', symbolStay: true });
                        $("#total").mask();
                        */
                        $("#datapag").mask("99/99/9999");
                    }
                });
            },
            error: function () {
                alert("Ocorreu um erro na Confirmação do Pagamento");
            }
        });
    }

    function holerite(pagId) {
        $.ajax({
            type: "POST",
            url: 'Pagamento/Holerite',
            data: { pag: pagId },
            success: function (data) {
                $.colorbox({ html: data });
            },
            error: function () {
                alert("Ocorreu um erro na geração do holerite.");
            }
        });        
    }
</script>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="SideMenu" runat="server">
    <% Html.RenderPartial("MenuFuncionarios"); %> 
</asp:Content>

