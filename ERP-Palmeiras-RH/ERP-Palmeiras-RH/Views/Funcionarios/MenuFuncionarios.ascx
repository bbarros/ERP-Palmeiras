<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<dynamic>" %>

    <ul>
        <li class="accordion"><a href="#">Permissoes</a></li>
        <li class="accordionSubItem">
            <ul>
                <li><a href="<%= Url.Action("Permissoes", "Funcionarios") %>">Visualizar Permissões</a></li>
                <li><a href="<%= Url.Action("CriarPermissao", "Funcionarios") %>">Criar Permissão</a></li>     
            </ul>
        </li>
    </ul>


