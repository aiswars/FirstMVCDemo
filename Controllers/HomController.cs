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
        // public ActionResult Index() //as no view for Index()action method in Views Folder
        public String Index()
        {
            return "Hello MVC 5 Application";
        }
    }
}