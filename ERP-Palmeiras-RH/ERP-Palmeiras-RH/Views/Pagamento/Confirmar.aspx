<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Modal.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Autorização do Pagametno
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<div id="modal-pag">
    <% ERP_Palmeiras_RH.Models.Pagamento pag = ViewBag.pagamento; %>
    
    <h1>Autorização do Pagamento</h1>
    </br>

    <table>
        <tr>
            <td>Colaborador:</td>
            <td><%= pag.Funcionario.DadosPessoais.Nome %></td>
        </tr>
        <tr>
            <td>Cargo:</td>
            <td><%= pag.Cargo %></td>
        </tr>
        <tr>
            <td>Salário:</td>
            <td><input id="salario" type="text" disabled="true" value="<%= pag.Salario %>"/></td>
        </tr>
        <tr>
            <td>Acréscimos:</td>
            <td><input id="acrescimo" type="text" value="<%= pag.Adicionais %>"/></td>
        </tr>
        <tr>
            <td>Descontos:</td>
            <td><input id="desconto" type="text" value="<%= pag.Descontos %>" /></td>
        </tr>
        <tr>
            <td>Impostos:</td>
            <td><input id="imposto" type="text" value="<%= pag.Impostos %>" /></td>
        </tr>
        <tr>
            <td>TOTAL:</td>
            <td><input id="total" type="text" disabled="true" value="<%= pag.Total %>"/></td>
            <td><button id="btn-calcular" onclick="javascript:calcularTotal();" >Calcular</button></td>
        </tr>
        <tr>
            <td>Banco:</td>
            <td><%= pag.Funcionario.DadosBancarios.Banco %></td>
        </tr>
        <tr>
            <td>Agência:</td>
            <td><%= pag.Funcionario.DadosBancarios.Agencia %></td>
        </tr>
        <tr>
            <td>Conta:</td>
            <td><%= pag.Funcionario.DadosBancarios.ContaCorrente %></td>
        </tr>
        <tr>
            <td colspan="3">Informações Adicionais:</td>
        </tr>
        <tr>
            <td colspan="3"><textarea id="infoad" cols="50" rows="3"><%= pag.Informacoes %></textarea></td>        
        </tr>
        <tr>
            <td><button id="btn-cancelar" onclick="javascript:cancelar();">Cancelar</button></td>
            <td><button id="btn-salvar" onclick="javascript:salvar(<%= pag.Id %>);">Salvar</button></td>
            <td><button id="btn-confirmar" onclick="javascript:enviar(<%= pag.Id %>);">Confirmar</button></td>
        </tr>
    </table>

</div>

<script type="text/javascript">
    function calcularTotal() {
        var total = $("#salario").val()*1 + $("#acrescimo").val()*1 - $("#desconto").val()*1 - $("#imposto").val()*1;
        $("#total").val(total);
    }
    
    function cancelar() {
        $.colorbox.close();
    }

    function salvar(pag) {
        var acrescimo = $("#acrescimo").val();
        var desconto = $("#desconto").val();
        var imposto = $("#imposto").val();
        var total = $("#total").val();
        var info = $("#infoad").val();

        $.ajax({
            type: "POST",
            url: 'Pagamento/Salvar',
            data: { 
                pag: pag,
                acrescimo: acrescimo,
                desconto: desconto,
                imposto: imposto,
                total: total,
                info: info
            },
            success: function (data) {
                alert(data);
            },
            error: function (data) {
                alert("Ocorreu um erro ao salvar os dados do Pagamento");
            }
        });        
    }

    function enviar(pag) {
        var acrescimo = $("#acrescimo").val();
        var desconto = $("#desconto").val();
        var imposto = $("#imposto").val();
        var total = $("#total").val();
        var info = $("#infoad").val();

        $.ajax({
            type: "POST",
            url: 'Pagamento/Enviar',
            data: {
                pag: pag,
                acrescimo: acrescimo,
                desconto: desconto,
                imposto: imposto,
                total: total,
                info: info
            },
            success: function (data) {
                alert(data);
                window.location.reload();
            },
            error: function (data) {
                alert("Ocorreu um erro ao confirmar o pagamento!");
            }
        });
    }
</script>

</asp:Content>
