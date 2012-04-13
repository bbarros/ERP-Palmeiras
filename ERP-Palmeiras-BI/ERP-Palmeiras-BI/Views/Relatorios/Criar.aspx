<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="SideMenu" runat="server">
    <% Html.RenderPartial("MenuBI"); %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="formulario">
        <form method="post" enctype="multipart/form-data" action="<%= Url.Action("Cadastrar") %>">
        <p style="font: verdana; color: #434343; font-size: large;">
            Formulário de Informações do Relatório</p>
        <table cellspacing="10" style="font-weight: normal;" class="formPadrao">
            <tr>
                <th>
                    Título
                </th>
                <th style="padding-left: 50px;">
                    <input id="titulo" name="titulo" type="text" value="" />
                </th>
                <th style="padding-left: 15px;">
                    Tipo de Relatório
                </th>
                <th style="padding-left: 60px;">
                    <select id="tipo" name="tipo">
                        <option value="0">Especialidades Requisitadas</option>
                        <option value="1">Consultas Realizadas</option>
                    </select>
                </th>
            </tr>
            <tr>
                <th>
                    Data de Início
                </th>
                <th style="padding-left: 50px;">
                    <input id="dataInicio" name="dataInicio" type="text" value="" />
                </th>
                <th style="padding-left: 15px;">
                    Data de Fim
                </th>
                <th style="padding-left: 60px;">
                    <input id="dataFim" name="dataFim" type="password" value="" />
                </th>
            </tr>
        </table>
        <br />
        <input id="botaoSalvar" type="submit" value="Salvar" style="float: right; margin-right: 9px;" />
        </form>
    </div>
</asp:Content>