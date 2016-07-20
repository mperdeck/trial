using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using System.Diagnostics;

namespace UnitTestProject1
{
    [TestFixture]
    public class TestBase
    {
        public IWebDriver Driver
        {
            get; private set;
        }

        private Process _serverProcess;

        [SetUp]
        public void Init()
        {
            _serverProcess = Process.Start(new ProcessStartInfo
            {
                FileName = "dotnet",
                Arguments = "run",
                WorkingDirectory = jsnlogTestSiteProjectDirectory
            });


            // ################## start iisexpress here

            // ###### install on teamcity: iisexpress, sql server express, chrome


            //var executingAssembly = Assembly.GetExecutingAssembly();
            //var executingAssemblyLocation = executingAssembly.Location;
            //string assemblyFolder = Path.GetDirectoryName(executingAssemblyLocation);
            //string dependenciesFolder = Path.Combine(assemblyFolder, "IntegrationTests", "Dependencies");

            Driver = new ChromeDriver(dependenciesFolder);

        }

        [TearDown]
        public void Cleanup()
        {
            /* ... */
        }
    }
}
