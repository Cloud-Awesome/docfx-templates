using System;

namespace SampleDocApi
{
    /// <summary>
    /// Here is a text class, to start off generation of some docs!
    /// </summary>
    /// <remarks>You can include all sorts of **markdown documentation** here</remarks>
    public class TestClass: ITestClass
    {
        /// <summary>
        /// This is a constructor for this TestClass. Use it to initiate an instance of this class!
        /// </summary>
        /// <param name="testString">This is a string, you can use it for alphanumeric content</param>
        /// <param name="testDateTime">Here is a datetime, to tell you when something...</param>
        /// <param name="testEnum">Consumes the <see cref="EnumTest"/> enum</param>
        /// <example>
        /// <para>Here is the incredibly complicated way of using this constructor</para>
        /// <code language="c#">
        /// var testClass = new TestClass("a string", new DateTime(), EnumTest.D);
        /// </code>
        /// </example>
        public TestClass(string testString, DateTime testDateTime, EnumTest testEnum)
        {
            TestString = testString;
            TestDateTime = testDateTime;
            TestEnum = testEnum;
        }
        
        /// <summary>
        /// This is a string, you can use it for alphanumeric content
        /// This doesn't explicitly appear in documentation because it's private
        /// </summary>
        private string TestString { get;  }
        
        /// <summary>
        /// Here is a datetime, to tell you when something...
        /// This doesn't explicitly appear in documentation because it's private 
        /// </summary>
        private DateTime TestDateTime { get; }
        
        /// <summary>
        /// Consumes the <see cref="EnumTest"/> enum. Can be changed at any time...
        /// </summary>
        public EnumTest TestEnum { get; set; }

        /// <summary>
        /// Something inherited from <see cref="ITestClass"/>
        /// </summary>
        public string ParentString { get; set; }

        /// <summary>
        /// Here's a public method consuming some private properties
        /// </summary>
        /// <returns>Returns a nice happy string</returns>
        public string DoSomethingWithInputs()
        {
            if (string.IsNullOrEmpty(TestString))
            {
                return string.Empty;
            }

            return TestDateTime.DayOfWeek == DayOfWeek.Friday ? 
                "Happy Friday!" : 
                "Here's a pointless string";
        }
        
        /// <summary>
        /// Something else inherited from <see cref="ITestClass"/> interface
        /// </summary>
        /// <param name="firstInt">An int input</param>
        /// <param name="secondInt">Another int input</param>
        /// <returns>An integer, when it's implemented, which it isn't yet</returns>
        /// <exception cref="NotImplementedException">Throws exception at present because it isn't implement! :O</exception>
        public int ReturnInteger(int firstInt, int secondInt)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Here is a test enum to start be consumed in the <see cref="TestClass"/>
    /// </summary>
    /// <remarks>**Avoid usage of this enum.** It likely will be deprecated as of v4.0</remarks>
    public enum EnumTest
    {
        /// <summary>
        /// First Letter of the alphabet
        /// </summary>
        A = 1, 
        /// <summary>
        /// Second Letter of the alphabet
        /// </summary>
        B, 
        /// <summary>
        /// Third Letter of the alphabet
        /// </summary>
        C, 
        /// <summary>
        /// Fourth Letter of the alphabet
        /// </summary>
        D, 
        /// <summary>
        /// Fifth Letter of the alphabet
        /// </summary>
        E, 
        /// <summary>
        /// Sixth Letter of the alphabet
        /// </summary>
        F, 
        /// <summary>
        /// Seventh Letter of the alphabet!
        /// </summary>
        G
    }
}