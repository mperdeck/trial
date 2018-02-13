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

    private static object GetDefaultValue(Type t)
    {
        if (t.IsValueType)
            return Activator.CreateInstance(t);

        return null;
    }

    private static void EnforceRequiredStrings(object options)// <<<<<<<<<<<<<<
    {
        var properties = options.GetType().GetTypeInfo().DeclaredProperties;

        foreach (var property in properties)
        {
            // Check if the property is an object with its own properties
            if ((property.PropertyType != typeof(string)) && (property.PropertyType.BaseType.FullName == "System.Object"))
            {
                EnforceRequiredStrings(property.GetValue(options));
            }
            else
            {
                bool isRequired = property.GetType().CustomAttributes.Any(a => a.AttributeType == typeof(RequiredAttribute));

                if (isRequired)
                {
                    // Default value of string is null, for int is 0, etc.
                    // This means a required int field cannot have value 0.
                    if (property.GetValue(options) == GetDefaultValue(property.GetType()))
                    {
                        throw new ArgumentNullException(property.Name);
                    }
                }
            }
        }

        //var properties = options.GetType().GetTypeInfo().DeclaredProperties.Where(p => p.PropertyType == typeof(string));
        //var requiredProperties = properties.Where(p => p.CustomAttributes.Any(a => a.AttributeType == typeof(RequiredAttribute)));

        //foreach (var property in requiredProperties)
        //{
        //    if (string.IsNullOrEmpty((string)property.GetValue(options)))
        //        throw new ArgumentNullException(property.Name);
        //}
    }


}
