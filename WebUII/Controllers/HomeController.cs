using Model.FW.Entity;
using Service.FW.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebUII.Attributes;
using WebUII.Model.ViewModels;

namespace WebUII.Controllers
{
    
    public class HomeController : Controller
    {

        CompanyUserService companyUserService = new CompanyUserService();

        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
               return View();
        }
        [HttpPost]
        [ActFilter]
        public ActionResult Login(LoginVM login)
        {
            if (ModelState.IsValid)
            {
                if (companyUserService.Any(x => x.UserName == login.UserName))
                {

                    var result = companyUserService.UserLogin(login.UserName, login.Password);



                    if (result)
                    {
                        CompanyUser user = companyUserService.GetDefault(x => x.UserName == login.UserName && x.Password == login.Password).FirstOrDefault();

                        Session["user"] = user;

                        //Cookie
                        FormsAuthentication.SetAuthCookie(user.UserName, true);


                        return RedirectToAction("Index");
                    }
                    else
                    {
                       
                        return View();
                    }
                }
                else
                {
                    return View();
                }
            }
            else
            {
                return View();
            }
        }
        public ActionResult LogOut(CompanyUser user)
        {
            if (user != null)
            {
                Session.Remove("user");
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }


    }
}