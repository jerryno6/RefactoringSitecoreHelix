using System;

namespace TAC.Sitecore.Models
{
    public class NavigationItem
    {
        public NavigationItem(string title, string url, bool active = false)
        {
            Title = title;
            URL = url;
            Active = active;
        }

        public string Title { get; protected set; }

        public string URL { get; protected set; }

        public bool Active { get; protected set; }
    }
}
