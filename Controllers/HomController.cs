using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCDemo.Controllers
{
    public class HomController : Controller
    {
        // GET: Hom

        public string Index(string id, string name)
        {
            return "Id = " + id + " ,Name = " + Request.QueryString["name"];
        }

    }
}