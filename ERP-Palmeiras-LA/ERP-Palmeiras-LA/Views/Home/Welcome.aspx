<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>



<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>Aqui é Palmeiras, porra!</p>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="SideMenu" runat="server">
    <% Html.RenderPartial("MenuLA"); %>
</asp:Content>

