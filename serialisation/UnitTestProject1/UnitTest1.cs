using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Xml.Serialization;
using System.Web.Script.Serialization;
using System.IO;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        static T DeserialiseXml<T>(string text)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(T));
            var stringReader = new StringReader(text);
            T result = (T)deserializer.Deserialize(stringReader);
            return result;
        }

        static T DeserialiseJson<T>(string text)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            T result = js.Deserialize<T>(text);
            return result;
        }

        [TestMethod]
        public void TestMethod1()
        {
            string text1 = @"
<jsnlog 
    serverSideLogger=""jslogger""  enabled=""false"">

</jsnlog>
";

            //  maxMessages=""5""
            //  enabled=""true""


            JsnlogConfiguration options1 = DeserialiseXml<JsnlogConfiguration>(text1);

            // ---------------------------------------------

            string text2 = @"
<jsnlog serverSideLogger=""jslogger""  enabled=""false"">

    <logger name=""a.b"" level=""INFO"" />
    <logger name=""a2.b"" level=""DEBUG"" />
</jsnlog>
";

            //  maxMessages=""5""
            //  enabled=""true""


            JsnlogConfiguration options2 = DeserialiseXml<JsnlogConfiguration>(text2);

            // ---------------------------------------------

            string text3 = @"
<jsnlog serverSideLogger=""jslogger""  enabled=""false"">

    <logger name=""a.b"" level=""INFO"" />
    <logger name=""a2.b"" level=""DEBUG"">
        <onceOnly regex=""regular expression"" />
        <onceOnly regex=""regular expression2"" />
    </logger>
</jsnlog>
";

            //  maxMessages=""5""
            //  enabled=""true""


            JsnlogConfiguration options3 = DeserialiseXml<JsnlogConfiguration>(text3);

            // ---------------------------------------------

            string text4 = @"
<jsnlog serverSideLogger=""jslogger"" enabled=""false"">

    <logger name=""a.b"" level=""INFO"" />

    <ajaxAppender name=""ajaxAppender"" bufferSize=""-6"" />
    <ajaxAppender name=""ajaxAppender"" />
    <logger appenders=""ajaxAppender;consoleAppender"" />

    <consoleAppender name=""consoleAppender"" storeInBufferLevel=""ERROR"" />


    <logger name=""a2.b"" level=""DEBUG"">
        <onceOnly regex=""regular expression"" />
        <onceOnly regex=""regular expression2"" />
    </logger>



</jsnlog>
";

            //  maxMessages=""5""
            //  enabled=""true""


            JsnlogConfiguration options4 = DeserialiseXml<JsnlogConfiguration>(text4);

            // ---------------------------------------------

            string text5 = @"
{ serverSideLogger: ""jslogger"", 
  enabled:""false"",
  loggers: [
        {
            name: ""a.b"",
            level: ""INFO""
        },
        {
            appenders: ""ajaxAppender;consoleAppender""
        },
        {
            name: ""a2.b"",
            level: ""DEBUG"",
            onceOnlies: [ 
                { regex: ""regular expression"" },
                { regex: ""regular expression2"" }
            ]
        }
    ],

    ajaxAppenders: [
        { name: ""ajaxAppender1"", bufferSize: ""6"" },
        { name: ""ajaxAppender2"" }
    ],

    consoleAppenders: [
        { name: ""consoleAppender"", storeInBufferLevel: ""ERROR"" }
    ]
}
";

            //  maxMessages=""5""
            //  enabled=""true""


            JsnlogConfiguration options5 = DeserialiseJson<JsnlogConfiguration>(text5);

            // ---------------------------------------------


        }
    }
}
