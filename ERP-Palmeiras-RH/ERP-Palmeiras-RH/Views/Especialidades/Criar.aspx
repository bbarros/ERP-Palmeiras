<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<h2>Especialidade</h2>
<br />

<form id="PermissaoForm" action="<%= Url.Action("Criar", "Especialidades") %>">
    <label for="nome">Nome</label>
    <input id="nome" type="text" name="nome" />
    <input id="submit" type="submit" value="Criar" />
</form>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="SideMenu" runat="server">
    <% Html.RenderPartial("MenuFuncionarios"); %>
</asp:Content>
