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
        // GET: /Store/Browse?genre=Disco

        public string Browse(string genre)
        {
            string message = HttpUtility.HtmlEncode("Store.Browse, Genre = " + genre);
            return message;
        }

        //
        // GET: /Store/Details

        public string Details()
        {
            return "Hello From Store.Details()";
        }

    }
}
