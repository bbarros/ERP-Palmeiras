<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<h2>Materiais</h2>
<br />

<form id="PermissaoForm" action="<%= Url.Action("Criar", "Materiais") %>">
    <label for="nome">Nome</label>
    <label for="codigo">Código</label>
    <label for="fabricante">Fabricante</label>
    <label for="descricao">Descrição</label>
</form>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="SideMenu" runat="server">
    <% Html.RenderPartial("MenuLA"); %>
</asp:Content>
