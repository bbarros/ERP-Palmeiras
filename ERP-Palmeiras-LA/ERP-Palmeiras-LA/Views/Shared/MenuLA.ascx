﻿<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<dynamic>" %>

    <ul>
        <li class="accordion">
            <h3>Materiais</h3>
            <ul class="accordionSubItem">
                <li><a href="<%= Url.Action("Index", "Materiais") %>">Visualizar Materiais</a></li>
                <li><a href="<%= Url.Action("Criar", "Materiais") %>">Cadastrar Materiais</a></li>
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

        <li class="accordion">
            <h3>Compra de Equipamentos</h3>
            <ul class="accordionSubItem">
                <li><a href="<%= Url.Action("Criar", "SolicitacoesCompraEquipamentos") %>">Cadastrar Solicitação</a></li>     
                <li><a href="<%= Url.Action("Pendencias", "SolicitacoesCompraEquipamentos") %>">Solicitações Pendentes</a></li>
                <li><a href="<%= Url.Action("Aprovadas", "SolicitacoesCompraEquipamentos") %>">Solicitações Aprovadas</a></li>
                <li><a href="<%= Url.Action("Reprovadas", "SolicitacoesCompraEquipamentos") %>">Solicitações Reprovadas</a></li>
                <li><a href="<%= Url.Action("Index", "SolicitacoesCompraEquipamentos") %>">Todas as Solicitações</a></li>
                
                <li><a href="<%= Url.Action("Solicitadas", "CompraEquipamentos") %>">Compras Solicitadas</a></li> 
                <li><a href="<%= Url.Action("Entregas", "CompraEquipamentos") %>">Compras Entregues</a></li> 
                <li><a href="<%= Url.Action("Index", "CompraEquipamentos") %>">Todas as Compras</a></li> 
            </ul>
        </li>

        <li class="accordion">
            <h3>Inventário</h3>
            <ul class="accordionSubItem">
                <li><a href="<%= Url.Action("Quebrados", "EquipamentosClinica") %>">Equipamentos Quebrados</a></li>     
                <li><a href="<%= Url.Action("Funcionando", "EquipamentosClinica") %>">Equipamentos Funcionando</a></li>     
                <li><a href="<%= Url.Action("Index", "EquipamentosClinica") %>">Todos os Equipamentos</a></li>
            </ul>
        </li>

    </ul>


