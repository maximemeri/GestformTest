// <copyright file="GestformLibraryTest.cs" company="Maxime Merigeaux">
// Copyright (c) Maxime Merigeaux. All rights reserved.
// </copyright>

namespace GestformTest
{
    using System;
    using GestformLibrary;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Testing class for the gestform algorithm.
    /// </summary>
    [TestClass]
    public class GestformLibraryTest
    {
        /// <summary>
        /// Testing if the amount of values generated by the gestform algorithm
        /// is equal the size wanted as parameter.
        /// </summary>
        [TestMethod]
        public void DictionnaryCountTest()
        {
            Gestform myGestform = new Gestform(100);
            Assert.AreEqual(100, myGestform.GestformResults.Count);
        }

        /// <summary>
        /// Testing if the <see cref="ArgumentOutOfRangeException"/> is raised when using
        /// a negative integer as parameter.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void DictionnaryArgumentOutOfRangeTest()
        {
            _ = new Gestform(-100);
        }

        /// <summary>
        /// Testing if <see cref="Gestform.IsMultiple3"/> return true when passing
        /// a multiple of 3 as parameter.
        /// </summary>
        [TestMethod]
        public void IsMultiple3Test()
        {
            Gestform myGestform = new Gestform();
            Assert.IsTrue(myGestform.IsMultiple3(12));
        }

        /// <summary>
        /// Testing if <see cref="Gestform.IsMultiple3"/> return false when passing
        /// a non multiple of 3 as parameter.
        /// </summary>
        [TestMethod]
        public void IsNotMultiple3Test()
        {
            Gestform myGestform = new Gestform();
            Assert.IsFalse(myGestform.IsMultiple3(10));
        }

        /// <summary>
        /// Testing if <see cref="Gestform.IsMultiple5"/> return true when passing
        /// a multiple of 5 as parameter.
        /// </summary>
        [TestMethod]
        public void IsMultiple5Test()
        {
            Gestform myGestform = new Gestform();
            Assert.IsTrue(myGestform.IsMultiple5(15));
        }

        /// <summary>
        /// Testing if <see cref="Gestform.IsMultiple5"/> return false when passing
        /// a non multiple of 5 as parameter.
        /// </summary>
        [TestMethod]
        public void IsNotMultiple5Test()
        {
            Gestform myGestform = new Gestform();
            Assert.IsFalse(myGestform.IsMultiple5(-27));
        }

        /// <summary>
        /// Testing if <see cref="Gestform.CastIntToGestformValue"/> return "Geste"
        /// when passing a multiple of 3 as parameter.
        /// </summary>
        [TestMethod]
        public void GetGesteFromGestformValueTest()
        {
            Gestform myGestform = new Gestform();
            Assert.AreEqual("Geste", myGestform.CastIntToGestformValue(9));
        }

        /// <summary>
        /// Testing if <see cref="Gestform.CastIntToGestformValue"/> return "Forme"
        /// when passing a multiple of 3 as parameter.
        /// </summary>
        [TestMethod]
        public void GetFormeFromGestformValueTest()
        {
            Gestform myGestform = new Gestform();
            Assert.AreEqual("Forme", myGestform.CastIntToGestformValue(20));
        }

        /// <summary>
        /// Testing if <see cref="Gestform.CastIntToGestformValue"/> return "Gestform"
        /// when passing a multiple of 3 and 5 as parameter.
        /// </summary>
        [TestMethod]
        public void GetGestformFromGestformValueTest()
        {
            Gestform myGestform = new Gestform();
            Assert.AreEqual("Gestform", myGestform.CastIntToGestformValue(15));
        }

        /// <summary>
        /// Testing if <see cref="Gestform.CastIntToGestformValue"/> return the number
        /// when passing a non multiple of 3 and 5 as parameter.
        /// </summary>
        [TestMethod]
        public void GetNumberFromGestformValueTest()
        {
            Gestform myGestform = new Gestform();
            Assert.AreEqual("19", myGestform.CastIntToGestformValue(19));
        }
    }
}
