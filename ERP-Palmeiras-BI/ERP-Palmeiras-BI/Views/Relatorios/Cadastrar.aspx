<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <%
        ERP_Palmeiras_BI.Models.Relatorio r = (ERP_Palmeiras_BI.Models.Relatorio)ViewData.Model;
    %>
<h2>Relatório criado com sucesso!</h2>

<p>
<img src="<%= r.UrlImagem %>" alt="<%= r.Titulo %>" />
</p>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="SideMenu" runat="server">
<% Html.RenderPartial("MenuBI"); %>
</asp:Content>
