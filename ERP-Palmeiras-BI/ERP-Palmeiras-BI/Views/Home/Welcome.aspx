<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>



<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>Wielkommen auf der System!!!!! </p>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="SideMenu" runat="server">
    <% Html.RenderPartial("MenuBI"); %>
</asp:Content>

