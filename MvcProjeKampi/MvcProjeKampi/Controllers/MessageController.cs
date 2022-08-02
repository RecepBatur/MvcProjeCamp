using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class MessageController : Controller
    {
       MessageManager mm = new MessageManager(new EfMessageDal())
        public ActionResult Inbox()
        {
            return View();
        }
    }
}