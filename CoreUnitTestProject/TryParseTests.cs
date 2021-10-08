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
    public partial class TryParseTests : TestBase
    {
        /// <summary>
        /// Testing TryParse extension method on string to int
        /// </summary>
        [TestMethod]
        [TestTraits(Trait.TryParse)]
        public void IntParseTest()
        {

        }

        /// <summary>
        /// Testing TryParse extension method on string to DateTime
        /// </summary>
        [TestMethod]
        [TestTraits(Trait.TryParse)]
        public void DateTimeParseTest()
        {
            
        }
    }
}