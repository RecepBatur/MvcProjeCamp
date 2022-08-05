using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
namespace MvcProjeKampi.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin p)
        {
            Context c = new Context();
            var adminUserİnfo = c.Admins.FirstOrDefault(x => x.AdminUserName == p.AdminUserName && x.AdminPassword == p.AdminPassword);
            if (adminUserİnfo != null)
            {
                //sisteme authentica olan kullanıcının bilgisi buradan gelecek.
                FormsAuthentication.SetAuthCookie(adminUserİnfo.AdminUserName, false);
                Session["AdminUserName"] = adminUserİnfo.AdminUserName;
                return RedirectToAction("Index", "AdminCategory");
            }
            else
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}