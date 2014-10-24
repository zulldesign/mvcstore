﻿using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcstore.Models;

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
        // GET: /Store/Details/5

        public string Details(int id)
        {
            string message = "Store.Details, ID = " + id;
            return message;
        }

    }
}
