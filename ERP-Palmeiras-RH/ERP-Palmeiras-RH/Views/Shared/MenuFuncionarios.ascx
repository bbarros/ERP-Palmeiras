<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<dynamic>" %>

    <ul>
        <li class="accordion">
            <h3>Funcionarios</h3>
            <ul class="accordionSubItem">
                <li><a href="<%= Url.Action("Index", "Funcionarios") %>">Visualizar Funcionários</a></li>
                <li><a href="<%= Url.Action("Criar", "Funcionarios") %>">Cadastrar Funcionario</a></li>     
            </ul>
        </li>

        <li class="accordion">
            <h3>Cargos</h3>
            <ul class="accordionSubItem">
                <li><a href="<%= Url.Action("Index", "Cargos") %>">Visualizar Cargos</a></li>
                <li><a href="<%= Url.Action("Criar", "Cargos") %>">Cadastrar Cargo</a></li>     
            </ul>
        </li>

        <li class="accordion">
            <h3>Benefícios</h3>
            <ul class="accordionSubItem">
                <li><a href="<%= Url.Action("Index", "Beneficios") %>">Visualizar Benefícios</a></li>
                <li><a href="<%= Url.Action("Criar", "Beneficios") %>">Cadastrar Benefício</a></li>     
            </ul>
        </li>

        <li class="accordion">
            <h3>Permissoes</h3>
            <ul class="accordionSubItem">
                <li><a href="<%= Url.Action("Index", "Permissoes") %>">Visualizar Permissões</a></li>
                <li><a href="<%= Url.Action("Criar", "Permissoes") %>">Cadastrar Permissão</a></li>     
            </ul>
        </li>

        <li class="accordion">
            <h3>Especialidades</h3>
            <ul class="accordionSubItem">
                <li><a href="<%= Url.Action("Index", "Especialidades") %>">Visualizar Especialidades</a></li>
                <li><a href="<%= Url.Action("Criar", "Especialidades") %>">Cadastrar Especialidade</a></li>     
            </ul>
        </li>

        <li class="accordion">
            <h3>Pagamentos</h3>
            <ul class="accordionSubItem">
                <li><a href="<%= Url.Action("Index", "Pagamento") %>">Pagamentos a Realizar</a></li>
            </ul>
        </li>

        <li class="accordion">
            <h3>Pendências</h3>
            <ul class="accordionSubItem">
                <li><a href="<%= Url.Action("Index", "Pendencias") %>">Cadastros Pendentes</a></li>
            </ul>
        </li>
    </ul>


