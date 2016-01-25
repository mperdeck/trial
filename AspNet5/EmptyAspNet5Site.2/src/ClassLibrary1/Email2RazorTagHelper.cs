using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Razor.Runtime.TagHelpers;
using Microsoft.AspNet.Razor.TagHelpers;

namespace ClassLibrary1
{
    // You may need to install the Microsoft.AspNet.Razor.Runtime package into your project
    [HtmlTargetElement("email2")]
    public class Email2RazorTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";    // Replaces <email> with <a> tag

            output.Attributes["href"] = "mailto:xxx.yyyy";
        }
    }
}
