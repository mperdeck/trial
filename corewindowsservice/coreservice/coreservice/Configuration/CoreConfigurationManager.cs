using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Binder;
using System.Configuration;
using System.Reflection;
using System.ComponentModel.DataAnnotations;

namespace Decideware.Configuration
{
    public class CoreConfigurationManager
    {
        private class NameConnectionString
        {
            public string name { get; set; }
            public string connectionString { get; set; }
        }


        public static IConfiguration Configuration { get; set; }

        public static Dictionary<string, string> AppSettings
        {
            get {
                var value = new Dictionary<string, string>();
                Configuration.GetSection("appSettings").Bind(value);
                return value;
            }
        }

        public static string GetAppSetting(string settingName)
        {
            var appSettings = AppSettings;

            string value;
            if (!appSettings.TryGetValue(settingName, out value))
            {
                string keys = string.Join(";", appSettings.Keys);
                throw new ArgumentException($"Key {settingName} is not in AppSettings. Available keys: {keys}.");
            }

            return value;
        }

        public static T GetSection<T>(string sectionName) where T : new()
        {
            var value = new T();
            var section = Configuration.GetSection(sectionName);
            section.Bind(value);

            //#####################################
            //###### this method doesn't work for IEnumerables          EnforceRequiredStrings(value);

            return value;
        }

        /// <summary>
        /// Determines whether the given property has the default value for the type of the property.
        /// So if the property is of type int, and it has value 0, it has the default value.
        /// Default value for string would be null.
        /// </summary>
        /// <param name="property"></param>
        /// <param name="propertyValue"></param>
        /// <returns>
        /// true if it has the default value, false otherwise.
        /// </returns>
        private static bool PropertyHasDefaultValue(PropertyInfo property, object propertyValue)
        {
            Type propertyType = property.PropertyType;

            if (propertyType.IsValueType)
            {
                object defaultValue = Activator.CreateInstance(propertyType);

                string defaultValueString = Convert.ToString(defaultValue);
                string propertyValueString = Convert.ToString(propertyValue);

                return (defaultValueString == propertyValueString);
            }

            return (propertyValue == null);
        }

        /// <summary>
        /// For all properties in the given options object that have the [Required] attribute,
        /// check if that property has the default value (null for string, 0, for int, etc.)
        /// If it does, throws an exception.
        /// 
        /// This is recursive. If a property is an object with properties of its own, those properties get
        /// checked as well.
        /// </summary>
        /// <param name="options"></param>
    }
}
