using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutomationFrame;


namespace TestCases
{
    [TestClass]
    public class NegativeCase : Base
    {
        [TestMethod]
        public void ErrorMessage()
        {
            CoverSection.Terms();
            CoverSection.Continue();
            Check.ErrorMessage();
        }

    }
}
