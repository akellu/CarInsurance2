using System;
using AutomationFrame;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCases
{
    public class Base
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
            Pageload.OpenPage();
            Console.WriteLine("Page opens");
        }

        [TestCleanup]
        public void CleanUp()
        {
            Driver.WaitForNumberOfSeconds(3);
            Driver.Close();
        }
    }

}

