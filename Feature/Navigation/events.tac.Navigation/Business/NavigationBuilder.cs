﻿

using events.tac.Navigation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TAC.Sitecore.Abstractions.Interfaces;
using TAC.Sitecore.Abstractions.SitecoreImplementation;

namespace events.tac.Navigation.Business
{
    public class NavigationBuilder
    {
        private IRenderingContext _context;

        public NavigationBuilder() : this(SitecoreRenderingContext.Create())
        {
            
        }

        public NavigationBuilder(IRenderingContext renderingContext)
        {
            this._context = renderingContext;
        }

        public NavigationMenuItem Build()
        {
            var root = _context?.DatasourceOrContextItem;
            
            return new NavigationMenuItem
                (
                    title: root?.DisplayName,
                    url : root?.Url,
                    children : root != null && _context?.ContextItem != null ? Build(root, _context.ContextItem) : null
                );
        }

        private IEnumerable<NavigationMenuItem> Build(IItem node, IItem current)
        {
            return node
                .GetChildren()
                .Where(x => x["ExcludeFromNavigation"] != "1")
                .Select(i => new NavigationMenuItem
                (
                    title: i.DisplayName,
                    url: i.Url,
                    children: i.IsAncestorOrSelf(current) ? Build(i, current) : null
                ));
        }


    }
}