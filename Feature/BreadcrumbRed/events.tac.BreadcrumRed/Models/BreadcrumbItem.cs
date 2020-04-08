using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace events.tac.BreadcrumbRed.Models
{
    public class BreadcrumbItem : TAC.Sitecore.Models.NavigationItem
    {
        public BreadcrumbItem(string title, string url, bool active = false) : base(title, url, active)
        {

        }

    }
}