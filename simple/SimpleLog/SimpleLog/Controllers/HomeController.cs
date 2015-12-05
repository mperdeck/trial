using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Web.Configuration;
using System.Configuration;
using System.Xml;

using System.Diagnostics;

namespace SimpleLog.Controllers.Home
{
    // See http://www.codeproject.com/Articles/50117/Extend-ConfigurationElement-to-Deserialize-Text-El

    //public class ValuedElement : ConfigurationElement
    //{
    //    [ConfigurationProperty("value")]
    //    public String Value { get { return this["value"].ToString(); } }
    //}

    //public class AppenderRef : ConfigurationElement
    //{
    //    [ConfigurationProperty("ref")]
    //    public String Ref { get { return this["ref"].ToString(); } }
    //}

    //public class Root : ConfigurationElement
    //{
    //    [ConfigurationProperty("level")]
    //    public ValuedElement Level { get { return (ValuedElement)this["level"]; } }

    //    [ConfigurationProperty("appender-ref")]
    //    public AppenderRef Level { get { return (AppenderRef)this["appender-ref"]; } }
    //}

    //public class Logger : ConfigurationElement
    //{
    //    [ConfigurationProperty("name")]
    //    public String Name { get { return this["name"].ToString(); } }

    //    [ConfigurationProperty("level")]
    //    public ValuedElement Level { get { return (ValuedElement)this["level"]; } }

    //    [ConfigurationProperty("appender-ref")]
    //    public AppenderRef Level { get { return (AppenderRef)this["appender-ref"]; } }
    //}

    //public class Log4Javascript4Net : ConfigurationSection
    //{
    //    //[ConfigurationProperty("element1")]
    //    //public Element1 Element1 { get { return (Element1)this["element1"]; } }
    //}

    public class Log4NetConfigurationSectionHandler : IConfigurationSectionHandler
    {
        #region Public Instance Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Log4NetConfigurationSectionHandler"/> class.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Default constructor.
        /// </para>
        /// </remarks>
        public Log4NetConfigurationSectionHandler()
        {
        }

        #endregion Public Instance Constructors

        #region Implementation of IConfigurationSectionHandler

        /// <summary>
        /// Parses the configuration section.
        /// </summary>
        /// <param name="parent">The configuration settings in a corresponding parent configuration section.</param>
        /// <param name="configContext">The configuration context when called from the ASP.NET configuration system. Otherwise, this parameter is reserved and is a null reference.</param>
        /// <param name="section">The <see cref="XmlNode" /> for the log4net section.</param>
        /// <returns>The <see cref="XmlNode" /> for the log4net section.</returns>
        /// <remarks>
        /// <para>
        /// Returns the <see cref="XmlNode"/> containing the configuration data,
        /// </para>
        /// </remarks>
        public object Create(object parent, object configContext, XmlNode section)
        {
            return section;
        }

        #endregion Implementation of IConfigurationSectionHandler
    }


    



    public class HomeController : Controller
    {
        private void ProcessNode(XmlNode xe2)
        {
            Debug.Print("---------------");
            if (!(xe2 is XmlElement))
            {
                Debug.Print("Not element - " + xe2.InnerXml);
                return;
            }

            XmlElement xe = xe2 as XmlElement;
            
            Debug.Print(xe.Name);

            foreach (XmlAttribute xa in xe.Attributes)
            {
                Debug.Print(xa.Name + " = " + xa.Value);
            }

            Debug.IndentLevel += 5;

            foreach (XmlNode child in xe.ChildNodes)
            {
                ProcessNode(child);
            }

            Debug.IndentLevel -= 5;

        }



        //
        // GET: /Default/

        public ActionResult Index()
        {

       //     Log4Javascript4Net cs = (Log4Javascript4Net)WebConfigurationManager.GetSection("log4javascript4net");
            XmlElement xe = WebConfigurationManager.GetSection("log4javascript4net") as XmlElement;

            string s1 = xe.Name;

            ProcessNode(xe);





            return View();
        }

    }
}
