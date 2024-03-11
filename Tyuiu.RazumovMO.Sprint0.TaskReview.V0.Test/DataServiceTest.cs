using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.RazumovMO.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.RazumovMO.Sprint0.TaskReview.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            Assert.AreEqual(65, DataService.Calc(5, 5, 3));
        }
    }
}
