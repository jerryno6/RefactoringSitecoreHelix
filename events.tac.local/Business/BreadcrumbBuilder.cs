﻿using events.tac.local.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TAC.Sitecore.Abstractions.Interfaces;
using TAC.Sitecore.Abstractions.SitecoreImplementation;

namespace events.tac.local.Business
{
    public class BreadcrumbBuilder
    {
        private IRenderingContext _context;

        public BreadcrumbBuilder() : this(SitecoreRenderingContext.Create())
        {

        }

        public BreadcrumbBuilder(IRenderingContext renderingContext)
        {
            this._context = renderingContext;
        }

        public IEnumerable<NavigationItem> Build()
        {
            var ancestors = _context.ContextItem.GetAncestors().ToList();
            var b = _context.ContextItem;

            return _context?.HomeItem == null || _context?.ContextItem == null ?
                Enumerable.Empty<NavigationItem>() :
                _context
                    .ContextItem
                    .GetAncestors()
                    .Where(i => _context.HomeItem.IsAncestorOrSelf(i))
                    .Select(i => new NavigationItem
                    (
                        title: i.DisplayName,
                        url: i.Url,
                        active: false
                    ))
                    .Concat(new[]
                    {
                        new NavigationItem
                        (
                            title: _context.ContextItem.DisplayName,
                            url: _context.ContextItem.Url,
                            active:true
                        )
                    });
        }
    }
}