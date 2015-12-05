using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Authentication.Facebook;
using Microsoft.AspNet.Authentication.Google;
using Microsoft.AspNet.Authentication.MicrosoftAccount;
using Microsoft.AspNet.Authentication.Twitter;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Diagnostics;
using Microsoft.AspNet.Diagnostics.Entity;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Routing;
using Microsoft.Data.Entity;
using Microsoft.Framework.Configuration;
using Microsoft.Framework.DependencyInjection;
using Microsoft.Framework.Logging;
using Microsoft.Framework.Logging.Console;
using Microsoft.Framework.Runtime;
using Fresh2.Models;
using Fresh2.Services;

//###################
using Microsoft.Framework.OptionsModel;
using JSNLog;
using System.Xml.Serialization;


//###################
//,
//    "dnxcore50": { }



namespace Fresh2
{
    public class Startup
    {
        public class AppSettings
        {
            public string SiteTitle { get; set; }
        }

        public class TestSubConfig
        {
            public string s1 { get; set; }
            public string s2 { get; set; }
        }

        public class TestConfig
        {
            public string st1 { get; set; }
            public int it2 { get; set; }
            public Dictionary<string, TestSubConfig> d1 { get; set; }
            public List<TestSubConfig> dl1 { get; set; }
        }




        public class Logger2a
        {
            public string appenders { get; set; }

            public string name { get; set; }
        }

        public class JsnlogConfiguration2 /* : ICanCreateJsonFields*/
        {
            //[XmlAttribute]
            //public bool enabled { get; set; }

            [XmlAttribute]
            public uint maxMessages { get; set; }

            //[XmlAttribute]
            //public string defaultAjaxUrl { get; set; }

            //[XmlAttribute]
            //public string corsAllowedOriginsRegex { get; set; }

            //[XmlAttribute]
            //public string serverSideLogger { get; set; }

            //[XmlAttribute]
            //public string serverSideLevel { get; set; }

            //[XmlAttribute]
            //public string serverSideMessageFormat { get; set; }

            //[XmlAttribute]
            //public string dateFormat { get; set; }

            //[XmlAttribute]
            //public string productionLibraryPath { get; set; }

            //[XmlElement("logger")]
            //public List<Logger> loggers = new List<Logger>();


            public List<Logger2a> logger2s { get; set; }
            //            public List<Logger2a> logger2s = new List<Logger2a>();


            //[XmlElement("ajaxAppender")]
            //public List<AjaxAppender> ajaxAppenders = new List<AjaxAppender>();

            //[XmlElement("consoleAppender")]
            //public List<ConsoleAppender> consoleAppenders = new List<ConsoleAppender>();

            //public JsnlogConfiguration2()
            //{
            //    // Set default values. If an element is not given in the XML or JSON,
            //    // the deserializer will simply not set it.
            //    enabled = true;
            //    maxMessages = int.MaxValue;
            //    serverSideMessageFormat = "%message";
            //    dateFormat = "o";

            //    // Do not set default for defaultAjaxUrl here. Its default is set in jsnlog.js.
            //}
        }













        public Startup(IHostingEnvironment env, IApplicationEnvironment appEnv)
        {
            // Setup configuration sources.

            var builder = new ConfigurationBuilder(appEnv.ApplicationBasePath)
                .AddJsonFile("config.json")
                .AddJsonFile($"config.{env.EnvironmentName}.json", optional: true);

            if (env.IsDevelopment())
            {
                // This reads the configuration keys from the secret store.
                // For more details on using the user secret store see http://go.microsoft.com/fwlink/?LinkID=532709
                builder.AddUserSecrets();
            }
            builder.AddEnvironmentVariables();
            Configuration = builder.Build();





            //var configuration = new ConfigurationBuilder()
            //    .AddInMemoryCollection(
            //        new Dictionary<string, string>
            //        {
            //            {"DynamoDB:AccessKey", "access-key"},
            //            {"DynamoDB:SecretKey", "secret-key"}
            //        })
            //    .Build();

            //var services = new ServiceCollection();
            //services.Configure<DynamoCredentials>(configuration.GetSection("DynamoDB"));
            //services.AddOptions();
            //var serviceProvider = services.BuildServiceProvider();



        }

