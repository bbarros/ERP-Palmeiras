<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="SideMenu" runat="server">
    <% Html.RenderPartial("MenuLA"); %>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="formulario">
        <form method="post" enctype="multipart/form-data" action="<%= Url.Action("Cadastrar") %>">
        <p style="font: verdana; color: #434343; font-size: large;">
            Formulário de Informações do Fabricante</p>
        <table cellspacing="10" style="font-weight: normal;" class="formPadrao">
            <tr>
                <th>
                    Nome
                </th>
                <th style="padding-left: 50px;">
                    <input id="nome" name="nome" type="text" value="" />
                </th>
                <th style="padding-left: 15px;">
                    CNPJ
                </th>
                <th style="padding-left: 60px;">
                    <input id="cnpj" name="cnpj" type="text" value="" />
                </th>
            </tr>
        </table>
        <br />
        <input id="botaoSalvar" type="submit" value="Salvar" style="float: right; margin-right: 9px;" />
        </form>
    </div>
</asp:Content>
