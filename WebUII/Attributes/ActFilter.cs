using Model.FW.Context;
using Model.FW.DesignPattern;
using Model.FW.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUII.Attributes
{
    public class ActFilter : FilterAttribute, IActionFilter
    {

        AppDbContext db = Singleton.Context;
        CompanyUser user = new CompanyUser();

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Log log = new Log();
            log.ActionName = filterContext.ActionDescriptor.ActionName;
            log.ControllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            if (filterContext.HttpContext.Session["user"] != null)
            {
                user = filterContext.HttpContext.Session["user"] as CompanyUser;
            }
            else
            {
                log.UserName = "cookie";

            }
            log.UserName = user.UserName;
            db.Logs.Add(log);
            db.SaveChanges();
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            throw new NotImplementedException();
        }
    }
}