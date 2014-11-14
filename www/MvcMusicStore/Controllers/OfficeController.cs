using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Facebook;
using Facebook.Web.Mvc;
using Facebook.Web;

namespace MvcMusicStore.Controllers
{
    public class OfficeController : Controller
    {
        //
        // GET: /Office/

        public ActionResult Index()
        {
            return View();
        }

    }
}
