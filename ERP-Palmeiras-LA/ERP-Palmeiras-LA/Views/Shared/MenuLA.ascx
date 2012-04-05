<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<dynamic>" %>

    <ul>
        <li class="accordion">
            <h3>Materiais</h3>
            <ul class="accordionSubItem">
                <li><a href="<%= Url.Action("Criar", "Materiais") %>">Cadastrar Materiais</a></li>
            </ul>
        </li>
    </ul>


