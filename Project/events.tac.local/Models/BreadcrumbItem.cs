namespace events.tac.local.Models
{
    public class BreadcrumbItem : TAC.Sitecore.Models.NavigationItem
    {
        public BreadcrumbItem(string title, string url, bool active = false) : base(title, url, active)
        {

        }

    }
}