using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using ERP_Palmeiras_BI.Core;

namespace ERP_Palmeiras_BI.Controllers
{
    public class HandleERPException : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            if (filterContext == null)
            {
                throw new ArgumentNullException("filterContext");
            }

            if (!filterContext.ExceptionHandled && filterContext.HttpContext.IsCustomErrorEnabled)
            {
                Exception innerException = filterContext.Exception;
                string controllerName = (string)filterContext.RouteData.Values["controller"];
                string actionName = (string)filterContext.RouteData.Values["action"];
                // Preserve old ViewData here
                ViewDataDictionary viewData = new ViewDataDictionary(filterContext.Controller.ViewData);
                // Set the Exception information model here
                if (innerException is ERPException)
                {
                    viewData["Message"] = filterContext.Exception.Message;
                }
                else
                {
                    viewData["Message"] = "Ocorreu um erro inesperado: " + filterContext.Exception.Message;
                }
                filterContext.Result = new ViewResult { ViewName = this.View, MasterName = this.Master, ViewData = viewData, TempData = filterContext.Controller.TempData };
                filterContext.ExceptionHandled = true;
                filterContext.HttpContext.Response.Clear();
                filterContext.HttpContext.Response.StatusCode = 500;
                filterContext.HttpContext.Response.TrySkipIisCustomErrors = true;
            }

            base.OnException(filterContext);
        }
    }
}
