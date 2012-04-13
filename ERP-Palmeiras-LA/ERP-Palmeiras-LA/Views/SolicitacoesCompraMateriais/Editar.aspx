<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content3" ContentPlaceHolderID="SideMenu" runat="server">
    <% Html.RenderPartial("MenuLA"); %>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <% IEnumerable<ERP_Palmeiras_LA.Models.Material> materiais = (IEnumerable<ERP_Palmeiras_LA.Models.Material>)ViewData["Materiais"]; %>
    <% ERP_Palmeiras_LA.Models.SolicitacaoCompraMaterial solicitacao = (ERP_Palmeiras_LA.Models.SolicitacaoCompraMaterial)ViewData.Model; %>
    <% String dataValidade = (new DateTime(solicitacao.DataValidade)).ToString("dd/MM/yyyy"); %>
    <div id="formulario">
        <form method="post" enctype="multipart/form-data" action="<%= Url.Action("Alterar") %>">
        <p style="font: verdana; color: #434343; font-size: large;">
            Formulário de Informações do Equipamento</p>
        <table cellspacing="10" style="font-weight: normal;" class="formPadrao">
            <tr>
                <th>
                    Preço Unitário
                </th>
                <th style="padding-left: 50px;">
                    <input id="preco" name="preco" type="text" value="" />
                </th>
                <th style="padding-left: 15px;">
                    Data Validade
                </th>
                <th style="padding-left: 60px;">
                    <input id="data" name="data" type="text" value="" />
                </th>
            </tr>
            <tr>
                <th style="padding-left: 15px;">
                    Material
                </th>
                <th style="padding-left: 60px;">
                    <select id="materialId" name="materialId">
                        <% foreach (ERP_Palmeiras_LA.Models.Material m in materiais)
                           { %>
                        <option <%= (solicitacao.MaterialId == m.Id)? "SELECTED" : "" %> value="<%= m.Id %>">
                            <%= m.Nome %></option>
                        <% } %>
                    </select>
                </th>
                <th style="padding-left: 15px;">
                    Quantidade
                </th>
                <th style="padding-left: 60px;">
                    <input id="quantidade" name="quantidade" type="text" value="" />
                </th>
            </tr>
        </table>
        <br />
        <input type="hidden" name="id" value="<%= solicitacao.Id %>" />
        <input id="botaoSalvar" type="submit" value="Salvar" style="float: right; margin-right: 9px;" />
        </form>
    </div>
</asp:Content>
