using events.tac.Navigation.Business;
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