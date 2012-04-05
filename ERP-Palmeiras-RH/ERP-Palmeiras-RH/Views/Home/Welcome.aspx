<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>



<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>Wielkommen auf der System!!!!! </p>
    <br />
    <br />
    <div id="FormRegistro">
    <p>Não Esqueça de Registrar seu cartão de entrada e Saída</p> 
    <br />
    <form id="FormPontoEntrada" action="<%= Url.Action("RegistroPontoEntrada","Home") %>" method="post">
    <input id="RegistrarPonto" type="submit" value=" Registrar Ponto Entrada" />
    </form>
    <br />
    <form id="FormProntoSaida" action="<%= Url.Action("RegistroPontoSaida","Home") %>" method="post">
    <input id="Submit1" type="submit" value=" Registrar Ponto Saida" />
    </form>
    </div>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="SideMenu" runat="server">
    <% Html.RenderPartial("MenuFuncionarios"); %>
</asp:Content>

