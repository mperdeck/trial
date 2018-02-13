using System;
using System.IO;
using Microsoft.Extensions.Configuration;

// <<<<<<<<<<<<<<
using System.Reflection;
using System.Linq;
using System.ComponentModel.DataAnnotations;


public class Program
{
    public static void Main(string[] args = null)
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");

        var config = builder.Build();

        var appConfig = new AppSettings();
        config.GetSection("App").Bind(appConfig);

        EnforceRequiredStrings(appConfig);// <<<<<<<<<<<<<<


        // --------------------

        Console.WriteLine($"Height {appConfig.Window.Height}");
        Console.WriteLine();

        Console.WriteLine("Press a key...");
        Console.ReadKey();
    }

    private static void EnforceRequiredStrings(object options)// <<<<<<<<<<<<<<
    {
        var properties = options.GetType().GetTypeInfo().DeclaredProperties.Where(p => p.PropertyType == typeof(string));
        var requiredProperties = properties.Where(p => p.CustomAttributes.Any(a => a.AttributeType == typeof(RequiredAttribute)));

        foreach (var property in requiredProperties)
        {
            if (string.IsNullOrEmpty((string)property.GetValue(options)))
                throw new ArgumentNullException(property.Name);
        }
    }


}
