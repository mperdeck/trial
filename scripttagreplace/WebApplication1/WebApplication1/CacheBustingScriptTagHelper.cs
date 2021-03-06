
// C:\Temp\script tag helper\TagHelpers\CacheBustingScriptTagHelper.cs
//##################################



using System.Linq;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.Extensions.Caching.Memory;
using WebApplication1;

namespace Decideware.Platform.Applications.Web.TagHelpers
{


    [HtmlTargetElement("script")]
    public class CacheBustingScriptTagHelper : ScriptTagHelper
    {
        ISiteInfo _siteInfo;


        public CacheBustingScriptTagHelper(
                    ISiteInfo siteInfo,
                    IHostingEnvironment hostingEnvironment,
                    IMemoryCache cache,
                    HtmlEncoder htmlEncoder,
                    JavaScriptEncoder javaScriptEncoder,
                    IUrlHelperFactory urlHelperFactory) : base(
                        hostingEnvironment,
                        cache,
                        htmlEncoder,
                        javaScriptEncoder,
                        urlHelperFactory)
        {
            _siteInfo = siteInfo;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string srcAttribute = (string)context.AllAttributes["src"].Value;

            bool applyCacheBusting = 
            (srcAttribute != null) &&
            (!srcAttribute.StartsWith("http")) &&
            (!srcAttribute.Contains("jquery")) &&
            (!srcAttribute.Contains("bootstrap")) &&
            (!srcAttribute.Contains("jsnlog"));

            if (applyCacheBusting)
            {

                
                // AppendVersion option appends a query string parameter with the version number of the script file.
                // That version number is essentially a hash over the contents of the file.

                //#############################

                    //const string appendVersion = "asp-append-version";
                    //if (!context.AllAttributes.Any(a => a.Name == appendVersion))
                    //{
                    var attributes = new TagHelperAttributeList();
                    attributes.Add("src", $"{srcAttribute}?v={_siteInfo.GetVersion}");
                    context = new TagHelperContext(attributes, context.Items, context.UniqueId);
                    //} // E

                    //base.AppendVersion = true; // C
           }
            base.Process(context, output); // D

        }
    }
}



