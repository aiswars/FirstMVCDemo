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
        public string Index(int id)
        {
            return "The value of  Id = " + id;
        }

    }
}