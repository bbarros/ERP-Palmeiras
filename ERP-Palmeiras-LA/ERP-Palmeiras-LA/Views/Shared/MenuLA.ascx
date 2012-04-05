<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<dynamic>" %>

    <ul>
        <li class="accordion">
            <h3>Usuários</h3>
            <ul class="accordionSubItem">
                <li><a href="<%= Url.Action("Index", "Usuarios") %>">Visualizar Usuários</a></li>
                <li><a href="<%= Url.Action("Criar", "Usuarios") %>">Cadastrar Usuário</a></li>     
            </ul>
        </li>
    </ul>


