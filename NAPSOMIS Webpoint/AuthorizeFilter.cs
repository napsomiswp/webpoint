using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NAPSOMIS_Webpoint.Models;
using NAPSOMIS_Webpoint.ViewModels;
using System.Data;
using System.Configuration;

namespace NAPSOMIS_Webpoint
    {
    public class AuthorizeFilterAttribute : ActionFilterAttribute
        {


        private void Trace(string methodname, System.Web.Routing.RouteData routeData)
            {
            string controllername = routeData.Values["controller"].ToString();
            string actionMethodname = routeData.Values["action"].ToString();
            
            }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
            {
            //string logonname = new GetUserLogonStatus().UserName();

            //if (logonname == "")
            //    {
            //    filterContext.Canceled = true;

            //    //ViewResult vr = new ViewResult();
            //    //vr.ViewName = "Accounts/Login";
                
            //    //filterContext.Result = vr;

            //    //filterContext.Result = new HttpUnauthorizedResult();

            //    }

            base.OnActionExecuted(filterContext);

            }
 
        public override void OnActionExecuting(ActionExecutingContext filterContext)
            {
            base.OnActionExecuting(filterContext);
            }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
            {
            base.OnResultExecuted(filterContext);
            }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
            {
            base.OnResultExecuting(filterContext);
            }
        }
    }