<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content3" ContentPlaceHolderID="SideMenu" runat="server">
    <% Html.RenderPartial("MenuLA"); %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <%
        ERP_Palmeiras_LA.Models.Equipamento eq = (ERP_Palmeiras_LA.Models.Equipamento)ViewData.Model;
    %>
    <% IEnumerable<ERP_Palmeiras_LA.Models.Fabricante> fabricantes = (IEnumerable<ERP_Palmeiras_LA.Models.Fabricante>)ViewData["Fabricantes"]; %>
    <div id="formulario">
        <form method="post" enctype="multipart/form-data" action="<%= Url.Action("Alterar") %>">
        <p style="font: verdana; color: #434343; font-size: large;">
            Formulário de Informações do Equipamento</p>
        <table cellspacing="10" style="font-weight: normal;" class="formPadrao">
            <tr>
                <th>
                    Número de Série
                </th>
                <th style="padding-left: 50px;">
                    <input id="nserie" name="nserie" type="text" value="<%= eq.NumeroSerie %>" />
                </th>
                <th style="padding-left: 15px;">
                    Nome
                </th>
                <th style="padding-left: 60px;">
                    <input id="nome" name="nome" type="text" value="<%= eq.Nome %>" />
                </th>
            </tr>
            <tr>
                <th>
                    Descrição
                </th>
                <th style="padding-left: 50px;">
                    <input id="descricao" name="descricao" type="text" value="<%= eq.Descricao %>" />
                </th>
                <th style="padding-left: 15px;">
                    Fabricante
                </th>
                <th style="padding-left: 60px;">
                    <select id="fabricante" name="fabricante">
                        <% foreach (ERP_Palmeiras_LA.Models.Fabricante f in fabricantes)
                           { %>
                        <option <%= (eq.FabricanteId == f.Id)? "SELECTED" : "" %> value="<%= f.Id %>" >
                            <%= f.Nome %></option>
                        <% } %>
                    </select>
                </th>
            </tr>
        </table>
        <br />
        <input id="botaoSalvar" type="submit" value="Salvar" style="float: right; margin-right: 9px;" />
        </form>
    </div>
</asp:Content>
