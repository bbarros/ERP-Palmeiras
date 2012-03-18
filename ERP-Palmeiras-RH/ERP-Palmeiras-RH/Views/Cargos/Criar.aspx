<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<h2>Criar Cargo</h2>

<form id="CargoForm" action="<%= Url.Action("Criar", "Cargos") %>">
    <p>Nome:</p>
    <input id="nome" type="text" name="nome" />
    <br />
    <p>Salário Base:</p>
    <input id="salarioBase" type="text" name="salarioBase" />
    <br />
    <input id="submit" type="submit" value="Criar" />
</form>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="SideMenu" runat="server">
    <% Html.RenderPartial("MenuFuncionarios"); %>
</asp:Content>
