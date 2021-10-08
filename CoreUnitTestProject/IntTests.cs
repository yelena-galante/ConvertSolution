using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ConverterLibrary.LanguageExtensions;
using CoreUnitTestProject.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreUnitTestProject
{
    /// <summary>
    /// 
    /// </summary>
    [TestClass]
    public partial class IntTests : TestBase
    {
        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        [TestTraits(Trait.Int)]
        public void PositiveToNegativeTest()
        {

        }

        [TestMethod]
        [TestTraits(Trait.Int)]
        public void IsPositive()
        {

        }

        [TestMethod]
        [TestTraits(Trait.Int)]
        public void IsNegative()
        {

        }

        [TestMethod]
        [TestTraits(Trait.Int)]
        public void IntToDecimalTest()
        {

        }

        [TestMethod]
        [TestTraits(Trait.Int)]
        public void IntToYesNoTest()
        {
 
        }

        /// <summary>
        /// These test pass but there is an issue, what is it?
        /// </summary>
        [TestMethod]
        [TestTraits(Trait.Int)]
        public void IntToYesNoFormattedTest()
        {

        }

        [TestMethod]
        [TestTraits(Trait.Int)]
        public void PercentDoneTest()
        {
            Dictionary<int, string> dictionary = new()
            {
                { 0, "" },
                { 2, "1%" },
                { 5, "4%" },
                { 15, "12%" },
                { 62, "50%" },
                { 95, "76%" },
                { 110, "88%" },
                { 125, "100%" }
            };

            dictionary.ToList().ForEach(kvp => 
                Assert.AreEqual(kvp.Key.PercentDone(125), kvp.Value));
            
        }

        /// <summary>
        /// Test against invalid values, in this case a negative value
        /// </summary>
        /// <remarks>
        /// See test in <see cref="DealingWithExceptionsTesting"/>
        /// </remarks>
        [TestMethod]
        [TestTraits(Trait.Int)]
        public void PercentDoneExceptionsTest()
        {

        }


        /// <summary>
        /// Test against invalid values, in this case a negative value
        /// NOTE: although this works the last test is the preferred method
        /// </summary>
        /// <remarks>
        /// See test in <see cref="DealingWithExceptionsTesting"/>
        /// </remarks>        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        [TestTraits(Trait.Int)]
        public void PercentDoneExceptionsDoneWrongTest()
        {
            
        }
    }
}

