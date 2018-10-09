using System;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace ttt
{
    public static class MenuHelper
    {
        public static MvcHtmlString BS_navbar_item(this HtmlHelper htmlHelper, string linkText, string actionName, string controllerName)
        {
            string currentAction = htmlHelper.ViewContext.RouteData.GetRequiredString("action");
            string currentController = htmlHelper.ViewContext.RouteData.GetRequiredString("controller");

            var ulTag = new TagBuilder("li");
            ulTag.AddCssClass("navbar-item");

            if (actionName == currentAction && controllerName == currentController)
                ulTag.InnerHtml = htmlHelper.ActionLink(linkText, actionName, controllerName, null, new { @class = "nav-link text-dark active" }).ToHtmlString();
            else
                ulTag.InnerHtml = htmlHelper.ActionLink(linkText, actionName, controllerName, null, new { @class = "nav-link text-dark" }).ToHtmlString();

            return MvcHtmlString.Create(ulTag.ToString());
        }

        public static MvcHtmlString RatingStars(this HtmlHelper htmlHelper, double value)
        {
            var div = new TagBuilder("div");
            div.MergeAttribute("title", "Rating: "+ value.ToString());

            int val = (int)value;
            for (int i = 10; i > 0; i--)
            {
                var span = new TagBuilder("span");
                span.AddCssClass("fa fa-star");
                if (i>(10-val))
                    span.AddCssClass("checked");
                div.InnerHtml += span;
            }

            return MvcHtmlString.Create(div.ToString());
        }
    }
}
