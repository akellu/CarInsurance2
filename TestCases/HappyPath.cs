using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutomationFrame;

namespace TestCases
{
    [TestClass]
    public class HappyPath : Base
    {
        [TestMethod]
        public void OpenWeb()
        {
            AboutYourCar.Make("Hyundai");
            AboutYourCar.Model("Tucson");
            AboutYourCar.Year("2018");
            AboutYourCar.Series("TL3 MY19");
            AboutYourCar.Transmission("Manual");
            AboutYourCar.Fuel("Petrol");
            AboutYourCar.Colour("Blue");

            /*
            Select number for level of cover
            1 -- Comprehenssive
            2 -- Third Party Property, Fire and Theft
            3 -- Third Party Property Only
            */
            CoverSection.LevelOfCover(2);
            CoverSection.WhyCover("Looking");
            CoverSection.AntiTheft("Alarm");
            CoverSection.Options();
            CoverSection.NonStandard();
            CoverSection.Damage();
            CoverSection.Insured("No");
            CoverSection.Terms();
            CoverSection.Continue();

            Check.Passed();
        }
    }
}