        public IConfiguration Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add Entity Framework services to the services container.
            services.AddEntityFramework()
                .AddSqlServer()
                .AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlServer(Configuration["Data:DefaultConnection:ConnectionString"]));

            // Add Identity services to the services container.
            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            // Configure the options for the authentication middleware.
            // You can add options for Google, Twitter and other middleware as shown below.
            // For more information see http://go.microsoft.com/fwlink/?LinkID=532715
            services.Configure<FacebookAuthenticationOptions>(options =>
            {
                options.AppId = Configuration["Authentication:Facebook:AppId"];
                options.AppSecret = Configuration["Authentication:Facebook:AppSecret"];
            });

            services.Configure<MicrosoftAccountAuthenticationOptions>(options =>
            {
                options.ClientId = Configuration["Authentication:MicrosoftAccount:ClientId"];
                options.ClientSecret = Configuration["Authentication:MicrosoftAccount:ClientSecret"];
            });

            // Add MVC services to the services container.
            services.AddMvc();

            // Uncomment the following line to add Web API services which makes it easier to port Web API 2 controllers.
            // You will also need to add the Microsoft.AspNet.Mvc.WebApiCompatShim package to the 'dependencies' section of project.json.
            // services.AddWebApiConventions();

            // Register application services.
            services.AddTransient<IEmailSender, AuthMessageSender>();
            services.AddTransient<ISmsSender, AuthMessageSender>();


            //##################
            services.Configure<AppSettings>(Configuration.GetConfigurationSection("AppSettings"));
            services.Configure<TestConfig>(Configuration.GetConfigurationSection("JSNLog2"));
            services.Configure<JsnlogConfiguration>(Configuration.GetConfigurationSection("JSNLog"));



            
        }

        // Configure is called after ConfigureServices is called.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory,
                    /*###############*/          IOptions<AppSettings> appSettings,
                    /*###############*/          IOptions<TestConfig> testConfig,
                    /*###############*/          IOptions<JsnlogConfiguration> jsnlogConfiguration)
        {


            //###################
            var name = appSettings.Options.SiteTitle;
            var st1v = testConfig.Options.st1;
            var it2v = testConfig.Options.it2;
            var tc = testConfig.Options;
            var jc = jsnlogConfiguration.Options;



            loggerFactory.MinimumLevel = LogLevel.Information;
            loggerFactory.AddConsole();

            // Configure the HTTP request pipeline.

            // Add the following to the request pipeline only in development environment.
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseErrorPage(ErrorPageOptions.ShowAll);
                app.UseDatabaseErrorPage(DatabaseErrorPageOptions.ShowAll);
            }
            else
            {
                // Add Error handling middleware which catches all application specific errors and
                // sends the request to the following path or controller action.
                app.UseErrorHandler("/Home/Error");
            }

            // Add static files to the request pipeline.
            app.UseStaticFiles();

            // Add cookie-based authentication to the request pipeline.
            app.UseIdentity();

            // Add authentication middleware to the request pipeline. You can configure options such as Id and Secret in the ConfigureServices method.
            // For more information see http://go.microsoft.com/fwlink/?LinkID=532715
            // app.UseFacebookAuthentication();
            // app.UseGoogleAuthentication();
            // app.UseMicrosoftAccountAuthentication();
            // app.UseTwitterAuthentication();

            // Add MVC to the request pipeline.
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

                // Uncomment the following line to add a route for porting Web API 2 controllers.
                // routes.MapWebApiRoute("DefaultApi", "api/{controller}/{id?}");
            });
        }
    }
}
