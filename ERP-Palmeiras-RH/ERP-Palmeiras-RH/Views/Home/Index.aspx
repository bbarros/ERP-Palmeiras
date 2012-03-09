<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>


<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
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
                    campo.value = vr.substr(0, 2) + '.' + vr.substr(3, 3) + '.' + vr.substr(7,3) + '-' + vr.substr(10, 1);
            }
        }
        function FormataCEP(campo, teclapres) {
            var tecla = teclapres.keyCode;
            var vr = new String(campo.value);
            vr = vr.replace("-", "");
            tam = vr.length + 1;
            if (tecla != 12) 
                if (tam == 6)
                    campo.value = vr.substr(0, 5) + '-' + vr.substr(6,3);

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
                    campo.value = vr.substr(0,8) + '-';

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
		</script>

    <div id="formulario">

   
    <p style="font: verdana; color: #434343; font-size: large;" >Formulário de Informações do Funcionário</p>
    <div id="infoPessoais">
    <p style="font: verdana; color: #434343; padding-bottom: 5px; font-size: medium;" >Dados Pessoais</p>

     <table cellspacing="10" style="font-weight: normal;" class="formPadrao" >
        <tr>
            <th>Nome</th>
            <th style="padding-left: 50px;" ><input id="nome" type="text" /></th>
            <th style="padding-left: 15px;">Sobrenome</th>
            <th style="padding-left: 60px;" ><input id="sobrenome" type="text" /></th>

        </tr>
        <tr>
            <th>Sexo</th>
            <th style="padding-left: 50px;" >
                <select id="Select2">
                    <option>Masculino</option>
                    <option>Feminino</option>
                    <option>Indefinido</option>
                </select>
            
            </th>
            <th style="padding-left: 15px;">Data de Nascimento</th>
            <th style="padding-left: 60px;" ><input id="nascimento" type="text" onkeyup="FormataData(this,event)" maxlength="10"/></th>
        </tr>
        <tr>
            <th><p>Telefone</p></th>
            <th style="padding-left: 50px;" ><input id="telefone" type="text" onkeyup="FormataTel(this,event)" maxlength="13" /></th>
            <th style="padding-left: 15px;"></th>
            <th></th>

        </tr>
        <tr>
            <th>E-mail Pessoal</th>
            <th style="padding-left: 50px;" ><input id="emailpes" type="text" /></th>
        </tr>
        <tr>
            <th>Rua</th>
            <th style="padding-left: 50px;" ><input id="rua" type="text" /></th>
            <th style="padding-left: 15px;">Num.</th>
            <th style="padding-left: 60px;" ><input id="num" type="text" /></th>
        </tr>
           
        <tr>
            <th>Complemento</th>
            <th style="padding-left: 50px;" ><input id="complemento" type="text" /></th>
        </tr>
        
        <tr>
            <th>Bairro</th>
            <th style="padding-left: 50px;" ><input id="bairro" type="text" /></th>
        </tr>

        <tr>
            <th>CEP</th>
            <th style="padding-left: 50px;" ><input id="cep" type="text" onkeyup="FormataCEP(this,event)" maxlength="9"  /></th>
        </tr>

        <tr>
            <th>Cidade</th>
            <th style="padding-left: 50px;" ><input id="cidade" type="text" /></th>          
            <th style="padding-left: 15px;">Estado</th>
            <th style="padding-left: 60px;" ><input id="estado" type="text" /></th>
        </tr>

        <tr>
            <th>País</th>
            <th style="padding-left: 50px;" ><input id="pais" type="text" /></th
        </tr>

        <tr>
            <th>RG</th>
            <th style="padding-left: 50px;" ><input id="rg" type="text" onkeyup="FormataRG(this,event)" maxlength="12" /></th>          
            <th style="padding-left: 15px;">CPF</th>
            <th style="padding-left: 60px;" ><input id="cpf" type="text" onkeyup="FormataCpf(this,event)" maxlength="14"/></th>
        </tr>

        <tr>
            <th>CRM</th>
            <th style="padding-left: 50px;" ><input id="crm" type="text" /></th>          
        </tr>

        <tr>
            <th>Formação</th>
            <th style="padding-left: 50px;" ><input id="formacao" type="text" /> <input id="anexarCV" type="button" value="Anexar CV" /></th>          
        </tr>



    </table>

    
    </div>

    <br />
    <hr style="margin-right:8px;"/>
    <br />

    <div id="infoFinanceiro">
        <p style="font: verdana; color: #434343; padding-left: 5px; font-size: medium;" >Dados Financeiros</p>

          <table cellspacing="10" style="font-weight: normal; padding-left: 4px;" class="formPadrao" >

            <tr>
                <th>Banco</th>
                <th style="padding-left: 55px;" ><input id="banco" type="text" /></th>
            </tr>

            <tr>
                <th>Agência</th>
                <th style="padding-left: 55px;" ><input id="agencia" type="text" /></th>
                <th style="padding-left: 100px;">Conta</th>
                <th style="padding-left: 87px;" ><input id="conta" type="text" /></th>
            </tr>
            <tr>
                <th>Salário</th>
                <th style="padding-left: 55px;" ><input id="salario" type="text" /></th>
                <th style="padding-left: 100px;">Benefícios</th>
                <th style="padding-left: 87px;" ><input id="beneficios" type="text" /></th>
            </tr>
            <tr>
                <th>Vale-Refeição</th>
                <th style="padding-left: 55px;" ><input id="vr" type="text" /></th>
                <th style="padding-left: 100px;">Vale-Transporte</th>
                <th style="padding-left: 87px;" ><input id="vt" type="text" /></th>
            </tr>

          </table>

    </div>

    <br />
    <hr style="margin-right:8px;"/>
    <br />

    <div id="infoProfissional">
        <p style="font: verdana; color: #434343; padding-left: 5px; font-size: medium;" >Dados Profissionais</p>

          <table cellspacing="10" style="font-weight: normal; padding-left: 4px;" class="formPadrao" >

          <tr>
            <th>Status</th>
            <th style="padding-left: 55px; width: 500px" >
                <select id="Select1">
                <option>Ativo</option>
                <option>Desligado</option>
                <option>Aposentado</option>
                </select>                       
            </th>
          </tr>

          <tr>
            <th>Num. Carteira de Trabalho</th>
            <th style="padding-left: 55px;" ><input id="carteira" type="text" /></th        
          </tr>
          <tr>
            <th>Data de Admissão</th>
            <th style="padding-left: 55px;" ><input id="dataadmissao" type="text" onkeyup="FormataData(this,event)" maxlength="10" /></th        
          </tr>              
          <tr>
            <th>Data de Demissão</th>
            <th style="padding-left: 55px;" ><input id="datademissao" type="text" onkeyup="FormataData(this,event)" maxlength="10" /></th        
          </tr>
          <tr>
            <th>E-mail Profissional</th>
            <th style="padding-left: 55px;" ><input id="Text3" type="text" /></th        
          </tr>
          <tr>
            <th>Ramal</th>
            <th style="padding-left: 55px;" ><input id="ramal" type="text" /></th        
          </tr>
          <tr>
            <th>Sala</th>
            <th style="padding-left: 55px;" ><input id="Text5" type="text" /></th        
          </tr>
          <tr>
            <th>Cargo</th>
            <th style="padding-left: 55px;" ><input id="Text6" type="text" /></th        
          </tr> 
          <tr>
            <th>Especialidade</th>
            <th style="padding-left: 55px;" ><input id="Text1" type="text" /></th        
          </tr>
          <tr>
            <th>Login</th>
            <th style="padding-left: 55px;" >userid</th>        
          </tr>                                                               
          </table>

    </div>

    <br />

    </div>
    <input id="botaoSalvar" type="button" value="Salvar" style="float: right; margin-right: 9px; "/>

</asp:Content>
