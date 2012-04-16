<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Modal.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Holerite
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<% ERP_Palmeiras_RH.Models.Pagamento pagamento = ViewBag.pagamento; %>
<div id="main-holerite">
    <div id="main-holerite-sup">
        <div>
            <div style="float:left; padding-left: 20px; padding-top: 25px;">
                <div id="h-empresa" class="h-field">Clínica Politécnica</div>
                <div id="h-cnpj" class="h-field">CNPJ da Empresa</div>
            </div>
            <% DateTime datapag = new DateTime(pagamento.DataPagamento); %>
            <div id="h-mes" class="h-field" style="float:left; padding-left:300px; padding-top: 40px;"><%= datapag.Month.ToString() + "/" + datapag.Year.ToString() %></div>
        </div>

        <div style="clear:left; padding-top: 20px;">
            <div id="h-funcionario" class="h-field" style="float: left; padding-left:70px;"><%= pagamento.Funcionario.DadosPessoais.Nome %></div>
            <div id="h-cargo" class="h-field" style="float: right; padding-right:140px;"><%= pagamento.Cargo %></div>
        </div>

        <div style="clear:left; padding-top: 30px;">
            <div id="h-salario-lbl" class="h-field" style="float: left; padding-left:60px;">Salário</div>
            <div id="h-salario-ref" class="h-field" style="float: left; padding-left:230px;">30d</div>
            <div id="Div1" class="h-field" style="float: right; padding-right:222px;"><%= "R$ " + pagamento.Salario.ToString() + ",00"%></div>
        </div>

        <div style="clear:left;">
            <div id="Div2" class="h-field" style="float: left; padding-left:60px;">Adicionais</div>
            <div id="Div4" class="h-field" style="float: right; padding-right:222px;"><%= "R$ " + pagamento.Adicionais.ToString() + ",00"%></div>
        </div>

        <div style="clear:left;">
            <div id="Div3" class="h-field" style="float: left; padding-left:60px;">Descontos</div>
            <div id="Div5" class="h-field" style="float: right; padding-right:120px;"><%= "R$ " + pagamento.Descontos.ToString() + ",00"%></div>
        </div>

        <div style="clear:left;">
            <div id="Div6" class="h-field" style="float: left; padding-left:60px;">Impostos</div>
            <div id="Div7" class="h-field" style="float: right; padding-right:120px;"><%= "R$ " + pagamento.Impostos.ToString() + ",00"%></div>
        </div>

        <div style="clear:left; padding-top:222px">
            <div id="Div9" class="h-field" style="float: right; padding-right:120px;"><%= "R$ " + (pagamento.Descontos * 1 + pagamento.Impostos * 1).ToString() + ",00"%></div>
            <div id="Div8" class="h-field" style="float: left; padding-left:400px;"><%= "R$ " + (pagamento.Salario * 1 + pagamento.Adicionais * 1).ToString() + ",00"%></div>
        </div>

        <div style="clear:left; padding-top:10px">
            <div id="Div10" class="h-field" style="float: right; padding-right:120px;"><%= "R$ " + pagamento.Total.ToString() + ",00"%></div>
        </div>

        <div style="clear:left; padding-top: 40px;">
            <div id="Div11" class="h-field" style="float: left; padding-left:20px;"><%= "R$ " + pagamento.Salario.ToString() + ",00"%></div>
            <div id="Div12" class="h-field" style="float: left; padding-left:60px;"><%= "R$ " + pagamento.Salario.ToString() + ",00"%></div>
            <div id="Div13" class="h-field" style="float: right; padding-right:400px;"><%= "R$ " + pagamento.Salario.ToString() + ",00"%></div>
        </div>
    </div>

    <div id="main-holerite-inf">
        <div>
            <div style="float:left; padding-left: 20px; padding-top: 90px;">
                <div id="Div14" class="h-field">Clínica Politécnica</div>
                <div id="Div15" class="h-field">CNPJ da Empresa</div>
            </div>
            <div id="Div16" class="h-field" style="float:left; padding-left:300px; padding-top: 105px;"><%= datapag.Month.ToString() + "/" + datapag.Year.ToString() %></div>
        </div>

        <div style="clear:left; padding-top: 20px;">
            <div id="Div17" class="h-field" style="float: left; padding-left:70px;"><%= pagamento.Funcionario.DadosPessoais.Nome %></div>
            <div id="Div18" class="h-field" style="float: right; padding-right:140px;"><%= pagamento.Cargo %></div>
        </div>

        <div style="clear:left; padding-top: 35px;">
            <div id="Div19" class="h-field" style="float: left; padding-left:60px;">Salário</div>
            <div id="Div20" class="h-field" style="float: left; padding-left:230px;">30d</div>
            <div id="Div21" class="h-field" style="float: right; padding-right:222px;"><%= "R$ " + pagamento.Salario.ToString() + ",00"%></div>
        </div>

        <div style="clear:left;">
            <div id="Div22" class="h-field" style="float: left; padding-left:60px;">Adicionais</div>
            <div id="Div23" class="h-field" style="float: right; padding-right:222px;"><%= "R$ " + pagamento.Adicionais.ToString() + ",00"%></div>
        </div>

        <div style="clear:left;">
            <div id="Div24" class="h-field" style="float: left; padding-left:60px;">Descontos</div>
            <div id="Div25" class="h-field" style="float: right; padding-right:120px;"><%= "R$ " + pagamento.Descontos.ToString() + ",00"%></div>
        </div>

        <div style="clear:left;">
            <div id="Div26" class="h-field" style="float: left; padding-left:60px;">Impostos</div>
            <div id="Div27" class="h-field" style="float: right; padding-right:120px;"><%= "R$ " + pagamento.Impostos.ToString() + ",00"%></div>
        </div>

        <div style="clear:left; padding-top:265px">
            <div id="Div28" class="h-field" style="float: right; padding-right:120px;"><%= "R$ " + (pagamento.Descontos * 1 + pagamento.Impostos * 1).ToString() + ",00"%></div>
            <div id="Div29" class="h-field" style="float: left; padding-left:400px;"><%= "R$ " + (pagamento.Salario * 1 + pagamento.Adicionais * 1).ToString() + ",00"%></div>
        </div>

        <div style="clear:left; padding-top:10px">
            <div id="Div30" class="h-field" style="float: right; padding-right:120px;"><%= "R$ " + pagamento.Total.ToString() + ",00"%></div>
        </div>

        <div style="clear:left; padding-top: 45px;">
            <div id="Div31" class="h-field" style="float: left; padding-left:20px;"><%= "R$ " + pagamento.Salario.ToString() + ",00"%></div>
            <div id="Div32" class="h-field" style="float: left; padding-left:60px;"><%= "R$ " + pagamento.Salario.ToString() + ",00"%></div>
            <div id="Div33" class="h-field" style="float: right; padding-right:400px;"><%= "R$ " + pagamento.Salario.ToString() + ",00"%></div>
        </div>
    </div>
</div>

<button onclick="javascript:printHolerite();">Imprimir</button>

<script type="text/javascript">
    function printHolerite() {
        $("#main-holerite").printElement();
    }

</script>


</asp:Content>
