<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="SideMenu" runat="server">
    <% Html.RenderPartial("MenuFuncionarios"); %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <%
        IEnumerable<ERP_Palmeiras_RH.Models.Cargo> cargos = (IEnumerable<ERP_Palmeiras_RH.Models.Cargo>) ViewData["Cargos"];
        IEnumerable<ERP_Palmeiras_RH.Models.Beneficio> beneficios = (IEnumerable<ERP_Palmeiras_RH.Models.Beneficio>) ViewData["Beneficios"];
        IEnumerable<ERP_Palmeiras_RH.Models.Especialidade> especialidades = (IEnumerable<ERP_Palmeiras_RH.Models.Especialidade>) ViewData["Especialidades"];
        IEnumerable<ERP_Palmeiras_RH.Models.Permissao> permissoes = (IEnumerable<ERP_Palmeiras_RH.Models.Permissao>) ViewData["Permissoes"];
    %>
    <script type="text/javascript">
        function FormataCpf(campo, teclapres) {
            var tecla = teclapres.keyCode;
            var vr = new String(campo.value);
            vr = vr.replace(".", "");
            vr = vr.replace("/", "");
            vr = vr.replace("-", "");
            tam = vr.length + 1;
            if (tecla != 14) {
                if (tam == 4)
                    campo.value = vr.substr(0, 3) + '.';
                if (tam == 7)
                    campo.value = vr.substr(0, 3) + '.' + vr.substr(3, 6) + '.';
                if (tam == 11)
                    campo.value = vr.substr(0, 3) + '.' + vr.substr(3, 3) + '.' + vr.substr(7, 3) + '-' + vr.substr(11, 2);
            }
        }

        function FormataRG(campo, teclapres) {
            var tecla = teclapres.keyCode;
            var vr = new String(campo.value);
            vr = vr.replace("-", "");
            tam = vr.length + 1;
            if (tecla != 12) {
                if (tam == 3)
                    campo.value = vr.substr(0, 2) + '.';
                if (tam == 7)
                    campo.value = vr.substr(0, 2) + '.' + vr.substr(3, 3) + '.';
                if (tam == 11)
                    campo.value = vr.substr(0, 2) + '.' + vr.substr(3, 3) + '.' + vr.substr(7, 3) + '-' + vr.substr(10, 1);
            }
        }
        function FormataCEP(campo, teclapres) {
            var tecla = teclapres.keyCode;
            var vr = new String(campo.value);
            vr = vr.replace("-", "");
            tam = vr.length + 1;
            if (tecla != 12)
                if (tam == 6)
                    campo.value = vr.substr(0, 5) + '-' + vr.substr(6, 3);

        }
        function FormataTel(campo, teclapres) {
            var tecla = teclapres.keyCode;
            var vr = new String(campo.value);
            vr = vr.replace("-", "");
            tam = vr.length + 1;
            if (tecla != 10)
                if (tam == 3)
                    campo.value = '(' + vr.substr(0, 2) + ')';
            if (tam == 9)
                campo.value = vr.substr(0, 8) + '-';

        }
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

        $(document).ready(function () {
            $("#addTelefone").click(function () {
                $("#telefones").append("<input name=\"telefone\" type=\"text\" onkeyup=\"FormataTel(this,event)\" maxlength=\"13\" />")
            });
        });
    </script>


    <div id="formulario">
        <form method="post" enctype="multipart/form-data" action="<%= Url.Action("Cadastrar") %>">
        <p style="font: verdana; color: #434343; font-size: large;">
            Formulário de Informações do Funcionário</p>
        <div id="infoPessoais">
            <p style="font: verdana; color: #434343; padding-bottom: 5px; font-size: medium;">
                Dados Pessoais</p>
            <table cellspacing="10" style="font-weight: normal;" class="formPadrao">
                <tr>
                    <th>
                        Nome
                    </th>
                    <th style="padding-left: 50px;">
                        <input id="nome" name="nome" type="text" />
                    </th>
                    <th style="padding-left: 15px;">
                        Sobrenome
                    </th>
                    <th style="padding-left: 60px;">
                        <input id="sobrenome" name="sobrenome" type="text" />
                    </th>
                </tr>
                <tr>
                    <th>
                        Sexo
                    </th>
                    <th style="padding-left: 50px;">
                        <select id="sexo" name="sexo">
                            <option value="Masculino">Masculino</option>
                            <option value="Feminino">Feminino</option>
                            <option value="Indefinido">Indefinido</option>
                        </select>
                    </th>
                    <th style="padding-left: 15px;">
                        Data de Nascimento
                    </th>
                    <th style="padding-left: 60px;">
                        <input id="nascimento" name="nascimento" type="text" onkeyup="FormataData(this,event)"
                            maxlength="10" />
                    </th>
                </tr>
                <tr>
                    <th>
                        <p>
                            Telefone</p>
                    </th>
                    <th id="telefones" style="padding-left: 50px;">
                        <input name="telefone" type="text" onkeyup="FormataTel(this,event)"
                            maxlength="13" />
                    </th>
                    <th style="padding-left: 15px;">
                        <input id="addTelefone" type="button" value="+" style="padding-left: 3px;" />
                    </th>
                    <th>
                    </th>
                </tr>
                <tr>
                    <th>
                        E-mail Pessoal
                    </th>
                    <th style="padding-left: 50px;">
                        <input id="emailpes" name="emailpes" type="text" />
                    </th>
                </tr>
                <tr>
                    <th>
                        Rua
                    </th>
                    <th style="padding-left: 50px;">
                        <input id="rua" name="rua" type="text" />
                    </th>
                    <th style="padding-left: 15px;">
                        Num.
                    </th>
                    <th style="padding-left: 60px;">
                        <input id="num" name="num" type="text" />
                    </th>
                </tr>
                <tr>
                    <th>
                        Complemento
                    </th>
                    <th style="padding-left: 50px;">
                        <input id="complemento" name="complemento" type="text" />
                    </th>
                </tr>
                <tr>
                    <th>
                        Bairro
                    </th>
                    <th style="padding-left: 50px;">
                        <input id="bairro" name="bairro" type="text" />
                    </th>
                </tr>
                <tr>
                    <th>
                        CEP
                    </th>
                    <th style="padding-left: 50px;">
                        <input id="cep" name="cep" type="text" onkeyup="FormataCEP(this,event)" maxlength="9" />
                    </th>
                </tr>
                <tr>
                    <th>
                        Cidade
                    </th>
                    <th style="padding-left: 50px;">
                        <input id="cidade" name="cidade" type="text" />
                    </th>
                    <th style="padding-left: 15px;">
                        Estado
                    </th>
                    <th style="padding-left: 60px;">
                        <input id="estado" name="estado" type="text" />
                    </th>
                </tr>
                <tr>
                    <th>
                        País
                    </th>
                    <th style="padding-left: 50px;">
                        <input id="pais" name="pais" type="text" />
                    </th>
                </tr>
                <tr>
                    <th>
                        RG
                    </th>
                    <th style="padding-left: 50px;">
                        <input id="rg" name="rg" type="text" onkeyup="FormataRG(this,event)" maxlength="12" />
                    </th>
                    <th style="padding-left: 15px;">
                        CPF
                    </th>
                    <th style="padding-left: 60px;">
                        <input id="cpf" name="cpf" type="text" onkeyup="FormataCpf(this,event)" maxlength="14" />
                    </th>
                </tr>
                <tr>
                    <th>
                        CRM
                    </th>
                    <th style="padding-left: 50px;">
                        <input id="crm" name="crm" type="text" />
                    </th>
                </tr>
                <tr>
                    <th>
                        Formação
                    </th>
                    <th style="padding-left: 50px;">
                        <input id="formacao" name="formacao" type="text" />
                    </th>
                </tr>
                <tr>
                    <th colspan="2">
                        <b>CV </b>
                        <input id="flCurriculum" name="flCurriculum" type="file" value="Anexar CV" />
                    </th>
                </tr>
            </table>
        </div>
        <br />
        <hr style="margin-right: 8px;" />
        <br />
        <div id="infoFinanceiro">
            <p style="font: verdana; color: #434343; padding-left: 5px; font-size: medium;">
                Dados Financeiros</p>
            <table cellspacing="10" style="font-weight: normal; padding-left: 4px;" class="formPadrao">
                <tr>
                    <th>
                        Banco
                    </th>
                    <th style="padding-left: 55px;">
                        <input id="banco" name="banco" type="text" />
                    </th>
                </tr>
                <tr>
                    <th>
                        Agência
                    </th>
                    <th style="padding-left: 55px;">
                        <input id="agencia" name="agencia" type="text" />
                    </th>
                    <th style="padding-left: 100px;">
                        Conta
                    </th>
                    <th style="padding-left: 87px;">
                        <input id="conta" name="conta" type="text" />
                    </th>
                </tr>
                <tr>
                    <th>
                        Salário
                    </th>
                    <th style="padding-left: 55px;">
                        <input id="salario" name="salario" type="text" />
                    </th>
                    <th style="padding-left: 100px;">
                        Benefícios
                    </th>
                    <th style="padding-left: 87px;">
                        <select id="beneficios" name="beneficios" multiple="multiple">
                            <% foreach (ERP_Palmeiras_RH.Models.Beneficio b in beneficios)
                               { %>
                            <option value="<%= b.Id %>">
                                <%= b.Nome %></option>
                            <% } %>
                        </select>
                        <input id="adicionaBeneficiosBtn" type="button" value="+" style="padding-left: 3px;" />
                    </th>
                </tr>
            </table>
        </div>
        <br />
        <hr style="margin-right: 8px;" />
        <br />
        <div id="infoProfissional">
            <p style="font: verdana; color: #434343; padding-left: 5px; font-size: medium;">
                Dados Profissionais</p>
            <table cellspacing="10" style="font-weight: normal; padding-left: 4px;" class="formPadrao">
                <tr>
                    <th>
                        Status
                    </th>
                    <th style="padding-left: 55px; width: 500px">
                        <select id="status" name="status">
                            <option value="1">Ativo</option>
                            <option value="2">Desligado</option>
                            <option value="3">Aposentado</option>
                        </select>
                    </th>
                </tr>
                <tr>
                    <th>
                        Num. Carteira de Trabalho
                    </th>
                    <th style="padding-left: 55px;">
                        <input id="carteira" name="carteira" type="text" />
                    </th>
                </tr>
                <tr>
                    <th>
                        Data de Admissão
                    </th>
                    <th style="padding-left: 55px;">
                        <input id="dataadmissao" name="dataadmissao" type="text" onkeyup="FormataData(this,event)"
                            maxlength="10" />
                    </th>
                </tr>
                <tr>
                    <th>
                        Data de Desligamento
                    </th>
                    <th style="padding-left: 55px;">
                        <input id="datademissao" name="datademissao" type="text" onkeyup="FormataData(this,event)"
                            maxlength="10" />
                    </th>
                </tr>
                <tr>
                    <th>
                        Motivo de Desligamento
                    </th>
                    <th style="padding-left: 55px;">
                        <textarea cols="60" rows="5" id="motivo" name="motivo">
                        </textarea>
                    </th>
                </tr>
                <tr>
                    <th>
                        Ramal
                    </th>
                    <th style="padding-left: 55px;">
                        <input id="ramal" name="ramal" type="text" />
                    </th>
                </tr>
                <tr>
                    <th>
                        Cargo
                    </th>
                    <th style="padding-left: 55px;">
                        <select id="cargo" name="cargo">
                            <% foreach (ERP_Palmeiras_RH.Models.Cargo c in cargos)
                               { %>
                            <option value="<%= c.Id %>"><%= c.Nome %></option>
                            <% } %>
                        </select>
                    </th>
                </tr>
                <tr>
                    <th>
                        Especialidade
                    </th>
                    <th style="padding-left: 55px;">
                        <select id="especialidade" name="especialidade">
                        <option value="0">Nao se aplica</option>
                            <% foreach (ERP_Palmeiras_RH.Models.Especialidade e in especialidades)
                               { %>
                            <option value="<%= e.Id %>"><%= e.Nome %></option>
                            <% } %>
                        </select>
                    </th>
                </tr>
                <tr>
                    <th>
                        Login
                    </th>
                    <th style="padding-left: 55px;">
                        <input id="usuario" name="usuario" type="text" />
                    </th>
                </tr>
                <tr>
                    <th>
                        Senha
                    </th>
                    <th style="padding-left: 55px;">
                        <input id="senha" name="senha" type="password" />
                    </th>
                </tr>
                <tr>
                <th>
                        Permissoes
                    </th>
                    <th style="padding-left: 55px;">
                        <select id="permissao" name="permissao">
                            <% foreach (ERP_Palmeiras_RH.Models.Permissao p in permissoes)
                               { %>
                            <option value="<%= p.Id %>">
                                <%= p.Nome %></option>
                            <% } %>
                        </select>
                    </th>
                </tr>
            </table>
            <div id="adicionarBeneficiosDiv" style="display: none"></div>
            <input id="adicionarBeneficiosUrl" type="hidden" value="<%= Url.Action("Visualizar", "Beneficios") %>" />
        </div>
        <br />
        <input id="botaoSalvar" type="submit" value="Salvar" style="float: right; margin-right: 9px;" />
        </form>
    </div>
</asp:Content>