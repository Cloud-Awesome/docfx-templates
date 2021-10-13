namespace SampleDocApi
{
    /// <summary>
    /// This is a test Struct
    /// </summary>
    public readonly struct StructTest
    {
        /// <summary>
        /// Constructor for the Struct to set the two values
        /// </summary>
        /// <param name="boolValue">Either a true or a false</param>
        /// <param name="stringValue">Something with letters and numbers, maybe even some symbols</param>
        public StructTest(bool boolValue, string stringValue)
        {
            BoolValue = boolValue;
            StringValue = stringValue;
        }
        
        /// <summary>
        /// Either a true or a false
        /// </summary>
        public bool BoolValue { get; }
        
        /// <summary>
        /// Something with letters and numbers, maybe even some symbols
        /// </summary>
        public string StringValue { get; }
    }
}