﻿<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content3" ContentPlaceHolderID="SideMenu" runat="server">
    <% Html.RenderPartial("MenuLA"); %>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <% IEnumerable<ERP_Palmeiras_LA.Models.Equipamento> equipamentos = (IEnumerable<ERP_Palmeiras_LA.Models.Equipamento>)ViewData["Equipamentos"]; %>
    <% ERP_Palmeiras_LA.Models.SolicitacaoCompraEquipamento solicitacao = (ERP_Palmeiras_LA.Models.SolicitacaoCompraEquipamento)ViewData.Model; %>
    <% String dataValidade = (new DateTime(solicitacao.DataValidade)).ToString("dd/MM/yyyy"); %>
    <div id="formulario">
        <form method="post" enctype="multipart/form-data" action="<%= Url.Action("Alterar") %>">
        <p style="font: verdana; color: #434343; font-size: large;">
            Formulário de Informações do Equipamento</p>
        <table cellspacing="10" style="font-weight: normal;" class="formPadrao">
            <tr>
                <th>
                    Data Validade
                </th>
                <th style="padding-left: 50px;">
                    <input id="data" name="data" type="text" value="<%= dataValidade %>" />
                </th>
                <th style="padding-left: 15px;">
                    Preço
                </th>
                <th style="padding-left: 60px;">
                    <input id="preco" name="preco" type="text" value="<%= solicitacao.Preco.ToString() %>" />
                </th>
            </tr>
            <tr>
                <th style="padding-left: 15px;">
                    Equipamento
                </th>
                <th style="padding-left: 60px;">
                    <select id="equipamentoId" name="equipamentoId">
                        <% foreach (ERP_Palmeiras_LA.Models.Equipamento eq in equipamentos)
                           { %>
                        <option <%= (solicitacao.EquipamentoId == eq.Id)? "SELECTED" : "" %> value="<%= eq.Id %>">
                            <%= eq.Nome %></option>
                        <% } %>
                    </select>
                </th>
            </tr>
        </table>
        <br />
        <input type="hidden" name="id" value="<%= solicitacao.Id %>" />
        <input id="botaoSalvar" type="submit" value="Salvar" style="float: right; margin-right: 9px;" />
        </form>
    </div>
</asp:Content>
