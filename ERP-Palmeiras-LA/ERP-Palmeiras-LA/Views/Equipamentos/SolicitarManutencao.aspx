<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <% 
        IEnumerable<ERP_Palmeiras_LA.Models.SolicitacaoManutencao> solicitacoes = (IEnumerable<ERP_Palmeiras_LA.Models.SolicitacaoManutencao>)ViewBag.solicitacoes;  
    %>


    <script type="text/javascript">
       function FormataData(campo, teclapres) {
            var tecla = teclapres.keyCode;
            var vr = new String(campo.value);
            vr = vr.replace("/", "");
            tam = vr.length + 1;
            if (tecla != 10) {
                if (tam == 3)
                    campo.value = vr.substr(0, 2) + '/';
                if (tam == 5)
                    campo.value = vr.substr(0, 2) + '/' + vr.substr(2, 2) + '/';
            }
        }

        
    </script>


<h2>SolicitarManutencao</h2>

    <div id="FormManutencao">
    <table>
    <form method="post" enctype="multipart/form-data" action="<%= Url.Action("CadastrarManutencao") %>">
        <p>Pendencia</p>
        <tr>
            <td>Usuário:</td>
            <td style="padding-left: 50px;"><input id="usuario" name="usuario" type="text" value="<%= (String)ViewBag.usuario %>" readonly disabled /></td>
            <td>Equipamento:</td>
            <th style="padding-left: 50px;">
            <select id="equipamentoId" name="equipamentoId" style=" width: 180px; overflow:hidden;">
                <% foreach (ERP_Palmeiras_LA.Models.EquipamentoClinica e in ViewBag.equipamentos)
                    { %>
                <option value="<%= e.Id %>">
                    <%= e.Id+"-"+e.Equipamento.Nome %></option>
                <% } %>
            </select>
         </th>
        </tr>
        <tr>
            <%--<td>Custo:</td>
            <td style="padding-left: 50px;"><input id="custo" name="custo" type="text"/></td>--%>
            <td>Data Prevista:</td>
            <td style="padding-left: 50px;"><input id="dataprevista" name="dataprevista" type="date" onkeyup="FormataData(this,event)" maxlength="10"/></td>
        
        </tr>
        <tr>
            <td colspan="4">Motivo</td>
        </tr>
        <tr>
            <td colspan="4"><input id="Text1" name="motivo" type="text" style="width: 100%; height: 100px; overflow: scroll;"/></td>
        </tr>
        <th>
        <input id="botaoSalvar" type="submit" value="Salvar" style=" margin-left: 1500%" />
        </th>


    </form>     
    </table>
    </div>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="SideMenu" runat="server">
    <% Html.RenderPartial("MenuLA"); %>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="Modal" runat="server">
</asp:Content>
