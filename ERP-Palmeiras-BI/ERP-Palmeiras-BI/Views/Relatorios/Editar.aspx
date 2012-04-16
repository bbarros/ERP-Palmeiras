<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="SideMenu" runat="server">
    <% Html.RenderPartial("MenuBI"); %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<% ERP_Palmeiras_BI.Models.Relatorio r = (ERP_Palmeiras_BI.Models.Relatorio)ViewData.Model; %>
    <div id="formulario">
        <form method="post" enctype="multipart/form-data" action="<%= Url.Action("Alterar") %>">
        <p style="font: verdana; color: #434343; font-size: large;">
            Formulário de Informações do Relatório</p>
        <table cellspacing="10" style="font-weight: normal;" class="formPadrao">
            <tr>
                <th>
                    Título
                </th>
                <th style="padding-left: 50px;">
                    <input id="titulo" name="titulo" type="text" value="<%= r.Titulo %>" />
                </th>
                <th style="padding-left: 15px;">
                    Tipo de Relatório
                </th>
                <th style="padding-left: 60px;">
                    <select id="tipo" name="tipo">
                        <option <%= r.Tipo.Value == 0? "SELECTED" : "" %> value="0">Especialidades Requisitadas</option>
                        <option <%= r.Tipo.Value == 1? "SELECTED" : "" %> value="1">Consultas Realizadas</option>
                    </select>
                </th>
            </tr>
            <tr>
                <th>
                    Data de Início
                </th>
                <th style="padding-left: 50px;">
                    <input id="dataInicio" name="dataInicio" type="text" value="<%= new DateTime(r.DataInicio).ToString("dd/MM/yyyy") %>" />
                </th>
                <th style="padding-left: 15px;">
                    Data de Fim
                </th>
                <th style="padding-left: 60px;">
                    <input id="dataFim" name="dataFim" type="text" value="<%= new DateTime(r.DataFim).ToString("dd/MM/yyyy") %>" />
                </th>
            </tr>
        </table>
        <br />
        <input type="hidden" name="id" value="<%= r.Id %>" />
        <input id="botaoSalvar" type="submit" value="Salvar" style="float: right; margin-right: 9px;" />
        </form>
    </div>
</asp:Content>