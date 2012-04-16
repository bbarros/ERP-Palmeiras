<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <% 

        String data = new DateTime(ViewBag.solmanu.DataPrevista).ToString("dd/MM/yyyy");
        
        String dataEntregue = new DateTime(ViewBag.solmanu.DataTerminoManutencao).ToString("dd/MM/yyyy");
        if (dataEntregue == "01/01/0001")
            dataEntregue = null;
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
    <form method="post" enctype="multipart/form-data" action="<%= Url.Action("AlterarManutencao") %>">
        <p>Pendencia</p>
        <tr>
            <td>Usuário:</td>
            <td style="padding-left: 50px;"><input id="usuario" name="usuario" type="text" value="<%= (String)ViewBag.usuario %>" readonly disabled /></td>
            <td>Equipamento:</td>
            <th style="padding-left: 50px;">
            <input id="equipamentoId" name="equipamentoId" type="text" value="<%= ViewBag.solmanu.EquipamentoClinica.Equipamento.Nome%>" readonly disabled />  
            </th>
        </tr>
        <tr>
            <td>Custo:</td>
            <td style="padding-left: 50px;"><input id="custo" name="custo" type="text" value="<%= ViewBag.solmanu.Custo %>"/></td>
            <td>Data Prevista:</td>
            <td style="padding-left: 50px;"><input id="dataprevista" name="dataprevista" type="date" value="<%= data %>" onkeyup="FormataData(this,event)" maxlength="10"/></td>
        
        </tr>
        <tr>
            <td>Status:</td>
            <td style="padding-left: 50px;"><select id="status" name="status" type="text" value="<%= ViewBag.solmanu.Status %>"/>
                    <option>CONCLUIDA</option>
                    <option>EM_PROGRESSO</option>
                    <option>PENDENTE</option>      
                </select>
            </td>
        </tr>
        <tr>
            <td>Data Entregue:</td>
            <td style="padding-left: 50px;">
            <input id="dataentregue" name="dataentregue" type="date" value="<%= dataEntregue %>" onkeyup="FormataData(this,event)" maxlength="10"/>
            </td>
        
        </tr>

        <tr>
            <td colspan="4">Motivo</td>
        </tr>
        <tr>
            <td colspan="4"><input id="Text1" name="motivo" type="text" disabled readonly value="<%= ViewBag.solmanu.Motivo %>" style="width: 100%; height: 100px; overflow: scroll;"/></td>
        </tr>
        <th>
        <input type="hidden" name="id" value="<%= ViewBag.solmanu.Id %>" />
        <input id="botaoSalvar" type="submit" value="Salvar" style=" margin-left: 820%" />
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
