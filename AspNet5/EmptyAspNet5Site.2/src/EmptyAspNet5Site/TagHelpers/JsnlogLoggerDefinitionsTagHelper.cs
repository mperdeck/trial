using Microsoft.AspNet.Razor.TagHelpers;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmptyAspNet5Site.TagHelpers
{
    public class JsnlogLoggerDefinitionsTagHelper : TagHelper
    {
        // Can be passed via <email mail-to="..." />. 
        // Pascal case gets translated into lower-kebab-case.
        public string RequestId { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "";    // Replaces <email> with <a> tag

            output.Content.SetHtmlContent(
                $@"<ul><li><strong>Version:</strong>dddd</li>
                <li><strong>Copyright Year:</strong>fffff</li>
                <li><strong>Number of tags to show:</strong>ggggg</li>"+ (string.IsNullOrEmpty(RequestId) ? "Request id is null" : RequestId) + "</ul>");
            output.TagMode = TagMode.StartTagAndEndTag;
        }
    }
}
