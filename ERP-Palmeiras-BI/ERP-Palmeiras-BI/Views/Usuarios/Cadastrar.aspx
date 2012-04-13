<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<h2>Usuário cadastrado com sucesso!</h2>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="SideMenu" runat="server">
<% Html.RenderPartial("MenuBI"); %>
</asp:Content>
