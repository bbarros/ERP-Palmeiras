<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<System.Web.Mvc.HandleErrorInfo>" %>
<asp:Content ID="errorContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Um erro ocorreu!
    </h2>
    <p>
        <%= ViewData["Message"] %>
    </p>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="SideMenu" runat="server">
<% if(ERP_Palmeiras_LA.Controllers.GerenciadorDeSessao.GetInstance().SessaoAtiva) { %>
    <% Html.RenderPartial("MenuLA"); %>
    <% } %>
</asp:Content>