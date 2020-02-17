using events.tac.local.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace events.tac.local.Controllers
{
    public class NavigationController : Controller
    {
        NavigationBuilder _builder;

        public NavigationController() : this(new NavigationBuilder())
        {

        }

        public NavigationController(NavigationBuilder builder)
        {
            _builder = builder;
        }

        // GET: Navigation
        public ActionResult Index()
        {
            return View(_builder.Build());
        }
    }
}