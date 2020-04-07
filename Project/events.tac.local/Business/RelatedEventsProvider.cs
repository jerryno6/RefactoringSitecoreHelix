using events.tac.local.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAC.Sitecore.Abstractions.Interfaces;
using TAC.Sitecore.Abstractions.SitecoreImplementation;

namespace events.tac.local.Business
{
    public class RelatedEventsProvider
    {
        private IRenderingContext _context;

        public RelatedEventsProvider() : this(SitecoreRenderingContext.Create())
        {

        }

        public RelatedEventsProvider(IRenderingContext renderingContext)
        {
            this._context = renderingContext;
        }

        public IEnumerable<NavigationItem> GetRelatedEvents()
        {
            return _context
                .ContextItem
                .GetMultilistFieldItems("relatedEvents")
                .Select(i => new NavigationItem
                (
                    title: i.DisplayName,
                    url: i.Url
                ));
        }
    }
}
