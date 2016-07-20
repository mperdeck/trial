using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

using System.Threading;
using System.Diagnostics;

namespace UnitTestProject1
{
    [SetUpFixture]
    public class MySetUpClass
    {
        [SetUp]
        public void RunBeforeAnyTests()
        {
//            Process cmdProcess = Process.Start("notepad", @"G:\temp\ccc.txt");
            Process cmdProcess = Process.Start("msbuild", @"/p:DeployOnBuild=true /p:PublishProfile=CTARS /P:Configuration=UITest C:\Dev\trial\CustomTemplates\WebApplication1.sln");


            //   CTARS.sln
            //           /p:DeployOnBuild = true
            //     /p:PublishProfile = CTARS
            // /P:Configuration = UITest



            while (!cmdProcess.HasExited)
            {
                Thread.Sleep(2000);
            }

            // Close process by sending a close message to its main window.
       //     cmdProcess.CloseMainWindow();
            // Free resources associated with process.
            cmdProcess.Close();
        }

        [TearDown]
        public void RunAfterAnyTests()
        {
            // ...
        }
    }
}

