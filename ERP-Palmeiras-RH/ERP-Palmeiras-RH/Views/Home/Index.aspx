<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>


<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div id="Login">
        
        <form action="<%= Url.Action("Login","Home") %>" method="post">
        <p>Usuario </p>
        <input id="user" name="usuario" type="text" />
        <br />
        <p>Senha </p>
        <input id="senha" name="senha" type="text" />

        <br />
        <input id="loginSubmit" name="Login" type="submit" value="submit" />
        </form>
    
    </div> 
    <%= ViewData.Model %>

</asp:Content>
