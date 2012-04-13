<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<% if (ViewBag.resposta)
    { %>

    Solicitação de Pagamento enviada ao setor financeiro!

<% }
    else 
    { %>

    Ocorreu um erro ao enviar a solicitação ao Módulo Financeiro!

<% } %>
