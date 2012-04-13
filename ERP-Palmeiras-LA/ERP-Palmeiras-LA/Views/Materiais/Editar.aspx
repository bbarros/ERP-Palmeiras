<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content3" ContentPlaceHolderID="SideMenu" runat="server">
    <% Html.RenderPartial("MenuLA"); %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div id="formulario">
        <form method="post" enctype="multipart/form-data" action="<%= Url.Action("Alterar") %>">
        <p style="font: verdana; color: #434343; font-size: large;">
            Formulário de Informações do Material</p>
        <table cellspacing="10" style="font-weight: normal;" class="formPadrao">
            <tr>
                Código
            </tr>
            <tr>
                <input id="codigo" name="codigo" type="text" value="<%= ViewBag.mat.Codigo %>" />
            </tr>
            <tr>
                Nome
            </tr>
            <tr>
                <input id="nome" name="nome" type="text" value="<%= ViewBag.mat.Nome %>" />
            </tr>
            <tr>
                Fabricante
            </tr>
            <tr>
                <select id="fabricante" name="fabricante">
                    <% foreach (ERP_Palmeiras_LA.Models.Fabricante f in ViewBag.fabricantes)
                        { %>
                    <option <%= (ViewBag.mat.FabricanteId == f.Id)? "SELECTED" : "" %> value="<%= f.Id %>" >
                        <%= f.Nome %></option>
                    <% } %>
                </select>
            </tr>
            <tr>
                Descrição
            </tr>
            <tr>
                <input id="descricao" name="descricao" type="text" value="<%= ViewBag.mat.Descricao %>" />
            </tr>
        </table>
        <br />
        <input type="hidden" name="materialID" value="<%= ViewBag.mat.Id %>" />
        <input id="botaoSalvar" type="submit" value="Salvar" style="float: right; margin-right: 9px;" />
        </form>
    </div>
</asp:Content>

