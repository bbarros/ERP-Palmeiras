<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>


<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div id="Login">
        
        
        <form  id="FormLogin" action="<%= Url.Action("Login","Home") %>" method="post">
        <p style="font-family: Verdana; font-size: large; font-style:oblique" >Login</p>
        <p>Para prosseguir, é necessário realizar o login.</p>    
        <hr />
        <br />
        <p>Usuario </p>
        <input id="user" name="usuario" type="text" />
        <br />
        <p>Senha </p>
        <input id="senha" name="senha" type="password" />

        <br /><br />
        <input id="loginSubmit" name="Login" type="submit" value=" Login " />
        </form>
    
    </div> 
    <%= ViewData.Model %>

</asp:Content>
