using System;
using NUnit.Framework;

namespace SampleDocApi.Tests
{
    /// <summary>
    /// These are some extremely basic tests
    /// </summary>
    [TestFixture]
    public class SomeBasicTests
    {
        /// <summary>
        /// Given that something is true <br/>
        /// When it is asserted that it's true <br/>
        /// It should be true
        /// </summary>
        [Test]
        public void True_Should__Equal_True()
        {
            Assert.True(true);
        }

        /// <summary>
        /// Given that a boolean value is input <br/>
        ///   And an identical boolean value is expected <br/>
        /// When tested for equality <br/>
        /// They should be equal
        /// </summary>
        /// <param name="inputValue">True or false</param>
        /// <param name="expectedValue">The same value as the _inputValue_</param>
        [Test]
        [TestCase(true, true, Description = "Test for trues")]
        [TestCase(false, false, Description = "Test for falses")]
        [TestCase(null, null, Description = "Test for nulls")]
        public void Input_Booleans_Should_Assert_Their_Truthiness(bool inputValue, bool expectedValue)
        {
            Assert.AreEqual(inputValue, expectedValue);
        }
    }
}