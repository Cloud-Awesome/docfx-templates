namespace SampleDocApi
{
    /// <summary>
    /// Here is an example of a basic interface
    /// </summary>
    public interface ITestClass
    {
        /// <summary>
        /// Here is a string that must be implemented in inheriting classes
        /// </summary>
        string ParentString { get; set; }

        /// <summary>
        /// Do something which returns an integer
        /// </summary>
        /// <param name="firstInt">This is the first number to input</param>
        /// <param name="secondInt">This is the second number to input</param>
        /// <returns>Returns a number which is the function of the two inputs</returns>
        int ReturnInteger(int firstInt, int secondInt);
    }
}