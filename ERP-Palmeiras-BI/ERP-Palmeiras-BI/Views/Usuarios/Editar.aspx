<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content3" ContentPlaceHolderID="SideMenu" runat="server">
    <% Html.RenderPartial("MenuBI"); %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <%
        ERP_Palmeiras_BI.Models.Usuario u = (ERP_Palmeiras_BI.Models.Usuario)ViewData.Model;
    %>
    <div id="formulario">
        <form method="post" enctype="multipart/form-data" action="<%= Url.Action("Alterar") %>">
        <p style="font: verdana; color: #434343; font-size: large;">
            Formulário de Informações do Usuário</p>
        <table cellspacing="10" style="font-weight: normal;" class="formPadrao">
            <tr>
                <th>
                    Login
                </th>
                <th style="padding-left: 50px;">
                    <input id="login" name="login" type="text" value="<%= u.Login %>" />
                </th>
                <th style="padding-left: 15px;">
                    Senha
                </th>
                <th style="padding-left: 60px;">
                    <input id="pasword" name="password" type="password" value="" />
                </th>
            </tr>
        </table>
        <br />
        <input type="hidden" name="id" value="<%= u.Id %>" />
        <input id="botaoSalvar" type="submit" value="Salvar" style="float: right; margin-right: 9px;" />
        </form>
    </div>
</asp:Content>
