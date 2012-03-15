<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<dynamic>" %>

    <ul>
        <li class="accordion"><a href="#">Permissoes</a>
            <ul class="accordionSubItem">
                <li><a href="<%= Url.Action("Permissoes", "Funcionarios") %>">Visualizar Permissões</a></li>
                <li><a href="<%= Url.Action("CriarPermissao", "Funcionarios") %>">Criar Permissão</a></li>     
            </ul>
        </li>

        <li class="accordion"><a href="#">Funcionarios</a>
            <ul class="accordionSubItem">
                <li><a href="<%= Url.Action("IndexFuncionarios", "Funcionarios") %>">Ver Cadastros</a></li>
                <li><a href="<%= Url.Action("Cadastro", "Funcionarios") %>">Cadastrar Funcionario</a></li>     
            </ul>
        </li>
    </ul>


