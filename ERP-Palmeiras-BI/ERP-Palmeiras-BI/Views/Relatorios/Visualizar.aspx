<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <%
        ERP_Palmeiras_BI.Models.Relatorio r = (ERP_Palmeiras_BI.Models.Relatorio)ViewData.Model;
    %>

<p align="center" style="margin: 30px 15% 30px 15%;" >
    <img src="<%= Url.Content(r.UrlImagem) %>" alt="<%= r.Titulo %>" height="400" />
</p>
<p align="left" style="margin: 30px;">
    Gerado em: <%= new DateTime(r.DataModificacao).ToString("dd/MM/yyyy : hh:mm:ss") %>
</p>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="SideMenu" runat="server">
<% Html.RenderPartial("MenuBI"); %>
</asp:Content>
