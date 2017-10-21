using Glass.Mapper.Sc;
using PlaySitecore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PlaySitecore.Controllers
{
    public class HomeController : Controller
    {
        ISitecoreContext _context;
        public HomeController(ISitecoreContext context)
        {
            _context = context;
        }
        // GET: Home
        public ActionResult Index()
        {         
            var model = _context.GetCurrentItem<Home>();
            return View(model);
        }
    }
}