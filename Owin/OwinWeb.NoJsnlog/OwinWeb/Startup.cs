using Microsoft.Owin;
using System.Collections.Generic;
using System.Linq;
using System;
using Owin;
using System.Threading.Tasks;
using System.IO;


[assembly: OwinStartupAttribute(typeof(OwinWeb.Startup))]
namespace OwinWeb
{
    using AppFunc = Func<IDictionary<string, object>, Task>;

    public partial class Startup
    {

        public void Configuration(IAppBuilder app)
        {
            var middleware = new Func<AppFunc, AppFunc>(MyMiddleWare);
            app.Use(middleware);

            ConfigureAuth(app);
        }

        public AppFunc MyMiddleWare(AppFunc next)
        {
            AppFunc appFunc = async (IDictionary<string, object> environment) =>
            {
                // Do something with the incoming request:
                var response = environment["owin.ResponseBody"] as Stream;
                using (var writer = new StreamWriter(response))
                {
                    await writer.WriteAsync("<h1>Hello from My First Middleware</h1>");
                }
                // Call the next Middleware in the chain:
                await next.Invoke(environment);
            };
            return appFunc;
        }
    }
}
