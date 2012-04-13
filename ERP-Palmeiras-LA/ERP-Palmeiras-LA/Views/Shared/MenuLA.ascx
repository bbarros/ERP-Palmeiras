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
            <h3>Equipamentos</h3>
            <ul class="accordionSubItem">
                <li><a href="<%= Url.Action("Index", "Equipamentos") %>">Visualizar Equipamentos</a></li>
                <li><a href="<%= Url.Action("Criar", "Equipamentos") %>">Cadastrar Equipamento</a></li> 
                <li><a href="<%= Url.Action("SolicitarManutencao", "Equipamentos") %>">Solicitar Manutenção</a></li>    
            </ul>
        </li>

        <li class="accordion">
            <h3>Fabricantes</h3>
            <ul class="accordionSubItem">
                <li><a href="<%= Url.Action("Index", "Fabricantes") %>">Visualizar Fabricantes</a></li>
                <li><a href="<%= Url.Action("Criar", "Fabricantes") %>">Cadastrar Fabricante</a></li>     
            </ul>
        </li>

        <form id="FormLogoff" action="<%= Url.Action("Logout","Home") %>" method="post" style="padding-left: 35%"><input id="logoffSubmit" name="Logout" type="submit" value=" Logout " /></form> 
    </ul>


