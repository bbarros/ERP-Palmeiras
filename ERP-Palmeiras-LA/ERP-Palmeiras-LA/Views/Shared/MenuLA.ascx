<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<dynamic>" %>

    <ul>
        <li class="accordion">
            <h3>Materiais</h3>
            <ul class="accordionSubItem">
                <li><a href="<%= Url.Action("Criar", "Materiais") %>">Cadastrar Materiais</a></li>
            </ul>
        </li>

         <li class="accordion">
            <h3>Equipamentos</h3>
            <ul class="accordionSubItem">
                <li><a href="<%= Url.Action("Index", "Equipamentos") %>">Visualizar Equipamentos</a></li>
                <li><a href="<%= Url.Action("Criar", "Equipamentos") %>">Cadastrar Equipamento</a></li>     
            </ul>
        </li>

        <li class="accordion">
            <h3>Fabricantes</h3>
            <ul class="accordionSubItem">
                <li><a href="<%= Url.Action("Index", "Fabricantes") %>">Visualizar Fabricantes</a></li>
                <li><a href="<%= Url.Action("Criar", "Fabricantes") %>">Cadastrar Fabricante</a></li>     
            </ul>
        </li>

        <li class="accordion">
            <h3>Compra de Equipamentos</h3>
            <ul class="accordionSubItem">
                <li><a href="<%= Url.Action("Index", "SolicitacoesCompraEquipamentos") %>">Visualizar Solicitações</a></li>
                <li><a href="<%= Url.Action("Criar", "SolicitacoesCompraEquipamentos") %>">Cadastrar Solicitação</a></li>     
            </ul>
        </li>
    </ul>


