using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewsDemo.Models;

namespace ViewsDemo.Controllers
{
    public class PictureController : Controller
    {
        public ActionResult Index()
        { 
            /*backed code here (database calls, api calls ....)*/
            return View(new List<Picture>() {
                new Picture{Id=1,DisplayName="asd",Url="http://asd"},
                new Picture{Id=2,DisplayName="qwe",Url="http://qwe"},
            });
        }
    }
}