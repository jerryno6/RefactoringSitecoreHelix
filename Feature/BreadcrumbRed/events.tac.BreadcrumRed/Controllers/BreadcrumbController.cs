using events.tac.BreadcrumbRed.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace events.tac.BreadcrumbRed.Controllers
{
    public class BreadcrumbController : Controller
    {
        private readonly BreadcrumbBuilder _builder;

        public BreadcrumbController() : this(new BreadcrumbBuilder())
        {

        }

        public BreadcrumbController(BreadcrumbBuilder builder)
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