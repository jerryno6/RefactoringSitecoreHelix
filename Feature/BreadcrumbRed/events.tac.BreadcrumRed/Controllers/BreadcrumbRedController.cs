using events.tac.BreadcrumbRed.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace events.tac.BreadcrumbRed.Controllers
{
    public class BreadcrumbRedController : Controller
    {
        private readonly BreadcrumbRedBuilder _builder;

        public BreadcrumbRedController() : this(new BreadcrumbRedBuilder())
        {

        }

        public BreadcrumbRedController(BreadcrumbRedBuilder builder)
        {
            _builder = builder;
        }

        // GET: Breadcrum
        public ActionResult Index()
        {
            return View(_builder.Build());
        }
    }
}