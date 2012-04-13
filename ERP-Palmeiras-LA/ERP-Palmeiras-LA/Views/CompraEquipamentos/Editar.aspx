<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content3" ContentPlaceHolderID="SideMenu" runat="server">
    <% Html.RenderPartial("MenuLA"); %>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <% ERP_Palmeiras_LA.Models.CompraEquipamento compra = (ERP_Palmeiras_LA.Models.CompraEquipamento)ViewData.Model; %>
    <% String dataPrevista = (new DateTime(compra.DataPrevista)).ToString("dd/MM/yyyy"); %>
    <div id="formulario">
        <form method="post" enctype="multipart/form-data" action="<%= Url.Action("Alterar") %>">
        <p style="font: verdana; color: #434343; font-size: large;">
            Formulário de Informações do Equipamento</p>
        <table cellspacing="10" style="font-weight: normal;" class="formPadrao">
            <tr>
                <th>
                    Data Prevista
                </th>
                <th style="padding-left: 50px;">
                    <input id="dataPrevista" name="dataPrevista" type="text" value="<%= dataPrevista %>" />
                </th>
            </tr>
        </table>
        <br />
        <input type="hidden" name="id" value="<%= compra.Id %>" />
        <input id="botaoSalvar" type="submit" value="Salvar" style="float: right; margin-right: 9px;" />
        </form>
    </div>
</asp:Content>
