﻿<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<dynamic>" %>

    <ul>
        <li class="accordion">
            <h3>Funcionarios</h3>
            <ul class="accordionSubItem">
                <li><a href="<%= Url.Action("Index", "Funcionarios") %>">Ver Cadastros</a></li>
                <li><a href="<%= Url.Action("Criar", "Funcionarios") %>">Cadastrar Funcionario</a></li>     
            </ul>
        </li>

        <li class="accordion">
            <h3>Permissoes</h3>
            <ul class="accordionSubItem">
                <li><a href="<%= Url.Action("Index", "Permissoes") %>">Visualizar Permissões</a></li>
                <li><a href="<%= Url.Action("Criar", "Permissoes") %>">Criar Permissão</a></li>     
            </ul>
        </li>

        <li class="accordion">
            <h3>Especialidades</h3>
            <ul class="accordionSubItem">
                <li><a href="<%= Url.Action("Index", "Especialidades") %>">Ver Especialidades</a></li>
                <li><a href="<%= Url.Action("Criar", "Especialidades") %>">Cadastrar Especialidade</a></li>     
            </ul>
        </li>

        <li class="accordion">
            <h3>Pagamentos</h3>
            <ul class="accordionSubItem">
                <li><a href="<%= Url.Action("Index", "Pagamento") %>">Pagamentos a Realizar</a></li>
            </ul>
        </li>
    </ul>


