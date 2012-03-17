<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<h2>Criar Beneficio</h2>

<form id="BeneficioForm" action="<%= Url.Action("Criar", "Beneficios") %>">
    <p>Nome:</p>
    <input id="nome" type="text" name="nome" />
    <br />
    <p>Valor:</p>
    <input id="valor" type="text" name="valor" />
    <br />
    <input id="submit" type="submit" value="Criar" />
</form>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="SideMenu" runat="server">
    <% Html.RenderPartial("MenuFuncionarios"); %>
</asp:Content>
