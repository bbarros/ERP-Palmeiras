<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<h2>Cadastrar Materiais</h2>
<br />

<form id="PermissaoForm" method="post" action="<%= Url.Action("Cadastrar") %>">
    <label for="nome">Nome</label> <br />
        <input id="nome" name="nome" type="text" value="" />
        
    <br /><br />
    <label for="codigo">Código</label><br />
        <input id="codigo" name="codigo" type="text" value="" />
    
    <br /><br />
    <label for="fabricante">Fabricante</label><br />
        <select id="fabricante" name="fabricante">
            <% foreach (ERP_Palmeiras_LA.Models.Fabricante f in ViewBag.fabricantes)
                { %>
            <option value="<%= f.Id %>">
                <%= f.Nome %></option>
            <% } %>
        </select>
    
    <br /><br />
    <label for="descricao">Descrição</label><br />
        <textarea id="descricao" name="descricao" cols="40" rows="5"></textarea>

    <br /><br />
    <input id="salvar" type="submit" value="Salvar" style="margin-left: 5%"/>
</form>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="SideMenu" runat="server">
    <% Html.RenderPartial("MenuLA"); %>
</asp:Content>
