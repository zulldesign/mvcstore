using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcstore.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/

        public string Index()
        {
            return "Hello From Store.Index()";
        }

        //
        // GET: /Store/Browse

        public string Browse()
        {
            return "Hello From Store.Browse()";
        }

        //
        // GET: /Store/Details

        public string Details()
        {
            return "Hello From Store.Details()";
        }

    }
}
