using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UserIdentity.Controllers
{ //eğer [Authorize]'ı buraya tanımlasak bütün actionlar için üyelik bekler 
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [Authorize]
        public ActionResult About() //eğer [Authorize]=yetki vermek'i buraya tanımlasak About sayfasını da göremezdik
        {
            return View();
        }
    }
}