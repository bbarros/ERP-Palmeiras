<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>



<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>Wielkommen auf der System!!!!! </p>
    <form id="FormPonto" action="<%= Url.Action("RegistroPonto","Home") %>" method="post">
    <input id="RegistrarPonto" type="submit" value=" Registrar Ponto " />
    
    </form>

</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="SideMenu" runat="server">
    <% Html.RenderPartial("MenuFuncionarios"); %>
</asp:Content>

