<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<dynamic>" %>

    <ul>
        <li class="accordion">
            <h3>Usuários</h3>
            <ul class="accordionSubItem">
                <li><a href="<%= Url.Action("Index", "Usuarios") %>">Visualizar Usuários</a></li>
                <li><a href="<%= Url.Action("Criar", "Usuarios") %>">Cadastrar Usuário</a></li>     
            </ul>
        </li>

        <li class="accordion">
            <h3>Relatórios</h3>
            <ul class="accordionSubItem">
                <li><a href="<%= Url.Action("Index", "Relatorios") %>">Visualizar Relatórios</a></li>
                <li><a href="<%= Url.Action("Criar", "Relatorios") %>">Criar Relatórios</a></li>     
            </ul>
        </li>
    </ul>

    <form id="FormLogoff" action="<%= Url.Action("Logout","Home") %>" method="post"><input id="logoffSubmit" name="Logout" type="submit" value=" Logout " /></form>

