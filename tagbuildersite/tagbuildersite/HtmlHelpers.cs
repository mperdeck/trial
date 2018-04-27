using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tagbuildersite
{
    public static class HtmlHelpers
    {
        public static IHtmlContent DropDownGroupList(this IHtmlHelper htmlHelper, string name)
        {
            TagBuilder tagBuilder = new TagBuilder("select");

            // Make optionLabel the first item that gets rendered.
                tagBuilder.InnerHtml.AppendHtml(ListItemToOption("abc123"));
            tagBuilder.InnerHtml.AppendHtml(ListItemToOption("abc124"));
            tagBuilder.InnerHtml.AppendHtml(ListItemToOption("abc125"));


            IHtmlContent hc = new HtmlString("<b>2222kkkkkkk</b>");
            tagBuilder.InnerHtml.AppendHtml("<b>kkkkkkk</b>");//##################
            tagBuilder.InnerHtml.AppendHtml(new HtmlString("<b>3333kkkkkkk</b>"));//##################
            tagBuilder.InnerHtml.AppendHtml(hc);//##################

            //var listHtml = new HtmlContentBuilder();
            //listHtml.AppendHtml("<ol><li>");
            //listHtml.AppendHtml(helper.ActionLink("foo", "bar", "example"));
            //listHtml.AppendHtml("</li></ol>");


            return tagBuilder;

        }

        internal static IHtmlContent ListItemToOption(string item)
        {
            TagBuilder builder = new TagBuilder("option");
            builder.InnerHtml.AppendHtml(item);
            if (item != null)
            {
                builder.Attributes["value"] = item;
            }

            return builder;
        }
    }
}
